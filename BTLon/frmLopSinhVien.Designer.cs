namespace BTLon
{
    partial class frmLopSinhVien
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnXoa2 = new System.Windows.Forms.Button();
            this.btnLuu2 = new System.Windows.Forms.Button();
            this.btnThemmoi2 = new System.Windows.Forms.Button();
            this.Ngay_sinh = new System.Windows.Forms.DateTimePicker();
            this.txt_danToc = new System.Windows.Forms.TextBox();
            this.txt_noiSinh = new System.Windows.Forms.TextBox();
            this.txt_gioiTinh = new System.Windows.Forms.TextBox();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.txt_maSV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.txt_tenLop = new System.Windows.Forms.TextBox();
            this.txt_maLop = new System.Windows.Forms.TextBox();
            this.cbb_danh_sach_lop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgSinhVien = new System.Windows.Forms.DataGridView();
            this.Cot1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cot2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cot3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cot4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cot5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienSelectMaLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDiemDataSet = new BTLon.QuanLyDiemDataSet();
            this.sinhVien_SelectMaLopTableAdapter = new BTLon.QuanLyDiemDataSetTableAdapters.SinhVien_SelectMaLopTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienSelectMaLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_timkiem);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnXoa2);
            this.panel1.Controls.Add(this.btnLuu2);
            this.panel1.Controls.Add(this.btnThemmoi2);
            this.panel1.Controls.Add(this.Ngay_sinh);
            this.panel1.Controls.Add(this.txt_danToc);
            this.panel1.Controls.Add(this.txt_noiSinh);
            this.panel1.Controls.Add(this.txt_gioiTinh);
            this.panel1.Controls.Add(this.txt_hoTen);
            this.panel1.Controls.Add(this.txt_maSV);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnThemMoi);
            this.panel1.Controls.Add(this.txt_tenLop);
            this.panel1.Controls.Add(this.txt_maLop);
            this.panel1.Controls.Add(this.cbb_danh_sach_lop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(51, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 228);
            this.panel1.TabIndex = 0;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(660, 171);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(263, 30);
            this.txt_timkiem.TabIndex = 25;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(453, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tìm kiếm sinh viên";
            // 
            // btnXoa2
            // 
            this.btnXoa2.Location = new System.Drawing.Point(327, 176);
            this.btnXoa2.Name = "btnXoa2";
            this.btnXoa2.Size = new System.Drawing.Size(100, 30);
            this.btnXoa2.TabIndex = 23;
            this.btnXoa2.Text = "Xóa";
            this.btnXoa2.UseVisualStyleBackColor = true;
            this.btnXoa2.Click += new System.EventHandler(this.btnXoa2_Click);
            // 
            // btnLuu2
            // 
            this.btnLuu2.Location = new System.Drawing.Point(182, 176);
            this.btnLuu2.Name = "btnLuu2";
            this.btnLuu2.Size = new System.Drawing.Size(121, 30);
            this.btnLuu2.TabIndex = 22;
            this.btnLuu2.Text = "Lưu";
            this.btnLuu2.UseVisualStyleBackColor = true;
            this.btnLuu2.Click += new System.EventHandler(this.btnLuu2_Click);
            // 
            // btnThemmoi2
            // 
            this.btnThemmoi2.Location = new System.Drawing.Point(26, 176);
            this.btnThemmoi2.Name = "btnThemmoi2";
            this.btnThemmoi2.Size = new System.Drawing.Size(132, 30);
            this.btnThemmoi2.TabIndex = 21;
            this.btnThemmoi2.Text = "Thêm mới";
            this.btnThemmoi2.UseVisualStyleBackColor = true;
            this.btnThemmoi2.Click += new System.EventHandler(this.btnThemmoi2_Click);
            // 
            // Ngay_sinh
            // 
            this.Ngay_sinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Ngay_sinh.Location = new System.Drawing.Point(316, 122);
            this.Ngay_sinh.Name = "Ngay_sinh";
            this.Ngay_sinh.Size = new System.Drawing.Size(132, 30);
            this.Ngay_sinh.TabIndex = 20;
            this.Ngay_sinh.Value = new System.DateTime(2023, 11, 30, 0, 0, 0, 0);
            // 
            // txt_danToc
            // 
            this.txt_danToc.Location = new System.Drawing.Point(818, 122);
            this.txt_danToc.Name = "txt_danToc";
            this.txt_danToc.Size = new System.Drawing.Size(105, 30);
            this.txt_danToc.TabIndex = 19;
            // 
            // txt_noiSinh
            // 
            this.txt_noiSinh.Location = new System.Drawing.Point(660, 122);
            this.txt_noiSinh.Name = "txt_noiSinh";
            this.txt_noiSinh.Size = new System.Drawing.Size(121, 30);
            this.txt_noiSinh.TabIndex = 18;
            // 
            // txt_gioiTinh
            // 
            this.txt_gioiTinh.Location = new System.Drawing.Point(484, 122);
            this.txt_gioiTinh.Name = "txt_gioiTinh";
            this.txt_gioiTinh.Size = new System.Drawing.Size(106, 30);
            this.txt_gioiTinh.TabIndex = 17;
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Location = new System.Drawing.Point(182, 122);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(118, 30);
            this.txt_hoTen.TabIndex = 16;
            // 
            // txt_maSV
            // 
            this.txt_maSV.Location = new System.Drawing.Point(30, 122);
            this.txt_maSV.Name = "txt_maSV";
            this.txt_maSV.Size = new System.Drawing.Size(117, 30);
            this.txt_maSV.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(824, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Dân tộc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(655, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nơi sinh";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã sinh viên";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(818, 45);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(660, 45);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(121, 30);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(473, 45);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(163, 30);
            this.btnThemMoi.TabIndex = 6;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // txt_tenLop
            // 
            this.txt_tenLop.Location = new System.Drawing.Point(316, 45);
            this.txt_tenLop.Name = "txt_tenLop";
            this.txt_tenLop.Size = new System.Drawing.Size(111, 30);
            this.txt_tenLop.TabIndex = 5;
            // 
            // txt_maLop
            // 
            this.txt_maLop.Location = new System.Drawing.Point(182, 48);
            this.txt_maLop.Name = "txt_maLop";
            this.txt_maLop.Size = new System.Drawing.Size(105, 30);
            this.txt_maLop.TabIndex = 4;
            // 
            // cbb_danh_sach_lop
            // 
            this.cbb_danh_sach_lop.FormattingEnabled = true;
            this.cbb_danh_sach_lop.Location = new System.Drawing.Point(26, 45);
            this.cbb_danh_sach_lop.Name = "cbb_danh_sach_lop";
            this.cbb_danh_sach_lop.Size = new System.Drawing.Size(121, 33);
            this.cbb_danh_sach_lop.TabIndex = 3;
            this.cbb_danh_sach_lop.SelectedIndexChanged += new System.EventHandler(this.cbb_danh_sach_lop_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT THÔNG TIN LỚP ,THÔNG TIN SINH VIÊN";
            // 
            // dtgSinhVien
            // 
            this.dtgSinhVien.AutoGenerateColumns = false;
            this.dtgSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cot1,
            this.cot2,
            this.cot3,
            this.cot4,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.cot5});
            this.dtgSinhVien.DataSource = this.sinhVienSelectMaLopBindingSource;
            this.dtgSinhVien.Location = new System.Drawing.Point(51, 289);
            this.dtgSinhVien.Name = "dtgSinhVien";
            this.dtgSinhVien.RowHeadersWidth = 62;
            this.dtgSinhVien.RowTemplate.Height = 28;
            this.dtgSinhVien.Size = new System.Drawing.Size(951, 261);
            this.dtgSinhVien.TabIndex = 1;
            // 
            // Cot1
            // 
            this.Cot1.DataPropertyName = "maSV";
            this.Cot1.HeaderText = "Mã SV";
            this.Cot1.MinimumWidth = 8;
            this.Cot1.Name = "Cot1";
            this.Cot1.Width = 180;
            // 
            // cot2
            // 
            this.cot2.DataPropertyName = "hoTen";
            this.cot2.HeaderText = "Họ tên";
            this.cot2.MinimumWidth = 8;
            this.cot2.Name = "cot2";
            this.cot2.Width = 200;
            // 
            // cot3
            // 
            this.cot3.DataPropertyName = "ngaySinh";
            this.cot3.HeaderText = "Ngày sinh";
            this.cot3.MinimumWidth = 8;
            this.cot3.Name = "cot3";
            this.cot3.Width = 160;
            // 
            // cot4
            // 
            this.cot4.DataPropertyName = "noiSinh";
            this.cot4.HeaderText = "Nơi sinh";
            this.cot4.MinimumWidth = 8;
            this.cot4.Name = "cot4";
            this.cot4.Width = 190;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "gioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // cot5
            // 
            this.cot5.DataPropertyName = "danToc";
            this.cot5.HeaderText = "Dân tộc";
            this.cot5.MinimumWidth = 8;
            this.cot5.Name = "cot5";
            this.cot5.Width = 160;
            // 
            // sinhVienSelectMaLopBindingSource
            // 
            this.sinhVienSelectMaLopBindingSource.DataMember = "SinhVien_SelectMaLop";
            this.sinhVienSelectMaLopBindingSource.DataSource = this.quanLyDiemDataSet;
            // 
            // quanLyDiemDataSet
            // 
            this.quanLyDiemDataSet.DataSetName = "QuanLyDiemDataSet";
            this.quanLyDiemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVien_SelectMaLopTableAdapter
            // 
            this.sinhVien_SelectMaLopTableAdapter.ClearBeforeFill = true;
            // 
            // frmLopSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.dtgSinhVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLopSinhVien";
            this.Text = "Xử lý dữ liệu Lớp, Sinh Viên";
            this.Load += new System.EventHandler(this.frmLopSinhVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienSelectMaLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.TextBox txt_tenLop;
        private System.Windows.Forms.TextBox txt_maLop;
        private System.Windows.Forms.ComboBox cbb_danh_sach_lop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.TextBox txt_maSV;
        private System.Windows.Forms.DateTimePicker Ngay_sinh;
        private System.Windows.Forms.TextBox txt_danToc;
        private System.Windows.Forms.TextBox txt_noiSinh;
        private System.Windows.Forms.TextBox txt_gioiTinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnXoa2;
        private System.Windows.Forms.Button btnLuu2;
        private System.Windows.Forms.Button btnThemmoi2;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.DataGridView dtgSinhVien;
        private System.Windows.Forms.BindingSource sinhVienSelectMaLopBindingSource;
        private QuanLyDiemDataSet quanLyDiemDataSet;
        private QuanLyDiemDataSetTableAdapters.SinhVien_SelectMaLopTableAdapter sinhVien_SelectMaLopTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cot1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cot2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cot3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cot4;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cot5;
    }
}