using System.Windows.Forms;
using ZulipNetCore;

namespace SampleApp.UserControls {
    public partial class UCStreams : UserControl {

        public UCStreams() {
            InitializeComponent();
            ViewHelpers.DataGridViewHelper.SetDGVProperties(dgvStreams);
            ToolTipsInit();
            btnGet.Click += btnGet_Click;
        }

        private void ToolTipsInit() {
            toolTip1.SetToolTip(this.txtZulipServerURL, "ie. 'myServer.zulipchat.com'");
            toolTip1.SetToolTip(this.txtUsername, "is the email address associated to your account on that server or a bot-name@yourzulipserver");
            toolTip1.SetToolTip(this.txtApiKey, "found under your profile Settings in your Zulip account");
        }

        private async void btnGet_Click(object sender, System.EventArgs e) {
            ZulipServer ZuSrv = new ZulipServer(txtZulipServerURL.Text);
            ZulipAuthentication ZuAuth = new ZulipAuthentication(txtUsername.Text, txtApiKey.Text);
            ZulipClient zc = new ZulipClient(ZuSrv, ZuAuth);
            Streams streams = new Streams(zc);
            try {
                await streams.GetStreamsAsync();
                dgvStreams.DataSource = streams.StreamCollection;
                txtResponse.Text = streams.JsonOutput;
            } catch (System.Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
