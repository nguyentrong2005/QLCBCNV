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
    public partial class frmTinhLuong : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private string actionState = "";
        private bool isAdmin;
        public frmTinhLuong(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            this.isAdmin = true;
            Admin(isAdmin);
        }
        private void frmTinhLuong_Load(object sender, EventArgs e)
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

            Lock(true);
            LoadNam();
            LoadThang();
            LoadGiaoVien();
            LoadLuong();
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
        private void LoadMucLuongCoSo()
        {
            if (cbxNam.SelectedValue != null && int.TryParse(cbxNam.SelectedValue.ToString(), out int nam))
            {
                string query = "SELECT MucLuong FROM LuongCoSo WHERE Nam = @Nam";
                object mucLuong = db.ExecuteScalar(query, new SqlParameter[]
                {
            new SqlParameter("@Nam", nam)
                });
                txtMucLuongCoSo.Text = mucLuong?.ToString() ?? "0";
            }
            else
            {
                txtMucLuongCoSo.Text = "0";
            }
        }
        private void LoadThongTinLuong()
        {
            if (cbxGiaoVien.SelectedValue != null && cbxNam.SelectedValue != null && cbxThang.SelectedItem != null)
            {
                string maGV = cbxGiaoVien.SelectedValue.ToString();
                int nam = Convert.ToInt32(cbxNam.SelectedValue);
                int thang = Convert.ToInt32(cbxThang.SelectedItem);

                string queryHeSo = @"
                    SELECT hgv.HeSoLuong
                    FROM GiaoVien gv
                    JOIN HangGiaoVien hgv ON gv.MaHangGV = hgv.MaHangGV
                    WHERE gv.MaGV = @MaGV";
                object heSo = db.ExecuteScalar(queryHeSo, new SqlParameter[]
                {
                    new SqlParameter("@MaGV", maGV)
                });
                txtHeSoLuong.Text = heSo?.ToString() ?? "0";

                string queryPC = @"
                    SELECT ISNULL(SUM(SoTien), 0)
                    FROM PhuCap
                    WHERE MaGV = @MaGV AND Nam = @Nam AND Thang = @Thang";
                object tongPC = db.ExecuteScalar(queryPC, new SqlParameter[]
                {
                    new SqlParameter("@MaGV", maGV),
                    new SqlParameter("@Nam", nam),
                    new SqlParameter("@Thang", thang)
                });
                txtTongPhuCap.Text = tongPC?.ToString() ?? "0";
            }
        }
        private void LoadLuong()
        {
            string query = @"SELECT * FROM Luong";

            DataTable dt = db.ExecuteQuery(query);
            dgvTinhLuong.DataSource = dt;
        }
        private void cbxNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMucLuongCoSo();
            LoadThongTinLuong();
        }
        private void cbxThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThongTinLuong();
        }
        private void cbxGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThongTinLuong();
        }
        private void Lock(bool locked)
        {
            txtMaLuong.Enabled = false;
            txtHeSoLuong.Enabled = false;
            txtMucLuongCoSo.Enabled = false;
            txtTongLuong.Enabled = false;
            txtTongPhuCap.Enabled = false;

            cbxThang.Enabled = !locked;
            cbxNam.Enabled = !locked;
            cbxGiaoVien.Enabled = !locked;
           
            if (locked)
            {
                txtMaLuong.Text = "";

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
            if (!(actionState == "TimKiem"))
            {
                if (string.IsNullOrWhiteSpace(txtHeSoLuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập hệ số lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHeSoLuong.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtMucLuongCoSo.Text))
                {
                    MessageBox.Show("Vui lòng nhập lương cơ sở.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMucLuongCoSo.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtTongPhuCap.Text))
                {
                    MessageBox.Show("Vui lòng nhập tổng phụ cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTongPhuCap.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtTongLuong.Text))
                {
                    MessageBox.Show("Vui lòng tính tổng lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTongLuong.Focus();
                    return false;
                }

                if (cbxGiaoVien.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxGiaoVien.Focus();
                    return false;
                }

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
            }

            return true;
        }
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            try
            {
                float heSo = float.Parse(txtHeSoLuong.Text);
                decimal luongCoSo = decimal.Parse(txtMucLuongCoSo.Text);
                decimal phuCap = decimal.Parse(txtTongPhuCap.Text);

                decimal tongLuong = (decimal)heSo * luongCoSo + phuCap;
                txtTongLuong.Text = tongLuong.ToString();

                btnLuu.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ để tính lương!");
            }
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
            if (dgvTinhLuong.SelectedRows.Count > 0)
            {
                string maLuong = dgvTinhLuong.SelectedRows[0].Cells["MaLuong"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa mã lương \"{maLuong}\" không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM Luong WHERE MaLuong = @MaLuong";
                    SqlParameter[] parameters = { new SqlParameter("@MaLuong", maLuong) };

                    db.ExecuteNonQuery(query, parameters);
                    LoadData();
                    Lock(true);
                    MessageBox.Show("Xóa mã lương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng mã lương viên cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (actionState == "Them")
            {
                string query = @"INSERT INTO Luong (MaGV, Thang, Nam, HeSoLuong, MucLuongCoSo, TongPhuCap, TongLuong)
                         VALUES (@MaGV, @Thang, @Nam, @HeSoLuong, @MucLuongCoSo, @TongPhuCap, @TongLuong)";

                SqlParameter[] parameters = {
                    new SqlParameter("@MaGV", cbxGiaoVien.SelectedValue.ToString()),
                    new SqlParameter("@Thang", Convert.ToInt32(cbxThang.SelectedItem)),
                    new SqlParameter("@Nam", Convert.ToInt32(cbxNam.SelectedValue)),
                    new SqlParameter("@HeSoLuong", float.Parse(txtHeSoLuong.Text)),
                    new SqlParameter("@MucLuongCoSo", decimal.Parse(txtMucLuongCoSo.Text)),
                    new SqlParameter("@TongPhuCap", decimal.Parse(txtTongPhuCap.Text)),
                    new SqlParameter("@TongLuong", decimal.Parse(txtTongLuong.Text))
                };

                // Hiển thị các tham số
                string message = "Tham số:\n";
                foreach (var param in parameters)
                {
                    message += $"{param.ParameterName}: {param.Value}\n";
                }
                MessageBox.Show(message);

                db.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Thêm lương thành công!");
            }
            else if (actionState == "Sua")
            {
                string query = @"UPDATE Luong 
                         SET MaGV = @MaGV, Thang = @Thang, Nam = @Nam, HeSoLuong = @HeSoLuong, 
                             MucLuongCoSo = @MucLuongCoSo, TongPhuCap = @TongPhuCap, TongLuong = @TongLuong
                         WHERE MaLuong = @MaLuong";

                SqlParameter[] parameters = {
                    new SqlParameter("@MaLuong", txtMaLuong.Text.Trim()),
                    new SqlParameter("@MaGV", cbxGiaoVien.SelectedValue.ToString()),
                    new SqlParameter("@Thang", Convert.ToInt32(cbxThang.SelectedItem)),
                    new SqlParameter("@Nam", Convert.ToInt32(cbxNam.SelectedValue)),
                    new SqlParameter("@HeSoLuong", float.Parse(txtHeSoLuong.Text)),
                    new SqlParameter("@MucLuongCoSo", decimal.Parse(txtMucLuongCoSo.Text)),
                    new SqlParameter("@TongPhuCap", decimal.Parse(txtTongPhuCap.Text)),
                    new SqlParameter("@TongLuong", decimal.Parse(txtTongLuong.Text))
                };

                string message = "Tham số:\n";
                foreach (var param in parameters)
                {
                    message += $"{param.ParameterName}: {param.Value}\n";
                }
                MessageBox.Show(message);

                db.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Cập nhật lương thành công!");
            }
            else if (actionState == "TimKiem")
            {
                List<string> conditions = new List<string>();
                List<SqlParameter> parameters = new List<SqlParameter>();

                if (cbxGiaoVien.SelectedValue != null && cbxGiaoVien.SelectedIndex != -1)
                {
                    conditions.Add("MaGV = @MaGV");
                    parameters.Add(new SqlParameter("@MaGV", cbxGiaoVien.SelectedValue.ToString()));
                }

                if (cbxThang.SelectedIndex >= 0)
                {
                    conditions.Add("Thang = @Thang");
                    parameters.Add(new SqlParameter("@Thang", int.Parse(cbxThang.SelectedItem.ToString())));
                }

                if (cbxNam.SelectedIndex > 0)
                {
                    conditions.Add("Nam = @Nam");
                    parameters.Add(new SqlParameter("@Nam", int.Parse(cbxNam.SelectedItem.ToString())));
                }

                string query = "SELECT * FROM Luong";

                if (conditions.Count > 0)
                {
                    query += " WHERE " + string.Join(" AND ", conditions);
                }

                DataTable dt = db.ExecuteQuery(query, parameters.ToArray());
                dgvTinhLuong.DataSource = dt;

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
        private void dgvTinhLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnThem.Enabled = false;
            btnTimKiem.Enabled = false;

            Admin(isAdmin);

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTinhLuong.Rows[e.RowIndex];

                txtMaLuong.Text = row.Cells["MaLuong"].Value?.ToString();

                cbxGiaoVien.SelectedValue = row.Cells["MaGV"].Value?.ToString();

                cbxThang.SelectedItem = Convert.ToInt32(row.Cells["Thang"].Value);

                cbxNam.SelectedValue = Convert.ToInt32(row.Cells["Nam"].Value);

                txtHeSoLuong.Text = row.Cells["HeSoLuong"].Value?.ToString();
                txtMucLuongCoSo.Text = row.Cells["MucLuongCoSo"].Value?.ToString();
                txtTongPhuCap.Text = row.Cells["TongPhuCap"].Value?.ToString();
                txtTongLuong.Text = row.Cells["TongLuong"].Value?.ToString();
            }
        }
    }
}
