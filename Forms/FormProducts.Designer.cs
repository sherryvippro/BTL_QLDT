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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnClearProduct = new System.Windows.Forms.Button();
            this.btnSkipProduct = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.grbPicture = new System.Windows.Forms.GroupBox();
            this.btnChoosePic = new System.Windows.Forms.Button();
            this.ptrImage = new System.Windows.Forms.PictureBox();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.grbProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.grbPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrImage)).BeginInit();
            this.SuspendLayout();
            // 
            // grbProductInfo
            // 
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
            this.grbProductInfo.Location = new System.Drawing.Point(0, 0);
            this.grbProductInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbProductInfo.Name = "grbProductInfo";
            this.grbProductInfo.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbProductInfo.Size = new System.Drawing.Size(870, 352);
            this.grbProductInfo.TabIndex = 0;
            this.grbProductInfo.TabStop = false;
            this.grbProductInfo.Text = "Thông tin sản phẩm";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(521, 44);
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
            this.label9.Location = new System.Drawing.Point(369, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "Màu";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(521, 176);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(292, 165);
            this.txtGhiChu.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ghi chú";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(521, 110);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(156, 35);
            this.txtSoLuong.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 113);
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
            // btnClearProduct
            // 
            this.btnClearProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearProduct.FlatAppearance.BorderSize = 0;
            this.btnClearProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearProduct.Location = new System.Drawing.Point(807, 581);
            this.btnClearProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClearProduct.Name = "btnClearProduct";
            this.btnClearProduct.Size = new System.Drawing.Size(171, 50);
            this.btnClearProduct.TabIndex = 1;
            this.btnClearProduct.Text = "Xóa";
            this.btnClearProduct.UseVisualStyleBackColor = true;
            this.btnClearProduct.Click += new System.EventHandler(this.btnClearProduct_Click);
            // 
            // btnSkipProduct
            // 
            this.btnSkipProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkipProduct.FlatAppearance.BorderSize = 0;
            this.btnSkipProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkipProduct.Location = new System.Drawing.Point(998, 581);
            this.btnSkipProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSkipProduct.Name = "btnSkipProduct";
            this.btnSkipProduct.Size = new System.Drawing.Size(171, 50);
            this.btnSkipProduct.TabIndex = 5;
            this.btnSkipProduct.Text = "Bỏ qua";
            this.btnSkipProduct.UseVisualStyleBackColor = true;
            this.btnSkipProduct.Click += new System.EventHandler(this.btnSkipProduct_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(0, 359);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.Size = new System.Drawing.Size(1180, 202);
            this.dgvProducts.TabIndex = 6;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // grbPicture
            // 
            this.grbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbPicture.Controls.Add(this.btnChoosePic);
            this.grbPicture.Controls.Add(this.ptrImage);
            this.grbPicture.Location = new System.Drawing.Point(893, 0);
            this.grbPicture.Name = "grbPicture";
            this.grbPicture.Size = new System.Drawing.Size(287, 352);
            this.grbPicture.TabIndex = 16;
            this.grbPicture.TabStop = false;
            this.grbPicture.Text = "Hình ảnh";
            // 
            // btnChoosePic
            // 
            this.btnChoosePic.Location = new System.Drawing.Point(6, 306);
            this.btnChoosePic.Name = "btnChoosePic";
            this.btnChoosePic.Size = new System.Drawing.Size(120, 44);
            this.btnChoosePic.TabIndex = 1;
            this.btnChoosePic.Text = "Chọn";
            this.btnChoosePic.UseVisualStyleBackColor = true;
            this.btnChoosePic.Click += new System.EventHandler(this.btnChoosePic_Click);
            // 
            // ptrImage
            // 
            this.ptrImage.Location = new System.Drawing.Point(6, 34);
            this.ptrImage.Name = "ptrImage";
            this.ptrImage.Size = new System.Drawing.Size(269, 269);
            this.ptrImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrImage.TabIndex = 0;
            this.ptrImage.TabStop = false;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Location = new System.Drawing.Point(614, 581);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(171, 50);
            this.btnEditProduct.TabIndex = 2;
            this.btnEditProduct.Text = "Sửa";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveProduct.FlatAppearance.BorderSize = 0;
            this.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProduct.Location = new System.Drawing.Point(422, 581);
            this.btnSaveProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(171, 50);
            this.btnSaveProduct.TabIndex = 3;
            this.btnSaveProduct.Text = "Lưu";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Location = new System.Drawing.Point(229, 581);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(171, 50);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 644);
            this.Controls.Add(this.grbPicture);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnSkipProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnClearProduct);
            this.Controls.Add(this.grbProductInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormProducts";
            this.Text = "SẢN PHẨM";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.grbProductInfo.ResumeLayout(false);
            this.grbProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.grbPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProductInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnClearProduct;
        private System.Windows.Forms.Button btnSkipProduct;
        private System.Windows.Forms.DataGridView dgvProducts;
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
        private System.Windows.Forms.GroupBox grbPicture;
        private System.Windows.Forms.PictureBox ptrImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnChoosePic;
        private System.Windows.Forms.ComboBox cboTenHang;
        private System.Windows.Forms.TextBox txtColor;
    }
}