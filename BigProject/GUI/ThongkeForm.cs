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

namespace BigProject.GUI
{
    public partial class ThongkeForm : Form
    {
        public ThongkeForm()
        {
            InitializeComponent();
        }
        public string CountSinhvien(string query)
        {
            DAL.DBConnectionSQL dbc = new DAL.DBConnectionSQL();
            SqlConnection conn = dbc.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            string count = cmd.ExecuteScalar().ToString();
            conn.Close();
            return count;
        }
        public string TotalSinhvien()
        {
            return CountSinhvien("Select COUNT(*) from Sinhvien");
        }
        public string TotalGiangvien()
        {
            return CountSinhvien("Select COUNT(*) from Giangvien");
        }
        private void ThongkeForm_Load(object sender, EventArgs e)
        {
            label_Tongsv.Text = "Số lượng sinh viên : " + TotalSinhvien();
            label_TongGv.Text = "Số lượng giang viên : " + TotalGiangvien();
        }
    }
}
