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
    public partial class FormLogin : Form
    {
        DatabaseProcess dtBase = new DatabaseProcess();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dtBase.OpenConn();
            DataTable dt = dtBase.Select("Select * from tUser where userName = '" + txtUserName.Text + "'" +
                " and password = '" + txtPassword.Text + "'");
            if (dt.Rows.Count != 0)
            {
                this.Hide();
                formMain.userName = txtUserName.Text;
                formMain.phanquyen = dt.Rows[0]["ChucVu"].ToString();
                formMain frmMain = new formMain();
                frmMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập chính xác thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtUserName.Text = "";
                txtUserName.Focus();
            }
            dtBase.CloseConn();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
