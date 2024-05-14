using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace lab3_bai3
{
    public partial class Form1 : Form
    {
        private string UserName = "Unknown";
        private StreamWriter swSender;
        private StreamReader srReceiver;
        private TcpClient tcpServer;
       
        private delegate void UpdateLogCallback(string strMessage);
        
        private delegate void CloseConnectionCallback(string strReason);
        private Thread thrMessaging;
        private IPAddress ipAddr;
        private bool Connected;
        public Form1()
        {
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            InitializeComponent();
        }
        public void OnApplicationExit(object sender, EventArgs e)
        {
            if (Connected == true)
            {               
                Connected = false;
                swSender.Close();
                srReceiver.Close();
                tcpServer.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Connected == false)
            {           
                InitializeConnection();
                btconnect.Enabled = false;
            }
        }

        private void btdisconnect_Click(object sender, EventArgs e)
        {
            CloseConnection("Hủy kết nối với user.");
        }
        private void InitializeConnection()
        {
            
            ipAddr = IPAddress.Parse("127.0.0.1");          
            tcpServer = new TcpClient();
            tcpServer.Connect(ipAddr, 1986);          
            Connected = true;                 
            btsend.Enabled = true;
            btdisconnect.Text = "Hủy kết nối";            
            swSender = new StreamWriter(tcpServer.GetStream());          
            swSender.Flush();         
        }     
        // Closes a current connection
        private void CloseConnection(string Reason)
        {                
            btsend.Enabled = false;
            btconnect.Text = "Kết nối";
            Byte[] data = System.Text.Encoding.ASCII.GetBytes("quit\n");         
            // Close the objects
            Connected = false;
            swSender.Close();
            srReceiver.Close();
            tcpServer.Close();
        }
        private void SendMessage()
        {
            if (txtmess.Lines.Length >= 1)
            {
                swSender.WriteLine(txtmess.Text);
                swSender.Flush();
                txtmess.Lines = null;
            }
            txtmess.Text = "";
        }

        private void btsend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void txtlog_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the key is Enter
            if (e.KeyChar == (char)13)
            {
                SendMessage();
            }
        }
    }
}
