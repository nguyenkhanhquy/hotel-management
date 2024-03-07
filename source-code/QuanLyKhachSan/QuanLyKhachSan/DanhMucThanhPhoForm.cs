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
    public partial class DanhMucThanhPhoForm : Form
    {
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtThanhPho = null;

        DBThanhPho dbTP;

        public DanhMucThanhPhoForm()
        {
            InitializeComponent();
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
                // Đưa dữ liệu lên DataGridView 
                dgvThanhPho.DataSource = dtThanhPho;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu trong table ThanhPho",
                    "Lỗi lấy dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DanhMucThanhPhoForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DanhMucThanhPhoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
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
