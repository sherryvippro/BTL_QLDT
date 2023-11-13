namespace BaiTapLon.Forms
{
    partial class FormCustomers
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
			this.grbCustomers = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMaKH = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTenKH = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtvKH = new System.Windows.Forms.DataGridView();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnBoQua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.grbCustomers.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtvKH)).BeginInit();
			this.SuspendLayout();
			// 
			// grbCustomers
			// 
			this.grbCustomers.Controls.Add(this.txtTenKH);
			this.grbCustomers.Controls.Add(this.label4);
			this.grbCustomers.Controls.Add(this.txtSDT);
			this.grbCustomers.Controls.Add(this.label3);
			this.grbCustomers.Controls.Add(this.txtDiaChi);
			this.grbCustomers.Controls.Add(this.label2);
			this.grbCustomers.Controls.Add(this.txtMaKH);
			this.grbCustomers.Controls.Add(this.label1);
			this.grbCustomers.Dock = System.Windows.Forms.DockStyle.Top;
			this.grbCustomers.Location = new System.Drawing.Point(0, 0);
			this.grbCustomers.Name = "grbCustomers";
			this.grbCustomers.Size = new System.Drawing.Size(1244, 182);
			this.grbCustomers.TabIndex = 0;
			this.grbCustomers.TabStop = false;
			this.grbCustomers.Text = "Thông tin khách hàng";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã Khách Hàng";
			// 
			// txtMaKH
			// 
			this.txtMaKH.Location = new System.Drawing.Point(254, 47);
			this.txtMaKH.Name = "txtMaKH";
			this.txtMaKH.Size = new System.Drawing.Size(167, 35);
			this.txtMaKH.TabIndex = 1;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(676, 105);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(159, 35);
			this.txtDiaChi.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(510, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "Địa chỉ";
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(676, 47);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(159, 35);
			this.txtSDT.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(501, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 29);
			this.label3.TabIndex = 4;
			this.label3.Text = "Số điện thoại";
			// 
			// txtTenKH
			// 
			this.txtTenKH.Location = new System.Drawing.Point(254, 102);
			this.txtTenKH.Name = "txtTenKH";
			this.txtTenKH.Size = new System.Drawing.Size(167, 35);
			this.txtTenKH.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(192, 29);
			this.label4.TabIndex = 6;
			this.label4.Text = "Tên Khách Hàng";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnThem);
			this.groupBox1.Controls.Add(this.btnBoQua);
			this.groupBox1.Controls.Add(this.btnLuu);
			this.groupBox1.Controls.Add(this.btnSua);
			this.groupBox1.Controls.Add(this.btnXoa);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(0, 451);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1244, 201);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// dtvKH
			// 
			this.dtvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtvKH.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtvKH.Location = new System.Drawing.Point(0, 182);
			this.dtvKH.Name = "dtvKH";
			this.dtvKH.RowHeadersWidth = 62;
			this.dtvKH.RowTemplate.Height = 28;
			this.dtvKH.Size = new System.Drawing.Size(1244, 269);
			this.dtvKH.TabIndex = 2;
			this.dtvKH.Click += new System.EventHandler(this.dtvKH_Click);
			// 
			// btnThem
			// 
			this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThem.FlatAppearance.BorderSize = 0;
			this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThem.Location = new System.Drawing.Point(174, 35);
			this.btnThem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(171, 50);
			this.btnThem.TabIndex = 15;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
			// 
			// btnBoQua
			// 
			this.btnBoQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBoQua.FlatAppearance.BorderSize = 0;
			this.btnBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBoQua.Location = new System.Drawing.Point(941, 35);
			this.btnBoQua.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnBoQua.Name = "btnBoQua";
			this.btnBoQua.Size = new System.Drawing.Size(171, 50);
			this.btnBoQua.TabIndex = 14;
			this.btnBoQua.Text = "Bỏ qua";
			this.btnBoQua.UseVisualStyleBackColor = true;
			this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLuu.FlatAppearance.BorderSize = 0;
			this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLuu.Location = new System.Drawing.Point(365, 35);
			this.btnLuu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(171, 50);
			this.btnLuu.TabIndex = 13;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnSua
			// 
			this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSua.FlatAppearance.BorderSize = 0;
			this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSua.Location = new System.Drawing.Point(557, 35);
			this.btnSua.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(171, 50);
			this.btnSua.TabIndex = 12;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnXoa.FlatAppearance.BorderSize = 0;
			this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoa.Location = new System.Drawing.Point(750, 35);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(171, 50);
			this.btnXoa.TabIndex = 11;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// FormCustomers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1244, 652);
			this.Controls.Add(this.dtvKH);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grbCustomers);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "FormCustomers";
			this.Text = "FormCustomers";
			this.Load += new System.EventHandler(this.FormCustomers_Load);
			this.grbCustomers.ResumeLayout(false);
			this.grbCustomers.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtvKH)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCustomers;
		private System.Windows.Forms.TextBox txtTenKH;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSDT;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMaKH;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dtvKH;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnBoQua;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
	}
}