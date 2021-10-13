
namespace QLCuaHangDongHo.GUI
{
    partial class UserControl_SanPham
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
            this.lbl_gia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TenSP = new System.Windows.Forms.Label();
            this.ptx_hinh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptx_hinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_gia
            // 
            this.lbl_gia.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gia.Location = new System.Drawing.Point(304, 26);
            this.lbl_gia.Name = "lbl_gia";
            this.lbl_gia.Size = new System.Drawing.Size(130, 13);
            this.lbl_gia.TabIndex = 7;
            this.lbl_gia.Text = "100000";
            this.lbl_gia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "VND";
            // 
            // lbl_TenSP
            // 
            this.lbl_TenSP.AutoSize = true;
            this.lbl_TenSP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenSP.Location = new System.Drawing.Point(84, 26);
            this.lbl_TenSP.Name = "lbl_TenSP";
            this.lbl_TenSP.Size = new System.Drawing.Size(38, 15);
            this.lbl_TenSP.TabIndex = 5;
            this.lbl_TenSP.Text = "label1";
            // 
            // ptx_hinh
            // 
            this.ptx_hinh.Location = new System.Drawing.Point(12, 3);
            this.ptx_hinh.Name = "ptx_hinh";
            this.ptx_hinh.Size = new System.Drawing.Size(66, 66);
            this.ptx_hinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptx_hinh.TabIndex = 4;
            this.ptx_hinh.TabStop = false;
            // 
            // UserControl_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_gia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_TenSP);
            this.Controls.Add(this.ptx_hinh);
            this.Name = "UserControl_SanPham";
            this.Size = new System.Drawing.Size(476, 72);
            this.Load += new System.EventHandler(this.UserControl_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptx_hinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_gia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TenSP;
        private System.Windows.Forms.PictureBox ptx_hinh;
    }
}
