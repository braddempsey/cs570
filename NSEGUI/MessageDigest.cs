using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

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
}
