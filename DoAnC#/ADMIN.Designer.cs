namespace DoAnC_
{
    partial class ADMIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            tácGiảToolStripMenuItem = new ToolStripMenuItem();
            nhàXuấtBảnToolStripMenuItem = new ToolStripMenuItem();
            sáchToolStripMenuItem = new ToolStripMenuItem();
            phiếuNhậpToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { nhânViênToolStripMenuItem, danhMụcToolStripMenuItem, tácGiảToolStripMenuItem, nhàXuấtBảnToolStripMenuItem, sáchToolStripMenuItem, phiếuNhậpToolStripMenuItem, đăngXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1339, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(73, 20);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(74, 20);
            danhMụcToolStripMenuItem.Text = "Danh mục";
            danhMụcToolStripMenuItem.Click += danhMụcToolStripMenuItem_Click;
            // 
            // tácGiảToolStripMenuItem
            // 
            tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            tácGiảToolStripMenuItem.Size = new Size(55, 20);
            tácGiảToolStripMenuItem.Text = "Tác giả";
            tácGiảToolStripMenuItem.Click += tácGiảToolStripMenuItem_Click;
            // 
            // nhàXuấtBảnToolStripMenuItem
            // 
            nhàXuấtBảnToolStripMenuItem.Name = "nhàXuấtBảnToolStripMenuItem";
            nhàXuấtBảnToolStripMenuItem.Size = new Size(90, 20);
            nhàXuấtBảnToolStripMenuItem.Text = "Nhà xuất bản";
            nhàXuấtBảnToolStripMenuItem.Click += nhàXuấtBảnToolStripMenuItem_Click;
            // 
            // sáchToolStripMenuItem
            // 
            sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            sáchToolStripMenuItem.Size = new Size(44, 20);
            sáchToolStripMenuItem.Text = "Sách";
            sáchToolStripMenuItem.Click += sáchToolStripMenuItem_Click;
            // 
            // phiếuNhậpToolStripMenuItem
            // 
            phiếuNhậpToolStripMenuItem.Name = "phiếuNhậpToolStripMenuItem";
            phiếuNhậpToolStripMenuItem.Size = new Size(79, 20);
            phiếuNhậpToolStripMenuItem.Text = "Phiếu nhập";
            phiếuNhậpToolStripMenuItem.Click += phiếuNhậpToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(73, 20);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // ADMIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 686);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "ADMIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMIN";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem tácGiảToolStripMenuItem;
        private ToolStripMenuItem nhàXuấtBảnToolStripMenuItem;
        private ToolStripMenuItem sáchToolStripMenuItem;
        private ToolStripMenuItem phiếuNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}