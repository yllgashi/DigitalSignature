using System;
using System.IO;
using System.Windows.Forms;
using DigitalSignature.Utils;

namespace DigitalSignature {
    public partial class ValidateDigitalSignature : Form {
        public ValidateDigitalSignature() {
            InitializeComponent();
        }


        private void buttonOpenFile_Click(object sender, EventArgs e) {
            string file = FileService.OpenFile(openFileDialog1, "*");
            if (file != null)
                textBoxFile.Text = file;
        }

        private void buttonGetKeysFromFile_Click(object sender, EventArgs e) {
            string file = FileService.OpenFile(openFileDialog1, "txt");

            if (!String.IsNullOrEmpty(file)) {
                string[] data = FileService.GetPKeyAndSignatureFromFile(file, 20);
                if (data != null) {
                    textBoxDigitalSignature.Text = data[0];
                    textBoxPublicKey.Text = data[1];
                }
                else {
                    MessageBox.Show("File is not in the right format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void buttonValidate_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(textBoxFile.Text)) {
                if (!String.IsNullOrEmpty(textBoxDigitalSignature.Text) &&
                    !String.IsNullOrEmpty(textBoxPublicKey.Text)) {
                    var hashBuff = HASH.GeneratePDFHASH(textBoxFile.Text);
                    try {
                        if (Sign.VaidateDigitalSign(hashBuff,
                            Convert.FromBase64String(textBoxDigitalSignature.Text), textBoxPublicKey.Text))
                            MessageBox.Show("Success");
                        else {
                            MessageBox.Show("Digital signs dont match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception) {
                        MessageBox.Show("Digital Key is not in the right format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("Please fill the digital signature and the public key first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Please select a file first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form1 = new MainForm();
            form1.ShowDialog();
            this.Close();
        }
    }
}