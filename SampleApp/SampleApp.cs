using SampleApp.UserControls;
using System.Windows.Forms;

namespace SampleApp {
    public partial class SampleApp : Form {
        

        public SampleApp() {
            InitializeComponent();

            AddUserControl(new UCUsers());
        }

        private void AddUserControl(UserControl UC) {
            panel_Main.Controls.Clear();
            UC.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(UC);
        }

        private void UCUsersToolStripMenuItem_Click(object sender, System.EventArgs e) {
            AddUserControl(new UCUsers());
        }

        private void streamsToolStripMenuItem_Click(object sender, System.EventArgs e) {
            AddUserControl(new UCStreams());
        }
    }
}
