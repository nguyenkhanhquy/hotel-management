namespace QuanLyKhachSan
{
    partial class DanhMucPhongForm
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
            this.lbDanhMucPhong = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiPhong = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongTrong = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDanhMucPhong
            // 
            this.lbDanhMucPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhMucPhong.ForeColor = System.Drawing.Color.Red;
            this.lbDanhMucPhong.Location = new System.Drawing.Point(376, 15);
            this.lbDanhMucPhong.Name = "lbDanhMucPhong";
            this.lbDanhMucPhong.Size = new System.Drawing.Size(261, 34);
            this.lbDanhMucPhong.TabIndex = 10;
            this.lbDanhMucPhong.Text = "Danh Mục Phòng";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(863, 8);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 50);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.AllowUserToResizeColumns = false;
            this.dgvPhong.AllowUserToResizeRows = false;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.MaLoaiPhong,
            this.SoPhong,
            this.SoLuongNguoi,
            this.PhongTrong,
            this.MaHopDong});
            this.dgvPhong.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPhong.Location = new System.Drawing.Point(13, 64);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(978, 228);
            this.dgvPhong.TabIndex = 11;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.Frozen = true;
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 100;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 125;
            // 
            // MaLoaiPhong
            // 
            this.MaLoaiPhong.DataPropertyName = "MaLoaiPhong";
            this.MaLoaiPhong.HeaderText = "Loại Phòng";
            this.MaLoaiPhong.MinimumWidth = 110;
            this.MaLoaiPhong.Name = "MaLoaiPhong";
            this.MaLoaiPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaLoaiPhong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaLoaiPhong.Width = 110;
            // 
            // SoPhong
            // 
            this.SoPhong.DataPropertyName = "SoPhong";
            this.SoPhong.HeaderText = "Số Phòng";
            this.SoPhong.MinimumWidth = 80;
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.Width = 80;
            // 
            // SoLuongNguoi
            // 
            this.SoLuongNguoi.DataPropertyName = "SoLuongNguoi";
            this.SoLuongNguoi.HeaderText = "Số Lượng Người Tối Đa";
            this.SoLuongNguoi.MinimumWidth = 145;
            this.SoLuongNguoi.Name = "SoLuongNguoi";
            this.SoLuongNguoi.Width = 145;
            // 
            // PhongTrong
            // 
            this.PhongTrong.DataPropertyName = "PhongTrong";
            this.PhongTrong.FalseValue = "0";
            this.PhongTrong.HeaderText = "Phòng Trống";
            this.PhongTrong.IndeterminateValue = "0";
            this.PhongTrong.MinimumWidth = 100;
            this.PhongTrong.Name = "PhongTrong";
            this.PhongTrong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PhongTrong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PhongTrong.TrueValue = "1";
            this.PhongTrong.Width = 125;
            // 
            // MaHopDong
            // 
            this.MaHopDong.DataPropertyName = "MaHopDong";
            this.MaHopDong.HeaderText = "Mã Hợp Đồng";
            this.MaHopDong.MinimumWidth = 125;
            this.MaHopDong.Name = "MaHopDong";
            this.MaHopDong.Width = 125;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::QuanLyKhachSan.Properties.Resources.dual_screen;
            this.pictureBox6.Location = new System.Drawing.Point(809, 8);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // DanhMucPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 301);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.lbDanhMucPhong);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DanhMucPhongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DanhMucPhongForm_FormClosing);
            this.Load += new System.EventHandler(this.DanhMucPhongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbDanhMucPhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNguoi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PhongTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHopDong;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}