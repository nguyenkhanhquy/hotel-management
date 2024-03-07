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
    public partial class PhongForm : Form
    {
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtPhong = null;

        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtLoaiPhong = null;

        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;

        DBPhong dbP;
        DBLoaiPhong dbLP;

        public PhongForm()
        {
            InitializeComponent();
            dbP = new DBPhong();
            dbLP = new DBLoaiPhong();
        }

        void clearPanel()
        {
            // Xóa trống các đối tượng trong Panel
            txtMaPhong.ResetText();
            cbLoaiPhong.SelectedIndex = -1;
            txtSoPhong.ResetText();
            txtSoLuongNguoi.ResetText();
        }

        void LoadData()
        {
            try
            {
                // Vận chuyển dữ liệu vào DataTable dtLoaiPhong
                dtLoaiPhong = new DataTable();
                dtLoaiPhong.Clear();
                dtLoaiPhong = dbLP.LayLoaiPhong().Tables[0];
                // Đưa dữ liệu lên ComboBox trong DataGridView 
                MaLoaiPhong.DataSource = dtLoaiPhong;
                MaLoaiPhong.DisplayMember = "TenLoaiPhong";
                MaLoaiPhong.ValueMember = "MaLoaiPhong";

                // Vận chuyển dữ liệu lên DataTable dtPhong
                dtPhong = new DataTable();
                dtPhong.Clear();
                dtPhong = dbP.LayPhong().Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvPhong.DataSource = dtPhong;

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
                MessageBox.Show("Không lấy được dữ liệu trong table Phong",
                    "Lỗi lấy dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PhongForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void PhongForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtPhong.Dispose();
            dtPhong = null;
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
                int r = dgvPhong.CurrentCell.RowIndex;
                // Lấy MaPhong của record hiện hành
                string strMaPhong = dgvPhong.Rows[r].Cells[0].Value.ToString();

                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc chắn muốn xóa phòng có mã " +
                    "[" + strMaPhong + "] không?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Yes không?
                if (traloi == DialogResult.Yes)
                {
                    string err = "";
                    bool f = dbP.XoaPhong(ref err,
                        strMaPhong);
                    if (f)
                    {
                        // Cập nhật lại DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã xóa thành công phòng có mã " +
                            "[" + strMaPhong + "]", "Xóa phòng",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa phòng không thành công!\n\r" +
                            "Lỗi:" + err,
                            "Lỗi xóa phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xóa phòng không thành công",
                    "Lỗi xóa phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;

            // Xóa trống các đối tượng trong Panel
            clearPanel();

            // Cho phép thay đổi txtMaPhong
            txtMaPhong.Enabled = true;
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;

            // Đưa dữ liệu lên ComboBox
            cbLoaiPhong.DataSource = dtLoaiPhong;
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbLoaiPhong.ValueMember = "MaLoaiPhong";
            cbLoaiPhong.SelectedIndex = -1;

            // Đưa con trỏ đến TextField txtMaPhong
            txtMaPhong.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;

            // Đưa dữ liệu lên ComboBox
            cbLoaiPhong.DataSource = dtLoaiPhong;
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbLoaiPhong.ValueMember = "MaLoaiPhong";

            // Cho phép thao tác trên Panel
            panel.Enabled = true;
            // Không cho phép thay đổi txtMaPhong
            txtMaPhong.Enabled = false;

            // Thứ tự dòng hiện hành
            int r = dgvPhong.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            txtMaPhong.Text = dgvPhong.Rows[r].Cells[0].Value.ToString();
            cbLoaiPhong.SelectedValue = dgvPhong.Rows[r].Cells[1].Value.ToString();
            txtSoPhong.Text = dgvPhong.Rows[r].Cells[2].Value.ToString();
            txtSoLuongNguoi.Text = dgvPhong.Rows[r].Cells[3].Value.ToString();
           
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;

            // Đưa con trỏ đến TextField txtMaPhong 
            txtMaPhong.Focus();
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
                    // Mã phòng được thêm
                    string strMaPhong = txtMaPhong.Text.ToString();

                    f = dbP.ThemPhong(ref err,
                        txtMaPhong.Text,
                        cbLoaiPhong.SelectedValue.ToString(),
                        txtSoPhong.Text,
                        txtSoLuongNguoi.Text, "1");
                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã thêm thành công phòng có mã " +
                            "[" + strMaPhong + "]", "Thêm phòng",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm phòng không thành công!\n\r" +
                            "Lỗi:" + err,
                            "Lỗi thêm phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Thêm phòng không thành công",
                        "Lỗi thêm phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Sửa thông tin
            if (!Them)
            {
                string err = "";
                try
                {
                    // Thứ tự dòng hiện hành
                    int r = dgvPhong.CurrentCell.RowIndex;
                    // MaPhong hiện hành
                    string strMaPhong = dgvPhong.Rows[r].Cells[0].Value.ToString();

                    f = dbP.CapNhatPhong(ref err,
                        strMaPhong,
                        cbLoaiPhong.SelectedValue.ToString(),
                        txtSoPhong.Text,
                        txtSoLuongNguoi.Text);
                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã sửa thành công phòng có mã " +
                            "[" + strMaPhong + "]", "Sửa phòng",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa phòng không thành công!\n\r" +
                            "Lỗi:" + err,
                            "Lỗi sửa phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Sửa phòng không thành công",
                        "Lỗi sửa phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPhong.CurrentCell != null)
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

                // Đưa dữ liệu lên ComboBox
                cbLoaiPhong.DataSource = dtLoaiPhong;
                cbLoaiPhong.DisplayMember = "TenLoaiPhong";
                cbLoaiPhong.ValueMember = "MaLoaiPhong";

                // Thứ tự dòng hiện hành
                int r = dgvPhong.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                txtMaPhong.Text = dgvPhong.Rows[r].Cells[0].Value.ToString();
                cbLoaiPhong.SelectedValue = dgvPhong.Rows[r].Cells[1].Value.ToString();
                txtSoPhong.Text = dgvPhong.Rows[r].Cells[2].Value.ToString();
                txtSoLuongNguoi.Text = dgvPhong.Rows[r].Cells[3].Value.ToString();

                // Lấy tình trạng phòng trống
                string ttpt = "";
                ttpt = dbP.LayTinhTrangPhongTrong(txtMaPhong.Text);

                // Kiểm tra tình trạng phòng trống
                if (ttpt == "True")
                {
                    //Cho thao tác trên các nút Sửa / Xóa
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
                else
                {
                    //Không cho thao tác trên nút Sửa / Xóa
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
            }
        }
    }
}
