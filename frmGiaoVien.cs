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
    public partial class frmGiaoVien : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private string actionState = "";
        private bool isAdmin;
        public frmGiaoVien(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            this.isAdmin = true;
            Admin(isAdmin);
        }
        private void frmGiaoVien_Load(object sender, EventArgs e)
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
            dtpNgaySinh.ShowCheckBox = true;
            dtpNgayVaoLam.ShowCheckBox = true;

            Lock(true);
            LoadHangGV();
            LoadGiaoVien();
        }
        private void Admin(bool isAdmin)
        {
            if (!isAdmin)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
        private void LoadHangGV()
        {
            string query = "SELECT MaHangGV, TenHangGV FROM HangGiaoVien ORDER BY MaHangGV ASC";
            DataTable dt = db.ExecuteQuery(query);

            cbxHangGiaoVien.DataSource = dt;
            cbxHangGiaoVien.DisplayMember = "TenHangGV";
            cbxHangGiaoVien.ValueMember = "MaHangGV";
            cbxHangGiaoVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxHangGiaoVien.SelectedIndex = -1;
        }
        private void LoadGiaoVien()
        {
            string query = @"
            SELECT 
                MaGV,
                HoTen,
                CASE GioiTinh 
                    WHEN 1 THEN N'Nam'
                    WHEN 0 THEN N'Nữ'
                END AS GioiTinh,
                NgaySinh,
                DiaChi,
                Email,
                SoDienThoai,
                MaHangGV,
                NgayVaoLam
            FROM GiaoVien";

            DataTable dt = db.ExecuteQuery(query);
            dgvGiaoVien.DataSource = dt;
        }
        private void Lock(bool locked)
        {
            txtMaGV.Enabled = false;

            txtHoTenGV.Enabled = !locked;
            txtSDT.Enabled = !locked;
            txtEmail.Enabled = !locked;
            rtxtDiaChi.Enabled = !locked;
            cbxHangGiaoVien.Enabled = !locked;
            radNam.Enabled = !locked;
            radNu.Enabled = !locked;
            dtpNgaySinh.Enabled = !locked;
            dtpNgayVaoLam.Enabled = !locked;

            if (locked)
            {
                txtMaGV.Text = "";

                txtEmail.Text = "";
                txtHoTenGV.Text = "";
                txtSDT.Text = "";
                rtxtDiaChi.Text = "";
                cbxHangGiaoVien.SelectedIndex = -1;
                radNam.Checked = false;
                radNu.Checked = false;
                dtpNgaySinh.Value = DateTime.Now;
                dtpNgayVaoLam.Value = DateTime.Now;
            }
        }
        private bool ValidateInput()
        {
            if (!(actionState == "TimKiem"))
            {
                if (string.IsNullOrWhiteSpace(txtHoTenGV.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHoTenGV.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSDT.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Vui lòng nhập email giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(rtxtDiaChi.Text))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rtxtDiaChi.Focus();
                    return false;
                }

                if (!radNam.Checked && !radNu.Checked)
                {
                    MessageBox.Show("Vui lòng chọn giới tính của giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!dtpNgaySinh.Checked)
                {
                    MessageBox.Show("Vui lòng chọn ngày sinh của giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!dtpNgayVaoLam.Checked)
                {
                    MessageBox.Show("Vui lòng chọn ngày dạy của giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cbxHangGiaoVien.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn hạng giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxHangGiaoVien.Focus();
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
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGiaoVien.SelectedRows.Count > 0)
            {
                string maGV = dgvGiaoVien.SelectedRows[0].Cells["MaGV"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa giáo viên \"{maGV}\" không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM GiaoVien WHERE MaGV = @MaGV";
                    SqlParameter[] parameters = { new SqlParameter("@MaGV", maGV) };

                    db.ExecuteNonQuery(query, parameters);
                    LoadData();
                    Lock(true);
                    MessageBox.Show("Xóa giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giáo viên cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (actionState == "Them")
            {
                string query = "INSERT INTO GiaoVien (HoTen, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, MaHangGV, NgayVaoLam) " +
                               "VALUES (@HoTen, @GioiTinh, @NgaySinh, @DiaChi, @Email, @SoDienThoai, @MaHangGV, @NgayVaoLam)";
                
                SqlParameter[] parameters = {
                    new SqlParameter("@HoTen", txtHoTenGV.Text),
                    new SqlParameter("@GioiTinh", radNam.Checked ? 1 : 0),
                    new SqlParameter("@NgaySinh", dtpNgaySinh.Value),
                    new SqlParameter("@DiaChi", rtxtDiaChi.Text),
                    new SqlParameter("@Email", txtEmail.Text),
                    new SqlParameter("@SoDienThoai", txtSDT.Text),
                    new SqlParameter("@MaHangGV", cbxHangGiaoVien.SelectedValue),
                    new SqlParameter("@NgayVaoLam", dtpNgayVaoLam.Value)
                };

                // Hiển thị các tham số
                string message = "Tham số:\n";
                foreach (var param in parameters)
                {
                    message += $"{param.ParameterName}: {param.Value}\n";
                }
                MessageBox.Show(message);

                db.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Thêm giáo viên thành công!");
            }
            else if (actionState == "Sua")
            {
                string query = "UPDATE GiaoVien SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, " +
                               "Email = @Email, SoDienThoai = @SoDienThoai, MaHangGV = @MaHangGV, NgayVaoLam = @NgayVaoLam " +
                               "WHERE MaGV = @MaGV";

                SqlParameter[] parameters = {
                    new SqlParameter("@HoTen", txtHoTenGV.Text),
                    new SqlParameter("@GioiTinh", radNam.Checked ? 1 : 0),
                    new SqlParameter("@NgaySinh", dtpNgaySinh.Value),
                    new SqlParameter("@DiaChi", rtxtDiaChi.Text),
                    new SqlParameter("@Email", txtEmail.Text),
                    new SqlParameter("@SoDienThoai", txtSDT.Text),
                    new SqlParameter("@MaHangGV", cbxHangGiaoVien.SelectedValue),
                    new SqlParameter("@NgayVaoLam", dtpNgayVaoLam.Value),
                    new SqlParameter("@MaGV", txtMaGV.Text)
                };

                string message = "Tham số:\n";
                foreach (var param in parameters)
                {
                    message += $"{param.ParameterName}: {param.Value}\n";
                }
                MessageBox.Show(message);

                db.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Cập nhật giáo viên thành công!");
            }
            else if (actionState == "TimKiem")
            {
                List<string> conditions = new List<string>();
                List<SqlParameter> parameters = new List<SqlParameter>();

                if (!string.IsNullOrWhiteSpace(txtMaGV.Text))
                {
                    conditions.Add("MaGV = @MaGV");
                    parameters.Add(new SqlParameter("@MaGV", txtMaGV.Text));
                }

                if (!string.IsNullOrWhiteSpace(txtHoTenGV.Text))
                {
                    conditions.Add("HoTen LIKE @HoTen");
                    parameters.Add(new SqlParameter("@HoTen", "%" + txtHoTenGV.Text + "%"));
                }

                if (radNam.Checked || radNu.Checked)
                {
                    bool gioiTinh = radNam.Checked ? true : false;
                    conditions.Add("GioiTinh = @GioiTinh");
                    parameters.Add(new SqlParameter("@GioiTinh", gioiTinh));
                }

                if (dtpNgaySinh.Checked)
                {
                    conditions.Add("CONVERT(date, NgaySinh) = @NgaySinh");
                    parameters.Add(new SqlParameter("@NgaySinh", dtpNgaySinh.Value.Date));
                }

                if (!string.IsNullOrWhiteSpace(rtxtDiaChi.Text))
                {
                    conditions.Add("DiaChi LIKE @DiaChi");
                    parameters.Add(new SqlParameter("@DiaChi", "%" + rtxtDiaChi.Text + "%"));
                }

                if (cbxHangGiaoVien.SelectedValue != null && cbxHangGiaoVien.SelectedIndex != -1)
                {
                    conditions.Add("MaHangGV = @MaHangGV");
                    parameters.Add(new SqlParameter("@MaHangGV", cbxHangGiaoVien.SelectedValue));
                }

                if (dtpNgayVaoLam.Checked)
                {
                    conditions.Add("CONVERT(date, NgayVaoLam) = @NgayVaoLam");
                    parameters.Add(new SqlParameter("@NgayVaoLam", dtpNgayVaoLam.Value.Date));
                }

                string query = "SELECT * FROM GiaoVien";

                if (conditions.Count > 0)
                {
                    query += " WHERE " + string.Join(" AND ", conditions);
                }

                DataTable dt = db.ExecuteQuery(query, parameters.ToArray());
                dgvGiaoVien.DataSource = dt;

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
            btnThem.Enabled = true;
            btnTimKiem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            LoadData();
            Lock(true);
            actionState = "";
            Admin(isAdmin);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            Lock(false);
            actionState = "TimKiem";
            Admin(isAdmin);
        }
        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnThem.Enabled = false;
            btnTimKiem.Enabled = false;

            Admin(isAdmin);

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGiaoVien.Rows[e.RowIndex];

                txtMaGV.Text = row.Cells["MaGV"]?.Value?.ToString() ?? "";

                txtHoTenGV.Text = row.Cells["HoTen"]?.Value?.ToString() ?? "";

                if (row.Cells["GioiTinh"].Value != null)
                {
                    string gioiTinh = row.Cells["GioiTinh"].Value.ToString().Trim();

                    if (gioiTinh == "Nam")
                    {
                        radNam.Checked = true;
                        radNu.Checked = false;
                    }
                    else if (gioiTinh == "Nữ")
                    {
                        radNam.Checked = false;
                        radNu.Checked = true;
                    }
                    else
                    {
                        radNam.Checked = false;
                        radNu.Checked = false;
                    }
                }
                else
                {
                    radNam.Checked = false;
                    radNu.Checked = false;
                }

                if (row.Cells["NgaySinh"].Value != null && DateTime.TryParse(row.Cells["NgaySinh"].Value.ToString(), out DateTime ngaySinh))
                    dtpNgaySinh.Value = ngaySinh;
                else
                    dtpNgaySinh.Value = DateTime.Now;

                rtxtDiaChi.Text = row.Cells["DiaChi"]?.Value?.ToString() ?? "";

                txtEmail.Text = row.Cells["Email"]?.Value?.ToString() ?? "";

                txtSDT.Text = row.Cells["SoDienThoai"]?.Value?.ToString() ?? "";

                if (row.Cells["MaHangGV"].Value != null)
                    cbxHangGiaoVien.SelectedValue = row.Cells["MaHangGV"].Value.ToString();
                else
                    cbxHangGiaoVien.SelectedIndex = -1;

                if (row.Cells["NgayVaoLam"].Value != null && DateTime.TryParse(row.Cells["NgayVaoLam"].Value.ToString(), out DateTime ngayVaoLam))
                    dtpNgayVaoLam.Value = ngayVaoLam;
                else
                    dtpNgayVaoLam.Value = DateTime.Now;
            }
        }
        private void dgvGiaoVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvGiaoVien.Columns[e.ColumnIndex].Name == "GioiTinh" && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int gioiTinh))
                {
                    e.Value = gioiTinh == 1 ? "Nam" : "Nữ";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
