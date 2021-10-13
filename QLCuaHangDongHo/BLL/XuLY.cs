using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangDongHo.DAL;

namespace QLCuaHangDongHo.BLL
{
    class XuLY
    {
        QLDongHoDataContext data = new QLDongHoDataContext();
        public NHANVIEN DangNhap(string _UseName, string _Pass)
        {
            NHANVIEN nv = data.NHANVIENs.FirstOrDefault(n => n.USERNAME == _UseName && n.PASS == _Pass);
            if (nv != null)
                return nv;
            else
                return null;
        }
        public CHUCVU Chucvu(string _MACV)
        {
            CHUCVU cv = data.CHUCVUs.FirstOrDefault(c => c.MACV == _MACV);
            return cv;
        }

        internal string Them_Ma_SP()
        {
            List<SANPHAM> lst = data.SANPHAMs.OrderByDescending(s => s.MASP).ToList();
            int Ma;
            if (lst.Count != 0)
                Ma = int.Parse(lst[0].MASP.Remove(0, 2));
            else
                Ma = 0;
            if (Ma + 1 < 10)
                return "SP00" + (Ma + 1);
            if (Ma + 1 < 100)
                return "SP0" + (Ma + 1);
            return "SP" + (Ma + 1);
        }

        internal string LuuAnh(string pma, OpenFileDialog openFileDialog1, Image ptx_HinhAnh)
        {
            string pHinhAnh;
            try
            {

                pHinhAnh = Path.GetFileName((openFileDialog1.FileName)).Trim();
                int d = pHinhAnh.Length;
                string duoi = pHinhAnh.Substring(d - 4);
                pHinhAnh = "H" + pma + duoi;
                int i = 0;
                while (System.IO.File.Exists(Application.StartupPath + "\\Resources\\" + pHinhAnh))
                {
                    pHinhAnh = "H" + pma + "_" + i + duoi;
                    i++;
                };
                switch (openFileDialog1.FilterIndex)
                {
                    case 1:
                        {
                            ptx_HinhAnh.Save(Application.StartupPath + "\\Resources\\" + pHinhAnh, ImageFormat.Jpeg);
                        }
                        break;
                    case 2:
                        {
                            ptx_HinhAnh.Save(Application.StartupPath + "\\Resources\\" + pHinhAnh, ImageFormat.Bmp);
                        }
                        break;
                    case 3:
                        {
                            ptx_HinhAnh.Save(Application.StartupPath + "\\Resources\\" + pHinhAnh, ImageFormat.Gif);
                        }
                        break;
                    case 4:
                        {
                            ptx_HinhAnh.Save(Application.StartupPath + "\\Resources\\" + pHinhAnh, ImageFormat.Png);
                        }
                        break;
                    default:
                        {
                            pHinhAnh = null;
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pHinhAnh = null;
            };
            return pHinhAnh;
        }

        internal List<SANPHAM> dsSanPham_timkiem(string _tukhoa)
        {
            if (_tukhoa != "")
                return data.SANPHAMs.Where(sp => sp.MASP.Contains(_tukhoa) || sp.TENSP.Contains(_tukhoa)).ToList();
            return data.SANPHAMs.Where(sp => sp.MASP == _tukhoa).ToList();
        }

        internal KHACHHANG timkhachhang(string _sdt)
        {
            return data.KHACHHANGs.FirstOrDefault(k => k.SDT == _sdt);
        }

        public string CHuyetsothanhchu(int inputNumber, bool suffix = true)
        {
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
            bool isNegative = false;

            // -12345678.3445435 => "-12345678"
            string sNumber = inputNumber.ToString("#");
            double number = Convert.ToInt32(sNumber);
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }


            int ones, tens, hundreds;

            int positionDigit = sNumber.Length;   // last -> first

            string result = " ";


            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                // 0:       ###
                // 1: nghìn ###,###
                // 2: triệu ###,###,###
                // 3: tỷ    ###,###,###,###
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    // Check last 3 digits remain ### (hundreds tens ones)
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                        if (tens == 1) result = "mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result = " " + result;
                }
            }
            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            return result + (suffix ? " đồng chẵn" : "");
        }

