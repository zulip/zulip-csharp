using System.Windows.Forms;

namespace SampleApp {
    public partial class SampleApp : Form {
        

        public SampleApp() {
            InitializeComponent();

            AddUserControl(new UCTestConnection());
        }

        private void AddUserControl(UserControl UC) {
            panel_Main.Controls.Clear();
            UC.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(UC);
        }
    }
}
