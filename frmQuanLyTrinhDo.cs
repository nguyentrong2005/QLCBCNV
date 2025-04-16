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
    public partial class frmQuanLyTrinhDo : Form
    {
        public frmQuanLyTrinhDo()
        {
            InitializeComponent();
            LoadDanhSachTrinhDo();
            SetTextBoxesReadOnly(true);
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }

        private bool isAdding = false;

        // Load danh sách môn học khi mở form
        private void LoadDanhSachTrinhDo()
        {
            string query = "SELECT MaTrinhDo, TenTrinhDo FROM TrinhDo ORDER BY MaTrinhDo ASC";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvTrinhDo.DataSource = dt;
        }

        // Khoá textbox
        private void SetTextBoxesReadOnly(bool state)
        {
            txtTrinhDo.ReadOnly = state;
        }

        //private void btnThem_Click(object sender, EventArgs e)
        //{

        //}
        //private void btnSua_Click(object sender, EventArgs e)
        //{

        //}
        //private void btnLuu_Click(object sender, EventArgs e)
        //{

        //}
        //private void btnXoa_Click(object sender, EventArgs e)
        //{

        //}
        //private void btnLamMoi_Click(object sender, EventArgs e)
        //{

        //}
        private void dgvTrinhDo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTrinhDo.Rows[e.RowIndex];

                if (row.Cells["TenTrinhDo"].Value != null) // Kiểm tra tránh lỗi null
                {
                    txtTrinhDo.Text = row.Cells["TenTrinhDo"].Value.ToString();
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

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            isAdding = false;
            txtTrinhDo.ReadOnly = false;
            txtTrinhDo.Focus();
            btnLuu.Enabled = true;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            isAdding = true;
            SetTextBoxesReadOnly(false);
            txtTrinhDo.Clear();
            txtTrinhDo.Focus();
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvTrinhDo.SelectedRows.Count > 0)
            {
                string maTrinhDo = dgvTrinhDo.SelectedRows[0].Cells["MaTrinhDo"].Value.ToString();
                string tenTrinhDo = dgvTrinhDo.SelectedRows[0].Cells["TenTrinhDo"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa trình độ '{tenTrinhDo}' không?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM TrinhDo WHERE MaTrinhDo = @MaTrinhDo";
                    SqlParameter[] parameters = { new SqlParameter("@MaTrinhDo", maTrinhDo) };

                    if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
                    {
                        MessageBox.Show("Xóa trình độ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachTrinhDo();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa trình độ. Vui lòng kiểm tra ràng buộc dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string tenTrinhDo = txtTrinhDo.Text.Trim();

            if (string.IsNullOrEmpty(tenTrinhDo))
            {
                MessageBox.Show("Vui lòng nhập tên trình độ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isAdding)
            {
                string query = "INSERT INTO TrinhDo (TenTrinhDo) VALUES (@TenTrinhDo)";
                SqlParameter[] parameters = { new SqlParameter("@TenTrinhDo", tenTrinhDo) };

                if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
                {
                    MessageBox.Show("Thêm trình độ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachTrinhDo();
                }
            }
            else
            {
                string maTrinhDo = dgvTrinhDo.SelectedRows[0].Cells["MaTrinhDo"].Value.ToString();
                string oldTenTrinhDo = dgvTrinhDo.SelectedRows[0].Cells["TenTrinhDo"].Value.ToString();

                DialogResult result = MessageBox.Show(
                $"MMH: '{maTrinhDo}'. Bạn có muốn sửa '{oldTenTrinhDo}' thành '{tenTrinhDo}' không?",
                "Xác nhận sửa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    string query = "UPDATE TrinhDo SET TenTrinhDo = @TenTrinhDo WHERE MaTrinhDo = @MaTrinhDo";
                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@TenTrinhDo", tenTrinhDo),
                        new SqlParameter("@MaTrinhDo", maTrinhDo)
                    };

                    if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
                    {
                        MessageBox.Show("Cập nhật trình độ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachTrinhDo();
                    }
                }
            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            LoadDanhSachTrinhDo();
            txtTrinhDo.Clear();
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            SetTextBoxesReadOnly(true);
        }

        private void dgvTrinhDo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
