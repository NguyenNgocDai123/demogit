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
    public partial class frmMaim : Form
    {
        public frmMaim()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_XuLyLopSV_Click(object sender, EventArgs e)
        {
            frmLopSinhVien frm_sv = new frmLopSinhVien();
            frm_sv.ShowDialog();
        }

        private void btnMonDiemHP_Click(object sender, EventArgs e)
        {
            frmMonDiemHP frm = new frmMonDiemHP();
            frm.ShowDialog();
        }

        private void btn_thongTinHeThong_Click(object sender, EventArgs e)
        {
            frmThongTinHeThong frm = new frmThongTinHeThong();
            frm.ShowDialog();
        }

        private void btn_bangDiem_Click(object sender, EventArgs e)
        {
            frmBangDiemChiTiet frm =  new frmBangDiemChiTiet();
            frm.ShowDialog();
        }
    }
}
