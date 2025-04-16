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
    public partial class frmQuanLyMonHoc : Form
    {
        public frmQuanLyMonHoc()
        {
            InitializeComponent();
            LoadDanhSachMonHoc();
            SetTextBoxesReadOnly(true);
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }

        private bool isAdding = false;

        // Load danh sách môn học khi mở form
        private void LoadDanhSachMonHoc()
        {
            string query = "SELECT MaMonHoc, TenMonHoc FROM MonHoc ORDER BY MaMonHoc ASC";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvMonHoc.DataSource = dt;
        }

        // Khoá textbox
        private void SetTextBoxesReadOnly(bool state)
        {
            txtMonHoc.ReadOnly = state;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            SetTextBoxesReadOnly(false);
            txtMonHoc.Clear();
            txtMonHoc.Focus();
            btnLuu.Enabled = true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            isAdding = false;
            txtMonHoc.ReadOnly = false;
            txtMonHoc.Focus();
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenMonHoc = txtMonHoc.Text.Trim();

            if (string.IsNullOrEmpty(tenMonHoc))
            {
                MessageBox.Show("Vui lòng nhập tên môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isAdding)
            {
                string query = "INSERT INTO MonHoc (TenMonHoc) VALUES (@TenMonHoc)";
                SqlParameter[] parameters = { new SqlParameter("@TenMonHoc", tenMonHoc) };

                if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
                {
                    MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachMonHoc();
                }
            }
            else
            {
                string maMonHoc = dgvMonHoc.SelectedRows[0].Cells["MaMonHoc"].Value.ToString();
                string oldTenMonHoc = dgvMonHoc.SelectedRows[0].Cells["TenMonHoc"].Value.ToString();

                DialogResult result = MessageBox.Show(
                $"MMH: '{maMonHoc}'. Bạn có muốn sửa '{oldTenMonHoc}' thành '{tenMonHoc}' không?",
                "Xác nhận sửa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    string query = "UPDATE MonHoc SET TenMonHoc = @TenMonHoc WHERE MaMonHoc = @MaMonHoc";
                    SqlParameter[] parameters =
                    {
                    new SqlParameter("@TenMonHoc", tenMonHoc),
                    new SqlParameter("@MaMonHoc", maMonHoc)
                };

                    if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
                    {
                        MessageBox.Show("Cập nhật môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachMonHoc();
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.SelectedRows.Count > 0)
            {
                string maMonHoc = dgvMonHoc.SelectedRows[0].Cells["MaMonHoc"].Value.ToString();
                string tenMonHoc = dgvMonHoc.SelectedRows[0].Cells["TenMonHoc"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa môn học '{tenMonHoc}' không?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM MonHoc WHERE MaMonHoc = @MaMonHoc";
                    SqlParameter[] parameters = { new SqlParameter("@MaMonHoc", maMonHoc) };

                    if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
                    {
                        MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachMonHoc();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa môn học. Vui lòng kiểm tra ràng buộc dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachMonHoc();
            txtMonHoc.Clear();
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            SetTextBoxesReadOnly(true);
        }

        private void dgvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dgvMonHoc.Rows[e.RowIndex];

            //    txtMonHoc.Text = row.Cells["TenMonHoc"].Value.ToString();
            //}
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMonHoc.Rows[e.RowIndex];

                if (row.Cells["TenMonHoc"].Value != null) // Kiểm tra tránh lỗi null
                {
                    txtMonHoc.Text = row.Cells["TenMonHoc"].Value.ToString();
                }

                // Hiện nút
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                // Ẩn nút
                btnThem.Enabled = false;
                btnLuu.Enabled = false;
                //
                SetTextBoxesReadOnly(true);
            }
        }
    }
}
