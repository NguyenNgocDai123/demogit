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
    public partial class frmThongTinHeThong : Form
    {
        public frmThongTinHeThong()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        private void frmThongTinHeThong_Load(object sender, EventArgs e)
        {
            txt_tenTinh.DataBindings.Clear();
            txt_tenTinh.DataBindings.Add("Text", dt.Thongtin_SelectAll(),"tinh");
            txt_donViChuQuan.DataBindings.Clear();
            txt_donViChuQuan.DataBindings.Add("Text", dt.Thongtin_SelectAll(),"donViChuQuan");
            txt_khoaHoc.DataBindings.Clear();
            txt_khoaHoc.DataBindings.Add("Text", dt.Thongtin_SelectAll(),"khoaHoc");
            txt_nganhHoc.DataBindings.Clear();
            txt_nganhHoc.DataBindings.Add("Text", dt.Thongtin_SelectAll(),"nganhHoc");
            txt_chuyenNganh.DataBindings.Clear();
            txt_chuyenNganh.DataBindings.Add("Text", dt.Thongtin_SelectAll(),"chuyenNganh");
            txt_tenTruong.DataBindings.Clear();
            txt_tenTruong.DataBindings.Add("Text", dt.Thongtin_SelectAll(), "tenTruong");

        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            dt.Thongtin_Update(txt_tenTinh.Text, txt_donViChuQuan.Text, txt_khoaHoc.Text, txt_nganhHoc.Text, txt_chuyenNganh.Text, txt_tenTruong.Text);
        }
    }
}
