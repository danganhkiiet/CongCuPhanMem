using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TaiKhoanDAL
    {
        public TaiKhoanDTO DangNhap(string taikhoan, string matkhau)
        {
            TaiKhoanDTO taikhoanDTO = null;
            using (SqlConnection connection = DataAccess.GetConnection())
            {

                SqlCommand cmd = new SqlCommand("Select * from TaiKhoan where TaiKhoan = @TaiKhoan and MatKhau = @MatKhau", connection);
                cmd.Parameters.AddWithValue("@TaiKhoan", taikhoan);
                cmd.Parameters.AddWithValue("@MatKhau", matkhau);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    taikhoanDTO = new TaiKhoanDTO();
                    taikhoanDTO.i_MaTaiKhoan = reader.GetInt32(0);
                    taikhoanDTO.s_HoTen = reader.GetString(1);
                    taikhoanDTO.s_TaiKhoan = reader.GetString(2);
                    taikhoanDTO.s_MatKhau = reader.GetString(3);
                    taikhoanDTO.i_Quyen = reader.GetInt32(4);
                    taikhoanDTO.i_TrangThai=reader.GetInt32(5);
                    taikhoanDTO.s_NgaySinh = reader.GetDateTime(6).ToString();
                    taikhoanDTO.s_SDT = reader.GetString(7);
                    taikhoanDTO.s_Email = reader.GetString(8);
                    taikhoanDTO.s_NgayTao = reader.GetDateTime(9).ToString();
                }  
                reader.Close();
            }

                return taikhoanDTO;
        }
    }
}
