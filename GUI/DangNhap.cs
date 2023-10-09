using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;


namespace GUI
{
    public partial class frm_dangnhap : Form
    {
        private TaiKhoanBUS taikhoanBUS = new TaiKhoanBUS();
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (txt_taikhoan.Text == "") MessageBox.Show("Vui lòng không để trống tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (txt_matkhau.Text == "") MessageBox.Show("Vui lòng không để trống mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if(txt_matkhau.Text!= "" && txt_taikhoan.Text != "")
            {
                string taikhoan = txt_taikhoan.Text;
                string matkhau = txt_matkhau.Text;

                TaiKhoanDTO taikhoanDTO = taikhoanBUS.DangNhap(taikhoan, matkhau);
                try
                {

                    if (taikhoanDTO != null)
                    {
                        if (taikhoanDTO.i_TrangThai == 0)
                        {
                            MessageBox.Show("Tài khoản của bạn đã bị vô hiệu hóa!!, vui lòng liên hệ admin");
                        }
                        else
                        {


                            MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            if (taikhoanDTO.i_Quyen == 0)
                            {
                                frm_quanli_menu quanli = new frm_quanli_menu(taikhoanDTO);
                                this.Hide();
                                quanli.ShowDialog();
                                this.Close();
                            }
                            if (taikhoanDTO.i_Quyen == 1)
                            {
                                frm_nhanvien nhanvien = new frm_nhanvien(taikhoanDTO);
                                this.Hide();
                                nhanvien.ShowDialog();
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chi tiết: " + ex);
                }

            }    
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {
            txt_matkhau.UseSystemPasswordChar = true;
        }

        private void ckb_anhienmk_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_anhienmk.Checked == false) txt_matkhau.UseSystemPasswordChar = true;
            else txt_matkhau.UseSystemPasswordChar = false;
        }

        private void btn_quenmk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ admin: 0306211158", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
