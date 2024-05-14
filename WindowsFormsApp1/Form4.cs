using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
            client = new TcpClient("127.0.0.1", 8080);
            stream = client.GetStream();

            // Start a thread for receiving files from the server

            StartUnsafeThread();
        }
        public void StartUnsafeThread()
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread receiveThread = new Thread(ReceiveFile);
            receiveThread.Start();
        }
        private void SendFile(string filepath)
        {
            byte[] fileBytes = File.ReadAllBytes(filepath);
            stream.Write(BitConverter.GetBytes(fileBytes.Length), 0, 4);
            stream.Write(fileBytes, 0, fileBytes.Length);
        }

        private void ReceiveFile()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string receivedFilepath = "input5.txt";
                        using (FileStream fileStream = new FileStream(receivedFilepath, FileMode.Create, FileAccess.Write))
                        {
                            fileStream.Write(buffer, 0, bytesRead);
                        }
                        UpdateDashboard(receivedFilepath);
                    }
                }
            }
            catch (IOException ex) // thong bao loi/ tranh bi pause
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateDashboard(string filepath)
        {
            Phims = DeserializeJson(filepath);
            try
            {
                foreach (var phim in Phims)
                {
                    txtMovie.Items.Add(phim.TenPhim);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        List<Phim> Phims = new List<Phim>();
        static Phim SelectedPhim = new Phim();
        static Phim.CPhong SelectedPhong = new Phim.CPhong();
        TcpClient client;
        NetworkStream stream;

        private List<Phim> DeserializeJson(string Filepath)
        {
            string json = File.ReadAllText(Filepath);
            List<Phim> Phims = JsonSerializer.Deserialize<List<Phim>>(json);
            return Phims;
        }

        private void SerializeJson(object obj, string Filepath)
        {
            string json = JsonSerializer.Serialize(obj);
            File.WriteAllText(Filepath, json);
        }

        private void bt1_Confirm_Click(object sender, EventArgs e)
        {
            long tong = 0; // tinh tổng tiền từ checked seats
            long cost = SelectedPhim.GiaVe;
            foreach (string c in clb1_Seats.CheckedItems)
            {
                if (new[] { "A1", "A5", "B1", "B5", "C1", "C5" }.Contains(c))
                {
                    tong += cost * 1 / 4;
                }
                else if (new[] { "A2", "A3", "A4", "C2", "C3", "C4" }.Contains(c))
                {
                    tong += cost * 1;
                }
                else
                {
                    tong += cost * 2;
                }
            }
            string s = "Ho va ten: " + txtName.Text;
            s += System.Environment.NewLine + "Các vé đã chọn: ";
            foreach (string c in clb1_Seats.CheckedItems)
                s += c + " ";
            s += System.Environment.NewLine;
            s += "Phòng chiếu: " + txtTheater.Text;
            s += System.Environment.NewLine;
            s += "Số tiền phải trả: " + tong.ToString();


            if (MessageBox.Show(s, "Warning !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) // thông báo lần cuối chắc chắn hay ko ? 
            {
                return;
            }
            else
            {
                MessageBox.Show("Bạn đã đặt vé thành công.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SelectedPhim.TongTien += tong;
                HashSet<string> temp = SelectedPhong.suat.ToHashSet();
                foreach (string c in clb1_Seats.CheckedItems)
                {
                    temp.Remove(c);
                }
                SelectedPhong.suat = temp.ToArray();
                foreach (var c in SelectedPhim.Phong)
                {
                    if (c.TenPhong == SelectedPhong.TenPhong)
                    {
                        SelectedPhim.Phong.Remove(c);
                        SelectedPhim.Phong.Add(SelectedPhong);
                        break;
                    }
                }
                foreach (var c in Phims)
                {
                    if (SelectedPhim.TenPhim == c.TenPhim)
                    {
                        Phims.Remove(c);
                        Phims.Add(SelectedPhim);
                        break;
                    }
                }
                SerializeJson(Phims, "output5.txt");
                SendFile("output5.txt");
                // blank các ô -> đẹp
                txtName.Text = "";
                txtMovie.Text = "";
                txtTheater.Text = "";
                txtTheater.Enabled = false;
                SelectedPhim = null;
                SelectedPhong = new Phim.CPhong();
                txtTheater.Items.Clear();
                clb1_Seats.Items.Clear();
            }


        }

        private void bt2_Reset_Click(object sender, EventArgs e)
        {
            txtMovie.Text = "";
            txtMovie.Text = "";
            txtTheater.Text = "";
            txtTheater.Enabled = false;
        }

        private void cb1_Theater_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clb1_Seats.Items.Clear();
            if (txtTheater.SelectedItem != null && SelectedPhim != null && SelectedPhim.Phong != null)
            {
                //MessageBox.Show("3"); ;
                foreach (Phim.CPhong c in SelectedPhim.Phong)
                {
                    if (c.TenPhong == txtTheater.SelectedItem.ToString())
                    {
                        //MessageBox.Show("4"); ;
                        SelectedPhong = c;
                        break;
                    }
                }

                if (SelectedPhong.suat != null)
                {
                    clb1_Seats.Items.AddRange(SelectedPhong.suat);
                }
            }
        }

        private void clb1_Seats_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clb1_Seats.CheckedItems.Count == 1)
            {
                if (e.NewValue == CheckState.Unchecked)
                    bt1_Confirm.Enabled = false;
            }
            else
                bt1_Confirm.Enabled = true;
        }

        private void cb2_Movie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtTheater.Items.Clear();
            if (txtMovie.SelectedItem != null)
            {
                foreach (Phim Phim in Phims)
                {
                    if (Phim.TenPhim == txtMovie.SelectedItem.ToString())
                    {
                        //MessageBox.Show("1");
                        SelectedPhim = Phim;
                        break;
                    }
                }

                if (SelectedPhim != null && SelectedPhim.Phong != null)
                {
                    //MessageBox.Show("2"); 
                    foreach (Phim.CPhong phong in SelectedPhim.Phong)
                    {
                        txtTheater.Items.Add(phong.TenPhong);
                    }
                }
                txtTheater.Enabled = true;
            }
        }

        private void bt3_Exit_Click(object sender, EventArgs e)
        {

            stream.Close();
            client.Close();
            this.Close();
        }
    }
}
