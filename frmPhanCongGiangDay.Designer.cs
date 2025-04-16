namespace QLCBCNV
{
    partial class frmPhanCongGiangDay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labNgay = new System.Windows.Forms.Label();
            this.dtpNgayDay = new System.Windows.Forms.DateTimePicker();
            this.dgvPhanCong = new System.Windows.Forms.DataGridView();
            this.labTiet = new System.Windows.Forms.Label();
            this.labGiaoVien = new System.Windows.Forms.Label();
            this.labMonHoc = new System.Windows.Forms.Label();
            this.labKy = new System.Windows.Forms.Label();
            this.labLop = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbxTiet = new System.Windows.Forms.ComboBox();
            this.cbxGiaoVien = new System.Windows.Forms.ComboBox();
            this.cbxMonHoc = new System.Windows.Forms.ComboBox();
            this.cbxKy = new System.Windows.Forms.ComboBox();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.btnCongGiaoVien = new System.Windows.Forms.Button();
            this.tbnCongLop = new System.Windows.Forms.Button();
            this.labBuoi = new System.Windows.Forms.Label();
            this.cbxBuoi = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnCongMonHoc = new System.Windows.Forms.Button();
            this.btnCongHocKy = new System.Windows.Forms.Button();
            this.cbxKhoi = new System.Windows.Forms.ComboBox();
            this.labKhoi = new System.Windows.Forms.Label();
            this.txtThu = new System.Windows.Forms.TextBox();
            this.cbxSoTiet = new System.Windows.Forms.ComboBox();
            this.labSoTiet = new System.Windows.Forms.Label();
            this.txtMaPC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // labNgay
            // 
            this.labNgay.AutoSize = true;
            this.labNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNgay.Location = new System.Drawing.Point(963, 35);
            this.labNgay.Name = "labNgay";
            this.labNgay.Size = new System.Drawing.Size(94, 38);
            this.labNgay.TabIndex = 0;
            this.labNgay.Text = "Ngày";
            // 
            // dtpNgayDay
            // 
            this.dtpNgayDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDay.Location = new System.Drawing.Point(1091, 30);
            this.dtpNgayDay.Name = "dtpNgayDay";
            this.dtpNgayDay.Size = new System.Drawing.Size(610, 45);
            this.dtpNgayDay.TabIndex = 1;
            this.dtpNgayDay.ValueChanged += new System.EventHandler(this.dtpNgayDay_ValueChanged);
            // 
            // dgvPhanCong
            // 
            this.dgvPhanCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanCong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhanCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhanCong.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPhanCong.Location = new System.Drawing.Point(5, 456);
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.RowHeadersWidth = 51;
            this.dgvPhanCong.RowTemplate.Height = 24;
            this.dgvPhanCong.Size = new System.Drawing.Size(1922, 690);
            this.dgvPhanCong.TabIndex = 2;
            this.dgvPhanCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhanCong_CellClick);
            this.dgvPhanCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhanCong_CellContentClick);
            // 
            // labTiet
            // 
            this.labTiet.AutoSize = true;
            this.labTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTiet.Location = new System.Drawing.Point(31, 243);
            this.labTiet.Name = "labTiet";
            this.labTiet.Size = new System.Drawing.Size(71, 38);
            this.labTiet.TabIndex = 3;
            this.labTiet.Text = "Tiết";
            // 
            // labGiaoVien
            // 
            this.labGiaoVien.AutoSize = true;
            this.labGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGiaoVien.Location = new System.Drawing.Point(1126, 124);
            this.labGiaoVien.Name = "labGiaoVien";
            this.labGiaoVien.Size = new System.Drawing.Size(155, 38);
            this.labGiaoVien.TabIndex = 4;
            this.labGiaoVien.Text = "Giáo viên";
            // 
            // labMonHoc
            // 
            this.labMonHoc.AutoSize = true;
            this.labMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMonHoc.Location = new System.Drawing.Point(1126, 240);
            this.labMonHoc.Name = "labMonHoc";
            this.labMonHoc.Size = new System.Drawing.Size(142, 38);
            this.labMonHoc.TabIndex = 6;
            this.labMonHoc.Text = "Môn học";
            // 
            // labKy
            // 
            this.labKy.AutoSize = true;
            this.labKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labKy.Location = new System.Drawing.Point(412, 35);
            this.labKy.Name = "labKy";
            this.labKy.Size = new System.Drawing.Size(56, 38);
            this.labKy.TabIndex = 7;
            this.labKy.Text = "Kỳ";
            // 
            // labLop
            // 
            this.labLop.AutoSize = true;
            this.labLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLop.Location = new System.Drawing.Point(670, 240);
            this.labLop.Name = "labLop";
            this.labLop.Size = new System.Drawing.Size(71, 38);
            this.labLop.TabIndex = 8;
            this.labLop.Text = "Lớp";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(38, 347);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(151, 55);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(304, 347);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 55);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(767, 347);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(105, 55);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(541, 347);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 55);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(987, 347);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(209, 55);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbxTiet
            // 
            this.cbxTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTiet.FormattingEnabled = true;
            this.cbxTiet.Location = new System.Drawing.Point(134, 240);
            this.cbxTiet.Name = "cbxTiet";
            this.cbxTiet.Size = new System.Drawing.Size(187, 46);
            this.cbxTiet.TabIndex = 15;
            // 
            // cbxGiaoVien
            // 
            this.cbxGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGiaoVien.FormattingEnabled = true;
            this.cbxGiaoVien.Location = new System.Drawing.Point(1312, 121);
            this.cbxGiaoVien.Name = "cbxGiaoVien";
            this.cbxGiaoVien.Size = new System.Drawing.Size(344, 46);
            this.cbxGiaoVien.TabIndex = 16;
            // 
            // cbxMonHoc
            // 
            this.cbxMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMonHoc.FormattingEnabled = true;
            this.cbxMonHoc.Location = new System.Drawing.Point(1312, 237);
            this.cbxMonHoc.Name = "cbxMonHoc";
            this.cbxMonHoc.Size = new System.Drawing.Size(344, 46);
            this.cbxMonHoc.TabIndex = 17;
            // 
            // cbxKy
            // 
            this.cbxKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKy.FormattingEnabled = true;
            this.cbxKy.Location = new System.Drawing.Point(515, 32);
            this.cbxKy.Name = "cbxKy";
            this.cbxKy.Size = new System.Drawing.Size(293, 46);
            this.cbxKy.TabIndex = 18;
            // 
            // cbxLop
            // 
            this.cbxLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(796, 237);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(198, 46);
            this.cbxLop.TabIndex = 19;
            // 
            // btnCongGiaoVien
            // 
            this.btnCongGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongGiaoVien.Location = new System.Drawing.Point(1678, 120);
            this.btnCongGiaoVien.Name = "btnCongGiaoVien";
            this.btnCongGiaoVien.Size = new System.Drawing.Size(47, 47);
            this.btnCongGiaoVien.TabIndex = 20;
            this.btnCongGiaoVien.Text = "+";
            this.btnCongGiaoVien.UseVisualStyleBackColor = true;
            // 
            // tbnCongLop
            // 
            this.tbnCongLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnCongLop.Location = new System.Drawing.Point(1016, 137);
            this.tbnCongLop.Name = "tbnCongLop";
            this.tbnCongLop.Size = new System.Drawing.Size(47, 146);
            this.tbnCongLop.TabIndex = 22;
            this.tbnCongLop.Text = "+";
            this.tbnCongLop.UseVisualStyleBackColor = true;
            // 
            // labBuoi
            // 
            this.labBuoi.AutoSize = true;
            this.labBuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBuoi.Location = new System.Drawing.Point(31, 137);
            this.labBuoi.Name = "labBuoi";
            this.labBuoi.Size = new System.Drawing.Size(82, 38);
            this.labBuoi.TabIndex = 23;
            this.labBuoi.Text = "Buổi";
            // 
            // cbxBuoi
            // 
            this.cbxBuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBuoi.FormattingEnabled = true;
            this.cbxBuoi.Location = new System.Drawing.Point(134, 134);
            this.cbxBuoi.Name = "cbxBuoi";
            this.cbxBuoi.Size = new System.Drawing.Size(187, 46);
            this.cbxBuoi.TabIndex = 24;
            this.cbxBuoi.SelectedIndexChanged += new System.EventHandler(this.cbxBuoi_SelectedIndexChanged);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(1311, 347);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(192, 55);
            this.btnLamMoi.TabIndex = 29;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnCongMonHoc
            // 
            this.btnCongMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongMonHoc.Location = new System.Drawing.Point(1678, 236);
            this.btnCongMonHoc.Name = "btnCongMonHoc";
            this.btnCongMonHoc.Size = new System.Drawing.Size(47, 47);
            this.btnCongMonHoc.TabIndex = 31;
            this.btnCongMonHoc.Text = "+";
            this.btnCongMonHoc.UseVisualStyleBackColor = true;
            // 
            // btnCongHocKy
            // 
            this.btnCongHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongHocKy.Location = new System.Drawing.Point(828, 32);
            this.btnCongHocKy.Name = "btnCongHocKy";
            this.btnCongHocKy.Size = new System.Drawing.Size(46, 46);
            this.btnCongHocKy.TabIndex = 32;
            this.btnCongHocKy.Text = "+";
            this.btnCongHocKy.UseVisualStyleBackColor = true;
            // 
            // cbxKhoi
            // 
            this.cbxKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKhoi.FormattingEnabled = true;
            this.cbxKhoi.Location = new System.Drawing.Point(796, 137);
            this.cbxKhoi.Name = "cbxKhoi";
            this.cbxKhoi.Size = new System.Drawing.Size(198, 46);
            this.cbxKhoi.TabIndex = 34;
            this.cbxKhoi.SelectedIndexChanged += new System.EventHandler(this.cbxKhoi_SelectedIndexChanged);
            // 
            // labKhoi
            // 
            this.labKhoi.AutoSize = true;
            this.labKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labKhoi.Location = new System.Drawing.Point(670, 140);
            this.labKhoi.Name = "labKhoi";
            this.labKhoi.Size = new System.Drawing.Size(82, 38);
            this.labKhoi.TabIndex = 33;
            this.labKhoi.Text = "Khối";
            // 
            // txtThu
            // 
            this.txtThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThu.Location = new System.Drawing.Point(1733, 30);
            this.txtThu.Name = "txtThu";
            this.txtThu.Size = new System.Drawing.Size(194, 45);
            this.txtThu.TabIndex = 35;
            // 
            // cbxSoTiet
            // 
            this.cbxSoTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSoTiet.FormattingEnabled = true;
            this.cbxSoTiet.Location = new System.Drawing.Point(494, 240);
            this.cbxSoTiet.Name = "cbxSoTiet";
            this.cbxSoTiet.Size = new System.Drawing.Size(105, 46);
            this.cbxSoTiet.TabIndex = 37;
            // 
            // labSoTiet
            // 
            this.labSoTiet.AutoSize = true;
            this.labSoTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSoTiet.Location = new System.Drawing.Point(364, 243);
            this.labSoTiet.Name = "labSoTiet";
            this.labSoTiet.Size = new System.Drawing.Size(109, 38);
            this.labSoTiet.TabIndex = 36;
            this.labSoTiet.Text = "Số tiết";
            // 
            // txtMaPC
            // 
            this.txtMaPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPC.Location = new System.Drawing.Point(38, 32);
            this.txtMaPC.Name = "txtMaPC";
            this.txtMaPC.Size = new System.Drawing.Size(194, 45);
            this.txtMaPC.TabIndex = 38;
            // 
            // frmPhanCongGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1175);
            this.Controls.Add(this.txtMaPC);
            this.Controls.Add(this.cbxSoTiet);
            this.Controls.Add(this.labSoTiet);
            this.Controls.Add(this.txtThu);
            this.Controls.Add(this.cbxKhoi);
            this.Controls.Add(this.labKhoi);
            this.Controls.Add(this.btnCongHocKy);
            this.Controls.Add(this.btnCongMonHoc);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.cbxBuoi);
            this.Controls.Add(this.labBuoi);
            this.Controls.Add(this.tbnCongLop);
            this.Controls.Add(this.btnCongGiaoVien);
            this.Controls.Add(this.cbxLop);
            this.Controls.Add(this.cbxKy);
            this.Controls.Add(this.cbxMonHoc);
            this.Controls.Add(this.cbxGiaoVien);
            this.Controls.Add(this.cbxTiet);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.labLop);
            this.Controls.Add(this.labKy);
            this.Controls.Add(this.labMonHoc);
            this.Controls.Add(this.labGiaoVien);
            this.Controls.Add(this.labTiet);
            this.Controls.Add(this.dgvPhanCong);
            this.Controls.Add(this.dtpNgayDay);
            this.Controls.Add(this.labNgay);
            this.Name = "frmPhanCongGiangDay";
            this.Text = "frmPhanCongGiangDay";
            this.Load += new System.EventHandler(this.frmPhanCongGiangDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayDay;
        private System.Windows.Forms.DataGridView dgvPhanCong;
        private System.Windows.Forms.Label labTiet;
        private System.Windows.Forms.Label labGiaoVien;
        private System.Windows.Forms.Label labMonHoc;
        private System.Windows.Forms.Label labKy;
        private System.Windows.Forms.Label labLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbxTiet;
        private System.Windows.Forms.ComboBox cbxGiaoVien;
        private System.Windows.Forms.ComboBox cbxMonHoc;
        private System.Windows.Forms.ComboBox cbxKy;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.Button btnCongGiaoVien;
        private System.Windows.Forms.Button tbnCongLop;
        private System.Windows.Forms.Label labBuoi;
        private System.Windows.Forms.ComboBox cbxBuoi;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnCongMonHoc;
        private System.Windows.Forms.Button btnCongHocKy;
        private System.Windows.Forms.ComboBox cbxKhoi;
        private System.Windows.Forms.Label labKhoi;
        private System.Windows.Forms.TextBox txtThu;
        private System.Windows.Forms.ComboBox cbxSoTiet;
        private System.Windows.Forms.Label labSoTiet;
        private System.Windows.Forms.TextBox txtMaPC;
    }
}