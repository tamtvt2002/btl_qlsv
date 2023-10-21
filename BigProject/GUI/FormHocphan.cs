using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigProject.GUI
{
    public partial class FormHocphan : Form
    {
        BLL.HocphanBLL bllhp = new BLL.HocphanBLL();
        public FormHocphan()
        {
            InitializeComponent();
        }
        bool checkData()
        {
            if (string.IsNullOrEmpty(txtmahocphan.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã học phần", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahocphan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txttenhocphan.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên học phần", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenhocphan.Focus();
                return false;
            }
            return true;
        }
        private void FormHocphan_Load(object sender, EventArgs e)
        {
            dataGridView_hocphan.DataSource = bllhp.LoadData();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                DTO.HocphanDTO dtohp = new DTO.HocphanDTO();
                dtohp.Mahocphan = txtmahocphan.Text;
                dtohp.Tenhocphan = txttenhocphan.Text;
                dtohp.Sotinchi = int.Parse(comboBox_sotinchi.Text);
                dtohp.Kyhoc = int.Parse(cbx_kyhoc.Text);
                if (bllhp.ThemHocphan(dtohp))
                {
                    FormHocphan_Load(sender, e);
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DTO.HocphanDTO dtohp = new DTO.HocphanDTO();
            dtohp.Mahocphan = txtmahocphan.Text;
            dtohp.Tenhocphan = txttenhocphan.Text;
            dtohp.Sotinchi = int.Parse(comboBox_sotinchi.Text);
            dtohp.Kyhoc = int.Parse(cbx_kyhoc.Text);
            if (bllhp.SuaHocphan(dtohp))
            {
                FormHocphan_Load(sender, e);
                MessageBox.Show("Sửa thành công!", "Thông báo");
            }
            else
                MessageBox.Show("Sửa thất bại!", "Thông báo");
        }

        private void dataGridView_hocphan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtmahocphan.Text = dataGridView_hocphan.Rows[index].Cells[0].Value.ToString();
                txttenhocphan.Text = dataGridView_hocphan.Rows[index].Cells[1].Value.ToString();
                comboBox_sotinchi.Text = dataGridView_hocphan.Rows[index].Cells[2].Value.ToString();
                cbx_kyhoc.Text = dataGridView_hocphan.Rows[index].Cells[3].Value.ToString();
            }
        }
    }
}
