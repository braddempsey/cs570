using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSEGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void aboutOurCryptographySystemToolStripMenuItem_Click(object sender, EventArgs e)
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
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Document|*.txt";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFileOutput.Text = sfd.FileName;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
