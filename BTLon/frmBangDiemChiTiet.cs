using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLon
{
    public partial class frmBangDiemChiTiet : Form
    {
        public frmBangDiemChiTiet()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        XuLy xl = new XuLy();
        private void frmBangDiemChiTiet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyDiemDataSet3.MonHP' table. You can move, or remove it, as needed.
            this.monHPTableAdapter.Fill(this.quanLyDiemDataSet3.MonHP);
            cbb_Lop.ValueMember = "maLop";
            cbb_Lop.DisplayMember = "tenLop";
            cbb_Lop.DataSource = dt.Lop_SelecAll();
            
        }

        private void cbb_Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeViewSV.Nodes.Clear();
            foreach (var r in dt.SinhVien_SelectMaLop(cbb_Lop.SelectedValue.ToString()))
            {
                TreeNode node = new TreeNode();
                node.Name = r.maSV;
                node.Text = r.hoTen;
                treeViewSV.Nodes.Add(node);
            }
            treeViewSV.ExpandAll();
        }

        private void treeViewSV_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            foreach (var r in dt.SinhVien_SelectID(e.Node.Name)){

                lb_maSV.Text = e.Node.Name;
                lb_hoTen.Text = r.hoTen;
                lb_ngaySinh.Text  = r.ngaySinh.ToString();
                lb_noiSinh.Text = r.noiSinh.ToString();
                if (r.gioiTinh.ToString() == "1")
                {
                    lb_gioiTinh.Text = "Nữ";
                }else
                    lb_gioiTinh.Text="Nam";
                
                lb_danToc.Text = r.danToc.ToString();
            }
            var table = new DataTable();
            DataColumnCollection col  = table.Columns;
            if (!col.Contains("maMon")) 
                table.Columns.Add("maMon", typeof(String));
            if (!col.Contains("tenMon"))
                table.Columns.Add("tenMon", typeof(String));
            if (!col.Contains("soTinChi"))
                table.Columns.Add("soTinChi", typeof(String));
            if (!col.Contains("diemHP"))
                table.Columns.Add("diemHP", typeof(String));
            if (!col.Contains("diemChu"))
                table.Columns.Add("diemChu", typeof(String));
            if (!col.Contains("diemSo"))
                table.Columns.Add("diemSo", typeof(String));
            foreach (var m in dt.MonHP_SelecAll())
            {
                DataRow r = table.NewRow();
                r["maMon"] = m.maMon;
                r["tenMon"] = m.tenMon;
                r["soTinChi"] = m.soTinChi;
                foreach (var d in dt.DiemHP_Search(m.maMon, e.Node.Name))
                {
                    if (d.diemLan2 == null)
                    {
                        r["diemHP"] = d.diemLan1;
                        r["diemChu"] = xl.diemChu(Convert.ToDouble(d.diemLan1));
                        r["diemSo"] = xl.diemSo(Convert.ToDouble(d.diemLan1));
                    }
                    else { 
                        r["diemHP"] = d.diemLan2;
                        r["diemChu"] = xl.diemChu(Convert.ToDouble(d.diemLan2));
                        r["diemSo"] = xl.diemSo(Convert.ToDouble(d.diemLan2));
                     }

                }


                table.Rows.Add(r);

            }
            dtg_bangDiem.DataSource = table;
        }
    }
        
}
