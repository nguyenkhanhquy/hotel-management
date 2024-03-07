using BALayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class DangNhapForm : Form
    {
        DBTaiKhoan dbTK;

        public static string strUser;
        public DangNhapForm()
        {
            InitializeComponent();
            dbTK = new DBTaiKhoan();
        }

        private void DangNhapForm_Load(object sender, EventArgs e)
        {
            picEye.Visible = false;
            txtPass.PasswordChar = '*';
        }

        void clearPanel()
        {
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
            chkHienMatKhau.Checked = false;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbTK.KiemTraTonTai(txtUser.Text) == "1")
                {
                    strUser = txtUser.Text;
                    string strPass = dbTK.LayMatKhau(strUser);
                    if (strPass == txtPass.Text)
                    {
                        Form frm = new MenuForm();
                        Hide();
                        frm.ShowDialog();
                        Show();
                        clearPanel();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không đúng",
                            "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại",
                        "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearPanel();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu trong table TaiKhoan" ,
                    "Lỗi lấy dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                picEye.Visible = true;
                picEyeOff.Visible = false;

                // Hiện mặt khẩu
                txtPass.PasswordChar = '\0';

            }
            else
            {
                picEye.Visible = false;
                picEyeOff.Visible = true;

                // Ẩn mật khẩu
                txtPass.PasswordChar = '*';
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc chắn muốn thoát không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Yes không?
            if (traloi == DialogResult.Yes) Application.Exit();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Form frm = new DangKyForm();
            Hide();
            frm.ShowDialog();
            Show();

            clearPanel();
        }
    }
}
