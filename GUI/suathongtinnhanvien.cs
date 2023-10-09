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
    public partial class frm_suathongtinnhanvien : Form
    {
        private DataProviderBUS data = new DataProviderBUS();
        DataGridViewRow row = new DataGridViewRow();
        public frm_suathongtinnhanvien(DataGridViewRow row)
        {
            InitializeComponent();
            this.row = row;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_hoten.Text = "";
            txt_matkhau.Text = "";
            txt_gmail.Text = "";
            txt_ngaysinh.Text = "";
            txt_sodienthoai.Text = "";
            cbb_chucvu.SelectedIndex = 0;
        }

        private void frm_suathongtinnhanvien_Load(object sender, EventArgs e)
        {
            txt_hoten.Text = row.Cells["HoTen"].Value.ToString();
            txt_matkhau.Text= row.Cells["MatKhau"].Value.ToString();
            txt_gmailnv.Text= row.Cells["email"].Value.ToString();
            txt_ngaysinh.Text= row.Cells["ngaysinh"].Value.ToString();
            txt_sodienthoai.Text= row.Cells["SDT"].Value.ToString();
            int chucvu = int.Parse(row.Cells["Quyen"].Value.ToString());
            if (chucvu == 0) cbb_chucvu.SelectedIndex = 1;
            else cbb_chucvu.SelectedIndex = 0;
        }
        private bool IsphoneNumber()
        {
            return Regex.Match(txt_sodienthoai.Text, @"^\d{11}$").Success;
        }
        private bool IsGmail()
        {
            return Regex.Match(txt_gmailnv.Text, @"^[a-zA-Z0-9._%+-]+@gmail\.com$").Success;
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            int matk = int.Parse(row.Cells["MaTK"].Value.ToString()), quyen;
            
            if (txt_hoten.Text == "" || txt_matkhau.Text == "" || IsphoneNumber() == false || IsGmail() == false || txt_ngaysinh.Text == "") 
                    MessageBox.Show("Vui lòng điền thông tin cần thiết!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    if (cbb_chucvu.SelectedIndex == 0) quyen = 1;
                    else
                        quyen = 0;
                    data.TryNonQuery(String.Format("update taikhoan set HoTen = N'{0}', MatKhau = '{1}', SDT = {2},Email = '{3}',Quyen = {4} where matk = {5}", txt_hoten.Text, txt_matkhau.Text, txt_sodienthoai.Text,txt_gmailnv.Text,quyen,matk));
                    MessageBox.Show("Thay đổi thông tin thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
