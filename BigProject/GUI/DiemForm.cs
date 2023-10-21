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
    public partial class DiemForm : Form
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        BLL.DiemBLL blldiem = new BLL.DiemBLL();
        public DiemForm()
        {
            InitializeComponent();
        }
        bool checkdata()
        {
            if (string.IsNullOrEmpty(txtmasinhvien.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmasinhvien.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtdiemchuyencan.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm chuyên cần", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiemchuyencan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtdiemgiuaky.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm giữa kỳ", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiemgiuaky.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtdiemcuoiky.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm cuối kỳ", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiemcuoiky.Focus();
                return false;
            }
            return true;
        }
        public void ShowCombox()
        {
            DAL.DBConnectionSQL dbc = new DAL.DBConnectionSQL();
            SqlConnection conn = dbc.Connect();
            conn.Open();
            cmd = new SqlCommand("Exec sp_AllHocphan ", conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            comboBox_tenhocphan.DataSource = dt;
            cb_tenhocphan.DataSource = dt;
            comboBox_tenhocphan.DisplayMember = "Tenhocphan";
            cb_tenhocphan.DisplayMember = "Tenhocphan";
            comboBox_tenhocphan.ValueMember = "Mahocphan";
            cb_tenhocphan.ValueMember = "Mahocphan";
        }
        public void ShowComboxMalop()
        {
            DAL.DBConnectionSQL dbc = new DAL.DBConnectionSQL();
            SqlConnection conn = dbc.Connect();
            conn.Open();
            cmd = new SqlCommand("Select * from Lop", conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            comboBox_malop.DataSource = dt;
            comboBox_malop.DisplayMember = "Malop";
            comboBox_malop.ValueMember = "Tenlop";
            comboBox_malop.DataSource = dt;
            comboBox_malop.DisplayMember = "Malop";
            comboBox_malop.ValueMember = "Tenlop";
        }
        private void DiemForm_Load(object sender, EventArgs e)
        {
            ShowCombox();
            ShowComboxMalop();
            dataGridView_diem.DataSource = blldiem.LoadData();
            
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
                DiemForm_Load(sender, e);
            else
                dataGridView_diem.DataSource = blldiem.timkiemDiemSV(txttimkiem.Text);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (checkdata())
            {
                DTO.DiemDTO dtodiem = new DTO.DiemDTO(int.Parse(txtmasinhvien.Text), comboBox_tenhocphan.Text, float.Parse(txtdiemchuyencan.Text), float.Parse(txtdiemgiuaky.Text), float.Parse(txtdiemcuoiky.Text));
                if (blldiem.Themdiem(dtodiem))
                {
                    dataGridView_diem.DataSource = blldiem.timkiemDiemSV(txttimkiem.Text);
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Mã sinh viên không hợp lệ!", "Thông báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DTO.DiemDTO dtodiem = new DTO.DiemDTO(int.Parse(txtmasinhvien.Text), comboBox_tenhocphan.Text, float.Parse(txtdiemchuyencan.Text), float.Parse(txtdiemgiuaky.Text), float.Parse(txtdiemcuoiky.Text));
            if (blldiem.Suadiem(dtodiem))
            {
                dataGridView_diem.DataSource = blldiem.timkiemDiemSV(txttimkiem.Text);
                MessageBox.Show("Sửa thành công!", "Thông báo");
            }
            else
                MessageBox.Show("Sửa thất bại!", "Thông báo");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa thông tin?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DTO.DiemDTO dtodiem = new DTO.DiemDTO(int.Parse(txtmasinhvien.Text), comboBox_tenhocphan.Text, float.Parse(txtdiemchuyencan.Text), float.Parse(txtdiemgiuaky.Text), float.Parse(txtdiemcuoiky.Text));
                if (blldiem.Xoadiem(dtodiem))
                {
                    dataGridView_diem.DataSource = blldiem.timkiemDiemSV(txttimkiem.Text);
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Xóa thất bại!", "Thông báo");
            }
        }

        private void dataGridView_diem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtmasinhvien.Text = dataGridView_diem.Rows[index].Cells[0].Value.ToString();
                comboBox_tenhocphan.Text = dataGridView_diem.Rows[index].Cells[1].Value.ToString();
                txtdiemchuyencan.Text = dataGridView_diem.Rows[index].Cells[2].Value.ToString();
                txtdiemgiuaky.Text = dataGridView_diem.Rows[index].Cells[3].Value.ToString();
                txtdiemcuoiky.Text = dataGridView_diem.Rows[index].Cells[4].Value.ToString();
                txttimkiem.Text = dataGridView_diem.Rows[index].Cells[0].Value.ToString();
            }
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            CrystalReport.CRBangdiemLopVaHocphan reportdiem = new CrystalReport.CRBangdiemLopVaHocphan();
            reportdiem.SetDataSource(blldiem.CRBangdiemLopVaHocphan(comboBox_malop.Text,cb_tenhocphan.Text));
            ReportForm reportform = new ReportForm();
            reportform.crystalReportViewer.ReportSource = reportdiem;
            reportform.ShowDialog();
        }
    }
}
