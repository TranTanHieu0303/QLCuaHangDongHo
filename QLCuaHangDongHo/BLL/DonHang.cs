using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDongHo.BLL
{
    public class DonHang
    {
        public List<itemdonhang> lstSP;
        public DonHang()
        {
            lstSP = new List<itemdonhang>();
        }
        public DonHang(List<itemdonhang> ds)
        {
            lstSP = ds;
        }
        public int tongThanhTien()
        {
            if (lstSP == null)
                return 0;
            return lstSP.Sum(t => t.thanhtien);
        }
        public int Them(string ms)
        {
            itemdonhang sp = lstSP.SingleOrDefault(g => g.Masp == ms);
            if (sp == null)
            {
                itemdonhang a = new itemdonhang(ms);
                if (a == null)
                    return 0;
                lstSP.Add(a);
            }
            else
            {
                sp.soluong += 1;
            }
            return 1;
        }
        public int Them(string ms, int sl)
        {
            itemdonhang sp = lstSP.SingleOrDefault(g => g.Masp == ms);
            if (sp == null)
            {
                itemdonhang a = new itemdonhang(ms, sl);
                if (a == null)
                    return 0;
                lstSP.Add(a);
            }
            else
            {
                sp.soluong += sl;
            }
            return 1;
        }
        public int Them(string ms, int sl, int _gia)
        {
            itemdonhang sp = lstSP.SingleOrDefault(g => g.Masp == ms);
            if (sp == null)
            {
                itemdonhang a = new itemdonhang(ms, sl, _gia);
                if (a == null)
                    return 0;
                lstSP.Add(a);
            }
            else
            {
                sp.soluong += sl;
            }
            return 1;
        }
        public int Bo(string ms)
        {
            itemdonhang sp = lstSP.SingleOrDefault(g => g.Masp == ms);
            lstSP.Remove(sp);
            return 1;
        }
    }
}
