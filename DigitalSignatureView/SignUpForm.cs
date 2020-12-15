using System;
using System.Windows.Forms;
using DigitalSignature.DataAccess;
using DigitalSignature.Services;
using Message = DigitalSignature.Models.Message;

namespace DigitalSignatureView {
    public partial class SignUpForm : Form {
        public SignUpForm() {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e) {
            this.Visible = false;
            new LoginForm().Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e) {
            if(!String.IsNullOrEmpty(textBoxName.Text) && 
               !String.IsNullOrEmpty(textBoxLastName.Text) && 
               !String.IsNullOrEmpty(textBoxUserName.Text) && 
               !String.IsNullOrEmpty(textBoxPassword.Text)) {
                
                if (
                    UserServices.Add(textBoxName.Text, textBoxLastName.Text, textBoxUserName.Text,
                        textBoxPassword.Text))
                    MessageBox.Show("User Added succesfully");
                else {
                    MessageBox.Show("User already exist");
                }
            }
            else 
                MessageBox.Show("Please fill all boxes");
            
        }
    }
}