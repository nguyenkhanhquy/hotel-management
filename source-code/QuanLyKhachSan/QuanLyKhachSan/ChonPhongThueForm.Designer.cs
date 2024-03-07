namespace QuanLyKhachSan
{
    partial class ChonPhongThueForm
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
            this.btnXong = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiPhong = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongTrong = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbChonPhongThue = new System.Windows.Forms.Label();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.lbMaHopDong = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXong
            // 
            this.btnXong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXong.Location = new System.Drawing.Point(830, 410);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(128, 50);
            this.btnXong.TabIndex = 21;
            this.btnXong.Text = "Xong";
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(613, 410);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(128, 50);
            this.btnChon.TabIndex = 28;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
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
            this.dgvPhong.Size = new System.Drawing.Size(946, 288);
            this.dgvPhong.TabIndex = 31;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.Frozen = true;
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 110;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 110;
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
            this.PhongTrong.MinimumWidth = 95;
            this.PhongTrong.Name = "PhongTrong";
            this.PhongTrong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PhongTrong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PhongTrong.TrueValue = "1";
            this.PhongTrong.Width = 95;
            // 
            // MaHopDong
            // 
            this.MaHopDong.DataPropertyName = "MaHopDong";
            this.MaHopDong.HeaderText = "Mã Hợp Đồng";
            this.MaHopDong.MinimumWidth = 100;
            this.MaHopDong.Name = "MaHopDong";
            this.MaHopDong.Width = 125;
            // 
            // lbChonPhongThue
            // 
            this.lbChonPhongThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChonPhongThue.ForeColor = System.Drawing.Color.Red;
            this.lbChonPhongThue.Location = new System.Drawing.Point(360, 21);
            this.lbChonPhongThue.Name = "lbChonPhongThue";
            this.lbChonPhongThue.Size = new System.Drawing.Size(295, 40);
            this.lbChonPhongThue.TabIndex = 32;
            this.lbChonPhongThue.Text = "Chọn Phòng Thuê";
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHopDong.ForeColor = System.Drawing.Color.Red;
            this.txtMaHopDong.Location = new System.Drawing.Point(495, 64);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.ReadOnly = true;
            this.txtMaHopDong.Size = new System.Drawing.Size(160, 30);
            this.txtMaHopDong.TabIndex = 34;
            // 
            // lbMaHopDong
            // 
            this.lbMaHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHopDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbMaHopDong.Location = new System.Drawing.Point(320, 67);
            this.lbMaHopDong.Name = "lbMaHopDong";
            this.lbMaHopDong.Size = new System.Drawing.Size(169, 28);
            this.lbMaHopDong.TabIndex = 33;
            this.lbMaHopDong.Text = "Mã Hợp Đồng:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QuanLyKhachSan.Properties.Resources.device_floppy;
            this.pictureBox4.Location = new System.Drawing.Point(776, 410);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyKhachSan.Properties.Resources.checkbox;
            this.pictureBox2.Location = new System.Drawing.Point(559, 410);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyKhachSan.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(12, 410);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.Location = new System.Drawing.Point(66, 410);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(128, 50);
            this.btnReload.TabIndex = 37;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // ChonPhongThueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtMaHopDong);
            this.Controls.Add(this.lbMaHopDong);
            this.Controls.Add(this.lbChonPhongThue);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnXong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChonPhongThueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Phòng Thuê";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChonPhongThueForm_FormClosing);
            this.Load += new System.EventHandler(this.ChonPhongThueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXong;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label lbChonPhongThue;
        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.Label lbMaHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNguoi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PhongTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHopDong;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReload;
    }
}