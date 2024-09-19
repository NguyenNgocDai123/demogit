using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLon
{
    public partial class frmMonDiemHP : Form
    {
        public frmMonDiemHP()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        private void frmMonDiemHP_Load(object sender, EventArgs e)
        {
            
            cbb_Lop.DataSource = dt.Lop_SelecAll();
            cbb_Lop.DisplayMember = "tenLop";
            cbb_Lop.ValueMember = "maLop";
            cbb_HocKy.DataSource = dt.HocKy_SelectAll();
            cbb_HocKy.ValueMember = "maHK";
            cbb_HocKy.DisplayMember = "tenHK";
            txt_maHK.DataBindings.Clear();
            txt_maHK.DataBindings.Add("Text", cbb_HocKy.DataSource, "maHK" );
            txt_tenHK.DataBindings.Clear();
            txt_tenHK.DataBindings.Add("Text", cbb_HocKy.DataSource, "tenHK");
            txt_maHK.Enabled = false;
            cbb_Mon_SelectedIndexChanged(sender, e);
        }
        Boolean adHK = false;
        private void btn_themHK_Click(object sender, EventArgs e)
        {
            txt_maHK.Text = "";
            txt_tenHK.Text = "";
            txt_maHK.Enabled = true;
            txt_maHK.Focus();
            adHK = true;
           
        }

        private void btn_luuHK_Click(object sender, EventArgs e)
        {
            if (adHK)
            {
                try
                {
                    dt.HocKy_Insert(txt_maHK.Text, txt_tenHK.Text);
                }
                catch
                {
                    MessageBox.Show("Thêm mới thất bại !!!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                txt_maHK.Enabled = false;
                adHK = false;
                frmMonDiemHP_Load(sender, e);
               
            }
            else
            {
                try
                {
                    dt.HocKy_Update(txt_maHK.Text, txt_tenHK.Text);
                }
                catch
                {
                    MessageBox.Show("Lưu thất bại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                frmMonDiemHP_Load(sender, e);

            }
            
        }

        private void btn_xoaHK_Click(object sender, EventArgs e)
        {
            DialogResult lenh = MessageBox.Show("Bạn muốn xóa học kì ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (lenh == DialogResult.Yes) {
                dt.HocKy_Delete(cbb_HocKy.SelectedValue.ToString()); 
            }
                    
            frmMonDiemHP_Load(sender, e);
        }

        private void cbb_HocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_Mon.ValueMember = "maMon";
            cbb_Mon.DisplayMember = "tenMon";
            cbb_Mon.DataSource = dt.MonHP_SelectMaHK(cbb_HocKy.SelectedValue.ToString());
            txt_maMon.DataBindings.Clear();
            txt_maMon.DataBindings.Add("Text", cbb_Mon.DataSource, "maMon");
            txt_tenMon.DataBindings.Clear();
            txt_tenMon.DataBindings.Add("Text", cbb_Mon.DataSource, "tenMon");
            txt_soTC.DataBindings.Clear();
            txt_soTC.DataBindings.Add("Text", cbb_Mon.DataSource, "soTinChi");
            txt_maMon.Enabled = false;
            cbb_Lop_SelectedIndexChanged(sender, e);
        }
        Boolean adMon = false;
        private void btn_themMon_Click(object sender, EventArgs e)
        {
            txt_maMon.Text = "";
            txt_tenMon.Text = "";
            txt_soTC.Text = "";
            txt_maMon.Enabled = true;
            adMon = true;
        }

        private void btn_luuMon_Click(object sender, EventArgs e)
        {
            if(adMon)
            {
                try
                {
                    dt.MonHP_Insert(txt_maMon.Text, txt_tenMon.Text, Convert.ToInt16(txt_soTC.Text), txt_maHK.Text);
                }
                catch
                {
                    MessageBox.Show("Thêm mới thất bại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                adMon = false;
                cbb_HocKy_SelectedIndexChanged(sender, e);
            }
            else
            {
                try
                {
                    dt.MonHP_Update(txt_maMon.Text, txt_tenMon.Text, Convert.ToInt16(txt_soTC.Text));
                }
                catch
                {
                    MessageBox.Show("Lưu thất bại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                cbb_HocKy_SelectedIndexChanged(sender, e);
            }
        }

        private void btn_xoaMon_Click(object sender, EventArgs e)
        {
            DialogResult lenh = MessageBox.Show("Bạn muốn xóa môn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (lenh == DialogResult.Yes)
            {
                dt.MonHP_Delete(txt_maMon.Text);
            }
            
            cbb_HocKy_SelectedIndexChanged(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try { 
                foreach(var m in dt.MonHP_SelecAll())
                {
                    foreach(var s in dt.SinhVien_SelecAll())
                    {
                        if(dt.DiemHP_Search(m.maMon,s.maSV).Count()==0){
                            dt.DiemHp_Insert(m.maMon,s.maSV); 
                    }
                }
            }
                MessageBox.Show("Cập nhật thành công cơ sở dữ liệu cho điểm học phần!", "Thông báo ",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại ,kiểm tra lại cơ sở dữ liệu của bạn !", "Thông báo ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbb_Mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_Lop_SelectedIndexChanged(sender, e);

           
        }

        private void cbb_Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgDiemMonHP.DataSource = dt.BangDiemHP(cbb_Lop.SelectedValue.ToString(), txt_maMon.Text);
        }

        private void dtgDiemMonHP_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = dtgDiemMonHP.CurrentCell.RowIndex;

                if (!String.IsNullOrEmpty(dtgDiemMonHP.Rows[i].Cells["diemlan1"].Value?.ToString()))
                {
                    double diemLan1 = Convert.ToDouble(dtgDiemMonHP.Rows[i].Cells["diemlan1"].Value);

                    if (diemLan1 >= 0 && diemLan1 <= 10)
                    {
                        dt.Update_Diemlan1(diemLan1, txt_maMon.Text, dtgDiemMonHP.Rows[i].Cells["maSV"].Value.ToString());
                    }
                    else
                    {
                        dtgDiemMonHP.Rows[i].Cells["diemlan1"].Value = "";
                        MessageBox.Show("Bạn chỉ được nhập từ 0 đến 10. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (!String.IsNullOrEmpty(dtgDiemMonHP.Rows[i].Cells["diemlan2"].Value?.ToString()))
                {
                    double diemLan2 = Convert.ToDouble(dtgDiemMonHP.Rows[i].Cells["diemlan2"].Value);

                    if (diemLan2 >= 0 && diemLan2 <= 10)
                    {
                        dt.Update_Diemlan2(diemLan2, txt_maMon.Text, dtgDiemMonHP.Rows[i].Cells["maSV"].Value.ToString());
                    }
                    else
                    {
                        dtgDiemMonHP.Rows[i].Cells["diemlan2"].Value = "";
                        MessageBox.Show("Bạn chỉ được nhập từ 0 đến 10. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá trị nhập không hợp lệ. Vui lòng nhập một số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xử lý: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
