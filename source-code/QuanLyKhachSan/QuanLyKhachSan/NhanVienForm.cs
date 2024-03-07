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
    public partial class NhanVienForm : Form
    {
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtNhanVien = null;

        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;

        DBNhanVien dbNV;

        public NhanVienForm()
        {
            InitializeComponent();
            dbNV = new DBNhanVien();
        }

        void clearPanel()
        {
            // Xóa trống các đối tượng trong Panel
            txtMaNhanVien.ResetText();
            txtTenNhanVien.ResetText();
            txtCCCD.ResetText();
            txtNgaySinh.ResetText();
            cbGioiTinh.SelectedIndex = -1;
            txtDienThoai.ResetText();
        }

        void LoadData()
        {
            try
            {
                // Vận chuyển dữ liệu lên DataTable dtNhanVien
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                dtNhanVien = dbNV.LayNhanVien().Tables[0];

                // Đưa dữ liệu lên DataGridView 
                dgvNhanVien.DataSource = dtNhanVien;

                // Xóa trống các đối tượng trong Panel
                clearPanel();
                // Không cho thao tác trên các nút Sửa / Lưu / Hủy / Xóa và panel
                btnSua.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnXoa.Enabled = false;
                panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Thoát / Lọc
                btnThem.Enabled = true;
                btnThoat.Enabled = true;
                btnLoc.Enabled = true;
                // Ẩn nút OK
                btnOK.Visible = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu trong table NhanVien", 
                    "Lỗi lấy dữ liệu",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void NhanVienForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtNhanVien.Dispose();
            dtNhanVien = null;
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
            if (cbGioiTinh.Items.Contains("ALL"))
            {
                cbGioiTinh.Items.Remove("ALL");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành
                int r = dgvNhanVien.CurrentCell.RowIndex;
                // Lấy MaNhanVien của record hiện hành
                string strMaNhanVien = dgvNhanVien.Rows[r].Cells[0].Value.ToString();

                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc chắn muốn xóa nhân viên có mã " +
                    "[" + strMaNhanVien + "] không?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Yes không?
                if (traloi == DialogResult.Yes)
                {
                    string err = "";
                    bool f = dbNV.XoaNhanVien(ref err, strMaNhanVien);
                    if (f)
                    {
                        // Cập nhật lại DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã xóa thành công nhân viên có mã " +
                            "[" + strMaNhanVien + "]", "Xóa nhân viên",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên không thành công!\n\r" + 
                            "Lỗi:" + err,
                            "Lỗi xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xóa nhân viên không thành công", 
                    "Lỗi xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;

            // Xóa trống các đối tượng trong Panel
            clearPanel();

            // Cho phép thay đổi txtMaNhanVien
            txtMaNhanVien.Enabled = true;
            // Cho thao tác trên các nút Lưu / Hủy / Panel / Lọc
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panel.Enabled = true;
            btnLoc.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;

            // Đưa con trỏ đến TextField txtMaNhanVien
            txtMaNhanVien.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;

            // Cho phép thao tác trên Panel
            panel.Enabled = true;
            // Không cho phép thay đổi txtMaNhanVien
            txtMaNhanVien.Enabled = false;

            // Thứ tự dòng hiện hành
            int r = dgvNhanVien.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            txtMaNhanVien.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            txtTenNhanVien.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            txtCCCD.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            txtNgaySinh.Text = ((DateTime)dgvNhanVien.Rows[r].Cells[3].Value).ToString("yyyy-MM-dd");
            cbGioiTinh.Text = dgvNhanVien.Rows[r].Cells[4].Value.ToString();
            txtDienThoai.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;

            // Đưa con trỏ đến TextField txtMaNhanVien 
            txtMaNhanVien.Focus();
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
                    // Mã nhân viên được thêm
                    string strMaNhanVien = txtMaNhanVien.Text.ToString();
                    
                    // Thêm nhân viên
                    f = dbNV.ThemNhanVien(ref err, 
                        txtMaNhanVien.Text,
                        txtTenNhanVien.Text,
                        txtCCCD.Text,
                        txtNgaySinh.Text,
                        cbGioiTinh.Text,
                        txtDienThoai.Text);
                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã thêm thành công nhân viên có mã " +
                            "[" + strMaNhanVien + "]", "Thêm nhân viên",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên không thành công!\n\r" + 
                            "Lỗi:" + err,
                            "Lỗi thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Thêm nhân viên không thành công!\n\r" + "Lỗi:" + err, 
                        "Lỗi thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Sửa dữ liệu
            if (!Them)
            {
                string err = "";
                try
                {
                    // Thứ tự dòng hiện hành
                    int r = dgvNhanVien.CurrentCell.RowIndex;
                    // MaNhanVien hiện hành
                    string strMaNhanVien = dgvNhanVien.Rows[r].Cells[0].Value.ToString();

                    // Cập nhật nhân viên
                    f = dbNV.CapNhatNhanVien(ref err,
                        txtMaNhanVien.Text,
                        txtTenNhanVien.Text,
                        txtCCCD.Text,
                        txtNgaySinh.Text,
                        cbGioiTinh.Text,
                        txtDienThoai.Text);
                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã sửa thành công nhân viên có mã " +
                            "[" + strMaNhanVien + "]", "Sửa nhân viên",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa nhân viên không thành công!\n\r" + 
                            "Lỗi:" + err,
                            "Lỗi sửa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Sửa nhân viên không thành công!\n\r" + "Lỗi:" + err, 
                        "Lỗi sửa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Không cho thao tác trên các nút Sửa / Lưu / Hủy / Xóa và panel
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnXoa.Enabled = false;
            panel.Enabled = false;
            // Cho thao tác trên các nút Thêm / Thoát / Lọc
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
            btnLoc.Enabled = true;

            // Xóa trống các đối tượng trong Panel
            clearPanel();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.CurrentCell != null)
            {
                if (cbGioiTinh.Items.Contains("ALL"))
                {
                    cbGioiTinh.Items.Remove("ALL");
                    btnOK.Visible = false;
                }
                // Không cho thao tác trên nút Lưu / Hủy và panel
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát / Lọc
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThoat.Enabled = true;
                btnLoc.Enabled = true;

                // Thứ tự dòng hiện hành
                int r = dgvNhanVien.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                txtMaNhanVien.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
                txtTenNhanVien.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
                txtCCCD.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
                txtNgaySinh.Text = ((DateTime)dgvNhanVien.Rows[r].Cells[3].Value).ToString("yyyy-MM-dd");
                cbGioiTinh.Text = dgvNhanVien.Rows[r].Cells[4].Value.ToString();
                txtDienThoai.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            clearPanel();

            // Cho phép thay đổi txtMaNhanVien
            txtMaNhanVien.Enabled = true;
            // Cho thao tác trên Panel
            panel.Enabled = true;
            // Hiển thị nút OK
            btnOK.Visible = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Lưu / Thoát / Lọc / Hủy / OK
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnThoat.Enabled = false;
            btnLoc.Enabled = false;
            btnHuy.Enabled = false;
            btnOK.Enabled = false;

            // Thêm lựa chọn ALL vào cbGioiTinh
            cbGioiTinh.Items.Add("ALL");
        }

        void locNhanVien()
        {
            string strMaNhanVien = txtMaNhanVien.Text;
            string strTenNhanVien = txtTenNhanVien.Text;
            string strCCCD = txtCCCD.Text;
            string strNgaySinh = txtNgaySinh.Text;
            string strGioiTinh = cbGioiTinh.Text;
            if (cbGioiTinh.Text == "ALL")
                strGioiTinh = "";
            string strDienThoai = txtDienThoai.Text; 

            // Vận chuyển dữ liệu lên DataTable dtNhanVien
            dtNhanVien = new DataTable();
            dtNhanVien.Clear();
            dtNhanVien = dbNV.LocNhanVien(
                strMaNhanVien,
                strTenNhanVien,
                strCCCD,
                strNgaySinh,
                strGioiTinh,
                strDienThoai).Tables[0];
            // Đưa dữ liệu lên DataGridView 
            dgvNhanVien.DataSource = dtNhanVien;
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (btnLoc.Enabled == false)
                locNhanVien();
        }

        private void txtTenNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (btnLoc.Enabled == false)
                locNhanVien();
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            if (btnLoc.Enabled == false)
                locNhanVien();
        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {
            // Nếu nút OK đang tắt thì bật lên
            if (btnOK.Enabled == false)
                btnOK.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(txtNgaySinh.Text, out _) && txtNgaySinh.Text != "")
            {
                txtNgaySinh.Text = "";
                MessageBox.Show("Ngày sinh không hợp lệ!\n\r" +
                    "Vui lòng nhập lại với định dạng yyyy-MM-dd",
                    "Lỗi định dạng ngày sinh",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                locNhanVien();

            // Không cho thao tác trên nút OK
            btnOK.Enabled = false;
        }

        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnLoc.Enabled == false)
                locNhanVien();
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (btnLoc.Enabled == false)
                locNhanVien();
        }
    }
}
