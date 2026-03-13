using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task JoinRoom(string roomName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, roomName);
            await Clients.Group(roomName).SendAsync("ReceiveMessage", "System", $"A new user joined {roomName}.");
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task UpdateWhiteboard(string data)
        {
            await Clients.Others.SendAsync("ReceiveWhiteboardUpdate", data);
        }
    }
}
