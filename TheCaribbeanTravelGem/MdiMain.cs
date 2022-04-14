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

namespace TheCaribbeanTravelGem
{
    public partial class MdiMain : Form
    {
        public MdiMain()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds =  Screen.FromHandle(this.Handle).WorkingArea;//this controls the dragging and keeps in the regular work area
        }
        #region//this is the controls for the drag the form
        //this is imported for the dragging of the form and add to system
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //this allows the drag and placement of the form
        private void panelRibbon_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        /*private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginToolStripMenuItem.Enabled == true)
            {
                FrmLogin frmLogin = new FrmLogin(); //Created an instance of the FrmNote form
                frmLogin.MdiParent = this;        //set the mdikparent for the frmNote instance. This MdiParent is the cureent Mdi Form
                frmLogin.Show();                  //display the frmNote Form
                frmLogin.Dock = DockStyle.Fill;
                menuStripMain.Hide();
                txtSearchBar.Hide();
                btnSearch.Hide();
            }
            else
            {
                menuStripMain.Show();
                txtSearchBar.Show();
                btnSearch.Show();
            }
        }

        private void signupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginToolStripMenuItem.Enabled == true)
            {
                FrmSignUp frmSignUp = new FrmSignUp(); //Created an instance of the FrmNote form
                frmSignUp.MdiParent = this;        //set the mdikparent for the frmNote instance. This MdiParent is the cureent Mdi Form
                frmSignUp.Show();                  //display the frmNote Form
                frmSignUp.Dock = DockStyle.Fill;
                menuStripMain.Hide();
                txtSearchBar.Hide();
                btnSearch.Hide();
            }
            else 
            {
                menuStripMain.Show();
                txtSearchBar.Show();
                btnSearch.Show();
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome(); //Created an instance of the FrmNote form
            frmHome.MdiParent = this;        //set the mdikparent for the frmNote instance. This MdiParent is the cureent Mdi Form
            frmHome.Show();                  //display the frmNote Form
            frmHome.Dock = DockStyle.Fill;
            
        }*/

        #region//this controls the close, maximize and minimize buttons
        private void MdiMain_Load(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome(); //Created an instance of the FrmNote form
            frmHome.MdiParent = this;        //set the mdikparent for the frmNote instance. This MdiParent is the cureent Mdi Form
            frmHome.Show();                  //display the frmNote Form
            frmHome.Dock = DockStyle.Fill;
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    FrmLogin frmLogin = new FrmLogin(); //Created an instance of the FrmNote form
        //    frmLogin.MdiParent = this;        //set the mdikparent for the frmNote instance. This MdiParent is the cureent Mdi Form
        //    frmLogin.Show();                  //display the frmNote Form
        //    frmLogin.Dock = DockStyle.Fill;

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    FrmSignUp frmSignUp = new FrmSignUp(); //Created an instance of the FrmNote form
        //    frmSignUp.MdiParent = this;        //set the mdikparent for the frmNote instance. This MdiParent is the cureent Mdi Form
        //    frmSignUp.Show();                  //display the frmNote Form
        //    frmSignUp.Dock = DockStyle.Fill;
        //}
    }
}
