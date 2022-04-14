using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCaribbeanTravelGem
{
    public partial class FrmHome : Form
    {
        private int imageNumber; // to help control the slider

        public FrmHome()
        {
            InitializeComponent();
            panelHomeInfo.BackColor = Color.FromArgb(80, 0, 0, 0);//change alpha(A) to get desired opacity.
        }


        #region // to control the slider
        private void LoadNextImage()
        {
            if (imageNumber == 16)
            {
                imageNumber = 1;

            }

            pbxSlider.ImageLocation = string.Format(@"Home\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timerSlider_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        #endregion

        #region//the login and signup access 
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FrmSignUp frmSignUp = new FrmSignUp(); //Created an instance of the FrmNote form
            frmSignUp.MdiParent = this.MdiParent;        //set the mdikparent for the frmNote instance. This MdiParent is the cureent Mdi Form
            frmSignUp.Show();                  //display the frmNote Form
            frmSignUp.Dock = DockStyle.Fill;
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin(); //Created an instance of the FrmNote form
            frmLogin.MdiParent = this.MdiParent;        //set the mdikparent for the frmNote instance. This MdiParent is the cureent Mdi Form
            frmLogin.Show();                  //display the frmNote Form
            frmLogin.Dock = DockStyle.Fill;
            this.Hide();
        }
        #endregion
        

    }
}
