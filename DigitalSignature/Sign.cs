using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace DigitalSignature
{
    class Sign
    {
        public static string PublicKey { get; set; }

        public static byte[] SignPDF(byte[] hashBuffer)
        {
            RSACryptoServiceProvider objRSA = new RSACryptoServiceProvider();

            PublicKey = objRSA.ToXmlString(false);

            return objRSA.SignHash(hashBuffer, "SHA256");
        }

        public static bool VaidateDigitalSign(byte[] hashBuffer, byte[] digitalSignFromTextBox, string publicKey)
        {
            RSACryptoServiceProvider objRSA = new RSACryptoServiceProvider();
            objRSA.FromXmlString(publicKey);  

            return objRSA.VerifyHash(hashBuffer, "SHA256", digitalSignFromTextBox);
        }
    }
}
