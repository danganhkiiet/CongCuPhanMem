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
    public class DataBillDetail
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
        public int Add_billdetail(ChiTietHoaDonDTO ct_hoadon)
        {
            return excuteNonQuery(String.Format("insert into ct_hoadon (mahd,masp,soluong,dongia,tensp) values ({0},{1},{2},{3},N'{4}')",ct_hoadon.MaHD,ct_hoadon.MaSP,ct_hoadon.SoLuong,ct_hoadon.DonGia,ct_hoadon.TenSP));
        }
    }
}
