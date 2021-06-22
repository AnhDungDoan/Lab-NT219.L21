using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCP.IPDemo;

namespace Client
{
    public partial class Client3 : Form
    {
        public Client3()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void bntSend_Click(object sender, EventArgs e)
        {
            if (cbSelect.Text != String.Empty)
                mahoa = true;
            string text = "Client: " + txtMessage.Text;
            string message = Encrypt(text);
            Send(message);
            lsvMessage.Items.Add(new ListViewItem(text));

            txtMessage.Clear();
        }

        IPEndPoint IP;
        Socket Client_tcp;
        void Connect()
        {
            //IP là địa chỉ của server
            IPEndPoint IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 10000);
            Client_tcp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                Client_tcp.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void Send(string message)
        {        
            
                Client_tcp.Send(Serialize(message));
                //lsvMessage.Items.Add(new ListViewItem( txtMessage.Text));
                //lsvMessage.Items.Add(new ListViewItem() { Text = text });
                 
            
        }
        void Receive()
        {
            try // nếu vượt qua ngưỡng lắng nghe
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 50000];
                    Client_tcp.Receive(data);
                    string message = (string)Deserialize(data);

                    //giai mã
                    if (mahoa == false)
                    {
                        lsvMessage.Items.Add(new ListViewItem() { Text = message });
                    }
                    else
                    {
                        string decrypted = Decrypt(message);
                        lsvMessage.Items.Add(new ListViewItem() { Text = decrypted });
                    }    
                  
                }
            }
            catch (Exception e) // đóng kết nối lại
            {
                //Close();
                MessageBox.Show(e.ToString());
            }
        }


        byte[] Serialize(object obj)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter fomatter = new BinaryFormatter();
            fomatter.Serialize(ms, obj);
            return ms.ToArray();
        }
        object Deserialize(byte[] data) // truyền vào mảng byte gom các mảnh thành một đối tượng
        {
            MemoryStream steam = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(steam);
        }


        private void Client3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        /*  Exchange Key*/
        long p, g;
        long b, B;
        long A, Secret_Key;



        private void bntCheck_Click_1(object sender, EventArgs e)
        {
            //nếu chưa có p
            if (txtP.Text == string.Empty)
            {
                p = GFG.generate_Prime();
                txtP.Text = p.ToString();
                // tạo g
                //g = GFG.findPrimitive(p);
                g = GFG.PrimitiveRoot(p);
                txtG.Text = g.ToString();

            }
            else // có p thì kiểm tra
            {
                p = Int32.Parse(txtP.Text.Trim());
                if (txtG.Text == String.Empty) // chưa có g
                {
                    p = Int32.Parse(txtP.Text.Trim());
                    bool prime = GFG.isPrime(p);
                    if (!prime)
                    {
                        MessageBox.Show("Nhập lại p");
                        return;
                    }
                    // tạo g
                    //g = GFG.findPrimitive(p);
                    g = GFG.PrimitiveRoot(p);
                    txtG.Text = g.ToString();
                }
            }
            p = Int32.Parse(txtP.Text.Trim());
            g = Int32.Parse(txtG.Text.Trim());
            // chọn random b
            Random random = new Random();
            b =(long) random.Next(1, (int)p - 1);
            txt_b.Text = b.ToString();

            // tính public key B

            //b = Int32.Parse(txtPR.Text.Trim());

            B = GFG.power(g, b, p);
            txtB.Text = B.ToString();

        }

        private void bntKey_Click_1(object sender, EventArgs e)
        {
            A = Int32.Parse(txtA.Text.Trim());
            // tính secret key
            Secret_Key = GFG.power(A, b, p);
            txtSecret.Text = Secret_Key.ToString();
        }

        

        //trao đổi khóa
        private void button1_Click(object sender, EventArgs e)//exchange key
        {
            string text = "Client\n       ";
            text += "P: " + txtP.Text + "       G:" + txtG.Text + "     B (g^b mod p): " + txtB.Text;
            Send(text);
            lsvMessage.Items.Add(new ListViewItem(text));

        }
        //mã hóa
        public string Encrypt(string msg)
        {
            string key = txtSecret.Text;
            string enc;
            int select = Int32.Parse(cbSelect.Text.Trim());
            switch (select)
            {
                case 1: //DES
                    {
                        enc = AES.EncryptData(msg, key);
                        return enc;
                        break;
                    }
                case 2: //DES
                    {

                        enc = AES.EncryptString(msg, key);
                        return enc;
                        break;
                    }
                case 3:
                    {
                        enc = AES.Encrypt(msg, key);
                        return enc;
                        break;
                    }
            }
            return "nope";
        }
        public string Decrypt(string msg)
        {
            string key = txtSecret.Text;
            string enc;
            int select = Int32.Parse(cbSelect.Text.Trim());
            switch (select)
            {
                case 1: //DES
                    {
                        enc = AES.DecryptData(msg, key);
                        return enc;
                        break;
                    }
                case 2: //DES
                    {

                        enc = AES.DecryptString(msg, key);
                        return enc;
                        break;
                    }
                case 3:
                    {
                        enc = AES.Decrypt(msg, key);
                        return enc;
                        break;
                    }
            }
            return "nope";
        }

        bool mahoa = false;
        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = "Cipher client:" + cbSelect.Text;
            Send(text);
            lsvMessage.Items.Add(new ListViewItem(text));

        }
    }
}

