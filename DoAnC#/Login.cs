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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        KetNoi kn = new KetNoi();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = string.Format("SELECT ROLE.roleName FROM USERS JOIN USER_ROLE ON USERS.id = USER_ROLE.userId JOIN ROLE ON USER_ROLE.roleId = ROLE.id where USERs.userName ='{0}' and USERs.password='{1}' ;", txtUserName.Text, txtPassword.Text);
            DataTable tb = kn.layDuLieu(query);
            if (tb.Rows.Count == 1)
            {
                string roleName = tb.Rows[0]["roleName"].ToString();
                MessageBox.Show("Đăng nhập thành công");
                QLBH frm = new QLBH(txtUserName.Text);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}
