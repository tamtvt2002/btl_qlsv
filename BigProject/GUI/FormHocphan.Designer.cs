
namespace BigProject.GUI
{
    partial class FormHocphan
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnsua = new Guna.UI2.WinForms.Guna2Button();
            this.btnthem = new Guna.UI2.WinForms.Guna2Button();
            this.cbx_kyhoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBox_sotinchi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txttenhocphan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmahocphan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_hocphan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mahocphanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhocphanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotinchiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSinhVienDataSet = new BigProject.QLSinhVienDataSet();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hocphan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnsua);
            this.panel3.Controls.Add(this.btnthem);
            this.panel3.Controls.Add(this.cbx_kyhoc);
            this.panel3.Controls.Add(this.comboBox_sotinchi);
            this.panel3.Controls.Add(this.txttenhocphan);
            this.panel3.Controls.Add(this.txtmahocphan);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 422);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(962, 180);
            this.panel3.TabIndex = 7;
            // 
            // btnsua
            // 
            this.btnsua.BorderRadius = 7;
            this.btnsua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnsua.ForeColor = System.Drawing.Color.White;
            this.btnsua.Location = new System.Drawing.Point(617, 87);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(101, 35);
            this.btnsua.TabIndex = 64;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BorderRadius = 7;
            this.btnthem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthem.FillColor = System.Drawing.Color.Navy;
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(617, 22);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(101, 35);
            this.btnthem.TabIndex = 63;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cbx_kyhoc
            // 
            this.cbx_kyhoc.BackColor = System.Drawing.Color.Transparent;
            this.cbx_kyhoc.BorderColor = System.Drawing.Color.Gray;
            this.cbx_kyhoc.BorderRadius = 7;
            this.cbx_kyhoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_kyhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_kyhoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_kyhoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_kyhoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_kyhoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbx_kyhoc.ItemHeight = 30;
            this.cbx_kyhoc.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbx_kyhoc.Location = new System.Drawing.Point(380, 86);
            this.cbx_kyhoc.Name = "cbx_kyhoc";
            this.cbx_kyhoc.Size = new System.Drawing.Size(161, 36);
            this.cbx_kyhoc.StartIndex = 0;
            this.cbx_kyhoc.TabIndex = 62;
            // 
            // comboBox_sotinchi
            // 
            this.comboBox_sotinchi.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_sotinchi.BorderColor = System.Drawing.Color.Gray;
            this.comboBox_sotinchi.BorderRadius = 7;
            this.comboBox_sotinchi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_sotinchi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sotinchi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_sotinchi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_sotinchi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_sotinchi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_sotinchi.ItemHeight = 30;
            this.comboBox_sotinchi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_sotinchi.Location = new System.Drawing.Point(130, 86);
            this.comboBox_sotinchi.Name = "comboBox_sotinchi";
            this.comboBox_sotinchi.Size = new System.Drawing.Size(150, 36);
            this.comboBox_sotinchi.StartIndex = 0;
            this.comboBox_sotinchi.TabIndex = 61;
            // 
            // txttenhocphan
            // 
            this.txttenhocphan.BorderColor = System.Drawing.Color.Gray;
            this.txttenhocphan.BorderRadius = 7;
            this.txttenhocphan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenhocphan.DefaultText = "";
            this.txttenhocphan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttenhocphan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttenhocphan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenhocphan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenhocphan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenhocphan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttenhocphan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenhocphan.Location = new System.Drawing.Point(380, 22);
            this.txttenhocphan.Name = "txttenhocphan";
            this.txttenhocphan.PasswordChar = '\0';
            this.txttenhocphan.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txttenhocphan.PlaceholderText = "Nhập tên học phần";
            this.txttenhocphan.SelectedText = "";
            this.txttenhocphan.Size = new System.Drawing.Size(161, 35);
            this.txttenhocphan.TabIndex = 60;
            // 
            // txtmahocphan
            // 
            this.txtmahocphan.BorderColor = System.Drawing.Color.Gray;
            this.txtmahocphan.BorderRadius = 7;
            this.txtmahocphan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmahocphan.DefaultText = "";
            this.txtmahocphan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmahocphan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmahocphan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmahocphan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmahocphan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmahocphan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmahocphan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmahocphan.Location = new System.Drawing.Point(130, 22);
            this.txtmahocphan.Name = "txtmahocphan";
            this.txtmahocphan.PasswordChar = '\0';
            this.txtmahocphan.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtmahocphan.PlaceholderText = "Nhập mã học phần";
            this.txtmahocphan.SelectedText = "";
            this.txtmahocphan.Size = new System.Drawing.Size(150, 35);
            this.txtmahocphan.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(329, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Kỳ học:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(48, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Mã học phần:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(65, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số tín chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(294, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên học phần:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_hocphan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 602);
            this.panel2.TabIndex = 6;
            // 
            // dataGridView_hocphan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_hocphan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_hocphan.AutoGenerateColumns = false;
            this.dataGridView_hocphan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_hocphan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_hocphan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_hocphan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_hocphan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_hocphan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_hocphan.ColumnHeadersHeight = 21;
            this.dataGridView_hocphan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahocphanDataGridViewTextBoxColumn,
            this.tenhocphanDataGridViewTextBoxColumn,
            this.sotinchiDataGridViewTextBoxColumn,
            this.kyhocDataGridViewTextBoxColumn});
            this.dataGridView_hocphan.DataSource = this.monhocBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_hocphan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_hocphan.EnableHeadersVisualStyles = false;
            this.dataGridView_hocphan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_hocphan.Location = new System.Drawing.Point(0, 12);
            this.dataGridView_hocphan.Name = "dataGridView_hocphan";
            this.dataGridView_hocphan.RowHeadersVisible = false;
            this.dataGridView_hocphan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_hocphan.Size = new System.Drawing.Size(962, 590);
            this.dataGridView_hocphan.TabIndex = 0;
            this.dataGridView_hocphan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_hocphan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_hocphan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_hocphan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_hocphan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_hocphan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_hocphan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_hocphan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_hocphan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_hocphan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_hocphan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_hocphan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_hocphan.ThemeStyle.HeaderStyle.Height = 21;
            this.dataGridView_hocphan.ThemeStyle.ReadOnly = false;
            this.dataGridView_hocphan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_hocphan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_hocphan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_hocphan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_hocphan.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_hocphan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_hocphan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_hocphan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_hocphan_CellClick);
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
            this.kyhocDataGridViewTextBoxColumn.HeaderText = "Kỳ học";
            this.kyhocDataGridViewTextBoxColumn.Name = "kyhocDataGridViewTextBoxColumn";
            // 
            // monhocBindingSource
            // 
            this.monhocBindingSource.DataMember = "Monhoc";
            this.monhocBindingSource.DataSource = this.qLSinhVienDataSet;
            // 
            // qLSinhVienDataSet
            // 
            this.qLSinhVienDataSet.DataSetName = "QLSinhVienDataSet";
            this.qLSinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormHocphan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 602);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormHocphan";
            this.Text = "FormMonhoc";
            this.Load += new System.EventHandler(this.FormHocphan_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hocphan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource monhocBindingSource;
        private QLSinhVienDataSet qLSinhVienDataSet;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txttenhocphan;
        private Guna.UI2.WinForms.Guna2TextBox txtmahocphan;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_kyhoc;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_sotinchi;
        private Guna.UI2.WinForms.Guna2Button btnsua;
        private Guna.UI2.WinForms.Guna2Button btnthem;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_hocphan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahocphanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhocphanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotinchiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyhocDataGridViewTextBoxColumn;
    }
}