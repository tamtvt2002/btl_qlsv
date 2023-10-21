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
    public partial class FormMainLogin : Form
    {
        public FormMainLogin()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            DAL.DBConnectionSQL dbc = new DAL.DBConnectionSQL();
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                string username = txttaikhoan.Text;
                string password = txtmatkhau.Text;
                if (txttaikhoan.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên đăng nhập!");
                    txttaikhoan.Focus();
                }
                else if (txtmatkhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu!");
                    txtmatkhau.Focus();
                }
                else
                {
                    string sql = "Select * from Sinhvien Where Masinhvien = '" + username + "' And Masinhvien = '" + password + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        FormMainSinhvien main = new FormMainSinhvien();
                        main.masinhvien = txttaikhoan.Text;
                        main.TopLevel = false;
                        main.FormBorderStyle = FormBorderStyle.None;
                        main.Dock = DockStyle.Fill;
                        panel.Controls.Add(main);
                        panel.Tag = main;
                        main.BringToFront();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Kết nối đến cơ sở dữ liệu thất bại");
            }
        }
    }
}
