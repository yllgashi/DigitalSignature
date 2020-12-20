using System.Security.Cryptography;

namespace DigitalSignature.Utils
{
    class Sign
    {
        public static string PublicKey { get; set; }

        public static byte[] SignPDF(byte[] hashBuffer, string hash)
        {
            RSACryptoServiceProvider objRSA = new RSACryptoServiceProvider();

            PublicKey = objRSA.ToXmlString(false);

            return objRSA.SignHash(hashBuffer, hash);
        }

        public static bool VaidateDigitalSign(byte[] hashBuffer, string hash, byte[] digitalSignFromTextBox, string publicKey)
        {
            RSACryptoServiceProvider objRSA = new RSACryptoServiceProvider();
            objRSA.FromXmlString(publicKey);  

            return objRSA.VerifyHash(hashBuffer, hash, digitalSignFromTextBox);
        }
    }
}
