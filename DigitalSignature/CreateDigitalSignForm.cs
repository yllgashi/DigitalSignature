using System;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;

namespace DigitalSignature {
    public partial class CreateDigitalSignForm : Form {
        public CreateDigitalSignForm() {
            InitializeComponent();
        }


        private void buttonSelectFile_Click(object sender, EventArgs e) {
            var fileDialog = openFileDialog1.ShowDialog();
            if(fileDialog == DialogResult.OK && openFileDialog1.FileName.EndsWith(".pdf"))    
                textBoxSelectFile.Text = openFileDialog1.FileName;
            else {
                MessageBox.Show("Please select a pdf file");
            }
        }

        private void buttonGenerateDigitalSignature_Click(object sender, EventArgs e) {
            if(!String.IsNullOrEmpty(textBoxSelectFile.Text)) {
                byte[] hashBuffer;
                byte[] digitalSignature;
                hashBuffer = HASH.GeneratePDFHASH(textBoxSelectFile.Text);
                digitalSignature = Sign.SignPDF(hashBuffer);

                textBoxDigitalSignature.Text = Convert.ToBase64String(digitalSignature);
                textBoxPublicKey.Text = Sign.PublicKey;
            }
            else {
                MessageBox.Show("Please select a file first");
            }
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(textBoxDigitalSignature.Text)) {
                StreamWriter streamWriter = new StreamWriter("C:\\Users\\blend\\Desktop\\file.txt", true);
                streamWriter.Write("Digital Signature : " + textBoxDigitalSignature.Text + "\n");
                streamWriter.Write("Public Key        : " + textBoxPublicKey.Text);
                
                streamWriter.Close();

                MessageBox.Show("File saved succesfully");
                
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