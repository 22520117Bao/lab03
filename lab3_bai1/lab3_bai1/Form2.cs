using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_bai1
{
    public partial class Form2 : Form
    {
        private UdpClient udpClient;
        public Form2()
        {
            InitializeComponent();
            udpClient = new UdpClient();
        }

        private void btsend_Click(object sender, EventArgs e)
        {
            try
            {
                //kết nối với UDP Server 
                string serverIP = txthost.Text;
                int serverPort = int.Parse(txtport.Text);
                IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(serverIP), serverPort);

                // cho phép gửi các tin nhắn theo ngôn ngữ tiếng Việt 
                string message = txtmessage.Text;
                byte[] data = Encoding.UTF8.GetBytes(message);

                udpClient.Send(data, data.Length, serverEndPoint);
                MessageBox.Show("Message sent successfully!");
                txtmessage.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