        public bool LuuHD(string _maHD, string _maKH, string _maNV, DateTime _ngayBD, DateTime _ngayKT, string _giamgia, int _tongtien, string _trangthai, string _diachi, List<itemdonhang> _lst)
        {
            try
            {
                HOADON hd = new HOADON();
                hd.MAHD = _maHD;
                hd.MAKH = _maKH;
                hd.MANV = _maNV;
                hd.NGAYBD = _ngayBD;
                hd.NGAYKT = _ngayKT;
                hd.GIAMGIA = _giamgia;
                hd.TONGTIEN = _tongtien;
                hd.TRANGTHAI = _trangthai;
                hd.DIACHI = _diachi;
                data.HOADONs.InsertOnSubmit(hd);
                foreach (itemdonhang item in _lst)
                {
                    CT_HOADON ct = new CT_HOADON();
                    ct.MAHD = hd.MAHD;
                    ct.MASP = item.Masp;
                    ct.SOLUONG = item.soluong;
                    ct.DONGIA = item.dongia;
                    ct.GIAMGIA = null;
                    ct.THANHTIEN = item.thanhtien;
                    data.CT_HOADONs.InsertOnSubmit(ct);
                }
                data.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.Trim(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal string Them_Ma_HD()
        {
            List<HOADON> lst = data.HOADONs.OrderByDescending(s => s.MAHD).ToList();
            int Ma;
            if (lst.Count != 0)
                Ma = int.Parse(lst[0].MAHD.Remove(0, 2));
            else
                Ma = 0;
            if (Ma + 1 < 10)
                return "HD00" + (Ma + 1);
            if (Ma + 1 < 100)
                return "HD0" + (Ma + 1);
            return "HD" + (Ma + 1);
        }

        public bool ThemKH(string _mAKH, string _TenKH, string _SDT, string _Gioitinh, string _pass, string _daichi)
        {
            try
            {
                KHACHHANG kh = new KHACHHANG();
                kh.MAKH = _mAKH;
                kh.TENKH = _TenKH;
                kh.SDT = _SDT;
                kh.GIOITINH = _Gioitinh;
                kh.PASS = _pass;
                kh.DIACHI = _daichi;
                data.KHACHHANGs.InsertOnSubmit(kh);
                data.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.Trim(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal string Them_Ma_KH()
        {
            List<KHACHHANG> lst = data.KHACHHANGs.OrderByDescending(s => s.MAKH).ToList();
            int Ma;
            if (lst.Count != 0)
                Ma = int.Parse(lst[0].MAKH.Remove(0, 2));
            else
                Ma = 0;
            if (Ma + 1 < 10)
                return "KH00" + (Ma + 1);
            if (Ma + 1 < 100)
                return "KH0" + (Ma + 1);
            return "KH" + (Ma + 1);
        }

        public bool ThemSP(string _mASP, string _TenSP, string _hinhAnh, string _mOTA, string _donGia, string _TrangThai, string _SoLuong, string _MaLoai)
        {
            try
            {
                SANPHAM sp = new SANPHAM();
                sp.MASP = _mASP;
                sp.TENSP = _TenSP;
                sp.HINHANH = _hinhAnh;
                sp.MOTA = _mOTA;
                sp.DONGIA = int.Parse(_donGia);
                sp.TRANGTHAI = _TrangThai;
                sp.SOLUONG = int.Parse(_SoLuong);
                sp.MALOAI = _MaLoai;
                data.SANPHAMs.InsertOnSubmit(sp);
                data.SubmitChanges();
               
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.Trim(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool CapNhatSP(string _mASP, string _TenSP, string _hinhAnh, string _mOTA, string _donGia, string _TrangThai, string _SoLuong, string _MaLoai)
        {
            try
            {
                SANPHAM sp = data.SANPHAMs.FirstOrDefault(s => s.MASP == _mASP);
                sp.TENSP = _TenSP;
                sp.HINHANH = _hinhAnh;
                sp.MOTA = _mOTA;
                sp.DONGIA = int.Parse(_donGia);
                sp.TRANGTHAI = _TrangThai;
                sp.SOLUONG = int.Parse(_SoLuong);
                sp.MALOAI = _MaLoai;
                data.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.Trim(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool XoaSP(string _mASP)
        {
            try
            {
                SANPHAM sp = data.SANPHAMs.FirstOrDefault(s => s.MASP == _mASP);

                data.SANPHAMs.DeleteOnSubmit(sp);
                data.SubmitChanges();
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.Trim(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
