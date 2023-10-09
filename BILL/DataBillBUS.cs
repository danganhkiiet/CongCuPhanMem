using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;
namespace BUS
{
    public class DataBillBUS
    {
        private BillDTO bill;
        private DataBillDAL data = new DataBillDAL();
        public DataTable TryQuery(string query)
        {
            return data.excuteQuery(query);
        }
        public int TryNonQuery(string query)
        {
            return data.excuteNonQuery(query);
        }
        public DataTable List_Bill()
        {
            return data.List_Bill();
        }
        public int Add_Bill(BillDTO bill)
        {
            return data.Add_Bill(bill);
        }
        public DataTable Max_mahd()
        {
            return data.Max_mahd();
        }
    }
}
