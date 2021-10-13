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
    public partial class UserControl_SanPham : UserControl
    {
        public SANPHAM _sp;
        public UserControl_SanPham()
        {
            InitializeComponent();
        }

        private void UserControl_SanPham_Load(object sender, EventArgs e)
        {
            ptx_hinh.Image = Image.FromFile("Resources\\" + _sp.HINHANH);
            lbl_TenSP.Text = _sp.TENSP;
            lbl_gia.Text = _sp.DONGIA.ToString();
        }
    }
}
