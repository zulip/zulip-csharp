using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using ZulipAPI;
using ZulipAPI.Messages;
using ZulipAPI.Users;

namespace SampleApp {
    public partial class UCUsers : UserControl {

        private UserEndPoint userEndPoint;

        public UCUsers() {
            InitializeComponent();
            ViewHelpers.DataGridViewHelper.SetDGVProperties(dgvUsers);
        }


        private async void btnTestConnection_Click(object sender, System.EventArgs e) {
            await Program.GetZulipClient();
            userEndPoint = Program.client?.GetUserEndPoint();
            try {
                var users = await userEndPoint.GetUsers();
                dgvUsers.DataSource = users;
            } catch (System.Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
