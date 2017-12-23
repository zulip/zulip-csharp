using System.Windows.Forms;
using ZulipNetCore;

namespace SampleApp {
    public partial class UCUsers : UserControl {
        public UCUsers() {
            InitializeComponent();
            ViewHelpers.DataGridViewHelper.SetDGVProperties(dgvUsers);
            ToolTipsInit();
        }

        private void ToolTipsInit() {
            toolTip1.SetToolTip(this.txtZulipServerURL, "ie. 'myServer.zulipchat.com'");
            toolTip1.SetToolTip(this.txtUsername, "is the email address associated to your account on that server or a bot-name@yourzulipserver");
            toolTip1.SetToolTip(this.txtApiKey, "found under your profile Settings in your Zulip account");
        }

        private async void btnTestConnection_Click(object sender, System.EventArgs e) {
            ZulipServer ZuSrv = new ZulipServer(txtZulipServerURL.Text);
            ZulipAuthentication ZuAuth = new ZulipAuthentication(txtUsername.Text, txtApiKey.Text);
            ZulipClient zc = new ZulipClient(ZuSrv, ZuAuth);
            Users users = new Users(zc);
            try {
                await users.GetUsersAsync();
                dgvUsers.DataSource = users.UserCollection;
                txtResponse.Text = users.JsonOutput;
            } catch (System.Exception) {
                
            }
        }
    }
}
