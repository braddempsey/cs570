using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    //filestream

namespace NSEGUI
{
    class Encryption
    {
        FileStream input;
        public Encryption(FileStream inp)
        {
            input = inp;
        }

        public void des()
        {
            Console.WriteLine("Enc DES");
        }

        public void rc2()
        {
            Console.WriteLine("Enc RC2");
        }

        public void rijndael()
        {
            Console.WriteLine("Enc Rijn");
        }

        public void tripledes()
        {
            Console.WriteLine("Enc 3DES");
        }
    }
}
