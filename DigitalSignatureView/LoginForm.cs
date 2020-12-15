using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DigitalSignature.DataAccess;
using DigitalSignature.Models;
using DigitalSignature.Services;
using Message = DigitalSignature.Models.Message;

namespace DigitalSignatureView {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e) {
            this.Visible = false;
            new SignUpForm().Show();

        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(textBoxUserName.Text) &&
                !String.IsNullOrEmpty(textBoxPassword.Text)) {
                User user = UserServices.Get(textBoxUserName.Text, textBoxPassword.Text);
                if (user != null) {
                    this.Visible = false;
                    new MainForm(user).Show();
                } else 
                    MessageBox.Show("User does not exits");

            }
        }
    }
}