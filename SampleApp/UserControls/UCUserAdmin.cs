using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using ZulipAPI;
using ZulipAPI.Users;

namespace SampleApp.UserControls {
    public partial class UCUserAdmin : UserControl {

        private UserEndPoint userEndPoint;

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
            userEndPoint = userEndPoint ?? Program.client.GetUserEndPoint();
            var user = new User(txtUserEmail.Text, txtUserPassword.Text, txtShortName.Text, txtFullName.Text); 
            await userEndPoint.CreateUser(user);
        }

        private void ChkActive_CheckedChanged(object sender, System.EventArgs e) {
            if (!FillingDataSource) ToggleActivateUser(chkActive.Checked);
        }

        private async void ToggleActivateUser(bool toggle) {
            if (cboUsers.SelectedValue != null) {
                try {
                    var SelectedUser = (User)cboUsers.SelectedItem;
                    switch (toggle) {
                        case true: await userEndPoint.ReactivateUser(SelectedUser);
                            break;
                        case false: await userEndPoint.DeactivateUser(SelectedUser);
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

        private bool FillingDataSource;
        private IList<User> _users;
        private async void LnkGetUsers_Click(object sender, System.EventArgs e) {
            await Program.GetZulipClient();
            FillingDataSource = true;
            try {
                userEndPoint = userEndPoint ?? Program.client.GetUserEndPoint();
                _users = await userEndPoint.GetUsers();
                cboUsers.DisplayMember = nameof(User.FullName);
                cboUsers.ValueMember = nameof(User.Email);
                cboUsers.DataSource = _users;
            } catch (System.Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            FillingDataSource = false;
        }

    }
}

