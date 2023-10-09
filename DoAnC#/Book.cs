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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void getData()
        {
            string query = string.Format("SELECT * FROM BOOK");
            DataTable tb = kn.layDuLieu(query);
            dgvBook.DataSource = tb;


        }
        public void getTacGia()
        {
            string query = "select * from AUTHOR";
            DataTable tb = kn.layDuLieu(query);
            cmbTacGia.DataSource = tb;
            cmbTacGia.DisplayMember = "nameAuthor";
            cmbTacGia.ValueMember = "id";
        }
        public void getNXB()
        {
            string query = "select * from Publicsher";
            DataTable tb = kn.layDuLieu(query);
            cmbNXB.DataSource = tb;
            cmbNXB.DisplayMember = "namePublicsher";
            cmbNXB.ValueMember = "id";
        }
        public void getDanhMuc()
        {
            string query = "select * from CATEGORY";
            DataTable tb = kn.layDuLieu(query);
            cmbDanhMuc.DataSource = tb;
            cmbDanhMuc.DisplayMember = "categoryName";
            cmbDanhMuc.ValueMember = "id";
        }
        private void Book_Load(object sender, EventArgs e)
        {
            getData();
            getTacGia();
            getNXB();
            getDanhMuc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {


            // Kiểm tra xem đường dẫn ảnh có hợp lệ không
            if (string.IsNullOrEmpty(duongDanAnh))
            {
                MessageBox.Show("Vui lòng chọn ảnh trước khi thêm.");
                return; // Ngăn việc tiếp tục thực hiện truy vấn
            }
            string query = String.Format("INSERT INTO BOOK(bookName,authorId,publicsherId,price,priceSale,sale,img,categoryId,namxb) values(N'{0}',{1},{2},0,0,{3},'{4}',{5},{6})",
               txtBookName.Text,
               cmbTacGia.SelectedValue,
               cmbNXB.SelectedValue,
               txtSale.Text,
               duongDanAnh,
               cmbDanhMuc.SelectedValue,
               txtNamXB.Text
               );
            // thêm sách vào kho

            if (kn.thucThi(query))
            {
                string query1 = "SELECT * FROM BOOK ORDER BY id DESC";
                string bookId = kn.layBien(query1);
                string query2 = string.Format("insert into kho(bookId) values({0})", bookId);
                if (kn.thucThi(query2))
                {
                    MessageBox.Show("Thêm thành công");
                    btnLamMoi.PerformClick();
                }

            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            getData();
        }
        private string duongDanAnh = "";
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter ="File anh|*.jpg;*.png;";
            if (openFileDialog.ShowDialog() ==DialogResult.OK)
            {
                duongDanAnh = openFileDialog.FileName;
                ptrAnh.Image=Image.FromFile(duongDanAnh);
            }
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtBookId.Text =dgvBook.Rows[r].Cells["id"].Value.ToString();
                txtBookName.Text =dgvBook.Rows[r].Cells["bookName"].Value.ToString();
                cmbDanhMuc.SelectedValue =dgvBook.Rows[r].Cells["categoryId"].Value;
                cmbNXB.SelectedValue =dgvBook.Rows[r].Cells["publicsherId"].Value;
                cmbTacGia.SelectedValue =dgvBook.Rows[r].Cells["authorId"].Value;
                txtSale.Text =dgvBook.Rows[r].Cells["sale"].Value.ToString();
                txtGia.Text =dgvBook.Rows[r].Cells["price"].Value.ToString();
                txtNamXB.Text =dgvBook.Rows[r].Cells["namxb"].Value.ToString();
                /*  txtBookId.Text =dgvBook.Rows[r].Cells["id"].Value.ToString();*/
                try
                {
                    ptrAnh.Image=Image.FromFile(dgvBook.Rows[r].Cells["img"].Value.ToString());
                }
                catch { }
                btnSua.Enabled=true;
                btnXoa.Enabled=true;
                txtGia.Enabled=true;
                btnThem.Enabled=false;

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnSua.Enabled=false;
            btnXoa.Enabled=false;
            btnThem.Enabled = true;
            btnLamMoi.Enabled = true;
            txtBookId.Text="";
            txtBookName.Text="";
            txtSale.Text="";
            txtGia.Text="";
            txtGiaSale.Text="";
            txtNamXB.Text="";
            txtSale.Text="";
            txtGia.Enabled=false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query;
            if (string.IsNullOrEmpty(duongDanAnh))
            {
                query = String.Format("update Book SET bookName=N'{0}',authorId={1},publicsherId={2},price={3},priceSale={4},sale={5},categoryId={6},namxb={7} where id={8}",
               txtBookName.Text,
               cmbTacGia.SelectedValue,
               cmbNXB.SelectedValue,
               txtGia.Text,
               txtGiaSale.Text,
               txtSale.Text,
               cmbDanhMuc.SelectedValue,
               txtNamXB.Text,
               txtBookId.Text
               );
            }
            else
            {
                query = String.Format("update Book SET bookName=N'{0}',authorId={1},publicsherId={2},price={3},priceSale={4},sale={5},img=N'{6}',categoryId={7},namxb={8} where id={9}",
               txtBookName.Text,
               cmbTacGia.SelectedValue,
               cmbNXB.SelectedValue,
               txtGia.Text,
               txtGiaSale.Text,
               txtSale.Text,
               duongDanAnh,
               cmbDanhMuc.SelectedValue,
               txtNamXB.Text,
               txtBookId.Text
               );
            }


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

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int gia = int.Parse(txtGia.Text.ToString());
                int sale = int.Parse(txtSale.Text.ToString());
                double giasale = gia - gia*sale*0.01;
                txtGiaSale.Text=giasale.ToString();
            }
            catch
            {
                txtGiaSale.Text="0";

            }
        }

        private void txtSale_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int gia = int.Parse(txtGia.Text.ToString());
                int sale = int.Parse(txtSale.Text.ToString());
                double giasale = gia - gia*(sale*0.01);
                txtGiaSale.Text=giasale.ToString();

            }
            catch
            {
                txtGiaSale.Text="0";

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = String.Format("DELETE FROM Book where id={0}", txtBookId.Text);
            string xoaKho = String.Format("delete from kho where bookId={0}", txtBookId.Text);
            if (kn.thucThi(xoaKho) &&  kn.thucThi(query))
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
            string query = string.Format("SELECT * FROM Book where bookName like N'%{0}%'", txtSearch.Text);
            DataTable tb = kn.layDuLieu(query);
            dgvBook.DataSource = tb;
        }
    }
}
