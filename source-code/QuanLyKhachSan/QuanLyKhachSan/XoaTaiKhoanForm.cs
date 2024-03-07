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
    public partial class XoaTaiKhoanForm : Form
    {
        DBTaiKhoan dbTK;
        public XoaTaiKhoanForm()
        {
            InitializeComponent();
            dbTK = new DBTaiKhoan();
        }

        private void XoaTaiKhoanForm_Load(object sender, EventArgs e)
        {
            txtUser.Text = DangNhapForm.strUser;
            picEye1.Visible = false;
            txtPass1.PasswordChar = '*';
        }

        void clearPanel()
        {
            txtPass1.Clear();
            txtPass1.Focus();
            chkHienMatKhau.Checked = false;
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                picEye1.Visible = true;
                picEyeOff1.Visible = false;

                // Hiện mặt khẩu
                txtPass1.PasswordChar = '\0';

            }
            else
            {
                picEye1.Visible = false;
                picEyeOff1.Visible = true;

                // Hiện mặt khẩu
                txtPass1.PasswordChar = '*';
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

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                string strUser = DangNhapForm.strUser;
                string strPass = dbTK.LayMatKhau(strUser);
                if (txtPass1.Text == strPass)
                {
                    string err = "";
                    bool f = dbTK.XoaTaiKhoan(ref err, strUser);
                    if (f)
                    {
                        MessageBox.Show("Đã xóa thành công tài khoản có tên đăng nhập " +
                            "[" + strUser + "].\n\r" +
                            "Sẽ tự động đăng xuất!", "Xóa tài khoản",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MenuForm.check = true;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản không thành công!\n\r" +
                            "Lỗi:" + err,
                            "Lỗi xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!",
                        "Lỗi xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
