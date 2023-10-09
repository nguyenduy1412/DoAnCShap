namespace DoAnC_
{
    partial class NhanVien
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
            openFileDialog1 = new OpenFileDialog();
            txtSearch = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgvNhanVien = new DataGridView();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cmbRole = new ComboBox();
            btnUpload = new Button();
            ptrAnh = new PictureBox();
            txtUserName = new TextBox();
            btnLamMoi = new Button();
            txtFullName = new TextBox();
            label7 = new Label();
            label18 = new Label();
            label8 = new Label();
            label9 = new Label();
            label19 = new Label();
            label5 = new Label();
            label2 = new Label();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            label6 = new Label();
            txtMaNV = new TextBox();
            txtSDT = new TextBox();
            txtPass = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrAnh).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(547, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(172, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvNhanVien);
            groupBox1.Location = new Point(32, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(733, 207);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(25, 51);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.Size = new Size(698, 150);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick_1;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(405, 119);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(121, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(405, 34);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(121, 23);
            txtDiaChi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 122);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 78);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 6;
            label3.Text = "Số điện thoại";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(117, 204);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 5;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(598, 204);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(75, 23);
            btnUpload.TabIndex = 4;
            btnUpload.Text = "Tải ảnh";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click_1;
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
            // txtUserName
            // 
            txtUserName.Enabled = false;
            txtUserName.Location = new Point(405, 163);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(121, 23);
            txtUserName.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(257, 22);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(81, 29);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click_1;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(117, 75);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(121, 23);
            txtFullName.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(278, 166);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 0;
            label7.Text = "Tên đăng nhập";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(25, 210);
            label18.Name = "label18";
            label18.Size = new Size(42, 15);
            label18.TabIndex = 0;
            label18.Text = "Quyền";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 163);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 0;
            label8.Text = "Ngày sinh";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 34);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 0;
            label9.Text = "Mã nhân viên";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(21, 122);
            label19.Name = "label19";
            label19.Size = new Size(52, 15);
            label19.TabIndex = 0;
            label19.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 78);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 0;
            label5.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 37);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Địa chỉ";
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
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(67, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(81, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click_1;
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
            btnSua.Click += btnSua_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnLamMoi);
            groupBox2.Location = new Point(32, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(733, 60);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpNgaySinh);
            groupBox3.Controls.Add(rdNu);
            groupBox3.Controls.Add(rdNam);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtMaNV);
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Controls.Add(txtSDT);
            groupBox3.Controls.Add(txtDiaChi);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(cmbRole);
            groupBox3.Controls.Add(btnUpload);
            groupBox3.Controls.Add(ptrAnh);
            groupBox3.Controls.Add(txtPass);
            groupBox3.Controls.Add(txtUserName);
            groupBox3.Controls.Add(txtFullName);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(32, 290);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(733, 238);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sách";
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(186, 120);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(41, 19);
            rdNu.TabIndex = 11;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.Location = new Point(117, 120);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(51, 19);
            rdNam.TabIndex = 10;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(283, 207);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 9;
            label6.Text = "Mật khẩu";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(117, 31);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(121, 23);
            txtMaNV.TabIndex = 8;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(405, 75);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(121, 23);
            txtSDT.TabIndex = 7;
            // 
            // txtPass
            // 
            txtPass.Enabled = false;
            txtPass.Location = new Point(405, 204);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(121, 23);
            txtPass.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(114, 157);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(124, 23);
            dtpNgaySinh.TabIndex = 12;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 539);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "NhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhanVien";
            Load += NhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrAnh).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cmbTacGia;
        private TextBox txtSale;
        private TextBox txtBookId;
        private OpenFileDialog openFileDialog1;
        private TextBox txtSearch;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvNhanVien;
        private TextBox txtEmail;
        private TextBox txtDiaChi;
        private Label label4;
        private Label label3;
        private ComboBox cmbRole;
        private Button btnUpload;
        private PictureBox ptrAnh;
        private TextBox txtUserName;
        private Button btnLamMoi;
        private TextBox txtFullName;
        private Label label7;
        private Label label18;
        private Label label8;
        private Label label9;
        private Label label19;
        private Label label5;
        private Label label2;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtMaNV;
        private TextBox txtSDT;
        private Label label6;
        private TextBox txtPass;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private DateTimePicker dtpNgaySinh;
    }
}