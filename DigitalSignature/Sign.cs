using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DigitalSignature
{
    class Sign
    {
        public static byte[] DigitalSign { get; set; }
        //public static RSAParameters PublicKey { get; set; }
        //public static RSAParameters PrivateKey { get; set; }
        public static string PublicKey { get; set; }
        public static string PrivateKey { get; set; }


        public static void SignPDF(byte[] hashBuffer)
        {
            RSACryptoServiceProvider objRSA = new RSACryptoServiceProvider();

            //PrivateKey = objRSA.ExportParameters(true); // Private key
            //PublicKey = objRSA.ExportParameters(false); // Public key
            PrivateKey = objRSA.ToXmlString(true);
            PublicKey = objRSA.ToXmlString(false);

            DigitalSign = objRSA.SignHash(hashBuffer, "SHA256");
        }

        public static bool VaidateDigitalSign(byte[] hashBuffer , byte[] digitalSign, string publicKey)
        {
            RSACryptoServiceProvider objRSA = new RSACryptoServiceProvider();
            //objRSA.ImportParameters(publicKey);
            return objRSA.VerifyHash(hashBuffer, "SHA256", digitalSign);
        }
    }
}
