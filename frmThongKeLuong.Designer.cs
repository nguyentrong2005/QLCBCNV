namespace QLCBCNV
{
    partial class frmThongKeLuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labThang = new System.Windows.Forms.Label();
            this.cbxThang = new System.Windows.Forms.ComboBox();
            this.cbxNam = new System.Windows.Forms.ComboBox();
            this.labNam = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.txtTongLuong = new System.Windows.Forms.TextBox();
            this.TongLuong = new System.Windows.Forms.Label();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.labHeSoLuong = new System.Windows.Forms.Label();
            this.cbxGiaoVien = new System.Windows.Forms.ComboBox();
            this.labGiaoVien = new System.Windows.Forms.Label();
            this.txtTongPhuCap = new System.Windows.Forms.TextBox();
            this.labTongPhuCap = new System.Windows.Forms.Label();
            this.txtMucLuongCoSo = new System.Windows.Forms.TextBox();
            this.labMucLuongCoSo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // labThang
            // 
            this.labThang.AutoSize = true;
            this.labThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labThang.Location = new System.Drawing.Point(28, 222);
            this.labThang.Name = "labThang";
            this.labThang.Size = new System.Drawing.Size(114, 39);
            this.labThang.TabIndex = 0;
            this.labThang.Text = "Tháng";
            // 
            // cbxThang
            // 
            this.cbxThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxThang.FormattingEnabled = true;
            this.cbxThang.Location = new System.Drawing.Point(167, 219);
            this.cbxThang.Name = "cbxThang";
            this.cbxThang.Size = new System.Drawing.Size(121, 46);
            this.cbxThang.TabIndex = 1;
            // 
            // cbxNam
            // 
            this.cbxNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNam.FormattingEnabled = true;
            this.cbxNam.Location = new System.Drawing.Point(495, 219);
            this.cbxNam.Name = "cbxNam";
            this.cbxNam.Size = new System.Drawing.Size(121, 46);
            this.cbxNam.TabIndex = 4;
            // 
            // labNam
            // 
            this.labNam.AutoSize = true;
            this.labNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNam.Location = new System.Drawing.Point(387, 222);
            this.labNam.Name = "labNam";
            this.labNam.Size = new System.Drawing.Size(89, 39);
            this.labNam.TabIndex = 3;
            this.labNam.Text = "Năm";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(35, 313);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(198, 48);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(560, 313);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(198, 48);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(342, 313);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 48);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvLuong
            // 
            this.dgvLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLuong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLuong.Location = new System.Drawing.Point(12, 402);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.RowHeadersWidth = 51;
            this.dgvLuong.RowTemplate.Height = 24;
            this.dgvLuong.Size = new System.Drawing.Size(1969, 761);
            this.dgvLuong.TabIndex = 55;
            this.dgvLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuong_CellClick);
            // 
            // txtTongLuong
            // 
            this.txtTongLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongLuong.Location = new System.Drawing.Point(245, 121);
            this.txtTongLuong.Name = "txtTongLuong";
            this.txtTongLuong.Size = new System.Drawing.Size(328, 45);
            this.txtTongLuong.TabIndex = 61;
            // 
            // TongLuong
            // 
            this.TongLuong.AutoSize = true;
            this.TongLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongLuong.Location = new System.Drawing.Point(28, 124);
            this.TongLuong.Name = "TongLuong";
            this.TongLuong.Size = new System.Drawing.Size(188, 39);
            this.TongLuong.TabIndex = 60;
            this.TongLuong.Text = "Tổng lương";
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeSoLuong.Location = new System.Drawing.Point(857, 28);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(293, 45);
            this.txtHeSoLuong.TabIndex = 59;
            // 
            // labHeSoLuong
            // 
            this.labHeSoLuong.AutoSize = true;
            this.labHeSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeSoLuong.Location = new System.Drawing.Point(626, 31);
            this.labHeSoLuong.Name = "labHeSoLuong";
            this.labHeSoLuong.Size = new System.Drawing.Size(199, 39);
            this.labHeSoLuong.TabIndex = 58;
            this.labHeSoLuong.Text = "Hệ số lương";
            // 
            // cbxGiaoVien
            // 
            this.cbxGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGiaoVien.FormattingEnabled = true;
            this.cbxGiaoVien.Location = new System.Drawing.Point(215, 28);
            this.cbxGiaoVien.Name = "cbxGiaoVien";
            this.cbxGiaoVien.Size = new System.Drawing.Size(347, 46);
            this.cbxGiaoVien.TabIndex = 57;
            // 
            // labGiaoVien
            // 
            this.labGiaoVien.AutoSize = true;
            this.labGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGiaoVien.Location = new System.Drawing.Point(28, 31);
            this.labGiaoVien.Name = "labGiaoVien";
            this.labGiaoVien.Size = new System.Drawing.Size(161, 39);
            this.labGiaoVien.TabIndex = 56;
            this.labGiaoVien.Text = "Giáo viên";
            // 
            // txtTongPhuCap
            // 
            this.txtTongPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongPhuCap.Location = new System.Drawing.Point(1497, 28);
            this.txtTongPhuCap.Name = "txtTongPhuCap";
            this.txtTongPhuCap.Size = new System.Drawing.Size(280, 45);
            this.txtTongPhuCap.TabIndex = 67;
            // 
            // labTongPhuCap
            // 
            this.labTongPhuCap.AutoSize = true;
            this.labTongPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTongPhuCap.Location = new System.Drawing.Point(1240, 31);
            this.labTongPhuCap.Name = "labTongPhuCap";
            this.labTongPhuCap.Size = new System.Drawing.Size(225, 39);
            this.labTongPhuCap.TabIndex = 66;
            this.labTongPhuCap.Text = "Tổng phụ cấp";
            // 
            // txtMucLuongCoSo
            // 
            this.txtMucLuongCoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMucLuongCoSo.Location = new System.Drawing.Point(978, 118);
            this.txtMucLuongCoSo.Name = "txtMucLuongCoSo";
            this.txtMucLuongCoSo.Size = new System.Drawing.Size(278, 45);
            this.txtMucLuongCoSo.TabIndex = 65;
            // 
            // labMucLuongCoSo
            // 
            this.labMucLuongCoSo.AutoSize = true;
            this.labMucLuongCoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMucLuongCoSo.Location = new System.Drawing.Point(675, 121);
            this.labMucLuongCoSo.Name = "labMucLuongCoSo";
            this.labMucLuongCoSo.Size = new System.Drawing.Size(264, 39);
            this.labMucLuongCoSo.TabIndex = 64;
            this.labMucLuongCoSo.Text = "Mức lương cơ sở";
            // 
            // frmThongKeLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1175);
            this.Controls.Add(this.txtTongPhuCap);
            this.Controls.Add(this.labTongPhuCap);
            this.Controls.Add(this.txtMucLuongCoSo);
            this.Controls.Add(this.labMucLuongCoSo);
            this.Controls.Add(this.txtTongLuong);
            this.Controls.Add(this.TongLuong);
            this.Controls.Add(this.txtHeSoLuong);
            this.Controls.Add(this.labHeSoLuong);
            this.Controls.Add(this.cbxGiaoVien);
            this.Controls.Add(this.labGiaoVien);
            this.Controls.Add(this.dgvLuong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.cbxNam);
            this.Controls.Add(this.labNam);
            this.Controls.Add(this.cbxThang);
            this.Controls.Add(this.labThang);
            this.Name = "frmThongKeLuong";
            this.Text = "frmThongKeLuong";
            this.Load += new System.EventHandler(this.frmThongKeLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labThang;
        private System.Windows.Forms.ComboBox cbxThang;
        private System.Windows.Forms.ComboBox cbxNam;
        private System.Windows.Forms.Label labNam;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.TextBox txtTongLuong;
        private System.Windows.Forms.Label TongLuong;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.Label labHeSoLuong;
        private System.Windows.Forms.ComboBox cbxGiaoVien;
        private System.Windows.Forms.Label labGiaoVien;
        private System.Windows.Forms.TextBox txtTongPhuCap;
        private System.Windows.Forms.Label labTongPhuCap;
        private System.Windows.Forms.TextBox txtMucLuongCoSo;
        private System.Windows.Forms.Label labMucLuongCoSo;
    }
}