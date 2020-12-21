using System;
using System.Windows.Forms;

namespace DigitalSignature {
    public partial class MainForm : Form {
        private ToolTip toolTip; 
        public MainForm()
        {
            InitializeComponent();
            toolTip = new ToolTip();
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateDigitalSignForm digitalSignForm = new CreateDigitalSignForm();
            digitalSignForm.ShowDialog();
            this.Close();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            this.Hide();
            ValidateDigitalSignature validateDigitalSignature = new ValidateDigitalSignature();
            validateDigitalSignature.ShowDialog();
            this.Close();
        }
         
        private void buttonSign_MouseHover(object sender, EventArgs e) {
            toolTip.SetToolTip(buttonSign, "Sign Document");
        }

        private void buttonValidate_MouseHover(object sender, EventArgs e) {
            toolTip.SetToolTip(buttonValidate, "Validate Document");
        }
    }
}