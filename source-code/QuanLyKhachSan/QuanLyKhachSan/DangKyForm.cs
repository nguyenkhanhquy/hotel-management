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
    public partial class DangKyForm : Form
    {
        DBTaiKhoan dbTK;
        public DangKyForm()
        {
            InitializeComponent();
            dbTK = new DBTaiKhoan();
        }

        private void DangKyForm_Load(object sender, EventArgs e)
        {
            picEye1.Visible = false;
            picEye2.Visible = false;
            txtPass1.PasswordChar = '*';
            txtPass2.PasswordChar = '*';
        }

        void clearPanel()
        {
            txtUser.Clear();
            txtPass1.Clear();
            txtPass2.Clear();
            txtUser.Focus();
            chkHienMatKhau.Checked = false;
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                picEye1.Visible = true;
                picEye2.Visible = true;
                picEyeOff1.Visible = false;
                picEyeOff2.Visible = false;

                // Hiện mặt khẩu
                txtPass1.PasswordChar = '\0';
                txtPass2.PasswordChar = '\0';

            }
            else
            {
                picEye1.Visible = false;
                picEye2.Visible = false;
                picEyeOff1.Visible = true;
                picEyeOff2.Visible = true;

                // Hiện mặt khẩu
                txtPass1.PasswordChar = '*';
                txtPass2.PasswordChar = '*';
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

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbTK.KiemTraTonTai(txtUser.Text) != "1")
                {
                    string strUser = txtUser.Text;
                    if (txtPass1.Text == txtPass2.Text)
                    {
                        string strPass = txtPass1.Text;
                        string err = "";
                        bool f = dbTK.ThemTaiKhoan(ref err,
                            strUser, 
                            strPass);
                        if (f)
                        {
                            MessageBox.Show("Đã tạo thành công tài khoản có tên đăng nhập " +
                                "[" + strUser + "]", "Tạo tài khoản",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Tạo nhân viên không thành công!\n\r" +
                                "Lỗi:" + err,
                                "Lỗi tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu 2 ô mật khẩu không trùng khớp",
                            "Lỗi tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại",
                        "Lỗi tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
