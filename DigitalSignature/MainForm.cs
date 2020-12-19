using System;
using System.Windows.Forms;

namespace DigitalSignature {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void buttonSign_Click(object sender, EventArgs e) {
            this.Hide();
            CreateDigitalSignForm digitalSignForm = new CreateDigitalSignForm();
            digitalSignForm.ShowDialog();
            this.Close();
        }

        private void buttonValidate_Click(object sender, EventArgs e) {
            this.Hide();
            ValidateDigitalSignature validateDigitalSignature = new ValidateDigitalSignature();
            validateDigitalSignature.ShowDialog();
            this.Close();

            //Application.Exit();
            //Application.Run(new ValidateDigitalSignature());
        }
    }
}