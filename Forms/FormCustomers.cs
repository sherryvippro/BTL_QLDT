using BaiTapLon.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon.Forms
{
    public partial class FormCustomers : Form
    {
        ConnectData data=new ConnectData();
		Classes.CommonFuns ft = new Classes.CommonFuns();
		public FormCustomers()
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
			txtTenKH.Text = "";
			  txtMaKH.Text = "";
			txtSDT.Text = "";
			txtDiaChi.Text = "";
			dtvKH.DataSource = null;
		}
		void LoadData()
		{

            DataTable dtChiTiet = data.ReadData("Select MaKh,TenKh,SDT,DiaChi from tKhachHang");
			dtvKH.DataSource = dtChiTiet;

			dtvKH.Columns[0].Width = 150;
			dtvKH.Columns[1].Width = 190;
			dtvKH.Columns[2].Width = 200;
			dtvKH.Columns[3].Width = 200;
			

			dtvKH.AllowUserToAddRows = false;
			dtvKH.EditMode = DataGridViewEditMode.EditProgrammatically;
			dtvKH.Columns[0].HeaderText = "Mã Khách Hàng";
			dtvKH.Columns[1].HeaderText = "Tên Khách Hàng";
			dtvKH.Columns[2].HeaderText = "Số Điện Thoại";
			dtvKH.Columns[3].HeaderText = "Địa Chỉ";
			//  dtvKH.Columns[4].HeaderText = "Giảm giá (%)";
			
		}
		private void FormCustomers_Load(object sender, EventArgs e)
        {
			LoadTheme();
            DataTable dtChiTiet = data.ReadData("Select MaKh,TenKh,SDT,DiaChi from tKhachHang");
            dtvKH.DataSource = dtChiTiet;

            dtvKH.Columns[0].Width = 150;
            dtvKH.Columns[1].Width = 190;
            dtvKH.Columns[2].Width = 200;
            dtvKH.Columns[3].Width = 200;


            dtvKH.AllowUserToAddRows = false;
            dtvKH.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtvKH.Columns[0].HeaderText = "Mã Khách Hàng";
            dtvKH.Columns[1].HeaderText = "Tên Khách Hàng";
            dtvKH.Columns[2].HeaderText = "Số Điện Thoại";
            dtvKH.Columns[3].HeaderText = "Địa Chỉ";
            btnThem.Enabled = true;
			btnLuu.Enabled = false;		
			txtMaKH.ReadOnly = true;
			btnLuu.Enabled = false;
			btnBoQua.Enabled = false;
			
		}

		

		
		private void dtvKH_Click(object sender, EventArgs e)
		{
			/*if (btnThem.Enabled == false)
			{
				MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtMaKH.Focus();
				return;
			}*/
		/*	if (tblKH.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}*/
			txtMaKH.Text = dtvKH.CurrentRow.Cells["MaKH"].Value.ToString();
			txtTenKH.Text = dtvKH.CurrentRow.Cells["TenKH"].Value.ToString();
			txtDiaChi.Text = dtvKH.CurrentRow.Cells["DiaChi"].Value.ToString();
			txtSDT.Text = dtvKH.CurrentRow.Cells["SDT"].Value.ToString();
			btnSua.Enabled = true;
			btnXoa.Enabled = true;
			btnBoQua.Enabled = true;
		}

		private void btnThem_Click_1(object sender, EventArgs e)
		{
			ResetValue();
			string str = "KH";
			txtMaKH.Text = ft.SinhMaTuDong("tKhachHang", "MaKH", str);

			btnThem.Enabled = false;
			btnLuu.Enabled = true;
			btnBoQua.Enabled = true;
			btnSua.Enabled = true;
			LoadData();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			
		
			if (txtTenKH.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtTenKH.Focus();
				return;
			}
			if (txtDiaChi.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtDiaChi.Focus();
				return;
			}
			if (txtSDT.Text == "")
			{
				MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtSDT.Focus();
				return;
			}
			string pattern = @"^\d{10}$";
			if(Regex.IsMatch(txtSDT.Text, pattern) == false)
			{
				MessageBox.Show("Bạn phải nhập đúng SĐT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtSDT.Focus();return;
			}
			DataTable dtSP = data.ReadData("INSERT INTO tKhachhang(MaKh,TenKH,Diachi,sdt) VALUES (N'" + txtMaKH.Text.Trim() +
				"',N'" + txtTenKH.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "','" + txtSDT.Text + "')");
			ResetValue();
			LoadData();
			

			btnXoa.Enabled = true;
			btnThem.Enabled = true;
			btnSua.Enabled = true;
			btnBoQua.Enabled = false;
			btnLuu.Enabled = false;
		
		}

		private void btnBoQua_Click(object sender, EventArgs e)
		{
			ResetValue();
			btnThem.Enabled = true;
			LoadData();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			
			if (txtTenKH.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtTenKH.Focus();
				return;
			}
			if (txtDiaChi.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtDiaChi.Focus();
				return;
			}
			if (txtSDT.Text == "")
			{
				MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtSDT.Focus();
				return;
			}
			data.UpdateData ( "UPDATE tKhachHang SET TenKH=N'" + txtTenKH.Text.Trim().ToString() + "',DiaChi=N'" +
				txtDiaChi.Text.Trim().ToString() + "',SDT='" + txtSDT.Text.ToString() +
				"' WHERE MaKH=N'" + txtMaKH.Text + "'");
			ResetValue();
			LoadData();			
			btnBoQua.Enabled = false;
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có thực sự muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					data.UpdateData("delete tKhachHang where MaKH = '" + txtMaKH.Text + "'");
					ResetValue();
					LoadData();
					
				}
				catch
				{
					MessageBox.Show("Bạn không được xóa vì nó liên quan đến các hóa đơn");
				}

			}
		}
	}
}
