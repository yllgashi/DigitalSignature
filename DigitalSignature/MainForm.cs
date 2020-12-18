using System;
using System.Windows.Forms;

namespace DigitalSignature {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void buttonSign_Click(object sender, EventArgs e) {
            this.Visible = false;
            CreateDigitalSignForm digitalSignForm = new CreateDigitalSignForm();
            digitalSignForm.Visible = true;
        }

        private void buttonValidate_Click(object sender, EventArgs e) {
            this.Visible = false;
            ValidateDigitalSignature validateDigitalSignature = new ValidateDigitalSignature();
            validateDigitalSignature.Visible = true;
        }
    }
}