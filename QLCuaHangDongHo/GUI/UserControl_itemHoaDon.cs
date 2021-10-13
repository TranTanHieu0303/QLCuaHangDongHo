using QLCuaHangDongHo.BLL;
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
    public partial class UserControl_itemHoaDon : UserControl
    {
        public itemdonhang _sanp;
        public UserControl_itemHoaDon()
        {
            InitializeComponent();
        }

        private void UserControl_itemHoaDon_Load(object sender, EventArgs e)
        {
            lbl_MSP.Text = _sanp.Masp;
            lbl_tenSP.Text = _sanp.tensp;
            lbl_sl.Text = _sanp.soluong.ToString();
            lbl_dg.Text = _sanp.dongia.ToString();
            lbl_ThanhTien.Text = _sanp.thanhtien.ToString();
        }
    }
}
