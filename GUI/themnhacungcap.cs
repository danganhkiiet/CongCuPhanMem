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
using BUS;

namespace GUI
{
    public partial class frm_themnhacungcap : Form
    {
        private DataProviderBUS data = new DataProviderBUS();
        DataTable ncc = new DataTable();
        public frm_themnhacungcap(DataTable ncc)
        {
            InitializeComponent();
            this.ncc = ncc;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_diachincc.Text = "";
            txt_mailncc.Text = "";
            txt_sdt.Text = "";
            txt_tenncc.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(txt_diachincc.Text == "" || IsGmail() == false || IsphoneNumber() == false || txt_tenncc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int flag = 1;
                foreach(DataRow row in ncc.Rows)
                {
                    if(txt_tenncc.Text== row.ItemArray[1].ToString())
                    {
                        MessageBox.Show("Nhà cung cấp này đã tồn tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        flag = 0;
                    }
                }
                if (flag == 1)
                {
                    try
                    {
                        data.TryNonQuery(String.Format("insert into nhacungcap(tenncc,diachi,sdt,email) values (N'{0}',N'{1}',N'{2}',N'{3}')", txt_tenncc.Text, txt_diachincc.Text, txt_sdt.Text, txt_gmail.Text));
                        MessageBox.Show("Bạn đã thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        btn_xoa_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("lỗi chi tiết: " + ex);
                    }
                    
                }
            }
        }
        private bool IsphoneNumber()
        {
            return   Regex.Match(txt_sdt.Text, @"^\d{11}$").Success;
        }
        private bool IsGmail()
        {
            return    Regex.Match(txt_mailncc.Text, @"^[a-zA-Z0-9._%+-]+@gmail\.com$").Success;
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

        private void txt_mailncc_TextChanged(object sender, EventArgs e)
        {
            if (IsGmail() == false)
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
    }
}
