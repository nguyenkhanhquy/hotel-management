namespace QuanLyKhachSan
{
    partial class KhachHangTheoThanhPhoForm
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThanhPho = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbThanhPho = new System.Windows.Forms.ComboBox();
            this.lbChonThanhPho = new System.Windows.Forms.Label();
            this.lbQuanLyKhachHangTheoThanhPho = new System.Windows.Forms.Label();
            this.txtSoKhachHang = new System.Windows.Forms.TextBox();
            this.lbTongSoKhachHang = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBoxFilter = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.AllowUserToResizeColumns = false;
            this.dgvKhachHang.AllowUserToResizeRows = false;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhachHang,
            this.TenKhachHang,
            this.CCCD,
            this.NgaySinh,
            this.GioiTinh,
            this.SDT,
            this.MaThanhPho});
            this.dgvKhachHang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvKhachHang.Location = new System.Drawing.Point(11, 134);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(1120, 344);
            this.dgvKhachHang.TabIndex = 18;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.Frozen = true;
            this.MaKhachHang.HeaderText = "Mã Khách Hàng";
            this.MaKhachHang.MinimumWidth = 110;
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Width = 110;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.MinimumWidth = 150;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Width = 150;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.MinimumWidth = 125;
            this.CCCD.Name = "CCCD";
            this.CCCD.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 80;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 80;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 75;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 75;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Điện Thoại";
            this.SDT.MinimumWidth = 125;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // MaThanhPho
            // 
            this.MaThanhPho.DataPropertyName = "MaThanhPho";
            this.MaThanhPho.HeaderText = "Thành Phố";
            this.MaThanhPho.MinimumWidth = 125;
            this.MaThanhPho.Name = "MaThanhPho";
            this.MaThanhPho.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaThanhPho.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaThanhPho.Width = 125;
            // 
            // cbThanhPho
            // 
            this.cbThanhPho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThanhPho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThanhPho.FormattingEnabled = true;
            this.cbThanhPho.Location = new System.Drawing.Point(208, 23);
            this.cbThanhPho.Name = "cbThanhPho";
            this.cbThanhPho.Size = new System.Drawing.Size(300, 33);
            this.cbThanhPho.TabIndex = 13;
            this.cbThanhPho.SelectedIndexChanged += new System.EventHandler(this.cbThanhPho_SelectedIndexChanged);
            // 
            // lbChonThanhPho
            // 
            this.lbChonThanhPho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChonThanhPho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbChonThanhPho.Location = new System.Drawing.Point(3, 26);
            this.lbChonThanhPho.Name = "lbChonThanhPho";
            this.lbChonThanhPho.Size = new System.Drawing.Size(199, 28);
            this.lbChonThanhPho.TabIndex = 12;
            this.lbChonThanhPho.Text = "Chọn Thành Phố:";
            // 
            // lbQuanLyKhachHangTheoThanhPho
            // 
            this.lbQuanLyKhachHangTheoThanhPho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLyKhachHangTheoThanhPho.ForeColor = System.Drawing.Color.Red;
            this.lbQuanLyKhachHangTheoThanhPho.Location = new System.Drawing.Point(24, 18);
            this.lbQuanLyKhachHangTheoThanhPho.Name = "lbQuanLyKhachHangTheoThanhPho";
            this.lbQuanLyKhachHangTheoThanhPho.Size = new System.Drawing.Size(562, 36);
            this.lbQuanLyKhachHangTheoThanhPho.TabIndex = 26;
            this.lbQuanLyKhachHangTheoThanhPho.Text = "Quản Lý Khách Hàng Theo Thành Phố";
            // 
            // txtSoKhachHang
            // 
            this.txtSoKhachHang.Enabled = false;
            this.txtSoKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoKhachHang.ForeColor = System.Drawing.Color.Red;
            this.txtSoKhachHang.Location = new System.Drawing.Point(1024, 23);
            this.txtSoKhachHang.Name = "txtSoKhachHang";
            this.txtSoKhachHang.ReadOnly = true;
            this.txtSoKhachHang.Size = new System.Drawing.Size(78, 30);
            this.txtSoKhachHang.TabIndex = 1;
            // 
            // lbTongSoKhachHang
            // 
            this.lbTongSoKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongSoKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTongSoKhachHang.Location = new System.Drawing.Point(761, 26);
            this.lbTongSoKhachHang.Name = "lbTongSoKhachHang";
            this.lbTongSoKhachHang.Size = new System.Drawing.Size(257, 28);
            this.lbTongSoKhachHang.TabIndex = 0;
            this.lbTongSoKhachHang.Text = "Tổng Số Khách Hàng:";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(65, 484);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(128, 50);
            this.btnReload.TabIndex = 21;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(568, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 50);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.pictureBoxFilter);
            this.panel.Controls.Add(this.cbThanhPho);
            this.panel.Controls.Add(this.lbChonThanhPho);
            this.panel.Controls.Add(this.txtSoKhachHang);
            this.panel.Controls.Add(this.btnOK);
            this.panel.Controls.Add(this.lbTongSoKhachHang);
            this.panel.Location = new System.Drawing.Point(11, 48);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1120, 80);
            this.panel.TabIndex = 22;
            // 
            // pictureBoxFilter
            // 
            this.pictureBoxFilter.Image = global::QuanLyKhachSan.Properties.Resources.filter;
            this.pictureBoxFilter.Location = new System.Drawing.Point(514, 13);
            this.pictureBoxFilter.Name = "pictureBoxFilter";
            this.pictureBoxFilter.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFilter.TabIndex = 21;
            this.pictureBoxFilter.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1003, 484);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 50);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::QuanLyKhachSan.Properties.Resources.dual_screen;
            this.pictureBox6.Location = new System.Drawing.Point(949, 484);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyKhachSan.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(11, 484);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // KhachHangTheoThanhPhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 541);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.lbQuanLyKhachHangTheoThanhPho);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KhachHangTheoThanhPhoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khách Hàng Theo Thành Phố";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KhachHangTheoThanhPhoForm_FormClosing);
            this.Load += new System.EventHandler(this.KhachHangTheoThanhPhoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.ComboBox cbThanhPho;
        private System.Windows.Forms.Label lbChonThanhPho;
        private System.Windows.Forms.Label lbQuanLyKhachHangTheoThanhPho;
        private System.Windows.Forms.TextBox txtSoKhachHang;
        private System.Windows.Forms.Label lbTongSoKhachHang;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaThanhPho;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxFilter;
    }
}