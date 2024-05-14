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

namespace lab3_bai3
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
            
            IPAddress ipAddr = IPAddress.Parse("127.0.0.1");           
            ChatServer mainServer = new ChatServer(ipAddr);          
            ChatServer.StatusChanged += new StatusChangedEventHandler(mainServer_StatusChanged);        
            mainServer.StartListening();       
            txtmess.AppendText("Đang lắng nghe các kết nối...\r\n");
        }
        public void mainServer_StatusChanged(object sender, StatusChangedEventArgs e)
        {   
            this.Invoke(new UpdateStatusCallback(this.UpdateStatus), new object[] { e.EventMessage });
        }

        private void UpdateStatus(string strMessage)
        {
            txtmess.AppendText(strMessage + "\r\n");
        }
    }
}
