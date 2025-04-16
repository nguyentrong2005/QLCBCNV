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
            this.isAdmin = true;
            Admin(isAdmin);
        }
        private void frmPhanCongGiangDay_Load(object sender, EventArgs e)
        {
            frmHelper.FullScreenForm(this);
            LoadData();
        }
        private void LoadData()
        {
            btnThem.Enabled = true;
            btnTimKiem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            dtpNgayDay.ShowCheckBox = true;

            Lock(true);
            LoadColor();
            LoadHocKyNamHoc();
            LoadBuoi();
            LoadTiet();
            LoadSoTiet();
            LoadKhoi();
            LoadLop();
            LoadGiaoVien();
            LoadMonHoc();
            LoadThu();
            LoadPhanCongGiangDay();

            cbxBuoi.SelectedIndexChanged += cbxBuoi_SelectedIndexChanged;
            cbxKhoi.SelectedIndexChanged += cbxKhoi_SelectedIndexChanged;
            dtpNgayDay.ValueChanged += dtpNgayDay_ValueChanged;
            txtTong.Text = (dgvPhanCong.Rows.Count - 1).ToString();
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
        private void LoadSoTiet()
        {
            cbxSoTiet.Items.Clear();
            for (int i = 1; i <= 5; i++)
            {
                cbxSoTiet.Items.Add(i);
            }

            cbxSoTiet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSoTiet.SelectedIndex = -1;
        }
        private void LoadKhoi()
        {
            string query = "SELECT DISTINCT LEFT(TenLop, 2) AS Khoi FROM LopHoc ORDER BY Khoi ASC";
            DataTable dt = db.ExecuteQuery(query);

            cbxKhoi.DataSource = dt;
            cbxKhoi.DisplayMember = "Khoi";
            cbxKhoi.ValueMember = "Khoi";
            cbxKhoi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxKhoi.SelectedIndex = -1;
        }
        private void LoadLop()
        {
            string query = "SELECT MaLop, TenLop FROM LopHoc ORDER BY TenLop ASC";
            DataTable dt = db.ExecuteQuery(query);

            cbxLop.DataSource = dt;
            cbxLop.DisplayMember = "TenLop";
            cbxLop.ValueMember = "MaLop";
            cbxLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLop.SelectedIndex = -1;
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
            string[] thuText = { "Chủ nhật", "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu", "Thứ Bảy" };
            txtThu.Text = thuText[thu];

            txtThu.ReadOnly = true;
        }
        private void LoadPhanCongGiangDay()
        {
            string query = "SELECT * FROM PhanCongGiangDay";

            DataTable dt = db.ExecuteQuery(query);
            dgvPhanCong.DataSource = dt;
        }
        private void Lock(bool locked)
        {
            cbxTiet.Enabled = false;
            cbxLop.Enabled = false;
            txtThu.Enabled = false;
            txtMaPC.Enabled = false;
            txtTong.Enabled = false;
            dtpNgayDay.Checked = false;

            cbxKy.Enabled = !locked;
            cbxSoTiet.Enabled = !locked;
            cbxBuoi.Enabled = !locked;
            cbxKhoi.Enabled = !locked;
            cbxGiaoVien.Enabled = !locked;
            cbxMonHoc.Enabled = !locked;
            dtpNgayDay.Enabled = !locked;

            txtTong.Text = (dgvPhanCong.Rows.Count - 1).ToString();

            if (locked)
            {
                cbxTiet.SelectedIndex = -1;
                cbxLop.SelectedIndex = -1;
                txtThu.Text = "";
                txtMaPC.Text = "";

                cbxKy.SelectedIndex = -1;
                cbxBuoi.SelectedIndex = -1;
                cbxKhoi.SelectedIndex = -1;
                cbxGiaoVien.SelectedIndex = -1;
                cbxMonHoc.SelectedIndex = -1;
                cbxSoTiet.SelectedIndex = -1;
                dtpNgayDay.Value = DateTime.Now;
            }
        }
        private void Admin(bool isAdmin)
        {
            if (isAdmin)
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
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
            if (cbxKhoi.SelectedItem == null) return;

            string selectedKhoi = cbxKhoi.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(selectedKhoi)) return;

            string query = $"SELECT MaLop, TenLop FROM LopHoc WHERE TenLop LIKE '{selectedKhoi}%' ORDER BY TenLop ASC";
            DataTable dt = db.ExecuteQuery(query);

            cbxLop.DataSource = dt;
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
        private bool ValidateInput()
        {
            if (!(actionState == "TimKiem"))
            {
                if (cbxGiaoVien.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxGiaoVien.Focus();
                    return false;
                }

                if (cbxMonHoc.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxMonHoc.Focus();
                    return false;
                }

                if (cbxLop.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn lớp học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxLop.Focus();
                    return false;
                }

                if (cbxKy.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn học kỳ - năm học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxKy.Focus();
                    return false;
                }

                if (!dtpNgayDay.Checked)
                {
                    MessageBox.Show("Vui lòng chọn ngày dạy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpNgayDay.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtThu.Text))
                {
                    MessageBox.Show("Vui lòng nhập thứ trong tuần.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtThu.Focus();
                    return false;
                }

                if (cbxTiet.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn tiết dạy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxTiet.Focus();
                    return false;
                }

                if (cbxSoTiet.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn số tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxSoTiet.Focus();
                    return false;
                }
            }

            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnTimKiem.Enabled = false;

            Lock(false);
            actionState = "Them";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            Lock(false);
            actionState = "Sua";
            cbxTiet.Enabled = true;
            cbxLop.Enabled = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhanCong.SelectedRows.Count > 0)
            {
                string maPC = dgvPhanCong.SelectedRows[0].Cells["MaPC"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn lịch phân công \"{maPC}\" không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM PhanCongGiangDay WHERE MaPC = @MaPC";
                    SqlParameter[] parameters = { new SqlParameter("@MaPC", maPC) };

                    db.ExecuteNonQuery(query, parameters);
                    LoadData();
                    Lock(true);
                    MessageBox.Show("Xóa lịch phân công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lịch phân công cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (actionState == "Them")
            {
                int thuTrongTuan = 0;
                if (int.TryParse(new string(txtThu.Text.Where(char.IsDigit).ToArray()), out int thu))
                {
                    thuTrongTuan = thu;
                }

                string query = "INSERT INTO PhanCongGiangDay (MaGV, MaMonHoc, MaLop, MaHKNH, NgayDay, ThuTrongTuan, Tiet, SoTiet) " +
                               "VALUES (@MaGV, @MaMonHoc, @MaLop, @MaHKNH, @NgayDay, @ThuTrongTuan, @Tiet, @SoTiet)";
                SqlParameter[] parameters = {
                    new SqlParameter("@MaGV", cbxGiaoVien.SelectedValue),
                    new SqlParameter("@MaMonHoc", cbxMonHoc.SelectedValue),
                    new SqlParameter("@MaLop", cbxLop.SelectedValue),
                    new SqlParameter("@MaHKNH", cbxKy.SelectedValue),
                    new SqlParameter("@NgayDay", dtpNgayDay.Value),
                    new SqlParameter("@ThuTrongTuan", thuTrongTuan),
                    new SqlParameter("@Tiet", cbxTiet.SelectedValue),
                    new SqlParameter("@SoTiet", Convert.ToInt32(cbxSoTiet.SelectedItem))
                };

                // Hiển thị các tham số
                string message = "Tham số:\n";
                foreach (var param in parameters)
                {
                    message += $"{param.ParameterName}: {param.Value}\n";
                }
                MessageBox.Show(message);

                db.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Thêm phân công giảng dạy thành công!");
            }
            else if (actionState == "Sua")
            {
                int thuTrongTuan = 0;
                if (int.TryParse(new string(txtThu.Text.Where(char.IsDigit).ToArray()), out int thu))
                {
                    thuTrongTuan = thu;
                }

                string query = "UPDATE PhanCongGiangDay SET MaGV = @MaGV, MaMonHoc = @MaMonHoc, MaLop = @MaLop, MaHKNH = @MaHKNH, " +
                               "NgayDay = @NgayDay, ThuTrongTuan = @ThuTrongTuan, Tiet = @Tiet, SoTiet = @SoTiet " +
                               "WHERE MaPC = @MaPC";
                SqlParameter[] parameters = {
                    new SqlParameter("@MaGV", cbxGiaoVien.SelectedValue),
                    new SqlParameter("@MaMonHoc", cbxMonHoc.SelectedValue),
                    new SqlParameter("@MaLop", cbxLop.SelectedValue),
                    new SqlParameter("@MaHKNH", cbxKy.SelectedValue),
                    new SqlParameter("@NgayDay", dtpNgayDay.Value),
                    new SqlParameter("@ThuTrongTuan", thuTrongTuan),
                    new SqlParameter("@Tiet", cbxTiet.SelectedValue),
                    new SqlParameter("@SoTiet", Convert.ToInt32(cbxSoTiet.SelectedItem)),
                    new SqlParameter("@MaPC", txtMaPC.Text)
                };

                // Hiển thị các tham số
                string message = "Tham số:\n";
                foreach (var param in parameters)
                {
                    message += $"{param.ParameterName}: {param.Value}\n";
                }
                MessageBox.Show(message);

                db.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Cập nhật phân công giảng dạy thành công!");
            }
            else if (actionState == "TimKiem")
            {
                List<string> conditions = new List<string>();
                List<SqlParameter> parameters = new List<SqlParameter>();

                if (cbxGiaoVien.SelectedValue != null && cbxGiaoVien.SelectedIndex != -1)
                {
                    conditions.Add("MaGV = @MaGV");
                    parameters.Add(new SqlParameter("@MaGV", cbxGiaoVien.SelectedValue));
                }

                if (cbxMonHoc.SelectedValue != null && cbxMonHoc.SelectedIndex != -1)
                {
                    conditions.Add("MaMonHoc = @MaMonHoc");
                    parameters.Add(new SqlParameter("@MaMonHoc", cbxMonHoc.SelectedValue));
                }

                if (cbxLop.SelectedValue != null && cbxLop.SelectedIndex != -1)
                {
                    conditions.Add("MaLop = @MaLop");
                    parameters.Add(new SqlParameter("@MaLop", cbxLop.SelectedValue));
                }

                if (cbxKy.SelectedValue != null && cbxKy.SelectedIndex != -1)
                {
                    conditions.Add("MaHKNH = @MaHKNH");
                    parameters.Add(new SqlParameter("@MaHKNH", cbxKy.SelectedValue));
                }

                if (dtpNgayDay.Checked)
                {
                    conditions.Add("CONVERT(date, NgayDay) = @NgayDay");
                    parameters.Add(new SqlParameter("@NgayDay", dtpNgayDay.Value.Date));
                }

                string query = "SELECT * FROM PhanCongGiangDay";

                if (conditions.Count > 0)
                {
                    query += " WHERE " + string.Join(" AND ", conditions);
                }

                DataTable dt = db.ExecuteQuery(query, parameters.ToArray());
                dgvPhanCong.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (!(actionState == "TimKiem"))
                LoadData();

            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnTimKiem.Enabled = true;

            Lock(true);
            Admin(isAdmin);
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Admin(isAdmin);

            btnThem.Enabled = true;
            btnTimKiem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            LoadData();
            Lock(true);
            actionState = "";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Admin(isAdmin);
            btnTimKiem.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            Lock(false);
            actionState = "TimKiem";
        }
        private void dgvPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Admin(isAdmin);

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnThem.Enabled = false;
            btnTimKiem.Enabled = false;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhanCong.Rows[e.RowIndex];

                txtMaPC.Text = row.Cells["MaPC"]?.Value?.ToString() ?? "";

                // GiaoVien
                if (row.Cells["MaGV"].Value != null)
                    cbxGiaoVien.SelectedValue = row.Cells["MaGV"].Value.ToString();
                else
                    cbxGiaoVien.SelectedIndex = -1;

                // MonHoc
                if (row.Cells["MaMonHoc"].Value != null)
                    cbxMonHoc.SelectedValue = row.Cells["MaMonHoc"].Value.ToString();
                else
                    cbxMonHoc.SelectedIndex = -1;

                // Lop
                if (row.Cells["MaLop"].Value != null)
                {
                    string maLop = row.Cells["MaLop"].Value.ToString();

                    string query = $"SELECT TenLop FROM LopHoc WHERE MaLop = '{maLop}'";
                    DataTable dtLop = db.ExecuteQuery(query);

                    if (dtLop.Rows.Count > 0)
                    {
                        string tenLop = dtLop.Rows[0]["TenLop"].ToString();

                        string khoi = tenLop.Length >= 2 ? tenLop.Substring(0, 2) : "";

                        if (!string.IsNullOrEmpty(khoi))
                        {
                            cbxKhoi.SelectedValue = khoi;
                        }
                        else
                        {
                            cbxKhoi.SelectedIndex = -1;
                        }

                        cbxLop.SelectedValue = maLop;
                        cbxLop.Enabled = false;
                    }
                }
                else
                {
                    cbxLop.SelectedIndex = -1;
                    cbxKhoi.SelectedIndex = -1;
                }

                // HocKyNam
                if (row.Cells["MaHKNH"].Value != null)
                    cbxKy.SelectedValue = row.Cells["MaHKNH"].Value.ToString();
                else
                    cbxKy.SelectedIndex = -1;

                // NgayDay
                if (row.Cells["NgayDay"].Value != null && DateTime.TryParse(row.Cells["NgayDay"].Value.ToString(), out DateTime ngayDay))
                    dtpNgayDay.Value = ngayDay;
                else
                    dtpNgayDay.Value = DateTime.Now;

                // Thu
                if (row.Cells["ThuTrongTuan"].Value != null)
                {
                    int thuSo;
                    if (int.TryParse(row.Cells["ThuTrongTuan"].Value.ToString(), out thuSo))
                    {
                        string thuChu = "";
                        switch (thuSo)
                        {
                            case 2: thuChu = "Thứ Hai"; break;
                            case 3: thuChu = "Thứ Ba"; break;
                            case 4: thuChu = "Thứ Tư"; break;
                            case 5: thuChu = "Thứ Năm"; break;
                            case 6: thuChu = "Thứ Sáu"; break;
                            case 7: thuChu = "Thứ Bảy"; break;
                            case 8: thuChu = "Chủ Nhật"; break; // hoặc dùng 1
                            default: thuChu = "Không xác định"; break;
                        }

                        txtThu.Text = thuChu;
                    }
                    else
                    {
                        txtThu.Text = "";
                    }
                }
                else
                {
                    txtThu.Text = "";
                }

                // Tiet
                if (row.Cells["Tiet"].Value != null)
                {
                    int tiet = Convert.ToInt32(row.Cells["Tiet"].Value);
                    string buoi = tiet <= 5 ? "Sáng" : (tiet <= 10 ? "Chiều" : "Tối");

                    cbxBuoi.SelectedValue = buoi;
                    cbxTiet.SelectedValue = tiet;
                    cbxTiet.Enabled = false;
                }
                else
                {
                    cbxTiet.SelectedIndex = -1;
                    cbxBuoi.SelectedIndex = -1;
                }    

                // SoTiet
                if (row.Cells["SoTiet"].Value != null)
                    cbxSoTiet.Text = row.Cells["SoTiet"].Value.ToString();
                else
                    cbxSoTiet.SelectedIndex = -1;
            }
        }
        private void dgvPhanCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
