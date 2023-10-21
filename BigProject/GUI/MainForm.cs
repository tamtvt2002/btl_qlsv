using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelcntt.Visible = false;
            panelqlchung.Visible = false;
        }
        private void hideMenu()
        {
            if (panelcntt.Visible == true)
                panelcntt.Visible = false;
            if (panelqlchung.Visible == true)
                panelqlchung.Visible = false;
        }
        private void showMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                hideMenu();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }
        private void btncntt_Click(object sender, EventArgs e)
        {
            showMenu(panelcntt);
        }
        private Form activeForm = null;
        private void openForm(Form frm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
            panel.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }
        private void btnttsvcntt_Click(object sender, EventArgs e)
        {
            openForm(new GUI.FormSinhvien());
            btnttsvcntt.BackColor = Color.White;
            btnttsvcntt.ForeColor = Color.DarkBlue;
            btndanhsachlop.BackColor = Color.Transparent;
            btndanhsachlop.ForeColor = Color.White;
            btnmonhoc.BackColor = Color.Transparent;
            btnmonhoc.ForeColor = Color.White;
            btndiem.BackColor = Color.Transparent;
            btndiem.ForeColor = Color.White;
            btngiangvien.BackColor = Color.Transparent;
            btngiangvien.ForeColor = Color.White;
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }

        private void btnqlchung_Click(object sender, EventArgs e)
        {
            showMenu(panelqlchung);
        }

        private void btndanhsachlop_Click(object sender, EventArgs e)
        {
            openForm(new GUI.FormLop());
            btndanhsachlop.BackColor = Color.White;
            btndanhsachlop.ForeColor = Color.DarkBlue;
            btnmonhoc.BackColor = Color.Transparent;
            btnmonhoc.ForeColor = Color.White;
            btnttsvcntt.BackColor = Color.Transparent;
            btnttsvcntt.ForeColor = Color.White;
            btndiem.BackColor = Color.Transparent;
            btndiem.ForeColor = Color.White;
            btngiangvien.BackColor = Color.Transparent;
            btngiangvien.ForeColor = Color.White;
            
        }

        private void btnmonhoc_Click(object sender, EventArgs e)
        {
            openForm(new GUI.FormHocphan());
            btnmonhoc.BackColor = Color.White;
            btnmonhoc.ForeColor = Color.DarkBlue;
            btndanhsachlop.BackColor = Color.Transparent;
            btndanhsachlop.ForeColor = Color.White;
            btnttsvcntt.BackColor = Color.Transparent;
            btnttsvcntt.ForeColor = Color.White;
            btndiem.BackColor = Color.Transparent;
            btndiem.ForeColor = Color.White;
            btngiangvien.BackColor = Color.Transparent;
            btngiangvien.ForeColor = Color.White;
            
        }
        private void btngiangvien_Click(object sender, EventArgs e)
        {
            openForm(new GUI.FormGiangvien());
            btngiangvien.BackColor = Color.White;
            btngiangvien.ForeColor = Color.DarkBlue;
            btnmonhoc.BackColor = Color.Transparent;
            btnmonhoc.ForeColor = Color.White;
            btndanhsachlop.BackColor = Color.Transparent;
            btndanhsachlop.ForeColor = Color.White;
            btnttsvcntt.BackColor = Color.Transparent;
            btnttsvcntt.ForeColor = Color.White;
            btndiem.BackColor = Color.Transparent;
            btndiem.ForeColor = Color.White;
            
        }

        private void btndiem_Click(object sender, EventArgs e)
        {
            openForm(new GUI.DiemForm());
            btndiem.BackColor = Color.White;
            btndiem.ForeColor = Color.DarkBlue;
            btnmonhoc.BackColor = Color.Transparent;
            btnmonhoc.ForeColor = Color.White;
            btndanhsachlop.BackColor = Color.Transparent;
            btndanhsachlop.ForeColor = Color.White;
            btnttsvcntt.BackColor = Color.Transparent;
            btnttsvcntt.ForeColor = Color.White;
            btngiangvien.BackColor = Color.Transparent;
            btngiangvien.ForeColor = Color.White;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openForm(new GUI.ThongkeForm());
            
            btndiem.BackColor = Color.White;
            btndiem.ForeColor = Color.DarkBlue;
            btnmonhoc.BackColor = Color.Transparent;
            btnmonhoc.ForeColor = Color.White;
            btndanhsachlop.BackColor = Color.Transparent;
            btndanhsachlop.ForeColor = Color.White;
            btnttsvcntt.BackColor = Color.Transparent;
            btnttsvcntt.ForeColor = Color.White;
            btngiangvien.BackColor = Color.Transparent;
            btngiangvien.ForeColor = Color.White;
        }
    }
}
