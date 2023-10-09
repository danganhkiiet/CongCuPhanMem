using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frm_themsanpham : Form
    {
        DataProviderBUS data = new DataProviderBUS();
        DataGridViewRow row = new DataGridViewRow();
        TaiKhoanDTO taikhoan = new TaiKhoanDTO();
        public frm_themsanpham(TaiKhoanDTO taikhoan)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
        }

        private void frm_themsanpham_Load(object sender, EventArgs e)
        {
            cbb_nhacungcap.DataSource = data.TryQuery("select mancc,tenncc from nhacungcap where trangthai = 1");
            cbb_nhacungcap.ValueMember = "mancc";
            cbb_nhacungcap.DisplayMember = "tenncc";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_cpu.Text = "";
            txt_giaban.Text = "";
            txt_mau.Text = "";
            txt_ram.Text = "";
            txt_soluong.Text = "";
            txt_tensanpham.Text = "";
            txt_von.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(txt_cpu.Text == "" || txt_giaban.Text == "" || txt_mau.Text == "" || txt_ram.Text == ""||
                txt_soluong.Text == ""|| txt_tensanpham.Text == "" || txt_von.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                try
                {
                    data.TryNonQuery(String.Format("insert into sanpham(tensp,mancc,soluong,dongia,von,ram,cpu,mau) values (N'{0}',{1},{2},{3},{4},N'{5}',N'{6}',N'{7}')",txt_tensanpham.Text,cbb_nhacungcap.SelectedValue,int.Parse(txt_soluong.Text),decimal.Parse(txt_giaban.Text),float.Parse(txt_von.Text),txt_cpu.Text,txt_ram.Text,txt_mau.Text));
                    data.TryNonQuery(String.Format("insert into hoadonnhap(matk,mancc,tensp,soluong,dongia,cpu,ram,mau) values ({0},{1},N'{2}',{3},{4},N'{5}',N'{6}',N'{7}')",taikhoan.i_MaTaiKhoan, cbb_nhacungcap.SelectedValue, txt_tensanpham.Text, int.Parse(txt_soluong.Text), decimal.Parse(txt_giaban.Text), txt_cpu.Text, txt_ram.Text, txt_mau.Text));
                    MessageBox.Show("Bạn đã thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    btn_xoa_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi chi tiết: " + ex);
                }
            }    
        }

        private void txt_von_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_giaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
