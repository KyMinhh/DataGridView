using System.Xml.Linq;

namespace DataGirldView
{
    public partial class frmDGV : Form
    {
        public frmDGV()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                // Thêm dữ liệu từ Form2 vào DataGridView
                dgvNhanVien.Rows.Add(frm2.MSNV, frm2.HoTenNV, frm2.Luong);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                dgvNhanVien.Rows.RemoveAt(dgvNhanVien.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];
                Form2 frm2 = new Form2
                {
                    MSNV = selectedRow.Cells[0].Value.ToString(),
                    HoTenNV = selectedRow.Cells[1].Value.ToString(),
                    Luong = selectedRow.Cells[2].Value.ToString()
                };

                if (frm2.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật lại dữ liệu
                    selectedRow.Cells[0].Value = frm2.MSNV;
                    selectedRow.Cells[1].Value = frm2.HoTenNV;
                    selectedRow.Cells[2].Value = frm2.Luong;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
