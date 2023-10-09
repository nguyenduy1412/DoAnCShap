namespace DoAnC_
{
    partial class DanhMuc
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
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvCategory = new DataGridView();
            label3 = new Label();
            txtNameCategory = new TextBox();
            groupBox2 = new GroupBox();
            btnSua = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            groupBox3 = new GroupBox();
            label2 = new Label();
            txtMaDM = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvCategory);
            groupBox1.Location = new Point(348, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 305);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh mục";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(68, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(256, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm";
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(6, 81);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.Size = new Size(328, 207);
            dgvCategory.TabIndex = 0;
            dgvCategory.CellClick += dgvCategory_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 95);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên danh mục";
            // 
            // txtNameCategory
            // 
            txtNameCategory.Location = new Point(126, 92);
            txtNameCategory.Name = "txtNameCategory";
            txtNameCategory.Size = new Size(156, 23);
            txtNameCategory.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnLamMoi);
            groupBox2.Location = new Point(12, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 127);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnSua
            // 
            btnSua.Enabled = false;
            btnSua.Location = new Point(21, 74);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(96, 42);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(21, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(96, 42);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Location = new Point(186, 74);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(96, 42);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(186, 26);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(96, 42);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtMaDM);
            groupBox3.Controls.Add(txtNameCategory);
            groupBox3.Location = new Point(12, 176);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(323, 163);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin danh mục";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 45);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã danh mục";
            // 
            // txtMaDM
            // 
            txtMaDM.Enabled = false;
            txtMaDM.Location = new Point(126, 42);
            txtMaDM.Name = "txtMaDM";
            txtMaDM.Size = new Size(156, 23);
            txtMaDM.TabIndex = 2;
            // 
            // DanhMuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 378);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "DanhMuc";
            Text = "DanhMuc";
            Load += DanhMuc_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private DataGridView dgvCategory;
        private TextBox txtSearch;
        private Label label3;
        private TextBox txtNameCategory;
        private GroupBox groupBox2;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnThem;
        private Button btnXoa;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox txtMaDM;
    }
}