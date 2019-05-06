using System.Windows.Forms;
using ZulipAPI;
using ZulipAPI.Streams;

namespace SampleApp.UserControls {
    public partial class UCStreams : UserControl {

        private StreamEndPoint streamEndPoint;
        public UCStreams() {
            InitializeComponent();
            ViewHelpers.DataGridViewHelper.SetDGVProperties(dgvStreams);
            btnGet.Click += btnGet_Click;
        }

        private async void btnGet_Click(object sender, System.EventArgs e) {
            await Program.GetZulipClient();
            streamEndPoint = streamEndPoint ?? Program.client.GetStreamEndPoint();
            try {
                var streams = await streamEndPoint.GetStreams();
                dgvStreams.DataSource = streams;
            } catch (System.Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
