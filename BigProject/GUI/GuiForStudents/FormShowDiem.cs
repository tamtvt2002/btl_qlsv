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
    public partial class FormShowDiem : Form
    {
        DAL.DBConnectionSQL dbc = new DAL.DBConnectionSQL();
        SqlCommand cmd;
        public FormShowDiem()
        {
            InitializeComponent();
        }
        public string masinhvien { set { label_masinhvien.Text = value; } }
        private void FormShowDiem_Load(object sender, EventArgs e)
        {
            dataGridView_bangdiem.DataSource = Bangdiemcanhan();
            dataGridView_hocphanchuatichluy.DataSource = Hocphanchuatichluy();
            label_TBC.Text = " TBC học tập thang điểm 10 :" + AVGthangdiem10();
            label_sumtinchi.Text = "Số tín chỉ đã tích lũy :" + SumTinchi();
        }
        public string SumTinchi()
        {
            SqlConnection conn = dbc.Connect();
            conn.Open();
            cmd = new SqlCommand("sp_SumTinchi", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Masinhvien", label_masinhvien.Text);
            string sum = cmd.ExecuteScalar().ToString();
            conn.Close();
            return sum;
        }
        public string AVGthangdiem10()
        {
            SqlConnection conn = dbc.Connect();
            conn.Open();
            cmd = new SqlCommand("sp_AVG", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Masinhvien", label_masinhvien.Text);
            string avg = cmd.ExecuteScalar().ToString();
            conn.Close();
            return avg;
        }
        private DataTable Hocphanchuatichluy()
        {
            DataTable dt = new DataTable("Hocphan");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("sp_Hocphanchuatichluy", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Masinhvien", label_masinhvien.Text);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
        private DataTable Bangdiemcanhan()
        {
            DataTable dt = new DataTable("Bangdiem");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("sp_Bangdiemcanhan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Masinhvien", label_masinhvien.Text);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            BLL.DiemBLL blldiem = new BLL.DiemBLL();
            CrystalReport.BangDiemTheoSVCrystalReport reportdiem = new CrystalReport.BangDiemTheoSVCrystalReport();
            reportdiem.SetDataSource(blldiem.ReportBangdiem(label_masinhvien.Text));
            ReportForm reportform = new ReportForm();
            reportform.crystalReportViewer.ReportSource = reportdiem;
            reportform.ShowDialog();
        }
    }
}
