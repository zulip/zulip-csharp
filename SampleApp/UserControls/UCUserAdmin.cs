using System.Windows.Forms;
using ZulipAPI;

namespace SampleApp.UserControls {
    public partial class UCUserAdmin : UserControl {

        public UCUserAdmin() {
            InitializeComponent();
            AddHandlers();
            InitControls();

        }

        private void AddHandlers() {
            btnCreateUser.Click += BtnCreateUser_Click;
        }

        private void InitControls() {
            txtFullName.Text = "Test User2";
            txtShortName.Text = "Test User2";
            txtUserEmail.Text = "testuser2@example.com";
            txtUserPassword.Text = "password123";
        }

        private async void BtnCreateUser_Click(object sender, System.EventArgs e) {
            var u = new Users(Program.client);
            await u.CreateUserAsync(txtUserEmail.Text, txtFullName.Text, txtUserPassword.Text, txtShortName.Text);
        }

    }
}

