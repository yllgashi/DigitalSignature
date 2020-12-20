using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace DigitalSignature.Utils
{
    class HASH
    {
        private static SHA256 Sha256 = SHA256.Create(); // HASH with SHA256 alg

        public static byte[] GeneratePDFHASH(string path, string hash)
        {
            FileStream stream = File.OpenRead(path);
            return ((HashAlgorithm)InvokeAHash(hash)).ComputeHash(stream);
        }


        public static List<string> GetAllHashNames() {
            var rez = new List<string>();
            GetAllHashType().ForEach(type => rez.Add(type.Name));
            return rez;
        }
        public static List<Type> GetAllHashType() {
            return typeof(HashAlgorithm).Assembly.GetTypes().Where(type => 
                type.BaseType != null && type.BaseType.Name.Equals(nameof(HashAlgorithm)) && 
                !type.Name.Equals("KeyedHashAlgorithm") &&
                !type.Name.Equals("RIPEMD160")).ToList();
        }

        public static object InvokeAHash(string hashName) {
            return GetAllHashType()
                .FirstOrDefault(type => type.Name.Equals(hashName))
                ?.GetMethods()
                .First(method => method.Name.Equals("Create") && method.GetParameters().Length < 1)
                .Invoke(null, null);
        } 
        public static void AddHashToComboBox(ComboBox comboBox) {
            var hashs = HASH.GetAllHashNames();
            foreach (var VARIABLE in hashs) {
                comboBox.Items.Add(VARIABLE);
            }
        }
    }
}
