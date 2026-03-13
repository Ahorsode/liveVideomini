namespace liveVideos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.lstChat = new System.Windows.Forms.ListBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            
            // txtRoomName
            this.txtRoomName.Location = new System.Drawing.Point(12, 12);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(200, 23);
            this.txtRoomName.TabIndex = 0;
            this.txtRoomName.PlaceholderText = "Enter Room Name";
            
            // btnJoin
            this.btnJoin.Location = new System.Drawing.Point(218, 12);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 23);
            this.btnJoin.TabIndex = 1;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            
            // webView
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(12, 41);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(560, 397);
            this.webView.TabIndex = 2;
            this.webView.ZoomFactor = 1D;
            
            // lstChat
            this.lstChat.FormattingEnabled = true;
            this.lstChat.ItemHeight = 15;
            this.lstChat.Location = new System.Drawing.Point(587, 41);
            this.lstChat.Name = "lstChat";
            this.lstChat.Size = new System.Drawing.Size(201, 364);
            this.lstChat.TabIndex = 3;
            
            // txtMessage
            this.txtMessage.Location = new System.Drawing.Point(587, 415);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(120, 23);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.PlaceholderText = "Type message";
            
            // btnSend
            this.btnSend.Location = new System.Drawing.Point(713, 415);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lstChat);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.txtRoomName);
            this.Name = "Form1";
            this.Text = "Live Video Conferencing";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Button btnJoin;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.ListBox lstChat;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
    }
}
