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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        private string duongDanAnh = "";
        KetNoi kn = new KetNoi();
        public void getData()
        {
            string query = string.Format("SELECT USERS.*,USER_ROLE.roleId\r\nFROM USERS\r\nJOIN USER_ROLE ON USERS.id = USER_ROLE.userId\r\nJOIN ROLE ON USER_ROLE.roleId = ROLE.id");
            DataTable tb = kn.layDuLieu(query);
            dgvNhanVien.DataSource = tb;

            btnLamMoi.PerformClick();
        }
        public void getRole()
        {
            string query = "select * from ROLE";
            DataTable tb = kn.layDuLieu(query);
            cmbRole.DataSource = tb;
            cmbRole.DisplayMember = "roleName";
            cmbRole.ValueMember = "id";
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            getData();
            getRole();
        }

   

     
   

      
   

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string gender = "";
            if (rdNam.Checked)
            {
                gender = "Nam";
            }
            else
            {
                gender = "Nữ";
            }
            if (string.IsNullOrEmpty(duongDanAnh))
            {
                MessageBox.Show("Vui lòng chọn ảnh trước khi thêm.");
                return; // Ngăn việc tiếp tục thực hiện truy vấn
            }
            string query = String.Format("INSERT INTO USERS(userName,password,fullName,gender,birthday,addresss,telephone,img,email) values(N'{0}',N'{1}',N'{2}',N'{3}','{4}',N'{5}','{6}',N'{7}',N'{8}')",
               txtUserName.Text,
               txtPass.Text,
               txtFullName.Text,
               gender,
               dtpNgaySinh.Value.ToString("yyyy-MM-dd"),
               txtDiaChi.Text,
               txtSDT.Text,
               duongDanAnh,
               txtEmail.Text
               );
            if (kn.thucThi(query))
            {
                string userId = kn.layBien("SELECT * FROM USERS ORDER BY id DESC");
                string queryRole = string.Format("INSERT INTO USER_ROLE(userId,roleId) values({0},{1})",
                userId,
                cmbRole.SelectedValue);
                kn.thucThi(queryRole);
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            // thêm sách vào kho

            getData();
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            btnSua.Enabled=false;
            btnXoa.Enabled=false;
            btnThem.Enabled = true;
            btnLamMoi.Enabled = true;
            txtMaNV.Text="";
            txtFullName.Text="";
            txtDiaChi.Text="";
            txtUserName.Text="";
            txtPass.Text="";
            txtSDT.Text="";
            txtEmail.Text="";
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string query = String.Format("DELETE FROM USERS where id={0}", txtMaNV.Text);
            string xoaRole = String.Format("delete from USER_ROLE where userId={0}", txtMaNV.Text);
            if (kn.thucThi(xoaRole) &&  kn.thucThi(query))
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

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string query;
            string gender = "";
            if (rdNam.Checked)
            {
                gender = "Nam";
            }
            else
            {
                gender = "Nữ";
            }
            if (string.IsNullOrEmpty(duongDanAnh))
            {
                // nếu k chọn ảnh thì k cập nhật ảnh
                query = String.Format("UPDATE USERS SET userName=N'{0}' ,password=N'{1}' ,gender=N'{2}' ,birthday='{3}' ,addresss=N'{4}',telephone='{5}',email=N'{6}' where id ={7}",
               txtUserName.Text,
               txtPass.Text,
               gender,
               dtpNgaySinh.Value.ToString("yyyy-MM-dd"),
               txtDiaChi.Text,
               txtSDT.Text,
               txtEmail.Text,
               txtMaNV.Text
               );
            }
            else
            {
                query = String.Format("UPDATE USERS SET userName=N'{0}' ,password=N'{1}' ,gender=N'{2}' ,birthday='{3}' ,addresss=N'{4}',telephone='{5}',img=N'{6}',email=N'{7}' where id ={8}",
              txtUserName.Text,
              txtPass.Text,
              gender,
              dtpNgaySinh.Value.ToString("yyyy-MM-dd"),
              txtDiaChi.Text,
              txtSDT.Text,
              duongDanAnh,
              txtEmail.Text,
              txtMaNV.Text
              );
            }
            if (kn.thucThi(query))
            {
                string queryRole = string.Format("update USER_ROLE set roleId={0} where userId={1}",
                    cmbRole.SelectedValue,
                    txtMaNV.Text
                    );
                kn.thucThi(queryRole);
                MessageBox.Show("Sửa thành công");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            getData();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM USERS where fullName like N'%{0}%'", txtSearch.Text);
            DataTable tb = kn.layDuLieu(query);
            dgvNhanVien.DataSource = tb;
        }

        private void dgvNhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaNV.Text =dgvNhanVien.Rows[r].Cells["id"].Value.ToString();
                txtFullName.Text =dgvNhanVien.Rows[r].Cells["fullName"].Value.ToString();
                cmbRole.SelectedValue =dgvNhanVien.Rows[r].Cells["roleId"].Value;
                if (dgvNhanVien.Rows[r].Cells["gender"].Value.ToString() =="Nam")
                {
                    rdNam.Checked = true;
                }
                else { rdNu.Checked = true; }
                txtEmail.Text=dgvNhanVien.Rows[r].Cells["email"].Value.ToString();
                txtPass.Text =dgvNhanVien.Rows[r].Cells["password"].Value.ToString();
                txtDiaChi.Text =dgvNhanVien.Rows[r].Cells["addresss"].Value.ToString();
                txtSDT.Text =dgvNhanVien.Rows[r].Cells["telephone"].Value.ToString();
                txtUserName.Text =dgvNhanVien.Rows[r].Cells["userName"].Value.ToString();
                dtpNgaySinh.Value=(DateTime)dgvNhanVien.Rows[r].Cells["birthday"].Value;
                try
                {
                    ptrAnh.Image=Image.FromFile(dgvNhanVien.Rows[r].Cells["img"].Value.ToString());
                }
                catch { }
                btnSua.Enabled=true;
                btnXoa.Enabled=true;

                btnThem.Enabled=false;

            }
        }

        private void btnUpload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter ="File anh|*.jpg;*.png;";
            if (openFileDialog.ShowDialog() ==DialogResult.OK)
            {
                duongDanAnh = openFileDialog.FileName;
                ptrAnh.Image=Image.FromFile(duongDanAnh);
            }
        }
    }
}
