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
    public partial class FormShowThongtin : Form
    {
        public FormShowThongtin()
        {
            InitializeComponent();
        }
        public string tensinhvien { set { txt_hoten.Text = value; } }
        public string masinhvien { set { txt_masinhvien.Text = value; } }
        private string Display(string query)
        {
            DAL.DBConnectionSQL dbc = new DAL.DBConnectionSQL();
            SqlConnection conn = dbc.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            string ngaysinh = cmd.ExecuteScalar().ToString();
            conn.Close();
            return ngaysinh;
        }
        public string Ngaysinh()
        {
            return Display("Select Ngaysinh From Sinhvien Where Masinhvien = '" + txt_masinhvien.Text+"'");
        }
        public string Gioitinh()
        {
            return Display("Select Gioitinh From Sinhvien Where Masinhvien = '" + txt_masinhvien.Text + "'");
        }
        public string Quequan()
        {
            return Display("Select Quequan From Sinhvien Where Masinhvien = '" + txt_masinhvien.Text + "'");
        }
        public string Email()
        {
            return Display("Select Email From Sinhvien Where Masinhvien = '" + txt_masinhvien.Text + "'");
        }
        public string Sodienthoai()
        {
            return Display("Select Sodienthoai From Sinhvien Where Masinhvien = '" + txt_masinhvien.Text + "'");
        }
        private void FormShowThongtin_Load(object sender, EventArgs e)
        {
            txt_ngaysinh.Text = Ngaysinh();
            txt_gioitinh.Text = Gioitinh();
            txt_quequan.Text = Quequan();
            txt_email.Text = Email();
            txt_sodienthoai.Text = Sodienthoai();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
