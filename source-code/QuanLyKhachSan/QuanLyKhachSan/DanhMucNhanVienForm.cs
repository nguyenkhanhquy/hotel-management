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
    public partial class DanhMucNhanVienForm : Form
    {
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtNhanVien = null;

        DBNhanVien dbNV;

        public DanhMucNhanVienForm()
        {
            InitializeComponent();
            dbNV = new DBNhanVien();
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
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu trong table NhanVien",
                    "Lỗi lấy dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DanhMucNhanVienForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DanhMucNhanVienForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
