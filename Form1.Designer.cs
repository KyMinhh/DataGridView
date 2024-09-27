namespace DataGirldView
{
    partial class frmDGV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvNhanVien = new DataGridView();
            colMSNV = new DataGridViewTextBoxColumn();
            colTenNV = new DataGridViewTextBoxColumn();
            colLuong = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnDong = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToOrderColumns = true;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BorderStyle = BorderStyle.Fixed3D;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { colMSNV, colTenNV, colLuong });
            dgvNhanVien.Location = new Point(29, 16);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 62;
            dgvNhanVien.Size = new Size(606, 395);
            dgvNhanVien.TabIndex = 0;
            // 
            // colMSNV
            // 
            colMSNV.HeaderText = "MSNV";
            colMSNV.MinimumWidth = 8;
            colMSNV.Name = "colMSNV";
            // 
            // colTenNV
            // 
            colTenNV.HeaderText = "Tên NV";
            colTenNV.MinimumWidth = 8;
            colTenNV.Name = "colTenNV";
            // 
            // colLuong
            // 
            colLuong.HeaderText = "Lương CB";
            colLuong.MinimumWidth = 8;
            colLuong.Name = "colLuong";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(676, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(676, 78);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(676, 144);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(676, 222);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(112, 34);
            btnDong.TabIndex = 4;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // frmDGV
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDong);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvNhanVien);
            Name = "frmDGV";
            Text = "DataGridView";
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvNhanVien;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnDong;
        private DataGridViewTextBoxColumn colMSNV;
        private DataGridViewTextBoxColumn colTenNV;
        private DataGridViewTextBoxColumn colLuong;
    }
}
