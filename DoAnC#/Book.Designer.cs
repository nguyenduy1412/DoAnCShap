namespace DoAnC_
{
    partial class Book
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
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            groupBox3 = new GroupBox();
            txtGia = new TextBox();
            txtNamXB = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cmbDanhMuc = new ComboBox();
            cmbNXB = new ComboBox();
            btnUpload = new Button();
            cmbTacGia = new ComboBox();
            ptrAnh = new PictureBox();
            txtGiaSale = new TextBox();
            txtSale = new TextBox();
            txtBookId = new TextBox();
            txtBookName = new TextBox();
            label7 = new Label();
            label18 = new Label();
            label8 = new Label();
            label9 = new Label();
            label19 = new Label();
            label5 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvBook = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptrAnh).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnLamMoi);
            groupBox2.Location = new Point(34, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(733, 60);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Location = new Point(618, 22);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(81, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(67, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(81, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Enabled = false;
            btnSua.Location = new Point(445, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(81, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(257, 22);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(81, 29);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtGia);
            groupBox3.Controls.Add(txtNamXB);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(cmbDanhMuc);
            groupBox3.Controls.Add(cmbNXB);
            groupBox3.Controls.Add(btnUpload);
            groupBox3.Controls.Add(cmbTacGia);
            groupBox3.Controls.Add(ptrAnh);
            groupBox3.Controls.Add(txtGiaSale);
            groupBox3.Controls.Add(txtSale);
            groupBox3.Controls.Add(txtBookId);
            groupBox3.Controls.Add(txtBookName);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(34, 291);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(733, 238);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sách";
            // 
            // txtGia
            // 
            txtGia.Enabled = false;
            txtGia.Location = new Point(405, 137);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(121, 23);
            txtGia.TabIndex = 7;
            txtGia.TextChanged += txtGia_TextChanged;
            // 
            // txtNamXB
            // 
            txtNamXB.Location = new Point(405, 39);
            txtNamXB.Name = "txtNamXB";
            txtNamXB.Size = new Size(121, 23);
            txtNamXB.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 140);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 6;
            label4.Text = "Giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 94);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 6;
            label3.Text = "Nhà xuất bản";
            // 
            // cmbDanhMuc
            // 
            cmbDanhMuc.FormattingEnabled = true;
            cmbDanhMuc.Location = new Point(117, 204);
            cmbDanhMuc.Name = "cmbDanhMuc";
            cmbDanhMuc.Size = new Size(121, 23);
            cmbDanhMuc.TabIndex = 5;
            // 
            // cmbNXB
            // 
            cmbNXB.FormattingEnabled = true;
            cmbNXB.Location = new Point(405, 86);
            cmbNXB.Name = "cmbNXB";
            cmbNXB.Size = new Size(121, 23);
            cmbNXB.TabIndex = 5;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(598, 204);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(75, 23);
            btnUpload.TabIndex = 4;
            btnUpload.Text = "Tải ảnh";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // cmbTacGia
            // 
            cmbTacGia.FormattingEnabled = true;
            cmbTacGia.Location = new Point(117, 122);
            cmbTacGia.Name = "cmbTacGia";
            cmbTacGia.Size = new Size(121, 23);
            cmbTacGia.TabIndex = 3;
            // 
            // ptrAnh
            // 
            ptrAnh.Location = new Point(562, 39);
            ptrAnh.Name = "ptrAnh";
            ptrAnh.Size = new Size(137, 153);
            ptrAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            ptrAnh.TabIndex = 2;
            ptrAnh.TabStop = false;
            // 
            // txtGiaSale
            // 
            txtGiaSale.Enabled = false;
            txtGiaSale.Location = new Point(405, 186);
            txtGiaSale.Name = "txtGiaSale";
            txtGiaSale.Size = new Size(121, 23);
            txtGiaSale.TabIndex = 1;
            // 
            // txtSale
            // 
            txtSale.Location = new Point(117, 163);
            txtSale.Name = "txtSale";
            txtSale.Size = new Size(121, 23);
            txtSale.TabIndex = 1;
            txtSale.TextChanged += txtSale_TextChanged;
            // 
            // txtBookId
            // 
            txtBookId.Enabled = false;
            txtBookId.Location = new Point(117, 31);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(121, 23);
            txtBookId.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(117, 75);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(121, 23);
            txtBookName.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(278, 189);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 0;
            label7.Text = "Giá khuyến mãi";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(25, 210);
            label18.Name = "label18";
            label18.Size = new Size(62, 15);
            label18.TabIndex = 0;
            label18.Text = "Danh mục";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 163);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 0;
            label8.Text = "Sale";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 34);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 0;
            label9.Text = "Mã sách";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(21, 122);
            label19.Name = "label19";
            label19.Size = new Size(43, 15);
            label19.TabIndex = 0;
            label19.Text = "Tác giả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 78);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 0;
            label5.Text = "Tên sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 42);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 0;
            label2.Text = "Năm xuất bản";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvBook);
            groupBox1.Location = new Point(34, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(733, 207);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(547, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(172, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(470, 25);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm";
            // 
            // dgvBook
            // 
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(25, 51);
            dgvBook.Name = "dgvBook";
            dgvBook.Size = new Size(698, 150);
            dgvBook.TabIndex = 0;
            dgvBook.CellClick += dgvBook_CellClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 530);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book";
            Load += Book_Load;
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptrAnh).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private Button btnLamMoi;
        private GroupBox groupBox3;
        private PictureBox ptrAnh;
        private TextBox txtGiaSale;
        private TextBox txtMaNV;
        private TextBox txtSale;
        private TextBox txtBookId;
        private TextBox txtBookName;
        private TextBox txtPhone;
        private Label label7;
        private Label label18;
        private TextBox txtCustomName;
        private Label label8;
        private Label label9;
        private Label label19;
        private Label label5;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvBook;
        private ComboBox cmbTacGia;
        private ComboBox cmbNXB;
        private Button btnUpload;
        private ComboBox cmbDanhMuc;
        private TextBox txtGia;
        private TextBox txtNamXB;
        private Label label4;
        private Label label3;
        private OpenFileDialog openFileDialog1;
    }
}