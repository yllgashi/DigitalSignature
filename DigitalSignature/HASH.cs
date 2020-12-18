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
        private static SHA256 Sha256 = SHA256.Create(); // HASH with SHA256 alg

        public static byte[] GeneratePDFHASH(string path)
        {
            FileStream stream = File.OpenRead(path);
            return Sha256.ComputeHash(stream);
        }
    }
}
