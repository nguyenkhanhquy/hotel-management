using BALayer;
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

namespace QuanLyKhachSan
{
    public partial class ThanhPhoForm : Form
    {
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtThanhPho = null;

        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;

        DBThanhPho dbTP;

        public ThanhPhoForm()
        {
            InitializeComponent();
            dbTP = new DBThanhPho();
        }

        void clearPanel()
        {
            // Xóa trống các đối tượng trong Panel
            txtMaThanhPho.ResetText();
            txtTenThanhPho.ResetText();
        }

        void LoadData()
        {
            try
            {
                // Vận chuyển dữ liệu lên DataTable dtThanhPho
                dtThanhPho = new DataTable();
                dtThanhPho.Clear();
                dtThanhPho = dbTP.LayThanhPho().Tables[0];

                // Đưa dữ liệu lên DataGridView 
                dgvThanhPho.DataSource = dtThanhPho;

                // Xóa trống các đối tượng trong Panel
                clearPanel();

                // Không cho thao tác trên các nút Sửa / Lưu / Hủy / Xóa
                btnSua.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnXoa.Enabled = false;
                panel.Enabled = false;

                // Cho thao tác trên các nút Thêm / Thoát
                btnThem.Enabled = true;
                btnThoat.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu trong table ThanhPho",
                    "Lỗi lấy dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThanhPhoForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ThanhPhoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtThanhPho.Dispose();
            dtThanhPho = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc chắn muốn thoát không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Yes không?
            if (traloi == DialogResult.Yes) Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành
                int r = dgvThanhPho.CurrentCell.RowIndex;
                // Lấy MaThanhPho của record hiện hành
                string strMaThanhPho = dgvThanhPho.Rows[r].Cells[0].Value.ToString();

                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc chắn muốn xóa thành phố có mã " +
                    "[" + strMaThanhPho + "] không?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra có nhắp chọn nút Yes không?
                if (traloi == DialogResult.Yes)
                {
                    string err = "";
                    bool f = dbTP.XoaThanhPho(ref err, strMaThanhPho);
                    if (f)
                    {
                        // Cập nhật lại DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã xóa thành công thành phố có mã " +
                            "[" + strMaThanhPho + "]", "Xóa thành phố",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thành phố không thành công!\n\r" +
                            "Lỗi:" + err,
                            "Lỗi xóa thành phố", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xóa thành phố không thành công",
                    "Lỗi xóa thành phố", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Them
            Them = true;

            // Xóa trống các đối tượng trong Panel
            clearPanel();

            // Cho phép thay đổi txtMaThanhPho
            txtMaThanhPho.Enabled = true;

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panel.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;

            // Đưa con trỏ đến TextField txtMaThanhPho
            txtMaThanhPho.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;

            // Cho phép thao tác trên Panel
            panel.Enabled = true;

            // Không cho phép thay đổi txtMaThanhPho
            txtMaThanhPho.Enabled = false;

            // Thứ tự dòng hiện hành
            int r = dgvThanhPho.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            txtMaThanhPho.Text = dgvThanhPho.Rows[r].Cells[0].Value.ToString();
            txtTenThanhPho.Text = dgvThanhPho.Rows[r].Cells[1].Value.ToString();

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panel.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;

            // Đưa con trỏ đến TextField txtMaThanhPho 
            txtMaThanhPho.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool f = false;
            // Thêm dữ liệu
            if (Them)
            {
                string err = "";
                try
                {
                    // Mã thành phố được thêm
                    string strMaThanhPho = txtMaThanhPho.Text.ToString();

                    f = dbTP.ThemThanhPho(ref err,
                        txtMaThanhPho.Text,
                        txtTenThanhPho.Text);
                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã thêm thành công thành phố có mã " +
                            "[" + strMaThanhPho + "]", "Thêm thành phố",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành phố không thành công!\n\r" +
                            "Lỗi:" + err,
                            "Lỗi thêm thành phố", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                catch (SqlException)
                {
                    MessageBox.Show("Thêm thành phố không thành công",
                        "Lỗi thêm thành phố", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Sửa thông tin
            if (!Them)
            {
                string err = "";
                try
                {
                    // Thứ tự dòng hiện hành
                    int r = dgvThanhPho.CurrentCell.RowIndex;
                    // MaThanhPho hiện hành
                    string strMaThanhPho = dgvThanhPho.Rows[r].Cells[0].Value.ToString();

                    f = dbTP.CapNhatThanhPho(ref err,
                        txtMaThanhPho.Text,
                        txtTenThanhPho.Text);
                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã sửa thành công thành phố có mã " +
                            "[" + strMaThanhPho + "]", "Sửa thành phố",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thành phố không thành công!\n\r" +
                            "Lỗi:" + err,
                            "Lỗi sửa thành phố", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                catch (SqlException)
                {
                    MessageBox.Show("Sửa thành phố không thành công",
                        "Lỗi sửa thành phố", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            clearPanel();

            // Không cho thao tác trên các nút Sửa / Lưu / Hủy / Xóa và panel
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnXoa.Enabled = false;
            panel.Enabled = false;

            // Cho thao tác trên các nút Thêm / Thoát
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void dgvThanhPho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvThanhPho.CurrentCell != null)
            {
                // Không cho thao tác trên nút Lưu / Hủy và panel
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                panel.Enabled = false;

                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThoat.Enabled = true;

                // Thứ tự dòng hiện hành
                int r = dgvThanhPho.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                txtMaThanhPho.Text = dgvThanhPho.Rows[r].Cells[0].Value.ToString();
                txtTenThanhPho.Text = dgvThanhPho.Rows[r].Cells[1].Value.ToString();
            }
        }
    }
}
