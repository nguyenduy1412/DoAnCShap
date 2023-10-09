namespace DoAnC_
{
    partial class PhieuNhap
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
            Sách = new GroupBox();
            txtSearchBook = new TextBox();
            label1 = new Label();
            dgvBook = new DataGridView();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            groupBox3 = new GroupBox();
            txtSoLuong = new TextBox();
            label2 = new Label();
            txtGia = new TextBox();
            label4 = new Label();
            ptrAnh = new PictureBox();
            txtBookId = new TextBox();
            txtBookName = new TextBox();
            label9 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            searchKho = new TextBox();
            label6 = new Label();
            dgvKho = new DataGridView();
            groupBox4 = new GroupBox();
            dtpNgayNhap = new DateTimePicker();
            lbMaPN = new Label();
            label3 = new Label();
            searchPN = new TextBox();
            label8 = new Label();
            lbTienNhap = new Label();
            label10 = new Label();
            label7 = new Label();
            btnLapPN = new Button();
            groupBox5 = new GroupBox();
            dgvCTPN = new DataGridView();
            dgvPhieuNhap = new DataGridView();
            btnPN = new Button();
            Sách.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptrAnh).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTPN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // Sách
            // 
            Sách.Controls.Add(txtSearchBook);
            Sách.Controls.Add(label1);
            Sách.Controls.Add(dgvBook);
            Sách.Location = new Point(24, 60);
            Sách.Name = "Sách";
            Sách.Size = new Size(464, 240);
            Sách.TabIndex = 1;
            Sách.TabStop = false;
            Sách.Text = "Sách";
            // 
            // txtSearchBook
            // 
            txtSearchBook.Location = new Point(286, 19);
            txtSearchBook.Name = "txtSearchBook";
            txtSearchBook.Size = new Size(172, 23);
            txtSearchBook.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 22);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Tìm kiếm";
            // 
            // dgvBook
            // 
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(6, 48);
            dgvBook.Name = "dgvBook";
            dgvBook.Size = new Size(452, 174);
            dgvBook.TabIndex = 0;
            dgvBook.CellClick += dgvBook_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnLamMoi);
            groupBox2.Location = new Point(30, 303);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(713, 60);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Location = new Point(554, 22);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(81, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Enabled = false;
            btnThem.Location = new Point(34, 22);
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
            btnSua.Location = new Point(344, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(81, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(192, 22);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(81, 29);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSoLuong);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtGia);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(ptrAnh);
            groupBox3.Controls.Add(txtBookId);
            groupBox3.Controls.Add(txtBookName);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(30, 369);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(713, 179);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sách";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(405, 47);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(121, 23);
            txtSoLuong.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 50);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 8;
            label2.Text = "Số lượng";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(405, 122);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(121, 23);
            txtGia.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 125);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 6;
            label4.Text = "Giá";
            // 
            // ptrAnh
            // 
            ptrAnh.Location = new Point(566, 22);
            ptrAnh.Name = "ptrAnh";
            ptrAnh.Size = new Size(116, 135);
            ptrAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            ptrAnh.TabIndex = 2;
            ptrAnh.TabStop = false;
            // 
            // txtBookId
            // 
            txtBookId.Enabled = false;
            txtBookId.Location = new Point(117, 47);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(121, 23);
            txtBookId.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(117, 117);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(121, 23);
            txtBookName.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 50);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 0;
            label9.Text = "Mã sách";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 120);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 0;
            label5.Text = "Tên sách";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(searchKho);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dgvKho);
            groupBox1.Location = new Point(494, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 237);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kho";
            // 
            // searchKho
            // 
            searchKho.Location = new Point(92, 19);
            searchKho.Name = "searchKho";
            searchKho.Size = new Size(151, 23);
            searchKho.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 22);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 3;
            label6.Text = "Tìm kiếm";
            // 
            // dgvKho
            // 
            dgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKho.Location = new Point(3, 48);
            dgvKho.Name = "dgvKho";
            dgvKho.Size = new Size(240, 174);
            dgvKho.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtpNgayNhap);
            groupBox4.Controls.Add(lbMaPN);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(searchPN);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(lbTienNhap);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(btnLapPN);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(dgvPhieuNhap);
            groupBox4.Location = new Point(766, 60);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(339, 488);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin phiếu nhập";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(123, 209);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(194, 23);
            dtpNgayNhap.TabIndex = 7;
            // 
            // lbMaPN
            // 
            lbMaPN.AutoSize = true;
            lbMaPN.Location = new Point(123, 183);
            lbMaPN.Name = "lbMaPN";
            lbMaPN.Size = new Size(0, 15);
            lbMaPN.TabIndex = 6;
            lbMaPN.TextChanged += lbMaPN_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 183);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 5;
            label3.Text = "Mã Phiếu Nhập :";
            // 
            // searchPN
            // 
            searchPN.Location = new Point(172, 22);
            searchPN.Name = "searchPN";
            searchPN.Size = new Size(151, 23);
            searchPN.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(95, 25);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 3;
            label8.Text = "Tìm kiếm";
            // 
            // lbTienNhap
            // 
            lbTienNhap.AutoSize = true;
            lbTienNhap.Location = new Point(106, 243);
            lbTienNhap.Name = "lbTienNhap";
            lbTienNhap.Size = new Size(0, 15);
            lbTienNhap.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 243);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 3;
            label10.Text = "Tiền nhập :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 215);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 3;
            label7.Text = "Ngày nhập :";
            // 
            // btnLapPN
            // 
            btnLapPN.Enabled = false;
            btnLapPN.Location = new Point(187, 434);
            btnLapPN.Name = "btnLapPN";
            btnLapPN.Size = new Size(136, 35);
            btnLapPN.TabIndex = 2;
            btnLapPN.Text = "Lập phiếu nhập";
            btnLapPN.UseVisualStyleBackColor = true;
            btnLapPN.Click += btnLapPN_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgvCTPN);
            groupBox5.Location = new Point(6, 277);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(317, 140);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chi tiết phiếu nhập";
            // 
            // dgvCTPN
            // 
            dgvCTPN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTPN.Location = new Point(6, 24);
            dgvCTPN.Name = "dgvCTPN";
            dgvCTPN.Size = new Size(305, 104);
            dgvCTPN.TabIndex = 0;
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhap.Location = new Point(6, 48);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.Size = new Size(317, 121);
            dgvPhieuNhap.TabIndex = 0;
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            // 
            // btnPN
            // 
            btnPN.Location = new Point(24, 12);
            btnPN.Name = "btnPN";
            btnPN.Size = new Size(110, 32);
            btnPN.TabIndex = 16;
            btnPN.Text = "Tạo phiếu nhập";
            btnPN.UseVisualStyleBackColor = true;
            btnPN.Click += btnPN_Click;
            // 
            // PhieuNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 560);
            Controls.Add(btnPN);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(Sách);
            Name = "PhieuNhap";
            Text = "PhieuNhap";
            Load += PhieuNhap_Load;
            Sách.ResumeLayout(false);
            Sách.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptrAnh).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCTPN).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox Sách;
        private DataGridView dgvBook;
        private TextBox txtSearchBook;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private Button btnLamMoi;
        private GroupBox groupBox3;
        private TextBox txtGia;
        private Label label4;
        private PictureBox ptrAnh;
        private TextBox txtBookId;
        private TextBox txtBookName;
        private Label label9;
        private Label label5;
        private TextBox txtSoLuong;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox searchKho;
        private Label label6;
        private DataGridView dgvKho;
        private GroupBox groupBox4;
        private DataGridView dgvPhieuNhap;
        private Button btnLapPN;
        private GroupBox groupBox5;
        private DataGridView dgvCTPN;
        private TextBox searchPN;
        private Label label8;
        private Label lbTienNhap;
        private Label label10;
        private Label label7;
        private Label lbMaPN;
        private Label label3;
        private Button btnPN;
        private DateTimePicker dtpNgayNhap;
    }
}