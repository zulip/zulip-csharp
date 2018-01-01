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
            lnkGetUsers.Click += LnkGetUsers_Click;
            cboUsers.SelectedValueChanged += CboUsers_SelectedValueChanged;
            chkActive.CheckedChanged += ChkActive_CheckedChanged;
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

        private void ChkActive_CheckedChanged(object sender, System.EventArgs e) {
            if (!FillingDataSource) ToggleActivateUser(chkActive.Checked);
        }

        private async void ToggleActivateUser(bool toggle) {
            if (cboUsers.SelectedValue != null) {
                try {
                    var SelectedUser = (User)cboUsers.SelectedItem;
                    switch (toggle) {
                        case true: await users.ReactivateUserAsync(SelectedUser.Email);
                            break;
                        case false: await users.DeactivateUserAsync(SelectedUser.Email);
                            break;
                    }
                } catch (System.Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void CboUsers_SelectedValueChanged(object sender, System.EventArgs e) {
            if (cboUsers.SelectedValue != null) {
                var SelectedUser = (User)cboUsers.SelectedItem;
                chkActive.Checked = SelectedUser.IsActive;
            }
        }

        private Users users;
        private bool FillingDataSource;
        private async void LnkGetUsers_Click(object sender, System.EventArgs e) {
            Program.GetZulipClient();
            FillingDataSource = true;
            try {
                users = new Users(Program.client);
                await users.GetUsersAsync();
                cboUsers.DisplayMember = nameof(User.FullName);
                cboUsers.ValueMember = nameof(User.Email);
                cboUsers.DataSource = users.UserCollection;
            } catch (System.Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            FillingDataSource = false;
        }

    }
}

