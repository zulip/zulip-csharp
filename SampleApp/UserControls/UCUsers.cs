using System.Windows.Forms;
using ZulipAPI;

namespace SampleApp {
    public partial class UCUsers : UserControl {
        public UCUsers() {
            InitializeComponent();
            ViewHelpers.DataGridViewHelper.SetDGVProperties(dgvUsers);
        }

        private async void btnTestConnection_Click(object sender, System.EventArgs e) {
            Program.GetZulipClient();
            Users users = new Users(Program.client);
            try {
                await users.GetUsersAsync();
                dgvUsers.DataSource = users.UserCollection;
                txtResponse.Text = users.JsonOutput;
            } catch (System.Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
