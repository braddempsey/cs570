using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    //filestream

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
        }

        public void tripledes()
        {
            Console.WriteLine("Dec 3DES");
        }
    }
}
