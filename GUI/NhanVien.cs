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
using System.Data;
using System.Data.SqlClient;
namespace GUI
{
    public partial class frm_nhanvien : Form
    {
        private TaiKhoanDTO taikhoanDTO;
        private BillDTO billDTO = new BillDTO();
        private DataProviderBUS data = new DataProviderBUS();
        private DataProductBUS data_product = new DataProductBUS();
        private DataBillBUS data_bill = new DataBillBUS();
        private SanPhamDTO sanpham = new SanPhamDTO();
        private ChiTietHoaDonDTO ct_hoadon = new ChiTietHoaDonDTO();
        private DataBillDetailBus data_detail = new DataBillDetailBus();
        decimal tongtien = 0;
        public frm_nhanvien(TaiKhoanDTO taikhoanDTO)
        {
            InitializeComponent();
            this.taikhoanDTO = taikhoanDTO;
        }

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            //ban hang
            txt_soluongmua.Text = "1";//gán mặc định số lượng mua là 1

            txt_tongtien.Text = tongtien.ToString();// hiển thị tổng tiền lên giao diện

            //load các thương hiệu lên combobox 
            cbb_thuonghieu.ValueMember = "MaNCC";
            cbb_thuonghieu.DisplayMember = "TenNCC";
            cbb_thuonghieu.DataSource = data.List_ProviderBUS();

            //load danh sách sản phẩm lên dtg
            dtg_danhsachsanpham.DataSource = data_product.List_product();

            //gán mặc định 2 combobox
            cbb_thuonghieu.SelectedIndex = -1;
            cbb_giaban.SelectedIndex = -1;

            //load hóa các hóa đơn vào bảng hóa đơn
            dtg_hoadon.DataSource = data_bill.List_Bill();

            //nếu là nhân viên thì ẩn nút quay về
            if (taikhoanDTO.i_Quyen == 1)
            { btn_back.Visible = false;
                btn_quaylai.Visible = false;
            }

        }
        private bool IsRowEmpty(DataGridViewRow row)//kiểm tra có phải dòng rỗng không
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
        private void btn_quaylai_Click(object sender, EventArgs e)//nếu là tài khoản admin thì quay lại trang quản lí
        {
       
            frm_quanli_menu quanli = new frm_quanli_menu(taikhoanDTO);
            this.Hide();
            quanli.ShowDialog();
            this.Close();
        }

