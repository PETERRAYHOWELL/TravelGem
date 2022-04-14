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
    public partial class FrmClubKingston : Form
    {
        public FrmClubKingston()
        {
            InitializeComponent();
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            float KPrice = 0.0f;
            if (optVipAdult.Checked == true)
            {
                KPrice = 40.00f;
            }
            if (optVipChild.Checked == true)
            {
                KPrice = 20.00f;
            }
            if (optRegAdult.Checked == true)
            {
                KPrice = 30.00f;
            }
            if (optRegChild.Checked == true)
            {
                KPrice = 20.00f;
            }
            if (optBundleAdult.Checked == true)
            {
                KPrice = 70.00f;
            }
            if (optBundleChild.Checked == true)
            {
                KPrice = 40.00f;
            }
            if (optFreeInfant.Checked == true)
            {
                KPrice = 0.00f;
            }

            //Rental rental = new Rental(txtFirstName.Text, txtLastName.Text, gender, txtStreet.Text, txtCity.Text, parish);

            FrmTransBooking frmBooking = new FrmTransBooking();
            frmBooking.Show();
            this.Hide();
        }

        // for the map, has error needs more work on
        private void wbrClubKingston_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string street = "Port Royal";

            try
            {

                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("http://maps.google.com/maps?q=");

                if (street != null) { stringBuilder.Append(street + ", +"); }


                wbrClubKingston.Navigate(stringBuilder.ToString());
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message.ToString(), "Error"); }
        }


        #region//to control the back and forward between forms
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTransListing back = new FrmTransListing();
            back.Show();

        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTransBooking forward = new FrmTransBooking();
            forward.Show();

        }
        #endregion
    }
}
