namespace BTLon
{
    partial class frmMonDiemHP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_xoaMon = new System.Windows.Forms.Button();
            this.btn_luuMon = new System.Windows.Forms.Button();
            this.btn_themMon = new System.Windows.Forms.Button();
            this.btn_xoaHK = new System.Windows.Forms.Button();
            this.btn_luuHK = new System.Windows.Forms.Button();
            this.btn_themHK = new System.Windows.Forms.Button();
            this.txt_soTC = new System.Windows.Forms.TextBox();
            this.txt_tenMon = new System.Windows.Forms.TextBox();
            this.txt_maMon = new System.Windows.Forms.TextBox();
            this.txt_tenHK = new System.Windows.Forms.TextBox();
            this.txt_maHK = new System.Windows.Forms.TextBox();
            this.cbb_Mon = new System.Windows.Forms.ComboBox();
            this.cbb_HocKy = new System.Windows.Forms.ComboBox();
            this.cbb_Lop = new System.Windows.Forms.ComboBox();
            this.dtgDiemMonHP = new System.Windows.Forms.DataGridView();
            this.bangDiemHPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDiemDataSet2 = new BTLon.QuanLyDiemDataSet2();
            this.quanLyDiemDataSet = new BTLon.QuanLyDiemDataSet();
            this.quanLyDiemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienSelectMaLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVien_SelectMaLopTableAdapter = new BTLon.QuanLyDiemDataSetTableAdapters.SinhVien_SelectMaLopTableAdapter();
            this.quanLyDiemDataSet1 = new BTLon.QuanLyDiemDataSet1();
            this.quanLyDiemDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangDiemHPTableAdapter = new BTLon.QuanLyDiemDataSet2TableAdapters.BangDiemHPTableAdapter();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemLan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemLan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiemMonHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemHPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienSelectMaLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(202, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT HỌC KỲ ,MÔN THI HỌC PHẦN ,ĐIỂM HỌC PHẦN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Học kỳ ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã học kỳ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên học kỳ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Môn học phần ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã môn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tên môn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số TC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.btn_xoaMon);
            this.groupBox1.Controls.Add(this.btn_luuMon);
            this.groupBox1.Controls.Add(this.btn_themMon);
            this.groupBox1.Controls.Add(this.btn_xoaHK);
            this.groupBox1.Controls.Add(this.btn_luuHK);
            this.groupBox1.Controls.Add(this.btn_themHK);
            this.groupBox1.Controls.Add(this.txt_soTC);
            this.groupBox1.Controls.Add(this.txt_tenMon);
            this.groupBox1.Controls.Add(this.txt_maMon);
            this.groupBox1.Controls.Add(this.txt_tenHK);
            this.groupBox1.Controls.Add(this.txt_maHK);
            this.groupBox1.Controls.Add(this.cbb_Mon);
            this.groupBox1.Controls.Add(this.cbb_HocKy);
            this.groupBox1.Controls.Add(this.cbb_Lop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(27, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(931, 208);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(28, 150);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(199, 35);
            this.button7.TabIndex = 23;
            this.button7.Text = "Cập nhật dữ liệu";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_xoaMon
            // 
            this.btn_xoaMon.Location = new System.Drawing.Point(820, 106);
            this.btn_xoaMon.Name = "btn_xoaMon";
            this.btn_xoaMon.Size = new System.Drawing.Size(90, 36);
            this.btn_xoaMon.TabIndex = 22;
            this.btn_xoaMon.Text = "Xóa";
            this.btn_xoaMon.UseVisualStyleBackColor = true;
            this.btn_xoaMon.Click += new System.EventHandler(this.btn_xoaMon_Click);
            // 
            // btn_luuMon
            // 
            this.btn_luuMon.Location = new System.Drawing.Point(712, 106);
            this.btn_luuMon.Name = "btn_luuMon";
            this.btn_luuMon.Size = new System.Drawing.Size(90, 36);
            this.btn_luuMon.TabIndex = 21;
            this.btn_luuMon.Text = "Lưu";
            this.btn_luuMon.UseVisualStyleBackColor = true;
            this.btn_luuMon.Click += new System.EventHandler(this.btn_luuMon_Click);
            // 
            // btn_themMon
            // 
            this.btn_themMon.Location = new System.Drawing.Point(566, 112);
            this.btn_themMon.Name = "btn_themMon";
            this.btn_themMon.Size = new System.Drawing.Size(110, 36);
            this.btn_themMon.TabIndex = 20;
            this.btn_themMon.Text = "Thêm mới";
            this.btn_themMon.UseVisualStyleBackColor = true;
            this.btn_themMon.Click += new System.EventHandler(this.btn_themMon_Click);
            // 
            // btn_xoaHK
            // 
            this.btn_xoaHK.Location = new System.Drawing.Point(820, 35);
            this.btn_xoaHK.Name = "btn_xoaHK";
            this.btn_xoaHK.Size = new System.Drawing.Size(90, 36);
            this.btn_xoaHK.TabIndex = 19;
            this.btn_xoaHK.Text = "Xóa";
            this.btn_xoaHK.UseVisualStyleBackColor = true;
            this.btn_xoaHK.Click += new System.EventHandler(this.btn_xoaHK_Click);
            // 
            // btn_luuHK
            // 
            this.btn_luuHK.Location = new System.Drawing.Point(712, 40);
            this.btn_luuHK.Name = "btn_luuHK";
            this.btn_luuHK.Size = new System.Drawing.Size(90, 36);
            this.btn_luuHK.TabIndex = 18;
            this.btn_luuHK.Text = "Lưu";
            this.btn_luuHK.UseVisualStyleBackColor = true;
            this.btn_luuHK.Click += new System.EventHandler(this.btn_luuHK_Click);
            // 
            // btn_themHK
            // 
            this.btn_themHK.Location = new System.Drawing.Point(566, 40);
            this.btn_themHK.Name = "btn_themHK";
            this.btn_themHK.Size = new System.Drawing.Size(110, 36);
            this.btn_themHK.TabIndex = 17;
            this.btn_themHK.Text = "Thêm mới";
            this.btn_themHK.UseVisualStyleBackColor = true;
            this.btn_themHK.Click += new System.EventHandler(this.btn_themHK_Click);
            // 
            // txt_soTC
            // 
            this.txt_soTC.Location = new System.Drawing.Point(478, 116);
            this.txt_soTC.Name = "txt_soTC";
            this.txt_soTC.Size = new System.Drawing.Size(60, 30);
            this.txt_soTC.TabIndex = 16;
            // 
            // txt_tenMon
            // 
            this.txt_tenMon.Location = new System.Drawing.Point(292, 119);
            this.txt_tenMon.Name = "txt_tenMon";
            this.txt_tenMon.Size = new System.Drawing.Size(166, 30);
            this.txt_tenMon.TabIndex = 15;
            // 
            // txt_maMon
            // 
            this.txt_maMon.Location = new System.Drawing.Point(163, 119);
            this.txt_maMon.Name = "txt_maMon";
            this.txt_maMon.Size = new System.Drawing.Size(92, 30);
            this.txt_maMon.TabIndex = 14;
            // 
            // txt_tenHK
            // 
            this.txt_tenHK.Location = new System.Drawing.Point(446, 42);
            this.txt_tenHK.Name = "txt_tenHK";
            this.txt_tenHK.Size = new System.Drawing.Size(92, 30);
            this.txt_tenHK.TabIndex = 13;
            // 
            // txt_maHK
            // 
            this.txt_maHK.Location = new System.Drawing.Point(315, 40);
            this.txt_maHK.Name = "txt_maHK";
            this.txt_maHK.Size = new System.Drawing.Size(92, 30);
            this.txt_maHK.TabIndex = 12;
            // 
            // cbb_Mon
            // 
            this.cbb_Mon.FormattingEnabled = true;
            this.cbb_Mon.Location = new System.Drawing.Point(28, 116);
            this.cbb_Mon.Name = "cbb_Mon";
            this.cbb_Mon.Size = new System.Drawing.Size(111, 30);
            this.cbb_Mon.TabIndex = 11;
            this.cbb_Mon.SelectedIndexChanged += new System.EventHandler(this.cbb_Mon_SelectedIndexChanged);
            // 
            // cbb_HocKy
            // 
            this.cbb_HocKy.FormattingEnabled = true;
            this.cbb_HocKy.Location = new System.Drawing.Point(160, 40);
            this.cbb_HocKy.Name = "cbb_HocKy";
            this.cbb_HocKy.Size = new System.Drawing.Size(111, 30);
            this.cbb_HocKy.TabIndex = 10;
            this.cbb_HocKy.SelectedIndexChanged += new System.EventHandler(this.cbb_HocKy_SelectedIndexChanged);
            // 
            // cbb_Lop
            // 
            this.cbb_Lop.FormattingEnabled = true;
            this.cbb_Lop.Location = new System.Drawing.Point(28, 40);
            this.cbb_Lop.Name = "cbb_Lop";
            this.cbb_Lop.Size = new System.Drawing.Size(111, 30);
            this.cbb_Lop.TabIndex = 9;
            this.cbb_Lop.SelectedIndexChanged += new System.EventHandler(this.cbb_Lop_SelectedIndexChanged);
            // 
            // dtgDiemMonHP
            // 
            this.dtgDiemMonHP.AutoGenerateColumns = false;
            this.dtgDiemMonHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDiemMonHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSV,
            this.hoTen,
            this.ngaySinh,
            this.diemLan1,
            this.diemLan2});
            this.dtgDiemMonHP.DataSource = this.bangDiemHPBindingSource;
            this.dtgDiemMonHP.Location = new System.Drawing.Point(27, 256);
            this.dtgDiemMonHP.Name = "dtgDiemMonHP";
            this.dtgDiemMonHP.RowHeadersWidth = 62;
            this.dtgDiemMonHP.RowTemplate.Height = 28;
            this.dtgDiemMonHP.Size = new System.Drawing.Size(931, 228);
            this.dtgDiemMonHP.TabIndex = 10;
            this.dtgDiemMonHP.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDiemMonHP_CellEndEdit);
            // 
            // bangDiemHPBindingSource
            // 
            this.bangDiemHPBindingSource.DataMember = "BangDiemHP";
            this.bangDiemHPBindingSource.DataSource = this.quanLyDiemDataSet2;
            // 
            // quanLyDiemDataSet2
            // 
            this.quanLyDiemDataSet2.DataSetName = "QuanLyDiemDataSet2";
            this.quanLyDiemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyDiemDataSet
            // 
            this.quanLyDiemDataSet.DataSetName = "QuanLyDiemDataSet";
            this.quanLyDiemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyDiemDataSetBindingSource
            // 
            this.quanLyDiemDataSetBindingSource.DataSource = this.quanLyDiemDataSet;
            this.quanLyDiemDataSetBindingSource.Position = 0;
            // 
            // sinhVienSelectMaLopBindingSource
            // 
            this.sinhVienSelectMaLopBindingSource.DataMember = "SinhVien_SelectMaLop";
            this.sinhVienSelectMaLopBindingSource.DataSource = this.quanLyDiemDataSetBindingSource;
            // 
            // sinhVien_SelectMaLopTableAdapter
            // 
            this.sinhVien_SelectMaLopTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyDiemDataSet1
            // 
            this.quanLyDiemDataSet1.DataSetName = "QuanLyDiemDataSet1";
            this.quanLyDiemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyDiemDataSet1BindingSource
            // 
            this.quanLyDiemDataSet1BindingSource.DataSource = this.quanLyDiemDataSet1;
            this.quanLyDiemDataSet1BindingSource.Position = 0;
            // 
            // bangDiemHPTableAdapter
            // 
            this.bangDiemHPTableAdapter.ClearBeforeFill = true;
            // 
            // maSV
            // 
            this.maSV.DataPropertyName = "maSV";
            this.maSV.HeaderText = "Mã SV";
            this.maSV.MinimumWidth = 8;
            this.maSV.Name = "maSV";
            this.maSV.Width = 220;
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ tên";
            this.hoTen.MinimumWidth = 8;
            this.hoTen.Name = "hoTen";
            this.hoTen.Width = 220;
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày Sinh";
            this.ngaySinh.MinimumWidth = 8;
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Width = 200;
            // 
            // diemLan1
            // 
            this.diemLan1.DataPropertyName = "diemLan1";
            this.diemLan1.HeaderText = "Điểm lần 1";
            this.diemLan1.MinimumWidth = 8;
            this.diemLan1.Name = "diemLan1";
            this.diemLan1.Width = 150;
            // 
            // diemLan2
            // 
            this.diemLan2.DataPropertyName = "diemLan2";
            this.diemLan2.HeaderText = "Điểm lần 2";
            this.diemLan2.MinimumWidth = 8;
            this.diemLan2.Name = "diemLan2";
            this.diemLan2.Width = 150;
            // 
            // frmMonDiemHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 495);
            this.Controls.Add(this.dtgDiemMonHP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMonDiemHP";
            this.Text = "Xử lý Học Kỳ ,Môn HP,Điểm HP";
            this.Load += new System.EventHandler(this.frmMonDiemHP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiemMonHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemHPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienSelectMaLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_soTC;
        private System.Windows.Forms.TextBox txt_tenMon;
        private System.Windows.Forms.TextBox txt_maMon;
        private System.Windows.Forms.TextBox txt_tenHK;
        private System.Windows.Forms.TextBox txt_maHK;
        private System.Windows.Forms.ComboBox cbb_Mon;
        private System.Windows.Forms.ComboBox cbb_HocKy;
        private System.Windows.Forms.ComboBox cbb_Lop;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_xoaMon;
        private System.Windows.Forms.Button btn_luuMon;
        private System.Windows.Forms.Button btn_themMon;
        private System.Windows.Forms.Button btn_xoaHK;
        private System.Windows.Forms.Button btn_luuHK;
        private System.Windows.Forms.Button btn_themHK;
        private System.Windows.Forms.DataGridView dtgDiemMonHP;
        private System.Windows.Forms.BindingSource quanLyDiemDataSetBindingSource;
        private QuanLyDiemDataSet quanLyDiemDataSet;
        private System.Windows.Forms.BindingSource sinhVienSelectMaLopBindingSource;
        private QuanLyDiemDataSetTableAdapters.SinhVien_SelectMaLopTableAdapter sinhVien_SelectMaLopTableAdapter;
        private System.Windows.Forms.BindingSource bangDiemHPBindingSource;
        private QuanLyDiemDataSet2 quanLyDiemDataSet2;
        private QuanLyDiemDataSet1 quanLyDiemDataSet1;
        private System.Windows.Forms.BindingSource quanLyDiemDataSet1BindingSource;
        private QuanLyDiemDataSet2TableAdapters.BangDiemHPTableAdapter bangDiemHPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemLan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemLan2;
    }
}