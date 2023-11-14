using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon.Forms
{
	public partial class FormDoanhThu : Form
	{
		Classes.ConnectData data = new Classes.ConnectData();
		Classes.CommonFun function = new Classes.CommonFun();
		public FormDoanhThu()
		{
			InitializeComponent();
		}

		
		void LoadDataHD()
		{
            System.Data.DataTable dtChiTiet = data.ReadData("Select maHDB,ngaylaphd,tongtien from tHoaDonBan");
			dtvHD_DT.DataSource = dtChiTiet;
			/*dtvHD_DT.Columns[0].Width = 150;
			dtvHD_DT.Columns[1].Width = 190;
			dtvHD_DT.AllowUserToAddRows = false;
			dtvHD_DT.EditMode = DataGridViewEditMode.EditProgrammatically;*/
			dtvHD_DT.Columns[0].HeaderText = "Mã Hoá Đơn";
			dtvHD_DT.Columns[1].HeaderText = "Ngày Bán";
			dtvHD_DT.Columns[2].HeaderText = "Tổng Tiền";
			for (int i = 1; i <= 12; i++)
			{
				cbbThang.Items.Add(i);
			}



		}

		private void FormDoanhThu_Load(object sender, EventArgs e)
		{
			LoadDataHD();
			cbbThang.SelectedValue = -1;
			cbbNam.SelectedValue = -1;
            System.Data.DataTable dtTable = new System.Data.DataTable();
			double tongtien;
			string money = "";
			dtTable.Columns.Add("tongtien", typeof(double));
            for (int i = 1; i <= 12; i++)
            {
                dtTable = data.ReadData("select sum(tongtien) as tongtien from thoadonban where month(ngaylaphd) = '" + i + "'");
				if (dtTable.Rows.Count > 0 && dtTable.Rows[0]["tongtien"].ToString() != "")
				{
                    tongtien = Convert.ToDouble(dtTable.Rows[0]["tongtien"]);
				}
				else tongtien = 0;
				if(tongtien == 0)
				{
					money = "";
				} else
				{
					money = tongtien.ToString();
				}
                chart1.Series["chartDoanhThu"].Points.Add(tongtien);
				/*chart1.Series["chartDoanhThu"].Points[i - 1].Label = money;*/
				chart1.Series["chartDoanhThu"].Points[i - 1].Color = Color.Blue;
                chart1.Series["chartDoanhThu"].Points[i - 1].AxisLabel = "Tháng " + i;
            }



        }

        /*private void cbbThang_SelectedValueChanged(object sender, EventArgs e)
		{
			//int cthang = Convert.ToInt32(cbbThang.SelectedItem);
			data.UpdateData("SELECT mahdb, ngaylaphd, tongtien FROM thoadonban WHERE MONTH(ngaylaphd) = '"+cbbThang.SelectedItem.ToString()+"'");
			LoadDataHD() ;
		}*/

        private void cbbNam_Click(object sender, EventArgs e)
		{
			function.FillCombobox(cbbNam, data.ReadData("Select * from tHoaDonBan"), "year(NgaylapHD)", "year(ngaylaphd)");
		}
		void ResetValue()
		{
			dtvHD_DT.DataSource = null;
			
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (cbbThang.Text == "")
			{
				MessageBox.Show("Bạn chưa chọn mã Hoá Đơn để tìm");
				cbbThang.Focus();
			}
			data.ReadData("SELECT mahdb, ngaylaphd, tongtien FROM thoadonban WHERE MONTH(ngaylaphd) = '" + cbbThang.SelectedValue.ToString() + "'");
			LoadDataHD();
			
		}

		

		private void cbbThang_SelectedValueChanged(object sender, EventArgs e)
		{
			data.UpdateData("select mahdb, ngaylaphd, tongtien from thoadonban where month(ngaylaphd) = 11");
			//ResetValue();
			LoadDataHD();

		}

		private void cbbThang_Click(object sender, EventArgs e)
		{
			
		}
    }
}
