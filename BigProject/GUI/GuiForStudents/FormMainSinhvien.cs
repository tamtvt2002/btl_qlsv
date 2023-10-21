using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigProject.GUI.GuiForStudents
{
    public partial class FormMainSinhvien : Form
    {
        DAL.ConvertByteArrayToImage bti = new DAL.ConvertByteArrayToImage();
        public FormMainSinhvien()
        {
            InitializeComponent();
        }
        public string masinhvien { set { label_msv.Text = value; } }
        private string DisplayHoten()
        {
            DAL.DBConnectionSQL dbc = new DAL.DBConnectionSQL();
            SqlConnection conn = dbc.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Tensinhvien From Sinhvien where Masinhvien = '" + label_msv.Text+"'", conn);
            string hoten = cmd.ExecuteScalar().ToString();
            conn.Close();
            return hoten;
        }
        public byte[] DisplayImage()
        {
            DAL.DBConnectionSQL dbc = new DAL.DBConnectionSQL();
            SqlConnection conn = dbc.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Picture From Sinhvien where Masinhvien = '" + label_msv.Text + "'", conn);
            byte[] img = (byte[])cmd.ExecuteScalar();
            conn.Close();
            return img;
        }
        private void btndangxuat_Click(object sender, EventArgs e)
        {
            FormMainLogin fm = new FormMainLogin();
            this.Hide();
            fm.ShowDialog();
        }
        private void btnthongtin_Click(object sender, EventArgs e)
        {
            FormShowThongtin thongtin = new FormShowThongtin();
            thongtin.masinhvien = label_msv.Text;
            thongtin.tensinhvien = label_hoten.Text;
            thongtin.TopLevel = false;
            thongtin.FormBorderStyle = FormBorderStyle.None;
            thongtin.Dock = DockStyle.Fill;
            panel.Controls.Add(thongtin);
            panel.Tag = thongtin;
            thongtin.BringToFront();
            thongtin.Show();
            btnthongtin.BackColor = Color.SkyBlue;
            btndiem.BackColor = Color.Transparent;
        }

        private void btndiem_Click(object sender, EventArgs e)
        {
            FormShowDiem diem = new FormShowDiem();
            diem.masinhvien = label_msv.Text;
            diem.TopLevel = false;
            diem.FormBorderStyle = FormBorderStyle.None;
            diem.Dock = DockStyle.Fill;
            panel.Controls.Add(diem);
            panel.Tag = diem;
            diem.BringToFront();
            diem.Show();
            btndiem.BackColor = Color.SkyBlue;
            btnthongtin.BackColor = Color.Transparent;
        }

        private void FormMainSinhvien_Load(object sender, EventArgs e)
        {
            pictureBox.Image = bti.ByteArrayToImage(DisplayImage());
            label_hoten.Text = DisplayHoten();
        }
    }
}
