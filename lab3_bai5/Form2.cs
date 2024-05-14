using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Homnayangi
{
    public partial class Form2 : Form
    {
        private delegate void UpdateStatusCallback(string strMessage);
        public Form2()
        {
            InitializeComponent();
        }

        private void btlisten_Click(object sender, EventArgs e)
        {
            string a = "127.0.0.1";
            // Parse the server's IP address out of the TextBox
            IPAddress ipAddr = IPAddress.Parse(a);
            // Create a new instance of the ChatServer object
            ChatServer mainServer = new ChatServer(ipAddr);
            // Hook the StatusChanged event handler to mainServer_StatusChanged
            ChatServer.StatusChanged += new StatusChangedEventHandler(mainServer_StatusChanged);
            // Start listening for connections
            mainServer.StartListening();
            // Show that we started to listen for connections
            txtLog.AppendText("Đang lắng nghe các kết nối...\r\n");
        }
        public void mainServer_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            // Call the method that updates the form
            this.Invoke(new UpdateStatusCallback(this.UpdateStatus), new object[] { e.EventMessage });
        }

        private void UpdateStatus(string strMessage)
        {
            // Updates the log with the message
            txtLog.AppendText(strMessage + "\r\n");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
