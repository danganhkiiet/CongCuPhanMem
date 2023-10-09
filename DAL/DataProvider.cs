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
    public class DataProvider
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
        public DataTable List_Provider()
        {
            return excuteQuery("select * from nhacungcap where trangthai = 1");
        }
    }
}
