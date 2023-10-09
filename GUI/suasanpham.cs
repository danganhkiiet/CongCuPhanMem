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
    public partial class frm_suasanpham : Form
    {
        DataProviderBUS data = new DataProviderBUS();
        DataGridViewRow row = new DataGridViewRow();
        public frm_suasanpham(DataGridViewRow row)
        {
            InitializeComponent();
            this.row = row;
        }

        private void frm_suasanpham_Load(object sender, EventArgs e)
        {
            cbb_nhacungcap.DataSource = data.TryQuery("select mancc,tenncc from nhacungcap where trangthai = 1");
            cbb_nhacungcap.ValueMember = "mancc";
            cbb_nhacungcap.DisplayMember = "tenncc";// load ncc vao combobox

            txt_cpu.Text = row.Cells["cpu"].Value.ToString();
            txt_giaban.Text = row.Cells["dongia"].Value.ToString();
            txt_mau.Text = row.Cells["mau"].Value.ToString();
            txt_ram.Text = row.Cells["ram"].Value.ToString();
            txt_tensanpham.Text = row.Cells["tensp"].Value.ToString();
            txt_von.Text = row.Cells["von"].Value.ToString();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_cpu.Text = "";
            txt_giaban.Text = "";
            txt_mau.Text = "";
            txt_ram.Text = "";
            txt_tensanpham.Text = "";
            txt_von.Text = "";
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_cpu.Text == "" || txt_giaban.Text == "" || txt_mau.Text == "" || txt_ram.Text == "" ||
                txt_tensanpham.Text == "" || txt_von.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    data.TryNonQuery(String.Format("update sanpham set tensp = N'{0}', dongia = {1}, von = {2}, cpu=N'{3}',ram = N'{4}', mau = N'{5}', mancc = {6} where masp = {7}", txt_tensanpham.Text, decimal.Parse(txt_giaban.Text), float.Parse(txt_von.Text), txt_cpu.Text, txt_ram.Text, txt_mau.Text, cbb_nhacungcap.SelectedValue, int.Parse(row.Cells["masp"].Value.ToString())));
                    MessageBox.Show("Bạn đã sửa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi chi tiết: " + ex);
                }
            }
        }

        private void txt_von_KeyPress(object sender, KeyPressEventArgs e)
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
