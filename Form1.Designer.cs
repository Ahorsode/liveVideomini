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
            topPanel = new Panel();
            btnJoin = new Button();
            txtRoomName = new TextBox();
            lblTitle = new Label();
            mainContainer = new Panel();
            splitContainer1 = new SplitContainer();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            lstChat = new ListBox();
            chatInputPanel = new Panel();
            txtMessage = new TextBox();
            btnSend = new Button();
            topPanel.SuspendLayout();
            mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            chatInputPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(45, 45, 48);
            topPanel.Controls.Add(btnJoin);
            topPanel.Controls.Add(txtRoomName);
            topPanel.Controls.Add(lblTitle);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1200, 70);
            topPanel.TabIndex = 0;
            // 
            // btnJoin
            // 
            btnJoin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnJoin.BackColor = Color.FromArgb(0, 122, 204);
            btnJoin.Cursor = Cursors.Hand;
            btnJoin.FlatAppearance.BorderSize = 0;
            btnJoin.FlatStyle = FlatStyle.Flat;
            btnJoin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnJoin.Location = new Point(1075, 18);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(100, 36);
            btnJoin.TabIndex = 2;
            btnJoin.Text = "JOIN";
            btnJoin.UseVisualStyleBackColor = false;
            btnJoin.Click += btnJoin_Click;
            // 
            // txtRoomName
            // 
            txtRoomName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtRoomName.BackColor = Color.FromArgb(60, 60, 60);
            txtRoomName.BorderStyle = BorderStyle.FixedSingle;
            txtRoomName.Font = new Font("Segoe UI", 12F);
            txtRoomName.ForeColor = Color.White;
            txtRoomName.Location = new Point(820, 19);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.PlaceholderText = "   Enter Room Name...";
            txtRoomName.Size = new Size(240, 34);
            txtRoomName.TabIndex = 1;
            txtRoomName.TextChanged += txtRoomName_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semilight", 16.2F);
            lblTitle.Location = new Point(20, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(170, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "LiveClass Pro";
            // 
            // mainContainer
            // 
            mainContainer.Controls.Add(splitContainer1);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 70);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(10);
            mainContainer.Size = new Size(1200, 630);
            mainContainer.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(10, 10);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(webView);
            splitContainer1.Panel1.Padding = new Padding(0, 0, 5, 0);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lstChat);
            splitContainer1.Panel2.Controls.Add(chatInputPanel);
            splitContainer1.Panel2.Padding = new Padding(5, 0, 0, 0);
            splitContainer1.Size = new Size(1180, 610);
            splitContainer1.SplitterDistance = 850;
            splitContainer1.SplitterWidth = 8;
            splitContainer1.TabIndex = 0;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.FromArgb(30, 30, 30);
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(0, 0);
            webView.Name = "webView";
            webView.Size = new Size(845, 610);
            webView.TabIndex = 0;
            webView.ZoomFactor = 1D;
            // 
            // lstChat
            // 
            lstChat.BackColor = Color.FromArgb(30, 30, 30);
            lstChat.BorderStyle = BorderStyle.None;
            lstChat.Dock = DockStyle.Fill;
            lstChat.Font = new Font("Segoe UI", 10.8F);
            lstChat.ForeColor = Color.FromArgb(224, 224, 224);
            lstChat.FormattingEnabled = true;
            lstChat.Location = new Point(5, 0);
            lstChat.Name = "lstChat";
            lstChat.Size = new Size(317, 540);
            lstChat.TabIndex = 0;
            // 
            // chatInputPanel
            // 
            chatInputPanel.BackColor = Color.FromArgb(45, 45, 48);
            chatInputPanel.Controls.Add(txtMessage);
            chatInputPanel.Controls.Add(btnSend);
            chatInputPanel.Dock = DockStyle.Bottom;
            chatInputPanel.Location = new Point(5, 540);
            chatInputPanel.Name = "chatInputPanel";
            chatInputPanel.Padding = new Padding(10);
            chatInputPanel.Size = new Size(317, 70);
            chatInputPanel.TabIndex = 1;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.FromArgb(60, 60, 60);
            txtMessage.BorderStyle = BorderStyle.FixedSingle;
            txtMessage.Dock = DockStyle.Fill;
            txtMessage.Font = new Font("Segoe UI", 12F);
            txtMessage.ForeColor = Color.White;
            txtMessage.Location = new Point(10, 10);
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = " Type a message...";
            txtMessage.Size = new Size(217, 34);
            txtMessage.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(0, 122, 204);
            btnSend.Cursor = Cursors.Hand;
            btnSend.Dock = DockStyle.Right;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSend.Location = new Point(227, 10);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(80, 50);
            btnSend.TabIndex = 1;
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1200, 700);
            Controls.Add(mainContainer);
            Controls.Add(topPanel);
            Font = new Font("Segoe UI", 10.2F);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "LiveClass Pro - Video Conferencing";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            mainContainer.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            chatInputPanel.ResumeLayout(false);
            chatInputPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Button btnJoin;
        
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        
        private System.Windows.Forms.ListBox lstChat;
        private System.Windows.Forms.Panel chatInputPanel;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
    }
}
