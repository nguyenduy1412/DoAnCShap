namespace DoAnC_
{
    partial class NhaXB
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
            dgvNhaXB = new DataGridView();
            label3 = new Label();
            txtTenNXB = new TextBox();
            groupBox2 = new GroupBox();
            btnSua = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            groupBox3 = new GroupBox();
            label2 = new Label();
            txtMaNhaXB = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaXB).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvNhaXB);
            groupBox1.Location = new Point(349, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 305);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhà xuất bản";
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
            // dgvNhaXB
            // 
            dgvNhaXB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaXB.Location = new Point(6, 81);
            dgvNhaXB.Name = "dgvNhaXB";
            dgvNhaXB.Size = new Size(328, 207);
            dgvNhaXB.TabIndex = 0;
            dgvNhaXB.CellClick += dgvNhaXB_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 95);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên nhà xuất bản";
            // 
            // txtTenNXB
            // 
            txtTenNXB.Location = new Point(126, 92);
            txtTenNXB.Name = "txtTenNXB";
            txtTenNXB.Size = new Size(156, 23);
            txtTenNXB.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnLamMoi);
            groupBox2.Location = new Point(13, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 127);
            groupBox2.TabIndex = 6;
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
            groupBox3.Controls.Add(txtMaNhaXB);
            groupBox3.Controls.Add(txtTenNXB);
            groupBox3.Location = new Point(13, 177);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(323, 163);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin nhà xuất bản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 45);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã nhà xuất bản";
            // 
            // txtMaNhaXB
            // 
            txtMaNhaXB.Enabled = false;
            txtMaNhaXB.Location = new Point(126, 42);
            txtMaNhaXB.Name = "txtMaNhaXB";
            txtMaNhaXB.Size = new Size(156, 23);
            txtMaNhaXB.TabIndex = 2;
            // 
            // NhaXB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 394);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "NhaXB";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhaXB";
            Load += NhaXB_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaXB).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvNhaXB;
        private Label label3;
        private TextBox txtTenNXB;
        private GroupBox groupBox2;
        private Button btnSua;
        private Button btnThem;
        private Button btnXoa;
        private Button btnLamMoi;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox txtMaNhaXB;
    }
}