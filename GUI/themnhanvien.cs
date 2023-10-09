using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DTO;
using BUS;

namespace GUI
{
    public partial class frm_themnhanvien : Form
    {
        private DataProviderBUS data = new DataProviderBUS();
        public frm_themnhanvien()
        {
            InitializeComponent();
        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void frm_themnhanvien_Load(object sender, EventArgs e)
        {
            cbb_chucvu.SelectedIndex = 0;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_hoten.Text = "";
            txt_matkhau.Text = "";
            txt_gmailnv.Text = "";
            txt_ngaysinh.Text = "";
            txt_taikhoan.Text = "";
            txt_sodienthoai.Text = "";
            cbb_chucvu.SelectedIndex = 0;
        }
        private bool IsphoneNumber()
        {
            return Regex.Match(txt_sodienthoai.Text, @"^\d{11}$").Success;
        }
        private bool IsGmail()
        {
            return Regex.Match(txt_gmailnv.Text, @"^[a-zA-Z0-9._%+-]+@gmail\.com$").Success;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if(txt_hoten.Text == "" || txt_matkhau.Text == "" || txt_taikhoan.Text == "" || IsphoneNumber() == false || IsGmail() == false || txt_ngaysinh.Text == "") 
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!", "Thông báo", MessageBoxButtons.OK);
            else
            {
                int chucvu = 1;
                try
                {
                    if (cbb_chucvu.SelectedIndex == 1) 
                        chucvu = 0;
                    data.TryNonQuery(String.Format("insert into taikhoan(hoten,taikhoan,matkhau,quyen,ngaysinh,sdt,email) values(N'{0}','{1}','{2}',{3},'{4}','{5}','{6}')",txt_hoten.Text,txt_taikhoan.Text,txt_matkhau.Text,chucvu,txt_ngaysinh.Text,txt_sodienthoai.Text,txt_gmailnv.Text));
                    MessageBox.Show("Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    btn_xoa_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chi tiết: " + ex);
                }
            }    
        }

        private void txt_sodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) == true && !char.IsNumber(e.KeyChar) == true && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_sodienthoai_TextChanged(object sender, EventArgs e)
        {
            if (IsphoneNumber() == false)
            {
                msg.Active = true;
                lbsdt.Visible = true;
            }
            else
            {
                msg.Active = false;
                lbsdt.Visible = false;
            }
        }

        private void txt_gmailnv_TextChanged(object sender, EventArgs e)
        {
            if (IsGmail() == false)
            {
                msg.Active = true;
                lb_mail.Visible = true;
            }
            else
            {
                msg.Active = false;
                lb_mail.Visible = false;
            }
        }
    }
}
