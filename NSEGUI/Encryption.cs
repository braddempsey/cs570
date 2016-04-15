using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSEGUI
{
    class Encryption
    {
        public Encryption(System.Windows.Forms.RadioButton rdoDES, System.Windows.Forms.RadioButton rdoTripleDES, System.Windows.Forms.RadioButton rdoRijndael, System.Windows.Forms.RadioButton rdoRC2)
        {
            if (rdoDES.Checked) { des(); }
            else if (rdoRC2.Checked) { rc2(); }
            else if (rdoRijndael.Checked) { rijndael(); }
            else if (rdoTripleDES.Checked) { tripledes(); }
            else { Console.WriteLine("None Selected"); }
        }

        private void des()
        {
            Console.WriteLine("Enc DES");
        }

        private void rc2()
        {
            Console.WriteLine("Enc RC2");
        }

        private void rijndael()
        {
            Console.WriteLine("Enc Rijn");
        }

        private void tripledes()
        {
            Console.WriteLine("Enc 3DES");
        }
    }
}
