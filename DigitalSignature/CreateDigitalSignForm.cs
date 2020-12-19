using System;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;
using DigitalSignature.Utils;

namespace DigitalSignature {
    public partial class CreateDigitalSignForm : Form {
        ToolTip toolTip;
        public CreateDigitalSignForm() {
            InitializeComponent();
            toolTip = new ToolTip();
        }


        private void buttonSelectFile_Click(object sender, EventArgs e) { 
            string file = FileService.OpenFile(openFileDialog1, "*");
            if (file != null)
                textBoxSelectFile.Text = file;
        }

        private void buttonGenerateDigitalSignature_Click(object sender, EventArgs e) {
            if(!String.IsNullOrEmpty(textBoxSelectFile.Text)) {
                byte[] hashBuffer;
                byte[] digitalSignature;
                hashBuffer = HASH.GeneratePDFHASH(textBoxSelectFile.Text);
                digitalSignature = Sign.SignPDF(hashBuffer);
                try {
                    textBoxDigitalSignature.Text = Convert.ToBase64String(digitalSignature);
                    textBoxPublicKey.Text = Sign.PublicKey;
                }
                catch (Exception) {
                    MessageBox.Show("Digital Signature is not in the right format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Please select a file first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e) {
            
            if (!String.IsNullOrEmpty(textBoxDigitalSignature.Text)) {
                if (FileService.SavePKeyAndSignatureInFile(openFileDialog1.FileName, "txt",textBoxPublicKey.Text,
                    textBoxDigitalSignature.Text)) {
                    
                    MessageBox.Show("File saved succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    //MessageBox.Show("File dose")
                }
                
                
            }
            else {
                MessageBox.Show("Please generate Digital Signature and Public Key first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e) {
            this.Hide();
            MainForm form1 = new MainForm();
            form1.ShowDialog();
            this.Close();
        }

        private void buttonSelectFile_MouseHover(object sender, EventArgs e) {
            toolTip.SetToolTip(buttonSelectFile, "Open File");
        }

        private void buttonGoBack_MouseHover(object sender, EventArgs e) {
            toolTip.SetToolTip(buttonGoBack, "Go Back");
        }

        private void buttonSaveToFile_MouseHover(object sender, EventArgs e) {
            toolTip.SetToolTip(buttonSaveToFile, "Save to File");
        }

        private void buttonGenerateDigitalSignature_MouseHover(object sender, EventArgs e) {
            toolTip.SetToolTip(buttonGenerateDigitalSignature, "Generate Digital Signature");
        }
    }
}