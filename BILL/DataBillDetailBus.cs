using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BUS
{
    public class DataBillDetailBus
    {
        private ChiTietHoaDonDTO ct_hoadon;
        private DataBillDetail data = new DataBillDetail();
        public DataTable TryQuery(string query)
        {
            return data.excuteQuery(query);
        }
        public int TryNonQuery(string query)
        {
            return data.excuteNonQuery(query);
        }
        public int Add(ChiTietHoaDonDTO ct_hoadon)
        {
            return data.Add_billdetail(ct_hoadon);
        }
    }
}
