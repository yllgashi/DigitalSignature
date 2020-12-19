using System.Security.Cryptography;

namespace DigitalSignature.Utils
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
