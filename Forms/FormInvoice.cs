using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using Excel = Microsoft.Office.Interop.Excel;

namespace BaiTapLon.Forms
{
	public partial class FormInvoice : Form
	{
		Classes.ConnectData data = new Classes.ConnectData();
		Classes.CommonFun function = new Classes.CommonFun();
		Classes.CommonFuns ft = new Classes.CommonFuns();
		public FormInvoice()
		{
			InitializeComponent();
		}
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        void ResetValue()
		{
			DateTime dt = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
			txtMaHD.Text = "";
			dtpNgayBan.Text = dt.ToShortDateString();
			cbbMaNV.Text = "";
			txtTenNV.Text = "";
			txtDiaChi.Text = "";
			txtDienThoai.Text = "";
			cbbMaKH.Text = "";
			cbbMaSP.Text = "";
			txtTenSP.Text = "";
			txtSoLuong.Text = "";
			txtDonGia.Text = "";
			txtThanhTien.Text = "";
			txtTenKH.Text = "";
			txtSoLuong.Text = "";
			txtGiamGia.Text = "";
			txtThanhTien.Text = "";
			
			txtGiamGia.Text = "";
			txtTongTien.Text = "";
			label1.Text = "";
			dtvHDB.DataSource = null;
		}
		void LoadData()
		{
			DataTable dtChiTiet = data.ReadData("Select tChiTietHDB.MaSP, TenSP, SLBan, DonGiaBan,giamgia, ThanhTien from tChiTietHDB inner join tSanPham on tChiTietHDB.MaSP = tSanPham.MaSP where mahdb='" + txtMaHD.Text + "'");
			dtvHDB.DataSource = dtChiTiet;
			dtvHDB.Columns[0].Width = 150;
			dtvHDB.Columns[1].Width = 190;
			dtvHDB.Columns[2].Width = 150;
			dtvHDB.Columns[3].Width = 150;
			dtvHDB.Columns[4].Width = 150;
			dtvHDB.Columns[5].Width = 190;

			dtvHDB.AllowUserToAddRows = false;
			dtvHDB.EditMode = DataGridViewEditMode.EditProgrammatically;
			dtvHDB.Columns[0].HeaderText = "Mã Điện Thoại";
			dtvHDB.Columns[1].HeaderText = "Tên Điện Thoại";
			dtvHDB.Columns[2].HeaderText = "Số lượng";
			dtvHDB.Columns[3].HeaderText = "Đơn giá";
			dtvHDB.Columns[4].HeaderText = "Giảm giá (%)";
			dtvHDB.Columns[5].HeaderText = "Thành tiền";
			

		}
		private void FormInvoice_Load(object sender, EventArgs e)
		{
			LoadData();
			LoadTheme();
			btnThem.Enabled = true;
			btnLuu.Enabled = false;
			btnIn.Enabled = false;
			txtMaHD.ReadOnly = true;
			txtTenNV.ReadOnly = true;
			txtTenKH.ReadOnly = true;
			txtDiaChi.ReadOnly = true;
			txtDienThoai.ReadOnly = true;
			txtTenSP.ReadOnly = true;
			txtDonGia.ReadOnly = true;
			txtThanhTien.ReadOnly = true;
			txtTongTien.ReadOnly = true;
		/*	txtGiamGia.Text = "";
			txtTongTien.Text = "";*/
			cbbMaNV.SelectedIndex = -1;
			cbbMaKH.SelectedIndex = -1;
			cbbMaSP.SelectedIndex = -1;
		}

		private void cbbMaNV_SelectedValueChanged(object sender, EventArgs e)
		{
			try
			{
				DataTable dtNV = data.ReadData("Select MaNV,tenNV from tNhanVien where MaNV='" + cbbMaNV.SelectedValue.ToString() + "'");
				if (dtNV.Rows.Count > 0)
					txtTenNV.Text = dtNV.Rows[0]["TenNV"].ToString();
			}
			catch
			{
			}
		}

