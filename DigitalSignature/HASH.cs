using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace DigitalSignature
{
    class HASH
    {
        public static byte[] HASHBuffer { get; set; }
        private static SHA256 Sha256 = SHA256.Create(); // HASH with SHA256 alg


        public static void GeneratePDFHASH(string path)
        {
            FileStream stream = File.OpenRead(path);
            HASHBuffer = Sha256.ComputeHash(stream);
        }
    }
}
