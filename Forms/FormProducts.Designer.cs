namespace BaiTapLon.Forms
{
    partial class FormProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbPicture = new System.Windows.Forms.GroupBox();
            this.btnChoosePic = new System.Windows.Forms.Button();
            this.ptrImage = new System.Windows.Forms.PictureBox();
            this.grbProductInfo = new System.Windows.Forms.GroupBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.cboTenHang = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbSearchProduct = new System.Windows.Forms.GroupBox();
            this.btnS = new System.Windows.Forms.Button();
            this.txtMauSearch = new System.Windows.Forms.TextBox();
            this.cbMau = new System.Windows.Forms.CheckBox();
            this.txtHangSearch = new System.Windows.Forms.TextBox();
            this.cbHang = new System.Windows.Forms.CheckBox();
            this.txtTenDTSearch = new System.Windows.Forms.TextBox();
            this.cbTenDT = new System.Windows.Forms.CheckBox();
            this.txtMaDTSearch = new System.Windows.Forms.TextBox();
            this.cbMaDT = new System.Windows.Forms.CheckBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnSkipProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnClearProduct = new System.Windows.Forms.Button();
            this.grbPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrImage)).BeginInit();
            this.grbProductInfo.SuspendLayout();
            this.grbSearchProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPicture
            // 
            this.grbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbPicture.Controls.Add(this.btnChoosePic);
            this.grbPicture.Controls.Add(this.ptrImage);
            this.grbPicture.Location = new System.Drawing.Point(1158, 12);
            this.grbPicture.Name = "grbPicture";
            this.grbPicture.Size = new System.Drawing.Size(307, 326);
            this.grbPicture.TabIndex = 16;
            this.grbPicture.TabStop = false;
            this.grbPicture.Text = "Hình ảnh";
            // 
            // btnChoosePic
            // 
            this.btnChoosePic.BackColor = System.Drawing.Color.SteelBlue;
            this.btnChoosePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoosePic.FlatAppearance.BorderSize = 0;
            this.btnChoosePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePic.ForeColor = System.Drawing.Color.White;
            this.btnChoosePic.Location = new System.Drawing.Point(173, 262);
            this.btnChoosePic.Name = "btnChoosePic";
            this.btnChoosePic.Size = new System.Drawing.Size(120, 44);
            this.btnChoosePic.TabIndex = 1;
            this.btnChoosePic.Text = "Chọn";
            this.btnChoosePic.UseVisualStyleBackColor = false;
            this.btnChoosePic.Click += new System.EventHandler(this.btnChoosePic_Click);
            // 
            // ptrImage
            // 
            this.ptrImage.Location = new System.Drawing.Point(28, 46);
            this.ptrImage.Name = "ptrImage";
            this.ptrImage.Size = new System.Drawing.Size(223, 210);
            this.ptrImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrImage.TabIndex = 0;
            this.ptrImage.TabStop = false;
            // 
            // grbProductInfo
            // 
            this.grbProductInfo.Controls.Add(this.grbPicture);
            this.grbProductInfo.Controls.Add(this.txtColor);
            this.grbProductInfo.Controls.Add(this.cboTenHang);
            this.grbProductInfo.Controls.Add(this.label9);
            this.grbProductInfo.Controls.Add(this.txtGhiChu);
            this.grbProductInfo.Controls.Add(this.label8);
            this.grbProductInfo.Controls.Add(this.txtSoLuong);
            this.grbProductInfo.Controls.Add(this.label6);
            this.grbProductInfo.Controls.Add(this.txtGiaBan);
            this.grbProductInfo.Controls.Add(this.label5);
            this.grbProductInfo.Controls.Add(this.txtGiaNhap);
            this.grbProductInfo.Controls.Add(this.label4);
            this.grbProductInfo.Controls.Add(this.label3);
            this.grbProductInfo.Controls.Add(this.txtTenDT);
            this.grbProductInfo.Controls.Add(this.label2);
            this.grbProductInfo.Controls.Add(this.txtMaDT);
            this.grbProductInfo.Controls.Add(this.label1);
            this.grbProductInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbProductInfo.Location = new System.Drawing.Point(0, 100);
            this.grbProductInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbProductInfo.Name = "grbProductInfo";
            this.grbProductInfo.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbProductInfo.Size = new System.Drawing.Size(1465, 351);
            this.grbProductInfo.TabIndex = 0;
            this.grbProductInfo.TabStop = false;
            this.grbProductInfo.Text = "Thông tin sản phẩm";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(469, 44);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(156, 35);
            this.txtColor.TabIndex = 19;
            // 
            // cboTenHang
            // 
            this.cboTenHang.FormattingEnabled = true;
            this.cboTenHang.Location = new System.Drawing.Point(187, 176);
            this.cboTenHang.Name = "cboTenHang";
            this.cboTenHang.Size = new System.Drawing.Size(156, 37);
            this.cboTenHang.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(360, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "Màu";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(469, 176);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(292, 165);
            this.txtGhiChu.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ghi chú";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(469, 110);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(156, 35);
            this.txtSoLuong.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số lượng";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(187, 306);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(156, 35);
            this.txtGiaBan.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá bán";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(187, 242);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(156, 35);
            this.txtGiaNhap.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên hãng";
            // 
            // txtTenDT
            // 
            this.txtTenDT.Location = new System.Drawing.Point(187, 107);
            this.txtTenDT.Name = "txtTenDT";
            this.txtTenDT.Size = new System.Drawing.Size(156, 35);
            this.txtTenDT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên điện thoại";
            // 
            // txtMaDT
            // 
            this.txtMaDT.Location = new System.Drawing.Point(187, 44);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.ReadOnly = true;
            this.txtMaDT.Size = new System.Drawing.Size(156, 35);
            this.txtMaDT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã điện thoại";
            // 
            // grbSearchProduct
            // 
            this.grbSearchProduct.Controls.Add(this.btnS);
            this.grbSearchProduct.Controls.Add(this.txtMauSearch);
            this.grbSearchProduct.Controls.Add(this.cbMau);
            this.grbSearchProduct.Controls.Add(this.txtHangSearch);
            this.grbSearchProduct.Controls.Add(this.cbHang);
            this.grbSearchProduct.Controls.Add(this.txtTenDTSearch);
            this.grbSearchProduct.Controls.Add(this.cbTenDT);
            this.grbSearchProduct.Controls.Add(this.txtMaDTSearch);
            this.grbSearchProduct.Controls.Add(this.cbMaDT);
            this.grbSearchProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbSearchProduct.Location = new System.Drawing.Point(0, 0);
            this.grbSearchProduct.Name = "grbSearchProduct";
            this.grbSearchProduct.Size = new System.Drawing.Size(1465, 100);
            this.grbSearchProduct.TabIndex = 17;
            this.grbSearchProduct.TabStop = false;
            this.grbSearchProduct.Text = "Tìm kiếm";
            // 
            // btnS
            // 
            this.btnS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnS.FlatAppearance.BorderSize = 0;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS.Image = ((System.Drawing.Image)(resources.GetObject("btnS.Image")));
            this.btnS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnS.Location = new System.Drawing.Point(1386, 34);
            this.btnS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnS.Name = "btnS";
            this.btnS.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnS.Size = new System.Drawing.Size(71, 50);
            this.btnS.TabIndex = 20;
            this.btnS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // txtMauSearch
            // 
            this.txtMauSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMauSearch.Location = new System.Drawing.Point(950, 49);
            this.txtMauSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMauSearch.Name = "txtMauSearch";
            this.txtMauSearch.Size = new System.Drawing.Size(125, 35);
            this.txtMauSearch.TabIndex = 12;
            // 
            // cbMau
            // 
            this.cbMau.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMau.AutoSize = true;
            this.cbMau.Location = new System.Drawing.Point(840, 51);
            this.cbMau.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbMau.Name = "cbMau";
            this.cbMau.Size = new System.Drawing.Size(85, 33);
            this.cbMau.TabIndex = 11;
            this.cbMau.Text = "Màu";
            this.cbMau.UseVisualStyleBackColor = true;
            this.cbMau.CheckedChanged += new System.EventHandler(this.cbMau_CheckedChanged);
            // 
            // txtHangSearch
            // 
            this.txtHangSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHangSearch.Location = new System.Drawing.Point(694, 49);
            this.txtHangSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtHangSearch.Name = "txtHangSearch";
            this.txtHangSearch.Size = new System.Drawing.Size(125, 35);
            this.txtHangSearch.TabIndex = 10;
            // 
            // cbHang
            // 
            this.cbHang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbHang.AutoSize = true;
            this.cbHang.Location = new System.Drawing.Point(558, 51);
            this.cbHang.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbHang.Name = "cbHang";
            this.cbHang.Size = new System.Drawing.Size(135, 33);
            this.cbHang.TabIndex = 9;
            this.cbHang.Text = "Hãng SX";
            this.cbHang.UseVisualStyleBackColor = true;
            this.cbHang.CheckedChanged += new System.EventHandler(this.cbHang_CheckedChanged);
            // 
            // txtTenDTSearch
            // 
            this.txtTenDTSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTenDTSearch.Location = new System.Drawing.Point(409, 49);
            this.txtTenDTSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTenDTSearch.Name = "txtTenDTSearch";
            this.txtTenDTSearch.Size = new System.Drawing.Size(125, 35);
            this.txtTenDTSearch.TabIndex = 8;
            // 
            // cbTenDT
            // 
            this.cbTenDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbTenDT.AutoSize = true;
            this.cbTenDT.Location = new System.Drawing.Point(288, 51);
            this.cbTenDT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbTenDT.Name = "cbTenDT";
            this.cbTenDT.Size = new System.Drawing.Size(121, 33);
            this.cbTenDT.TabIndex = 7;
            this.cbTenDT.Text = "Tên ĐT";
            this.cbTenDT.UseVisualStyleBackColor = true;
            this.cbTenDT.CheckedChanged += new System.EventHandler(this.cbTenDT_CheckedChanged);
            // 
            // txtMaDTSearch
            // 
            this.txtMaDTSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaDTSearch.Location = new System.Drawing.Point(138, 49);
            this.txtMaDTSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMaDTSearch.Name = "txtMaDTSearch";
            this.txtMaDTSearch.Size = new System.Drawing.Size(125, 35);
            this.txtMaDTSearch.TabIndex = 6;
            // 
            // cbMaDT
            // 
            this.cbMaDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMaDT.AutoSize = true;
            this.cbMaDT.Location = new System.Drawing.Point(17, 51);
            this.cbMaDT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbMaDT.Name = "cbMaDT";
            this.cbMaDT.Size = new System.Drawing.Size(111, 33);
            this.cbMaDT.TabIndex = 5;
            this.cbMaDT.Text = "Mã ĐT";
            this.cbMaDT.UseVisualStyleBackColor = true;
            this.cbMaDT.CheckedChanged += new System.EventHandler(this.ischecked);
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(3, 487);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.Size = new System.Drawing.Size(1462, 221);
            this.dgvProducts.TabIndex = 19;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick_1);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchProduct.FlatAppearance.BorderSize = 0;
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchProduct.Image")));
            this.btnSearchProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchProduct.Location = new System.Drawing.Point(303, 765);
            this.btnSearchProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSearchProduct.Size = new System.Drawing.Size(189, 50);
            this.btnSearchProduct.TabIndex = 18;
            this.btnSearchProduct.Text = "   Tìm kiếm";
            this.btnSearchProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click_1);
            // 
            // btnSkipProduct
            // 
            this.btnSkipProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkipProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSkipProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkipProduct.FlatAppearance.BorderSize = 0;
            this.btnSkipProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkipProduct.ForeColor = System.Drawing.Color.White;
            this.btnSkipProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnSkipProduct.Image")));
            this.btnSkipProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSkipProduct.Location = new System.Drawing.Point(1280, 765);
            this.btnSkipProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSkipProduct.Name = "btnSkipProduct";
            this.btnSkipProduct.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSkipProduct.Size = new System.Drawing.Size(171, 50);
            this.btnSkipProduct.TabIndex = 5;
            this.btnSkipProduct.Text = "   Bỏ qua";
            this.btnSkipProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSkipProduct.UseVisualStyleBackColor = false;
            this.btnSkipProduct.Click += new System.EventHandler(this.btnSkipProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(511, 765);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddProduct.Size = new System.Drawing.Size(171, 50);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "   Thêm";
            this.btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProduct.FlatAppearance.BorderSize = 0;
            this.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProduct.ForeColor = System.Drawing.Color.White;
            this.btnSaveProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveProduct.Image")));
            this.btnSaveProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveProduct.Location = new System.Drawing.Point(704, 765);
            this.btnSaveProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSaveProduct.Size = new System.Drawing.Size(171, 50);
            this.btnSaveProduct.TabIndex = 3;
            this.btnSaveProduct.Text = "   Lưu";
            this.btnSaveProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveProduct.UseVisualStyleBackColor = false;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnEditProduct.Image")));
            this.btnEditProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProduct.Location = new System.Drawing.Point(896, 765);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEditProduct.Size = new System.Drawing.Size(171, 50);
            this.btnEditProduct.TabIndex = 2;
            this.btnEditProduct.Text = "   Sửa";
            this.btnEditProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnClearProduct
            // 
            this.btnClearProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClearProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearProduct.FlatAppearance.BorderSize = 0;
            this.btnClearProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearProduct.ForeColor = System.Drawing.Color.White;
            this.btnClearProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnClearProduct.Image")));
            this.btnClearProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearProduct.Location = new System.Drawing.Point(1089, 765);
            this.btnClearProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClearProduct.Name = "btnClearProduct";
            this.btnClearProduct.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnClearProduct.Size = new System.Drawing.Size(171, 50);
            this.btnClearProduct.TabIndex = 1;
            this.btnClearProduct.Text = "   Xóa";
            this.btnClearProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearProduct.UseVisualStyleBackColor = false;
            this.btnClearProduct.Click += new System.EventHandler(this.btnClearProduct_Click);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 828);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.grbProductInfo);
            this.Controls.Add(this.grbSearchProduct);
            this.Controls.Add(this.btnSkipProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnClearProduct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormProducts";
            this.Text = "SẢN PHẨM";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.grbPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrImage)).EndInit();
            this.grbProductInfo.ResumeLayout(false);
            this.grbProductInfo.PerformLayout();
            this.grbSearchProduct.ResumeLayout(false);
            this.grbSearchProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnClearProduct;
        private System.Windows.Forms.Button btnSkipProduct;
        private System.Windows.Forms.GroupBox grbPicture;
        private System.Windows.Forms.PictureBox ptrImage;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnChoosePic;
        private System.Windows.Forms.GroupBox grbSearchProduct;
        private System.Windows.Forms.GroupBox grbProductInfo;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.ComboBox cboTenHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.TextBox txtMauSearch;
        private System.Windows.Forms.CheckBox cbMau;
        private System.Windows.Forms.TextBox txtHangSearch;
        private System.Windows.Forms.CheckBox cbHang;
        private System.Windows.Forms.TextBox txtTenDTSearch;
        private System.Windows.Forms.CheckBox cbTenDT;
        private System.Windows.Forms.TextBox txtMaDTSearch;
        private System.Windows.Forms.CheckBox cbMaDT;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}