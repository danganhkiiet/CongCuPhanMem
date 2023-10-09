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
    public partial class frm_themsoluong : Form
    {
        private TaiKhoanDTO taikhoan = new TaiKhoanDTO();
        private DataProviderBUS data = new DataProviderBUS();
        DataGridViewRow row = new DataGridViewRow();
        public frm_themsoluong(TaiKhoanDTO taikhoan, DataGridViewRow row)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
            this.row = row;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (txt_soluong.Text == "") MessageBox.Show("Vui lòng điền số lượng", "Thông báo", MessageBoxButtons.OK);
            else
            {
                try
                {
                    data.TryNonQuery(String.Format("update sanpham set soluong = soluong + {0} where masp = {1}", int.Parse(txt_soluong.Text), int.Parse(row.Cells["MaSP"].Value.ToString())));
                    data.TryNonQuery(String.Format("insert into hoadonnhap(matk,mancc,tensp,soluong,dongia) values ({0},{1},N'{2}',{3},{4})", taikhoan.i_MaTaiKhoan, int.Parse(row.Cells["MaNCC"].Value.ToString()), row.Cells["TenSP"].Value.ToString(),int.Parse(txt_soluong.Text),decimal.Parse(row.Cells["DonGia"].Value.ToString())));
                    MessageBox.Show("Thêm số lượng thành công", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chi tiết: " + ex);
                }
            }
        }

        private void frm_themsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) == true && !char.IsNumber(e.KeyChar) == true && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) == true && !char.IsNumber(e.KeyChar) == true && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
