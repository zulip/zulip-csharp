namespace SampleApp {
    partial class SampleApp {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.lnkZulipRCAuth = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZulipServerURL = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.userAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testConnectionToolStripMenuItem,
            this.streamsToolStripMenuItem,
            this.messagesToolStripMenuItem,
            this.userAdminToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // testConnectionToolStripMenuItem
            // 
            this.testConnectionToolStripMenuItem.Name = "testConnectionToolStripMenuItem";
            this.testConnectionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testConnectionToolStripMenuItem.Text = "Users";
            this.testConnectionToolStripMenuItem.Click += new System.EventHandler(this.UCUsersToolStripMenuItem_Click);
            // 
            // streamsToolStripMenuItem
            // 
            this.streamsToolStripMenuItem.Name = "streamsToolStripMenuItem";
            this.streamsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.streamsToolStripMenuItem.Text = "Streams";
            this.streamsToolStripMenuItem.Click += new System.EventHandler(this.streamsToolStripMenuItem_Click);
            // 
            // messagesToolStripMenuItem
            // 
            this.messagesToolStripMenuItem.Name = "messagesToolStripMenuItem";
            this.messagesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.messagesToolStripMenuItem.Text = "Messages";
            this.messagesToolStripMenuItem.Click += new System.EventHandler(this.messagesToolStripMenuItem_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 85);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(811, 411);
            this.panel_Main.TabIndex = 1;
            // 
            // panel_Login
            // 
            this.panel_Login.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_Login.Controls.Add(this.lnkZulipRCAuth);
            this.panel_Login.Controls.Add(this.label3);
            this.panel_Login.Controls.Add(this.txtUsername);
            this.panel_Login.Controls.Add(this.label1);
            this.panel_Login.Controls.Add(this.txtApiKey);
            this.panel_Login.Controls.Add(this.label2);
            this.panel_Login.Controls.Add(this.txtZulipServerURL);
            this.panel_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Login.Location = new System.Drawing.Point(0, 24);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(811, 61);
            this.panel_Login.TabIndex = 0;
            // 
            // lnkZulipRCAuth
            // 
            this.lnkZulipRCAuth.AutoSize = true;
            this.lnkZulipRCAuth.Location = new System.Drawing.Point(348, 40);
            this.lnkZulipRCAuth.Name = "lnkZulipRCAuth";
            this.lnkZulipRCAuth.Size = new System.Drawing.Size(149, 13);
            this.lnkZulipRCAuth.TabIndex = 8;
            this.lnkZulipRCAuth.TabStop = true;
            this.lnkZulipRCAuth.Text = "Authentication with .zuliprc file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zulip Server";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(101, 7);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(174, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "User name (email)";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(101, 33);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(174, 20);
            this.txtApiKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "API key";
            // 
            // txtZulipServerURL
            // 
            this.txtZulipServerURL.Location = new System.Drawing.Point(351, 7);
            this.txtZulipServerURL.Name = "txtZulipServerURL";
            this.txtZulipServerURL.Size = new System.Drawing.Size(174, 20);
            this.txtZulipServerURL.TabIndex = 4;
            // 
            // userAdminToolStripMenuItem
            // 
            this.userAdminToolStripMenuItem.Name = "userAdminToolStripMenuItem";
            this.userAdminToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userAdminToolStripMenuItem.Text = "User Admin";
            this.userAdminToolStripMenuItem.Click += new System.EventHandler(this.userAdminToolStripMenuItem_Click);
            // 
            // SampleApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 496);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SampleApp";
            this.Text = "Sample App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testConnectionToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.ToolStripMenuItem streamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messagesToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZulipServerURL;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel lnkZulipRCAuth;
        private System.Windows.Forms.ToolStripMenuItem userAdminToolStripMenuItem;
    }
}

