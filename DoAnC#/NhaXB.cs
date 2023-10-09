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
    public partial class NhaXB : Form
    {
        public NhaXB()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void getData()
        {
            string query = string.Format("SELECT * FROM Publicsher");
            DataTable tb = kn.layDuLieu(query);
            dgvNhaXB.DataSource = tb;


        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = String.Format("INSERT INTO Publicsher(namePublicsher) values(N'{0}')", txtTenNXB.Text);

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

        private void NhaXB_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = String.Format("update Publicsher SET namePublicsher=N'{0}' where id={1}", txtTenNXB.Text, txtMaNhaXB.Text);

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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtTenNXB.Text="";
            txtMaNhaXB.Text="";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = String.Format("DELETE FROM Publicsher where id={0}", txtMaNhaXB.Text);

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
            string query = string.Format("SELECT * FROM Publicsher where namePublicsher like N'%{0}%'", txtSearch.Text);
            DataTable tb = kn.layDuLieu(query);
            dgvNhaXB.DataSource = tb;
        }

        private void dgvNhaXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaNhaXB.Text = dgvNhaXB.Rows[r].Cells["id"].Value.ToString();
                txtTenNXB.Text = dgvNhaXB.Rows[r].Cells["namePublicsher"].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

            }
        }
    }
}
