namespace QuanLyKhachSan
{
    partial class XemPhongThueForm
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
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.lbMaHopDong = new System.Windows.Forms.Label();
            this.lbXemPhongThue = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiPhong = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongTrong = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHopDong.ForeColor = System.Drawing.Color.Red;
            this.txtMaHopDong.Location = new System.Drawing.Point(346, 63);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.ReadOnly = true;
            this.txtMaHopDong.Size = new System.Drawing.Size(160, 30);
            this.txtMaHopDong.TabIndex = 40;
            // 
            // lbMaHopDong
            // 
            this.lbMaHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHopDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbMaHopDong.Location = new System.Drawing.Point(171, 66);
            this.lbMaHopDong.Name = "lbMaHopDong";
            this.lbMaHopDong.Size = new System.Drawing.Size(169, 28);
            this.lbMaHopDong.TabIndex = 39;
            this.lbMaHopDong.Text = "Mã Hợp Đồng:";
            // 
            // lbXemPhongThue
            // 
            this.lbXemPhongThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXemPhongThue.ForeColor = System.Drawing.Color.Red;
            this.lbXemPhongThue.Location = new System.Drawing.Point(211, 9);
            this.lbXemPhongThue.Name = "lbXemPhongThue";
            this.lbXemPhongThue.Size = new System.Drawing.Size(295, 36);
            this.lbXemPhongThue.TabIndex = 38;
            this.lbXemPhongThue.Text = "Xem Phòng Thuê";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(512, 302);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 50);
            this.btnThoat.TabIndex = 35;
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
            this.dgvPhong.Location = new System.Drawing.Point(12, 116);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(628, 180);
            this.dgvPhong.TabIndex = 41;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::QuanLyKhachSan.Properties.Resources.dual_screen;
            this.pictureBox6.Location = new System.Drawing.Point(458, 302);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 46;
            this.pictureBox6.TabStop = false;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.Frozen = true;
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 90;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 90;
            // 
            // MaLoaiPhong
            // 
            this.MaLoaiPhong.DataPropertyName = "MaLoaiPhong";
            this.MaLoaiPhong.HeaderText = "Tên Loại Phòng";
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
            this.SoPhong.MinimumWidth = 90;
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.Width = 90;
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
            this.PhongTrong.MinimumWidth = 125;
            this.PhongTrong.Name = "PhongTrong";
            this.PhongTrong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PhongTrong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PhongTrong.TrueValue = "1";
            this.PhongTrong.Visible = false;
            this.PhongTrong.Width = 125;
            // 
            // MaHopDong
            // 
            this.MaHopDong.DataPropertyName = "MaHopDong";
            this.MaHopDong.HeaderText = "Mã Hợp Đồng";
            this.MaHopDong.MinimumWidth = 125;
            this.MaHopDong.Name = "MaHopDong";
            this.MaHopDong.Visible = false;
            this.MaHopDong.Width = 125;
            // 
            // XemPhongThueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 361);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.txtMaHopDong);
            this.Controls.Add(this.lbMaHopDong);
            this.Controls.Add(this.lbXemPhongThue);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XemPhongThueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Phòng Thuê";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XemPhongThueForm_FormClosing);
            this.Load += new System.EventHandler(this.XemPhongThueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.Label lbMaHopDong;
        private System.Windows.Forms.Label lbXemPhongThue;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNguoi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PhongTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHopDong;
    }
}