using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace lab3_bai2
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }
        private void StartListen(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }
        void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];
            Socket clientSocket;
            Socket listenerSocket = new Socket( AddressFamily.InterNetwork,
                SocketType.Stream,ProtocolType.Tcp);
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();
            IPEndPoint remoteEndPoint = (IPEndPoint)clientSocket.RemoteEndPoint;
            lbcommand.Items.Add("New client connected: " + remoteEndPoint.Address + " " + 8080);
            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                }
                while (text[text.Length - 1] != '\n');
                lbcommand.Items.Add(remoteEndPoint.Address + " (" + 8080 + "): " + text);
            }
            listenerSocket.Close();
        }


        private void btlisten_Click(object sender, EventArgs e)
        {
            lbcommand.Items.Add( "Start listening....."+"\r\n");
            StartListen(sender, e);
        }
    }
}
