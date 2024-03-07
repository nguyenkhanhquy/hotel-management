using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class MenuForm : Form
    {
        public static bool check;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            check = false;
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ThongTinTaiKhoanForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DoiMatKhauForm();
            Hide();
            frm.ShowDialog();
            if (!check)
                Show();
            else
                Close();
        }

        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new XoaTaiKhoanForm();
            Hide();
            frm.ShowDialog();
            if (!check)
                Show();
            else
                Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc chắn muốn đăng xuất không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Yes không?
            if (traloi == DialogResult.Yes) Close();
        }

        private void danhMụcPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DanhMucLoaiPhongForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DanhMucNhanVienForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void danhMụcThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DanhMucThanhPhoForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DanhMucKhachHangForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void danhMụcHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DanhMucChiTietHopDongForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void danhMụcPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new DanhMucPhongForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void danhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DanhMucHoaDonForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void quảnLýDanhMụcLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new LoaiPhongForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void quảnLýDanhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new NhanVienForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void quảnLýDanhMụcThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ThanhPhoForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void quảnLýDanhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new KhachHangForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void quảnLýDanhMụcHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ChiTietHopDongForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void quảnLýDanhMụcPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new PhongForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void quảnLýDanhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new HoaDonForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void quảnLýKháchHàngTheoThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new KhachHangTheoThanhPhoForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void quảnLýPhòngTheoLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new PhongTheoLoaiPhongForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new TacGiaForm();
            Hide();
            frm.ShowDialog();
            Show();
        }
    }
}
