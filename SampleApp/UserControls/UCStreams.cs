using System.Windows.Forms;
using ZulipNetCore;

namespace SampleApp.UserControls {
    public partial class UCStreams : UserControl {

        public UCStreams() {
            InitializeComponent();
            ViewHelpers.DataGridViewHelper.SetDGVProperties(dgvStreams);
            btnGet.Click += btnGet_Click;
        }

        private async void btnGet_Click(object sender, System.EventArgs e) {
            Program.GetZulipClient();
            Streams streams = new Streams(Program.client);
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
