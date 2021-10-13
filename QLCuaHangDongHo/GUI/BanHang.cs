using QLCuaHangDongHo.BLL;
using QLCuaHangDongHo.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDongHo.GUI
{
    public partial class BanHang : Form
    {
        public NHANVIEN _nv;
        public Form _frm;
        XuLY XL = new XuLY();
        DonHang don = new DonHang();
        List<SANPHAM> lst;
        string maspchon;
        UserControl_SanPham usersp;
        KHACHHANG _kh;
        public BanHang()
        {
            InitializeComponent();
        }

        private void txt_timkiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (lst.Count == 1)
                {
                    don.Them(lst[0].MASP);
                    catnhatdonhang();
                    txt_timkiem.Text = null;
                }
        }

        private void catnhatdonhang()
        {
            List<itemdonhang> l = don.lstSP;
            flowLP_hoadon.Controls.Clear();
            foreach (itemdonhang item in l)
            {
                UserControl_itemHoaDon u = new UserControl_itemHoaDon();
                u._sanp = item;
                u.btn_xoa.Tag = item.Masp;
                u.btn_xoa.Click += Btn_xoa_Click;
                flowLP_hoadon.Controls.Add(u);
            }

            txt_tongtien.Text = string.Format("{0:n0}", don.tongThanhTien());
            if (txt_tongtien.Text == "0")
                lbl_tienchu.Text = "";
            else
                lbl_tienchu.Text = XL.CHuyetsothanhchu(don.tongThanhTien()).ToUpperInvariant();
            if (don.lstSP.Count == 0)
            {
                txt_sdt.Enabled = false;
                txt_tenkh.Enabled = false;
                rdb_nam.Enabled = false;
                rdb_Nu.Enabled = false;
            }
            else
            {
                txt_sdt.Enabled = true;
            }
        }

        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            Button use = (Button)sender;
            don.Bo(use.Tag.ToString());
            catnhatdonhang();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {

        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            lst = XL.dsSanPham_timkiem(txt_timkiem.Text);
            flowLP_timkiemsp.Controls.Clear();
            foreach (SANPHAM item in lst)
            {
                UserControl_SanPham user = new UserControl_SanPham();
                user._sp = item;
                user.Click += User_Click;
                flowLP_timkiemsp.Controls.Add(user);
            }
        }

        private void User_Click(object sender, EventArgs e)
        {
            UserControl_SanPham us = (UserControl_SanPham)sender;
            maspchon = us._sp.MASP;
            txt_sl.Enabled = true;
            txt_sl.Focus();
            txt_sl.ResetText();
            us.BackColor = System.Drawing.Color.WhiteSmoke;
            if (usersp != null)
                usersp.BackColor = System.Drawing.Color.White;
            usersp = (UserControl_SanPham)sender;
        }

        private void txt_sdt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _kh = XL.timkhachhang(txt_sdt.Text);
                if (_kh != null)
                {
                    txt_tenkh.Enabled = true;
                    rdb_nam.Enabled = true;
                    rdb_Nu.Enabled = true;
                    txt_tenkh.Text = _kh.TENKH;
                    if (_kh.GIOITINH == "Nam")
                        rdb_nam.Checked = true;
                    else
                        rdb_Nu.Checked = true;
                }
                else
                {
                    MessageBox.Show("Chưa có thông tin khách hàng, Hãy tạo mới.", "Thông báo");
                    txt_tenkh.Enabled = true;
                    rdb_nam.Enabled = true;
                    rdb_Nu.Enabled = true;
                    txt_tenkh.Text = null;
                    txt_tenkh.Focus();
                }
            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (_kh == null)
            {
                _kh = new KHACHHANG();
                _kh.MAKH = XL.Them_Ma_KH();
                string gt;
                if (rdb_nam.Checked)
                    gt = "Nam";
                else
                    gt = "Nữ";
                XL.ThemKH(_kh.MAKH, txt_tenkh.Text, txt_sdt.Text, gt, null, null);



            }
            string mahd = XL.Them_Ma_HD();
            bool luu = XL.LuuHD(mahd, _kh.MAKH, _nv.MANV, DateTime.Now, DateTime.Now, null, don.tongThanhTien(), "Mua tại cửa hàng", "Cửa Hàng", don.lstSP);
            if (luu)
            {
                MessageBox.Show("Tạo hóa đơn thành công", "Thành công", MessageBoxButtons.YesNo);
                don = new DonHang();
                catnhatdonhang();
                txt_sdt.Text = null;
                txt_tenkh.Text = null;
                txt_sdt.Enabled = false;
                txt_tenkh.Enabled = false;
            }
        }

        private void txt_sl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                don.Them(maspchon, (int)txt_sl.Value);
                catnhatdonhang();
                txt_sl.Enabled = false;
                txt_timkiem.Focus();
                txt_timkiem.Text = null;
            }
        }
    }
}
