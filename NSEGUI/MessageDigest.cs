using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace NSEGUI
{
    class MessageDigest
    {
        byte[] input;
        public MessageDigest(byte[] inp)
        {
            input = inp;
        }


        public byte[] md5()
        {
            Console.WriteLine("Mes MD5");
            byte[] hash = MD5.Create().ComputeHash(input);
            return hash;
            //return new byte[0];
        }

        public byte[] sha1()
        {
            Console.WriteLine("Mes sha1");
            return new byte[0];
        }

        public byte[] sha256()
        {
            Console.WriteLine("Mes SHA256");
            return new byte[0];
        }

        public byte[] sha512()
        {
            Console.WriteLine("Mes SHA512");
            return new byte[0];
        }
    }

    public class EncDec
    {

        public static byte[] des(byte[] clearData, byte[] Key, byte[] IV)
        {

            MemoryStream ms = new MemoryStream();
            DES alg = DES.Create();

            alg.Key = Key;
            alg.IV = IV;

            CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);

            cs.Write(clearData, 0, clearData.Length);
            cs.Close();

            byte[] encryptedData = ms.ToArray();
            return encryptedData;
        }

        public static byte[] rc2(byte[] clearData, byte[] Key, byte[] IV)
        {

            MemoryStream ms = new MemoryStream();
            RC2 alg = RC2.Create();

            alg.Key = Key;
            alg.IV = IV;

            CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);

            cs.Write(clearData, 0, clearData.Length);
            cs.Close();

            byte[] encryptedData = ms.ToArray();
            return encryptedData;
        }

        public static byte[] rijndael(byte[] clearData, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();

            alg.Key = Key;
            alg.IV = IV;

            CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);

            cs.Write(clearData, 0, clearData.Length);
            cs.Close();

            byte[] encryptedData = ms.ToArray();
            return encryptedData;

        }

        public static byte[] tripledes(byte[] clearData, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            TripleDES alg = TripleDES.Create();

            alg.Key = Key;
            alg.IV = IV;

            CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);

            cs.Write(clearData, 0, clearData.Length);
            cs.Close();

            byte[] encryptedData = ms.ToArray();
            return encryptedData;
        }
    }
}
