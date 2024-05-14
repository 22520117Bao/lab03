using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DataClient dataclient = new DataClient(8080);
            dataclient.Start();
            rtb1_Show.Text = "Bang thong ke";
        }
        static int n = 0;
        List<Phim> Phims = new List<Phim>();
        private void EnableInput()
        {
            txtName.Enabled = true;
            cbRoom1.Enabled = true;
            cbRoom2.Enabled = true;
            cbRoom3.Enabled = true;
            txtCost.Enabled = true;
            btAdd.Enabled = true;
        }

        private bool CheckLoiNhap()
        {
            // ghi thong bao loi o day
            return false;
        }


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
        private static void RankPhim(List<Phim> phimList)
        {

            for (int i = 0; i < phimList.Count - 1; i++)
            {
                for (int j = 0; j < phimList.Count - 1 - i; j++)
                {
                    if (phimList[j].TongTien < phimList[j + 1].TongTien)
                    {
                        Phim temp = phimList[j];
                        phimList[j] = phimList[j + 1];
                        phimList[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < phimList.Count; i++)
            {
                phimList[i].Rank = i + 1;
            }
        }


        private void bt3_Read_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            try
            {
                Phims = DeserializeJson("output5.txt");
                RankPhim(Phims);
                rtb1_Show.Clear();
                int progressStep = 100 / Phims.Count;
                foreach (var c in Phims)
                {
                    progressBar1.Value += progressStep;
                    progressBar1.Refresh();

                    rtb1_Show.Text += "Ten phim: " + c.TenPhim + '\n';
                    double vetong = 0;
                    double veban = 0;
                    foreach (Phim.CPhong c2 in c.Phong)
                    {
                        vetong += 15;
                        veban += c2.suat.Length;
                    }
                    rtb1_Show.Text += "So ve ban duoc: " + (vetong - veban).ToString() + '\n' + "So ve ton: " + veban.ToString() + '\n';
                    rtb1_Show.Text += "Ti le ve ban duoc: " + (((vetong - veban) / vetong) * 100).ToString("0.00") + "%" +
                        '\n' + "Doanh thu: " + c.TongTien.ToString() + '\n' + "Xep hang doanh thu: " + c.Rank + "\n\n";
                }

            }
            catch (JsonException)
            {
                MessageBox.Show("File thông kế (output5.txt) hiện không có dữ liệu để trích xuất hoặc lỗi về Json ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void bt1_WtF_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
            {
                MessageBox.Show("Nhap so luong phim vao Total");
                txtTotal.Enabled = true;
                return;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Phim Phim = new Phim();
                int num = Int32.Parse(txtCount.Text);
                Phim.TenPhim = txtName.Text;
                if (cbRoom1.CheckState == CheckState.Checked)
                {
                    Phim.Phong.Add(new Phim.CPhong { TenPhong = cbRoom1.Text.Trim() });
                }
                if (cbRoom2.CheckState == CheckState.Checked)
                {
                    Phim.Phong.Add(new Phim.CPhong { TenPhong = cbRoom2.Text.Trim() });
                }
                if (cbRoom3.CheckState == CheckState.Checked)
                {
                    Phim.Phong.Add(new Phim.CPhong { TenPhong = cbRoom3.Text.Trim() });
                }
                Phim.GiaVe = Int32.Parse(txtCost.Text);
                txtCount.Text = (num - 1).ToString();
                {
                    Phims.Add(Phim);
                    MessageBox.Show("Nhap thanh cong!!, con lai " + txtCount.Text + " lan nhap");
                    txtName.Text = "";
                    txtCost.Text = "";
                    cbRoom1.CheckState = CheckState.Unchecked;
                    cbRoom2.CheckState = CheckState.Unchecked;
                    cbRoom3.CheckState = CheckState.Unchecked;
                    txtTotal.Enabled = false;
                }
                if (txtCount.Text == "0")
                {
                    MessageBox.Show("Qua trinh nhap ket thuc !", "Canh bao", MessageBoxButtons.OK);
                    SerializeJson(Phims, "input5.txt");
                    SerializeJson(Phims, "output5.txt");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtTotal.Text, out int temp))
            {
                MessageBox.Show(@"Nhap so nguyen vao thanh ""So luong phim"": ");
                return;
            }
            n = temp;
            txtCount.Text = n.ToString();
            MessageBox.Show("Nhap day du thong tin phim vao cac o phia duoi!! ");

            EnableInput();
        }

        private void btDatVe_Click(object sender, EventArgs e)
        {

        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
