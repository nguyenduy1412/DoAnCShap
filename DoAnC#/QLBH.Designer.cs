namespace DoAnC_
{
    partial class QLBH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLBH));
            groupBox4 = new GroupBox();
            dgvCus = new DataGridView();
            txtSearchCus = new TextBox();
            label10 = new Label();
            groupBox5 = new GroupBox();
            btnThanhToan = new Button();
            lbNameNV = new Label();
            label20 = new Label();
            dtpNgayMua = new DateTimePicker();
            label15 = new Label();
            lbThanhTien = new Label();
            label11 = new Label();
            dgvDetailOrder = new DataGridView();
            txtAddressCus = new TextBox();
            txtPhoneCus = new TextBox();
            label17 = new Label();
            txtNameCus = new TextBox();
            label16 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtSumMoney = new TextBox();
            txtMaNV = new TextBox();
            txtAddress = new TextBox();
            txtQuantity = new TextBox();
            txtBookId = new TextBox();
            txtBookName = new TextBox();
            txtPhone = new TextBox();
            label7 = new Label();
            txtCustomName = new TextBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvBook = new DataGridView();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            txtTenNV = new TextBox();
            txtAuthor = new TextBox();
            label18 = new Label();
            label6 = new Label();
            label9 = new Label();
            label19 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCus).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailOrder).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvCus);
            groupBox4.Controls.Add(txtSearchCus);
            groupBox4.Controls.Add(label10);
            groupBox4.Location = new Point(771, 42);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(533, 224);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách khách hàng";
            // 
            // dgvCus
            // 
            dgvCus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCus.Location = new Point(87, 77);
            dgvCus.Name = "dgvCus";
            dgvCus.Size = new Size(344, 134);
            dgvCus.TabIndex = 6;
            dgvCus.CellClick += dgvCus_CellClick;
            // 
            // txtSearchCus
            // 
            txtSearchCus.Location = new Point(188, 36);
            txtSearchCus.Name = "txtSearchCus";
            txtSearchCus.Size = new Size(243, 23);
            txtSearchCus.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(87, 39);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 4;
            label10.Text = "Tìm kiếm";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnThanhToan);
            groupBox5.Controls.Add(lbNameNV);
            groupBox5.Controls.Add(label20);
            groupBox5.Controls.Add(dtpNgayMua);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(lbThanhTien);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(dgvDetailOrder);
            groupBox5.Controls.Add(txtAddressCus);
            groupBox5.Controls.Add(txtPhoneCus);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(txtNameCus);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label13);
            groupBox5.Location = new Point(771, 272);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(533, 396);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thông tin hóa đơn";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(313, 344);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(195, 39);
            btnThanhToan.TabIndex = 14;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // lbNameNV
            // 
            lbNameNV.AutoSize = true;
            lbNameNV.Location = new Point(162, 112);
            lbNameNV.Name = "lbNameNV";
            lbNameNV.Size = new Size(0, 15);
            lbNameNV.TabIndex = 13;
            lbNameNV.Click += lbNameNV_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(27, 112);
            label20.Name = "label20";
            label20.Size = new Size(117, 15);
            label20.TabIndex = 12;
            label20.Text = "Nhân viên bán hàng:";
            // 
            // dtpNgayMua
            // 
            dtpNgayMua.Format = DateTimePickerFormat.Short;
            dtpNgayMua.Location = new Point(398, 27);
            dtpNgayMua.Name = "dtpNgayMua";
            dtpNgayMua.Size = new Size(110, 23);
            dtpNgayMua.TabIndex = 11;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(477, 312);
            label15.Name = "label15";
            label15.Size = new Size(31, 15);
            label15.TabIndex = 10;
            label15.Text = "VND";
            // 
            // lbThanhTien
            // 
            lbThanhTien.AutoSize = true;
            lbThanhTien.Location = new Point(388, 312);
            lbThanhTien.Name = "lbThanhTien";
            lbThanhTien.Size = new Size(0, 15);
            lbThanhTien.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(313, 312);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 10;
            label11.Text = "Thành tiền :";
            // 
            // dgvDetailOrder
            // 
            dgvDetailOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetailOrder.Location = new Point(83, 148);
            dgvDetailOrder.Name = "dgvDetailOrder";
            dgvDetailOrder.Size = new Size(348, 149);
            dgvDetailOrder.TabIndex = 8;
            // 
            // txtAddressCus
            // 
            txtAddressCus.Enabled = false;
            txtAddressCus.Location = new Point(398, 63);
            txtAddressCus.Name = "txtAddressCus";
            txtAddressCus.Size = new Size(110, 23);
            txtAddressCus.TabIndex = 6;
            // 
            // txtPhoneCus
            // 
            txtPhoneCus.Enabled = false;
            txtPhoneCus.Location = new Point(141, 63);
            txtPhoneCus.Name = "txtPhoneCus";
            txtPhoneCus.Size = new Size(110, 23);
            txtPhoneCus.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(282, 66);
            label17.Name = "label17";
            label17.Size = new Size(43, 15);
            label17.TabIndex = 3;
            label17.Text = "Địa chỉ";
            // 
            // txtNameCus
            // 
            txtNameCus.Enabled = false;
            txtNameCus.Location = new Point(141, 24);
            txtNameCus.Name = "txtNameCus";
            txtNameCus.Size = new Size(110, 23);
            txtNameCus.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(282, 27);
            label16.Name = "label16";
            label16.Size = new Size(62, 15);
            label16.TabIndex = 4;
            label16.Text = "Ngày mua";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 66);
            label12.Name = "label12";
            label12.Size = new Size(76, 15);
            label12.TabIndex = 3;
            label12.Text = "Số điện thoại";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(25, 27);
            label13.Name = "label13";
            label13.Size = new Size(90, 15);
            label13.TabIndex = 4;
            label13.Text = "Tên khách hàng";
            // 
            // txtSumMoney
            // 
            txtSumMoney.Enabled = false;
            txtSumMoney.Location = new Point(405, 202);
            txtSumMoney.Name = "txtSumMoney";
            txtSumMoney.Size = new Size(121, 23);
            txtSumMoney.TabIndex = 1;
            // 
            // txtMaNV
            // 
            txtMaNV.Enabled = false;
            txtMaNV.Location = new Point(117, 160);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(121, 23);
            txtMaNV.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(117, 116);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(121, 23);
            txtAddress.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(405, 160);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(121, 23);
            txtQuantity.TabIndex = 1;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtBookId
            // 
            txtBookId.Enabled = false;
            txtBookId.Location = new Point(405, 30);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(121, 23);
            txtBookId.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.Enabled = false;
            txtBookName.Location = new Point(405, 74);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(121, 23);
            txtBookName.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(117, 30);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(121, 23);
            txtPhone.TabIndex = 1;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(309, 205);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 0;
            label7.Text = "Tổng tiền";
            // 
            // txtCustomName
            // 
            txtCustomName.Location = new Point(117, 74);
            txtCustomName.Name = "txtCustomName";
            txtCustomName.Size = new Size(121, 23);
            txtCustomName.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 163);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 0;
            label8.Text = "Mã nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnLamMoi);
            groupBox2.Location = new Point(13, 355);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(733, 69);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(618, 22);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(81, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
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
            btnSua.Location = new Point(445, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(81, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(257, 22);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(81, 29);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(547, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(172, 23);
            txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(470, 39);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm";
            // 
            // dgvBook
            // 
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(21, 77);
            dgvBook.Name = "dgvBook";
            dgvBook.Size = new Size(698, 215);
            dgvBook.TabIndex = 0;
            dgvBook.CellClick += dgvBook_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(txtSumMoney);
            groupBox3.Controls.Add(txtTenNV);
            groupBox3.Controls.Add(txtMaNV);
            groupBox3.Controls.Add(txtAddress);
            groupBox3.Controls.Add(txtQuantity);
            groupBox3.Controls.Add(txtBookId);
            groupBox3.Controls.Add(txtAuthor);
            groupBox3.Controls.Add(txtBookName);
            groupBox3.Controls.Add(txtPhone);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(txtCustomName);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(13, 430);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(733, 238);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Khách hàng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(562, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtTenNV
            // 
            txtTenNV.Enabled = false;
            txtTenNV.Location = new Point(117, 200);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(121, 23);
            txtTenNV.TabIndex = 1;
            // 
            // txtAuthor
            // 
            txtAuthor.Enabled = false;
            txtAuthor.Location = new Point(405, 116);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(121, 23);
            txtAuthor.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(25, 203);
            label18.Name = "label18";
            label18.Size = new Size(80, 15);
            label18.TabIndex = 0;
            label18.Text = "Tên nhân viên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(309, 163);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 0;
            label6.Text = "Số lượng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(309, 30);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 0;
            label9.Text = "Mã sách";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(309, 119);
            label19.Name = "label19";
            label19.Size = new Size(43, 15);
            label19.TabIndex = 0;
            label19.Text = "Tác giả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 119);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 0;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 77);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 0;
            label5.Text = "Tên sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 33);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 0;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 74);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 0;
            label2.Text = "Tên khách hàng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvBook);
            groupBox1.Location = new Point(13, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(733, 307);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // QLBH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 680);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "QLBH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QLBH";
            Load += QLBH_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCus).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailOrder).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private TextBox txtSearchCus;
        private Label label10;
        private GroupBox groupBox5;
        private Label label15;
        private Label lbThanhTien;
        private Label label11;
        private DataGridView dgvDetailOrder;
        private TextBox txtPhoneCus;
        private TextBox txtNameCus;
        private Label label12;
        private Label label13;
        private TextBox txtSumMoney;
        private TextBox txtMaNV;
        private TextBox txtAddress;
        private TextBox txtQuantity;
        private TextBox txtBookId;
        private TextBox txtBookName;
        private TextBox txtPhone;
        private Label label7;
        private TextBox txtCustomName;
        private Label label8;
        private GroupBox groupBox2;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private Button btnLamMoi;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvBook;
        private GroupBox groupBox3;
        private Label label6;
        private Label label9;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtAddressCus;
        private Label label17;
        private Label label16;
        private DateTimePicker dtpNgayMua;
        private PictureBox pictureBox1;
        private TextBox txtTenNV;
        private TextBox txtAuthor;
        private Label label18;
        private Label label19;
        private Label lbNameNV;
        private Label label20;
        private Button btnThanhToan;
        private DataGridView dgvCus;
    }
}