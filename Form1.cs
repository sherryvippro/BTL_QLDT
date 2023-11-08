using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public formMain()
        {
            InitializeComponent();
            random = new Random();
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
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control priviousBtn in panelMenu.Controls)
            {
                if(priviousBtn.GetType() == typeof(Button))
                {
                    priviousBtn.BackColor = Color.FromArgb(51, 51, 76);
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

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

        }
        

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

        }
    }
}
