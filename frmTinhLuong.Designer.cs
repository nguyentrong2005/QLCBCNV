namespace QLCBCNV
{
    partial class frmTinhLuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labGiaoVien = new System.Windows.Forms.Label();
            this.cbxGiaoVien = new System.Windows.Forms.ComboBox();
            this.cbxThang = new System.Windows.Forms.ComboBox();
            this.labThang = new System.Windows.Forms.Label();
            this.cbxNam = new System.Windows.Forms.ComboBox();
            this.labNam = new System.Windows.Forms.Label();
            this.labMaLuong = new System.Windows.Forms.Label();
            this.txtMaLuong = new System.Windows.Forms.TextBox();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.labHeSoLuong = new System.Windows.Forms.Label();
            this.txtMucLuongCoSo = new System.Windows.Forms.TextBox();
            this.labMucLuongCoSo = new System.Windows.Forms.Label();
            this.txtTongPhuCap = new System.Windows.Forms.TextBox();
            this.labTongPhuCap = new System.Windows.Forms.Label();
            this.txtTongLuong = new System.Windows.Forms.TextBox();
            this.TongLuong = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.dgvTinhLuong = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // labGiaoVien
            // 
            this.labGiaoVien.AutoSize = true;
            this.labGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGiaoVien.Location = new System.Drawing.Point(12, 116);
            this.labGiaoVien.Name = "labGiaoVien";
            this.labGiaoVien.Size = new System.Drawing.Size(161, 39);
            this.labGiaoVien.TabIndex = 0;
            this.labGiaoVien.Text = "Giáo viên";
            // 
            // cbxGiaoVien
            // 
            this.cbxGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGiaoVien.FormattingEnabled = true;
            this.cbxGiaoVien.Location = new System.Drawing.Point(194, 116);
            this.cbxGiaoVien.Name = "cbxGiaoVien";
            this.cbxGiaoVien.Size = new System.Drawing.Size(347, 46);
            this.cbxGiaoVien.TabIndex = 1;
            this.cbxGiaoVien.SelectedIndexChanged += new System.EventHandler(this.cbxGiaoVien_SelectedIndexChanged);
            // 
            // cbxThang
            // 
            this.cbxThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxThang.FormattingEnabled = true;
            this.cbxThang.Location = new System.Drawing.Point(502, 12);
            this.cbxThang.Name = "cbxThang";
            this.cbxThang.Size = new System.Drawing.Size(145, 46);
            this.cbxThang.TabIndex = 4;
            this.cbxThang.SelectedIndexChanged += new System.EventHandler(this.cbxThang_SelectedIndexChanged);
            // 
            // labThang
            // 
            this.labThang.AutoSize = true;
            this.labThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labThang.Location = new System.Drawing.Point(373, 18);
            this.labThang.Name = "labThang";
            this.labThang.Size = new System.Drawing.Size(114, 39);
            this.labThang.TabIndex = 3;
            this.labThang.Text = "Tháng";
            // 
            // cbxNam
            // 
            this.cbxNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNam.FormattingEnabled = true;
            this.cbxNam.Location = new System.Drawing.Point(837, 12);
            this.cbxNam.Name = "cbxNam";
            this.cbxNam.Size = new System.Drawing.Size(145, 46);
            this.cbxNam.TabIndex = 6;
            this.cbxNam.SelectedIndexChanged += new System.EventHandler(this.cbxNam_SelectedIndexChanged);
            // 
            // labNam
            // 
            this.labNam.AutoSize = true;
            this.labNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNam.Location = new System.Drawing.Point(708, 19);
            this.labNam.Name = "labNam";
            this.labNam.Size = new System.Drawing.Size(89, 39);
            this.labNam.TabIndex = 5;
            this.labNam.Text = "Năm";
            // 
            // labMaLuong
            // 
            this.labMaLuong.AutoSize = true;
            this.labMaLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaLuong.Location = new System.Drawing.Point(12, 19);
            this.labMaLuong.Name = "labMaLuong";
            this.labMaLuong.Size = new System.Drawing.Size(168, 39);
            this.labMaLuong.TabIndex = 7;
            this.labMaLuong.Text = "Mã Lương";
            // 
            // txtMaLuong
            // 
            this.txtMaLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLuong.Location = new System.Drawing.Point(194, 16);
            this.txtMaLuong.Name = "txtMaLuong";
            this.txtMaLuong.Size = new System.Drawing.Size(130, 45);
            this.txtMaLuong.TabIndex = 8;
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeSoLuong.Location = new System.Drawing.Point(827, 113);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(293, 45);
            this.txtHeSoLuong.TabIndex = 10;
            // 
            // labHeSoLuong
            // 
            this.labHeSoLuong.AutoSize = true;
            this.labHeSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeSoLuong.Location = new System.Drawing.Point(598, 119);
            this.labHeSoLuong.Name = "labHeSoLuong";
            this.labHeSoLuong.Size = new System.Drawing.Size(199, 39);
            this.labHeSoLuong.TabIndex = 9;
            this.labHeSoLuong.Text = "Hệ số lương";
            // 
            // txtMucLuongCoSo
            // 
            this.txtMucLuongCoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMucLuongCoSo.Location = new System.Drawing.Point(1342, 12);
            this.txtMucLuongCoSo.Name = "txtMucLuongCoSo";
            this.txtMucLuongCoSo.Size = new System.Drawing.Size(278, 45);
            this.txtMucLuongCoSo.TabIndex = 12;
            // 
            // labMucLuongCoSo
            // 
            this.labMucLuongCoSo.AutoSize = true;
            this.labMucLuongCoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMucLuongCoSo.Location = new System.Drawing.Point(1046, 15);
            this.labMucLuongCoSo.Name = "labMucLuongCoSo";
            this.labMucLuongCoSo.Size = new System.Drawing.Size(264, 39);
            this.labMucLuongCoSo.TabIndex = 11;
            this.labMucLuongCoSo.Text = "Mức lương cơ sở";
            // 
            // txtTongPhuCap
            // 
            this.txtTongPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongPhuCap.Location = new System.Drawing.Point(1444, 113);
            this.txtTongPhuCap.Name = "txtTongPhuCap";
            this.txtTongPhuCap.Size = new System.Drawing.Size(280, 45);
            this.txtTongPhuCap.TabIndex = 14;
            // 
            // labTongPhuCap
            // 
            this.labTongPhuCap.AutoSize = true;
            this.labTongPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTongPhuCap.Location = new System.Drawing.Point(1202, 116);
            this.labTongPhuCap.Name = "labTongPhuCap";
            this.labTongPhuCap.Size = new System.Drawing.Size(225, 39);
            this.labTongPhuCap.TabIndex = 13;
            this.labTongPhuCap.Text = "Tổng phụ cấp";
            // 
            // txtTongLuong
            // 
            this.txtTongLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongLuong.Location = new System.Drawing.Point(213, 209);
            this.txtTongLuong.Name = "txtTongLuong";
            this.txtTongLuong.Size = new System.Drawing.Size(328, 45);
            this.txtTongLuong.TabIndex = 16;
            // 
            // TongLuong
            // 
            this.TongLuong.AutoSize = true;
            this.TongLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongLuong.Location = new System.Drawing.Point(12, 212);
            this.TongLuong.Name = "TongLuong";
            this.TongLuong.Size = new System.Drawing.Size(188, 39);
            this.TongLuong.TabIndex = 15;
            this.TongLuong.Text = "Tổng lương";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(1157, 305);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(192, 55);
            this.btnLamMoi.TabIndex = 53;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(860, 305);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(209, 55);
            this.btnTimKiem.TabIndex = 52;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(468, 305);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 55);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(667, 305);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(105, 55);
            this.btnLuu.TabIndex = 50;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(258, 305);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 55);
            this.btnSua.TabIndex = 49;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuong.Location = new System.Drawing.Point(605, 204);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(210, 55);
            this.btnTinhLuong.TabIndex = 48;
            this.btnTinhLuong.Text = "Tính lương";
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // dgvTinhLuong
            // 
            this.dgvTinhLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTinhLuong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTinhLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTinhLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTinhLuong.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTinhLuong.Location = new System.Drawing.Point(19, 394);
            this.dgvTinhLuong.Name = "dgvTinhLuong";
            this.dgvTinhLuong.RowHeadersWidth = 51;
            this.dgvTinhLuong.RowTemplate.Height = 24;
            this.dgvTinhLuong.Size = new System.Drawing.Size(1969, 769);
            this.dgvTinhLuong.TabIndex = 54;
            this.dgvTinhLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTinhLuong_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(19, 305);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(151, 55);
            this.btnThem.TabIndex = 55;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1175);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvTinhLuong);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.txtTongLuong);
            this.Controls.Add(this.TongLuong);
            this.Controls.Add(this.txtTongPhuCap);
            this.Controls.Add(this.labTongPhuCap);
            this.Controls.Add(this.txtMucLuongCoSo);
            this.Controls.Add(this.labMucLuongCoSo);
            this.Controls.Add(this.txtHeSoLuong);
            this.Controls.Add(this.labHeSoLuong);
            this.Controls.Add(this.txtMaLuong);
            this.Controls.Add(this.labMaLuong);
            this.Controls.Add(this.cbxNam);
            this.Controls.Add(this.labNam);
            this.Controls.Add(this.cbxThang);
            this.Controls.Add(this.labThang);
            this.Controls.Add(this.cbxGiaoVien);
            this.Controls.Add(this.labGiaoVien);
            this.Name = "frmTinhLuong";
            this.Text = "frmTinhLuong";
            this.Load += new System.EventHandler(this.frmTinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labGiaoVien;
        private System.Windows.Forms.ComboBox cbxGiaoVien;
        private System.Windows.Forms.ComboBox cbxThang;
        private System.Windows.Forms.Label labThang;
        private System.Windows.Forms.ComboBox cbxNam;
        private System.Windows.Forms.Label labNam;
        private System.Windows.Forms.Label labMaLuong;
        private System.Windows.Forms.TextBox txtMaLuong;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.Label labHeSoLuong;
        private System.Windows.Forms.TextBox txtMucLuongCoSo;
        private System.Windows.Forms.Label labMucLuongCoSo;
        private System.Windows.Forms.TextBox txtTongPhuCap;
        private System.Windows.Forms.Label labTongPhuCap;
        private System.Windows.Forms.TextBox txtTongLuong;
        private System.Windows.Forms.Label TongLuong;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.DataGridView dgvTinhLuong;
        private System.Windows.Forms.Button btnThem;
    }
}