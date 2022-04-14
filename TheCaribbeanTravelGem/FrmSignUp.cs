using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using TCTGLibrary;

namespace TheCaribbeanTravelGem
{
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        #region//to control the the validating email
        private void ValidateEmail()
        {
            string email = txtEmail.Texts;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                MessageBox.Show(email + " is Valid Email Address", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("Registration completed and Account created successfully \n" + txtUsername.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Give access to the main

                //to create an instance of the client class to gain the variables and attach to the form  
                Client client = new Client();
                client.FirstName = txtFirstName.Texts;
                client.LastName = txtLastName.Texts;
                if (optFemale.Checked == true)
                { client.Gender = "Female"; }
                else if (optMale.Checked == true)
                { client.Gender = " Male"; }
                else if (optOthers.Checked == true)
                { client.Gender = "Others"; }
                client.Dob = dtpDOB.Value.Date;
                client.Country = cbxCountry.Texts;
                client.Nationality = cbxNationality.Texts;
                client.Email = txtEmail.Texts;
                client.Telephone1 = txtPhoneNumber1.Texts;
                client.Telephone2 = txtPhoneNumber2.Texts;
                client.Username = txtUsername.Texts;
                client.Password = txtPassword.Texts;



                FrmClientPortal frmClient = new FrmClientPortal();
                frmClient.MdiParent = this.MdiParent;//to ensure it loads in the mdimain through the login
                frmClient.Show();
                frmClient.Dock = DockStyle.Fill;
                this.Hide();

            }
            else
            { MessageBox.Show(email + " is Invalid Email Address", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        #endregion


        #region//to control the verification when sign up button is clicked 
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Texts == "")// unlike the system text feature; we had to use texts keyword to obtain info cuz what was created for our custom textbox
            {
                MessageBox.Show("Please enter First Name", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
            }
            else if (txtLastName.Texts == "")//last name
            {
                MessageBox.Show("Please enter Last Name", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
            }
            else if (optMale.Checked != true && optFemale.Checked != true && optOthers.Checked != true)//gender
            {
                MessageBox.Show("Please checked a gender", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
            }
            else if (dtpDOB.Value.Date == DateTime.Now.Date)//DOB
            {
                MessageBox.Show("Please enter Date of Birth", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDOB.Focus();
            }
            else if (cbxCountry.Texts == "Select Country")//country
            {
                MessageBox.Show("Please select a country", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxCountry.Focus();
            }
            else if (cbxNationality.Texts == "Select Nationality")//nationality
            {
                MessageBox.Show("Please select a nationality", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxNationality.Focus();
            }
            else if (txtEmail.Texts == "")//email
            {
                MessageBox.Show("Please enter your email address", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
            else if (txtPhoneNumber1.Texts == "")//phone
            {
                MessageBox.Show("Please enter your phone number", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber1.Focus();
            }
            else if (txtUsername.Texts == "")//username
            {
                MessageBox.Show("Please enter username", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else if (txtPassword.Texts == "")//password
            {
                MessageBox.Show("Please enter password", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else if (tbtnNotice.Checked != true)//toggle button 
            {
                MessageBox.Show("Please select to confirm your consent to proceed forward", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbtnNotice.Focus();
                tbtnNotice.OffBackColor = Color.CornflowerBlue;
            }
            else
            {
                ValidateEmail(); // this function ensure to valid email then send everything to the client class and output message box
            }
        }
        #endregion


        #region//to allow when cancel is clicked the exit the application instead of the regular exit and the focus for the signup button
        private void labelCancel_Click(object sender, EventArgs e)
        {
            lblCancel.ForeColor = Color.CornflowerBlue;
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSignUp_Enter(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.CornflowerBlue;
        }

        private void btnSignUp_Leave(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.MediumSlateBlue;
        }


        #endregion

        #region// this is to control the switch between login and signup 
        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.MdiParent = this.MdiParent;
            frmLogin.Dock = DockStyle.Fill;
            frmLogin.Show();
            
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
