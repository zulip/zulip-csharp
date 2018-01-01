namespace SampleApp.UserControls {
    partial class UCUserAdmin {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.lnkGetUsers = new System.Windows.Forms.LinkLabel();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Email";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(107, 13);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(155, 20);
            this.txtUserEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Password";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(107, 39);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(155, 20);
            this.txtUserPassword.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Full Name";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(107, 65);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(155, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Short Name";
            // 
            // txtShortName
            // 
            this.txtShortName.Location = new System.Drawing.Point(107, 91);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(155, 20);
            this.txtShortName.TabIndex = 1;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(187, 117);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(75, 23);
            this.btnCreateUser.TabIndex = 2;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            // 
            // lnkGetUsers
            // 
            this.lnkGetUsers.AutoSize = true;
            this.lnkGetUsers.Location = new System.Drawing.Point(10, 151);
            this.lnkGetUsers.Name = "lnkGetUsers";
            this.lnkGetUsers.Size = new System.Drawing.Size(54, 13);
            this.lnkGetUsers.TabIndex = 3;
            this.lnkGetUsers.TabStop = true;
            this.lnkGetUsers.Text = "Get Users";
            // 
            // cboUsers
            // 
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(107, 148);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(155, 21);
            this.cboUsers.TabIndex = 4;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(268, 150);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(55, 17);
            this.chkActive.TabIndex = 5;
            this.chkActive.Text = "active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // UCUserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.cboUsers);
            this.Controls.Add(this.lnkGetUsers);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.txtShortName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.label1);
            this.Name = "UCUserAdmin";
            this.Size = new System.Drawing.Size(738, 447);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.LinkLabel lnkGetUsers;
        private System.Windows.Forms.ComboBox cboUsers;
        private System.Windows.Forms.CheckBox chkActive;
    }
}
