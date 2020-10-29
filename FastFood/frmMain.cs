using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFood.forms;
using FontAwesome.Sharp;

namespace FastFood
{
    public partial class frmMain : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public frmMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 64);
            panelMenu.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Methods
        private void ActivateButton (object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(235, 212, 137);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = Color.Firebrick;
                iconCurrentChildForm.IconSize = 45;
            }
        }
        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(169, 4, 9);
                currentBtn.ForeColor = Color.FromArgb(235, 212, 137);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(235, 212, 137);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm (Form childForm)
        {
            if(currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            childForm.Show();
            lblChildForm.Text = childForm.Text;
        }

        private void iBtnDashboard_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, Color.FromArgb(169, 4, 9));
            OpenChildForm(new frmDashboard());
            panelHome.Visible = false;
        }

        private void iBtnTransaction_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(169, 4, 9));
            OpenChildForm(new frmTransaction());
            panelHome.Visible = false;
        }

        private void iBtnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(169, 4, 9));
            OpenChildForm(new frmSetting());
            panelHome.Visible = false;
        }

        private void iBtnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(169, 4, 9));
            OpenChildForm(new frmCustomer());
            panelHome.Visible = false;
        }

        private void iBtnProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(169, 4, 9));
            OpenChildForm(new frmProduct());
            panelHome.Visible = false;
        }

        private void iBtnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(169, 4, 9));
            OpenChildForm(new frmOrders());
            panelHome.Visible = false;
        }
        private void iBtnStaff_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(169, 4, 9));
            OpenChildForm(new frmStaff());
            panelHome.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelHome.Visible = true;
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(169, 4, 9);
            lblChildForm.Text = "Home";
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private void iconButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButtonRestore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            frmNotionClose frmNoti = new frmNotionClose();
            if (frmNoti.ShowDialog() != DialogResult.Yes)
            {
                this.Show();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }
        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmlogin = frm;
        }
        frmLogin _frmlogin;

        private void iconButtonLogout_Click(object sender, EventArgs e)
        {
            frmLogOut frmLgOut = new frmLogOut();
            if (frmLgOut.ShowDialog() == DialogResult.Yes)
            {
                this.Close();
                MessageBox.Show("Logged out successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
