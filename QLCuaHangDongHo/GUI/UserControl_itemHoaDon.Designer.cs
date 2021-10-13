
namespace QLCuaHangDongHo.GUI
{
    partial class UserControl_itemHoaDon
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.lbl_dg = new System.Windows.Forms.Label();
            this.lbl_sl = new System.Windows.Forms.Label();
            this.lbl_tenSP = new System.Windows.Forms.Label();
            this.lbl_MSP = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.Location = new System.Drawing.Point(275, 18);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(98, 13);
            this.lbl_ThanhTien.TabIndex = 22;
            this.lbl_ThanhTien.Text = "Thành Tiền";
            this.lbl_ThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_dg
            // 
            this.lbl_dg.Location = new System.Drawing.Point(206, 18);
            this.lbl_dg.Name = "lbl_dg";
            this.lbl_dg.Size = new System.Drawing.Size(63, 13);
            this.lbl_dg.TabIndex = 21;
            this.lbl_dg.Text = "Đơn Giá";
            this.lbl_dg.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_sl
            // 
            this.lbl_sl.AutoSize = true;
            this.lbl_sl.Location = new System.Drawing.Point(180, 18);
            this.lbl_sl.Name = "lbl_sl";
            this.lbl_sl.Size = new System.Drawing.Size(20, 13);
            this.lbl_sl.TabIndex = 20;
            this.lbl_sl.Text = "SL";
            // 
            // lbl_tenSP
            // 
            this.lbl_tenSP.AutoSize = true;
            this.lbl_tenSP.Location = new System.Drawing.Point(73, 18);
            this.lbl_tenSP.Name = "lbl_tenSP";
            this.lbl_tenSP.Size = new System.Drawing.Size(78, 13);
            this.lbl_tenSP.TabIndex = 19;
            this.lbl_tenSP.Text = "Tên Sản Phẩm";
            // 
            // lbl_MSP
            // 
            this.lbl_MSP.AutoSize = true;
            this.lbl_MSP.Location = new System.Drawing.Point(2, 18);
            this.lbl_MSP.Name = "lbl_MSP";
            this.lbl_MSP.Size = new System.Drawing.Size(39, 13);
            this.lbl_MSP.TabIndex = 18;
            this.lbl_MSP.Text = "Mã SP";
            // 
            // btn_xoa
            // 
            this.btn_xoa.AutoSize = true;
            this.btn_xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Image = global::QLCuaHangDongHo.Properties.Resources.close_icon__1_;
            this.btn_xoa.Location = new System.Drawing.Point(376, 8);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(38, 38);
            this.btn_xoa.TabIndex = 23;
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // UserControl_itemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.lbl_ThanhTien);
            this.Controls.Add(this.lbl_dg);
            this.Controls.Add(this.lbl_sl);
            this.Controls.Add(this.lbl_tenSP);
            this.Controls.Add(this.lbl_MSP);
            this.Name = "UserControl_itemHoaDon";
            this.Size = new System.Drawing.Size(412, 51);
            this.Load += new System.EventHandler(this.UserControl_itemHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label lbl_ThanhTien;
        private System.Windows.Forms.Label lbl_dg;
        private System.Windows.Forms.Label lbl_sl;
        private System.Windows.Forms.Label lbl_tenSP;
        private System.Windows.Forms.Label lbl_MSP;
    }
}
