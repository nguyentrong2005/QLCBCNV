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

namespace QLCBCNV
{
    public partial class frmQuanLyGiaoVien : Form
    {
        public frmQuanLyGiaoVien()
        {
            InitializeComponent();
            SetTextBoxesReadOnly(true);
            // Load comboBox
            LoadMonHocToComboBox();
            LoadTrinhDoToComboBox();
            //
            LoadDanhSachGiaoVien();
            //
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }
        private bool isAdding = false;
        private bool isLoading = true;
        private bool isSearching = false;
        // Load danh sách môn học khi mở form
        private void LoadDanhSachGiaoVien()
        {
            string query = "SELECT * FROM GiaoVien ORDER BY MaGV ASC";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvGiaoVien.DataSource = dt;
        }
        // Khóa textbox
        private void SetTextBoxesReadOnly(bool state)
        {
            txtHoTen.ReadOnly = state;
            txtEmail.ReadOnly = state;
            txtSdt.ReadOnly = state;
            rtxtDiaChi.ReadOnly = state;

            cmbMonHoc.Enabled = !state;
            cmbTrinhDo.Enabled = !state;
            dtpNgaySinh.Enabled = !state;
            dtpNgayVaoLam.Enabled = !state;
            btnCongMonHoc.Enabled = !state;
            btnCongTrinhDo.Enabled = !state;
            rabNam.Enabled = !state;
            rabNu.Enabled = !state;
            dtpNgaySinh.Checked = !state;
            dtpNgayVaoLam.Checked = !state;
        }
        private void ClearTextBoxes()
        {
            //text box
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSdt.Clear();
            rtxtDiaChi.Clear();
            //date
            dtpNgaySinh.Value = DateTime.Now;
            dtpNgayVaoLam.Value = DateTime.Now;
            //radio
            rabNam.Checked = false;
            rabNu.Checked = false;
            //combo box
            cmbMonHoc.SelectedIndex = -1;
            cmbTrinhDo.SelectedIndex = -1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            isSearching = false;
            btnLuu.Enabled = true;
            btnTimKiem.Enabled = false;
            btnThem.Enabled = false;

            ClearTextBoxes();

            // Đưa con trỏ chuột vào ô nhập họ tên
            txtHoTen.Focus();

            // Mở khóa textbox để nhập dữ liệu
            SetTextBoxesReadOnly(false);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            SetTextBoxesReadOnly(false);
            txtHoTen.Focus();
            btnSua.Enabled = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Tìm kiếm
            if (isSearching)
            {
                string query = "SELECT * FROM GiaoVien WHERE 1=1";
                List<SqlParameter> parameters = new List<SqlParameter>();

                // Họ tên
                if (!string.IsNullOrWhiteSpace(txtHoTen.Text))
                {
                    query += " AND HoTen LIKE @HoTen";
                    parameters.Add(new SqlParameter("@HoTen", "%" + txtHoTen.Text.Trim() + "%"));
                }
                // Số điện thoại
                if (!string.IsNullOrWhiteSpace(txtSdt.Text))
                {
                    query += " AND SoDienThoai LIKE @SoDienThoai";
                    parameters.Add(new SqlParameter("@SoDienThoai", "%" + txtSdt.Text.Trim() + "%"));
                }
                // Email
                if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    query += " AND Email LIKE @Email";
                    parameters.Add(new SqlParameter("@Email", "%" + txtEmail.Text.Trim() + "%"));
                }
                // Mã môn học
                if (cmbMonHoc.SelectedIndex != -1)
                {
                    query += " AND MaMonHoc = @MaMonHoc";
                    parameters.Add(new SqlParameter("@MaMonHoc", cmbMonHoc.SelectedValue.ToString()));
                }
                // Trình độ
                if (cmbTrinhDo.SelectedIndex != -1)
                {
                    query += " AND MaTrinhDo = @MaTrinhDo";
                    parameters.Add(new SqlParameter("@MaTrinhDo", cmbTrinhDo.SelectedValue.ToString()));
                }
                // Địa chỉ
                if (!string.IsNullOrWhiteSpace(rtxtDiaChi.Text))
                {
                    query += " AND DiaChi LIKE @DiaChi";
                    parameters.Add(new SqlParameter("@DiaChi", "%" + rtxtDiaChi.Text.Trim() + "%"));
                }
                // Giới tính
                if (rabNam.Checked)
                {
                    query += " AND GioiTinh = @GioiTinh";
                    parameters.Add(new SqlParameter("@GioiTinh", "Nam"));
                }
                if (rabNu.Checked)
                {
                    query += " AND GioiTinh = @GioiTinh";
                    parameters.Add(new SqlParameter("@GioiTinh", "Nữ"));
                }
                // Ngày sinh
                if (dtpNgaySinh.Checked && dtpNgaySinh.Value.Date != DateTime.Today)
                {
                    query += " AND NgaySinh = @NgaySinh";
                    parameters.Add(new SqlParameter("@NgaySinh", dtpNgaySinh.Value.Date));
                }
                // Ngày vào làm
                if (dtpNgayVaoLam.Checked && dtpNgayVaoLam.Value.Date != DateTime.Today)
                {
                    query += " AND NgayVaoLam = @NgayVaoLam";
                    parameters.Add(new SqlParameter("@NgayVaoLam", dtpNgayVaoLam.Value.Date));
                }

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
                dgvGiaoVien.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Tìm kiếm hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                isSearching = false;
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                return;
            }
            // Thêm và sửa
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtSdt.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                cmbMonHoc.SelectedIndex == -1 ||
                cmbTrinhDo.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string sdt = txtSdt.Text.Trim();
            string diaChi = rtxtDiaChi.Text.Trim();
            DateTime ngaySinh = dtpNgaySinh.Value;
            DateTime ngayVaoLam = dtpNgayVaoLam.Value;
            string gioiTinh = rabNam.Checked ? "Nam" : "Nữ";
            string maMonHoc = cmbMonHoc.SelectedValue.ToString();
            string maTrinhDo = cmbTrinhDo.SelectedValue.ToString();

