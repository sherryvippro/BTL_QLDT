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
    public partial class FormEmployees : Form
    {
        DatabaseProcess dtBase = new DatabaseProcess();
		private string ptrFileName = "";
        public FormEmployees()
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
        private void FormEmployees_Load(object sender, EventArgs e)
        {
            LoadTheme();
            DataTable dt = dtBase.Select("select * from tnhanvien");
            dgvEmployees.DataSource = dt;
			dgvEmployees.Columns[0].HeaderText = "Mã NV";
			dgvEmployees.Columns[1].HeaderText = "Tên NV";
			dgvEmployees.Columns[2].HeaderText = "Ngày sinh";
			dgvEmployees.Columns[3].HeaderText = "Số điện thoại";
			dgvEmployees.Columns[4].HeaderText = "Ghi chú";
			dgvEmployees.Columns[5].HeaderText = "Ảnh";
			dgvEmployees.Columns[6].HeaderText = "Địa chỉ";
            if (formMain.phanquyen == "quanly")
            {
                formMain.PhanQuyen(btnAdd, btnSave, btnEdit, btnClear, btnSkip, true);
            }
            else
            {
                formMain.PhanQuyen(btnAdd, btnSave, btnEdit, btnClear, btnSkip, false);
            }
        }
		private void ResetEmployees()
		{
			txtMaNV.Text = string.Empty;
			txtTenNV.Text = string.Empty;
			txtSDT.Text = string.Empty;
			dtpDoB.Text = "11/1/2023";
			txtDchi.Text = string.Empty;
			txtNote.Text = string.Empty;
			ptrImg.Image = null;
		}
		private void EmployeesReadOnly()
		{
			txtMaNV.ReadOnly = true;
			txtTenNV.ReadOnly = true;
			txtSDT.ReadOnly = true;
			dtpDoB.Enabled = false;
			txtDchi.ReadOnly = true;
			txtNote.ReadOnly = true;
		}
		private void EditEmployees()
		{
			txtTenNV.ReadOnly = false;
			txtSDT.ReadOnly = false;
			dtpDoB.Enabled = true;
			txtDchi.ReadOnly = false;
			txtNote.ReadOnly = false;
		}
		private void EmployeesEnabled()
		{
			txtMaNV.ReadOnly = false;
			txtTenNV.ReadOnly = false;
			txtSDT.ReadOnly = false;
			dtpDoB.Enabled = true;
			txtDchi.ReadOnly = false;
			txtNote.ReadOnly = false;
		}

		private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			EmployeesReadOnly();

			txtMaNV.Text = dgvEmployees.CurrentRow.Cells[0].Value.ToString();
			txtTenNV.Text = dgvEmployees.CurrentRow.Cells[1].Value.ToString();
			dtpDoB.Text = dgvEmployees.CurrentRow.Cells[2].Value.ToString();
			txtSDT.Text = dgvEmployees.CurrentRow.Cells[3].Value.ToString();
			txtNote.Text = dgvEmployees.CurrentRow.Cells[4].Value.ToString();
			ptrFileName = dgvEmployees.CurrentRow.Cells[5].Value.ToString();
			if (ptrFileName != "")
			{
				ptrImg.Image = Image.FromFile(Application.StartupPath + "\\Images\\NHANVIEN\\" + ptrFileName);
			}
			else ptrImg.Image = null;
			txtDchi.Text = dgvEmployees.CurrentRow.Cells[6].Value.ToString();



			btnEdit.Enabled = true;
			btnClear.Enabled = true;
			btnSave.Enabled = false;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			ResetEmployees();
			EmployeesEnabled();
			txtMaNV.Focus();
			btnEdit.Enabled = false;
			btnClear.Enabled = false;
			btnSkip.Enabled = true;
			btnSave.Enabled = true;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			dtBase.OpenConn();

			if (btnEdit.Enabled == false)
			{
				if (txtMaNV.Text.Trim() == "" || txtTenNV.Text.Trim() == "" || txtSDT.Text.Trim() == ""
				&& txtDchi.Text.Trim() == "")
				{
					MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (DateTime.Now.Year - dtpDoB.Value.Year < 18)
				{
					MessageBox.Show("Nhân viên phải đủ 18 tuổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					DataTable dt = dtBase.Select("Select * from tnhanvien where manv = '" + txtMaNV.Text + "'");
					if (dt.Rows.Count > 0)
					{
						MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						dtBase.Update("insert into tnhanvien(manv, tennv, ngaysinh, sdt, ghichu, anh, diachi) " +
							"values('" + txtMaNV.Text + "', N'" + txtTenNV.Text + "', N'" + dtpDoB.Text + "'," +
							" '" + txtSDT.Text + "', '" + txtNote.Text + "', '" + ptrFileName + "', '" + txtDchi.Text + "'");
						dgvEmployees.DataSource = dtBase.Select("Select * from tnhanvien");
						ResetEmployees();
					}

				}
			}
			if (btnEdit.Enabled == true)
			{
				dtBase.Update("update tnhanvien set tennv = '" + txtTenNV.Text + "', ngaysinh = " + dtpDoB.Text + ", sdt = " + txtSDT.Text + ", ghichu= N'" +
						txtNote.Text + "', Anh = N'" + ptrFileName + "', diachi = N'" + txtDchi.Text + "' where manv = '" + txtMaNV.Text + "'");
				dgvEmployees.DataSource = dtBase.Select("select * from tnhanvien");
				ResetEmployees();
			}
			dtBase.CloseConn();
			btnEdit.Enabled = false;
			btnClear.Enabled = false;
			btnSkip.Enabled = false;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			txtTenNV.Focus();
			EditEmployees();
			btnSave.Enabled = true;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn xóa " + dgvEmployees.CurrentRow.Cells[1].Value.ToString() + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				dtBase.OpenConn();
				dtBase.Update("delete from tnhanvien where manv ='" + dgvEmployees.CurrentRow.Cells[0].Value.ToString() + "'");
				dgvEmployees.DataSource = dtBase.Select("Select * from tnhanvien");

				ResetEmployees();
				dtBase.CloseConn();
			}
		}

		private void btnSkip_Click(object sender, EventArgs e)
		{
			ResetEmployees();
			EmployeesReadOnly();
			btnSave.Enabled = false;
			btnEdit.Enabled = false;
			btnClear.Enabled = false;
			btnAdd.Enabled = true;
		}
	}
}
