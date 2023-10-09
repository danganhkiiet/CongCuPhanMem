using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{

    public partial class frm_quanli_menu : Form
    {
        private TaiKhoanDTO taikhoanDTO;
        private DataProviderBUS data = new DataProviderBUS();
        public frm_quanli_menu(TaiKhoanDTO taikhoanDTO)
        {
            InitializeComponent();
            this.taikhoanDTO = taikhoanDTO;
        }

        private void btn_themnhanvien_Click(object sender, EventArgs e)
        {
            frm_themnhanvien themnhanvien = new frm_themnhanvien();
            themnhanvien.Show();
        }

        private void btn_xoanhanvien_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                try {
                    DataGridViewRow row = dtg_nhanvien.CurrentRow;
                    data.TryNonQuery(String.Format("update taikhoan set trangthai = 0 where MaTk = {0}" , int.Parse( row.Cells["MaTK"].Value.ToString())));
                    frm_quanli_menu_Load(sender, e);
                }catch(Exception ex)
                {
                    MessageBox.Show("Lỗi chi tiết: " + ex);
                }
            }    
        }

        private void btn_suanhanvien_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtg_nhanvien.CurrentRow;
            frm_suathongtinnhanvien suathongtinnhanvien = new frm_suathongtinnhanvien(row);
            suathongtinnhanvien.Show();
        }
        private bool IsRowEmpty(DataGridViewRow row)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value != null && cell.Value.ToString() != "")
                {
                    return false;
                }
            }
            return true;
        }
        private void btn_xemcacdondatao_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtg_nhanvien.CurrentRow;
            frm_donhangdatao donhangdatao = new frm_donhangdatao(row);
            donhangdatao.Show();
        }

        private void btn_themsanpham_Click(object sender, EventArgs e)
        {
           
            frm_themsanpham themsanpham = new frm_themsanpham(taikhoanDTO);
            themsanpham.Show();
        }

        private void btn_suasanpham_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtg_sanpham.CurrentRow;
            frm_suasanpham suasanpham = new frm_suasanpham(row);
            suasanpham.Show();
        }

        private void btn_themncc_Click(object sender, EventArgs e)
        {
            DataTable ncc = data.TryQuery("select * from nhacungcap where trangthai = 1");//lay bang nha cung cap

            frm_themnhacungcap themnhacungcap = new frm_themnhacungcap(ncc);
            themnhacungcap.Show();
        }

        private void btn_suanhacungcap_Click(object sender, EventArgs e)
        {
            DataTable ncc = data.TryQuery("select * from nhacungcap where trangthai = 1");//lay bang nha cung cap

            DataGridViewRow row = dtg_nhacungcap.CurrentRow;
            frm_suanhacungcap suanhacungcap = new frm_suanhacungcap(row,ncc);
            suanhacungcap.Show();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            frm_dangnhap dangnhap = new frm_dangnhap();
            this.Hide();
            dangnhap.ShowDialog();
            this.Close();
        }
        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            frm_quanli_menu quanli = new frm_quanli_menu(taikhoanDTO);
            this.Hide();
            quanli.ShowDialog();
            this.Close();
        }

        private void btn_xoasanpham_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dtg_sanpham.CurrentRow;
                try
                {
                    data.TryNonQuery(String.Format("update sanpham set trangthai = 0 where masp = {0}", int.Parse(row.Cells["MaSP"].Value.ToString())));
                    MessageBox.Show("Bạn đã xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    frm_quanli_menu_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chi tiết: " + ex);
                }
            }
        }

        private void btn_xoancc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow row = dtg_nhacungcap.CurrentRow;
                    data.TryNonQuery(String.Format("update nhacungcap set trangthai = 0 where mancc = {0}", int.Parse(row.Cells["MaNCC"].Value.ToString())));
                    MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chi tiết: " + ex);
                }
            }
        }
       
        private void frm_quanli_menu_Load(object sender, EventArgs e)
        {
            dtg_sanpham.DataSource = data.TryQuery("select * from sanpham where trangthai = 1");//hien bang san pham
            dtg_nhanvien.DataSource = data.TryQuery("select * from taikhoan where trangthai = 1");//hien bang nhan vien
            dtg_nhacungcap.DataSource = data.TryQuery("select * from nhacungcap where trangthai = 1");//hien bang nha cung cap
            //tong so san pham da ban
            DataTable sldaban = data.TryQuery("select sum(soluong) from ct_hoadon");
            txt_tongspdaban.Text = sldaban.Rows[0].ItemArray[0].ToString();

            //tong doanh thu
            DataTable tongtien = data.TryQuery("select sum(tongtien) from hoadon");
            txt_doanhthu.Text = tongtien.Rows[0].ItemArray[0].ToString();

            //von
            DataTable von = data.TryQuery("select sum(von*ct_hoadon.SoLuong) from sanpham, ct_hoadon where sanpham.MaSP = ct_hoadon.MaSP");
            txt_tongvon.Text = von.Rows[0].ItemArray[0].ToString();

            //loi nhuan
            DataTable loinhuan = data.TryQuery("  select sum(sanpham.dongia*ct_hoadon.SoLuong)-sum(von*ct_hoadon.SoLuong)  from sanpham, ct_hoadon where sanpham.MaSP = ct_hoadon.MaSP");
            txt_loinhuan.Text = loinhuan.Rows[0].ItemArray[0].ToString();

            //top 5 san pham ban chay
            DataTable top5ban = data.TryQuery(" SELECT top 5 MaSP,TenSP ,sum(soluong) as 'Tổng sản phẩm đã bán' FROM ct_hoadon GROUP BY MaSP, TenSP; ");
            dtg_sanphambanchay.DataSource = top5ban;

            //top san pham chay hang
            DataTable spchayhang = data.TryQuery("select MaSp, Tensp, Tenncc, soluong from SANPHAM,NHACUNGCAP ORDER BY soluong asc");
            dtg_chayhang.DataSource = spchayhang;

            //nhanvien
            DataTable nhanvien = data.TryQuery("SELECT top 5 hd.MaTk,HoTen,count(hd.matk) as 'Tổng hóa đơn đã tạo' FROM hoadon hd,taikhoan tk GROUP BY hd.matk,hoten; ");
            dtg_nhanviennangno.DataSource = nhanvien;

        }

        private void dtg_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = dtg_nhanvien.CurrentRow;
                if (IsRowEmpty(row) == false)
                {
                    txt_hoten.Text = row.Cells["HoTen"].Value.ToString();
                    txt_ngaysinh.Text = row.Cells["NgaySinh"].Value.ToString();
                    txt_sodienthoai.Text = row.Cells["SDT"].Value.ToString();
                    txt_ngaytao.Text = row.Cells["NgayTao"].Value.ToString();
                    txt_gmail.Text = row.Cells["Email"].Value.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi chi tiết: " + ex);
            }
        }

        private void dtg_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dtg_sanpham.CurrentRow;
                if (IsRowEmpty(row) == false)
                {
                    txt_tensanpham.Text = row.Cells["TenSP"].Value.ToString();
                    txt_gia.Text = row.Cells["DonGia"].Value.ToString();
                    txt_von.Text = row.Cells["Von"].Value.ToString();
                    txt_soluongton.Text = row.Cells["SoLuong"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chi tiết: " + ex);
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            frm_quanli_menu_Load(sender, e);
        }

        private void btn_load2_Click(object sender, EventArgs e)
        {
            frm_quanli_menu_Load(sender, e);
        }

        private void btn_nhanvienkhoa_Click(object sender, EventArgs e)
        {
            dtg_nhanvien.DataSource = data.TryQuery("select * from taikhoan where trangthai = 0");
        }

        private void dtg_nhanvien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_nhanvien.CurrentRow;
            if (IsRowEmpty(row) == false)
            {
                if (int.Parse(row.Cells["TrangThai"].Value.ToString()) == 0)
                {
                    DialogResult result = MessageBox.Show("Bạn muốn khôi phục tài khoản này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        data.TryNonQuery(String.Format("update taikhoan set trangthai = 1 where matk = {0}", int.Parse(row.Cells["MaTK"].Value.ToString())));
                        MessageBox.Show("Khôi phục tài khoản thành công ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            frm_nhanvien banhang = new frm_nhanvien(taikhoanDTO);
            this.Hide();
            banhang.ShowDialog();
            this.Close();
        }

        private void btn_xemhoadonnhap_Click(object sender, EventArgs e)
        {
            frm_hoadonnhap hoadon = new frm_hoadonnhap();
            hoadon.Show();
        }

        private void btn_thaydoisl_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtg_sanpham.CurrentRow;
            frm_themsoluong soluong = new frm_themsoluong(taikhoanDTO,row);
            soluong.Show();
        }
    }
}
