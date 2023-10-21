using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigProject.GUI
{
    public partial class FormSinhvien : Form
    {
        DAL.ConvertImageToByteArray itb = new DAL.ConvertImageToByteArray();
        DAL.ConvertByteArrayToImage bti = new DAL.ConvertByteArrayToImage();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        BLL.SinhvienBLL bllsv;
        public FormSinhvien()
        {
            InitializeComponent();
            bllsv = new BLL.SinhvienBLL();
        }

        bool checkdata()
        {
            if (pictureBox_sinhvien.Image == null)
            {
                MessageBox.Show("Bạn chưa chọn ảnh", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtmasinhvien.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmasinhvien.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txthoten.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthoten.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtquequan.Text))
            {
                MessageBox.Show("Bạn chưa nhập quê quán", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtquequan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtemail.Text))
            {
                MessageBox.Show("Bạn chưa nhập email", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtemail.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsodienthoai.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsodienthoai.Focus();
                return false;
            }
            return true;
        }

        private void Thongtinsinhvien_Load(object sender, EventArgs e)
        {
            dataGridView_sinhvien.DataSource =  bllsv.LoadData();
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView_sinhvien.Columns[8];
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ShowCombox();
        }
        public void ShowCombox()
        {
            DAL.DBConnectionSQL dbc = new DAL.DBConnectionSQL();
            SqlConnection conn = dbc.Connect();
            conn.Open();
            cmd = new SqlCommand("Select * from Lop", conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            comboBox_timkiemMalop.DataSource = dt;
            comboBox_timkiemMalop.DisplayMember = "Malop";
            comboBox_timkiemMalop.ValueMember = "Tenlop";
            comboBox_malop.DataSource = dt;
            comboBox_malop.DisplayMember = "Malop";
            comboBox_malop.ValueMember = "Tenlop";
        }

        private void btnchonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png)|*.jpg;*.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_sinhvien.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (checkdata())
            {

                DTO.SinhvienDTO dtosv = new DTO.SinhvienDTO();
                dtosv.Malop = comboBox_malop.Text;
                dtosv.Masinhvien = int.Parse(txtmasinhvien.Text);
                dtosv.Hoten = txthoten.Text;
                dtosv.Ngaysinh = DateTime.Parse(dateTimePicker_ngaysinh.Text);
                dtosv.Gioitinh = comboBox_gioitinh.Text;
                dtosv.Quequan = txtquequan.Text;
                dtosv.Email = txtemail.Text;
                dtosv.Sodienthoai = txtsodienthoai.Text;
                dtosv.Picture = itb.ImageToByteArray(pictureBox_sinhvien.Image);
                if (bllsv.Themsinhvien(dtosv))
                {
                    dataGridView_sinhvien.DataSource = bllsv.TimkiemSvtheoMalop(comboBox_timkiemMalop.Text);
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DTO.SinhvienDTO dtosv = new DTO.SinhvienDTO();
            dtosv.Malop = comboBox_malop.Text;
            dtosv.Masinhvien = int.Parse(txtmasinhvien.Text);
            dtosv.Hoten = txthoten.Text;
            dtosv.Ngaysinh = DateTime.Parse(dateTimePicker_ngaysinh.Text);
            dtosv.Gioitinh = comboBox_gioitinh.Text;
            dtosv.Quequan = txtquequan.Text;
            dtosv.Email = txtemail.Text;
            dtosv.Sodienthoai = txtsodienthoai.Text;
            dtosv.Picture = itb.ImageToByteArray(pictureBox_sinhvien.Image);
            if (bllsv.Suasinhvien(dtosv))
            {
                if (txttimkiem.Text == "")
                {
                    dataGridView_sinhvien.DataSource = bllsv.TimkiemSvtheoMalop(comboBox_timkiemMalop.Text);
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }
                else
                {
                    dataGridView_sinhvien.DataSource = bllsv.timkiemSinhvien(txttimkiem.Text);
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }
            }
            else
                MessageBox.Show("Sửa thất bại!", "Thông báo");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Điểm của sinh viên này cũng sẽ bị xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DTO.SinhvienDTO dtosv = new DTO.SinhvienDTO();
                dtosv.Malop = comboBox_malop.Text;
                dtosv.Masinhvien = int.Parse(txtmasinhvien.Text);
                dtosv.Hoten = txthoten.Text;
                dtosv.Ngaysinh = DateTime.Parse(dateTimePicker_ngaysinh.Text);
                dtosv.Gioitinh = comboBox_gioitinh.Text;
                dtosv.Quequan = txtquequan.Text;
                dtosv.Email = txtemail.Text;
                dtosv.Sodienthoai = txtsodienthoai.Text;
                dtosv.Picture = itb.ImageToByteArray(pictureBox_sinhvien.Image);
                if (bllsv.Xoasinhvien(dtosv))
                {
                    dataGridView_sinhvien.DataSource = bllsv.TimkiemSvtheoMalop(comboBox_timkiemMalop.Text);
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Xóa thất bại!", "Thông báo");
            }
        }

        private void dataGridView_sinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                comboBox_malop.Text = dataGridView_sinhvien.Rows[index].Cells[0].Value.ToString();
                txtmasinhvien.Text = dataGridView_sinhvien.Rows[index].Cells[1].Value.ToString();
                txthoten.Text = dataGridView_sinhvien.Rows[index].Cells[2].Value.ToString();
                dateTimePicker_ngaysinh.Text = dataGridView_sinhvien.Rows[index].Cells[3].Value.ToString();
                comboBox_gioitinh.Text = dataGridView_sinhvien.Rows[index].Cells[4].Value.ToString();
                txtquequan.Text = dataGridView_sinhvien.Rows[index].Cells[5].Value.ToString();
                txtemail.Text = dataGridView_sinhvien.Rows[index].Cells[6].Value.ToString();
                txtsodienthoai.Text = dataGridView_sinhvien.Rows[index].Cells[7].Value.ToString();
                pictureBox_sinhvien.Image = bti.ByteArrayToImage((byte[])dataGridView_sinhvien.Rows[index].Cells[8].Value);
            }
        }

        private void comboBox_timkiemMalop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_sinhvien.DataSource = bllsv.TimkiemSvtheoMalop(comboBox_timkiemMalop.Text);
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
                Thongtinsinhvien_Load(sender, e);
            else
                dataGridView_sinhvien.DataSource = bllsv.timkiemSinhvien(txttimkiem.Text);
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            CrystalReport.DSSinhvientheoLopCrystalReport reportSv = new CrystalReport.DSSinhvientheoLopCrystalReport();
            reportSv.SetDataSource(bllsv.ReportSinhvienFromLop(comboBox_timkiemMalop.Text));
            ReportForm formreport = new ReportForm();
            formreport.crystalReportViewer.ReportSource = reportSv;
            formreport.ShowDialog();
        }
    }
}
