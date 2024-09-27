using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGirldView
{
    public partial class Form2 : Form
    {
        public string MSNV { get; set; }
        public string HoTenNV { get; set; }
        public string Luong { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            // Lưu thông tin nhập từ các TextBox
            MSNV = tbMSNV.Text;
            HoTenNV = tbTen.Text;
            Luong = tbLuong.Text;

            // Kiểm tra các trường nhập liệu
            if (string.IsNullOrWhiteSpace(MSNV) || string.IsNullOrWhiteSpace(HoTenNV) || string.IsNullOrWhiteSpace(Luong))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            DialogResult = DialogResult.OK; // Trả về OK để Form1 biết dữ liệu đã được nhập thành công
            this.Close();
        }

        //Khi form được mở lại để sửa thông tin thì load dữ liệu các thuộc tính
        private void Form2_Load(object sender, EventArgs e)
        {
            tbMSNV.Text = MSNV;
            tbTen.Text = HoTenNV;
            tbLuong.Text = Luong;
        }
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
