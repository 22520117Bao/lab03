using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace lab3_bai1
{
    public partial class Form1 : Form
    {
        private UdpClient udpServer;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btlisten_Click(object sender, EventArgs e)
        {
            int port = 0;
            port = int .Parse(txtport.Text);
            udpServer = new UdpClient(port); // Khởi tạo UDP Server ở cổng 12345
            StartListening();
            txtmess.Text += "Start listening....."+"\r\n";
            txtmess.Text += "127.0.0.1:Uiter connect"+"\r\n";
        }
        private async void StartListening()
        {
            try
            {
                while (true)
                {
                    UdpReceiveResult result = await udpServer.ReceiveAsync();
                    string message = Encoding.UTF8.GetString(result.Buffer);
                    AppendToLog($"{result.RemoteEndPoint.Address.ToString()}: {message}");  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
      

        private void AppendToLog(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { AppendToLog(text); }));
                return;
            }
            txtmess.AppendText(text + Environment.NewLine);
        }
    }
}
