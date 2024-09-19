using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLon
{
    public partial class frmLopSinhVien : Form
    {
        public frmLopSinhVien()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        QLDDataContext dt = new QLDDataContext();
        private void frmLopSinhVien_Load(object sender, EventArgs e)
        {
            cbb_danh_sach_lop.DisplayMember = "tenLop";
            cbb_danh_sach_lop.ValueMember = "maLop";
            cbb_danh_sach_lop.DataSource = dt.Lop_SelecAll();
            txt_maLop.DataBindings.Clear();
            txt_maLop.DataBindings.Add("Text", cbb_danh_sach_lop.DataSource, "maLop");
            txt_tenLop.DataBindings.Clear();
            txt_tenLop.DataBindings.Add("Text", cbb_danh_sach_lop.DataSource, "tenLop");
            txt_maLop.Enabled = false;
        }
        Boolean adLop = false;
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txt_maLop.Text = "";
            txt_tenLop.Text = "";
            txt_maLop.Enabled = true;
            txt_maLop.Focus();
            adLop = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (adLop)
            {
                dt.Lop_Insert(txt_maLop.Text, txt_tenLop.Text);
                txt_maLop.Enabled = false;
                adLop = false;
            }
            else
            {
                dt.Lop_Update(txt_maLop.Text, txt_tenLop.Text);
            }
            frmLopSinhVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dt.Lop_Delete(cbb_danh_sach_lop.SelectedValue.ToString());
            frmLopSinhVien_Load(sender, e);
        }

        private void cbb_danh_sach_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgSinhVien.DataSource = dt.SinhVien_SelectMaLop(txt_maLop.Text);
            txt_maSV.DataBindings.Clear();
            txt_maSV.DataBindings.Add("Text", dtgSinhVien.DataSource, "maSV");
            txt_hoTen.DataBindings.Clear();
            txt_hoTen.DataBindings.Add("Text", dtgSinhVien.DataSource, "hoTen");
            Ngay_sinh.DataBindings.Clear();
            Ngay_sinh.DataBindings.Add("Text", dtgSinhVien.DataSource, "ngaySinh");
            txt_gioiTinh.DataBindings.Clear();
            txt_gioiTinh.DataBindings.Add("Text", dtgSinhVien.DataSource, "gioiTinh");
            txt_noiSinh.DataBindings.Clear();
            txt_noiSinh.DataBindings.Add("Text", dtgSinhVien.DataSource, "noiSinh");
            txt_danToc.DataBindings.Clear();
            txt_danToc.DataBindings.Add("Text", dtgSinhVien.DataSource, "danToc");

        }
        Boolean adSV = false;
        private void btnThemmoi2_Click(object sender, EventArgs e)
        {
            txt_maSV.Text = "";
            txt_hoTen.Text = "";
            Ngay_sinh.Text = "";
            txt_gioiTinh.Text = "";
            txt_danToc.Text = "";
            txt_noiSinh.Text = "";
            txt_maSV.Enabled = true;
            txt_maSV.Focus();
            adSV = true;
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {
            if (adSV)
            {
                dt.SinhVien_Insert(txt_maSV.Text, txt_hoTen.Text, Ngay_sinh.Value,
                 Convert.ToInt16(txt_gioiTinh.Text), txt_noiSinh.Text, txt_danToc.Text, txt_maLop.Text);
                adSV = false;
                txt_maLop.Enabled = false;
                cbb_danh_sach_lop_SelectedIndexChanged(sender, e);
            }
            else
            {
                dt.SinhVien_Update(txt_maSV.Text, txt_hoTen.Text, Ngay_sinh.Value,
                 Convert.ToInt16(txt_gioiTinh.Text), txt_noiSinh.Text, txt_danToc.Text);
                cbb_danh_sach_lop_SelectedIndexChanged(sender, e);
            }
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            dt.SinhVien_Delete(txt_maSV.Text);
            cbb_danh_sach_lop_SelectedIndexChanged(sender, e);
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
           dtgSinhVien.DataSource = dt.SinhViens.Where(x=> x.hoTen.Contains(txt_timkiem.Text)).ToList();
            txt_maSV.DataBindings.Clear();
            txt_maSV.DataBindings.Add("Text", dtgSinhVien.DataSource, "maSV");
            txt_hoTen.DataBindings.Clear();
            txt_hoTen.DataBindings.Add("Text", dtgSinhVien.DataSource, "hoTen");
            Ngay_sinh.DataBindings.Clear();
            Ngay_sinh.DataBindings.Add("Text", dtgSinhVien.DataSource, "ngaySinh");
            txt_gioiTinh.DataBindings.Clear();
            txt_gioiTinh.DataBindings.Add("Text", dtgSinhVien.DataSource, "gioiTinh");
            txt_noiSinh.DataBindings.Clear();
            txt_noiSinh.DataBindings.Add("Text", dtgSinhVien.DataSource, "noiSinh");
            txt_danToc.DataBindings.Clear();
            txt_danToc.DataBindings.Add("Text", dtgSinhVien.DataSource, "danToc");
        }
    }
}

