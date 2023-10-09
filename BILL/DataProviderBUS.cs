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
    public class DataProviderBUS
    {
        DataProvider data = new DataProvider();
        public DataTable TryQuery(string query)
        { 
            return data.excuteQuery(query);
        }
        public int TryNonQuery(string query)
        {
            return data.excuteNonQuery(query);
        }
        public DataTable List_ProviderBUS()
        {
            return data.List_Provider();
        }
    }
}
