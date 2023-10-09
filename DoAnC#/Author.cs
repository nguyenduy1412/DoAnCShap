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
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void getData()
        {
            string query = string.Format("SELECT * FROM AUTHOR");
            DataTable tb = kn.layDuLieu(query);
            dgvTacGia.DataSource = tb;


        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = String.Format("INSERT INTO AUTHOR(nameAuthor) values(N'{0}')", txtTenTacGia.Text);

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
            txtTenTacGia.Text="";
            txtMaTacGia.Text="";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = String.Format("DELETE FROM AUTHOR where id={0}", txtMaTacGia.Text);

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = String.Format("update AUTHOR SET nameAuthor=N'{0}' where id={1}", txtTenTacGia.Text, txtMaTacGia.Text);

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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM AUTHOR where nameAuthor like N'%{0}%'", txtSearch.Text);
            DataTable tb = kn.layDuLieu(query);
            dgvTacGia.DataSource = tb;
        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaTacGia.Text = dgvTacGia.Rows[r].Cells["id"].Value.ToString();
                txtTenTacGia.Text = dgvTacGia.Rows[r].Cells["nameAuthor"].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

            }
        }

        private void Author_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
