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

namespace BigProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            GUI.GuiForStudents.FormMainLogin SvLogin = new GUI.GuiForStudents.FormMainLogin();
            SvLogin.ShowDialog();
            this.Hide();
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
                    string sql = "Select * from Accounts Where Username = '" + username + "' And Password = '" + password + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        MainForm mf = new MainForm();
                        this.Hide();
                        mf.ShowDialog();
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
        private void btndangnhap_Click_1(object sender, EventArgs e)
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
                    string sql = "Select * from Accounts Where Username = '" + username + "' And Password = '" + password + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        MainForm mf = new MainForm();
                        this.Hide();
                        mf.ShowDialog();
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

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
