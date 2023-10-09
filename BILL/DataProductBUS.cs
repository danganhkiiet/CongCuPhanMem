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
    public class DataProductBUS
    {
        DataProductDAL data = new DataProductDAL();
        public DataTable TryQuery(string query)
        {
            return data.excuteQuery(query);
        }
        public int TryNonQuery(string query)
        {
            return data.excuteNonQuery(query);
        }
        public DataTable Serch(string s)
        {
            return data.Serch_Product(s);
        }
        public DataTable List_product()
        {
            return data.List_Product();
        }
    }
}
