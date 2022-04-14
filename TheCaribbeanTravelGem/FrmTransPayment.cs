using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCTGLibrary;

namespace TheCaribbeanTravelGem
{
    public partial class FrmTransPayment : Form
    {
        public FrmTransPayment()
        {
            InitializeComponent();
        }
        public FrmTransPayment(TransBooking booking)
        {
            InitializeComponent();
        }

        #region//this control the click event of pay now button
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtCardNumber.Texts == "")// unlike the system text feature; we had to use texts keyword to obtain info cuz what was created for our custom textbox
            {
                MessageBox.Show("Please enter your card number", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCardNumber.Focus();
            }
            else if (txtExpirationDate.Texts == "")//the card expiration date
            {
                MessageBox.Show("Please enter the expiration date of the card", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExpirationDate.Focus();
            }
            else if (txtCVC.Texts == "")//the card CVC
            {
                MessageBox.Show("Please enter the CVC number of the card", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCVC.Focus();
            }
            else if (txtStreetAddress.Texts == "")//the street address
            {
                MessageBox.Show("Please checked a gender", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStreetAddress.Focus();
            }
            else if (cbxCountry.Texts == "Select Country")//the country
            {
                MessageBox.Show("Please select your country", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCVC.Focus();
            }
            else if (txtCity.Texts == "")//the country
            {
                MessageBox.Show("Please enter your city", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCity.Focus();
            }
            else if (txtState.Texts == "")//the country
            {
                MessageBox.Show("Please enter your state", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtState.Focus();
            }
            else if (txtZipCode.Texts == "")//the country
            {
                MessageBox.Show("Please enter your zip code", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtZipCode.Focus();
            }
            else
            {
                MessageBox.Show("Payment successfully completed", 
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Payment payment = new Payment();
                payment.CardNumber = txtCardNumber.Texts;
                payment.ExpirationDate =  txtExpirationDate.Texts;
                payment.CVC = Convert.ToInt16(txtCVC.Texts);
                payment.StreetAddress = txtStreetAddress.Texts;
                payment.Apt= txtApt.Texts;
                payment.Country = cbxCountry.Texts;
                payment.City = txtCity.Texts;
                payment.State = txtState.Texts;
                payment.ZipCode = txtZipCode.Texts;

            }

        }
        #endregion

        #region//to control the change colour event
        private void btnPay_Enter(object sender, EventArgs e)
        {
            btnPay.BackColor = Color.CornflowerBlue;
        }

        private void btnPay_Leave(object sender, EventArgs e)
        {
            btnPay.BackColor = Color.MediumSlateBlue;
        }
        #endregion


        #region//to control the back and forward between forms
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTransBooking back = new FrmTransBooking();
            back.Show();

        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTransportation forward = new FrmTransportation();
            forward.Show();

        }
        #endregion

    }
}
