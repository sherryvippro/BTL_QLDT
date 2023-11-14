using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BaiTapLon.Forms
{
    public partial class formHangSX : Form
    {
        DatabaseProcess dtBase = new DatabaseProcess();
        public formHangSX()
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
                    btnS.BackColor = ThemeColor.PrimaryColor;
                }
            }
        }
        private void formHangSX_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dgvHangSX.DataSource = dtBase.Select("select * from thang");
            dgvHangSX.Columns[0].HeaderText = "Mã hãng";
            dgvHangSX.Columns[1].HeaderText = "Tên hãng";

            dgvHangSX.Columns[0].Width = 150;
            dgvHangSX.Columns[1].Width = 150;

            grbSearchHang.Visible = false;

            HangReadOnly();
            btnEditHang.Enabled = false;
            btnClearHang.Enabled = false;

            btnSaveHang.Enabled = false;
            btnSkipHang.Enabled = false;
        }
        private void ResetHang()
        {
            txtMaHang.Text = string.Empty;
            txtTenHang.Text = string.Empty;
        }
        private void HangReadOnly()
        {
            txtMaHang.ReadOnly = true;
            txtTenHang.ReadOnly = true;
        }
        private void EditHang()
        {
            txtMaHang.ReadOnly = true;
            txtTenHang.ReadOnly = false;
        }

        private void btnAddHang_Click(object sender, EventArgs e)
        {
            ResetHang();
            EditHang();
            txtTenHang.Focus();
            txtMaHang.Text = dtBase.SinhMaTuDong("thang", "mahang", "H");

            btnEditHang.Enabled = false;
            btnClearHang.Enabled = false;
            btnSkipHang.Enabled = true;
            btnSaveHang.Enabled = true;
        }

        private void btnEditHang_Click(object sender, EventArgs e)
        {
            txtTenHang.Focus();
            HangReadOnly();
            txtTenHang.ReadOnly = false;
            btnSaveHang.Enabled = true;
            btnSkipHang.Enabled = true;
        }

        private void btnSkipHang_Click(object sender, EventArgs e)
        {
            ResetHang();
            HangReadOnly();
            btnSaveHang.Enabled = false;
            btnEditHang.Enabled = false;
            btnClearHang.Enabled = false;
            btnAddHang.Enabled = true;

            grbSearchHang.Visible = false;
        }

        private void btnSearchHang_Click(object sender, EventArgs e)
        {
            grbSearchHang.Visible = true;

            txtMaHang.Enabled = false;
            txtTenHang.Enabled = false;
            btnSkipHang.Enabled = true;
        }

        private void dgvHangSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HangReadOnly();

            txtMaHang.Text = dgvHangSX.CurrentRow.Cells[0].Value.ToString();
            txtTenHang.Text = dgvHangSX.CurrentRow.Cells[1].Value.ToString();

            btnEditHang.Enabled = true;
            btnClearHang.Enabled = true;
            btnSaveHang.Enabled = false;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            dtBase.OpenConn();
            DataTable dt = dtBase.Select("select mahang, tenhang from thang where mahang like '%" + txtMaHSearch.Text + "%'"
                + "and tenhang like N'%" + txtTenHSearch.Text + "%'");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hãng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvHangSX.DataSource = dt;
            dtBase.CloseConn();
        }

        private void btnSaveHang_Click(object sender, EventArgs e)
        {
            dtBase.OpenConn();

            if (btnEditHang.Enabled == false)
            {
                if (txtMaHang.Text.Trim() == "" || txtTenHang.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataTable dt = dtBase.Select("Select * from thang where mahang = '" + txtMaHang.Text + "'");
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Mã hãng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dtBase.Update("insert into thang(mahang, tenhang)" +
                            "values('" + txtMaHang.Text + "', N'" + txtTenHang.Text + "')");
                        dgvHangSX.DataSource = dtBase.Select("Select * from thang");
                        ResetHang();
                    }

                }
                btnSkipHang.Enabled = true;
            }
            if (btnEditHang.Enabled == true)
            {
                dtBase.Update("update thang set tenhang = N'" + txtTenHang.Text + "' where masp = '" + txtMaHang.Text + "'");
                dgvHangSX.DataSource = dtBase.Select("Select * from thang");

                ResetHang();
            }
            dtBase.CloseConn();
            btnEditHang.Enabled = false;
            btnClearHang.Enabled = false;
        }

        private void btnClearHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa " + dgvHangSX.CurrentRow.Cells[1].Value.ToString() + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtBase.OpenConn();
                dtBase.Update("update tsanpham set mahang = null where mahang ='" + dgvHangSX.CurrentRow.Cells[0].Value.ToString() + "'");
                dtBase.Update("delete from thang where mahang = '" + dgvHangSX.CurrentRow.Cells[0].Value.ToString());
                dgvHangSX.DataSource = dtBase.Select("select * from thang");

                ResetHang();
                dtBase.CloseConn();
            }
        }

        private void cbTenH_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMaH.Checked)
            {
                txtMaHSearch.Text = "";
                txtMaHSearch.Enabled = true;
            }
            else
            {
                txtMaHSearch.Text = "";
                txtMaHSearch.Enabled = false;
            }
        }

        private void cbMaH_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTenH.Checked)
            {
                txtTenHSearch.Text = "";
                txtTenHSearch.Enabled = true;
            }
            else
            {
                txtTenHSearch.Text = "";
                txtTenHSearch.Enabled = false;
            }
        }
    }
}
