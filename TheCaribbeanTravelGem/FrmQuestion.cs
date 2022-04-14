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

namespace TheCaribbeanTravelGem
{
    public partial class FrmQuestion : Form
    {
        public FrmQuestion()
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
                MessageBox.Show( email + " is Valid Email Address", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Your question has been sent and \nyou will received a email response", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { MessageBox.Show( email + " is Invalid Email Address", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        #endregion

        #region//to control the verification upon clicking submit button
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (txtName.Texts == "")// unlike the system text feature; we had to use texts keyword to obtain info cuz what was created for our custom textbox
            {
                MessageBox.Show("Please enter your full name", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else if (txtEmail.Texts == "")
                {
                MessageBox.Show("Please enter your email", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                }
            else if (txtQuestion.Texts == "")
                {
                MessageBox.Show("Please enter your question", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuestion.Focus();
                }
            else if (cbxTopic.Texts == "Select Topic")
                {
                MessageBox.Show("Please select an topic", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxTopic.Focus();
                }
            else if (txtEmail.Texts != "")
            {
                ValidateEmail();
            }
            
        }
        #endregion


        #region//this is to control the click event of close btn
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmFrequentlyAsked frequent = new FrmFrequentlyAsked();
                frequent.Show();
                this.Close();
            }
        }

        private void btnSubmit_Enter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.CornflowerBlue;
        }

        private void btnSubmit_Leave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.FromArgb(41, 21, 126);
        }
        #endregion


    }
}

