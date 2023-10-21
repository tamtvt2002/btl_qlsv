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
    public partial class FormGiangvien : Form
    {
        DAL.ConvertImageToByteArray itb = new DAL.ConvertImageToByteArray();
        DAL.ConvertByteArrayToImage bti = new DAL.ConvertByteArrayToImage();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        BLL.GiangvienBLL bllgv;
        public FormGiangvien()
        {
            InitializeComponent();
            bllgv = new BLL.GiangvienBLL();
        }
        bool checkdata()
        {
            if (pictureBox_giangvien.Image == null)
            {
                MessageBox.Show("Bạn chưa chọn ảnh", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtmagiangvien.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã giảng viên", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmagiangvien.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txthotengv.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthotengv.Focus();
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
        public void ShowCombox()
        {
            DAL.DBConnectionSQL dbc = new DAL.DBConnectionSQL();
            SqlConnection conn = dbc.Connect();
            conn.Open();
            cmd = new SqlCommand("Select * from Hocphan", conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            comboBox_hocphan.DataSource = dt;
            comboBox_hocphan.DisplayMember = "Tenhocphan";
            comboBox_hocphan.ValueMember = "Mahocphan";
        }

        private void FormGiangvien_Load(object sender, EventArgs e)
        {
            ShowCombox();
            dataGridView_giangvien.DataSource = bllgv.LoadData();
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView_giangvien.Columns[8];
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
                FormGiangvien_Load(sender, e);
            else
                dataGridView_giangvien.DataSource = bllgv.timkiemGiangvien(txttimkiem.Text);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (checkdata())
            {
                DTO.GiangvienDTO dtogv = new DTO.GiangvienDTO();
                dtogv.Tenhocphan = comboBox_hocphan.Text;
                dtogv.Magiangvien = int.Parse(txtmagiangvien.Text);
                dtogv.Hoten = txthotengv.Text;
                dtogv.Ngaysinh = DateTime.Parse(dateTimePicker_ngaysinh.Text);
                dtogv.Gioitinh = comboBox_gioitinh.Text;
                dtogv.Quequan = txtquequan.Text;
                dtogv.Email = txtemail.Text;
                dtogv.Sodienthoai = txtsodienthoai.Text;
                dtogv.Picture = itb.ImageToByteArray(pictureBox_giangvien.Image);
                if (bllgv.Themgiangvien(dtogv))
                {
                    dataGridView_giangvien.DataSource = bllgv.timkiemGiangvien(txttimkiem.Text);
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DTO.GiangvienDTO dtogv = new DTO.GiangvienDTO();
            dtogv.Tenhocphan = comboBox_hocphan.Text;
            dtogv.Magiangvien = int.Parse(txtmagiangvien.Text);
            dtogv.Hoten = txthotengv.Text;
            dtogv.Ngaysinh = DateTime.Parse(dateTimePicker_ngaysinh.Text);
            dtogv.Gioitinh = comboBox_gioitinh.Text;
            dtogv.Quequan = txtquequan.Text;
            dtogv.Email = txtemail.Text;
            dtogv.Sodienthoai = txtsodienthoai.Text;
            dtogv.Picture = itb.ImageToByteArray(pictureBox_giangvien.Image);
            if (bllgv.Suagiangvien(dtogv))
            {
                if (txttimkiem.Text == "")
                {
                    dataGridView_giangvien.DataSource = bllgv.timkiemGiangvien(txttimkiem.Text);
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }
                else
                {
                    FormGiangvien_Load(sender, e);
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }
            }
            else
                MessageBox.Show("Sửa thất bại!", "Thông báo");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa thông tin?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DTO.GiangvienDTO dtogv = new DTO.GiangvienDTO();
                dtogv.Tenhocphan = comboBox_hocphan.Text;
                dtogv.Magiangvien = int.Parse(txtmagiangvien.Text);
                dtogv.Hoten = txthotengv.Text;
                dtogv.Ngaysinh = DateTime.Parse(dateTimePicker_ngaysinh.Text);
                dtogv.Gioitinh = comboBox_gioitinh.Text;
                dtogv.Quequan = txtquequan.Text;
                dtogv.Email = txtemail.Text;
                dtogv.Sodienthoai = txtsodienthoai.Text;
                dtogv.Picture = itb.ImageToByteArray(pictureBox_giangvien.Image);
                if (bllgv.Xoagiangvien(dtogv))
                {
                    FormGiangvien_Load(sender, e);
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Xóa thất bại!", "Thông báo");
            }
        }
        private void btnchonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png)|*.jpg;*.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_giangvien.Image = Image.FromFile(opf.FileName);
            }
        }

        private void dataGridView_giangvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                comboBox_hocphan.Text = dataGridView_giangvien.Rows[index].Cells[0].Value.ToString();
                txtmagiangvien.Text = dataGridView_giangvien.Rows[index].Cells[1].Value.ToString();
                txthotengv.Text = dataGridView_giangvien.Rows[index].Cells[2].Value.ToString();
                dateTimePicker_ngaysinh.Text = dataGridView_giangvien.Rows[index].Cells[3].Value.ToString();
                comboBox_gioitinh.Text = dataGridView_giangvien.Rows[index].Cells[4].Value.ToString();
                txtquequan.Text = dataGridView_giangvien.Rows[index].Cells[5].Value.ToString();
                txtemail.Text = dataGridView_giangvien.Rows[index].Cells[6].Value.ToString();
                txtsodienthoai.Text = dataGridView_giangvien.Rows[index].Cells[7].Value.ToString();
                pictureBox_giangvien.Image = bti.ByteArrayToImage((byte[])dataGridView_giangvien.Rows[index].Cells[8].Value);
            }
        }
    }
}
