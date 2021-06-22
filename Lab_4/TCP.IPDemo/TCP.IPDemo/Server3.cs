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
using  Client;
namespace TCP.IPDemo
{
    public partial class Server3 : Form
    {
        public Server3()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        Socket listenerSocket;
        IPEndPoint ipeServer;
        List<Socket> ClientList; // danh sách các client đang kết nối với server
        private void bntSend_Click(object sender, EventArgs e)
        {
            if (cbSelect.Text != String.Empty)
                mahoa = true;
            foreach (Socket item in ClientList)
            {
                string text = "Server: " + txtMessage.Text;
                string encrypted = Encrypt(text);
                Send(item, encrypted);
                lsvMessage.Items.Add(new ListViewItem(text));
            }
            txtMessage.Clear();
        }
       
        void Connect()
        {
            ClientList = new List<Socket>();

            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ipeServer = new IPEndPoint(IPAddress.Any, 10000);

            listenerSocket.Bind(ipeServer);
            lsvMessage.Items.Add(new ListViewItem("Server running on 127.0.0.1: 10000"));
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        listenerSocket.Listen(100);
                        Socket client = listenerSocket.Accept();
                        ClientList.Add(client);
                        lsvMessage.Items.Add(new ListViewItem("New client connected " + client.RemoteEndPoint));

                        Thread recv = new Thread(Receive);
                        recv.IsBackground = true;
                        recv.Start(client);
                    }
                }
                catch
                {
                    listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    ipeServer = new IPEndPoint(IPAddress.Any, 10000);
                }



            });
            Listen.IsBackground = true;
            Listen.Start();

        }
      
        void Send(Socket client, string msg)
        {
           
                string text =msg;
                //mã hóa
                client.Send(Serialize(text));
           
        }
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try // nếu vượt qua ngưỡng lắng nghe
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 50000];
                    client.Receive(data);
                    string message= (string)Deserialize(data);

                    // Gửi cho các client msg vừa nhận
                    /* foreach (Socket item in ClientList)
                     {
                         if (item != null && item != client)
                             item.Send(Serialize(message));
                     }*/

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
            catch // đóng kết nối lại
            {
                ClientList.Remove(client);
                client.Close();
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

        private void Server3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        /*  ExchangeKey*/
        
       
        long p, g;
        long a, A;

        long B, secret_Key;

        private void button1_Click(object sender, EventArgs e)//exchange key
        {
            foreach (Socket item in ClientList)
            {
                string text = "Server\n      ";
                 text += "P: " + txtP.Text + "     G: " + txtG.Text + "      A (g^a mod n):  " + txtA.Text;
                Send(item, text);
                lsvMessage.Items.Add(new ListViewItem() { Text = text });

            }
        }

        private void bntCheck_Click(object sender, EventArgs e)
        {
            //nếu chưa có p
            if (txtP.Text == string.Empty)
            {
                p = GFG.generate_Prime();
                txtP.Text = p.ToString();
                // tạo g
                // g = GFG.findPrimitive(p);
                g = GFG.PrimitiveRoot(p);
                txtG.Text = g.ToString();

            }
            else // có p thì kiểm tra
            {
                p = Int32.Parse(txtP.Text.Trim());
                if (txtG.Text == String.Empty) // chưa có g
                {
                   
                    bool prime = GFG.isPrime(p);
                    if (!prime)
                    {
                        MessageBox.Show("Nhập lại p");
                        return;
                    }
                    // tạo g
                    // g = GFG.findPrimitive(p);
                    g = GFG.PrimitiveRoot(p);
                    txtG.Text = g.ToString();
                }
            }
            p = Int32.Parse(txtP.Text.Trim());
            g = Int32.Parse(txtG.Text.Trim());

            //random a
            Random random = new Random();
            a = random.Next(1,(int) p-1);
            string s = a.ToString();
            txt_a.Text = s;

            //tính A
           
            //a = Int32.Parse(txt_a.Text.Trim());

            A = GFG.power(g, a, p);
            txtA.Text = A.ToString();
          
        }

        private void bntKey_Click(object sender, EventArgs e)
        {

            B = Int32.Parse(txtB.Text.Trim());
            // tính secret key
            secret_Key = GFG.power(B, a, p);
            txtSecret.Text = secret_Key.ToString();
        }
        /*Mã hóa*/
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
            foreach (Socket item in ClientList)
            {
                string text = "Cipher server :" + cbSelect.Text;
                Send(item, text);
                lsvMessage.Items.Add(new ListViewItem() { Text = text });

            }


        }
    }
}
