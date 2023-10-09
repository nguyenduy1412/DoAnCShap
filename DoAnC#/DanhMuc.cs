using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnC_
{
    public partial class DanhMuc : Form
    {
        public DanhMuc()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void getData()
        {
            string query = string.Format("SELECT * FROM CATEGORY");
            DataTable tb = kn.layDuLieu(query);
            dgvCategory.DataSource = tb;


        }
        private void DanhMuc_Load(object sender, EventArgs e)
        {
            getData();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = String.Format("INSERT INTO CATEGORY(categoryName) values(N'{0}')", txtNameCategory.Text);

            if (kn.thucThi(query))
            {
                MessageBox.Show("Thêm thành công");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            getData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtNameCategory.Text="";
            txtMaDM.Text="";

        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaDM.Text = dgvCategory.Rows[r].Cells["id"].Value.ToString();
                txtNameCategory.Text = dgvCategory.Rows[r].Cells["categoryName"].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = String.Format("update CATEGORY SET categoryName=N'{0}' where id={1}", txtNameCategory.Text, txtMaDM.Text);

            if (kn.thucThi(query))
            {
                MessageBox.Show("Sửa thành công");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            getData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = String.Format("DELETE FROM CATEGORY where id={0}", txtMaDM.Text);

            if (kn.thucThi(query))
            {
                MessageBox.Show("Xóa thành công");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
            getData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM CATEGORY where categoryName like N'%{0}%'",txtSearch.Text);
            DataTable tb = kn.layDuLieu(query);
            dgvCategory.DataSource = tb;
        }
    }
}
