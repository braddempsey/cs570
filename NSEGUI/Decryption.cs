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
        FileStream input;
        public Decryption(FileStream inp)
        {
            input = inp;
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
