using BALayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class DanhMucLoaiPhongForm : Form
    {
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtLoaiPhong = null;

        DBLoaiPhong dbLP;

        public DanhMucLoaiPhongForm()
        {
            InitializeComponent();
            dbLP = new DBLoaiPhong();
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
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu trong table LoaiPhong",
                    "Lỗi lấy dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DanhMucLoaiPhongForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DanhMucLoaiPhongForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
