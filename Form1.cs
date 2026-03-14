using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Web.WebView2.Core;

namespace liveVideos
{
    public partial class Form1 : Form
    {
        private HubConnection? _hubConnection;
        private string serverIP = "http://10.156.224.5:5000/chathub";

        public Form1()
        {
            InitializeComponent();
            InitializeWebViewAsync();
            _ = ConnectToSignalRAsync();
        }

        private async void InitializeWebViewAsync()
        {
            await webView.EnsureCoreWebView2Async(null);
            if (webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.PermissionRequested += CoreWebView2_PermissionRequested;
            }
        }

        private void CoreWebView2_PermissionRequested(object? sender, CoreWebView2PermissionRequestedEventArgs e)
        {
            if (e.PermissionKind == CoreWebView2PermissionKind.Camera || 
                e.PermissionKind == CoreWebView2PermissionKind.Microphone)
            {
                e.State = CoreWebView2PermissionState.Allow;
            }
        }

        private async Task ConnectToSignalRAsync()
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl(serverIP)
                .WithAutomaticReconnect()
                .Build();

            _hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                Invoke((Action)(() =>
                {
                    lstChat.Items.Add($"{user}: {message}");
                    lstChat.TopIndex = lstChat.Items.Count - 1;
                }));
            });

            _hubConnection.On<string>("ReceiveWhiteboardUpdate", (data) =>
            {
                // Implement whiteboard rendering logic here
            });

            try
            {
                await _hubConnection.StartAsync();
                lstChat.Items.Add("System: Successfully connected to the Server!");
            }
            catch (Exception ex)
            {
                lstChat.Items.Add($"System: Failed to connect to server.");
                lstChat.Items.Add($"Error: {ex.Message}");
            }
        }

        private async void btnJoin_Click(object sender, EventArgs e)
        {
            string roomName = txtRoomName.Text.Trim();

            if (string.IsNullOrEmpty(roomName))
            {
                MessageBox.Show("Please enter a Room Name first.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string jitsiUrl = $"https://meet.jit.si/{Uri.EscapeDataString(roomName)}";
            if (webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(jitsiUrl);
            }

            if (_hubConnection != null && _hubConnection.State == HubConnectionState.Connected)
            {
                try
                {
                    await _hubConnection.InvokeAsync("JoinRoom", roomName);
                    lstChat.Items.Add($"System: You have joined room '{roomName}'.");
                }
                catch (Exception ex)
                {
                    lstChat.Items.Add($"System: Error joining room. {ex.Message}");
                }
            }
            else
            {
                lstChat.Items.Add("System: Cannot join room; disconnected.");
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (_hubConnection != null && _hubConnection.State == HubConnectionState.Connected)
            {
                string message = txtMessage.Text.Trim();
                if (!string.IsNullOrEmpty(message))
                {
                    try
                    {
                        await _hubConnection.InvokeAsync("SendMessage", "Student", message);
                        txtMessage.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error sending message: {ex.Message}");
                    }
                }
            }
        }

        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
