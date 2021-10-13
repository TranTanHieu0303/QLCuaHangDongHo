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
    public partial class SanPham : Form
    {
        XuLY XL = new XuLY();
        string pHinhAnh;
        bool chonanh = false;
        public SanPham()
        {
            InitializeComponent();
        }

        private void sANPHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sANPHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.LOAI' table. You can move, or remove it, as needed.
            this.lOAITableAdapter.Fill(this.dataSet.LOAI);
            // TODO: This line of code loads data into the 'dataSet.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.dataSet.SANPHAM);
            btn_OpenFile.Visible = false;
            btn_HoanTac.Visible = false;
            btn_LuuDaTa.Visible = false;
            settext(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            sANPHAMDataGridView.ClearSelection();
            sANPHAMDataGridView.AllowUserToAddRows = true;
            settextnull();
            btn_CapNhat.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_LuuDaTa.Visible = true;
            btn_HoanTac.Visible = true;
            btn_OpenFile.Visible = true;
            txt_MaSP.Text = XL.Them_Ma_SP();
            settext(true);
            txt_MaSP.Enabled = false;
        }

        private void settext(bool set)
        {
            cbb_LoaiSP.Enabled = set;
            txt_MaSP.Enabled = set;
            txt_TenSP.Enabled = set;
            txt_DonGia.Enabled = set;
            txt_TrangThai.Enabled = set;
            txt_MoTa.Enabled = set;
            txt_SoLuong.Enabled = set;
        }

        private void settextnull()
        {
            txt_TenSP.Text = null;
            txt_DonGia.Text = null;
            txt_TrangThai.Text = null;
            txt_SoLuong.Text = null;
            txt_MoTa.Text = null;
            ptb_HinhAnh.Image = Image.FromFile("Resources\\add_hinh.png");
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_LuuDaTa.Visible = true;
            btn_HoanTac.Visible = true;
            btn_OpenFile.Visible = true;
            settext(true);
            txt_MaSP.Enabled = false;
        }

        private void btn_LuuDaTa_Click(object sender, EventArgs e)
        {
            if (chonanh)
                pHinhAnh = XL.LuuAnh(txt_MaSP.Text, openFile, ptb_HinhAnh.Image);

            if (btn_Them.Enabled)
            {
                bool kq = XL.ThemSP(txt_MaSP.Text, txt_TenSP.Text, pHinhAnh, txt_MoTa.Text, txt_DonGia.Text, txt_TrangThai.Text, txt_SoLuong.Text, cbb_LoaiSP.SelectedValue.ToString());
                if (kq)
                {
                    MessageBox.Show("Thêm Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                btn_CapNhat.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_LuuDaTa.Visible = false;
                btn_HoanTac.Visible = false;
                btn_OpenFile.Visible = false;
                this.sANPHAMTableAdapter.Fill(this.dataSet.SANPHAM);
            }
            else
            {
                bool kq = XL.CapNhatSP(txt_MaSP.Text, txt_TenSP.Text, pHinhAnh, txt_MoTa.Text, txt_DonGia.Text, txt_TrangThai.Text, txt_SoLuong.Text, cbb_LoaiSP.SelectedValue.ToString());
                if (kq)
                {
                    MessageBox.Show("Cập Nhật Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cật Nhật Không Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btn_Them.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_LuuDaTa.Visible = false;
                btn_HoanTac.Visible = false;
                btn_OpenFile.Visible = false;
                settext(false);
                this.sANPHAMTableAdapter.Fill(this.dataSet.SANPHAM);
            }
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            openFile.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            openFile.Title = "Open an Image File";
            DialogResult dr = openFile.ShowDialog();
            if (dr == DialogResult.OK)
            {

                ptb_HinhAnh.Image = Image.FromFile(openFile.FileName);
                chonanh = true;

            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                bool kq = XL.XoaSP(txt_MaSP.Text);
                if (kq)
                {
                    MessageBox.Show("Xóa Thành Công", "Xóa Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.sANPHAMTableAdapter.Fill(this.dataSet.SANPHAM);
                }
                else
                    MessageBox.Show("Xóa Không Thành Công", "Xóa Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sANPHAMDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (sANPHAMDataGridView.CurrentRow != null)
            {
                if (sANPHAMDataGridView.CurrentRow.Cells[2].Value.ToString() != "")
                {
                    pHinhAnh = sANPHAMDataGridView.CurrentRow.Cells[2].Value.ToString();
                    ptb_HinhAnh.Image = Image.FromFile("Resources\\" + pHinhAnh);
                    cbb_LoaiSP.SelectedValue = sANPHAMDataGridView.CurrentRow.Cells[7].Value.ToString();
                }
                else
                {
                    ptb_HinhAnh.Image = Image.FromFile("Resources\\erorr.png");
                }

            }
        }
    }
}
