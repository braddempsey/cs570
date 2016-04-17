using System;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace NSEGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string outputPath;
        string inputPath;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Document|*.txt";
            ofd.Title = "Open file to encrypt";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)          
            {
                txtFileInput.Text = ofd.FileName;
                inputPath = ofd.FileName;
                Console.WriteLine(inputPath);
                //input = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Document|*.txt";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFileOutput.Text = sfd.FileName;
                outputPath = sfd.FileName;
                //output = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write);
            }
        }

        private void openFileToEncryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBrowseInput_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBrowseOutput_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Encryption enc = new Encryption(txtPassword.Text, inputPath, outputPath);
            if (rdoDES.Checked) { enc.des(); }
            else if (rdoRC2.Checked) { enc.rc2(); }
            else if (rdoRijndael.Checked) { enc.rijndael(); }
            else if (rdoTripleDES.Checked) { enc.tripledes(); }
            else { Console.WriteLine("None Selected"); }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Decryption dec = new Decryption(txtPassword.Text, inputPath, outputPath);
            if (rdoDES.Checked) { dec.des(); }
            else if (rdoRC2.Checked) { dec.rc2(); }
            else if (rdoRijndael.Checked) { dec.rijndael(); }
            else if (rdoTripleDES.Checked) { dec.tripledes(); }
            else { Console.WriteLine("None Selected"); }
        }

        private void btnDigest_Click(object sender, EventArgs e)
        {
            //need if here to prevent using digest button without having selected an input file
            FileStream input = new FileStream(inputPath, FileMode.Open, FileAccess.Read, FileShare.Read);
            MemoryStream convert = new MemoryStream();
            input.CopyTo(convert);
            byte[] inputBytes = convert.ToArray();//try ToArray
            MessageDigest mes = new MessageDigest(inputBytes);
            if (rdoMD5.Checked) { File.WriteAllBytes(outputPath, mes.md5()); }
            else if (rdoSHA1.Checked) { File.WriteAllBytes(outputPath, mes.sha1()); }
            else if (rdoSHA256.Checked) { File.WriteAllBytes(outputPath, mes.sha256()); }
            else if (rdoSHA512.Checked) { File.WriteAllBytes(outputPath, mes.sha512()); }
            else { Console.WriteLine("None Selected"); }
            input.Close();
        }
    }
}
