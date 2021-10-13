
namespace QLCuaHangDongHo.GUI
{
    partial class DangNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.cb_HienthiPass = new System.Windows.Forms.CheckBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_UseName = new System.Windows.Forms.TextBox();
            this.btn_DN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(108, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Thông tin đăng nhập";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(268, 194);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(84, 32);
            this.btn_Thoat.TabIndex = 23;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            // 
            // cb_HienthiPass
            // 
            this.cb_HienthiPass.AutoSize = true;
            this.cb_HienthiPass.ForeColor = System.Drawing.Color.Black;
            this.cb_HienthiPass.Location = new System.Drawing.Point(191, 158);
            this.cb_HienthiPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_HienthiPass.Name = "cb_HienthiPass";
            this.cb_HienthiPass.Size = new System.Drawing.Size(115, 17);
            this.cb_HienthiPass.TabIndex = 21;
            this.cb_HienthiPass.Text = "Hiển Thị Mật Khẩu";
            this.cb_HienthiPass.UseVisualStyleBackColor = true;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(191, 131);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(176, 20);
            this.txt_Pass.TabIndex = 20;
            this.txt_Pass.UseSystemPasswordChar = true;
            // 
            // txt_UseName
            // 
            this.txt_UseName.Location = new System.Drawing.Point(191, 96);
            this.txt_UseName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_UseName.Name = "txt_UseName";
            this.txt_UseName.Size = new System.Drawing.Size(176, 20);
            this.txt_UseName.TabIndex = 19;
            // 
            // btn_DN
            // 
            this.btn_DN.BackColor = System.Drawing.SystemColors.Window;
            this.btn_DN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DN.Location = new System.Drawing.Point(113, 194);
            this.btn_DN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.Size = new System.Drawing.Size(92, 32);
            this.btn_DN.TabIndex = 22;
            this.btn_DN.Text = "Đăng Nhập";
            this.btn_DN.UseVisualStyleBackColor = false;
            this.btn_DN.Click += new System.EventHandler(this.btn_DN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(87, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "User name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(87, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.cb_HienthiPass);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_UseName);
            this.Controls.Add(this.btn_DN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.CheckBox cb_HienthiPass;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_UseName;
        private System.Windows.Forms.Button btn_DN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}