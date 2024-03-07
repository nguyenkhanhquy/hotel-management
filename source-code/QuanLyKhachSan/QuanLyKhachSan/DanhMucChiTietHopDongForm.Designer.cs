namespace QuanLyKhachSan
{
    partial class DanhMucChiTietHopDongForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvChiTietHopDong = new System.Windows.Forms.DataGridView();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbDanhMucHopDong = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.MaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongPhongThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangThanhToan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiTietHopDong
            // 
            this.dgvChiTietHopDong.AllowUserToAddRows = false;
            this.dgvChiTietHopDong.AllowUserToDeleteRows = false;
            this.dgvChiTietHopDong.AllowUserToResizeColumns = false;
            this.dgvChiTietHopDong.AllowUserToResizeRows = false;
            this.dgvChiTietHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHopDong,
            this.MaNhanVien,
            this.MaKhachHang,
            this.NgayVao,
            this.SoNgayThue,
            this.SoLuongPhongThue,
            this.TongTien,
            this.TinhTrangThanhToan});
            this.dgvChiTietHopDong.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChiTietHopDong.Location = new System.Drawing.Point(12, 81);
            this.dgvChiTietHopDong.Name = "dgvChiTietHopDong";
            this.dgvChiTietHopDong.RowHeadersWidth = 51;
            this.dgvChiTietHopDong.RowTemplate.Height = 24;
            this.dgvChiTietHopDong.Size = new System.Drawing.Size(1506, 324);
            this.dgvChiTietHopDong.TabIndex = 20;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::QuanLyKhachSan.Properties.Resources.dual_screen;
            this.pictureBox6.Location = new System.Drawing.Point(1336, 25);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 28;
            this.pictureBox6.TabStop = false;
            // 
            // lbDanhMucHopDong
            // 
            this.lbDanhMucHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhMucHopDong.ForeColor = System.Drawing.Color.Red;
            this.lbDanhMucHopDong.Location = new System.Drawing.Point(648, 32);
            this.lbDanhMucHopDong.Name = "lbDanhMucHopDong";
            this.lbDanhMucHopDong.Size = new System.Drawing.Size(346, 36);
            this.lbDanhMucHopDong.TabIndex = 27;
            this.lbDanhMucHopDong.Text = "Danh Mục Hợp Đồng";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1390, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 50);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // MaHopDong
            // 
            this.MaHopDong.DataPropertyName = "MaHopDong";
            this.MaHopDong.Frozen = true;
            this.MaHopDong.HeaderText = "Mã Hợp Đồng";
            this.MaHopDong.MinimumWidth = 125;
            this.MaHopDong.Name = "MaHopDong";
            this.MaHopDong.Width = 125;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Tên Nhân Viên";
            this.MaNhanVien.MinimumWidth = 150;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNhanVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaNhanVien.Width = 150;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Tên Khách Hàng";
            this.MaKhachHang.MinimumWidth = 150;
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaKhachHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaKhachHang.Width = 150;
            // 
            // NgayVao
            // 
            this.NgayVao.DataPropertyName = "NgayVao";
            this.NgayVao.HeaderText = "Ngày Vào";
            this.NgayVao.MinimumWidth = 110;
            this.NgayVao.Name = "NgayVao";
            this.NgayVao.Width = 110;
            // 
            // SoNgayThue
            // 
            this.SoNgayThue.DataPropertyName = "SoNgayThue";
            this.SoNgayThue.HeaderText = "Số Ngày Thuê";
            this.SoNgayThue.MinimumWidth = 110;
            this.SoNgayThue.Name = "SoNgayThue";
            this.SoNgayThue.Width = 110;
            // 
            // SoLuongPhongThue
            // 
            this.SoLuongPhongThue.DataPropertyName = "SoLuongPhongThue";
            this.SoLuongPhongThue.HeaderText = "Số Lượng Phòng Thuê";
            this.SoLuongPhongThue.MinimumWidth = 140;
            this.SoLuongPhongThue.Name = "SoLuongPhongThue";
            this.SoLuongPhongThue.Width = 140;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 125;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 125;
            // 
            // TinhTrangThanhToan
            // 
            this.TinhTrangThanhToan.DataPropertyName = "TinhTrangThanhToan";
            this.TinhTrangThanhToan.FalseValue = "0";
            this.TinhTrangThanhToan.HeaderText = "Tình Trạng Thanh Toán";
            this.TinhTrangThanhToan.IndeterminateValue = "0";
            this.TinhTrangThanhToan.MinimumWidth = 150;
            this.TinhTrangThanhToan.Name = "TinhTrangThanhToan";
            this.TinhTrangThanhToan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TinhTrangThanhToan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TinhTrangThanhToan.TrueValue = "1";
            this.TinhTrangThanhToan.Width = 150;
            // 
            // DanhMucChiTietHopDongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 417);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lbDanhMucHopDong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvChiTietHopDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DanhMucChiTietHopDongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Hợp Đồng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DanhMucChiTietHopDongForm_FormClosing);
            this.Load += new System.EventHandler(this.DanhMucChiTietHopDongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiTietHopDong;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbDanhMucHopDong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHopDong;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongPhongThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TinhTrangThanhToan;
    }
}