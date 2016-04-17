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
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = outputPath;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write);

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
