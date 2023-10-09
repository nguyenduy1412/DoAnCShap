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
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllChildForms();
            NhanVien frm = new NhanVien();
            frm.MdiParent=this;


            frm.Show();

        }
        private void HideAllChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Hide();
            }
        }
        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllChildForms();
            DanhMuc frm = new DanhMuc();
            frm.MdiParent=this;

            frm.Show();

        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllChildForms();
            Author frm = new Author();
            frm.MdiParent=this;
            frm.Show();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllChildForms();
            NhaXB frm = new NhaXB();

            frm.MdiParent=this;
            frm.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllChildForms();
            Book frm = new Book();

            frm.MdiParent=this;
            frm.Show();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllChildForms();
            PhieuNhap frm = new PhieuNhap();

            frm.MdiParent=this;
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm=new Login();
            frm.Show();
            this.Hide();
        }
    }
}
