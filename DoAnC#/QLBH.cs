using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAnC_
{
    public partial class QLBH : Form
    {
        private string maPX;
        private string userName;
        private string maHD;
        public QLBH(string a)
        {
            InitializeComponent();
            userName=a;
        }
        KetNoi kn = new KetNoi();
        public void getData()
        {
            string query = string.Format("select book.id, book.bookName,book.priceSale,book.img,Publicsher.namePublicsher,CATEGORY.categoryName,AUTHOR.nameAuthor,kho.quantity\r\nfrom CATEGORY \r\njoin book on CATEGORY.id =book.categoryId\r\njoin kho on book.id =kho.bookId\r\njoin Publicsher on Publicsher.id =book.publicsherId\r\njoin AUTHOR on AUTHOR.id =book.authorId");
            DataTable tb = kn.layDuLieu(query);
            dgvBook.DataSource = tb;
            string queryCus = string.Format("select * from Customer");
            dgvCus.DataSource = kn.layDuLieu(queryCus);



            try
            {
                string queryDetail = String.Format("select * from CHITIETHOADON where mahd={0}", maHD);
                dgvDetailHD.DataSource = kn.layDuLieu(queryDetail);

            }
            catch
            {

            }


        }
        private void QLBH_Load(object sender, EventArgs e)
        {
            string query = string.Format("select USERs.id, USERS.fullName from users where userName='{0}'", userName);
            DataTable tb = kn.layDuLieu(query);
            txtMaNV.Text = tb.Rows[0]["id"].ToString();
            txtTenNV.Text=tb.Rows[0]["fullName"].ToString();
            lbNameNV.Text=tb.Rows[0]["fullName"].ToString();
            getData();
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {

                txtBookName.Text = dgvBook.Rows[r].Cells["bookName"].Value.ToString();
                txtBookId.Text = dgvBook.Rows[r].Cells["id"].Value.ToString();
                txtAuthor.Text = dgvBook.Rows[r].Cells["nameAuthor"].Value.ToString();
                txtQuantity.Text = "1";
                txtSumMoney.Text=dgvBook.Rows[r].Cells["priceSale"].Value.ToString();
                try
                {
                    ptrAnh.Image=Image.FromFile(dgvBook.Rows[r].Cells["img"].Value.ToString());
                }
                catch { }


            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            string query = String.Format("select priceSale from book where id='{0}'", txtBookId.Text);
            DataTable tb = kn.layDuLieu(query);

            try
            {
                int gia = int.Parse(tb.Rows[0]["priceSale"].ToString());
                int soluong = int.Parse(txtQuantity.Text);
                if (soluong > 0)
                    txtSumMoney.Text = (gia * soluong).ToString();
                else
                {
                    txtSumMoney.Text="0";
                }
            }
            catch
            {
                txtSumMoney.Text="0";
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //lay thong tin khách hàng xem có hay chưa nếu chưa có thì thêm
            string check = String.Format("select * from CUSTOMER where sdt='{0}'", txtPhone.Text);
            DataTable tb = kn.layDuLieu(check);
            if (tb.Rows.Count == 0)
            {
                string query = String.Format("insert into CUSTOMER values('{0}',N'{1}',N'{2}')",
                txtPhone.Text,
                txtCustomName.Text,
                txtAddress.Text
                );
                // them khach hang thi them luon hoa don
                string queryHD = string.Format("insert into HoaDon(sdtCus) values('{0}')", txtPhone.Text);
                bool kt = kn.thucThi(query);
                kt=kn.thucThi(queryHD);

                if (kt==false)
                {
                    MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    btnLamMoi.PerformClick();
                }
            }

            // lay mahd 
            string queryMaHD = string.Format("select * from hoadon where sdtCus={0}", txtPhone.Text);
            maHD = kn.layBien(queryMaHD);
            // them sach vao chi tiet hoa don khi co mahd
            //kiem tra san pham co chua

            string queryCheck = string.Format("select * from CHITIETHOADON where bookId={0} and mahd={1}",
                txtBookId.Text,
                maHD);
            //th1 san pham bi trung cap nhat lai so luong
            string queryThemHD;
            if (kn.layDuLieu(queryCheck).Rows.Count >0)
            {
                queryThemHD=string.Format("update CHITIETHOADON set quantity=quantity + {0} where bookId={1} and mahd={2}",
                    txtQuantity.Text,
                    txtBookId.Text,
                    maHD
                    );
            }
            //TH2 san pham k bi trung them moi
            else
            {
                queryThemHD = String.Format("insert into CHITIETHOADON (bookId,mahd,quantity) values({0},{1},{2})",
                   txtBookId.Text,
                   maHD,
                   txtQuantity.Text);
            }
            //thuc hien them
            if (kn.thucThi(queryThemHD))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            // lay tat ca sach co trong hoa don cua khach hang
            string queryCTHD = string.Format("select * from CHITIETHOADON where mahd={0}", maHD);
            DataTable tbCTHD = kn.layDuLieu(queryCTHD);
            dgvDetailHD.DataSource = tbCTHD;




            string queryTongTien = String.Format("SELECT  SUM(b.price * c.quantity) AS tongTien ,c.mahd\r\nFROM chitiethoadon c\r\nJOIN Book b ON c.bookId = b.id\r\nwhere c.mahd={0}\r\nGROUP BY c.mahd",
                tbCTHD.Rows[0]["mahd"].ToString());
            DataTable tbTongTien = kn.layDuLieu(queryTongTien);
            lbThanhTien.Text=tbTongTien.Rows[0][0].ToString();
            getData();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string query = String.Format("select customerName,addresss from CUSTOMER where sdt='{0}'", txtPhone.Text);
            DataTable tb = kn.layDuLieu(query);
            try
            {
                txtCustomName.Text=tb.Rows[0]["customerName"].ToString();
                txtAddress.Text=tb.Rows[0]["addresss"].ToString();
            }
            catch
            {
                txtAddress.Text="";
                txtCustomName.Text="";
            }
            getData();
        }

        private void lbNameNV_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            bool kt = false;
            bool kt1 = false;
            // lấy danh sách các sản phẩm trong bảng chi tiết hóa đơn
            string qureryDetail = String.Format("select * from CHITIETHOADON where mahd={0}", maHD);
            DataTable tbDetail = kn.layDuLieu(qureryDetail);
            for (int i = 0; i<tbDetail.Rows.Count; i++)
            {
                String querySoluongKho = String.Format("select quantity from kho where bookId={0}", tbDetail.Rows[i]["bookId"].ToString());
                int soluongKho = int.Parse(kn.layBien(querySoluongKho));
                int soluongDat = int.Parse(tbDetail.Rows[i]["quantity"].ToString());
                // nếu có 1 sản phẩm vượt quá số lượng kho thì hủy
                if (soluongDat > soluongKho)
                {
                    string queryDeleteDetail = String.Format("delete from CHITIETHOADON where id={0}", tbDetail.Rows[i]["id"].ToString());
                    kn.thucThi(queryDeleteDetail);
                    kt=true;

                }
            }
            if (kt)
            {
                MessageBox.Show("Số lượng sách trong kho không đủ vui lòng đặt lại số lượng");
            }
            else
            {
                for (int i = 0; i<tbDetail.Rows.Count; i++)
                {
                    String querySoluongKho = String.Format("select quantity from kho where bookId={0}", tbDetail.Rows[i]["bookId"].ToString());
                    int soluongKho = int.Parse(kn.layBien(querySoluongKho));
                    int soluongDat = int.Parse(tbDetail.Rows[i]["quantity"].ToString());
                    int soLuongKhoUpdate = soluongKho-soluongDat;
                    String queryUpdateKho = String.Format("update kho set quantity={0} where bookId={1}", soLuongKhoUpdate, tbDetail.Rows[i]["bookId"].ToString());
                    kt1=kn.thucThi(queryUpdateKho);

                }

                string queryPX = String.Format("INSERT INTO PhieuXuat(userId,sumMoney,sdtCustomer) values({0},{1},'{2}')",
                    txtMaNV.Text,
                    lbThanhTien.Text,
                    txtPhone.Text
                    );

                if (kn.thucThi(queryPX)==false && kt1==false)
                {
                    MessageBox.Show("Loi");
                }
                else
                {
                    string MAPX = string.Format("SELECT * FROM PhieuXuat where userId={0} and sdtCustomer={1}",
                        txtMaNV.Text,
                        txtPhone.Text

                        );
                    maPX=kn.layBien(MAPX);
                    // lưu tất cả các chi tiet hóa đơn vào phiếu xuất
                    for (int i = 0; i<tbDetail.Rows.Count; i++)
                    {
                        string Gia = kn.layBien(string.Format("select price from book where id={0}", tbDetail.Rows[i]["bookId"]));
                        string queryCTPX = string.Format("insert into ChiTietPhieuXuat (bookId,maphieuxuat,quantity,price) values({0},{1},{2},{3})",
                            tbDetail.Rows[i]["bookId"].ToString(),
                            maPX,
                            tbDetail.Rows[i]["quantity"].ToString(),
                            Gia
                            );
                        kn.thucThi(queryCTPX);
                    }
                    //xóa tất cả các sản phẩm
                    string deleteCTHD = string.Format("delete from CHITIETHOADON where mahd={0}", maHD);
                    kn.thucThi(deleteCTHD);

                    MessageBox.Show("Đặt hàng thành công");

                }
            }

            getData();

        }

        private void dgvCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                try
                {
                    txtPhone.Text = dgvCus.Rows[r].Cells["sdt"].Value.ToString();
                    txtPhoneCus.Text=dgvCus.Rows[r].Cells["sdt"].Value.ToString();
                    txtNameCus.Text=dgvCus.Rows[r].Cells["customerName"].Value.ToString();
                    txtAddressCus.Text=dgvCus.Rows[r].Cells["addresss"].Value.ToString();
                    // lay mahd 
                    string queryMaHD = string.Format("select * from hoadon where sdtCus={0}", txtPhone.Text);
                    maHD = kn.layBien(queryMaHD);
                    string queryCTHD = string.Format("select * from CHITIETHOADON where mahd={0}", maHD);
                    DataTable tbCTHD = kn.layDuLieu(queryCTHD);
                    dgvDetailHD.DataSource = tbCTHD;
                    string queryTongTien = String.Format("SELECT  SUM(b.price * c.quantity) AS tongTien ,c.mahd\r\nFROM chitiethoadon c\r\nJOIN Book b ON c.bookId = b.id\r\nwhere c.mahd={0}\r\nGROUP BY c.mahd",
                    tbCTHD.Rows[0]["mahd"].ToString());
                    DataTable tbTongTien = kn.layDuLieu(queryTongTien);
                    lbThanhTien.Text=tbTongTien.Rows[0][0].ToString();
                }
                catch(Exception ex)
                { 
                    
                    lbThanhTien.Text="0";
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void dgvDetailHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                try
                {
                    lbMaCTHD.Text=dgvDetailHD.Rows[r].Cells["id"].Value.ToString();
                    txtSoLuongCTHD.Text=dgvDetailHD.Rows[r].Cells["quantity"].Value.ToString();
                   
                }
                catch { }
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
            txtQuantity.Text="1";
            txtAuthor.Text="";
            txtSumMoney.Text="0";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("delete from chitiethoadon where id={0}", lbMaCTHD.Text);
                if (kn.thucThi(query))
                {
                    MessageBox.Show("Xóa thành công");
                    btnLamMoi.PerformClick();
                    getData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }

            }
            catch { }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("update CHITIETHOADON set quantity= {0} where id={1}",
                    txtSoLuongCTHD.Text,
                    lbMaCTHD.Text
                    
                    );
                if (kn.thucThi(query))
                {
                    MessageBox.Show("Sửa thành công");
                    btnLamMoi.PerformClick();
                    getData();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }

            }
            catch { }
        }
    }
}
