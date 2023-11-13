using BaiTapLon.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class formMain : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public static string userName = "";
        public static string phanquyen = "";

        public formMain()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
           
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        public static void PhanQuyen(Button btnAdd, Button btnSave, Button btnEdit, Button btnClear, Button btnSkip, bool hien)
        {
            btnAdd.Visible = hien;
            btnSave.Visible = hien;
            btnEdit.Visible = hien;
            btnClear.Visible = hien;
            btnSkip.Visible = hien;
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActiveButton(object sender)
        {
            if(sender != null)
            {
                if(currentButton != (sender as Button))
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (sender as Button);
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3); 
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;

                }
            }
        }
        private void DisableButton()
        {
            foreach(Control priviousBtn in panelMenu.Controls)
            {
                if(priviousBtn.GetType() == typeof(Button))
                {
                    priviousBtn.BackColor = Color.FromArgb(108, 166, 205);
                    priviousBtn.ForeColor = Color.White;
                    priviousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblHome.Text = childForm.Text;
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProducts(), sender);
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

        }

        

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEmployees(), sender);

        }
        

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCustomers(), sender);
        }

        

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblHome.Text = "TRANG CHỦ";
            panelTitleBar.BackColor = Color.FromArgb(118, 146, 200);
            panelLogo.BackColor = Color.FromArgb(118, 146, 239);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void btnHangSX_Click(object sender, EventArgs e)
        {
            
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            } else this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
