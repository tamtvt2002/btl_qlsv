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
    public partial class FormLop : Form
    {
        BLL.LopBLL blllop;
        public FormLop()
        {
            InitializeComponent();
            blllop = new BLL.LopBLL();
        }
        bool checkData()
        {
            if (string.IsNullOrEmpty(txtmalop.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã lớp", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmalop.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txttenlop.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên lớp", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenlop.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtnienkhoa.Text))
            {
                MessageBox.Show("Bạn chưa nhập niên khóa", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnienkhoa.Focus();
                return false;
            }
            return true;
        }
        private void FormLop_Load(object sender, EventArgs e)
        {
            dataGridView_lop.DataSource = blllop.LoadData();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                DTO.LopDTO dtolop = new DTO.LopDTO();
                dtolop.Malop = txtmalop.Text;
                dtolop.Tenlop = txttenlop.Text;
                dtolop.Course = txtnienkhoa.Text;
                if (blllop.ThemLop(dtolop))
                {
                    FormLop_Load(sender, e);
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Mã lớp đã tồn tại!", "Thêm thất bại");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DTO.LopDTO dtolop = new DTO.LopDTO();
            dtolop.Malop = txtmalop.Text;
            dtolop.Tenlop = txttenlop.Text;
            dtolop.Course = txtnienkhoa.Text;
            if (blllop.SuaLop(dtolop))
            {
                FormLop_Load(sender, e);
                MessageBox.Show("Sửa thành công!", "Thông báo");
            }
            else
                MessageBox.Show("Sửa thất bại!", "Thông báo");
        }

        private void dataGridView_lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtmalop.Text = dataGridView_lop.Rows[index].Cells[0].Value.ToString();
                txttenlop.Text = dataGridView_lop.Rows[index].Cells[1].Value.ToString();
                txtnienkhoa.Text = dataGridView_lop.Rows[index].Cells[2].Value.ToString();
            }
        }
    }
}
