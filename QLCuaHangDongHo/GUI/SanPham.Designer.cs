
namespace QLCuaHangDongHo.GUI
{
    partial class SanPham
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mASPLabel;
            System.Windows.Forms.Label tENSPLabel;
            System.Windows.Forms.Label mOTALabel;
            System.Windows.Forms.Label lbl_DonGia;
            System.Windows.Forms.Label tRANGTHAILabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.dataSet = new QLCuaHangDongHo.DAL.DataSet();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sANPHAMTableAdapter = new QLCuaHangDongHo.DAL.DataSetTableAdapters.SANPHAMTableAdapter();
            this.tableAdapterManager = new QLCuaHangDongHo.DAL.DataSetTableAdapters.TableAdapterManager();
            this.lOAITableAdapter = new QLCuaHangDongHo.DAL.DataSetTableAdapters.LOAITableAdapter();
            this.sANPHAMDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.ptb_HinhAnh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_LoaiSP = new System.Windows.Forms.ComboBox();
            this.lOAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Them = new System.Windows.Forms.ToolStripButton();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_CapNhat = new System.Windows.Forms.ToolStripButton();
            this.btn_HoanTac = new System.Windows.Forms.ToolStripButton();
            this.btn_LuuDaTa = new System.Windows.Forms.ToolStripButton();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            mASPLabel = new System.Windows.Forms.Label();
            tENSPLabel = new System.Windows.Forms.Label();
            mOTALabel = new System.Windows.Forms.Label();
            lbl_DonGia = new System.Windows.Forms.Label();
            tRANGTHAILabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mASPLabel
            // 
            mASPLabel.AutoSize = true;
            mASPLabel.Location = new System.Drawing.Point(161, 57);
            mASPLabel.Name = "mASPLabel";
            mASPLabel.Size = new System.Drawing.Size(74, 13);
            mASPLabel.TabIndex = 0;
            mASPLabel.Text = "Mã Sản Phẩm";
            // 
            // tENSPLabel
            // 
            tENSPLabel.AutoSize = true;
            tENSPLabel.Location = new System.Drawing.Point(161, 83);
            tENSPLabel.Name = "tENSPLabel";
            tENSPLabel.Size = new System.Drawing.Size(78, 13);
            tENSPLabel.TabIndex = 2;
            tENSPLabel.Text = "Tên Sản Phẩm";
            // 
            // mOTALabel
            // 
            mOTALabel.AutoSize = true;
            mOTALabel.Location = new System.Drawing.Point(523, 86);
            mOTALabel.Name = "mOTALabel";
            mOTALabel.Size = new System.Drawing.Size(38, 13);
            mOTALabel.TabIndex = 6;
            mOTALabel.Text = "Mô Tả";
            // 
            // lbl_DonGia
            // 
            lbl_DonGia.AutoSize = true;
            lbl_DonGia.Location = new System.Drawing.Point(523, 31);
            lbl_DonGia.Name = "lbl_DonGia";
            lbl_DonGia.Size = new System.Drawing.Size(49, 13);
            lbl_DonGia.TabIndex = 8;
            lbl_DonGia.Text = "Đơn Giá:";
            // 
            // tRANGTHAILabel
            // 
            tRANGTHAILabel.AutoSize = true;
            tRANGTHAILabel.Location = new System.Drawing.Point(523, 57);
            tRANGTHAILabel.Name = "tRANGTHAILabel";
            tRANGTHAILabel.Size = new System.Drawing.Size(62, 13);
            tRANGTHAILabel.TabIndex = 10;
            tRANGTHAILabel.Text = "Trạng Thái:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(161, 109);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(56, 13);
            sOLUONGLabel.TabIndex = 12;
            sOLUONGLabel.Text = "Số Lượng:";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            this.sANPHAMBindingSource.DataSource = this.dataSet;
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGCHAMCONGTableAdapter = null;
            this.tableAdapterManager.CHUCVUTableAdapter = null;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.CT_NGAYLAMTableAdapter = null;
            this.tableAdapterManager.CT_NHAPHANGTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.LOAITableAdapter = this.lOAITableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHAPHANGTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = this.sANPHAMTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLCuaHangDongHo.DAL.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOAITableAdapter
            // 
            this.lOAITableAdapter.ClearBeforeFill = true;
            // 
            // sANPHAMDataGridView
            // 
            this.sANPHAMDataGridView.AutoGenerateColumns = false;
            this.sANPHAMDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sANPHAMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sANPHAMDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.sANPHAMDataGridView.DataSource = this.sANPHAMBindingSource;
            this.sANPHAMDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sANPHAMDataGridView.Location = new System.Drawing.Point(3, 16);
            this.sANPHAMDataGridView.Name = "sANPHAMDataGridView";
            this.sANPHAMDataGridView.Size = new System.Drawing.Size(854, 229);
            this.sANPHAMDataGridView.TabIndex = 1;
            this.sANPHAMDataGridView.SelectionChanged += new System.EventHandler(this.sANPHAMDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MASP";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Sản Phẩm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENSP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Sản Phẩn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HINHANH";
            this.dataGridViewTextBoxColumn3.HeaderText = "HINHANH";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MOTA";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mô Tả";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn5.HeaderText = "Đơn Giá";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TRANGTHAI";
            this.dataGridViewTextBoxColumn6.HeaderText = "Trạng Thái";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn7.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MALOAI";
            this.dataGridViewTextBoxColumn8.HeaderText = "Mã Loại";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sANPHAMDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 248);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_OpenFile);
            this.groupBox2.Controls.Add(this.ptb_HinhAnh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbb_LoaiSP);
            this.groupBox2.Controls.Add(mASPLabel);
            this.groupBox2.Controls.Add(this.txt_MaSP);
            this.groupBox2.Controls.Add(tENSPLabel);
            this.groupBox2.Controls.Add(this.txt_TenSP);
            this.groupBox2.Controls.Add(mOTALabel);
            this.groupBox2.Controls.Add(this.txt_MoTa);
            this.groupBox2.Controls.Add(lbl_DonGia);
            this.groupBox2.Controls.Add(this.txt_DonGia);
            this.groupBox2.Controls.Add(tRANGTHAILabel);
            this.groupBox2.Controls.Add(this.txt_TrangThai);
            this.groupBox2.Controls.Add(sOLUONGLabel);
            this.groupBox2.Controls.Add(this.txt_SoLuong);
            this.groupBox2.Location = new System.Drawing.Point(12, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 208);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết";
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(44, 172);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenFile.TabIndex = 19;
            this.btn_OpenFile.Text = "Open File";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // ptb_HinhAnh
            // 
            this.ptb_HinhAnh.Location = new System.Drawing.Point(16, 19);
            this.ptb_HinhAnh.Name = "ptb_HinhAnh";
            this.ptb_HinhAnh.Size = new System.Drawing.Size(139, 147);
            this.ptb_HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_HinhAnh.TabIndex = 17;
            this.ptb_HinhAnh.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Loại Sản Phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbb_LoaiSP
            // 
            this.cbb_LoaiSP.DataSource = this.lOAIBindingSource;
            this.cbb_LoaiSP.DisplayMember = "TENLOAI";
            this.cbb_LoaiSP.FormattingEnabled = true;
            this.cbb_LoaiSP.Location = new System.Drawing.Point(256, 28);
            this.cbb_LoaiSP.Name = "cbb_LoaiSP";
            this.cbb_LoaiSP.Size = new System.Drawing.Size(189, 21);
            this.cbb_LoaiSP.TabIndex = 15;
            this.cbb_LoaiSP.ValueMember = "MALOAI";
            // 
            // lOAIBindingSource
            // 
            this.lOAIBindingSource.DataMember = "LOAI";
            this.lOAIBindingSource.DataSource = this.dataSet;
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "MASP", true));
            this.txt_MaSP.Location = new System.Drawing.Point(256, 54);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(189, 20);
            this.txt_MaSP.TabIndex = 1;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "TENSP", true));
            this.txt_TenSP.Location = new System.Drawing.Point(256, 80);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(189, 20);
            this.txt_TenSP.TabIndex = 3;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "MOTA", true));
            this.txt_MoTa.Location = new System.Drawing.Point(602, 83);
            this.txt_MoTa.Multiline = true;
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(210, 43);
            this.txt_MoTa.TabIndex = 7;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "DONGIA", true));
            this.txt_DonGia.Location = new System.Drawing.Point(602, 28);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(210, 20);
            this.txt_DonGia.TabIndex = 9;
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "TRANGTHAI", true));
            this.txt_TrangThai.Location = new System.Drawing.Point(602, 54);
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.Size = new System.Drawing.Size(210, 20);
            this.txt_TrangThai.TabIndex = 11;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "SOLUONG", true));
            this.txt_SoLuong.Location = new System.Drawing.Point(256, 106);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(189, 20);
            this.txt_SoLuong.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Them,
            this.btn_Xoa,
            this.btn_CapNhat,
            this.btn_HoanTac,
            this.btn_LuuDaTa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 43);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Them
            // 
            this.btn_Them.AutoSize = false;
            this.btn_Them.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 40);
            this.btn_Them.Text = "Thêm";
            this.btn_Them.ToolTipText = "Thêm tài khoản";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AutoSize = false;
            this.btn_Xoa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 40);
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.ToolTipText = "Xóa tài khoản";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.AutoSize = false;
            this.btn_CapNhat.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_CapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(140, 40);
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.ToolTipText = "Cập Nhật thông tin  tài khoản";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_HoanTac
            // 
            this.btn_HoanTac.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoanTac.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_HoanTac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_HoanTac.Name = "btn_HoanTac";
            this.btn_HoanTac.Size = new System.Drawing.Size(102, 40);
            this.btn_HoanTac.Text = "Hoàn Tác";
            this.btn_HoanTac.ToolTipText = "Về Trạng Thái Cũ";
            // 
            // btn_LuuDaTa
            // 
            this.btn_LuuDaTa.AutoSize = false;
            this.btn_LuuDaTa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuDaTa.Image = ((System.Drawing.Image)(resources.GetObject("btn_LuuDaTa.Image")));
            this.btn_LuuDaTa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_LuuDaTa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_LuuDaTa.Name = "btn_LuuDaTa";
            this.btn_LuuDaTa.Size = new System.Drawing.Size(100, 40);
            this.btn_LuuDaTa.Text = "Lưu";
            this.btn_LuuDaTa.ToolTipText = "Lưu tất cả thông tin đã chỉnh sữa vào DataBase";
            this.btn_LuuDaTa.Click += new System.EventHandler(this.btn_LuuDaTa_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SanPham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DAL.DataSet dataSet;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private DAL.DataSetTableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private DAL.DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DAL.DataSetTableAdapters.LOAITableAdapter lOAITableAdapter;
        private System.Windows.Forms.DataGridView sANPHAMDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.TextBox txt_MoTa;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_TrangThai;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Them;
        private System.Windows.Forms.ToolStripButton btn_Xoa;
        private System.Windows.Forms.ToolStripButton btn_CapNhat;
        private System.Windows.Forms.ToolStripButton btn_HoanTac;
        private System.Windows.Forms.ToolStripButton btn_LuuDaTa;
        private System.Windows.Forms.BindingSource lOAIBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.PictureBox ptb_HinhAnh;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}