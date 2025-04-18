using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTH_BTNhom;

namespace QLCBCNV
{
    public partial class frmThongKeLuong : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private bool isAdmin;
        public frmThongKeLuong(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            this.isAdmin = true;
            Admin(isAdmin);
        }
        private void frmThongKeLuong_Load(object sender, EventArgs e)
        {
            frmHelper.FullScreenForm(this);
            LoadData();
        }
        private void LoadData()
        {
            btnThongKe.Enabled = true;
            btnLuu.Enabled = false;

            Lock(true);
            LoadNam();
            LoadThang();
            LoadGiaoVien();
        }
        private void Admin(bool isAdmin)
        {
            if (!isAdmin)
            {
                btnThongKe.Enabled = false;
            }
        }
        private void LoadNam()
        {
            string query = "SELECT Nam FROM LuongCoSo ORDER BY Nam DESC";
            DataTable dt = db.ExecuteQuery(query);
            cbxNam.DataSource = dt;
            cbxNam.DisplayMember = "Nam";
            cbxNam.ValueMember = "Nam";
            cbxNam.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNam.SelectedIndex = -1;
        }
        private void LoadThang()
        {
            cbxThang.Items.Clear();
            for (int i = 1; i <= 12; i++)
                cbxThang.Items.Add(i);
            cbxThang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxThang.SelectedIndex = -1;
        }
        private void LoadGiaoVien()
        {
            string query = "SELECT MaGV, HoTen FROM GiaoVien";
            DataTable dt = db.ExecuteQuery(query);
            cbxGiaoVien.DataSource = dt;
            cbxGiaoVien.DisplayMember = "HoTen";
            cbxGiaoVien.ValueMember = "MaGV";
            cbxGiaoVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxGiaoVien.SelectedIndex = -1;
        }
        private void Lock(bool locked)
        {
            txtHeSoLuong.Enabled = false;
            txtMucLuongCoSo.Enabled = false;
            txtTongLuong.Enabled = false;
            txtTongPhuCap.Enabled = false;
            cbxGiaoVien.Enabled = false;

            cbxThang.Enabled = !locked;
            cbxNam.Enabled = !locked;

            if (locked)
            {
                txtHeSoLuong.Text = "";
                txtMucLuongCoSo.Text = "";
                txtTongLuong.Text = "";
                txtTongPhuCap.Text = "";
                cbxThang.SelectedIndex = -1;
                cbxNam.SelectedIndex = -1;
                cbxGiaoVien.SelectedIndex = -1;
            }
        }
        private bool ValidateInput()
        {
            if (cbxThang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxThang.Focus();
                return false;
            }

            if (cbxNam.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn năm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxNam.Focus();
                return false;
            }
            
            return true;
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnThongKe.Enabled = false;

            Lock(false);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            int thang = Convert.ToInt32(cbxThang.SelectedItem);
            int nam = Convert.ToInt32(cbxNam.SelectedValue);

            string query = @"
                SELECT 
                    l.MaGV,
                    gv.HoTen,
                    l.Thang,
                    l.Nam,
                    l.HeSoLuong,
                    l.MucLuongCoSo,
                    l.TongPhuCap,
                    l.TongLuong
                FROM Luong l
                JOIN GiaoVien gv ON gv.MaGV = l.MaGV
                WHERE l.Thang = @Thang AND l.Nam = @Nam";

            SqlParameter[] parameters = {
                new SqlParameter("@Thang", thang),
                new SqlParameter("@Nam", nam)
            };

            DataTable dt = db.ExecuteQuery(query, parameters);
            dgvLuong.DataSource = dt;

            dgvLuong.Columns["HeSoLuong"].DefaultCellStyle.Format = "N2";
            dgvLuong.Columns["MucLuongCoSo"].DefaultCellStyle.Format = "N0";
            dgvLuong.Columns["TongPhuCap"].DefaultCellStyle.Format = "N0";
            dgvLuong.Columns["TongLuong"].DefaultCellStyle.Format = "N0";

            LoadData();

            btnLuu.Enabled = false;
            btnThongKe.Enabled = true;

            Lock(true);
            Admin(isAdmin);
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnThongKe.Enabled = true;

            LoadData();
            Lock(true);
            Admin(isAdmin);

            dgvLuong.DataSource = null;
        }
        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThongKe.Enabled = false;
            btnLuu.Enabled = false;
            Admin(isAdmin);

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLuong.Rows[e.RowIndex];

                cbxGiaoVien.SelectedValue = row.Cells["MaGV"].Value?.ToString();

                cbxThang.SelectedItem = Convert.ToInt32(row.Cells["Thang"].Value);

                cbxNam.SelectedValue = Convert.ToInt32(row.Cells["Nam"].Value);

                decimal hs = Convert.ToDecimal(row.Cells["HeSoLuong"].Value);
                txtHeSoLuong.Text = hs.ToString("F2");

                decimal luongCoSo = Convert.ToDecimal(row.Cells["MucLuongCoSo"].Value);
                txtMucLuongCoSo.Text = luongCoSo.ToString("N0");

                decimal phuCap = Convert.ToDecimal(row.Cells["TongPhuCap"].Value);
                txtTongPhuCap.Text = phuCap.ToString("N0");

                decimal tongLuong = Convert.ToDecimal(row.Cells["TongLuong"].Value);
                txtTongLuong.Text = tongLuong.ToString("N0");
            }
        }
    }
}
