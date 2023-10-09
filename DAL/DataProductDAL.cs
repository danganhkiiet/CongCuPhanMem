using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DataProductDAL
    {
       
        public DataTable excuteQuery(string query)
        {
            using (SqlConnection connection = DataAccess.GetConnection())
            {
                DataTable data = new DataTable();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(data);
                connection.Close();
                return data;
            }
        }
        public int excuteNonQuery(string query)
        {
            int count = 0;
            using (SqlConnection connection = DataAccess.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                count = cmd.ExecuteNonQuery();
                connection.Close();
                return count;
            }
        }
        public DataTable List_Product()
        {
            return excuteQuery("select * from sanpham where trangthai = 1");
        }
        public DataTable Serch_Product(string s)
        {
            return excuteQuery(String.Format(String.Format("Select * from sanpham where tensp like N'%{0}%' and trangthai = 1", s)));
        }
    }
}
