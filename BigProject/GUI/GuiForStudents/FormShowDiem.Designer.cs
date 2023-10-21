
namespace BigProject.GUI.GuiForStudents
{
    partial class FormShowDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TBC = new System.Windows.Forms.Label();
            this.label_sumtinchi = new System.Windows.Forms.Label();
            this.spBangdiemcanhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appForStudents = new BigProject.AppForStudents();
            this.label_masinhvien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hocphanchuatichluyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BangdiemcanhanTableAdapter = new BigProject.AppForStudentsTableAdapters.sp_BangdiemcanhanTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_bangdiem = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mahocphanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhocphanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotinchiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyhocDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemchuyencanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemgiuakyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemcuoikyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangdiem10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangdiem4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangdiemchuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_hocphanchuatichluy = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mahocphanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhocphanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotinchiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_report = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.spBangdiemcanhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appForStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocphanchuatichluyBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bangdiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hocphanchuatichluy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(298, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "BẢNG ĐIỂM CÁ NHÂN";
            // 
            // label_TBC
            // 
            this.label_TBC.AutoSize = true;
            this.label_TBC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_TBC.Location = new System.Drawing.Point(52, 32);
            this.label_TBC.Name = "label_TBC";
            this.label_TBC.Size = new System.Drawing.Size(147, 13);
            this.label_TBC.TabIndex = 2;
            this.label_TBC.Text = " TBC học tập thang điểm 10 :";
            // 
            // label_sumtinchi
            // 
            this.label_sumtinchi.AutoSize = true;
            this.label_sumtinchi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_sumtinchi.Location = new System.Drawing.Point(262, 32);
            this.label_sumtinchi.Name = "label_sumtinchi";
            this.label_sumtinchi.Size = new System.Drawing.Size(113, 13);
            this.label_sumtinchi.TabIndex = 3;
            this.label_sumtinchi.Text = "Số tín chỉ đã tích lũy :";
            // 
            // spBangdiemcanhanBindingSource
            // 
            this.spBangdiemcanhanBindingSource.DataMember = "sp_Bangdiemcanhan";
            this.spBangdiemcanhanBindingSource.DataSource = this.appForStudents;
            // 
            // appForStudents
            // 
            this.appForStudents.DataSetName = "AppForStudents";
            this.appForStudents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_masinhvien
            // 
            this.label_masinhvien.ForeColor = System.Drawing.Color.SkyBlue;
            this.label_masinhvien.Location = new System.Drawing.Point(13, 9);
            this.label_masinhvien.Name = "label_masinhvien";
            this.label_masinhvien.Size = new System.Drawing.Size(100, 23);
            this.label_masinhvien.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(249, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "DANH SÁCH HỌC PHẦN CHƯA TÍCH LŨY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hocphanchuatichluyBindingSource
            // 
            this.hocphanchuatichluyBindingSource.DataMember = "Hocphanchuatichluy";
            this.hocphanchuatichluyBindingSource.DataSource = this.appForStudents;
            // 
            // sp_BangdiemcanhanTableAdapter
            // 
            this.sp_BangdiemcanhanTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_bangdiem);
            this.panel1.Location = new System.Drawing.Point(2, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 194);
            this.panel1.TabIndex = 24;
            // 
            // dataGridView_bangdiem
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_bangdiem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_bangdiem.AutoGenerateColumns = false;
            this.dataGridView_bangdiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_bangdiem.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_bangdiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_bangdiem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_bangdiem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_bangdiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_bangdiem.ColumnHeadersHeight = 21;
            this.dataGridView_bangdiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahocphanDataGridViewTextBoxColumn1,
            this.tenhocphanDataGridViewTextBoxColumn1,
            this.sotinchiDataGridViewTextBoxColumn1,
            this.kyhocDataGridViewTextBoxColumn1,
            this.diemchuyencanDataGridViewTextBoxColumn,
            this.diemgiuakyDataGridViewTextBoxColumn,
            this.diemcuoikyDataGridViewTextBoxColumn,
            this.thangdiem10DataGridViewTextBoxColumn,
            this.thangdiem4DataGridViewTextBoxColumn,
            this.thangdiemchuDataGridViewTextBoxColumn});
            this.dataGridView_bangdiem.DataSource = this.spBangdiemcanhanBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_bangdiem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_bangdiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_bangdiem.EnableHeadersVisualStyles = false;
            this.dataGridView_bangdiem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_bangdiem.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_bangdiem.Name = "dataGridView_bangdiem";
            this.dataGridView_bangdiem.RowHeadersVisible = false;
            this.dataGridView_bangdiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_bangdiem.Size = new System.Drawing.Size(798, 194);
            this.dataGridView_bangdiem.TabIndex = 1;
            this.dataGridView_bangdiem.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_bangdiem.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_bangdiem.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_bangdiem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_bangdiem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_bangdiem.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_bangdiem.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_bangdiem.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_bangdiem.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_bangdiem.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_bangdiem.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_bangdiem.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_bangdiem.ThemeStyle.HeaderStyle.Height = 21;
            this.dataGridView_bangdiem.ThemeStyle.ReadOnly = false;
            this.dataGridView_bangdiem.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_bangdiem.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_bangdiem.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_bangdiem.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_bangdiem.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_bangdiem.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_bangdiem.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // mahocphanDataGridViewTextBoxColumn1
            // 
            this.mahocphanDataGridViewTextBoxColumn1.DataPropertyName = "Mahocphan";
            this.mahocphanDataGridViewTextBoxColumn1.FillWeight = 105F;
            this.mahocphanDataGridViewTextBoxColumn1.HeaderText = "Mã học phần";
            this.mahocphanDataGridViewTextBoxColumn1.Name = "mahocphanDataGridViewTextBoxColumn1";
            // 
            // tenhocphanDataGridViewTextBoxColumn1
            // 
            this.tenhocphanDataGridViewTextBoxColumn1.DataPropertyName = "Tenhocphan";
            this.tenhocphanDataGridViewTextBoxColumn1.FillWeight = 80F;
            this.tenhocphanDataGridViewTextBoxColumn1.HeaderText = "Học phần";
            this.tenhocphanDataGridViewTextBoxColumn1.Name = "tenhocphanDataGridViewTextBoxColumn1";
            // 
            // sotinchiDataGridViewTextBoxColumn1
            // 
            this.sotinchiDataGridViewTextBoxColumn1.DataPropertyName = "Sotinchi";
            this.sotinchiDataGridViewTextBoxColumn1.FillWeight = 60F;
            this.sotinchiDataGridViewTextBoxColumn1.HeaderText = "Tín chỉ";
            this.sotinchiDataGridViewTextBoxColumn1.Name = "sotinchiDataGridViewTextBoxColumn1";
            // 
            // kyhocDataGridViewTextBoxColumn1
            // 
            this.kyhocDataGridViewTextBoxColumn1.DataPropertyName = "Kyhoc";
            this.kyhocDataGridViewTextBoxColumn1.FillWeight = 60F;
            this.kyhocDataGridViewTextBoxColumn1.HeaderText = "Học kỳ";
            this.kyhocDataGridViewTextBoxColumn1.Name = "kyhocDataGridViewTextBoxColumn1";
            // 
            // diemchuyencanDataGridViewTextBoxColumn
            // 
            this.diemchuyencanDataGridViewTextBoxColumn.DataPropertyName = "Diemchuyencan";
            this.diemchuyencanDataGridViewTextBoxColumn.HeaderText = "Điểm chuyên cần";
            this.diemchuyencanDataGridViewTextBoxColumn.Name = "diemchuyencanDataGridViewTextBoxColumn";
            // 
            // diemgiuakyDataGridViewTextBoxColumn
            // 
            this.diemgiuakyDataGridViewTextBoxColumn.DataPropertyName = "Diemgiuaky";
            this.diemgiuakyDataGridViewTextBoxColumn.HeaderText = "Điểm giữa kỳ";
            this.diemgiuakyDataGridViewTextBoxColumn.Name = "diemgiuakyDataGridViewTextBoxColumn";
            // 
            // diemcuoikyDataGridViewTextBoxColumn
            // 
            this.diemcuoikyDataGridViewTextBoxColumn.DataPropertyName = "Diemcuoiky";
            this.diemcuoikyDataGridViewTextBoxColumn.HeaderText = "Điểm cuối kỳ";
            this.diemcuoikyDataGridViewTextBoxColumn.Name = "diemcuoikyDataGridViewTextBoxColumn";
            // 
            // thangdiem10DataGridViewTextBoxColumn
            // 
            this.thangdiem10DataGridViewTextBoxColumn.DataPropertyName = "Thangdiem10";
            this.thangdiem10DataGridViewTextBoxColumn.FillWeight = 80F;
            this.thangdiem10DataGridViewTextBoxColumn.HeaderText = "Thang 10";
            this.thangdiem10DataGridViewTextBoxColumn.Name = "thangdiem10DataGridViewTextBoxColumn";
            // 
            // thangdiem4DataGridViewTextBoxColumn
            // 
            this.thangdiem4DataGridViewTextBoxColumn.DataPropertyName = "Thangdiem4";
            this.thangdiem4DataGridViewTextBoxColumn.FillWeight = 75F;
            this.thangdiem4DataGridViewTextBoxColumn.HeaderText = "Thang 4";
            this.thangdiem4DataGridViewTextBoxColumn.Name = "thangdiem4DataGridViewTextBoxColumn";
            // 
            // thangdiemchuDataGridViewTextBoxColumn
            // 
            this.thangdiemchuDataGridViewTextBoxColumn.DataPropertyName = "Thangdiemchu";
            this.thangdiemchuDataGridViewTextBoxColumn.FillWeight = 85F;
            this.thangdiemchuDataGridViewTextBoxColumn.HeaderText = "Thang chữ";
            this.thangdiemchuDataGridViewTextBoxColumn.Name = "thangdiemchuDataGridViewTextBoxColumn";
            // 
            // dataGridView_hocphanchuatichluy
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView_hocphanchuatichluy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_hocphanchuatichluy.AutoGenerateColumns = false;
            this.dataGridView_hocphanchuatichluy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_hocphanchuatichluy.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_hocphanchuatichluy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_hocphanchuatichluy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_hocphanchuatichluy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_hocphanchuatichluy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_hocphanchuatichluy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hocphanchuatichluy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahocphanDataGridViewTextBoxColumn,
            this.tenhocphanDataGridViewTextBoxColumn,
            this.sotinchiDataGridViewTextBoxColumn,
            this.kyhocDataGridViewTextBoxColumn});
            this.dataGridView_hocphanchuatichluy.DataSource = this.hocphanchuatichluyBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_hocphanchuatichluy.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_hocphanchuatichluy.EnableHeadersVisualStyles = false;
            this.dataGridView_hocphanchuatichluy.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_hocphanchuatichluy.Location = new System.Drawing.Point(2, 289);
            this.dataGridView_hocphanchuatichluy.Name = "dataGridView_hocphanchuatichluy";
            this.dataGridView_hocphanchuatichluy.RowHeadersVisible = false;
            this.dataGridView_hocphanchuatichluy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_hocphanchuatichluy.Size = new System.Drawing.Size(798, 174);
            this.dataGridView_hocphanchuatichluy.TabIndex = 25;
            this.dataGridView_hocphanchuatichluy.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_hocphanchuatichluy.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_hocphanchuatichluy.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_hocphanchuatichluy.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_hocphanchuatichluy.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_hocphanchuatichluy.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_hocphanchuatichluy.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_hocphanchuatichluy.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_hocphanchuatichluy.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_hocphanchuatichluy.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_hocphanchuatichluy.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_hocphanchuatichluy.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hocphanchuatichluy.ThemeStyle.HeaderStyle.Height = 21;
            this.dataGridView_hocphanchuatichluy.ThemeStyle.ReadOnly = false;
            this.dataGridView_hocphanchuatichluy.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_hocphanchuatichluy.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_hocphanchuatichluy.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_hocphanchuatichluy.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_hocphanchuatichluy.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_hocphanchuatichluy.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_hocphanchuatichluy.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // mahocphanDataGridViewTextBoxColumn
            // 
            this.mahocphanDataGridViewTextBoxColumn.DataPropertyName = "Mahocphan";
            this.mahocphanDataGridViewTextBoxColumn.HeaderText = "Mã học phần";
            this.mahocphanDataGridViewTextBoxColumn.Name = "mahocphanDataGridViewTextBoxColumn";
            // 
            // tenhocphanDataGridViewTextBoxColumn
            // 
            this.tenhocphanDataGridViewTextBoxColumn.DataPropertyName = "Tenhocphan";
            this.tenhocphanDataGridViewTextBoxColumn.HeaderText = "Tên học phần";
            this.tenhocphanDataGridViewTextBoxColumn.Name = "tenhocphanDataGridViewTextBoxColumn";
            // 
            // sotinchiDataGridViewTextBoxColumn
            // 
            this.sotinchiDataGridViewTextBoxColumn.DataPropertyName = "Sotinchi";
            this.sotinchiDataGridViewTextBoxColumn.HeaderText = "Số tín chỉ";
            this.sotinchiDataGridViewTextBoxColumn.Name = "sotinchiDataGridViewTextBoxColumn";
            // 
            // kyhocDataGridViewTextBoxColumn
            // 
            this.kyhocDataGridViewTextBoxColumn.DataPropertyName = "Kyhoc";
            this.kyhocDataGridViewTextBoxColumn.HeaderText = "Học kỳ";
            this.kyhocDataGridViewTextBoxColumn.Name = "kyhocDataGridViewTextBoxColumn";
            // 
            // btn_report
            // 
            this.btn_report.BorderRadius = 7;
            this.btn_report.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_report.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_report.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_report.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_report.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.Location = new System.Drawing.Point(630, 21);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(135, 30);
            this.btn_report.TabIndex = 26;
            this.btn_report.Text = "In bảng điểm";
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // FormShowDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(802, 465);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.dataGridView_hocphanchuatichluy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_masinhvien);
            this.Controls.Add(this.label_sumtinchi);
            this.Controls.Add(this.label_TBC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormShowDiem";
            this.Text = "FormShowDiem";
            this.Load += new System.EventHandler(this.FormShowDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spBangdiemcanhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appForStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocphanchuatichluyBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bangdiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hocphanchuatichluy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TBC;
        private System.Windows.Forms.Label label_sumtinchi;
        private System.Windows.Forms.Label label_masinhvien;
        private System.Windows.Forms.Label label2;
        private AppForStudents appForStudents;
        private System.Windows.Forms.BindingSource spBangdiemcanhanBindingSource;
        private System.Windows.Forms.BindingSource hocphanchuatichluyBindingSource;
        private AppForStudentsTableAdapters.sp_BangdiemcanhanTableAdapter sp_BangdiemcanhanTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_bangdiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahocphanDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhocphanDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotinchiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyhocDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemchuyencanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemgiuakyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemcuoikyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangdiem10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangdiem4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangdiemchuDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_hocphanchuatichluy;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahocphanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhocphanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotinchiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyhocDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button btn_report;
    }
}