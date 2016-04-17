using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    //filestream
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace NSEGUI
{
    class Decryption
    {
        string password;
        string outputPath;
        string inputPath;
        public Decryption(string pass, string inp, string output)
        {
            inputPath = inp;
            password = pass;
            outputPath = output;
        }

        private PasswordDeriveBytes passwordCrunch(string password)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
                0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            return pdb;
        }

        public void des()
        {
            Console.WriteLine("Dec DES");
        }

        public void rc2()
        {
            Console.WriteLine("Dec RC2");
        }

        public void rijndael()
        {
            Console.WriteLine("Dec Rijn");
            //try
            //{
                PasswordDeriveBytes pdb = passwordCrunch(password);

                FileStream fsCrypt = new FileStream(inputPath, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();
                RMCrypto.Padding = PaddingMode.Zeros;

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateDecryptor(pdb.GetBytes(32), pdb.GetBytes(16)), CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputPath, FileMode.Create);

                int data;
                while ((data = fsOut.ReadByte()) != -1) fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();
            /*}
            catch
            {
                Console.WriteLine("Decryption Failed");
            }*/
        }

        public void tripledes()
        {
            Console.WriteLine("Dec 3DES");
        }
    }
}
