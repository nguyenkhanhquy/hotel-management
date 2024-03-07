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
    public partial class ChonPhongThueForm : Form
    {
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtPhong = null;

        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtLoaiPhong = null;

        // Khai báo biến lưu mã hợp đồng
        string strMaHopDong;

        DBPhong dbP;
        DBLoaiPhong dbLP;
        DBChiTietHopDong dbCTHD;

        public ChonPhongThueForm(string maHopDong)
        {
            InitializeComponent();
            strMaHopDong = maHopDong;
            dbP = new DBPhong();
            dbLP = new DBLoaiPhong();
            dbCTHD = new DBChiTietHopDong();
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

                // Không cho thao tác trên nút Chọn
                btnChon.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu trong table Phong",
                    "Lỗi lấy dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChonPhongThueForm_Load(object sender, EventArgs e)
        {
            txtMaHopDong.Text = strMaHopDong;
            LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ChonPhongThueForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtPhong.Dispose();
            dtPhong = null;
            dtLoaiPhong.Dispose();
            dtLoaiPhong = null;
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc chắn đã thêm phòng xong?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Yes không?
            if (traloi == DialogResult.Yes) Close();      
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPhong.CurrentCell != null)
            {
                // Thứ tự dòng hiện hành
                int r = dgvPhong.CurrentCell.RowIndex;
                if (dgvPhong.Rows[r].Cells[4].Value.ToString() == "True")
                {
                    // Cho thao tác trên nút Chọn
                    btnChon.Enabled = true;
                }
                else
                {
                    // Không cho thao tác trên nút Chọn
                    btnChon.Enabled = false;
                }
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvPhong.CurrentCell.RowIndex;
            // MaPhong hiện hành
            string strMaPhong = dgvPhong.Rows[r].Cells[0].Value.ToString();

            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc chắn muốn thêm phòng có mã " +
                    "[" + strMaPhong + "] vào hợp đồng có mã " +
                    "[" + strMaHopDong + "] không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Yes không?
            if (traloi == DialogResult.Yes)
            {
                string err = "";
                bool f = false;
                // Cập nhật mã hợp đồng và tình trạng phòng trống cho phòng được thuê
                f = dbP.CapNhatMaHopDong(ref err,
                    strMaPhong, 
                    strMaHopDong);
                if (!f) 
                {
                    MessageBox.Show("Cập nhật mã hợp đồng và tình trạng phòng trống " +
                        "cho phòng được thuê không thành công!\n\r" +
                        "Lỗi:" + err,
                        "Lỗi thêm phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Tăng số lượng phòng thuê của hợp đồng
                f = dbCTHD.CapNhatSoPhongThue(ref err,
                    strMaHopDong);
                if (!f)
                {
                    MessageBox.Show("Cập nhật số lượng phòng thuê không thành công!\n\r " +
                        "Lỗi:" + err,
                        "Lỗi thêm phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Cập nhật Cập nhật tổng tiền
                int GiaPhong = 0;
                string strMaLoaiPhong = dgvPhong.Rows[r].Cells[1].Value.ToString();
                GiaPhong = int.Parse(dbLP.LayGiaPhong(strMaLoaiPhong).ToString());
                ChiTietHopDongForm.intTongTien += GiaPhong;

                // Load lại dữ liệu trên DataGridView
                LoadData();

                // Thông báo
                MessageBox.Show("Đã thêm thành công phòng có mã " +
                    "[" + strMaPhong + "] vào hợp đồng có mã " +
                    "[" + strMaHopDong + "]", "Thêm phòng vào hợp đồng",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
