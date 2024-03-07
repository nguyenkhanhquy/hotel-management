namespace QuanLyKhachSan
{
    partial class PhongTheoLoaiPhongForm
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
            this.lbQuanLyPhongTheoLoaiPhong = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBoxFilter = new System.Windows.Forms.PictureBox();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lbChonLoaiPhong = new System.Windows.Forms.Label();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbTongSoPhong = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiPhong = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongTrong = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQuanLyPhongTheoLoaiPhong
            // 
            this.lbQuanLyPhongTheoLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLyPhongTheoLoaiPhong.ForeColor = System.Drawing.Color.Red;
            this.lbQuanLyPhongTheoLoaiPhong.Location = new System.Drawing.Point(23, 18);
            this.lbQuanLyPhongTheoLoaiPhong.Name = "lbQuanLyPhongTheoLoaiPhong";
            this.lbQuanLyPhongTheoLoaiPhong.Size = new System.Drawing.Size(488, 36);
            this.lbQuanLyPhongTheoLoaiPhong.TabIndex = 31;
            this.lbQuanLyPhongTheoLoaiPhong.Text = "Quản Lý Phòng Theo Loại Phòng";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(63, 484);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(128, 50);
            this.btnReload.TabIndex = 29;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.pictureBoxFilter);
            this.panel.Controls.Add(this.cbLoaiPhong);
            this.panel.Controls.Add(this.lbChonLoaiPhong);
            this.panel.Controls.Add(this.txtSoPhong);
            this.panel.Controls.Add(this.btnOK);
            this.panel.Controls.Add(this.lbTongSoPhong);
            this.panel.Location = new System.Drawing.Point(9, 47);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1012, 81);
            this.panel.TabIndex = 30;
            // 
            // pictureBoxFilter
            // 
            this.pictureBoxFilter.Image = global::QuanLyKhachSan.Properties.Resources.filter;
            this.pictureBoxFilter.Location = new System.Drawing.Point(536, 13);
            this.pictureBoxFilter.Name = "pictureBoxFilter";
            this.pictureBoxFilter.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFilter.TabIndex = 22;
            this.pictureBoxFilter.TabStop = false;
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(230, 23);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(300, 33);
            this.cbLoaiPhong.TabIndex = 13;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_SelectedIndexChanged);
            // 
            // lbChonLoaiPhong
            // 
            this.lbChonLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChonLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbChonLoaiPhong.Location = new System.Drawing.Point(3, 26);
            this.lbChonLoaiPhong.Name = "lbChonLoaiPhong";
            this.lbChonLoaiPhong.Size = new System.Drawing.Size(221, 28);
            this.lbChonLoaiPhong.TabIndex = 12;
            this.lbChonLoaiPhong.Text = "Chọn Loại Phòng:";
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Enabled = false;
            this.txtSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhong.ForeColor = System.Drawing.Color.Red;
            this.txtSoPhong.Location = new System.Drawing.Point(918, 25);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.ReadOnly = true;
            this.txtSoPhong.Size = new System.Drawing.Size(78, 30);
            this.txtSoPhong.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(590, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 50);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbTongSoPhong
            // 
            this.lbTongSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongSoPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTongSoPhong.Location = new System.Drawing.Point(727, 28);
            this.lbTongSoPhong.Name = "lbTongSoPhong";
            this.lbTongSoPhong.Size = new System.Drawing.Size(185, 28);
            this.lbTongSoPhong.TabIndex = 0;
            this.lbTongSoPhong.Text = "Tổng Số Phòng:";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(893, 484);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 50);
            this.btnThoat.TabIndex = 28;
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
            this.dgvPhong.Location = new System.Drawing.Point(9, 134);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(1012, 344);
            this.dgvPhong.TabIndex = 32;
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
            this.MaLoaiPhong.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
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
            this.MaHopDong.MinimumWidth = 100;
            this.MaHopDong.Name = "MaHopDong";
            this.MaHopDong.Width = 125;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::QuanLyKhachSan.Properties.Resources.dual_screen;
            this.pictureBox6.Location = new System.Drawing.Point(839, 484);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 33;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyKhachSan.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(9, 484);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // PhongTheoLoaiPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.lbQuanLyPhongTheoLoaiPhong);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhongTheoLoaiPhongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng Theo Loại Phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhongTheoLoaiPhongForm_FormClosing);
            this.Load += new System.EventHandler(this.PhongTheoLoaiPhongForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbQuanLyPhongTheoLoaiPhong;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label lbChonLoaiPhong;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbTongSoPhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNguoi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PhongTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHopDong;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxFilter;
    }
}