using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public int MaSP { get; set; }
        public string AnhSP { get; set; }
        public string TenSP { get; set; }
        public int MaNCC { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public int TrangThai { get; set; }
        public float Von { get; set; }
        public string Ram { get; set; }
        public string CPU { get; set; }
        public string Mau { get; set; }
    }
}
