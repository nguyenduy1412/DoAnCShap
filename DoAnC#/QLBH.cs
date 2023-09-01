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
        private String orderId;
        private string userName;
        public QLBH(string a)
        {
            InitializeComponent();
            userName=a;
        }
        KetNoi kn = new KetNoi();
        public void getData()
        {
            string query = string.Format("select book.id, book.bookName,book.priceSale,Publicsher.namePublicsher,CATEGORY.categoryName,AUTHOR.nameAuthor,Warehouse.quantity\r\nfrom CATEGORY \r\njoin book on CATEGORY.id =book.categoryId\r\njoin Warehouse on book.id =Warehouse.bookId\r\njoin Publicsher on Publicsher.id =book.publicsherId\r\njoin AUTHOR on AUTHOR.id =book.authorId");
            DataTable tb = kn.layDuLieu(query);
            dgvBook.DataSource = tb;
            string queryCus = string.Format("select * from Customer");
            dgvCus.DataSource = kn.layDuLieu(queryCus);
            string queryLayOrder = String.Format("select * from ORDERS where dateOrder='{0}' and sdtCustomer='{1}' and userId={2}",
               dtpNgayMua.Value.ToString("yyyy-MM-dd"),
               txtPhone.Text,
               txtMaNV.Text);
            DataTable tbOrder = kn.layDuLieu(queryLayOrder);
            if(tbOrder.Rows.Count == 0)
            {
                orderId="0";
            }
            else
            {
                orderId= tbOrder.Rows[0]["id"].ToString();
            }
           
            
            try
            {
                string qureryDetail = String.Format("select bookId,quantity,price from Detail_Order where orderId={0}", orderId);
                dgvDetailOrder.DataSource=kn.layDuLieu(qureryDetail);
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
            getData();
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                /*txtMaSP.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;*/
                txtBookName.Text = dgvBook.Rows[r].Cells["bookName"].Value.ToString();
                txtBookId.Text = dgvBook.Rows[r].Cells["id"].Value.ToString();
                txtAuthor.Text = dgvBook.Rows[r].Cells["nameAuthor"].Value.ToString();
                txtQuantity.Text = "1";
                string query = string.Format("select book.*\r\nfrom CATEGORY \r\njoin book on CATEGORY.id =book.categoryId\r\njoin Warehouse on book.id =Warehouse.bookId\r\njoin Publicsher on Publicsher.id =book.publicsherId\r\njoin AUTHOR on AUTHOR.id =book.authorId");
                DataTable tb = kn.layDuLieu(query);
                try
                {
                    int gia = int.Parse(tb.Rows[r]["priceSale"].ToString());
                    txtSumMoney.Text= (gia*1).ToString();
                }
                catch
                {
                    txtSumMoney.Text="0";
                }


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
                bool kt = kn.thucThi(query);
                if (kt==false)
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            string queryLayOrder = String.Format("select * from ORDERS where dateOrder='{0}' and sdtCustomer='{1}' and userId={2}",
               dtpNgayMua.Value.ToString("yyyy-MM-dd"),
               txtPhone.Text,
               txtMaNV.Text);
            // nếu chưa có order thì thêm ngược lại thì không thêm
            if (kn.layDuLieu(queryLayOrder).Rows.Count==0)
            {
                string queryAddOrder = String.Format("insert into ORDERS(userId,sdtCustomer,dateOrder) values({0},'{1}','{2}')",
                    txtMaNV.Text,
                    txtPhone.Text,
                    dtpNgayMua.Value.ToString("yyyy-MM-dd"));
                if (kn.thucThi(queryAddOrder)==false)
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            DataTable tbOrder = kn.layDuLieu(queryLayOrder);
            orderId= tbOrder.Rows[0]["id"].ToString();
            //thêm bảng order detail
            //th1 nếu có sản phẩm rồi thì sửa số lượng 
            string queryCheckSoLuong = String.Format("select * from DETAIL_ORDER where bookId={0} and orderId={1}",txtBookId.Text,orderId);
            if(kn.layDuLieu(queryCheckSoLuong).Rows.Count >0) 
            {
                int soluong = int.Parse(txtQuantity.Text) + int.Parse( kn.layDuLieu(queryCheckSoLuong).Rows[0]["quantity"].ToString());
                int money= int.Parse(txtSumMoney.Text) + int.Parse(kn.layDuLieu(queryCheckSoLuong).Rows[0]["price"].ToString());
                
                string queryUpdateQuantity = String.Format("update DETAIL_ORDER SET quantity={0} , price={1} where orderId={2} and bookId={3}",
                    soluong,money,orderId,txtBookId.Text);
               if(kn.thucThi(queryUpdateQuantity)==false)
                {
                    MessageBox.Show("Thêm thất bại");
                }    
            }
            //nếu sản phẩm không có trong giỏ hàng thì thêm mới
            else
            {
                string queryAddOrderDetail = String.Format("insert into DETAIL_ORDER values({0},{1},{2},{3})",
                txtBookId.Text,
                orderId,
                txtQuantity.Text,
                txtSumMoney.Text);
                if (kn.thucThi(queryAddOrderDetail)==false)
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }    
            string queryTongTien = String.Format("select sum(price) from DETAIL_ORDER where orderId={0}",
                tbOrder.Rows[0]["id"].ToString());
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
            getData() ;
        }

        private void lbNameNV_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string queryUpdate = String.Format("update ORDERS SET sumMoney={0} where id={1}",
                lbThanhTien.Text,
                orderId
                );
            if (kn.thucThi(queryUpdate)==false)
            {
                MessageBox.Show("Loi");
            }

        }

        private void dgvCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtPhone.Text = dgvCus.Rows[r].Cells["sdt"].Value.ToString();
                txtPhoneCus.Text=dgvCus.Rows[r].Cells["sdt"].Value.ToString();
                txtNameCus.Text=dgvCus.Rows[r].Cells["customerName"].Value.ToString();
                txtAddressCus.Text=dgvCus.Rows[r].Cells["addresss"].Value.ToString();
            }
        }
    }
}
