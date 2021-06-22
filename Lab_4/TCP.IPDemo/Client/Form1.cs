using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCP.IPDemo;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg, key,text;
            msg = textBox1.Text;
            key = textBox2.Text;

            //DES
            text = textBox4.Text;
            // text = AES.EncryptData(msg, key);
            textBox3.Text = AES.DecryptData(text, key);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg, key, text;
            msg = textBox1.Text;
            key = textBox2.Text;

            textBox4.Text = AES.EncryptData(msg,key);
           
        }
    }
}
