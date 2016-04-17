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
        }

        public byte[] sha1()
        {
            Console.WriteLine("Mes sha1");
            byte[] hash = SHA1.Create().ComputeHash(input);
            return hash;
        }

        public byte[] sha256()
        {
            Console.WriteLine("Mes SHA256");
            byte[] hash = SHA256.Create().ComputeHash(input);
            return hash;
        }

        public byte[] sha512()
        {
            Console.WriteLine("Mes SHA512");
            byte[] hash = SHA512.Create().ComputeHash(input);
            return hash;
        }
    }
}
