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
    public partial class FrmLogin : Form
    {
        private int tries;

        public FrmLogin() //default constructor
        {
            this.tries = 0;
            InitializeComponent();
        }

        public FrmLogin(int tries) //primary constructor
        {
            this.tries = tries;
            InitializeComponent();
        }

        #region//The login controls
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string sysUsername = "admin";
            //string sysPassword = "admin01";

            if (txtUsername.Texts == "")// unlike the system text feature; we had to use texts keyword to obtain info cuz what was created for our custom textbox
            {
                MessageBox.Show("Please enter username", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else if (txtPassword.Texts == "")
            {
                MessageBox.Show("Please enter password", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else if ((txtUsername.Texts == "admin") && (txtPassword.Texts == "admin01"))//to open the admin portal
            {
                MessageBox.Show("You have successfully logged in \n\n Welcome Back " + txtUsername.Texts, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Give access to the main 

                FrmAdminPortal frmAdmin = new FrmAdminPortal(this);
                frmAdmin.MdiParent = this.MdiParent;//to ensure it loads in the mdimain through the login
                frmAdmin.Show();
                frmAdmin.Dock = DockStyle.Fill;
                this.Hide();
                
            }
            else if ((txtUsername.Texts == "client") && (txtPassword.Texts == "client01"))//to open the client portal
            {
                MessageBox.Show("You have successfully logged in \n\n Welcome Back " + txtUsername.Texts, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Give access to the main

                FrmClientPortal frmClient = new FrmClientPortal(this);
                frmClient.MdiParent = this.MdiParent;//to ensure it loads in the mdimain through the login
                frmClient.Show();
                frmClient.Dock = DockStyle.Fill;
                this.Hide();

            }
            else
            {
                if (this.tries >=3 )
                {
                    MessageBox.Show("Incorrect Login Information \n\n Try again later", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Texts = "";
                    txtPassword.Texts = "";
                    txtUsername.Focus();

                }
                else
                {
                    this.tries = this.tries +1; //incrementing the tries upon each error same as this.tries++;
                    MessageBox.Show("Incorrect user information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }
        #endregion


        #region //to allow when cancel is clicked the exit the application instead of the regular exit and the focus color on button
        private void lblCancel_Click(object sender, EventArgs e)
        {
            lblCancel.ForeColor = Color.CornflowerBlue;
            if (MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }


        private void btnLogin_Enter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.CornflowerBlue;
        }

        private void btnLogin_Leave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.MediumSlateBlue;
        }

        #endregion

        #region// this is to control the switch between login and signup
        private void lblSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSignUp frmSignUp = new FrmSignUp();
            frmSignUp.MdiParent = this.MdiParent;
            frmSignUp.Dock = DockStyle.Fill;
            frmSignUp.Show();
            
        }

        #endregion


        #region//this is to control the click event of close btn
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MdiMain main = new MdiMain();
                main.Show();
                this.Hide();
                

            }
        }


        #endregion

        
    }
}
