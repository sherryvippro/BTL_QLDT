using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BaiTapLon.Forms
{
    public partial class FormProducts : Form
    {
        DatabaseProcess dtBase = new DatabaseProcess();
        private string ptrFileName = "";

        public FormProducts()
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

        private void FormProducts_Load(object sender, EventArgs e)
        {
            LoadTheme();
            DataTable dataTable = dtBase.Select("Select masp, tensp, soluong, dongianhap, dongiaban, mahang, mau, anh, ghichu from tSanPham");
            dgvProducts.DataSource = dataTable;
            dgvProducts.Columns[0].HeaderText = "Mã SP";
            dgvProducts.Columns[1].HeaderText = "Tên SP";
            dgvProducts.Columns[2].HeaderText = "Số lượng";
            dgvProducts.Columns[3].HeaderText = "Đơn giá nhập";
            dgvProducts.Columns[4].HeaderText = "Đơn giá bán";
            dgvProducts.Columns[5].HeaderText = "Mã hãng";
            dgvProducts.Columns[6].HeaderText = "Màu";
            dgvProducts.Columns[7].HeaderText = "Ảnh";
            dgvProducts.Columns[8].HeaderText = "Ghi chú";
            dgvProducts.Columns[1].Width = 220;
            dgvProducts.Columns[3].Width = 200;
            dgvProducts.Columns[4].Width = 200;

            cboTenHang.DisplayMember = "TenHang";
            cboTenHang.ValueMember = "MaHang";
            cboTenHang.DataSource = dtBase.Select("select * from thang");
            ProductsReadOnly();
            btnEditProduct.Enabled = false;
            btnClearProduct.Enabled = false;
            btnSkipProduct.Enabled = false;
            btnSaveProduct.Enabled = false;
        }
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductsReadOnly();

			txtMaDT.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
            txtTenDT.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
            txtGiaNhap.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
            txtGiaBan.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
            txtColor.Text = dgvProducts.CurrentRow.Cells[6].Value.ToString();
            cboTenHang.SelectedValue = dgvProducts.CurrentRow.Cells[5].Value.ToString();
            ptrFileName = dgvProducts.CurrentRow.Cells[7].Value.ToString();
            txtGhiChu.Text = dgvProducts.CurrentRow.Cells[8].Value.ToString();
			if (ptrFileName != "")
			{
                ptrImage.Image = Image.FromFile(Application.StartupPath + "\\Images\\DIENTHOAI\\" + ptrFileName);
			}
			else ptrImage.Image = null;
			


			btnEditProduct.Enabled = true;
            btnClearProduct.Enabled = true;
            btnSaveProduct.Enabled = false;
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ResetProducts();
            ProductsEnabled();
            txtMaDT.Focus();
            btnEditProduct.Enabled = false;
            btnClearProduct.Enabled = false;
            btnSkipProduct.Enabled = true;
            btnSaveProduct.Enabled = true;
        }
        private void ResetProducts()
        {
            txtMaDT.Text = string.Empty;
            txtTenDT.Text = string.Empty;
            cboTenHang.SelectedIndex = 0;
            txtSoLuong.Text = string.Empty;
            txtGiaNhap.Text = string.Empty;
            txtGiaBan.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            txtColor.Text = string.Empty;
            ptrImage.Image = null;
        }
        private void ProductsReadOnly()
        {
            txtMaDT.ReadOnly = true;
            txtTenDT.ReadOnly = true;
            cboTenHang.Enabled = false;
            txtSoLuong.ReadOnly = true;
            txtGiaNhap.ReadOnly = true;
            txtGiaBan.ReadOnly = true;
            txtGhiChu.ReadOnly = true;
            txtColor.ReadOnly = true;
            btnChoosePic.Enabled = false;
        }
        private void EditProducts()
        {
            txtGiaNhap.ReadOnly = false;
            txtGiaBan.ReadOnly = false;
            txtColor.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtGhiChu.ReadOnly = false;
            btnChoosePic.Enabled = true;
        }
        private void ProductsEnabled()
        {
            txtMaDT.ReadOnly = false;
            txtTenDT.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtGiaNhap.ReadOnly = false;
            txtGiaBan.ReadOnly = false;
            txtGhiChu.ReadOnly = false;
            txtColor.ReadOnly = false;
            cboTenHang.Enabled = true;
            btnChoosePic.Enabled = true;
        }
        private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*txtSoLuong.Focus();*/
        }

        private void btnChoosePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "JPEG images|*.jpg|Bitmap images|*.bmp|All Files|*.*",
                FilterIndex = 3
            };
            ofd.Title = "Chọn ảnh để hiển thị";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ptrImage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            dtBase.OpenConn();

            if(btnEditProduct.Enabled == false)
            {
                if (txtMaDT.Text.Trim() == "" || txtTenDT.Text.Trim() == "" || txtSoLuong.Text.Trim() == ""
                && txtGiaNhap.Text.Trim() == "" || txtGiaBan.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (int.Parse(txtGiaNhap.Text) > int.Parse(txtGiaBan.Text))
                {
                    MessageBox.Show("Giá nhập không được lớn hơn giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataTable dt = dtBase.Select("Select * from tsanpham where masp = '" + txtMaDT.Text + "'");
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dtBase.Update("insert into tsanpham(masp, tensp, soluong, dongianhap, dongiaban, anh, mahang, model, mau, ghichu) " +
                            "values('" + txtMaDT.Text + "', N'" + txtTenDT.Text + "', N'" + txtSoLuong.Text + "'," +
                            " '" + txtGiaNhap.Text + "', '" + txtGiaBan.Text + "', '" + ptrFileName + "', '" + cboTenHang.SelectedValue + "', N'', N'" + txtColor.Text + "', N'" + txtGhiChu.Text + "')");
                        dgvProducts.DataSource = dtBase.Select("Select masp, tensp, soluong, dongianhap, dongiaban, mahang, mau, anh, ghichu from tSanPham");
						ResetProducts();
                    }

                }
            }
            if(btnEditProduct.Enabled == true)
            {
                dtBase.Update("update tsanpham set soluong = '" + txtSoLuong.Text + "', dongianhap = " + txtGiaNhap.Text + ", dongiaban = " + txtGiaBan.Text + ", mau = '" + txtColor.Text + "', ghichu= N'" +
                        txtGhiChu.Text + "', Anh = N'" + ptrFileName + "' where MaHang = '" + txtMaDT.Text + "'");
                dgvProducts.DataSource = dtBase.Select("Select masp, tensp, soluong, dongianhap, dongiaban, mahang, mau, anh, ghichu from tSanPham");
				ResetProducts();
            }
            dtBase.CloseConn();
            btnEditProduct.Enabled = false;
            btnClearProduct.Enabled = false;
            btnSkipProduct.Enabled = false;
        }

        private void btnSkipProduct_Click(object sender, EventArgs e)
        {
            ResetProducts();
            ProductsReadOnly();
            btnSaveProduct.Enabled = false;
            btnEditProduct.Enabled = false;
            btnClearProduct.Enabled = false;
            btnAddProduct.Enabled = true;
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            txtGiaNhap.Focus();
            EditProducts();
			btnSaveProduct.Enabled = true;

		}

		private void btnClearProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa " + dgvProducts.CurrentRow.Cells[1].Value.ToString() + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtBase.OpenConn();
                dtBase.Update("delete from tsanpham where masp ='" + dgvProducts.CurrentRow.Cells[0].Value.ToString() + "'");
                dgvProducts.DataSource = dtBase.Select("Select masp, tensp, soluong, dongianhap, dongiaban, mahang, mau, anh, ghichu from tSanPham");

				ResetProducts();
                dtBase.CloseConn();
            }
        }
    }
}
