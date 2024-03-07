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
    public partial class HoaDonForm : Form
    {
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtHoaDon = null;

        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtHopDong = null;

        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;

        DBHoaDon dbHD;
        DBChiTietHopDong dbCTHD;
        DBPhong dbP;

        public HoaDonForm()
        {
            InitializeComponent();
            dbHD = new DBHoaDon();
            dbCTHD = new DBChiTietHopDong();
            dbP = new DBPhong();
        }

        void clearPanel()
        {
            // Xóa trống các đối tượng trong Panel
            txtMaHoaDon.ResetText();
            cbHopDong.SelectedIndex = -1;
            txtTongTien.ResetText();
            txtNgayThanhToan.ResetText();
        }

        void LoadData()
        {
            try
            {
                // Vận chuyển dữ liệu vào DataTable dtHopDong
                dtHopDong = new DataTable();
                dtHopDong.Clear();
                dtHopDong = dbCTHD.LayChiTietHopDong().Tables[0];
                // Đưa dữ liệu lên ComboBox trong DataGridView 
                MaHopDong.DataSource = dtHopDong;
                MaHopDong.DisplayMember = "MaHopDong";
                MaHopDong.ValueMember = "MaHopDong";

                // Vận chuyển dữ liệu lên DataTable dtHoaDon
                dtHoaDon = new DataTable();
                dtHoaDon.Clear();
                dtHoaDon = dbHD.LayHoaDon().Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvHoaDon.DataSource = dtHoaDon;

                // Xóa trống các đối tượng trong Panel
                clearPanel();

                // Không cho thao tác trên các nút Lưu / Hủy và panel
                btnThanhToan.Enabled = false;
                btnThanhToan.Text = "Thanh Toán";
                btnHuy.Enabled = false;
                panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Thoát
                btnThem.Enabled = true;
                btnThoat.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu trong table HoaDon",
                    "Lỗi lấy dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void HoaDonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtHoaDon.Dispose();
            dtHoaDon = null;
            dtHopDong.Dispose();
            dtHopDong = null;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            clearPanel();

            // Đưa dữ liệu lên ComboBox
            cbHopDong.DataSource = dtHopDong;
            cbHopDong.DisplayMember = "MaHopDong";
            cbHopDong.ValueMember = "MaHopDong";
            cbHopDong.SelectedIndex = -1;

            // Cho phép thay đổi txtMaHoaDon
            txtMaHoaDon.Enabled = true;
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnThanhToan.Enabled = true;
            btnThanhToan.Text = "Thanh Toán";
            btnHuy.Enabled = true;
            panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Thoát
            btnThem.Enabled = false;
            btnThoat.Enabled = false;

            // Gán ngày tháng năm hiện tại vào txtNgayThanhToan
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("yyyy-MM-dd");
            txtNgayThanhToan.Text = formattedDate;

            // Đưa con trỏ đến TextField txtMaHoaDon
            txtMaHoaDon.Focus();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc chắn muốn thanh toán không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Yes không?
            if (traloi == DialogResult.Yes)
            {
                bool f = false;
                // Thêm dữ liệu
                if (Them)
                {
                    string err = "";
                    try
                    {
                        // Mã hóa đơn được thêm
                        string strMaHoaDon = txtMaHoaDon.Text.ToString();

                        // Điều kiện về mã có trong hóa đơn
                        if (txtMaHoaDon.Text == "" ||
                            cbHopDong.SelectedIndex == -1)
                        {
                            MessageBox.Show(
                                "Các loại mã trong hóa đơn không được bỏ trống\n" +
                                "Vui lòng nhập lại hoặc chọn lại!",
                                "Điều kiện về mã có trong hóa đơn",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                        else
                        {
                            f = dbHD.ThemHoaDon(ref err,
                                txtMaHoaDon.Text,
                                cbHopDong.SelectedValue.ToString(),
                                txtTongTien.Text,
                                txtNgayThanhToan.Text);
                            if (f)
                            {
                                // Cập nhật tình trạng thanh toán của hợp đồng
                                dbCTHD.CapNhatTinhTrangThanhToan(ref err,
                                    cbHopDong.Text.ToString());

                                // Cập nhật tình trạng phòng được thuê của hợp đồng
                                dbP.CapNhatTinhTrangPhongThue(ref err,
                                    cbHopDong.Text.ToString());

                                // Thông báo
                                MessageBox.Show("Đã thanh toán thành công hóa đơn có mã " +
                                    "[" + strMaHoaDon + "]", "Thanh toán hóa đơn",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thanh toán hóa đơn không thành công!\n\r" +
                                        "Lỗi:" + err,
                                        "Lỗi Thanh toán hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            // Load lại dữ liệu trên DataGridView
                            LoadData();
                        }
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Thanh toán hóa đơn không thành công",
                            "Lỗi thanh toán hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            clearPanel();

            // Không cho thao tác trên các nút Thanh Toán / Hủy và panel
            btnThanhToan.Enabled = false;
            btnThanhToan.Text = "Thanh Toán";
            btnHuy.Enabled = false;
            panel.Enabled = false;
            // Cho thao tác trên các nút Thêm / Thoát
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null)
            {
                // Không cho thao tác trên nút Thanh Toán / Hủy và panel
                btnThanhToan.Enabled = false;
                btnHuy.Enabled = false;
                panel.Enabled = false;

                // Cho thao tác trên các nút Thêm / Thoát
                btnThem.Enabled = true;
                btnThoat.Enabled = true;

                // Đưa dữ liệu lên ComboBox
                cbHopDong.DataSource = dtHopDong;
                cbHopDong.DisplayMember = "MaHopDong";
                cbHopDong.ValueMember = "MaHopDong";

                // Thứ tự dòng hiện hành
                int r = dgvHoaDon.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                txtMaHoaDon.Text = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
                cbHopDong.Text = dgvHoaDon.Rows[r].Cells[1].Value.ToString();
                txtTongTien.Text = dgvHoaDon.Rows[r].Cells[2].Value.ToString();
                txtNgayThanhToan.Text = ((DateTime)dgvHoaDon.Rows[r].Cells[3].Value).ToString("yyyy-MM-dd");
            }   
        }

        private void cbHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHopDong.SelectedIndex != -1)
            {
                // Đưa thông tin tổng tiền của hợp đồng lên txtTongTien
                txtTongTien.Text = dbCTHD.LayTongTien(cbHopDong.Text).ToString();

                // Kiểm tra hợp đồng đã được thanh toán chưa
                string tttt = dbCTHD.LayTinhTrangThanhToan(cbHopDong.Text);
                if (tttt == "True")
                {
                    btnThanhToan.Enabled = false;
                    btnThanhToan.Text = "Đã Thanh Toán";
                }
                else
                {
                    btnThanhToan.Enabled = true;
                    btnThanhToan.Text = "Thanh Toán";
                }
            }
            else
            {
                txtTongTien.ResetText();
            }
        }
    }
}
