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
                PasswordDeriveBytes pdb = passwordCrunch(password);
                string cryptFile = outputPath;

                DES des = DES.Create();
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);


                CryptoStream cs = new CryptoStream(fsCrypt, des.CreateEncryptor(pdb.GetBytes(8), pdb.GetBytes(8)), CryptoStreamMode.Write);

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

        public void rc2()
        {
            try
            {
                PasswordDeriveBytes pdb = passwordCrunch(password);
                string cryptFile = outputPath;

                RC2 rcTwo = RC2.Create();
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);


                CryptoStream cs = new CryptoStream(fsCrypt, rcTwo.CreateEncryptor(pdb.GetBytes(8), pdb.GetBytes(8)), CryptoStreamMode.Write);

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
            try
            {
                PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, new byte[] 
                    { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F });
                string cryptFile = outputPath;

                TripleDES tripleDES = TripleDES.Create();
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);


                CryptoStream cs = new CryptoStream(fsCrypt, tripleDES.CreateEncryptor(pdb.GetBytes(16), pdb.GetBytes(16)), CryptoStreamMode.Write);

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
    }
}
