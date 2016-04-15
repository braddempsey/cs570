using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSEGUI
{
    class MessageDigest
    {
        public MessageDigest(System.Windows.Forms.RadioButton rdoMD5, System.Windows.Forms.RadioButton rdoSHA1, System.Windows.Forms.RadioButton rdoSHA256, System.Windows.Forms.RadioButton rdoSHA512)
        {
            if (rdoMD5.Checked) { md5(); }
            else if (rdoSHA1.Checked) { sha1(); }
            else if (rdoSHA256.Checked) { sha256(); }
            else if (rdoSHA512.Checked) { sha512(); }
            else { Console.WriteLine("None Selected"); }
        }

        private void md5()
        {
            Console.WriteLine("Mes MD5");
        }

        private void sha1()
        {
            Console.WriteLine("Mes sha1");
        }

        private void sha256()
        {
            Console.WriteLine("Mes SHA256");
        }

        private void sha512()
        {
            Console.WriteLine("Mes SHA512");
        }
    }
}
