using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;
namespace DAL
{
    public class DataBillDAL
    {
        private BillDTO bill;
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
        public DataTable List_Bill()
        {
            return excuteQuery("select * from hoadon where trangthai = 1");
        }
        public int Add_Bill(BillDTO bill)
        {
                return excuteNonQuery(String.Format("insert into hoadon (matk,tongtien,tenkh,sdt,diachi,tongsp) values ({0},{1},N'{2}',N'{3}',N'{4}',{5})", bill.MaTK, bill.TongTien, bill.TenKH, bill.SDT, bill.DiaChi, bill.TongSanPham));
        }
        public DataTable Max_mahd()
        {
            return excuteQuery("select max(mahd) from hoadon where trangthai = 1");
        }
    }
}
