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
    public partial class DoiMatKhauForm : Form
    {
        DBTaiKhoan dbTK;
        public DoiMatKhauForm()
        {
            InitializeComponent();
            dbTK = new DBTaiKhoan();
        }

        private void DoiMatKhauForm_Load(object sender, EventArgs e)
        {
            txtUser.Text = DangNhapForm.strUser;
            picEye1.Visible = false;
            picEye2.Visible = false;
            picEye3.Visible = false;
            txtPass1.PasswordChar = '*';
            txtPass2.PasswordChar = '*';
            txtPass3.PasswordChar = '*';
        }

        void clearPanel()
        {
            txtPass1.Clear();
            txtPass2.Clear();
            txtPass3.Clear();
            txtPass1.Focus();
            chkHienMatKhau.Checked = false;
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                picEye1.Visible = true;
                picEye2.Visible = true;
                picEye3.Visible = true;
                picEyeOff1.Visible = false;
                picEyeOff2.Visible = false;
                picEyeOff3.Visible = false;

                // Hiện mặt khẩu
                txtPass1.PasswordChar = '\0';
                txtPass2.PasswordChar = '\0';
                txtPass3.PasswordChar = '\0';

            }
            else
            {
                picEye1.Visible = false;
                picEye2.Visible = false;
                picEye3 .Visible = false;
                picEyeOff1.Visible = true;
                picEyeOff2.Visible = true;
                picEyeOff3 .Visible = true;

                // Hiện mặt khẩu
                txtPass1.PasswordChar = '*';
                txtPass2.PasswordChar = '*';
                txtPass3.PasswordChar = '*';
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
            if (traloi == DialogResult.Yes) Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                string strUser = DangNhapForm.strUser;
                string strPass = dbTK.LayMatKhau(strUser);
                if (txtPass1.Text == strPass && txtPass2.Text == txtPass3.Text)
                {
                    string err = "";
                    bool f = dbTK.DoiMatKhau(ref err,
                        strUser,
                        txtPass2.Text);
                    if (f)
                    {
                        MessageBox.Show("Đã đổi thành công mật khẩu của tài khoản có tên đăng nhập " +
                            "[" + strUser + "]. Vui lòng đăng nhập lại!", "Đổi mật khẩu",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MenuForm.check = true;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu không thành công!\n\r" +
                            "Lỗi:" + err,
                            "Lỗi đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu cũ hoặc mật khẩu mới ở 2 ô mật khẩu mới không trùng khớp",
                        "Lỗi đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearPanel();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu trong table TaiKhoan",
                    "Lỗi lấy dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
