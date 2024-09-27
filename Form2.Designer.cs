namespace DataGirldView
{
    partial class Form2
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
            lblMSNV = new Label();
            lblTen = new Label();
            lblLuong = new Label();
            tbMSNV = new TextBox();
            tbTen = new TextBox();
            tbLuong = new TextBox();
            btnDongY = new Button();
            btnBoQua = new Button();
            SuspendLayout();
            // 
            // lblMSNV
            // 
            lblMSNV.AutoSize = true;
            lblMSNV.Location = new Point(96, 45);
            lblMSNV.Name = "lblMSNV";
            lblMSNV.Size = new Size(62, 25);
            lblMSNV.TabIndex = 0;
            lblMSNV.Text = "MSNV";
            // 
            // lblTen
            // 
            lblTen.Location = new Point(96, 135);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(191, 36);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên Nhân Viên";
            // 
            // lblLuong
            // 
            lblLuong.Location = new Point(96, 230);
            lblLuong.Name = "lblLuong";
            lblLuong.Size = new Size(191, 36);
            lblLuong.TabIndex = 2;
            lblLuong.Text = "Lương Căn Bản";
            // 
            // tbMSNV
            // 
            tbMSNV.Location = new Point(191, 45);
            tbMSNV.Name = "tbMSNV";
            tbMSNV.Size = new Size(228, 31);
            tbMSNV.TabIndex = 3;
            // 
            // tbTen
            // 
            tbTen.Location = new Point(241, 140);
            tbTen.Name = "tbTen";
            tbTen.Size = new Size(440, 31);
            tbTen.TabIndex = 4;
            // 
            // tbLuong
            // 
            tbLuong.Location = new Point(265, 227);
            tbLuong.Name = "tbLuong";
            tbLuong.Size = new Size(228, 31);
            tbLuong.TabIndex = 5;
            // 
            // btnDongY
            // 
            btnDongY.Location = new Point(212, 319);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(112, 34);
            btnDongY.TabIndex = 6;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(381, 319);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(112, 34);
            btnBoQua.TabIndex = 7;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBoQua);
            Controls.Add(btnDongY);
            Controls.Add(tbLuong);
            Controls.Add(tbTen);
            Controls.Add(tbMSNV);
            Controls.Add(lblLuong);
            Controls.Add(lblTen);
            Controls.Add(lblMSNV);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMSNV;
        private Label lblTen;
        private Label lblLuong;
        private TextBox tbMSNV;
        private TextBox tbTen;
        private TextBox tbLuong;
        private Button btnDongY;
        private Button btnBoQua;
    }
}