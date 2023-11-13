namespace BaiTapLon.Forms
{
    partial class FormSearchProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchProduct));
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.txtMauSearch = new System.Windows.Forms.TextBox();
            this.txtHangSearch = new System.Windows.Forms.TextBox();
            this.txtTenDTSearch = new System.Windows.Forms.TextBox();
            this.txtMaDTSearch = new System.Windows.Forms.TextBox();
            this.cbMau = new System.Windows.Forms.CheckBox();
            this.cbHangSX = new System.Windows.Forms.CheckBox();
            this.cbTenDT = new System.Windows.Forms.CheckBox();
            this.cbMaDT = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnBack);
            this.grbSearch.Controls.Add(this.button2);
            this.grbSearch.Controls.Add(this.button1);
            this.grbSearch.Controls.Add(this.btnTimKiem);
            this.grbSearch.Controls.Add(this.txtMauSearch);
            this.grbSearch.Controls.Add(this.txtHangSearch);
            this.grbSearch.Controls.Add(this.txtTenDTSearch);
            this.grbSearch.Controls.Add(this.txtMaDTSearch);
            this.grbSearch.Controls.Add(this.cbMau);
            this.grbSearch.Controls.Add(this.cbHangSX);
            this.grbSearch.Controls.Add(this.cbTenDT);
            this.grbSearch.Controls.Add(this.cbMaDT);
            this.grbSearch.Location = new System.Drawing.Point(1, 1);
            this.grbSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbSearch.Size = new System.Drawing.Size(1120, 513);
            this.grbSearch.TabIndex = 19;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Tìm kiếm sản phẩm";
            // 
            // txtMauSearch
            // 
            this.txtMauSearch.Location = new System.Drawing.Point(794, 180);
            this.txtMauSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMauSearch.Name = "txtMauSearch";
            this.txtMauSearch.Size = new System.Drawing.Size(268, 35);
            this.txtMauSearch.TabIndex = 7;
            this.txtMauSearch.Visible = false;
            // 
            // txtHangSearch
            // 
            this.txtHangSearch.Location = new System.Drawing.Point(794, 100);
            this.txtHangSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtHangSearch.Name = "txtHangSearch";
            this.txtHangSearch.Size = new System.Drawing.Size(268, 35);
            this.txtHangSearch.TabIndex = 6;
            this.txtHangSearch.Visible = false;
            // 
            // txtTenDTSearch
            // 
            this.txtTenDTSearch.Location = new System.Drawing.Point(260, 180);
            this.txtTenDTSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTenDTSearch.Name = "txtTenDTSearch";
            this.txtTenDTSearch.Size = new System.Drawing.Size(268, 35);
            this.txtTenDTSearch.TabIndex = 5;
            this.txtTenDTSearch.Visible = false;
            // 
            // txtMaDTSearch
            // 
            this.txtMaDTSearch.Location = new System.Drawing.Point(260, 100);
            this.txtMaDTSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMaDTSearch.Name = "txtMaDTSearch";
            this.txtMaDTSearch.Size = new System.Drawing.Size(268, 35);
            this.txtMaDTSearch.TabIndex = 4;
            this.txtMaDTSearch.Visible = false;
            // 
            // cbMau
            // 
            this.cbMau.AutoSize = true;
            this.cbMau.Location = new System.Drawing.Point(607, 183);
            this.cbMau.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbMau.Name = "cbMau";
            this.cbMau.Size = new System.Drawing.Size(85, 33);
            this.cbMau.TabIndex = 3;
            this.cbMau.Text = "Màu";
            this.cbMau.UseVisualStyleBackColor = true;
            // 
            // cbHangSX
            // 
            this.cbHangSX.AutoSize = true;
            this.cbHangSX.Location = new System.Drawing.Point(607, 103);
            this.cbHangSX.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbHangSX.Name = "cbHangSX";
            this.cbHangSX.Size = new System.Drawing.Size(135, 33);
            this.cbHangSX.TabIndex = 2;
            this.cbHangSX.Text = "Hãng SX";
            this.cbHangSX.UseVisualStyleBackColor = true;
            // 
            // cbTenDT
            // 
            this.cbTenDT.AutoSize = true;
            this.cbTenDT.Location = new System.Drawing.Point(96, 183);
            this.cbTenDT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbTenDT.Name = "cbTenDT";
            this.cbTenDT.Size = new System.Drawing.Size(121, 33);
            this.cbTenDT.TabIndex = 1;
            this.cbTenDT.Text = "Tên ĐT";
            this.cbTenDT.UseVisualStyleBackColor = true;
            // 
            // cbMaDT
            // 
            this.cbMaDT.AutoSize = true;
            this.cbMaDT.Location = new System.Drawing.Point(96, 103);
            this.cbMaDT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbMaDT.Name = "cbMaDT";
            this.cbMaDT.Size = new System.Drawing.Size(111, 33);
            this.cbMaDT.TabIndex = 0;
            this.cbMaDT.Text = "Mã ĐT";
            this.cbMaDT.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(676, 261);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(286, 72);
            this.button1.TabIndex = 21;
            this.button1.Text = "   Tìm kiếm";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(342, 261);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(286, 72);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "   Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(247, 271);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(286, 72);
            this.button2.TabIndex = 20;
            this.button2.Text = "   Tìm kiếm";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(581, 271);
            this.btnBack.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.btnBack.Size = new System.Drawing.Size(286, 72);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "   Quay lại";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 514);
            this.Controls.Add(this.grbSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SearchProduct";
            this.Text = "SearchProduct";
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtMauSearch;
        private System.Windows.Forms.TextBox txtHangSearch;
        private System.Windows.Forms.TextBox txtTenDTSearch;
        private System.Windows.Forms.TextBox txtMaDTSearch;
        private System.Windows.Forms.CheckBox cbMau;
        private System.Windows.Forms.CheckBox cbHangSX;
        private System.Windows.Forms.CheckBox cbTenDT;
        private System.Windows.Forms.CheckBox cbMaDT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button2;
    }
}