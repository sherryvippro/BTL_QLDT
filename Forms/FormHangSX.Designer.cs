namespace BaiTapLon.Forms
{
    partial class formHangSX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHangSX));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvHangSX = new System.Windows.Forms.DataGridView();
            this.grbHangSX = new System.Windows.Forms.GroupBox();
            this.grbSearchHang = new System.Windows.Forms.GroupBox();
            this.btnS = new System.Windows.Forms.Button();
            this.txtTenHSearch = new System.Windows.Forms.TextBox();
            this.cbTenH = new System.Windows.Forms.CheckBox();
            this.txtMaHSearch = new System.Windows.Forms.TextBox();
            this.cbMaH = new System.Windows.Forms.CheckBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchHang = new System.Windows.Forms.Button();
            this.btnAddHang = new System.Windows.Forms.Button();
            this.btnSaveHang = new System.Windows.Forms.Button();
            this.btnEditHang = new System.Windows.Forms.Button();
            this.btnClearHang = new System.Windows.Forms.Button();
            this.btnSkipHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangSX)).BeginInit();
            this.grbHangSX.SuspendLayout();
            this.grbSearchHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHangSX
            // 
            this.dgvHangSX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHangSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangSX.Location = new System.Drawing.Point(-6, 263);
            this.dgvHangSX.Name = "dgvHangSX";
            this.dgvHangSX.ReadOnly = true;
            this.dgvHangSX.RowHeadersWidth = 62;
            this.dgvHangSX.RowTemplate.Height = 28;
            this.dgvHangSX.Size = new System.Drawing.Size(1244, 277);
            this.dgvHangSX.TabIndex = 1;
            this.dgvHangSX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangSX_CellClick);
            // 
            // grbHangSX
            // 
            this.grbHangSX.Controls.Add(this.grbSearchHang);
            this.grbHangSX.Controls.Add(this.txtTenHang);
            this.grbHangSX.Controls.Add(this.label2);
            this.grbHangSX.Controls.Add(this.txtMaHang);
            this.grbHangSX.Controls.Add(this.label1);
            this.grbHangSX.Controls.Add(this.dgvHangSX);
            this.grbHangSX.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbHangSX.Location = new System.Drawing.Point(0, 0);
            this.grbHangSX.Name = "grbHangSX";
            this.grbHangSX.Size = new System.Drawing.Size(1244, 546);
            this.grbHangSX.TabIndex = 2;
            this.grbHangSX.TabStop = false;
            this.grbHangSX.Text = "Thông tin về hãng sản xuất";
            // 
            // grbSearchHang
            // 
            this.grbSearchHang.Controls.Add(this.btnS);
            this.grbSearchHang.Controls.Add(this.txtTenHSearch);
            this.grbSearchHang.Controls.Add(this.cbTenH);
            this.grbSearchHang.Controls.Add(this.txtMaHSearch);
            this.grbSearchHang.Controls.Add(this.cbMaH);
            this.grbSearchHang.Location = new System.Drawing.Point(3, 120);
            this.grbSearchHang.Name = "grbSearchHang";
            this.grbSearchHang.Size = new System.Drawing.Size(1241, 100);
            this.grbSearchHang.TabIndex = 18;
            this.grbSearchHang.TabStop = false;
            this.grbSearchHang.Text = "Tìm kiếm";
            // 
            // btnS
            // 
            this.btnS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnS.BackColor = System.Drawing.Color.SteelBlue;
            this.btnS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnS.FlatAppearance.BorderSize = 0;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS.ForeColor = System.Drawing.Color.White;
            this.btnS.Image = ((System.Drawing.Image)(resources.GetObject("btnS.Image")));
            this.btnS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnS.Location = new System.Drawing.Point(651, 41);
            this.btnS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnS.Name = "btnS";
            this.btnS.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnS.Size = new System.Drawing.Size(71, 50);
            this.btnS.TabIndex = 20;
            this.btnS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // txtTenHSearch
            // 
            this.txtTenHSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTenHSearch.Location = new System.Drawing.Point(463, 51);
            this.txtTenHSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTenHSearch.Name = "txtTenHSearch";
            this.txtTenHSearch.Size = new System.Drawing.Size(125, 35);
            this.txtTenHSearch.TabIndex = 8;
            // 
            // cbTenH
            // 
            this.cbTenH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbTenH.AutoSize = true;
            this.cbTenH.Location = new System.Drawing.Point(312, 51);
            this.cbTenH.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbTenH.Name = "cbTenH";
            this.cbTenH.Size = new System.Drawing.Size(141, 33);
            this.cbTenH.TabIndex = 7;
            this.cbTenH.Text = "Tên hãng";
            this.cbTenH.UseVisualStyleBackColor = true;
            this.cbTenH.CheckedChanged += new System.EventHandler(this.cbTenH_CheckedChanged);
            // 
            // txtMaHSearch
            // 
            this.txtMaHSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaHSearch.Location = new System.Drawing.Point(153, 49);
            this.txtMaHSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMaHSearch.Name = "txtMaHSearch";
            this.txtMaHSearch.Size = new System.Drawing.Size(125, 35);
            this.txtMaHSearch.TabIndex = 6;
            // 
            // cbMaH
            // 
            this.cbMaH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMaH.AutoSize = true;
            this.cbMaH.Location = new System.Drawing.Point(17, 51);
            this.cbMaH.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbMaH.Name = "cbMaH";
            this.cbMaH.Size = new System.Drawing.Size(131, 33);
            this.cbMaH.TabIndex = 5;
            this.cbMaH.Text = "Mã hãng";
            this.cbMaH.UseVisualStyleBackColor = true;
            this.cbMaH.CheckedChanged += new System.EventHandler(this.cbMaH_CheckedChanged);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(487, 58);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(185, 35);
            this.txtTenHang.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên hãng";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(139, 58);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(185, 35);
            this.txtMaHang.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hãng";
            // 
            // btnSearchHang
            // 
            this.btnSearchHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchHang.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchHang.FlatAppearance.BorderSize = 0;
            this.btnSearchHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchHang.ForeColor = System.Drawing.Color.White;
            this.btnSearchHang.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchHang.Image")));
            this.btnSearchHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchHang.Location = new System.Drawing.Point(89, 574);
            this.btnSearchHang.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchHang.Name = "btnSearchHang";
            this.btnSearchHang.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSearchHang.Size = new System.Drawing.Size(189, 50);
            this.btnSearchHang.TabIndex = 23;
            this.btnSearchHang.Text = "   Tìm kiếm";
            this.btnSearchHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchHang.UseVisualStyleBackColor = false;
            this.btnSearchHang.Click += new System.EventHandler(this.btnSearchHang_Click);
            // 
            // btnAddHang
            // 
            this.btnAddHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddHang.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddHang.FlatAppearance.BorderSize = 0;
            this.btnAddHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHang.ForeColor = System.Drawing.Color.White;
            this.btnAddHang.Image = ((System.Drawing.Image)(resources.GetObject("btnAddHang.Image")));
            this.btnAddHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddHang.Location = new System.Drawing.Point(297, 574);
            this.btnAddHang.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddHang.Name = "btnAddHang";
            this.btnAddHang.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddHang.Size = new System.Drawing.Size(171, 50);
            this.btnAddHang.TabIndex = 22;
            this.btnAddHang.Text = "   Thêm";
            this.btnAddHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddHang.UseVisualStyleBackColor = false;
            this.btnAddHang.Click += new System.EventHandler(this.btnAddHang_Click);
            // 
            // btnSaveHang
            // 
            this.btnSaveHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveHang.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveHang.FlatAppearance.BorderSize = 0;
            this.btnSaveHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveHang.ForeColor = System.Drawing.Color.White;
            this.btnSaveHang.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveHang.Image")));
            this.btnSaveHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveHang.Location = new System.Drawing.Point(490, 574);
            this.btnSaveHang.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSaveHang.Name = "btnSaveHang";
            this.btnSaveHang.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSaveHang.Size = new System.Drawing.Size(171, 50);
            this.btnSaveHang.TabIndex = 21;
            this.btnSaveHang.Text = "   Lưu";
            this.btnSaveHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveHang.UseVisualStyleBackColor = false;
            this.btnSaveHang.Click += new System.EventHandler(this.btnSaveHang_Click);
            // 
            // btnEditHang
            // 
            this.btnEditHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditHang.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditHang.FlatAppearance.BorderSize = 0;
            this.btnEditHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditHang.ForeColor = System.Drawing.Color.White;
            this.btnEditHang.Image = ((System.Drawing.Image)(resources.GetObject("btnEditHang.Image")));
            this.btnEditHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditHang.Location = new System.Drawing.Point(682, 574);
            this.btnEditHang.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEditHang.Name = "btnEditHang";
            this.btnEditHang.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEditHang.Size = new System.Drawing.Size(171, 50);
            this.btnEditHang.TabIndex = 20;
            this.btnEditHang.Text = "   Sửa";
            this.btnEditHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditHang.UseVisualStyleBackColor = false;
            this.btnEditHang.Click += new System.EventHandler(this.btnEditHang_Click);
            // 
            // btnClearHang
            // 
            this.btnClearHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearHang.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClearHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearHang.FlatAppearance.BorderSize = 0;
            this.btnClearHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearHang.ForeColor = System.Drawing.Color.White;
            this.btnClearHang.Image = ((System.Drawing.Image)(resources.GetObject("btnClearHang.Image")));
            this.btnClearHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearHang.Location = new System.Drawing.Point(875, 574);
            this.btnClearHang.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClearHang.Name = "btnClearHang";
            this.btnClearHang.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnClearHang.Size = new System.Drawing.Size(171, 50);
            this.btnClearHang.TabIndex = 19;
            this.btnClearHang.Text = "   Xóa";
            this.btnClearHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearHang.UseVisualStyleBackColor = false;
            this.btnClearHang.Click += new System.EventHandler(this.btnClearHang_Click);
            // 
            // btnSkipHang
            // 
            this.btnSkipHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkipHang.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSkipHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkipHang.FlatAppearance.BorderSize = 0;
            this.btnSkipHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkipHang.ForeColor = System.Drawing.Color.White;
            this.btnSkipHang.Image = ((System.Drawing.Image)(resources.GetObject("btnSkipHang.Image")));
            this.btnSkipHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSkipHang.Location = new System.Drawing.Point(1067, 574);
            this.btnSkipHang.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSkipHang.Name = "btnSkipHang";
            this.btnSkipHang.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSkipHang.Size = new System.Drawing.Size(171, 50);
            this.btnSkipHang.TabIndex = 19;
            this.btnSkipHang.Text = "   Bỏ qua";
            this.btnSkipHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSkipHang.UseVisualStyleBackColor = false;
            this.btnSkipHang.Click += new System.EventHandler(this.btnSkipHang_Click);
            // 
            // formHangSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 652);
            this.Controls.Add(this.btnSkipHang);
            this.Controls.Add(this.btnSearchHang);
            this.Controls.Add(this.btnAddHang);
            this.Controls.Add(this.btnSaveHang);
            this.Controls.Add(this.btnEditHang);
            this.Controls.Add(this.btnClearHang);
            this.Controls.Add(this.grbHangSX);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "formHangSX";
            this.Text = "HÃNG SẢN XUẤT";
            this.Load += new System.EventHandler(this.formHangSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangSX)).EndInit();
            this.grbHangSX.ResumeLayout(false);
            this.grbHangSX.PerformLayout();
            this.grbSearchHang.ResumeLayout(false);
            this.grbSearchHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvHangSX;
        private System.Windows.Forms.GroupBox grbHangSX;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchHang;
        private System.Windows.Forms.Button btnAddHang;
        private System.Windows.Forms.Button btnSaveHang;
        private System.Windows.Forms.Button btnEditHang;
        private System.Windows.Forms.Button btnClearHang;
        private System.Windows.Forms.GroupBox grbSearchHang;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.TextBox txtTenHSearch;
        private System.Windows.Forms.CheckBox cbTenH;
        private System.Windows.Forms.TextBox txtMaHSearch;
        private System.Windows.Forms.CheckBox cbMaH;
        private System.Windows.Forms.Button btnSkipHang;
    }
}