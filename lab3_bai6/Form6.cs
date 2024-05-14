using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Server
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtuser.Text == "user1" && txtpass.Text == "12345")
            {
                Form2 f2 = new Form2();
                f2.Show();
                button1.Enabled = false;
                txtuser.Clear();
                txtpass.Clear();
            }
            else if (txtuser.Text == "user2" && txtpass.Text == "12345")
            {
                Form4 f4 = new Form4();
                f4.Show();
                button1.Enabled = false;
                txtuser.Clear();
                txtpass.Clear();
            }
            else
            {
                MessageBox.Show("Dang nhap sai vui long nhap lai");
                txtuser.Clear();
                txtpass.Clear();
            }
        }
    }
}