            if (isAdding)
            {
                string query = @"INSERT INTO GiaoVien (HoTen, Email, SoDienThoai, DiaChi, MaMonHoc, MaTrinhDo, NgaySinh, NgayVaoLam, GioiTinh) 
                         VALUES (@HoTen, @Email, @SoDienThoai, @DiaChi, @MaMonHoc, @MaTrinhDo, @NgaySinh, @NgayVaoLam, @GioiTinh)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@HoTen", hoTen),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@SoDienThoai", sdt),
                    new SqlParameter("@DiaChi", diaChi),
                    new SqlParameter("@MaMonHoc", maMonHoc),
                    new SqlParameter("@MaTrinhDo", maTrinhDo),
                    new SqlParameter("@NgaySinh", ngaySinh),
                    new SqlParameter("@NgayVaoLam", ngayVaoLam),
                    new SqlParameter("@GioiTinh", gioiTinh),
                };

                if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
                {
                    MessageBox.Show("Thêm giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachGiaoVien(); // Refresh danh sách
                    ClearTextBoxes();
                    SetTextBoxesReadOnly(true);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string maGV = dgvGiaoVien.SelectedRows[0].Cells["MaGV"].Value.ToString();

                string updateQuery = @"UPDATE GiaoVien 
                                   SET HoTen = @HoTen, Email = @Email, SoDienThoai = @SoDienThoai, DiaChi = @DiaChi, 
                                       MaMonHoc = @MaMonHoc, MaTrinhDo = @MaTrinhDo, NgaySinh = @NgaySinh, 
                                       NgayVaoLam = @NgayVaoLam, GioiTinh = @GioiTinh
                                   WHERE MaGV = @MaGV";

                SqlParameter[] updateParams = new SqlParameter[]
{
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@Email", email),
                new SqlParameter("@SoDienThoai", sdt),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@MaMonHoc", maMonHoc),
                new SqlParameter("@MaTrinhDo", maTrinhDo),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@NgayVaoLam", ngayVaoLam),
                new SqlParameter("@GioiTinh", gioiTinh),
                new SqlParameter("@MaGV", maGV)
                };

                if (DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams) > 0)
                {
                    MessageBox.Show("Cập nhật giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Làm mới dữ liệu
            LoadDanhSachGiaoVien();
            ClearTextBoxes();
            SetTextBoxesReadOnly(true);
            btnLuu.Enabled = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maGV = dgvGiaoVien.SelectedRows[0].Cells["MaGV"].Value.ToString();

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa giáo viên có mã {maGV} không?", "Xác nhận",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM GiaoVien WHERE MaGV = @MaGV";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaGV", maGV)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachGiaoVien(); // Cập nhật danh sách   
                }
                else
                {
                    MessageBox.Show("Xóa không thành công. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            isAdding = false;
            isSearching = true;
            SetTextBoxesReadOnly(false);
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtHoTen.Focus();
            btnTimKiem.Enabled = false;
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            SetTextBoxesReadOnly(true);
            ClearTextBoxes();
            LoadMonHocToComboBox();
            LoadTrinhDoToComboBox();
            LoadDanhSachGiaoVien();

            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnTimKiem.Enabled = true;
        }
        private void btnCongMonHoc_Click(object sender, EventArgs e)
        {
            frmQuanLyMonHoc formMonHoc = new frmQuanLyMonHoc();
            formMonHoc.ShowDialog();
        }
        private void btnCongTrinhDo_Click(object sender, EventArgs e)
        {
            frmQuanLyTrinhDo formTrinhDo = new frmQuanLyTrinhDo();
            formTrinhDo.ShowDialog();
        }
        private void LoadMonHocToComboBox()
        {
            isLoading = true;
            string query = "SELECT MaMonHoc, TenMonHoc FROM MonHoc ORDER BY TenMonHoc ASC";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            cmbMonHoc.DataSource = dt;
            cmbMonHoc.DisplayMember = "TenMonHoc"; // Hiển thị tên môn học
            cmbMonHoc.ValueMember = "MaMonHoc";    // Giá trị thực tế là MaMonHoc
            cmbMonHoc.SelectedIndex = -1; // Không chọn gì ban đầu

            isLoading = false;
        }
        private void LoadTrinhDoToComboBox()
        {
            isLoading = true;
            string query = "SELECT MaTrinhDo, TenTrinhDo FROM TrinhDo ORDER BY TenTrinhDo ASC";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            cmbTrinhDo.DataSource = dt;
            cmbTrinhDo.DisplayMember = "TenTrinhDo"; // Hiển thị tên trình độ
            cmbTrinhDo.ValueMember = "MaTrinhDo"; // Giá trị thực tế là MaTrinhDo
            cmbTrinhDo.SelectedIndex = -1; // Không chọn gì ban đầu

            isLoading = false;
        }
        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading || cmbMonHoc.SelectedIndex == -1)
                return;

            string maMonHoc = cmbMonHoc.SelectedValue.ToString();
            string tenMonHoc = cmbMonHoc.Text;

            if (isAdding)
                MessageBox.Show($"Bạn đã chọn môn học: {tenMonHoc} (Mã: {maMonHoc})", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cmbTrinhDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading || cmbTrinhDo.SelectedIndex == -1)
                return;

            string maTrinhDo = cmbTrinhDo.SelectedValue.ToString();
            string tenTrinhDo = cmbTrinhDo.Text;

            if (isAdding)
                MessageBox.Show($"Bạn đã chọn trình độ: {tenTrinhDo} (Mã: {maTrinhDo})", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isAdding = false;
            isSearching = false;

            if (e.RowIndex >= 0 && dgvGiaoVien.Rows[e.RowIndex].Cells.Count > 0) // Đảm bảo chỉ số hợp lệ
            {
                DataGridViewRow row = dgvGiaoVien.Rows[e.RowIndex];

                // Kiểm tra và gán giá trị vào các TextBox (tránh lỗi null)
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString().Trim();
                rtxtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString().Trim();
                txtSdt.Text = row.Cells["SoDienThoai"].Value?.ToString().Trim();
                txtEmail.Text = row.Cells["Email"].Value?.ToString().Trim();
                string gioiTinh = row.Cells["GioiTinh"].Value.ToString().Trim();

                // Giới tính
                if (gioiTinh == "Nam")
                {
                    rabNam.Checked = true;
                    rabNu.Checked = false;
                }
                else if (gioiTinh == "Nữ")
                {
                    rabNam.Checked = false;
                    rabNu.Checked = true;
                }

                // Xử lý DateTimePicker
                if (row.Cells["NgaySinh"].Value != null && DateTime.TryParse(row.Cells["NgaySinh"].Value.ToString(), out DateTime ngaySinh))
                {
                    dtpNgaySinh.Value = ngaySinh;
                }
                if (row.Cells["NgayVaoLam"].Value != null && DateTime.TryParse(row.Cells["NgayVaoLam"].Value.ToString(), out DateTime ngayVaoLam))
                {
                    dtpNgayVaoLam.Value = ngayVaoLam;
                }

                // Xử lý Combobox
                if (row.Cells["MaMonHoc"].Value != null)
                {
                    string maMonHoc = row.Cells["MaMonHoc"].Value.ToString().Trim();
                    cmbMonHoc.SelectedValue = maMonHoc;
                }
                if (row.Cells["MaTrinhDo"].Value != null)
                {
                    string maTrinhDo = row.Cells["MaTrinhDo"].Value.ToString().Trim();
                    cmbTrinhDo.SelectedValue = maTrinhDo;
                }

                // Hiện nút "Sửa" và "Xóa"
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                // Ẩn nút "Thêm", "Lưu" và "Tìm kiếm"
                btnThem.Enabled = false;
                btnLuu.Enabled = false;
                btnTimKiem.Enabled = false;

                // Khóa chỉnh sửa các TextBox
                SetTextBoxesReadOnly(true);
            }
        }
    }
}
