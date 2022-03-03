using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBuilder
{
    public partial class FileConstructor : Form
    {
        /* 
         * Hello, this project is a child of Abraxas (An Open Source Remote Administration Tool) [Currently Private]
         * Although this algorithm is used all over the world, this specific project must be used for educational purposes only.
         * I, the creator, am not responsible for any actions, and or damages, caused by this software.
         * You bear the full responsibility of your actions and acknowledge that this software was created for educational purposes only.
         * This software's main purpose is NOT to be used maliciously, or on any system that you do not own, or have the right to use.
         * By using this software, you automatically agree to the above.
         * 
         * Sail safe.
         */

        public FileConstructor()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle; // No Resize
        }

        private void ButtonClicker(object sender, EventArgs e)
        {
            Button button = sender as Button;

            // Obtain Name of Button & Apply Function
            if (KeyBox.Text != "")
            {
                try
                {
                    switch (button.Name)
                    {
                        // Encrypts The File & Creates New Version 'FileName.Extension.encrypted'
                        case "EncryptButton":
                            Functions.FileEncrypt(Functions.ObtainFileName(), KeyBox.Text);
                            MessageBox.Show("Encrypted File With Extension '.encrypted' :  It has been placed in the same directory.");
                            break;

                        // Decrypts The File & Creates Overwrites Encrypted File
                        case "DecryptButton":
                            string FileChosen = Functions.ObtainFileName();
                            Functions.FileDecrypt(FileChosen, FileChosen + ".decrypted", KeyBox.Text);
                            MessageBox.Show("Decrypted File With Extension '.decrypted' :  It has been placed in the same directory.");
                            break;
                    }
                }
                catch {}
            }
            else { MessageBox.Show("Type In A Key For Decryption", "Missing Key", MessageBoxButtons.OK); }
        }
    }
}
