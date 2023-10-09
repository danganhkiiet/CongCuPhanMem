using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAL taikhoandal = new TaiKhoanDAL();
        public TaiKhoanDTO DangNhap(string taikhoan,string matkhau)
        {
            return taikhoandal.DangNhap(taikhoan, matkhau);
        }
    }
}
