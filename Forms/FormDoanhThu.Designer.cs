namespace BaiTapLon.Forms
{
	partial class FormDoanhThu
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbbNam = new System.Windows.Forms.ComboBox();
			this.cbbThang = new System.Windows.Forms.ComboBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dtvHD_DT = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtvHD_DT)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbbNam);
			this.groupBox1.Controls.Add(this.cbbThang);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(800, 75);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(489, 30);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(256, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Năm";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tháng";
			// 
			// cbbNam
			// 
			this.cbbNam.FormattingEnabled = true;
			this.cbbNam.Location = new System.Drawing.Point(315, 28);
			this.cbbNam.Name = "cbbNam";
			this.cbbNam.Size = new System.Drawing.Size(121, 28);
			this.cbbNam.TabIndex = 0;
			// 
			// cbbThang
			// 
			this.cbbThang.FormattingEnabled = true;
			this.cbbThang.Location = new System.Drawing.Point(97, 28);
			this.cbbThang.Name = "cbbThang";
			this.cbbThang.Size = new System.Drawing.Size(121, 28);
			this.cbbThang.TabIndex = 0;
			this.cbbThang.SelectedValueChanged += new System.EventHandler(this.cbbThang_SelectedValueChanged);
			this.cbbThang.Click += new System.EventHandler(this.cbbThang_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox2.Location = new System.Drawing.Point(0, 350);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(800, 100);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(719, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "VND";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(560, 22);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(153, 26);
			this.textBox1.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(443, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Doanh Thu";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.chart1);
			this.groupBox3.Controls.Add(this.dtvHD_DT);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 75);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(800, 275);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Danh Sách Hoá Đơn";
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(369, 22);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(428, 250);
			this.chart1.TabIndex = 2;
			this.chart1.Text = "chart1";
			// 
			// dtvHD_DT
			// 
			this.dtvHD_DT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtvHD_DT.Dock = System.Windows.Forms.DockStyle.Left;
			this.dtvHD_DT.Location = new System.Drawing.Point(3, 22);
			this.dtvHD_DT.Name = "dtvHD_DT";
			this.dtvHD_DT.RowHeadersWidth = 62;
			this.dtvHD_DT.RowTemplate.Height = 28;
			this.dtvHD_DT.Size = new System.Drawing.Size(366, 250);
			this.dtvHD_DT.TabIndex = 1;
			// 
			// FormDoanhThu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormDoanhThu";
			this.Text = "Doanh Thu";
			this.Load += new System.EventHandler(this.FormDoanhThu_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtvHD_DT)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbbNam;
		private System.Windows.Forms.ComboBox cbbThang;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dtvHD_DT;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
	}
}