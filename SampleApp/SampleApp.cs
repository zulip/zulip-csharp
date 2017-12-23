using SampleApp.UserControls;
using System.Windows.Forms;

namespace SampleApp {
    public partial class SampleApp : Form {


        public SampleApp() {
            InitializeComponent();
            ToolTipsInit();
            AddHandlers();
        }

            AddUserControl(new UCUsers());
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
        }

        private void UCUsersToolStripMenuItem_Click(object sender, System.EventArgs e) {
            AddUserControl(new UCUsers());
        }

        private void streamsToolStripMenuItem_Click(object sender, System.EventArgs e) {
            AddUserControl(new UCStreams());
        }

        private void txtLogin_TextChanged(object sender, System.EventArgs e) {
            Program.ServerURL = txtZulipServerURL.Text;
            Program.UserEmail = txtUsername.Text;
            Program.UserSecret = txtApiKey.Text;
        }
    }
}
