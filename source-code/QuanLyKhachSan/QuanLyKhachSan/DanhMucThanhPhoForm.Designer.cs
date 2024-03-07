namespace QuanLyKhachSan
{
    partial class DanhMucThanhPhoForm
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
            this.lbDanhMucThanhPho = new System.Windows.Forms.Label();
            this.dgvThanhPho = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.MaThanhPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThanhPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhPho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDanhMucThanhPho
            // 
            this.lbDanhMucThanhPho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhMucThanhPho.ForeColor = System.Drawing.Color.Red;
            this.lbDanhMucThanhPho.Location = new System.Drawing.Point(194, 19);
            this.lbDanhMucThanhPho.Name = "lbDanhMucThanhPho";
            this.lbDanhMucThanhPho.Size = new System.Drawing.Size(346, 37);
            this.lbDanhMucThanhPho.TabIndex = 1;
            this.lbDanhMucThanhPho.Text = "Danh Mục Thành Phố";
            // 
            // dgvThanhPho
            // 
            this.dgvThanhPho.AllowUserToAddRows = false;
            this.dgvThanhPho.AllowUserToDeleteRows = false;
            this.dgvThanhPho.AllowUserToResizeColumns = false;
            this.dgvThanhPho.AllowUserToResizeRows = false;
            this.dgvThanhPho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhPho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThanhPho,
            this.TenThanhPho});
            this.dgvThanhPho.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvThanhPho.Location = new System.Drawing.Point(12, 68);
            this.dgvThanhPho.Name = "dgvThanhPho";
            this.dgvThanhPho.RowHeadersWidth = 51;
            this.dgvThanhPho.RowTemplate.Height = 24;
            this.dgvThanhPho.Size = new System.Drawing.Size(732, 228);
            this.dgvThanhPho.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(616, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 50);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::QuanLyKhachSan.Properties.Resources.dual_screen;
            this.pictureBox6.Location = new System.Drawing.Point(562, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // MaThanhPho
            // 
            this.MaThanhPho.DataPropertyName = "MaThanhPho";
            this.MaThanhPho.HeaderText = "Mã Thành Phố";
            this.MaThanhPho.MinimumWidth = 250;
            this.MaThanhPho.Name = "MaThanhPho";
            this.MaThanhPho.Width = 250;
            // 
            // TenThanhPho
            // 
            this.TenThanhPho.DataPropertyName = "TenThanhPho";
            this.TenThanhPho.HeaderText = "Tên Thành Phố";
            this.TenThanhPho.MinimumWidth = 250;
            this.TenThanhPho.Name = "TenThanhPho";
            this.TenThanhPho.Width = 250;
            // 
            // DanhMucThanhPhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 305);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvThanhPho);
            this.Controls.Add(this.lbDanhMucThanhPho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DanhMucThanhPhoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Thành Phố";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DanhMucThanhPhoForm_FormClosing);
            this.Load += new System.EventHandler(this.DanhMucThanhPhoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhPho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDanhMucThanhPho;
        private System.Windows.Forms.DataGridView dgvThanhPho;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThanhPho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThanhPho;
    }
}