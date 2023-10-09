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
    public partial class frm_donhangdatao : Form
    {
        private DataProviderBUS data = new DataProviderBUS();
        DataGridViewRow row = new DataGridViewRow();
        public frm_donhangdatao(DataGridViewRow row)
        {
            InitializeComponent();
            this.row = row;
        }

        private void frm_donhangdatao_Load(object sender, EventArgs e)
        {
            int matk = int.Parse(row.Cells["MaTK"].Value.ToString());
            dtg_donhangdatao.DataSource = data.TryQuery(String.Format("select * from hoadon where matk = {0}", matk));
            txt_tennhanvien.Text = row.Cells["HoTen"].Value.ToString();
        }
    }
}
