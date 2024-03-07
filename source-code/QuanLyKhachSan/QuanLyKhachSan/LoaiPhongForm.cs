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
    public partial class LoaiPhongForm : Form
    {
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtLoaiPhong = null;

        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;

        DBLoaiPhong dbLP;

        public LoaiPhongForm()
        {
            InitializeComponent();
            dbLP = new DBLoaiPhong();
        }

        void clearPanel()
        {
            // Xóa trống các đối tượng trong Panel
            txtMaLoaiPhong.ResetText();
            txtTenLoaiPhong.ResetText();
            txtGiaPhong.ResetText();
        }

        void LoadData()
        {
            try
            {
                // Vận chuyển dữ liệu lên DataTable dtLoaiPhong
                dtLoaiPhong = new DataTable();
                dtLoaiPhong.Clear();
                dtLoaiPhong = dbLP.LayLoaiPhong().Tables[0];

                // Đưa dữ liệu lên DataGridView 
                dgvLoaiPhong.DataSource = dtLoaiPhong;

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
                MessageBox.Show("Không lấy được dữ liệu trong table LoaiPhong",
                    "Lỗi lấy dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoaiPhongForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoaiPhongForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtLoaiPhong.Dispose();
            dtLoaiPhong = null;
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
                int r = dgvLoaiPhong.CurrentCell.RowIndex;
                // Lấy MaLoaiPhong của record hiện hành
                string strMaLoaiPhong = dgvLoaiPhong.Rows[r].Cells[0].Value.ToString();

                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc chắn muốn xóa loại phòng có mã " +
                    "[" + strMaLoaiPhong + "] không?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Yes không?
                if (traloi == DialogResult.Yes)
                {
                    string err = "";
                    bool f = dbLP.XoaLoaiPhong(ref err, strMaLoaiPhong);
                    if (f)
                    {
                        // Cập nhật lại DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã xóa thành công loại phòng có mã " +
                            "[" + strMaLoaiPhong + "]", "Xóa loại phòng",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại phòng không thành công!\n\r" +
                            "Lỗi:" + err,
                            "Lỗi xóa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xóa loại phòng không thành công",
                    "Lỗi xóa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;

            // Xóa trống các đối tượng trong Panel
            clearPanel();

            // Cho phép thay đổi txtMaLoaiPhong
            txtMaLoaiPhong.Enabled = true;
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;

            // Đưa con trỏ đến TextField txtMaLoaiPhong
            txtMaLoaiPhong.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;

            // Cho phép thao tác trên Panel
            panel.Enabled = true;
            // Không cho phép thay đổi txtMaLoaiPhong
            txtMaLoaiPhong.Enabled = false;

            // Thứ tự dòng hiện hành
            int r = dgvLoaiPhong.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            txtMaLoaiPhong.Text = dgvLoaiPhong.Rows[r].Cells[0].Value.ToString();
            txtTenLoaiPhong.Text = dgvLoaiPhong.Rows[r].Cells[1].Value.ToString();

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;

            // Đưa con trỏ đến TextField txtMaLoaiPhong 
            txtMaLoaiPhong.Focus();
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
                    // Mã loại phòng được thêm
                    string strMaLoaiPhong = txtMaLoaiPhong.Text.ToString();

                    f = dbLP.ThemLoaiPhong(ref err,
                        txtMaLoaiPhong.Text,
                        txtTenLoaiPhong.Text,
                        txtGiaPhong.Text);
                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã thêm thành công loại phòng có mã " +
                            "[" + strMaLoaiPhong + "]", "Thêm loại phòng",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm loại phòng không thành công!\n\r" + 
                            "Lỗi:" + err,
                            "Lỗi thêm loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Thêm loại phòng không thành công",
                        "Lỗi thêm loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Sửa dữ liệu
            if (!Them)
            {
                string err = "";
                try
                {
                    // Thứ tự dòng hiện hành
                    int r = dgvLoaiPhong.CurrentCell.RowIndex;
                    // MaLoaiPhong hiện hành
                    string strMaLoaiPhong = dgvLoaiPhong.Rows[r].Cells[0].Value.ToString();

                    f = dbLP.CapNhatLoaiPhong(ref err,
                        txtMaLoaiPhong.Text,
                        txtTenLoaiPhong.Text,
                        txtGiaPhong.Text);
                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã sửa thành công loại phòng có mã " +
                            "[" + strMaLoaiPhong + "]", "Sửa loại phòng",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa loại phòng không thành công!\n\r" + 
                            "Lỗi:" + err,
                            "Lỗi sửa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                catch (SqlException)
                {
                    MessageBox.Show("Sửa loại phòng không thành công",
                        "Lỗi sửa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
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

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLoaiPhong.CurrentCell != null)
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
                int r = dgvLoaiPhong.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                txtMaLoaiPhong.Text = dgvLoaiPhong.Rows[r].Cells[0].Value.ToString();
                txtTenLoaiPhong.Text = dgvLoaiPhong.Rows[r].Cells[1].Value.ToString();
                txtGiaPhong.Text = dgvLoaiPhong.Rows[r].Cells[2].Value.ToString();
            }
        }
    }
}
