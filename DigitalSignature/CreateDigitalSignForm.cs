using System;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;
using DigitalSignature.Utils;

namespace DigitalSignature {
    public partial class CreateDigitalSignForm : Form {
        public CreateDigitalSignForm() {
            InitializeComponent();
        }


        private void buttonSelectFile_Click(object sender, EventArgs e) { 
            string file = FileService.OpenFile(openFileDialog1, "pdf");
            if (file != null && file.EndsWith("pdf"))
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
                    MessageBox.Show("Digital Signature is not in the right format");
                }
            }
            else {
                MessageBox.Show("Please select a file first");
            }
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e) {
            
            if (!String.IsNullOrEmpty(textBoxDigitalSignature.Text)) {
                if (FileService.SavePKeyAndSignatureInFile(openFileDialog1.FileName, "txt",textBoxPublicKey.Text,
                    textBoxDigitalSignature.Text)) {
                    
                    MessageBox.Show("File saved succesfully");
                }
                else {
                    //MessageBox.Show("File dose")
                }
                
                
            }
            else {
                MessageBox.Show("Please generate Digital Signature first");
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e) {
            this.Visible = false;
            MainForm form1 = new MainForm();
            form1.Visible = true;
        }
    }
}