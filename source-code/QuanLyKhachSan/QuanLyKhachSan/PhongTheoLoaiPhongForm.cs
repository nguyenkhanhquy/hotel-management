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
    public partial class PhongTheoLoaiPhongForm : Form
    {
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtPhong = null;

        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtLoaiPhong = null;

        // Đối tượng DataView
        DataView dtvPhong = null;

        DBPhong dbP;
        DBLoaiPhong dbLP;

        public PhongTheoLoaiPhongForm()
        {
            InitializeComponent();
            dbP = new DBPhong();
            dbLP = new DBLoaiPhong();
        }

        void LoadData()
        {
            try
            {
                // Vận chuyển dữ liệu vào DataTable dtLoaiPhong
                dtLoaiPhong = new DataTable();
                dtLoaiPhong.Clear();
                dtLoaiPhong = dbLP.LayLoaiPhong().Tables[0];
                // Đưa dữ liệu lên ComboBox
                cbLoaiPhong.DataSource = dtLoaiPhong;
                cbLoaiPhong.DisplayMember = "TenLoaiPhong";
                cbLoaiPhong.ValueMember = "MaLoaiPhong";
                cbLoaiPhong.SelectedIndex = -1;
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

                // Chuyển từ DataTable vào DataView
                dtvPhong = new DataView(dtPhong);
                // Gán vào DataGridView
                dgvPhong.DataSource = dtvPhong;
                txtSoPhong.Text = dtvPhong.Count.ToString();

                // Không cho thao tác nút OK
                btnOK.Enabled = false;
                btnOK.Text = "ALL";
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu trong table Phong",
                    "Lỗi lấy dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PhongTheoLoaiPhongForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void PhongTheoLoaiPhongForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtPhong.Dispose();
            dtPhong = null;
            dtLoaiPhong.Dispose();
            dtLoaiPhong = null;
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cho thao tác nút OK
            btnOK.Enabled = true;
            btnOK.Text = "OK";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Lọc dữ liệu theo MaLoaiPhong
            dtvPhong.RowFilter = "MaLoaiPhong ='" +
                cbLoaiPhong.SelectedValue.ToString() + "'";
            dgvPhong.DataSource = dtvPhong;
            // Gán số lượng phòng lọc được vào txtSoPhong
            txtSoPhong.Text = dtvPhong.Count.ToString();

            btnOK.Enabled = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            cbLoaiPhong.SelectedIndex = -1;
            dtvPhong.RowFilter = "";
            dgvPhong.DataSource = dtvPhong;
            txtSoPhong.Text = dtvPhong.Count.ToString();

            // Không cho thao tác nút OK
            btnOK.Enabled = false;
            btnOK.Text = "ALL";
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
