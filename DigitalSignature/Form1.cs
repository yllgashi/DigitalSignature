using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;


namespace DigitalSignature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Sign
        private void btnBrowsePDFPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (DialogResult.OK == openFile.ShowDialog())
            {
                txtPDFPath.Text = openFile.FileName;
            }
        }

        private void btnSignPDF_Click(object sender, EventArgs e)
        {
            // Generate HASH
            if (txtPDFPath.Text == "") MessageBox.Show("Empty text");
            else
            {
                HASH.GeneratePDFHASH(txtPDFPath.Text);
                txtHASH.Text = BitConverter.ToString(HASH.HASHBuffer);
            }

            // Create new PDF with digital sign
            Sign.SignPDF(HASH.HASHBuffer);
            txtDigitalSign.Text = Encoding.UTF8.GetString(Sign.DigitalSign);
            txtPublicKey.Text = Sign.PublicKey;
            txtPrivateKey.Text = Sign.PrivateKey;
        }
        #endregion

        #region Validate
        private void btnValidateBrowsePDFPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (DialogResult.OK == openFile.ShowDialog())
            {
                txtValidatePDFPath.Text = openFile.FileName;
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (txtValidatePDFPath.Text == "") MessageBox.Show("Empty text");
            else
            {
                // Generate HASH
                HASH.GeneratePDFHASH(txtValidatePDFPath.Text);

                // Validate
                byte[] digitalSignAsByte = Encoding.UTF8.GetBytes(txtValidateDigitalSign.Text);

                bool validate = Sign.VaidateDigitalSign(HASH.HASHBuffer, digitalSignAsByte,
                    txtValidatePublicKey.Text);
            }
        }
        #endregion
    }
}
