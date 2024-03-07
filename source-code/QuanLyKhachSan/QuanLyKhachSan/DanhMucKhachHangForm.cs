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
    public partial class DanhMucKhachHangForm : Form
    {
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtKhachHang = null;

        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtThanhPho = null;

        DBKhachHang dbKH;
        DBThanhPho dbTP;

        public DanhMucKhachHangForm()
        {
            InitializeComponent();
            dbKH = new DBKhachHang();
            dbTP = new DBThanhPho();
        }

        void LoadData()
        {
            try
            {
                // Vận chuyển dữ liệu lên DataTable dtThanhPho
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
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu trong table KhachHang",
                    "Lỗi lấy dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DanhMucKhachHangForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DanhMucKhachHangForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtKhachHang.Dispose();
            dtKhachHang = null;
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
    }
}
