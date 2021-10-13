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
    public partial class DangNhap : Form
    {
        XuLY XL = new XuLY();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            if (txt_Pass.TextLength == 0 || txt_UseName.TextLength == 0)
                MessageBox.Show("Thông tin đăng nhập không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                NHANVIEN NV = XL.DangNhap(txt_UseName.Text, txt_Pass.Text);
                if (NV == null)
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu của bạn không đúng. Vui lòng kiểm tra lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {                   
                        TrangChu frm = new TrangChu();
                        frm._nv = XL.DangNhap(txt_UseName.Text, txt_Pass.Text);
                        frm._frm = this;
                        frm.Show();
                        this.Hide();
                }
            }
        }
    }
}
