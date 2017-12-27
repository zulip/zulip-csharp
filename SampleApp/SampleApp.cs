using System;
using ZulipNetCore;
using System.IO;
using SampleApp.UserControls;
using System.Windows.Forms;

namespace SampleApp {
    public partial class SampleApp : Form {


        public SampleApp() {
            InitializeComponent();
            ToolTipsInit();
            AddHandlers();
            ZulipRCLogin(AutoLogin:true);
            AddUserControl(new UCMessages());
        }

        private void ToolTipsInit() {
            toolTip1.SetToolTip(this.txtZulipServerURL, "ie. 'myServer.zulipchat.com'");
            toolTip1.SetToolTip(this.txtUsername, "is the email address associated to your account on that server or a bot-name@yourzulipserver");
            toolTip1.SetToolTip(this.txtApiKey, "found under your profile Settings in your Zulip account");
        }

        private void AddUserControl(UserControl UC) {
            panel_Main.Controls.Clear();
            UC.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(UC);
        }

        private void AddHandlers() {
            txtZulipServerURL.TextChanged += txtLogin_TextChanged;
            txtUsername.TextChanged += txtLogin_TextChanged;
            txtApiKey.TextChanged += txtLogin_TextChanged;
            lnkZulipRCAuth.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkZulipRCAuth_LinkClicked);
        }

        private void UCUsersToolStripMenuItem_Click(object sender, System.EventArgs e) {
            AddUserControl(new UCUsers());
        }

        private void streamsToolStripMenuItem_Click(object sender, System.EventArgs e) {
            AddUserControl(new UCStreams());
        }

        private void messagesToolStripMenuItem_Click(object sender, System.EventArgs e) {
            AddUserControl(new UCMessages());
        }

        private void txtLogin_TextChanged(object sender, System.EventArgs e) {
            Program.ServerURL = txtZulipServerURL.Text;
            Program.UserEmail = txtUsername.Text;
            Program.UserSecret = txtApiKey.Text;
        }

        private void ZulipRCLogin(bool AutoLogin = false) {
            string AppPath = Path.GetDirectoryName(Application.ExecutablePath);
            string defZulipRCPath = Path.Combine(AppPath, ".zuliprc");
            string HomePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".zuliprc");

            // .zuliprc is in the same folder as the SampleApp.exe
            if (File.Exists(defZulipRCPath)) {
                Program.GetZulipClient(defZulipRCPath);
            // .zuliprc is in folder %HOMEPATH%
            } else if (File.Exists(HomePath)) {
                Program.GetZulipClient(HomePath);
            // if not found in the above open dialog
            } else {
                // only when Autologin is true the OpenFileDialog will show up, which is not desired at application startup
                if (!AutoLogin) {
                    var ofd = new OpenFileDialog();
                    DialogResult result = ofd.ShowDialog();
                    if (result == DialogResult.OK) {// Test result.
                        try {
                            Program.GetZulipClient(ofd.FileName);
                        } catch (System.Exception ex) {
                            MessageBox.Show(ex.StackTrace + "\r\n" + ex.Message);
                        }
                    }
                }
            }

            if (Program.client != null) {
                txtZulipServerURL.Text = Program.client.Server.ServerBaseURL;
                txtUsername.Text = Program.client.Authentication.UserEmail;
                txtApiKey.Text = Program.client.Authentication.UserSecret;
            }
        }

        private void lnkZulipRCAuth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ZulipRCLogin();
        }
    }
}
