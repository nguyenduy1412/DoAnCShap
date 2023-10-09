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
    public partial class PhieuNhap : Form
    {
        public PhieuNhap()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void getBook()
        {
            string query = string.Format("SELECT * FROM BOOK");
            DataTable tb = kn.layDuLieu(query);
            dgvBook.DataSource = tb;
        }
        public void getKho()
        {
            string query = string.Format("SELECT bookId,quantity FROM Kho");
            DataTable tb = kn.layDuLieu(query);
            dgvKho.DataSource = tb;
        }
        public void getPhieuNhap()
        {
            string query = string.Format("select * from phieunhap order by id desc");
            DataTable tb = kn.layDuLieu(query);
            dgvPhieuNhap.DataSource = tb;
        }
        public void getCTPN()
        {
            string query = string.Format("SELECT * FROM chitietphieunhap where maphieunhap={0}", lbMaPN.Text);
            DataTable tb = kn.layDuLieu(query);
            dgvCTPN.DataSource = tb;
        }
        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            getBook();
            getKho();
            getPhieuNhap();

        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtBookId.Text =dgvBook.Rows[r].Cells["id"].Value.ToString();
                txtBookName.Text =dgvBook.Rows[r].Cells["bookName"].Value.ToString();
                double gia = int.Parse(dgvBook.Rows[r].Cells["price"].Value.ToString());
                txtGia.Text=(gia / 1.2).ToString();

                /*  txtBookId.Text =dgvBook.Rows[r].Cells["id"].Value.ToString();*/
                try
                {
                    ptrAnh.Image=Image.FromFile(dgvBook.Rows[r].Cells["img"].Value.ToString());
                }
                catch { }
                /* btnSua.Enabled=true;
                 btnXoa.Enabled=true;
                 txtGia.Enabled=true;
                 btnThem.Enabled=false;*/

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtBookId.Text="";
            txtBookName.Text="";
            txtSoLuong.Text="1";
            txtGia.Text="0";
        }



        private void btnPN_Click(object sender, EventArgs e)
        {
            string query = string.Format("INSERT INTO phieunhap(tiennhap) values(0)");
            kn.thucThi(query);

            getPhieuNhap();
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                lbMaPN.Text =dgvPhieuNhap.Rows[r].Cells["id"].Value.ToString();
                try
                {

                    dtpNgayNhap.Value =(DateTime)dgvPhieuNhap.Rows[r].Cells["ngaynhap"].Value;
                    lbTienNhap.Text =dgvPhieuNhap.Rows[r].Cells["tiennhap"].Value.ToString();
                }
                catch { }



            }
        }

        private void lbMaPN_TextChanged(object sender, EventArgs e)
        {
            if (lbMaPN.Text.Length > 0)
            {
                getCTPN();
                btnLapPN.Enabled=true;
                btnThem.Enabled=true;
            }
            else
            {
                btnLapPN.Enabled=false;
                btnThem.Enabled=false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // thêm phiếu nhập
            string query = string.Format("INSERT INTO chitietphieunhap(maphieunhap,soluong,gia,bookId) values({0},{1},{2},{3})",
                lbMaPN.Text,
                txtSoLuong.Text,
                txtGia.Text,
                txtBookId.Text
                );
            // kiểm tra xem sách đã có trong phiếu nhập chưa nếu có thì cập nhật lại số lượng
            string checkBook = string.Format("SELECT * FROM chitietphieunhap where maphieunhap={0} and bookId={1}", lbMaPN.Text, txtBookId.Text);
           
            DataTable tb = kn.layDuLieu(checkBook);
            if (tb.Rows.Count>0)
            {
                int soluong = int.Parse(tb.Rows[0]["soluong"].ToString());
                soluong += int.Parse(txtSoLuong.Text);
                query=string.Format("update chitietphieunhap set soluong={0}  where maphieunhap={1} and bookId={2}", soluong, lbMaPN.Text, txtBookId.Text);
            }
            //cập nhật lại giá bán
            double gia = int.Parse(txtGia.Text) * 1.2;
            //lấy sale 
            string salee = string.Format("select sale from book where id={0}", txtBookId.Text);
            int sale = int.Parse(kn.layBien(salee));
            double giaSale=gia - ( gia * sale)/100;
            string queryGia = string.Format("update BOOK SET price={0},priceSale={1} where id={2}", gia, giaSale, txtBookId.Text);

            if (kn.thucThi(query) && kn.thucThi(queryGia))
            {

                MessageBox.Show("Thêm thành công");
                getCTPN();
                getBook();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnLapPN_Click(object sender, EventArgs e)
        {
            string tongtien = string.Format("select sum(soluong * gia) from chitietphieunhap where maphieunhap={0}",lbMaPN.Text);
            string tiennhap = kn.layBien(tongtien);
            string query = string.Format("update phieunhap SET tiennhap={0} where id={1}", tiennhap,lbMaPN.Text);
            string updateKho;
            if (kn.thucThi(query))
            {
                int n = dgvCTPN.Rows.Count-1;

                for (int i = 0; i<n; i++)
                {
                    updateKho = string.Format("update kho set quantity={0} where bookId={1}",
                        dgvCTPN.Rows[i].Cells["soluong"].Value.ToString(),
                        dgvCTPN.Rows[i].Cells["bookId"].Value.ToString()
                        );
                    kn.thucThi(updateKho);
                }

                MessageBox.Show("Thêm phiếu nhập thành công");
                btnLamMoi.PerformClick();
                getPhieuNhap();
                getKho();
            }
            else
            {
                MessageBox.Show("Thêm phiếu nhập thất bại");
            }
        }
    }
}
