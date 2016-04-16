namespace NSEGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFileInput = new System.Windows.Forms.TextBox();
            this.txtFileOutput = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoDES = new System.Windows.Forms.RadioButton();
            this.rdoRC2 = new System.Windows.Forms.RadioButton();
            this.rdoRijndael = new System.Windows.Forms.RadioButton();
            this.rdoTripleDES = new System.Windows.Forms.RadioButton();
            this.Encrypt = new System.Windows.Forms.GroupBox();
            this.messageDigestBox = new System.Windows.Forms.GroupBox();
            this.rdoMD5 = new System.Windows.Forms.RadioButton();
            this.rdoSHA1 = new System.Windows.Forms.RadioButton();
            this.rdoSHA256 = new System.Windows.Forms.RadioButton();
            this.rdoSHA512 = new System.Windows.Forms.RadioButton();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnDigest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtProgress = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutOurCryptographySystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToEncryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Encrypt.SuspendLayout();
            this.messageDigestBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileInput
            // 
            this.txtFileInput.Location = new System.Drawing.Point(12, 60);
            this.txtFileInput.Name = "txtFileInput";
            this.txtFileInput.Size = new System.Drawing.Size(327, 20);
            this.txtFileInput.TabIndex = 0;
            // 
            // txtFileOutput
            // 
            this.txtFileOutput.Location = new System.Drawing.Point(12, 103);
            this.txtFileOutput.Name = "txtFileOutput";
            this.txtFileOutput.Size = new System.Drawing.Size(327, 20);
            this.txtFileOutput.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(92, 147);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(247, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Location = new System.Drawing.Point(364, 57);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseInput.TabIndex = 3;
            this.btnBrowseInput.Text = "Browse";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(364, 101);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutput.TabIndex = 4;
            this.btnBrowseOutput.Text = "Browse";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // rdoDES
            // 
            this.rdoDES.AutoSize = true;
            this.rdoDES.Location = new System.Drawing.Point(25, 30);
            this.rdoDES.Name = "rdoDES";
            this.rdoDES.Size = new System.Drawing.Size(47, 17);
            this.rdoDES.TabIndex = 0;
            this.rdoDES.TabStop = true;
            this.rdoDES.Text = "DES";
            this.rdoDES.UseVisualStyleBackColor = true;
            // 
            // rdoRC2
            // 
            this.rdoRC2.AutoSize = true;
            this.rdoRC2.Location = new System.Drawing.Point(114, 30);
            this.rdoRC2.Name = "rdoRC2";
            this.rdoRC2.Size = new System.Drawing.Size(46, 17);
            this.rdoRC2.TabIndex = 1;
            this.rdoRC2.TabStop = true;
            this.rdoRC2.Text = "RC2";
            this.rdoRC2.UseVisualStyleBackColor = true;
            // 
            // rdoRijndael
            // 
            this.rdoRijndael.AutoSize = true;
            this.rdoRijndael.Location = new System.Drawing.Point(218, 30);
            this.rdoRijndael.Name = "rdoRijndael";
            this.rdoRijndael.Size = new System.Drawing.Size(66, 17);
            this.rdoRijndael.TabIndex = 2;
            this.rdoRijndael.TabStop = true;
            this.rdoRijndael.Text = "Rijndael ";
            this.rdoRijndael.UseVisualStyleBackColor = true;
            // 
            // rdoTripleDES
            // 
            this.rdoTripleDES.AutoSize = true;
            this.rdoTripleDES.Location = new System.Drawing.Point(335, 30);
            this.rdoTripleDES.Name = "rdoTripleDES";
            this.rdoTripleDES.Size = new System.Drawing.Size(73, 17);
            this.rdoTripleDES.TabIndex = 3;
            this.rdoTripleDES.TabStop = true;
            this.rdoTripleDES.Text = "TripleDES";
            this.rdoTripleDES.UseVisualStyleBackColor = true;
            // 
            // Encrypt
            // 
            this.Encrypt.Controls.Add(this.rdoDES);
            this.Encrypt.Controls.Add(this.rdoRC2);
            this.Encrypt.Controls.Add(this.rdoRijndael);
            this.Encrypt.Controls.Add(this.rdoTripleDES);
            this.Encrypt.Location = new System.Drawing.Point(12, 173);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(427, 66);
            this.Encrypt.TabIndex = 9;
            this.Encrypt.TabStop = false;
            this.Encrypt.Text = "Encryption Algorithm";
            // 
            // messageDigestBox
            // 
            this.messageDigestBox.Controls.Add(this.rdoMD5);
            this.messageDigestBox.Controls.Add(this.rdoSHA1);
            this.messageDigestBox.Controls.Add(this.rdoSHA256);
            this.messageDigestBox.Controls.Add(this.rdoSHA512);
            this.messageDigestBox.Location = new System.Drawing.Point(12, 245);
            this.messageDigestBox.Name = "messageDigestBox";
            this.messageDigestBox.Size = new System.Drawing.Size(427, 66);
            this.messageDigestBox.TabIndex = 10;
            this.messageDigestBox.TabStop = false;
            this.messageDigestBox.Text = "Message Digest Algorithm";
            // 
            // rdoMD5
            // 
            this.rdoMD5.AutoSize = true;
            this.rdoMD5.Location = new System.Drawing.Point(25, 30);
            this.rdoMD5.Name = "rdoMD5";
            this.rdoMD5.Size = new System.Drawing.Size(48, 17);
            this.rdoMD5.TabIndex = 0;
            this.rdoMD5.TabStop = true;
            this.rdoMD5.Text = "MD5";
            this.rdoMD5.UseVisualStyleBackColor = true;
            // 
            // rdoSHA1
            // 
            this.rdoSHA1.AutoSize = true;
            this.rdoSHA1.Location = new System.Drawing.Point(114, 30);
            this.rdoSHA1.Name = "rdoSHA1";
            this.rdoSHA1.Size = new System.Drawing.Size(53, 17);
            this.rdoSHA1.TabIndex = 1;
            this.rdoSHA1.TabStop = true;
            this.rdoSHA1.Text = "SHA1";
            this.rdoSHA1.UseVisualStyleBackColor = true;
            // 
            // rdoSHA256
            // 
            this.rdoSHA256.AutoSize = true;
            this.rdoSHA256.Location = new System.Drawing.Point(218, 30);
            this.rdoSHA256.Name = "rdoSHA256";
            this.rdoSHA256.Size = new System.Drawing.Size(65, 17);
            this.rdoSHA256.TabIndex = 2;
            this.rdoSHA256.TabStop = true;
            this.rdoSHA256.Text = "SHA256";
            this.rdoSHA256.UseVisualStyleBackColor = true;
            // 
            // rdoSHA512
            // 
            this.rdoSHA512.AutoSize = true;
            this.rdoSHA512.Location = new System.Drawing.Point(335, 30);
            this.rdoSHA512.Name = "rdoSHA512";
            this.rdoSHA512.Size = new System.Drawing.Size(65, 17);
            this.rdoSHA512.TabIndex = 3;
            this.rdoSHA512.TabStop = true;
            this.rdoSHA512.Text = "SHA512";
            this.rdoSHA512.UseVisualStyleBackColor = true;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(18, 317);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(100, 45);
            this.btnEncrypt.TabIndex = 11;
            this.btnEncrypt.Text = "ENCRYPT";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(124, 317);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(100, 45);
            this.btnDecrypt.TabIndex = 12;
            this.btnDecrypt.Text = "DECRYPT";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnDigest
            // 
            this.btnDigest.Location = new System.Drawing.Point(230, 317);
            this.btnDigest.Name = "btnDigest";
            this.btnDigest.Size = new System.Drawing.Size(100, 45);
            this.btnDigest.TabIndex = 13;
            this.btnDigest.Text = "DIGEST";
            this.btnDigest.UseVisualStyleBackColor = true;
            this.btnDigest.Click += new System.EventHandler(this.btnDigest_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(336, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 45);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(129, 368);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(310, 17);
            this.progressBar.TabIndex = 15;
            // 
            // txtProgress
            // 
            this.txtProgress.AutoSize = true;
            this.txtProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgress.Location = new System.Drawing.Point(14, 368);
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.Size = new System.Drawing.Size(113, 17);
            this.txtProgress.TabIndex = 16;
            this.txtProgress.Text = "Progress Status:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToEncryptToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialToolStripMenuItem,
            this.aboutOurCryptographySystemToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.tutorialToolStripMenuItem.Text = "Tutorial";
            // 
            // openFileToEncryptToolStripMenuItem
            // 
            this.openFileToEncryptToolStripMenuItem.Name = "openFileToEncryptToolStripMenuItem";
            this.openFileToEncryptToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openFileToEncryptToolStripMenuItem.Text = "Open...";
            this.openFileToEncryptToolStripMenuItem.Click += new System.EventHandler(this.openFileToEncryptToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 400);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDigest);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.messageDigestBox);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.btnBrowseInput);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtFileOutput);
            this.Controls.Add(this.txtFileInput);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Cryptography System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Encrypt.ResumeLayout(false);
            this.Encrypt.PerformLayout();
            this.messageDigestBox.ResumeLayout(false);
            this.messageDigestBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileInput;
        private System.Windows.Forms.TextBox txtFileOutput;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnBrowseInput;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoDES;
        private System.Windows.Forms.RadioButton rdoTripleDES;
        private System.Windows.Forms.RadioButton rdoRijndael;
        private System.Windows.Forms.RadioButton rdoRC2;
        private System.Windows.Forms.GroupBox Encrypt;
        private System.Windows.Forms.GroupBox messageDigestBox;
        private System.Windows.Forms.RadioButton rdoMD5;
        private System.Windows.Forms.RadioButton rdoSHA1;
        private System.Windows.Forms.RadioButton rdoSHA256;
        private System.Windows.Forms.RadioButton rdoSHA512;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnDigest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label txtProgress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutOurCryptographySystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToEncryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

