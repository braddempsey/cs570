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

            try
            {
                PasswordDeriveBytes pdb = passwordCrunch(password);

                FileStream fsCrypt = new FileStream(inputPath, FileMode.Open);

                DES RMCrypto = DES.Create();

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateDecryptor(pdb.GetBytes(8), pdb.GetBytes(8)), CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputPath, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1) fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch
            {
                Console.WriteLine("Decryption Failed");
            }

}

        public void rc2()
        {
            Console.WriteLine("Dec RC2");

            try
            {
                PasswordDeriveBytes pdb = passwordCrunch(password);

                FileStream fsCrypt = new FileStream(inputPath, FileMode.Open);

                RC2 RMCrypto = RC2.Create();

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateDecryptor(pdb.GetBytes(8), pdb.GetBytes(8)), CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputPath, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1) fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch
            {
                Console.WriteLine("Decryption Failed");
            }
}

        public void rijndael()
        {
            Console.WriteLine("Dec Rijn");
            try
            {

                PasswordDeriveBytes pdb = passwordCrunch(password);

                FileStream fsCrypt = new FileStream(inputPath, FileMode.Open);

                Rijndael RMCrypto = Rijndael.Create();
                RMCrypto.Padding = PaddingMode.Zeros;

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateDecryptor(pdb.GetBytes(32), pdb.GetBytes(16)), CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputPath, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1) fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch
            {
                Console.WriteLine("Decryption Failed");
            }
        }

        public void tripledes()
        {
            Console.WriteLine("Dec 3DES");

            try
            {
                PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, new byte[]
                        { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F });

                FileStream fsCrypt = new FileStream(inputPath, FileMode.Open);

                DES RMCrypto = DES.Create();
                RMCrypto.Padding = PaddingMode.Zeros;

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateDecryptor(pdb.GetBytes(16), pdb.GetBytes(16)), CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputPath, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1) fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();

            }
            catch
            {
                Console.WriteLine("Decryption Failed");
            }
}
    }
}
