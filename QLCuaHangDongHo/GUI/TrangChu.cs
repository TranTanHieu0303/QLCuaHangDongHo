using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangDongHo.DAL;
using QLCuaHangDongHo.BLL;

namespace QLCuaHangDongHo.GUI
{
    public partial class TrangChu : Form
    {
        public NHANVIEN _nv;
        public Form _frm;
        XuLY XL = new XuLY();
        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            if (XL.Chucvu(_nv.CHUCVU.ToString()).TENCV.ToString() == "QuanLy")
            {
                btnSanPham.Enabled = true;
                btnHD.Enabled = true;
                btnNhanVien.Enabled = true;
                btnNhapHang.Enabled = true;
                btnKH.Enabled = true;
            }
            else
            {
                btnSanPham.Enabled = true;
                btnNhapHang.Enabled = true;
                btnHD.Enabled = true;
                btnNhanVien.Visible = false;
                btnKH.Enabled = true;
                SanPham fr = new SanPham();
                fr.MdiParent = this;
                fr.MaximizeBox = true;
                fr.Show();
            }
            ptb_hinhanh.Image = Image.FromFile("Resources\\" + _nv.HINHANH.ToString());
            lbl_MANV.Text = _nv.MANV.ToString();
            lbl_TenNv.Text = _nv.TENNV.ToString();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            dismdirent();
            SanPham fr = new SanPham();
            fr.MdiParent = this;
            fr.MaximizeBox = true;
            fr.Show();
        }

        private void dismdirent()
        {
            Form[] childArray = this.MdiChildren;
            foreach (Form childForm in childArray)
            {
                childForm.Close();
            }
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            dismdirent();
            BanHang fr = new BanHang();
            fr.MdiParent = this;
            fr._nv = _nv;
            fr.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức Năng Chưa Phát Triển", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức Năng Chưa Phát Triển", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức Năng Chưa Phát Triển", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                this._frm.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }
    }
}
