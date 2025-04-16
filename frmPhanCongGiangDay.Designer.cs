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
            this.labNgay = new System.Windows.Forms.Label();
            this.dtpNgayDay = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.cmbKy = new System.Windows.Forms.ComboBox();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.btnCongGiaoVien = new System.Windows.Forms.Button();
            this.tbnCongLop = new System.Windows.Forms.Button();
            this.labBuoi = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbxThuTrongTuan = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.labThuTrongTuan = new System.Windows.Forms.Label();
            this.btnCongMonHoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labNgay
            // 
            this.labNgay.AutoSize = true;
            this.labNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNgay.Location = new System.Drawing.Point(420, 31);
            this.labNgay.Name = "labNgay";
            this.labNgay.Size = new System.Drawing.Size(97, 39);
            this.labNgay.TabIndex = 0;
            this.labNgay.Text = "Ngày";
            // 
            // dtpNgayDay
            // 
            this.dtpNgayDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDay.Location = new System.Drawing.Point(548, 26);
            this.dtpNgayDay.Name = "dtpNgayDay";
            this.dtpNgayDay.Size = new System.Drawing.Size(560, 45);
            this.dtpNgayDay.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 471);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1869, 675);
            this.dataGridView1.TabIndex = 2;
            // 
            // labTiet
            // 
            this.labTiet.AutoSize = true;
            this.labTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTiet.Location = new System.Drawing.Point(31, 124);
            this.labTiet.Name = "labTiet";
            this.labTiet.Size = new System.Drawing.Size(74, 39);
            this.labTiet.TabIndex = 3;
            this.labTiet.Text = "Tiết";
            // 
            // labGiaoVien
            // 
            this.labGiaoVien.AutoSize = true;
            this.labGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGiaoVien.Location = new System.Drawing.Point(878, 124);
            this.labGiaoVien.Name = "labGiaoVien";
            this.labGiaoVien.Size = new System.Drawing.Size(161, 39);
            this.labGiaoVien.TabIndex = 4;
            this.labGiaoVien.Text = "Giáo viên";
            // 
            // labMonHoc
            // 
            this.labMonHoc.AutoSize = true;
            this.labMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMonHoc.Location = new System.Drawing.Point(878, 240);
            this.labMonHoc.Name = "labMonHoc";
            this.labMonHoc.Size = new System.Drawing.Size(147, 39);
            this.labMonHoc.TabIndex = 6;
            this.labMonHoc.Text = "Môn học";
            // 
            // labKy
            // 
            this.labKy.AutoSize = true;
            this.labKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labKy.Location = new System.Drawing.Point(31, 31);
            this.labKy.Name = "labKy";
            this.labKy.Size = new System.Drawing.Size(57, 39);
            this.labKy.TabIndex = 7;
            this.labKy.Text = "Kỳ";
            // 
            // labLop
            // 
            this.labLop.AutoSize = true;
            this.labLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLop.Location = new System.Drawing.Point(422, 240);
            this.labLop.Name = "labLop";
            this.labLop.Size = new System.Drawing.Size(74, 39);
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
            this.btnSua.Location = new System.Drawing.Point(298, 347);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 55);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(749, 347);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(105, 55);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(529, 347);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 55);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(1264, 347);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(209, 55);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cbxTiet
            // 
            this.cbxTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTiet.FormattingEnabled = true;
            this.cbxTiet.Location = new System.Drawing.Point(134, 121);
            this.cbxTiet.Name = "cbxTiet";
            this.cbxTiet.Size = new System.Drawing.Size(187, 46);
            this.cbxTiet.TabIndex = 15;
            // 
            // cbxGiaoVien
            // 
            this.cbxGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGiaoVien.FormattingEnabled = true;
            this.cbxGiaoVien.Location = new System.Drawing.Point(1064, 121);
            this.cbxGiaoVien.Name = "cbxGiaoVien";
            this.cbxGiaoVien.Size = new System.Drawing.Size(344, 46);
            this.cbxGiaoVien.TabIndex = 16;
            // 
            // cbxMonHoc
            // 
            this.cbxMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMonHoc.FormattingEnabled = true;
            this.cbxMonHoc.Location = new System.Drawing.Point(1064, 237);
            this.cbxMonHoc.Name = "cbxMonHoc";
            this.cbxMonHoc.Size = new System.Drawing.Size(344, 46);
            this.cbxMonHoc.TabIndex = 17;
            // 
            // cmbKy
            // 
            this.cmbKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKy.FormattingEnabled = true;
            this.cmbKy.Location = new System.Drawing.Point(134, 28);
            this.cmbKy.Name = "cmbKy";
            this.cmbKy.Size = new System.Drawing.Size(226, 46);
            this.cmbKy.TabIndex = 18;
            // 
            // cbxLop
            // 
            this.cbxLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(548, 237);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(198, 46);
            this.cbxLop.TabIndex = 19;
            // 
            // btnCongGiaoVien
            // 
            this.btnCongGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongGiaoVien.Location = new System.Drawing.Point(1426, 120);
            this.btnCongGiaoVien.Name = "btnCongGiaoVien";
            this.btnCongGiaoVien.Size = new System.Drawing.Size(47, 47);
            this.btnCongGiaoVien.TabIndex = 20;
            this.btnCongGiaoVien.Text = "+";
            this.btnCongGiaoVien.UseVisualStyleBackColor = true;
            // 
            // tbnCongLop
            // 
            this.tbnCongLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnCongLop.Location = new System.Drawing.Point(768, 236);
            this.tbnCongLop.Name = "tbnCongLop";
            this.tbnCongLop.Size = new System.Drawing.Size(47, 47);
            this.tbnCongLop.TabIndex = 22;
            this.tbnCongLop.Text = "+";
            this.tbnCongLop.UseVisualStyleBackColor = true;
            // 
            // labBuoi
            // 
            this.labBuoi.AutoSize = true;
            this.labBuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBuoi.Location = new System.Drawing.Point(31, 240);
            this.labBuoi.Name = "labBuoi";
            this.labBuoi.Size = new System.Drawing.Size(86, 39);
            this.labBuoi.TabIndex = 23;
            this.labBuoi.Text = "Buổi";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 237);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 46);
            this.comboBox1.TabIndex = 24;
            // 
            // cbxThuTrongTuan
            // 
            this.cbxThuTrongTuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxThuTrongTuan.FormattingEnabled = true;
            this.cbxThuTrongTuan.Location = new System.Drawing.Point(1305, 28);
            this.cbxThuTrongTuan.Name = "cbxThuTrongTuan";
            this.cbxThuTrongTuan.Size = new System.Drawing.Size(255, 46);
            this.cbxThuTrongTuan.TabIndex = 28;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(963, 347);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(192, 55);
            this.btnLamMoi.TabIndex = 29;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // labThuTrongTuan
            // 
            this.labThuTrongTuan.AutoSize = true;
            this.labThuTrongTuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labThuTrongTuan.Location = new System.Drawing.Point(1206, 31);
            this.labThuTrongTuan.Name = "labThuTrongTuan";
            this.labThuTrongTuan.Size = new System.Drawing.Size(76, 39);
            this.labThuTrongTuan.TabIndex = 30;
            this.labThuTrongTuan.Text = "Thứ";
            // 
            // btnCongMonHoc
            // 
            this.btnCongMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongMonHoc.Location = new System.Drawing.Point(1426, 236);
            this.btnCongMonHoc.Name = "btnCongMonHoc";
            this.btnCongMonHoc.Size = new System.Drawing.Size(47, 47);
            this.btnCongMonHoc.TabIndex = 31;
            this.btnCongMonHoc.Text = "+";
            this.btnCongMonHoc.UseVisualStyleBackColor = true;
            // 
            // frmPhanCongGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1175);
            this.Controls.Add(this.btnCongMonHoc);
            this.Controls.Add(this.labThuTrongTuan);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.cbxThuTrongTuan);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labBuoi);
            this.Controls.Add(this.tbnCongLop);
            this.Controls.Add(this.btnCongGiaoVien);
            this.Controls.Add(this.cbxLop);
            this.Controls.Add(this.cmbKy);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpNgayDay);
            this.Controls.Add(this.labNgay);
            this.Name = "frmPhanCongGiangDay";
            this.Text = "frmPhanCongGiangDay";
            this.Load += new System.EventHandler(this.frmPhanCongGiangDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayDay;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.ComboBox cmbKy;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.Button btnCongGiaoVien;
        private System.Windows.Forms.Button tbnCongLop;
        private System.Windows.Forms.Label labBuoi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbxThuTrongTuan;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label labThuTrongTuan;
        private System.Windows.Forms.Button btnCongMonHoc;
    }
}