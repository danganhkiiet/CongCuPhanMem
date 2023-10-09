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

namespace GUI
{
    public partial class frm_suanhacungcap : Form
    {
        private DataProviderBUS data = new DataProviderBUS();
        private DataGridViewRow row = new DataGridViewRow();
        DataTable ncc = new DataTable();
        public frm_suanhacungcap(DataGridViewRow row, DataTable ncc)
        {
            InitializeComponent();
            this.row = row;
            this.ncc = ncc;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_diachincc.Text = "";
            txt_mailncc.Text = "";
            txt_sdt.Text = "";
            txt_tenncc.Text = "";
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_diachincc.Text == "" || txt_mailncc.Text == "" || txt_sdt.Text == "" || txt_tenncc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int flag = 1;
                foreach (DataRow row in ncc.Rows)
                {
                    if (txt_tenncc.Text == row.ItemArray[1].ToString())
                    {
                        MessageBox.Show("Nhà cung cấp này đã tồn tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        flag = 0;
                    }
                }
                if (flag == 1)
                {
                    try
                    {
                        data.TryNonQuery(String.Format("update nhacungcap set tenncc = N'{0}',diachi = N'{1}',sdt = '{2}',email=N'{3}'", txt_tenncc.Text, txt_diachincc.Text, txt_sdt.Text, txt_gmail.Text));
                        MessageBox.Show("Bạn đã sủa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        btn_xoa_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("lỗi chi tiết: " + ex);
                    }
                }
            }
        }

        private void frm_suanhacungcap_Load(object sender, EventArgs e)
        {

        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) == true && !char.IsNumber(e.KeyChar) == true && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
