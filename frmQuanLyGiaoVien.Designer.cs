namespace QLCBCNV
{
    partial class frmQuanLyGiaoVien
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
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.labHoTen = new System.Windows.Forms.Label();
            this.labNgaySinh = new System.Windows.Forms.Label();
            this.labGioiTinh = new System.Windows.Forms.Label();
            this.labDiaChi = new System.Windows.Forms.Label();
            this.labSdt = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.labMonHoc = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rabNam = new System.Windows.Forms.RadioButton();
            this.rabNu = new System.Windows.Forms.RadioButton();
            this.rtxtDiaChi = new System.Windows.Forms.RichTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.btnCongMonHoc = new System.Windows.Forms.Button();
            this.btnCongTrinhDo = new System.Windows.Forms.Button();
            this.labTrinhDo = new System.Windows.Forms.Label();
            this.cmbTrinhDo = new System.Windows.Forms.ComboBox();
            this.labNgayLam = new System.Windows.Forms.Label();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Location = new System.Drawing.Point(12, 209);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.RowHeadersWidth = 51;
            this.dgvGiaoVien.RowTemplate.Height = 24;
            this.dgvGiaoVien.Size = new System.Drawing.Size(1558, 532);
            this.dgvGiaoVien.TabIndex = 0;
            this.dgvGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellClick);
            // 
            // labHoTen
            // 
            this.labHoTen.AutoSize = true;
            this.labHoTen.Location = new System.Drawing.Point(12, 9);
            this.labHoTen.Name = "labHoTen";
            this.labHoTen.Size = new System.Drawing.Size(51, 16);
            this.labHoTen.TabIndex = 1;
            this.labHoTen.Text = "Họ tên*";
            // 
            // labNgaySinh
            // 
            this.labNgaySinh.AutoSize = true;
            this.labNgaySinh.Location = new System.Drawing.Point(373, 9);
            this.labNgaySinh.Name = "labNgaySinh";
            this.labNgaySinh.Size = new System.Drawing.Size(72, 16);
            this.labNgaySinh.TabIndex = 2;
            this.labNgaySinh.Text = "Ngày sinh*";
            // 
            // labGioiTinh
            // 
            this.labGioiTinh.AutoSize = true;
            this.labGioiTinh.Location = new System.Drawing.Point(765, 9);
            this.labGioiTinh.Name = "labGioiTinh";
            this.labGioiTinh.Size = new System.Drawing.Size(54, 16);
            this.labGioiTinh.TabIndex = 3;
            this.labGioiTinh.Text = "Giới tính";
            // 
            // labDiaChi
            // 
            this.labDiaChi.AutoSize = true;
            this.labDiaChi.Location = new System.Drawing.Point(934, 9);
            this.labDiaChi.Name = "labDiaChi";
            this.labDiaChi.Size = new System.Drawing.Size(47, 16);
            this.labDiaChi.TabIndex = 4;
            this.labDiaChi.Text = "Địa chỉ";
            // 
            // labSdt
            // 
            this.labSdt.AutoSize = true;
            this.labSdt.Location = new System.Drawing.Point(14, 54);
            this.labSdt.Name = "labSdt";
            this.labSdt.Size = new System.Drawing.Size(39, 16);
            this.labSdt.TabIndex = 5;
            this.labSdt.Text = "SĐT*";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(326, 54);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(46, 16);
            this.labEmail.TabIndex = 6;
            this.labEmail.Text = "Email*";
            // 
            // labMonHoc
            // 
            this.labMonHoc.AutoSize = true;
            this.labMonHoc.Location = new System.Drawing.Point(14, 99);
            this.labMonHoc.Name = "labMonHoc";
            this.labMonHoc.Size = new System.Drawing.Size(63, 16);
            this.labMonHoc.TabIndex = 7;
            this.labMonHoc.Text = "Môn học*";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(80, 9);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(237, 22);
            this.txtHoTen.TabIndex = 8;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(80, 54);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(175, 22);
            this.txtSdt.TabIndex = 10;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Checked = false;
            this.dtpNgaySinh.Location = new System.Drawing.Point(464, 9);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(239, 22);
            this.dtpNgaySinh.TabIndex = 11;
            // 
            // rabNam
            // 
            this.rabNam.AutoSize = true;
            this.rabNam.Location = new System.Drawing.Point(840, 9);
            this.rabNam.Name = "rabNam";
            this.rabNam.Size = new System.Drawing.Size(57, 20);
            this.rabNam.TabIndex = 12;
            this.rabNam.TabStop = true;
            this.rabNam.Text = "Nam";
            this.rabNam.UseVisualStyleBackColor = true;
            // 
            // rabNu
            // 
            this.rabNu.AutoSize = true;
            this.rabNu.Location = new System.Drawing.Point(840, 47);
            this.rabNu.Name = "rabNu";
            this.rabNu.Size = new System.Drawing.Size(45, 20);
            this.rabNu.TabIndex = 13;
            this.rabNu.TabStop = true;
            this.rabNu.Text = "Nữ";
            this.rabNu.UseVisualStyleBackColor = true;
            // 
            // rtxtDiaChi
            // 
            this.rtxtDiaChi.Location = new System.Drawing.Point(1002, 6);
            this.rtxtDiaChi.Name = "rtxtDiaChi";
            this.rtxtDiaChi.Size = new System.Drawing.Size(568, 61);
            this.rtxtDiaChi.TabIndex = 14;
            this.rtxtDiaChi.Text = "";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(392, 52);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(311, 22);
            this.txtEmail.TabIndex = 15;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(94, 99);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(175, 24);
            this.cmbMonHoc.TabIndex = 16;
            this.cmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbMonHoc_SelectedIndexChanged);
            // 
            // btnCongMonHoc
            // 
            this.btnCongMonHoc.Location = new System.Drawing.Point(275, 99);
            this.btnCongMonHoc.Name = "btnCongMonHoc";
            this.btnCongMonHoc.Size = new System.Drawing.Size(24, 24);
            this.btnCongMonHoc.TabIndex = 17;
            this.btnCongMonHoc.Text = "+";
            this.btnCongMonHoc.UseVisualStyleBackColor = true;
            this.btnCongMonHoc.Click += new System.EventHandler(this.btnCongMonHoc_Click);
            // 
            // btnCongTrinhDo
            // 
            this.btnCongTrinhDo.Location = new System.Drawing.Point(598, 96);
            this.btnCongTrinhDo.Name = "btnCongTrinhDo";
            this.btnCongTrinhDo.Size = new System.Drawing.Size(24, 24);
            this.btnCongTrinhDo.TabIndex = 18;
            this.btnCongTrinhDo.Text = "+";
            this.btnCongTrinhDo.UseVisualStyleBackColor = true;
            this.btnCongTrinhDo.Click += new System.EventHandler(this.btnCongTrinhDo_Click);
            // 
            // labTrinhDo
            // 
            this.labTrinhDo.AutoSize = true;
            this.labTrinhDo.Location = new System.Drawing.Point(326, 99);
            this.labTrinhDo.Name = "labTrinhDo";
            this.labTrinhDo.Size = new System.Drawing.Size(61, 16);
            this.labTrinhDo.TabIndex = 19;
            this.labTrinhDo.Text = "Trình độ*";
            // 
            // cmbTrinhDo
            // 
            this.cmbTrinhDo.FormattingEnabled = true;
            this.cmbTrinhDo.Location = new System.Drawing.Point(392, 95);
            this.cmbTrinhDo.Name = "cmbTrinhDo";
            this.cmbTrinhDo.Size = new System.Drawing.Size(200, 24);
            this.cmbTrinhDo.TabIndex = 20;
            this.cmbTrinhDo.SelectedIndexChanged += new System.EventHandler(this.cmbTrinhDo_SelectedIndexChanged);
            // 
            // labNgayLam
            // 
            this.labNgayLam.AutoSize = true;
            this.labNgayLam.Location = new System.Drawing.Point(684, 99);
            this.labNgayLam.Name = "labNgayLam";
            this.labNgayLam.Size = new System.Drawing.Size(91, 16);
            this.labNgayLam.TabIndex = 21;
            this.labNgayLam.Text = "Ngày vào làm";
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.Checked = false;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(795, 94);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(246, 22);
            this.dtpNgayVaoLam.TabIndex = 22;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(17, 157);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(146, 157);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(275, 157);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(533, 157);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 26;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(662, 157);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 27;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(404, 157);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmQuanLyGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 753);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgayVaoLam);
            this.Controls.Add(this.labNgayLam);
            this.Controls.Add(this.cmbTrinhDo);
            this.Controls.Add(this.labTrinhDo);
            this.Controls.Add(this.btnCongTrinhDo);
            this.Controls.Add(this.btnCongMonHoc);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.rtxtDiaChi);
            this.Controls.Add(this.rabNu);
            this.Controls.Add(this.rabNam);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.labMonHoc);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labSdt);
            this.Controls.Add(this.labDiaChi);
            this.Controls.Add(this.labGioiTinh);
            this.Controls.Add(this.labNgaySinh);
            this.Controls.Add(this.labHoTen);
            this.Controls.Add(this.dgvGiaoVien);
            this.Name = "frmQuanLyGiaoVien";
            this.Text = "frmQuanLyGiaoVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.Label labHoTen;
        private System.Windows.Forms.Label labNgaySinh;
        private System.Windows.Forms.Label labGioiTinh;
        private System.Windows.Forms.Label labDiaChi;
        private System.Windows.Forms.Label labSdt;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labMonHoc;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rabNam;
        private System.Windows.Forms.RadioButton rabNu;
        private System.Windows.Forms.RichTextBox rtxtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.Button btnCongMonHoc;
        private System.Windows.Forms.Button btnCongTrinhDo;
        private System.Windows.Forms.Label labTrinhDo;
        private System.Windows.Forms.ComboBox cmbTrinhDo;
        private System.Windows.Forms.Label labNgayLam;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuu;
    }
}