        private void dtg_danhsachsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dtg_danhsachsanpham.CurrentRow;
                if (IsRowEmpty(row) == false)
                {
                    txt_tensanpham.Text = row.Cells["TenSP"].Value.ToString();
                    txt_giatien.Text = row.Cells["DonGia"].Value.ToString();
                    txt_soluongton.Text = row.Cells["SoLuong"].Value.ToString();
                    txt_mau.Text = row.Cells["Mau"].Value.ToString();
                    txt_cpu.Text = row.Cells["CPU"].Value.ToString();
                    txt_dungluongram.Text = row.Cells["Ram"].Value.ToString();
                    txt_thuonghieu.Text = row.Cells["MaNCC"].Value.ToString();
                    sanpham.MaSP = int.Parse(row.Cells["MaSp"].Value.ToString());
                    sanpham.TenSP = row.Cells["TenSP"].Value.ToString();
                    sanpham.SoLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());
                    sanpham.DonGia = decimal.Parse(row.Cells["DonGia"].Value.ToString());
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi chi tiết: " + ex);
            }
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            frm_dangnhap dangnhap = new frm_dangnhap();
            this.Hide();
            dangnhap.ShowDialog();
            this.Close();
        }

        private void btn_dangxuat2_Click(object sender, EventArgs e)
        {
            frm_dangnhap dangnhap = new frm_dangnhap();
            this.Hide();
            dangnhap.ShowDialog();
            this.Close();
        }


        int soluongmua = 0;
        private void btn_themvaogio_Click(object sender, EventArgs e)
        {
            int soluong = 0;
            if (txt_hotenKH.Text == "" || txt_sdt.Text == "") MessageBox.Show("Vui lòng điền đầy đủ họ tên và số điện thoại!!", "Thông báo", MessageBoxButtons.OK);
            else
            {

                DataGridViewRow row = dtg_danhsachsanpham.CurrentRow;
                if (IsRowEmpty(row) == false)
                {
                    int flag = 0;
                    foreach(DataGridViewRow item in dtg_donhang.Rows)// kiem tra san pham da co trong don hang chua
                    {
                        if (int.Parse(row.Cells["MaSP"].Value.ToString()) == int.Parse(item.Cells["masp"].Value.ToString()))
                        {
                            flag = 1;
                            soluong = int.Parse(item.Cells["SoLuong"].Value.ToString());// lay so luong mua cua mon hang do
                            break;
                        }
                    }
                    if (flag == 0)// neu san pham chua co trong don hang
                    {
                        if (int.Parse(txt_soluongmua.Text) > int.Parse(txt_soluongton.Text) || int.Parse(txt_soluongton.Text)==0)
                        {
                            MessageBox.Show("Số lượng không đủ đáp ứng yêu cầu, vui lòng chọn lại!!", "Thông báo1", MessageBoxButtons.OK);
                        }
                        else
                        {
                            try
                            {
                                tongtien = tongtien + (decimal)sanpham.DonGia * decimal.Parse(txt_soluongmua.Text);
                                txt_tongtien.Text = tongtien.ToString();
                                dtg_donhang.Rows.Add(txt_hotenKH.Text, sanpham.TenSP, txt_soluongmua.Text, sanpham.DonGia * int.Parse(txt_soluongmua.Text), sanpham.MaSP);
                                soluongmua = soluongmua + int.Parse(txt_soluongmua.Text);//lay so luog mua cua hoa don do
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi chi tiết: " + ex);
                            }
                        }
                    }
                    else// san pham da co trong don hang
                    {
                        soluong = int.Parse(txt_soluongmua.Text) + soluong;
                        if (soluong > int.Parse(txt_soluongton.Text)|| int.Parse(txt_soluongton.Text) == 0)
                        {
                            MessageBox.Show("Số lượng không đủ đáp ứng yêu cầu, vui lòng chọn lại!!", "Thông báo2", MessageBoxButtons.OK);
                            MessageBox.Show(soluong.ToString());
                        }
                        else
                        {
                            try
                            {
                                tongtien = tongtien + (decimal)sanpham.DonGia * soluong;
                                txt_tongtien.Text = tongtien.ToString();

                                foreach (DataGridViewRow item in dtg_donhang.Rows)//xoa dong cu
                                {
                                    if (sanpham.MaSP == int.Parse(item.Cells["masp"].Value.ToString()))
                                    {
                                        dtg_donhang.Rows.Remove(item);
                                        break;
                                    }
                                }
                                dtg_donhang.Rows.Add(txt_hotenKH.Text, sanpham.TenSP, soluong, sanpham.DonGia * int.Parse(txt_soluongmua.Text), sanpham.MaSP);
                                soluongmua = soluongmua + int.Parse(txt_soluongmua.Text) + soluong;//lay so luog mua cua hoa don do
                                soluong = 0;// gán lại soluong
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("Lỗi chi tiết: " + ex);
                            }
                        }
                    }    
                }
            }
        }
        private void btn_taodonhang_Click(object sender, EventArgs e)
        {
            if (dtg_donhang.Rows.Count != 0)
            {
                try
                {
                    billDTO.MaTK = taikhoanDTO.i_MaTaiKhoan;
                    billDTO.TongTien = float.Parse(txt_tongtien.Text);
                    billDTO.SDT = txt_sdt.Text;
                    billDTO.TenKH = txt_hotenKH.Text;
                    billDTO.TongSanPham = soluongmua;
                    data_bill.Add_Bill(billDTO);//them 1 hoa don moi
                    try
                    {
                        DataTable mahd = new DataTable();
                        mahd = data_bill.Max_mahd();// lay bang co hoa don lon nhat
                        int mahoadon = int.Parse(mahd.Rows[0].ItemArray[0].ToString());//lay ra so hoa don cao nhat
                        foreach (DataGridViewRow row in dtg_donhang.Rows)
                        {
                            ct_hoadon.MaHD = mahoadon;
                            ct_hoadon.MaSP = int.Parse(row.Cells["masp"].Value.ToString());
                            ct_hoadon.SoLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());
                            ct_hoadon.DonGia = float.Parse(row.Cells["DonGia"].Value.ToString());
                            ct_hoadon.TenSP = row.Cells["tensp"].Value.ToString();
                            data.TryNonQuery(String.Format("update sanpham set soluong = soluong - {0} where masp = {1}", ct_hoadon.SoLuong, ct_hoadon.MaSP));
                            data_detail.Add(ct_hoadon);//them mot chi tiet hoa don moi
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi chi tiết: " + ex);
                    }
                    //in hóa đơn
                    try
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn in hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == result)
                        {
                            printPreviewDialog1.Document = printDocument1;
                            printPreviewDialog1.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi chi tiết: " + ex);
                    }
                    MessageBox.Show("Đã thêm đơn hàng thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    //làm mới form
                    txt_hotenKH.Text = "";
                    txt_sdt.Text = "";
                    txt_diachi.Text = "";
                    tongtien = 0;
                    txt_tongtien.Text = "";
                    dtg_donhang.Rows.Clear();
                    frm_nhanvien_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chi tiết: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_xoagio_Click(object sender, EventArgs e)
        {
            if (dtg_donhang.Rows.Count == 0)
            {
                MessageBox.Show("Không có đơn hàng để xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    DataGridViewRow row = dtg_donhang.CurrentRow;
                    tongtien = tongtien - decimal.Parse(row.Cells["DonGia"].Value.ToString());
                    soluongmua = soluongmua - int.Parse(row.Cells["SoLuong"].Value.ToString());
                    txt_tongtien.Text = tongtien.ToString();
                    dtg_donhang.Rows.Remove(dtg_donhang.CurrentRow);
                    txt_tongtien.Text = tongtien.ToString();
                  //  soluongmua = soluongmua - int.Parse(row.Cells["SoLuong"].Value.ToString());
                }catch(Exception ex)
                {
                    MessageBox.Show("Lỗi chi tiết: "+ex);
                }
            }
        }

        private void txt_soluongmua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) == true && !char.IsNumber(e.KeyChar) == true && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) == true && !char.IsNumber(e.KeyChar) == true && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            dtg_danhsachsanpham.DataSource = data_product.Serch(txt_timsanpham.Text);// tim san pham
        }

        private void cbb_thuonghieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_thuonghieu.SelectedIndex == -1)
            {
                dtg_danhsachsanpham.DataSource = data_product.List_product();
            }
            else
            {
            dtg_danhsachsanpham.DataSource = data.TryQuery(String.Format("Select * from sanpham where mancc = {0} and trangthai = 1", cbb_thuonghieu.SelectedValue));
            }
        }

        private void btn_xoatimkiem_Click(object sender, EventArgs e)
        {
            dtg_danhsachsanpham.DataSource = data.TryQuery("select * from sanpham where trangthai = 1");
            cbb_thuonghieu.SelectedIndex = -1;
            cbb_giaban.SelectedIndex = -1;
        }

        private void cbb_giaban_SelectedIndexChanged(object sender, EventArgs e)
        {
            float giaban1 = -1, giaban2 = -1;
            if(cbb_giaban.SelectedIndex == 0)
            {
                giaban1 = 0;
                giaban2 = 5000000;
            }
            if(cbb_giaban.SelectedIndex == 1)
            {
                giaban1 = 5000000;
                giaban2 = 10000000;
            }
            if(cbb_giaban.SelectedIndex == 2)
            {
                giaban1 = 10000000;
                giaban2 = 15000000;
            }
            if(cbb_giaban.SelectedIndex == 3)
            {
                giaban1 = 15000000;
            }

            if(cbb_giaban.SelectedIndex == -1)
            {
                dtg_danhsachsanpham.DataSource = data.TryQuery("select * from sanpham where trangthai = 1");

            }
            else
            {
                if(cbb_giaban.SelectedIndex == 3)
                    dtg_danhsachsanpham.DataSource = data.TryQuery(String.Format("Select * from sanpham where Dongia >= {0} and trangthai = 1", giaban1));
                else
                    dtg_danhsachsanpham.DataSource = data.TryQuery(String.Format("Select * from sanpham where Dongia >= {0} and Dongia <= {1} and trangthai = 1", giaban1, giaban2));
            }
        }

        private void btn_timkiemhoadon_Click(object sender, EventArgs e)
        {
            dtg_hoadon.DataSource = data.TryQuery(String.Format("Select * from hoadon where tenkh like N'%{0}%' and trangthai = 1", txt_tenkh.Text));

        }

        private void btn_resettimkiem_Click(object sender, EventArgs e)
        {
            dtg_hoadon.DataSource = data.TryQuery("select * from hoadon where trangthai = 1");
            txt_tenkh.Text = "";
        }

        private void dtg_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_hoadon.CurrentRow;
            if (IsRowEmpty(row) == false)
            {
                int mahd = int.Parse(row.Cells["MaHD"].Value.ToString());
                dtg_chitiethoadon.DataSource = data.TryQuery(String.Format("select * from ct_hoadon where mahd = {0}", mahd));
                txt_madon.Text = row.Cells["MaHD"].Value.ToString();
                txt_tongtien_donhang.Text = row.Cells["TongTien"].Value.ToString();
                txt_manhanvientao.Text = row.Cells["MaTK"].Value.ToString();
                txt_ngaytao.Text = row.Cells["NgayLapHD"].Value.ToString();
                txt_sl.Text = row.Cells["TongSP"].Value.ToString();
                txt_hoten_donhang.Text = row.Cells["TenKH"].Value.ToString();
                txt_sdt_donhang.Text = row.Cells["SDT"].Value.ToString();
            }
        }

        private void btn_dangxuat_dh_Click(object sender, EventArgs e)
        {
            frm_dangnhap dangnhap = new frm_dangnhap();
            this.Hide();
            dangnhap.ShowDialog();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_quanli_menu quanli = new frm_quanli_menu(taikhoanDTO);
            this.Hide();
            quanli.ShowDialog();
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("Ngày: " + DateTime.Now, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Nhân Viên Lập: " + taikhoanDTO.s_HoTen, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 40));

            e.Graphics.DrawString("NEWPHONE", new Font("Arial", 26, FontStyle.Regular), Brushes.Black, new Point(300, 80));
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Arial", 26, FontStyle.Regular), Brushes.Black, new Point(220, 120));

            e.Graphics.DrawString("Tên khách hàng: " + txt_hotenKH.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 160));

            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 180));
            e.Graphics.DrawString("Tên Sản Phẩm", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 200));
            e.Graphics.DrawString("Số Lượng", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(180, 200));
            e.Graphics.DrawString("Đơn Giá", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(420, 200));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 220));
            int yPos = 240;

            for (int i = 0; i < dtg_donhang.Rows.Count; i++)
            {
                string tenSP = dtg_donhang.Rows[i].Cells["TenSP"].Value.ToString();
                e.Graphics.DrawString(tenSP, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
                e.Graphics.DrawString(dtg_donhang.Rows[i].Cells["SoLuong"].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(200, yPos));
                e.Graphics.DrawString(dtg_donhang.Rows[i].Cells["DonGia"].Value.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(420, yPos));
                yPos += 30;
            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
            e.Graphics.DrawString("Tổng phải trả: " + txt_tongtien.Text + " VNĐ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(500, yPos + 30));
        }
        private void btn_inhoadon_Click(object sender, EventArgs e)
        {
            if (dtg_chitiethoadon.Rows.Count != 0)
            {
                try
                {

                    DialogResult result = MessageBox.Show("Bạn có muốn in hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == result)
                    {
                        printPreviewDialog2.Document = printDocument2;
                        printPreviewDialog2.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chi tiết: " + ex);
                }
            }
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("Ngày: " + txt_ngaytao.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Nhân Viên Lập: " + taikhoanDTO.s_HoTen, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 40));

            e.Graphics.DrawString("NEWPHONE", new Font("Arial", 26, FontStyle.Regular), Brushes.Black, new Point(300, 80));
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Arial", 26, FontStyle.Regular), Brushes.Black, new Point(220, 120));

            e.Graphics.DrawString("Tên khách hàng: " + txt_hoten_donhang.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 160));

            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 180));
            e.Graphics.DrawString("Tên Sản Phẩm", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 200));
            e.Graphics.DrawString("Số Lượng", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(180, 200));
            e.Graphics.DrawString("Đơn Giá", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(420, 200));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 220));
            int yPos = 240;

            for (int i = 0; i < dtg_chitiethoadon.Rows.Count - 1; i++)
            {
                string tensp = dtg_chitiethoadon.Rows[i].Cells["TenSP"].Value.ToString();
                string soluong = dtg_chitiethoadon.Rows[i].Cells["SoLuong"].Value.ToString();
                string dongia = dtg_chitiethoadon.Rows[i].Cells["DonGia"].Value.ToString();
                e.Graphics.DrawString(tensp, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
                e.Graphics.DrawString(soluong, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(200, yPos));
                e.Graphics.DrawString(dongia, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(420, yPos));
                yPos += 30;
            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
            e.Graphics.DrawString("Tổng phải trả: " + txt_tongtien_donhang.Text + " VNĐ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(500, yPos + 30));
        }

    }
}
