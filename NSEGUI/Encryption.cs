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
    class Encryption
    {
        string password;
        string outputPath;
        string inputPath;
        public Encryption(string pass, string inp, string output)
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
            Console.WriteLine("Enc DES w/ pass: " + password);
            try
            {

            }
            catch
            {
                Console.WriteLine("Encryption failed!", "Error");
            }
        }

        public void rc2()
        {
            Console.WriteLine("Enc RC2");
        }

        public void rijndael()
        {
            Console.WriteLine("Enc Rijn w/ pass: " + password);
            try
            {

                PasswordDeriveBytes pdb = passwordCrunch(password);

                string cryptFile = outputPath;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(pdb.GetBytes(32), pdb.GetBytes(16)), CryptoStreamMode.Write); //THIS IS WHERE THE ERROR IS

                FileStream fsIn = new FileStream(inputPath, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1) cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch
            {
                Console.WriteLine("Encryption failed!", "Error");
            }
        }

        public void tripledes()
        {
            Console.WriteLine("Enc 3DES");
        }
    }
}
