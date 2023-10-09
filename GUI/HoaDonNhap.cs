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
    public partial class frm_hoadonnhap : Form
    {
        private DataProviderBUS data = new DataProviderBUS();
        public frm_hoadonnhap()
        {
            InitializeComponent();
        }

        private void frm_hoadonnhap_Load(object sender, EventArgs e)
        {
            dtg_hoadonnhap.DataSource = data.TryQuery("select * from hoadonnhap");
        }
    }
}
