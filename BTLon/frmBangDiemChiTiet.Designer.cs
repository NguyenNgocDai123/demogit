namespace BTLon
{
    partial class frmBangDiemChiTiet
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
            this.cbb_Lop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeViewSV = new System.Windows.Forms.TreeView();
            this.quanLyDiemDataSet1 = new BTLon.QuanLyDiemDataSet();
            this.dtg_bangDiem = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_maSV = new System.Windows.Forms.Label();
            this.lb_hoTen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_noiSinh = new System.Windows.Forms.Label();
            this.lb_gioiTinh = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_ngaySinh = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lb_danToc = new System.Windows.Forms.Label();
            this.quanLyDiemDataSet2 = new BTLon.QuanLyDiemDataSet2();
            this.bangDiemHPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangDiemHPTableAdapter = new BTLon.QuanLyDiemDataSet2TableAdapters.BangDiemHPTableAdapter();
            this.quanLyDiemDataSet3 = new BTLon.QuanLyDiemDataSet3();
            this.monHPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHPTableAdapter = new BTLon.QuanLyDiemDataSet3TableAdapters.MonHPTableAdapter();
            this.quanLyDiemDataSet4 = new BTLon.QuanLyDiemDataSet4();
            this.diemHPSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diemHP_SearchTableAdapter = new BTLon.QuanLyDiemDataSet4TableAdapters.DiemHP_SearchTableAdapter();
            this.maMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_bangDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemHPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemHPSearchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_Lop
            // 
            this.cbb_Lop.FormattingEnabled = true;
            this.cbb_Lop.Location = new System.Drawing.Point(121, 45);
            this.cbb_Lop.Name = "cbb_Lop";
            this.cbb_Lop.Size = new System.Drawing.Size(169, 33);
            this.cbb_Lop.TabIndex = 0;
            this.cbb_Lop.SelectedIndexChanged += new System.EventHandler(this.cbb_Lop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(378, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "BẢNG TỔNG HỢP ĐIỂM CHI TIẾT CỦA SINH VIÊN";
            // 
            // treeViewSV
            // 
            this.treeViewSV.Location = new System.Drawing.Point(17, 84);
            this.treeViewSV.Name = "treeViewSV";
            this.treeViewSV.Size = new System.Drawing.Size(273, 456);
            this.treeViewSV.TabIndex = 3;
            this.treeViewSV.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewSV_NodeMouseClick);
            // 
            // quanLyDiemDataSet1
            // 
            this.quanLyDiemDataSet1.DataSetName = "QuanLyDiemDataSet";
            this.quanLyDiemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtg_bangDiem
            // 
            this.dtg_bangDiem.AutoGenerateColumns = false;
            this.dtg_bangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_bangDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMon,
            this.tenMon,
            this.soTC,
            this.diemHP,
            this.diemChu,
            this.diemSo});
            this.dtg_bangDiem.DataSource = this.bangDiemHPBindingSource;
            this.dtg_bangDiem.Location = new System.Drawing.Point(296, 177);
            this.dtg_bangDiem.Name = "dtg_bangDiem";
            this.dtg_bangDiem.RowHeadersWidth = 62;
            this.dtg_bangDiem.RowTemplate.Height = 28;
            this.dtg_bangDiem.Size = new System.Drawing.Size(953, 363);
            this.dtg_bangDiem.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã SV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Họ tên:";
            // 
            // lb_maSV
            // 
            this.lb_maSV.AutoSize = true;
            this.lb_maSV.Location = new System.Drawing.Point(410, 53);
            this.lb_maSV.Name = "lb_maSV";
            this.lb_maSV.Size = new System.Drawing.Size(42, 25);
            this.lb_maSV.TabIndex = 7;
            this.lb_maSV.Text = "null";
            // 
            // lb_hoTen
            // 
            this.lb_hoTen.AutoSize = true;
            this.lb_hoTen.Location = new System.Drawing.Point(410, 109);
            this.lb_hoTen.Name = "lb_hoTen";
            this.lb_hoTen.Size = new System.Drawing.Size(42, 25);
            this.lb_hoTen.TabIndex = 8;
            this.lb_hoTen.Text = "null";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(866, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nơi sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(612, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Giới tính:";
            // 
            // lb_noiSinh
            // 
            this.lb_noiSinh.AutoSize = true;
            this.lb_noiSinh.Location = new System.Drawing.Point(984, 48);
            this.lb_noiSinh.Name = "lb_noiSinh";
            this.lb_noiSinh.Size = new System.Drawing.Size(42, 25);
            this.lb_noiSinh.TabIndex = 11;
            this.lb_noiSinh.Text = "null";
            // 
            // lb_gioiTinh
            // 
            this.lb_gioiTinh.AutoSize = true;
            this.lb_gioiTinh.Location = new System.Drawing.Point(715, 53);
            this.lb_gioiTinh.Name = "lb_gioiTinh";
            this.lb_gioiTinh.Size = new System.Drawing.Size(42, 25);
            this.lb_gioiTinh.TabIndex = 12;
            this.lb_gioiTinh.Text = "null";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(595, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 25);
            this.label15.TabIndex = 17;
            this.label15.Text = "Ngày sinh:";
            // 
            // lb_ngaySinh
            // 
            this.lb_ngaySinh.AutoSize = true;
            this.lb_ngaySinh.Location = new System.Drawing.Point(715, 109);
            this.lb_ngaySinh.Name = "lb_ngaySinh";
            this.lb_ngaySinh.Size = new System.Drawing.Size(42, 25);
            this.lb_ngaySinh.TabIndex = 18;
            this.lb_ngaySinh.Text = "null";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(866, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 25);
            this.label17.TabIndex = 19;
            this.label17.Text = "Dân tộc:";
            // 
            // lb_danToc
            // 
            this.lb_danToc.AutoSize = true;
            this.lb_danToc.Location = new System.Drawing.Point(984, 109);
            this.lb_danToc.Name = "lb_danToc";
            this.lb_danToc.Size = new System.Drawing.Size(42, 25);
            this.lb_danToc.TabIndex = 20;
            this.lb_danToc.Text = "null";
            // 
            // quanLyDiemDataSet2
            // 
            this.quanLyDiemDataSet2.DataSetName = "QuanLyDiemDataSet2";
            this.quanLyDiemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangDiemHPBindingSource
            // 
            this.bangDiemHPBindingSource.DataMember = "BangDiemHP";
            this.bangDiemHPBindingSource.DataSource = this.quanLyDiemDataSet2;
            // 
            // bangDiemHPTableAdapter
            // 
            this.bangDiemHPTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyDiemDataSet3
            // 
            this.quanLyDiemDataSet3.DataSetName = "QuanLyDiemDataSet3";
            this.quanLyDiemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monHPBindingSource
            // 
            this.monHPBindingSource.DataMember = "MonHP";
            this.monHPBindingSource.DataSource = this.quanLyDiemDataSet3;
            // 
            // monHPTableAdapter
            // 
            this.monHPTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyDiemDataSet4
            // 
            this.quanLyDiemDataSet4.DataSetName = "QuanLyDiemDataSet4";
            this.quanLyDiemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diemHPSearchBindingSource
            // 
            this.diemHPSearchBindingSource.DataMember = "DiemHP_Search";
            this.diemHPSearchBindingSource.DataSource = this.quanLyDiemDataSet4;
            // 
            // diemHP_SearchTableAdapter
            // 
            this.diemHP_SearchTableAdapter.ClearBeforeFill = true;
            // 
            // maMon
            // 
            this.maMon.DataPropertyName = "maMon";
            this.maMon.HeaderText = "Mã môn";
            this.maMon.MinimumWidth = 8;
            this.maMon.Name = "maMon";
            this.maMon.Width = 150;
            // 
            // tenMon
            // 
            this.tenMon.DataPropertyName = "tenMon";
            this.tenMon.HeaderText = "Tên môn";
            this.tenMon.MinimumWidth = 8;
            this.tenMon.Name = "tenMon";
            this.tenMon.Width = 150;
            // 
            // soTC
            // 
            this.soTC.DataPropertyName = "soTinChi";
            this.soTC.HeaderText = "Số TC";
            this.soTC.MinimumWidth = 8;
            this.soTC.Name = "soTC";
            this.soTC.Width = 150;
            // 
            // diemHP
            // 
            this.diemHP.DataPropertyName = "diemHP";
            this.diemHP.HeaderText = "Điểm HP";
            this.diemHP.MinimumWidth = 8;
            this.diemHP.Name = "diemHP";
            this.diemHP.Width = 150;
            // 
            // diemChu
            // 
            this.diemChu.DataPropertyName = "diemChu";
            this.diemChu.HeaderText = "Điểm chữ";
            this.diemChu.MinimumWidth = 8;
            this.diemChu.Name = "diemChu";
            this.diemChu.Width = 150;
            // 
            // diemSo
            // 
            this.diemSo.DataPropertyName = "diemSo";
            this.diemSo.HeaderText = "Điểm số";
            this.diemSo.MinimumWidth = 8;
            this.diemSo.Name = "diemSo";
            this.diemSo.Width = 150;
            // 
            // frmBangDiemChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 562);
            this.Controls.Add(this.lb_danToc);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lb_ngaySinh);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lb_gioiTinh);
            this.Controls.Add(this.lb_noiSinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_hoTen);
            this.Controls.Add(this.lb_maSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtg_bangDiem);
            this.Controls.Add(this.treeViewSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_Lop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBangDiemChiTiet";
            this.Text = "Bảng tổng hợp điểm chi tiết của sinh viên";
            this.Load += new System.EventHandler(this.frmBangDiemChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_bangDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemHPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemHPSearchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_Lop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeViewSV;
        private QuanLyDiemDataSet quanLyDiemDataSet1;
        private System.Windows.Forms.DataGridView dtg_bangDiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_maSV;
        private System.Windows.Forms.Label lb_hoTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_noiSinh;
        private System.Windows.Forms.Label lb_gioiTinh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb_ngaySinh;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lb_danToc;
        private System.Windows.Forms.BindingSource bangDiemHPBindingSource;
        private QuanLyDiemDataSet2 quanLyDiemDataSet2;
        private QuanLyDiemDataSet2TableAdapters.BangDiemHPTableAdapter bangDiemHPTableAdapter;
        private QuanLyDiemDataSet3 quanLyDiemDataSet3;
        private System.Windows.Forms.BindingSource monHPBindingSource;
        private QuanLyDiemDataSet3TableAdapters.MonHPTableAdapter monHPTableAdapter;
        private System.Windows.Forms.BindingSource diemHPSearchBindingSource;
        private QuanLyDiemDataSet4 quanLyDiemDataSet4;
        private QuanLyDiemDataSet4TableAdapters.DiemHP_SearchTableAdapter diemHP_SearchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemSo;
    }
}