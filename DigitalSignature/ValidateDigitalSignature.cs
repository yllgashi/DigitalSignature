using System;
using System.IO;
using System.Windows.Forms;

namespace DigitalSignature {
    public partial class ValidateDigitalSignature : Form {
        public ValidateDigitalSignature() {
            InitializeComponent();
        }


        private void buttonOpenFile_Click(object sender, EventArgs e) {
            var dialog =  openFileDialog1.ShowDialog();

            if (dialog == DialogResult.OK)
                textBoxFile.Text = openFileDialog1.FileName;
        }

        private void buttonGetKeysFromFile_Click(object sender, EventArgs e) {
           var dialog =  openFileDialog1.ShowDialog();
           if (dialog == DialogResult.OK) {
               StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                    
               textBoxDigitalSignature.Text = streamReader.ReadLine().Remove(0, 20);
               MessageBox.Show(streamReader.Peek() + "");
               textBoxPublicKey.Text = streamReader.ReadLine().Remove(0, 20);
               
           }
        }

        private void buttonValidate_Click(object sender, EventArgs e) {
            var hashBuff = HASH.GeneratePDFHASH(textBoxFile.Text);
            if (!String.IsNullOrEmpty(textBoxDigitalSignature.Text)) {
                if (Sign.VaidateDigitalSign(hashBuff,
                    Convert.FromBase64String(textBoxDigitalSignature.Text), textBoxPublicKey.Text))
                    MessageBox.Show("Success");
                else {
                    MessageBox.Show("Digital signs dont match");
                }
            }
            else {
                MessageBox.Show("Please fill the digital signature and the public key first");
            }

        }

        private void buttonGoBack_Click(object sender, EventArgs e) {
            this.Visible = false;
            MainForm form1 = new MainForm();
            
            form1.Show();
        }
    }
}