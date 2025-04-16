using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTH_BTNhom;

namespace QLCBCNV
{
    public partial class frmPhanCongGiangDay : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private string actionState = "";
        private bool isAdmin;
        private DataTable allTietTable;
        private DataTable allLopTable;
        public frmPhanCongGiangDay(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
        }

        private void frmPhanCongGiangDay_Load(object sender, EventArgs e)
        {
            frmHelper.FullScreenForm(this);
            LoadData();
        }

        private void LoadData()
        {
            Lock(true);
            LoadColor();
            LoadHocKyNamHoc();
            LoadBuoi();
            LoadTiet();
            LoadKhoi();
            LoadLop();
            LoadGiaoVien();
            LoadMonHoc();
            LoadThu();
            LoadPhanCongGiangDay();

            cbxBuoi.SelectedIndexChanged += cbxBuoi_SelectedIndexChanged;
            cbxKhoi.SelectedIndexChanged += cbxKhoi_SelectedIndexChanged;
            dtpNgayDay.ValueChanged += dtpNgayDay_ValueChanged;
        }
        private void LoadColor()
        {
            btnThem.BackColor = Color.FromArgb(40, 167, 69); ;
            btnSua.BackColor = Color.FromArgb(253, 126, 20);
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnLuu.BackColor = Color.FromArgb(0, 123, 255);
            btnTimKiem.BackColor = Color.FromArgb(108, 117, 125);
            btnLamMoi.BackColor = Color.FromArgb(32, 201, 151);

            // Màu chữ trắng cho tất cả
            btnThem.ForeColor = Color.White;
            btnSua.ForeColor = Color.White;
            btnXoa.ForeColor = Color.White;
            btnLuu.ForeColor = Color.White;
            btnTimKiem.ForeColor = Color.White;
            btnLamMoi.ForeColor = Color.White;
        }
        private void LoadHocKyNamHoc()
        {
            string query = @"
                SELECT MaHKNH, HocKy, NamHoc,
                       CAST(HocKy AS VARCHAR) + ' - (' + NamHoc + ')' AS HocKyNam
                FROM HocKyNamHoc
                ORDER BY NamHoc ASC, HocKy ASC";
            DataTable dt = db.ExecuteQuery(query);

            cbxKy.DataSource = dt;
            cbxKy.DisplayMember = "HocKyNam";
            cbxKy.ValueMember = "MaHKNH";

            cbxKy.DropDownStyle = ComboBoxStyle.DropDownList;

            cbxKy.SelectedIndex = -1;
        }
        private void LoadBuoi()
        {
            var dt = new DataTable();
            dt.Columns.Add("Buoi");

            dt.Rows.Add("Sáng");
            dt.Rows.Add("Chiều");
            dt.Rows.Add("Tối");

            cbxBuoi.DataSource = dt;
            cbxBuoi.DisplayMember = "Buoi";
            cbxBuoi.ValueMember = "Buoi";
            cbxBuoi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBuoi.SelectedIndex = -1;
        }
        private void LoadTiet()
        {
            allTietTable = new DataTable();
            allTietTable.Columns.Add("Tiet", typeof(int));
            allTietTable.Columns.Add("Buoi");

            for (int i = 1; i <= 13; i++)
            {
                string buoi = i <= 5 ? "Sáng" : (i <= 10 ? "Chiều" : "Tối");
                allTietTable.Rows.Add(i, buoi);
            }

            cbxTiet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTiet.SelectedIndex = -1;
    
        }
        private void LoadKhoi()
        {
            var khoiData = new DataTable();
            khoiData.Columns.Add("KhoiLop");

            khoiData.Rows.Add("10");
            khoiData.Rows.Add("11");
            khoiData.Rows.Add("12");

            cbxKhoi.DataSource = khoiData;
            cbxKhoi.DisplayMember = "KhoiLop";
            cbxKhoi.ValueMember = "KhoiLop";
            cbxKhoi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxKhoi.SelectedIndex = -1;
        }
        private void LoadLop()
        {
            string query = "SELECT MaLop, TenLop FROM LopHoc ORDER BY TenLop ASC";
            allLopTable = db.ExecuteQuery(query);

            FilterLopByKhoi();
        }
        private void LoadGiaoVien()
        {
            string query = "SELECT MaGV, HoTen FROM GiaoVien ORDER BY HoTen ASC";
            DataTable dt = db.ExecuteQuery(query);

            cbxGiaoVien.DataSource = dt;
            cbxGiaoVien.DisplayMember = "HoTen";
            cbxGiaoVien.ValueMember = "MaGV";
            cbxGiaoVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxGiaoVien.SelectedIndex = -1;
        }
        private void LoadMonHoc()
        {
            string query = "SELECT MaMonHoc, TenMonHoc FROM MonHoc ORDER BY TenMonHoc ASC";
            DataTable dt = db.ExecuteQuery(query);

            cbxMonHoc.DataSource = dt;
            cbxMonHoc.DisplayMember = "TenMonHoc";
            cbxMonHoc.ValueMember = "MaMonHoc";
            cbxMonHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMonHoc.SelectedIndex = -1;
        }
        private void LoadThu()
        {
            var thu = (int)dtpNgayDay.Value.DayOfWeek;
            string[] thuText = { "Chủ nhật", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7" };
            txtThu.Text = thuText[thu];

            txtThu.ReadOnly = true;
        }
        private void LoadPhanCongGiangDay()
        {
            string query = @"
                SELECT 
                    pc.MaPC,
                    gv.HoTen AS GiaoVien,
                    mh.TenMonHoc AS MonHoc,
                    lh.TenLop AS Lop,
                    CAST(hknh.HocKy AS VARCHAR) + ' - ' + CAST(hknh.NamHoc AS VARCHAR) AS HocKyNam,  -- Sửa ở đây
                    pc.NgayDay,
                    CASE pc.ThuTrongTuan
                        WHEN 2 THEN N'Thứ 2'
                        WHEN 3 THEN N'Thứ 3'
                        WHEN 4 THEN N'Thứ 4'
                        WHEN 5 THEN N'Thứ 5'
                        WHEN 6 THEN N'Thứ 6'
                        WHEN 7 THEN N'Thứ 7'
                        WHEN 8 THEN N'Chủ nhật'
                    END AS Thu,
                    pc.Tiet,
                    pc.SoTiet
                FROM PhanCongGiangDay pc
                INNER JOIN GiaoVien gv ON pc.MaGV = gv.MaGV
                INNER JOIN MonHoc mh ON pc.MaMonHoc = mh.MaMonHoc
                INNER JOIN LopHoc lh ON pc.MaLop = lh.MaLop
                INNER JOIN HocKyNamHoc hknh ON pc.MaHKNH = hknh.MaHKNH
                ORDER BY pc.NgayDay DESC, pc.Tiet ASC
            ";

            DataTable dt = db.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                dgvPhanCong.DataSource = dt;
                dgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPhanCong.ReadOnly = true;
                dgvPhanCong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");
            }
        }
        private void Lock(bool locked)
        {
            cbxTiet.Enabled = false;
            cbxLop.Enabled = false;
            txtThu.Enabled = false;

            cbxKy.Enabled = !locked;
            cbxBuoi.Enabled = !locked;
            cbxKhoi.Enabled = !locked;
            cbxGiaoVien.Enabled = !locked;
            cbxMonHoc.Enabled = !locked;
            dtpNgayDay.Enabled = !locked;

            if (locked)
            {
                cbxTiet.SelectedIndex = -1;
                cbxLop.SelectedIndex = -1;
                txtThu.Text = "";

                cbxKy.SelectedIndex = -1;
                cbxBuoi.SelectedIndex = -1;
                cbxKhoi.SelectedIndex = -1;
                cbxGiaoVien.SelectedIndex = -1;
                cbxMonHoc.SelectedIndex = -1;
                dtpNgayDay.Value = DateTime.Now;
            }
        }
        private void FilterTietByBuoi()
        {
            if (cbxBuoi.SelectedItem == null || allTietTable == null || !allTietTable.Columns.Contains("Tiet")) return;

            string selectedBuoi = cbxBuoi.Text.Trim();
            DataView dv = new DataView(allTietTable);
            dv.RowFilter = $"Buoi = '{selectedBuoi}'";

            cbxTiet.DataSource = dv;
            cbxTiet.DisplayMember = "Tiet";
            cbxTiet.ValueMember = "Tiet";
            cbxTiet.SelectedIndex = -1;
        }
        private void FilterLopByKhoi()
        {
            if (cbxKhoi.SelectedItem == null || allLopTable == null) return;

            string selectedKhoi = cbxKhoi.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(selectedKhoi)) return;

            DataView dv = new DataView(allLopTable);
            dv.RowFilter = $"TenLop LIKE '{selectedKhoi}%'";

            cbxLop.DataSource = dv;
            cbxLop.DisplayMember = "TenLop";
            cbxLop.ValueMember = "MaLop";
            cbxLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLop.SelectedIndex = -1;
        }
        private void cbxBuoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBuoi.SelectedItem != null)
            {
                FilterTietByBuoi();
                cbxTiet.Enabled = true;    
            }
            else
            {
                cbxTiet.Enabled = false;
            }
        }
        private void cbxKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKhoi.SelectedItem != null)
            {
                FilterLopByKhoi();
                cbxLop.Enabled = true;
            }
            else
            {
                cbxLop.Enabled = false;
            }
        }
        private void dtpNgayDay_ValueChanged(object sender, EventArgs e)
        {
            LoadThu();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void dgvPhanCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