		private void cbbMaNV_Click(object sender, EventArgs e)
		{
			function.FillCombobox(cbbMaNV, data.ReadData("Select * from tNhanVien"), "MaNV", "MaNV");
		}
		private void cbbMaKH_Click(object sender, EventArgs e)
		{
			function.FillCombobox(cbbMaKH, data.ReadData("Select * from tKhachHang"), "MaKH", "MaKH");
		}
		private void cbbMaKH_SelectedValueChanged(object sender, EventArgs e)
		{
			try
			{
				DataTable dtKhach = data.ReadData("Select * from tKhachHang where MaKH='" +
					cbbMaKH.SelectedValue.ToString() + "'");
				if (dtKhach.Rows.Count > 0)
				{
					txtTenKH.Text = dtKhach.Rows[0]["TenKH"].ToString();
					txtDiaChi.Text = dtKhach.Rows[0]["DiaChi"].ToString();
					txtDienThoai.Text = dtKhach.Rows[0]["SDT"].ToString();
				}
			}
			catch
			{
			}
		}
		private void cbbMaSP_Click(object sender, EventArgs e)
		{
			function.FillCombobox(cbbMaSP, data.ReadData("Select * from tSanPham"), "MaSP", "MaSP");
		}
		private void cbbMaSP_SelectedValueChanged(object sender, EventArgs e)
		{
			try
			{
				DataTable dtSP = data.ReadData("Select * from tSanPham where MaSP='" +
					cbbMaSP.SelectedValue.ToString() + "'");
				if (dtSP.Rows.Count > 0)
				{
					txtTenSP.Text = dtSP.Rows[0]["TenSP"].ToString();
					txtDonGia.Text = dtSP.Rows[0]["DonGiaBan"].ToString();
					txtSoLuong.Text = "";
				}
			}
			catch
			{
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			btnThem.Enabled = false;
			btnLuu.Enabled = true;
			btnHuy.Enabled = true;
			btnIn.Enabled = false;
			ResetValue();
			string str = "HDB";
			txtMaHD.Text = ft.SinhMaTuDong("tHoaDonBan", "MaHDB", str);
			LoadData();

		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			int sl, slcon;
			double tong, tongmoi;
			DataTable dtHD = data.ReadData("Select * from tHoaDonBan where MaHDB = '" + txtMaHD.Text + "'");
			//Trường hợp hóa đơn chưa có lưu các thông tin chung
			if (dtHD.Rows.Count == 0)
			{
				if (dtpNgayBan.Text == "")
				{
					MessageBox.Show("Vui lòng nhập ngày bán");
					// errNhapTT.SetError(dtpNgayBan, "Vui lòng nhập ngày bán.");
					dtpNgayBan.Focus();
				}
				else if (cbbMaNV.Text == "")
				{
					MessageBox.Show("Vui lòng chọn mã nhân viên!");
					/*  errNhapTT.Clear();
					  errNhapTT.SetError(cbbMaNV, "Vui lòng chọn mã nhân viên");*/
					cbbMaNV.Focus();
				}
				else if (cbbMaKH.Text == "")
				{
					MessageBox.Show("Vui lòng chọn mã khách hàng!");
					cbbMaKH.Focus();
				}
				else
				{
					DateTime dtNgayBan = Convert.ToDateTime(dtpNgayBan.Text.Trim());
					data.UpdateData("INSERT INTO tHoaDonBan(MaHDB,NgayLapHD,MaNV,MaKH,TongTien) values('" +
												 txtMaHD.Text + "','" + string.Format("{0:MM/dd/yyyy}", dtNgayBan) + "',N'" +
												cbbMaNV.SelectedValue.ToString() + "',N'" +
												cbbMaKH.SelectedValue.ToString() + "','" +
												txtTongTien.Text.Trim() + "')");
				}
			}
			// Lưu thông tin các mặt hàng 
			if (cbbMaSP.Text.Trim() == "")
			{
				MessageBox.Show("Vui lòng chọn mã sản phẩm!");
				/* errNhapTT.SetError(cbbMaSP, "Vui lòng chọn mã hàng");*/
				cbbMaSP.Focus();
			}
			else if (txtSoLuong.Text == "")
			{
				MessageBox.Show("Vui lòng nhập số lượng!");

				/*errNhapTT.Clear();
                errNhapTT.SetError(txtSoLuong, "Vui lòng nhập số lượng");*/
				txtSoLuong.Focus();
			}

			else
			{//ktra so luong sp<so luong nhap mua
				DataTable dtSP = data.ReadData("Select * from tSanPham where MaSP = '" + cbbMaSP.SelectedValue.ToString() + "'");
				// DataTable dtH_CTHD = data.ReadData("Select * from tChiTietHDB where MaSP = '" + cbbMaSP.SelectedValue + "'");
				if (Convert.ToInt32(dtSP.Rows[0]["SoLuong"].ToString()) < Convert.ToInt32(txtSoLuong.Text))
				{
					MessageBox.Show("Số lượng mặt hàng này chỉ còn " + dtSP.Rows[0]["SoLuong"].ToString());
					txtSoLuong.Focus();
					return;
				}
				else
				{

					data.UpdateData("insert into tChiTietHDB(MaHDB, MaSP, SLban, giamgia, ThanhTien) values ('" + txtMaHD.Text + "', " +
						"'" + cbbMaSP.SelectedValue.ToString() + "', '" + txtSoLuong.Text + "','" +
								txtGiamGia.Text + "','" + txtThanhTien.Text + "')");
					LoadData();
					
					//cap nhat sl sp va bang sp
					slcon = Convert.ToInt32(dtSP.Rows[0]["Soluong"].ToString()) - Convert.ToInt32(txtSoLuong.Text);
					data.UpdateData("Update tSanPham set SoLuong=" + slcon + " where MaSP ='" + cbbMaSP.SelectedValue.ToString() + "'");

					//cap nhat tong tien
					dtHD = data.ReadData("Select * from tHoaDonBan where MaHDB = '" + txtMaHD.Text + "'");
					txtTongTien.Text = (Convert.ToDouble(dtHD.Rows[0]["TongTien"].ToString()) + Convert.ToDouble(txtThanhTien.Text)).ToString();
					data.UpdateData("Update tHoaDonBan set TongTien='" + txtTongTien.Text + "' where MaHDB='" + txtMaHD.Text + "'");
					

					label1.Text = "Bằng chữ: " + NumberToText(double.Parse(txtTongTien.Text));
				
					//	btnXoa.Enabled = true;
					btnThem.Enabled = true;
					btnIn.Enabled = true;
				
				}
			}
		
		}
		

		private void cbbTimMaHD_Click(object sender, EventArgs e)
		{
			
			function.FillCombobox(cbbTimMaHD, data.ReadData("Select MaHDB from tHoaDonBan"), "MaHDB", "MaHDB");
		}

		private void btnIn_Click(object sender, EventArgs e)
		{
			SaveFileDialog file = new SaveFileDialog();
			Excel.Application exApp = new Excel.Application();
			Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
			Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
			Excel.Range tenTruong = (Excel.Range)exSheet.Cells[1, 1]; //Đưa con trỏ vào ô A1
																	  //Đưa dữ liệu vào file Excel
			tenTruong.Range["A1:D1"].MergeCells = true;
			tenTruong.Range["A1"].Value = "CỬA HÀNG BÁN ĐIỆN THOẠI HIỀN HẰNG";
			tenTruong.Range["A1"].Font.Color = System.Drawing.Color.Red;
			tenTruong.Range["A2"].Font.Color = System.Drawing.Color.Red;
			tenTruong.Range["A2"].Value = "Địa chỉ: 37B-TT Đông Anh - Hà Nội";
			tenTruong.Range["A3"].Value = "Điện thoại: 0966047698";
			tenTruong.Range["c5:f5"].MergeCells = true;
			tenTruong.Range["C5:F5"].Font.Size = 18;
			tenTruong.Range["C5:F5"].Font.Color = System.Drawing.Color.Red;
			tenTruong.Range["C5"].Value = "HÓA ĐƠN BÁN";
			tenTruong.Range["A7"].Value = "Mã HĐ: " + txtMaHD.Text;
			tenTruong.Range["A8"].Value = "Khách hàng: " + txtTenKH.Text;
			tenTruong.Range["A9"].Value = "Số ĐT Khách: " + txtDienThoai.Text;
			tenTruong.Range["A10"].Value = "Địa chỉ" + txtDiaChi.Text;
			tenTruong.Range["A11"].Value = "STT";
			tenTruong.Range["B11"].Value = "Mã ĐT ";
			tenTruong.Range["C11"].Value = "Tên ĐT " + txtTenSP.Text;
			tenTruong.Range["D11"].Value = "Đơn giá" + txtDonGia.Text;
			tenTruong.Range["E11"].Value = "Số lượng" + txtSoLuong.Text;
			tenTruong.Range["F11"].Value = "Giảm giá" + txtGiamGia.Text;
			tenTruong.Range["G12"].Value = "Thành tiền" + txtThanhTien.Text;
			int hang = 11;

			DataTable tblChiTiet = data.ReadData("Select tSanPham.MaSP,TenSP,tChiTietHDB.SLBan,DonGiaBan,giamgia,ThanhTien from tChiTietHDB " +
				"inner join tSanPham on tSanPham.MaSP = tChiTietHDB.MaSP where MaHDB = '" + txtMaHD.Text + "'");
			for (int i = 0; i < tblChiTiet.Rows.Count; i++)
			{
				hang++;
				tenTruong.Range["A" + hang.ToString()].Value = (i + 1).ToString();
				tenTruong.Range["B" + hang.ToString()].Value = tblChiTiet.Rows[i]["MaSP"];
				tenTruong.Range["C" + hang.ToString()].Value = tblChiTiet.Rows[i]["TenSP"];
				tenTruong.Range["D" + hang.ToString()].Value = tblChiTiet.Rows[i]["DonGiaBan"];
				tenTruong.Range["E" + hang.ToString()].Value = tblChiTiet.Rows[i]["SLBan"];
				tenTruong.Range["F" + hang.ToString()].Value = tblChiTiet.Rows[i]["GiamGia"];
				tenTruong.Range["G" + hang.ToString()].Value = tblChiTiet.Rows[i]["ThanhTien"];



			}
			tenTruong.Range["D" + (hang + 1).ToString()].Value = "Tổng: " + txtTongTien.Text;
			double tt = double.Parse(txtTongTien.Text);
			//	label1.Text = NumberToText(tt);
			tenTruong.Range["D" + (hang + 2).ToString()].Font.Bold = true;
			tenTruong.Range["D" + (hang + 2).ToString()].Value = "Bằng chữ: " + NumberToText(tt);
			//tenTruong.Range["B" + (hang + 3).ToString()].Value = "Nhân viên bán: " + txtTenNV.Text;
			DataTable tblThongtinHD = data.ReadData("SELECT a.MaHDB, a.NgayLapHD, a.TongTien, b.TenKH, b.DiaChi, b.SDT, c.TenNV FROM tHoaDonBan " +
			"AS a, tKhachHang AS b, tNhanVien AS c WHERE a.MaHDB = N'" + txtMaHD.Text + "' AND a.MaKH = b.MaKH " +
			"AND a.MaNV = c.MaNV");
			DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
			tenTruong.Range["D16"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
			tenTruong.Range["E17"].MergeCells = true;
			tenTruong.Range["E17"].Font.Italic = true;
			tenTruong.Range["E17"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
			tenTruong.Range["E17"].Value = "Nhân viên bán hàng";
			tenTruong.Range["E21"].MergeCells = true;
			tenTruong.Range["E21"].Font.Italic = true;
			tenTruong.Range["E21"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
			tenTruong.Range["E21"].Value = txtTenNV.Text;

			exSheet.Name = "HoaDonBan";
			exBook.Activate();
			if (file.ShowDialog() == DialogResult.OK)
				exBook.SaveAs(file.FileName.ToString());
			exApp.Quit();
		}
		private void dtvHDB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			if (cbbTimMaHD.Text == "")
			{
				MessageBox.Show("Bạn chưa chọn mã Hoá Đơn để tìm");
				cbbTimMaHD.Focus();
			}
			DataTable dtHD = data.ReadData("select * from tHoaDonBan where MaHDB='" + cbbTimMaHD.SelectedValue.ToString() + "'");
			if (dtHD.Rows.Count > 0)
			{

				txtMaHD.Text = dtHD.Rows[0]["MaHDB"].ToString();
				cbbMaNV.Text = dtHD.Rows[0]["MaNV"].ToString();
				DataTable dtNV = data.ReadData("Select MaNV,TenNV from tNhanVien" +
				   " where MaNV='" + dtHD.Rows[0]["MaNV"].ToString() + "'");
				if (dtNV.Rows.Count > 0)
					txtTenNV.Text = dtNV.Rows[0]["TenNV"].ToString();

				cbbMaKH.Text = dtHD.Rows[0]["MaKH"].ToString();
				DataTable dtKhach = data.ReadData("Select * from tKhachHang where MaKH='" +
					dtHD.Rows[0]["MaKH"].ToString() + "'");
				if (dtKhach.Rows.Count > 0)
				{
					txtTenKH.Text = dtKhach.Rows[0]["TenKH"].ToString();
					txtDiaChi.Text = dtKhach.Rows[0]["DiaChi"].ToString();
					txtDienThoai.Text = dtKhach.Rows[0]["SDT"].ToString();
					//txtGiamGia.Text = dtKhach.Rows[0]["GiamGia"].ToString();
				}

				DataTable dttt = data.ReadData("SELECT TongTien FROM tHoaDonBan WHERE MaHDB = N'" + txtMaHD.Text + "'");
				txtTongTien.Text = dttt.Rows[0]["TongTien"].ToString();
				label1.Text = NumberToText(double.Parse(txtTongTien.Text));
				LoadData();
				//btnXoa.Enabled = true;
			
				btnLuu.Enabled = true;
				btnIn.Enabled = true;
				cbbTimMaHD.SelectedIndex = -1;
			}
		}

		private void dtvHDB_Click(object sender, EventArgs e)
		{
			cbbMaSP.Text = dtvHDB.CurrentRow.Cells["MaSP"].Value.ToString();
			txtTenSP.Text = dtvHDB.CurrentRow.Cells["TenSP"].Value.ToString();
			txtDonGia.Text = dtvHDB.CurrentRow.Cells["DonGiaBan"].Value.ToString();
			txtSoLuong.Text = dtvHDB.CurrentRow.Cells["SLBan"].Value.ToString();
			txtGiamGia.Text = dtvHDB.CurrentRow.Cells["GiamGia"].Value.ToString() ;
			double DonGia, soluong;
			soluong = Convert.ToDouble(txtSoLuong.Text);
			DonGia = double.Parse(txtDonGia.Text);
			txtThanhTien.Text = (soluong * DonGia).ToString();

			btnHuy.Enabled = true;
			btnThem.Enabled = true;
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			ResetValue(); LoadData();
			btnThem.Enabled = true;
			btnHuy.Enabled = false;
			btnLuu.Enabled = false;
			btnIn.Enabled = false;
		}

		private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) // Kiểm tra có phải ký tự số không
			{
				MessageBox.Show("Bạn phải nhập số cho giảm giá");
				e.Handled = true;
			}
		}

	
		private void txtSoLuong_TextChanged(object sender, EventArgs e)
		{
			try
			{
				double DonGia, GiamGia, soluong;
				if (txtGiamGia.Text == "")
					GiamGia = 0;
				else
					GiamGia = Convert.ToDouble(txtGiamGia.Text);

				if (txtSoLuong.Text == "")
					soluong = 0;
				else
					soluong = Convert.ToDouble(txtSoLuong.Text);
				DonGia = Convert.ToDouble(txtDonGia.Text);
				txtThanhTien.Text = (soluong * DonGia - soluong * DonGia * GiamGia / 100).ToString();
			}
			catch
			{
			}
		}
		public static string NumberToText(double inputNumber, bool suffix = true)
		{
			string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
			string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
			bool isNegative = false;

			// -12345678.3445435 => "-12345678"
			string sNumber = inputNumber.ToString("#");
			double number = Double.Parse(sNumber);
			if (number < 0)
			{
				number = -number;
				sNumber = number.ToString();
				isNegative = true;
			}


			int ones, tens, hundreds;

			int positionDigit = sNumber.Length;   // last -> first

			string result = " ";


			if (positionDigit == 0)
				result = unitNumbers[0] + result;
			else
			{
				// 0:       ###
				// 1: nghìn ###,###
				// 2: triệu ###,###,###
				// 3: tỷ    ###,###,###,###
				int placeValue = 0;

				while (positionDigit > 0)
				{
					// Check last 3 digits remain ### (hundreds tens ones)
					tens = hundreds = -1;
					ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
					positionDigit--;
					if (positionDigit > 0)
					{
						tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
						positionDigit--;
						if (positionDigit > 0)
						{
							hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
							positionDigit--;
						}
					}

					if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
						result = placeValues[placeValue] + result;

					placeValue++;
					if (placeValue > 3) placeValue = 1;

					if ((ones == 1) && (tens > 1))
						result = "một " + result;
					else
					{
						if ((ones == 5) && (tens > 0))
							result = "lăm " + result;
						else if (ones > 0)
							result = unitNumbers[ones] + " " + result;
					}
					if (tens < 0)
						break;
					else
					{
						if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
						if (tens == 1) result = "mười " + result;
						if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
					}
					if (hundreds < 0) break;
					else
					{
						if ((hundreds > 0) || (tens > 0) || (ones > 0))
							result = unitNumbers[hundreds] + " trăm " + result;
					}
					result = " " + result;
				}
			}
			result = result.Trim();
			if (isNegative) result = "Âm " + result;
			return result + (suffix ? " đồng chẵn" : "");
		}

		private void dtvHDB_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
		{
			if (MessageBox.Show("Bạn không muốn mua sản phẩm này à?", "Yes/No", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				//Cập nhật lại số lượng trong bảng hàng
				string maHang = dtvHDB.CurrentRow.Cells[0].Value.ToString();
				//lay ra sp xoa
				DataTable dtSP = data.ReadData("Select * from tSanPham where MaSP ='" + maHang + "'");
				int slcon = int.Parse(dtSP.Rows[0]["SoLuong"].ToString()) +
					int.Parse(dtvHDB.CurrentRow.Cells[3].Value.ToString());
				//cap nhat lai so luong vao bang sp
				data.UpdateData("Update tSanPham set SoLuong=" + slcon + " where MaSP ='" + maHang + "'");
				//Tinh lai tong tien hoa don 
				double tongtien = double.Parse(txtTongTien.Text) - double.Parse(dtvHDB.CurrentRow.Cells[6].Value.ToString());
				data.UpdateData("update tHoaDonBan set TongTien='" + tongtien.ToString() + "' where MaHDB='" + txtMaHD.Text + "'");
				txtTongTien.Text = tongtien.ToString();
				//Xóa chi tiết 
				data.UpdateData("delete tChiTietHDB where MaHDB='" + txtMaHD.Text + "' and MaSP='" + maHang + "'");
				//Load lại dataGridview
				dtvHDB.DataSource = data.ReadData("Select tSanPham.MaSP,TenSP,tChiTietHDB.SoLuong,giamgia,ThanhTien from tChiTietHDB inner join" +
				  " tHang on tSanPham.MaSP=tChiTietHDB.MaHang where MaHoaDonBan='" + txtMaHD.Text + "'");

				ResetValue();
				LoadData();
				
				btnIn.Enabled = false;
			}

		}
	}
}
