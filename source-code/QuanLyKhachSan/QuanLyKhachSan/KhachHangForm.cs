using BALayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class KhachHangForm : Form
    {
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtKhachHang = null;

        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtThanhPho = null;

        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;

        DBKhachHang dbKH;
        DBThanhPho dbTP;

        public KhachHangForm()
        {
            InitializeComponent();
            dbKH = new DBKhachHang();
            dbTP = new DBThanhPho();
        }

        void clearPanel()
        {
            // Xóa trống các đối tượng trong Panel
            txtMaKhachHang.ResetText();
            txtTenKhachHang.ResetText();
            txtCCCD.ResetText();
            txtNgaySinh.ResetText();
            cbGioiTinh.SelectedIndex = -1;
            txtDienThoai.ResetText();
            cbThanhPho.SelectedIndex = -1;
        }

        void LoadData()
        {
            try
            {
                // Vận chuyển dữ liệu vào DataTable dtThanhPho
                dtThanhPho = new DataTable();
                dtThanhPho.Clear();
                dtThanhPho = dbTP.LayThanhPho().Tables[0];
                // Đưa dữ liệu lên ComboBox trong DataGridView 
                MaThanhPho.DataSource = dtThanhPho;
                MaThanhPho.DisplayMember = "TenThanhPho";
                MaThanhPho.ValueMember = "MaThanhPho";

                // Vận chuyển dữ liệu lên DataTable dtKhachHang
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                dtKhachHang = dbKH.LayKhachHang().Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvKhachHang.DataSource = dtKhachHang;

                // Xóa trống các đối tượng trong Panel
                clearPanel();

                // Không cho thao tác trên các nút Sửa / Lưu / Hủy / Xóa
                btnSua.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnXoa.Enabled = false;
                panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Thoát / Lọc
                btnThem.Enabled = true;
                btnThoat.Enabled = true;
                btnLoc.Enabled = true;
                // Ẩn nút OK và RS
                btnOK.Visible = false;  
                btnRS.Visible = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu trong table KhachHang",
                    "Lỗi lấy dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void KhachHangForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtKhachHang.Dispose();
            dtKhachHang = null;
            dtThanhPho.Dispose();
            dtKhachHang = null;
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
                int r = dgvKhachHang.CurrentCell.RowIndex;
                // Lấy MaKhachHang của record hiện hành
                string strMaKhachHang = dgvKhachHang.Rows[r].Cells[0].Value.ToString();

                string err = "";
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc chắn muốn xóa khách hàng có mã " +
                    "[" + strMaKhachHang + "] không?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Yes không?
                if (traloi == DialogResult.Yes)
                {
                    bool f = dbKH.XoaKhachHang(ref err,
                        strMaKhachHang);
                    if (f)
                    {
                        // Cập nhật lại DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã xóa thành công khách hàng có mã " +
                            "[" + strMaKhachHang + "]", "Xóa khách hàng",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng không thành công!\n\r" +
                            "Lỗi:" + err,
                            "Lỗi xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xóa khách hàng không thành công",
                    "Lỗi xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;

            // Xóa trống các đối tượng trong Panel
            clearPanel();

            // Cho phép thay đổi txtMaKhachHang
            txtMaKhachHang.Enabled = true;
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

            // Đưa dữ liệu lên ComboBox
            cbThanhPho.DataSource = dtThanhPho;
            cbThanhPho.DisplayMember = "TenThanhPho";
            cbThanhPho.ValueMember = "MaThanhPho";
            cbThanhPho.SelectedIndex = -1;

            // Đưa con trỏ đến TextField txtMaKhachHang
            txtMaKhachHang.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Đưa dữ liệu lên ComboBox
            cbThanhPho.DataSource = dtThanhPho;
            cbThanhPho.DisplayMember = "TenThanhPho";
            cbThanhPho.ValueMember = "MaThanhPho";

            // Kích hoạt biến Sửa
            Them = false;

            // Cho phép thao tác trên Panel
            panel.Enabled = true;
            // Không cho phép thay đổi txtMaKhachHang
            txtMaKhachHang.Enabled = false;

            // Thứ tự dòng hiện hành
            int r = dgvKhachHang.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            txtMaKhachHang.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            txtTenKhachHang.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            txtCCCD.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            txtNgaySinh.Text = ((DateTime)dgvKhachHang.Rows[r].Cells[3].Value).ToString("yyyy-MM-dd");
            cbGioiTinh.Text = dgvKhachHang.Rows[r].Cells[4].Value.ToString();
            txtDienThoai.Text = dgvKhachHang.Rows[r].Cells[5].Value.ToString();
            cbThanhPho.SelectedValue = dgvKhachHang.Rows[r].Cells[6].Value.ToString();
            
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKhachHang 
            txtMaKhachHang.Focus();
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
                    // Mã khách hàng được thêm
                    string strMaKhachHang = txtMaKhachHang.Text.ToString();

                    f = dbKH.ThemKhachHang(ref err,
                        txtMaKhachHang.Text,
                        txtTenKhachHang.Text,
                        txtCCCD.Text,
                        txtNgaySinh.Text,
                        cbGioiTinh.Text,
                        txtDienThoai.Text,
                        cbThanhPho.SelectedValue.ToString());
                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã thêm thành công khách hàng có mã " +
                            "[" + strMaKhachHang + "]", "Thêm khách hàng",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng không thành công!\n\r" +
                            "Lỗi:" + err,
                            "Lỗi thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Thêm khách hàng không thành công",
                        "Lỗi thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Sửa thông tin
            if (!Them)
            {
                string err = "";
                try
                {
                    // Thứ tự dòng hiện hành
                    int r = dgvKhachHang.CurrentCell.RowIndex;
                    // MaKhachHang hiện hành
                    string strMaKhachHang = dgvKhachHang.Rows[r].Cells[0].Value.ToString();

                    f = dbKH.CapNhatKhachHang(ref err,
                        txtMaKhachHang.Text,
                        txtTenKhachHang.Text,
                        txtCCCD.Text,
                        txtNgaySinh.Text,
                        cbGioiTinh.Text,
                        txtDienThoai.Text,
                        cbThanhPho.SelectedValue.ToString());
                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã sửa thành công khách hàng có mã " +
                            "[" + strMaKhachHang + "]", "Sửa khách hàng",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa khách hàng không thành công!\n\r" +
                            "Lỗi:" + err,
                            "Lỗi sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }        
                }
                catch (SqlException)
                {
                    MessageBox.Show("Sửa khách hàng không thành công",
                        "Lỗi sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Không cho thao tác trên các nút Sửa / Lưu / Hủy / Xóa
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

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhachHang.CurrentCell != null)
            {
                if (cbGioiTinh.Items.Contains("ALL"))
                {
                    cbGioiTinh.Items.Remove("ALL");
                    btnOK.Visible = false;
                    btnRS.Visible = false;
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

                // Đưa dữ liệu lên ComboBox
                cbThanhPho.DataSource = dtThanhPho;
                cbThanhPho.DisplayMember = "TenThanhPho";
                cbThanhPho.ValueMember = "MaThanhPho";

                // Thứ tự dòng hiện hành
                int r = dgvKhachHang.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                txtMaKhachHang.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
                txtTenKhachHang.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString();
                txtCCCD.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
                txtNgaySinh.Text = ((DateTime)dgvKhachHang.Rows[r].Cells[3].Value).ToString("yyyy-MM-dd");
                cbGioiTinh.Text = dgvKhachHang.Rows[r].Cells[4].Value.ToString();
                txtDienThoai.Text = dgvKhachHang.Rows[r].Cells[5].Value.ToString();
                cbThanhPho.SelectedValue = dgvKhachHang.Rows[r].Cells[6].Value.ToString();
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            // Đưa dữ liệu lên ComboBox
            cbThanhPho.DataSource = dtThanhPho;
            cbThanhPho.DisplayMember = "TenThanhPho";
            cbThanhPho.ValueMember = "MaThanhPho";

            // Xóa trống các đối tượng trong Panel
            clearPanel();

            // Cho phép thay đổi txtMaKhachHang
            txtMaKhachHang.Enabled = true;
            // Cho thao tác trên Panel
            panel.Enabled = true;
            // Hiển thị nút OK và RS
            btnOK.Visible = true;
            btnRS.Visible = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Lưu / Thoát / Lọc / Hủy / OK / RS
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnThoat.Enabled = false;
            btnLoc.Enabled = false;
            btnHuy.Enabled = false;
            btnOK.Enabled = false;
            btnRS.Enabled = false;

            // Thêm lựa chọn ALL vào cbGioiTinh
            cbGioiTinh.Items.Add("ALL");
        }

        void locKhachHang()
        {
            string strMaKhachHang = txtMaKhachHang.Text;
            string strTenKhachHang = txtTenKhachHang.Text;
            string strCCCD = txtCCCD.Text;
            string strNgaySinh = txtNgaySinh.Text;
            string strGioiTinh = cbGioiTinh.Text;
            if (cbGioiTinh.Text == "ALL")
                strGioiTinh = "";
            string strDienThoai = txtDienThoai.Text;
            string strMaThanhPho = "";
            if (cbThanhPho.SelectedValue != null)
                strMaThanhPho = cbThanhPho.SelectedValue.ToString();

            // Vận chuyển dữ liệu lên DataTable dtKhachHang
            dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            dtKhachHang = dbKH.LocKhachHang(
                strMaKhachHang,
                strTenKhachHang,
                strCCCD,
                strNgaySinh,
                strGioiTinh,
                strDienThoai,
                strMaThanhPho).Tables[0];
            // Đưa dữ liệu lên DataGridView 
            dgvKhachHang.DataSource = dtKhachHang;
        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (btnLoc.Enabled == false)
                locKhachHang();
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (btnLoc.Enabled == false)
                locKhachHang();
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            if (btnLoc.Enabled == false)
                locKhachHang();
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
                locKhachHang();

            // Không cho thao tác trên nút OK
            btnOK.Enabled = false;
        }

        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnLoc.Enabled == false)
                locKhachHang();
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (btnLoc.Enabled == false)
                locKhachHang();
        }

        private void cbThanhPho_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nếu nút RS đang tắt thì bật lên
            if (btnRS.Enabled == false)
                btnRS.Enabled = true;

            if (btnLoc.Enabled == false)
                locKhachHang();
        }

        private void btnRS_Click(object sender, EventArgs e)
        {
            cbThanhPho.SelectedIndex = -1;
            btnRS.Enabled = false;
        }
    }
}
