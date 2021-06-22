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

namespace Client
{
    public partial class Client2 : Form
    {
        public Client2()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void bntSend_Click(object sender, EventArgs e)
        {
            Send();
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
        void Send()
        {
            if (txtMessage.Text != String.Empty)
            {
                string text = txtMessage.Text;
                Client_tcp.Send(Serialize(text));
                //lsvMessage.Items.Add(new ListViewItem( txtMessage.Text));
                lsvMessage.Items.Add(new ListViewItem() { Text = "Client: " + txtMessage.Text });
            }
            else
            {
                if (txtP.Text != String.Empty)
                {
                    string text = "P: " + txtP.Text + "       G:" + txtG.Text + "   B (g^b mod p): " + txtB.Text;
                    Client_tcp.Send(Serialize(text));


                    lsvMessage.Items.Add(new ListViewItem() { Text = "P: " + txtP.Text });
                    lsvMessage.Items.Add(new ListViewItem() { Text = "G: " + txtG.Text });
                    lsvMessage.Items.Add(new ListViewItem() { Text = "B (g^b mod p): " + txtB.Text });
                }
            }


        }
        void Receive()
        {
            try // nếu vượt qua ngưỡng lắng nghe
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 50];
                    Client_tcp.Receive(data);

                    string message = (string)Deserialize(data);
                    lsvMessage.Items.Add(new ListViewItem() { Text = message });
                }
            }
            catch // đóng kết nối lại
            {
                Close();
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

        /*  Exchange Key*/
        long p, g;
        long b, B;
        long A, Secret_Key;

        private void button1_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void bntCheck_Click(object sender, EventArgs e)
        {
            //nếu chưa có p
            if (txtP.Text == string.Empty)
            {
                p = GFG.generate_Prime();
                txtP.Text = p.ToString();
                // tạo g
                g = GFG.findPrimitive(p);
                txtG.Text = g.ToString();

            }
            else // có p thì kiểm tra
            {

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
                    g = GFG.findPrimitive(p);
                    txtG.Text = g.ToString();
                }
            }
            p = Int32.Parse(txtP.Text.Trim());
            g = Int32.Parse(txtG.Text.Trim());
            // chọn random b
            Random random = new Random();
            b = random.Next(1, (int)p - 1);
            txt_b.Text = b.ToString();

            // tính public key B

            //b = Int32.Parse(txtPR.Text.Trim());

            B = GFG.power(g, b, p);
            txtB.Text = B.ToString();

        }

        private void bntKey_Click(object sender, EventArgs e)
        {

            A = Int32.Parse(txtA.Text.Trim());
            // tính secret key
            Secret_Key = GFG.power(A, b, p);
            txtSecretKey.Text = Secret_Key.ToString();
        }


    }
}
