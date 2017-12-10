using System.Windows.Forms;

namespace SampleApp {
    public partial class UCTestConnection : UserControl {
        public UCTestConnection() {
            InitializeComponent();

            ToolTipsInit();
        }

        private void ToolTipsInit() {
            toolTip1.SetToolTip(this.txtZulipServerURL, "ie. 'myServer.zulipchat.com'");
            toolTip1.SetToolTip(this.txtUsername, "is the email address associated to your account on that server or a bot-name@yourzulipserver");
            toolTip1.SetToolTip(this.txtApiKey, "found under your profile Settings in your Zulip account");
        }

        private void btnTestConnection_Click(object sender, System.EventArgs e) {
            txtResponse.Text = "not doing anything yet";
        }
    }
}
