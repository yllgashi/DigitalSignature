using System;
using System.IO;
using System.Windows.Forms;

namespace DigitalSignature.Utils {
    public class FileService {

        public static string OpenFile(OpenFileDialog openFileDialog, string fileType) {
            openFileDialog.FileName = "";
            if (fileType.Equals("*"))
                openFileDialog.Filter = $"All files (*.*)|*.*";
            else
                openFileDialog.Filter = $"{fileType} files (*.{fileType})|*.{fileType}";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                return openFileDialog.FileName;
            }

            return null;
        }



        public static string[] GetPKeyAndSignatureFromFile(string path, int startingPoint) {
            string[] rez = new string[2];
            
            StreamReader streamReader = new StreamReader(path);
            try {
                for (int i = 0; i < rez.Length; i++) {
                    rez[i] = streamReader.ReadLine();
                    //MessageBox.Show(rez[i]);
                    if (rez[i].Contains("Digital Signature") || rez[i].Contains("Public Key")) {
                        rez[i] = rez[i].Remove(0, startingPoint);
                    }
                    else {
                        return null;
                    }
                }
            }
            catch (Exception) {
                return null;
            }

            return rez;
        }

        public static bool SavePKeyAndSignatureInFile(string path, string fileType,string publicKey, string digitalSignature) {
            try {
                StreamWriter streamWriter = new StreamWriter($"{Path.GetDirectoryName(path)}\\SignatureAndPublicKey.{fileType}");
                    
                streamWriter.Write("Digital Signature : " + digitalSignature + "\n");
                streamWriter.Write("Public Key        : " + publicKey);
                streamWriter.Close();
                return true;
            }
            catch (Exception) {
                return false;
            }
        }
        
    }
}