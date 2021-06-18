using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace HashCalculator
{
    public partial class mainGUI : Form
    {
        public mainGUI()
        {
            InitializeComponent();
            //importFileButton.Enabled = false;
        }
        string message;
        private string calMD5(string message)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(message));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("X2")); // x2 = lowercase
            }
            return hash.ToString();
        }
        private string calSHA1(string message)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(message));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2")); // x2 = lowercase
                }

                return sb.ToString();
            }
        }
        private string calSHA256(string message)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(message);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:X2}", x);
            }
            return hashString;
        }

        private string calSHA384(string message)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(message);
            SHA384Managed hashstring = new SHA384Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:X2}", x);
            }
            return hashString;
        }
        private string calSHA512(string message)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(message);
            SHA512Managed hashstring = new SHA512Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:X2}", x);
            }
            return hashString;
        }

        private string calRIPEMD160(string messgae)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(message);
            RIPEMD160Managed hashstring = new RIPEMD160Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:X2}", x);
            }
            return hashString;
        }
        private string ToHexString(string str)
        {
            var sb = new StringBuilder();

            var bytes = Encoding.Unicode.GetBytes(str);
            foreach (var t in bytes)
            {
                sb.Append(t.ToString("X2"));
            }

            return sb.ToString(); // returns: "48656C6C6F20776F726C64" for "Hello world"
        }

        
        private void HashButton_Click(object sender, EventArgs e)
        {
            /*  Data format include:
                    - Text string
                    - Hex string  
                    - File
            */
            if (dataFormat.Text == "Hex string")
                message = ToHexString(dataText.Text);
            else
                if (dataFormat.Text == "File")
                {
                    importFileButton.Enabled = true;
                    //message = readFile();
                }  
                else
                    message = dataText.Text;

            

            if (MD5check.Checked)
                MD5Hash.Text = calMD5(message);

            if (SHA1check.Checked)
                SHA1Hash.Text = calSHA1(message);

            if (SHA256check.Checked)
                SHA256Hash.Text = calSHA256(message);

            if (SHA384Check.Checked)
                SHA384Hash.Text = calSHA384(message);

            if (SHA512Check.Checked)
                SHA512Hash.Text = calSHA512(message);

            if (RIPEMD160Check.Checked)
                RIPEMD160Hash.Text = calRIPEMD160(message);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn dám thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                message = "";
                this.Close();
            }
        }

        private void importFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult result = dlg.ShowDialog(); 
            if (result == DialogResult.OK) 
            {
                string file = dlg.FileName;
                label3.Text = file;
                try
                {
                    message = File.ReadAllText(file);
                }
                catch (IOException)
                {
                }
            }
        }
    }
}
