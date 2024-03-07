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
    public partial class ChiTietHopDongForm : Form
    {
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtChiTietHopDong = null;

        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtNhanVien = null;

        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtKhachHang = null;

        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;

        DBChiTietHopDong dbCTHD;
        DBNhanVien dbNV;
        DBKhachHang dbKH;
        DBPhong dbP;

        //Khai báo biến tổng tiền
        public static int intTongTien = 0;

        public ChiTietHopDongForm()
        {
            InitializeComponent();
            dbCTHD = new DBChiTietHopDong();
            dbNV = new DBNhanVien();
            dbKH = new DBKhachHang();
            dbP = new DBPhong();
        }

        void clearPanel()
        {
            // Xóa trống các đối tượng trong Panel
            txtMaHopDong.ResetText();
            cbNhanVien.SelectedIndex = -1;
            cbKhachHang.SelectedIndex = -1;
            txtNgayVao.ResetText();
            txtSoNgayThue.ResetText();
            txtSoLuongPhongThue.ResetText();
            txtTongTien.ResetText();//
        }

        void LoadData()
        {
            try
            {
                // Vận chuyển dữ liệu vào DataTable dtNhanVien
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                dtNhanVien = dbNV.LayNhanVien().Tables[0];
                // Đưa dữ liệu lên ComboBox trong DataGridView 
                MaNhanVien.DataSource = dtNhanVien;
                MaNhanVien.DisplayMember = "TenNhanVien";
                MaNhanVien.ValueMember = "MaNhanVien";

                // Vận chuyển dữ liệu vào DataTable dtNhanVien
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                dtKhachHang = dbKH.LayKhachHang().Tables[0];
                // Đưa dữ liệu lên ComboBox trong DataGridView 
                MaKhachHang.DataSource = dtKhachHang;
                MaKhachHang.DisplayMember = "TenKhachHang";
                MaKhachHang.ValueMember = "MaKhachHang";

                // Vận chuyển dữ liệu lên DataTable dtChiTietHopDong
                dtChiTietHopDong = new DataTable();
                dtChiTietHopDong.Clear();
                dtChiTietHopDong = dbCTHD.LayChiTietHopDong().Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvChiTietHopDong.DataSource = dtChiTietHopDong;

                // Xóa trống các đối tượng trong Panel
                clearPanel();

                // Không cho thao tác trên các nút Xem Phòng / Sửa / Lưu / Hủy
                btnXemPhong.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                panel.Enabled = false;

                // Cho thao tác trên các nút Thêm / Thoát
                btnThem.Enabled = true;
                btnThoat.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu trong table ChiTietHopDong",
                    "Lỗi lấy dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChiTietHopDongForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ChiTietHopDongForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtKhachHang.Dispose();
            dtKhachHang = null;
            dtNhanVien.Dispose();
            dtNhanVien = null;
            dtChiTietHopDong.Dispose();
            dtChiTietHopDong = null;
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
            intTongTien = 0;
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dbP.KiemTraTonTai() == "0")
            {
                MessageBox.Show("Hiện tại đã hết phòng!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                intTongTien = 0;
                // Kich hoạt biến Them
                Them = true;
                // Xóa trống các đối tượng trong Panel
                clearPanel();
                // Cho phép thay đổi txtMaHopDong
                txtMaHopDong.Enabled = true;
                // Cho thao tác trên các nút Lưu / Hủy / Panel
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                panel.Enabled = true;
                // Không cho thao tác trên các nút Xem Phòng / Thêm / Thoát
                btnXemPhong.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnThoat.Enabled = false;
                // Đưa dữ liệu lên ComboBox
                cbNhanVien.DataSource = dtNhanVien;
                cbNhanVien.DisplayMember = "MaNhanVien";
                cbNhanVien.ValueMember = "MaNhanVien";
                cbNhanVien.SelectedIndex = -1;

                cbKhachHang.DataSource = dtKhachHang;
                cbKhachHang.DisplayMember = "MaKhachHang";
                cbKhachHang.ValueMember = "MaKhachHang";
                cbKhachHang.SelectedIndex = -1;

                // Gán ngày tháng năm hiện tại vào txtNgayVao
                DateTime currentDate = DateTime.Now;
                string formattedDate = currentDate.ToString("yyyy-MM-dd");
                txtNgayVao.Text = formattedDate;

                // Đưa con trỏ đến TextField txtMaHopDong
                txtMaHopDong.Focus();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Cập nhật tổng tiền trước khi sửa
            int soNgayThue = int.Parse(txtSoNgayThue.Text.ToString());
            intTongTien = intTongTien / soNgayThue;

            // Đưa dữ liệu lên ComboBox
            cbNhanVien.DataSource = dtNhanVien;
            cbNhanVien.DisplayMember = "MaNhanVien";
            cbNhanVien.ValueMember = "MaNhanVien";

            cbKhachHang.DataSource = dtKhachHang;
            cbKhachHang.DisplayMember = "MaKhachHang";
            cbKhachHang.ValueMember = "MaKhachHang";
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            panel.Enabled = true;
            // Không cho phép thay đổi txtMaHopDong / cbNhanVien / cbKhachHang / nút Xem Phòng
            txtMaHopDong.Enabled = false;
            cbNhanVien.Enabled = false;
            cbKhachHang.Enabled = false;
            btnXemPhong.Enabled = false;
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Thoát
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnThoat.Enabled = false;
            // Đưa con trỏ đến TextField txtSoNgayThue 
            txtSoNgayThue.Focus();
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
                    // Mã hợp đồng được thêm
                    string strMaHopDong = txtMaHopDong.Text.ToString();

                    // Điều kiện về mã có trong hợp đồng
                    if (txtMaHopDong.Text == "" || 
                        cbNhanVien.SelectedIndex == -1 ||
                        cbKhachHang.SelectedIndex == -1)
                    {
                        MessageBox.Show(
                            "Các loại mã trong hợp đồng không được bỏ trống\n" +
                            "Vui lòng nhập lại hoặc chọn lại!",
                            "Điều kiện về mã có trong hợp đồng",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Điều kiện số ngày thuê phải là số lớn hơn 0
                        int soNgayThue = 0;
                        int.TryParse(txtSoNgayThue.Text.ToString(), out soNgayThue);
                        if (soNgayThue < 1)
                        {
                            MessageBox.Show(
                                "Số ngày thuê phải là số nguyên lớn hơn 0\n" +
                                "Vui lòng nhập lại!",
                                "Điều kiện số ngày thuê",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtSoNgayThue.ResetText();
                            txtSoNgayThue.Focus();
                        }
                        else
                        {
                            f = dbCTHD.ThemChiTietHopDong(ref err,
                            txtMaHopDong.Text,
                            cbNhanVien.SelectedValue.ToString(),
                            cbKhachHang.SelectedValue.ToString(),
                            txtNgayVao.Text,
                            txtSoNgayThue.Text, "0", "0", "0");
                            if (f)
                            {
                                // Thông báo
                                MessageBox.Show("Đã thêm thành công hợp đồng có mã " +
                                    "[" + strMaHopDong + "]", "Thêm hợp đồng",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Gọi Form ChonPhongThueForm
                                Form frm = new ChonPhongThueForm(strMaHopDong);
                                frm.ShowDialog();

                                // Cập nhật tổng tiền
                                capNhatTongTien(strMaHopDong);

                                // Load lại dữ liệu trên DataGridView
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Thêm hợp đồng không thành công!\n\r" +
                                    "Lỗi:" + err,
                                    "Lỗi thêm hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Thêm hợp đồng không thành công",
                        "Lỗi thêm hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Sửa thông tin
            if (!Them)
            {
                string err = "";
                try
                {
                    // Thứ tự dòng hiện hành
                    int r = dgvChiTietHopDong.CurrentCell.RowIndex;
                    // MaHopDong hiện hành
                    string strMaHopDong = dgvChiTietHopDong.Rows[r].Cells[0].Value.ToString();

                    // Điều kiện số ngày thuê phải là số lớn hơn 0
                    int soNgayThue = 0;
                    int.TryParse(txtSoNgayThue.Text.ToString(), out soNgayThue);
                    if (soNgayThue < 1)
                    {
                        MessageBox.Show(
                            "Số ngày thuê phải là số nguyên lớn hơn 0\n" +
                            "Vui lòng nhập lại!",
                            "Điều kiện số ngày thuê",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        txtSoNgayThue.ResetText();
                        txtSoNgayThue.Focus();
                    }
                    else
                    {
                        f = dbCTHD.CapNhatChiTietHopDong(ref err,
                        strMaHopDong,
                        txtSoNgayThue.Text);
                        if (f)
                        {
                            // Cập nhật tổng tiền
                            capNhatTongTien(strMaHopDong);

                            // Thông báo
                            MessageBox.Show("Đã sửa thành công hợp đồng có mã " +
                                "[" + strMaHopDong + "]", "Sửa hợp đồng",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Load lại dữ liệu trên DataGridView
                            LoadData();

                            // Cho phép thay đổi txtMaHopDong / cbNhanVien / cbKhachHang
                            txtMaHopDong.Enabled = true;
                            cbNhanVien.Enabled = true;
                            cbKhachHang.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Sửa hợp đồng không thành công!\n\r" +
                                "Lỗi:" + err,
                                "Lỗi sửa hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                 
                }
                catch (SqlException)
                {
                    MessageBox.Show("Sửa hợp đồng không thành công",
                        "Lỗi sửa hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            clearPanel();

            // Không cho thao tác trên các nút Sửa / Lưu / Hủy
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            panel.Enabled = false;

            // Cho thao tác trên các nút Thêm / Thoát
            btnThem.Enabled = true;
            btnThoat.Enabled = true;

            // Cho phép thay đổi txtMaHopDong / cbNhanVien / cbKhachHang
            txtMaHopDong.Enabled = true;
            cbNhanVien.Enabled = true;
            cbKhachHang.Enabled = true;
        }

        private void dgvChiTietHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiTietHopDong.CurrentCell != null)
            {
                // Không cho thao tác trên nút Lưu / Hủy và panel
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                panel.Enabled = false;

                // Đưa dữ liệu lên ComboBox
                cbNhanVien.DataSource = dtNhanVien;
                cbNhanVien.DisplayMember = "MaNhanVien";
                cbNhanVien.ValueMember = "MaNhanVien";

                cbKhachHang.DataSource = dtKhachHang;
                cbKhachHang.DisplayMember = "MaKhachHang";
                cbKhachHang.ValueMember = "MaKhachHang";

                // Thứ tự dòng hiện hành
                int r = dgvChiTietHopDong.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                txtMaHopDong.Text = dgvChiTietHopDong.Rows[r].Cells[0].Value.ToString();
                cbNhanVien.SelectedValue = dgvChiTietHopDong.Rows[r].Cells[1].Value.ToString();
                cbKhachHang.SelectedValue = dgvChiTietHopDong.Rows[r].Cells[2].Value.ToString();
                txtNgayVao.Text = ((DateTime)dgvChiTietHopDong.Rows[r].Cells[3].Value).ToString("yyyy-MM-dd");
                txtSoNgayThue.Text = dgvChiTietHopDong.Rows[r].Cells[4].Value.ToString();
                txtSoLuongPhongThue.Text = dgvChiTietHopDong.Rows[r].Cells[5].Value.ToString();
                txtTongTien.Text = dgvChiTietHopDong.Rows[r].Cells[6].Value.ToString();
                // Gán tổng tiền
                intTongTien = int.Parse(dgvChiTietHopDong.Rows[r].Cells[6].Value.ToString());

                // Lấy tình trạng thanh toán
                string tttt = "";
                tttt = dbCTHD.LayTinhTrangThanhToan(txtMaHopDong.Text);

                if (tttt == "True")
                {
                    // Không cho thao tác trên nút Sửa / Xem Phòng
                    btnSua.Enabled = false;
                    btnXemPhong.Enabled = false;
                }
                else
                {
                    // Cho thao tác trên các nút Xem Phòng Sửa
                    btnXemPhong.Enabled = true;
                    btnSua.Enabled = true;
                }

                // Cho thao tác trên các nút Thêm / Thoát
                btnThem.Enabled = true;
                btnThoat.Enabled = true;
            }
        }

        private void btnXemPhong_Click(object sender, EventArgs e)
        {
            // Mã hợp đồng được chọn
            string strMaHopDong = txtMaHopDong.Text.ToString();

            // Gọi Form XemPhongThueForm
            Form frm = new XemPhongThueForm(strMaHopDong);
            frm.ShowDialog();

            // Load lại dữ liệu trên DataGridView
            LoadData();
        }

        void capNhatTongTien(string strMaHopDong)
        {
            bool f = false;
            string err = "";
            // Cập nhật tổng tiền
            int soNgayThue = int.Parse(txtSoNgayThue.Text.ToString());
            intTongTien = intTongTien * soNgayThue;

            f = dbCTHD.CapNhatTongTien(ref err,
                strMaHopDong,
                intTongTien.ToString());
            if (!f)
            {
                MessageBox.Show("Cập nhật tổng tiền không thành công!\n\r" +
                            "Lỗi:" + err,
                            "Cập nhật tổng tiền", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
