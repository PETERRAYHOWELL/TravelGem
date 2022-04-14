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
    public partial class FrmKnutsfordExpress : Form
    {
       

        public FrmKnutsfordExpress()
        {
            InitializeComponent();
        }

        //to open the Booking form
        private void btnBookNow_Click(object sender, EventArgs e)
        {
            float KPrice;
            if (optEarly.Checked == true)
            {
                KPrice = 900.00f;
            }
            if (optAdult.Checked == true)
            {
                KPrice = 900.00f;
            }
            if (optChild.Checked == true)
            {
                KPrice = 650.00f;
            }
            if (optSenior.Checked == true)
            {
                KPrice = 750.00f;
            }
            if (optStudent.Checked == true)
            {
                KPrice = 700.00f;
            }


            
            //Rental rental = new Rental(txtFirstName.Text, txtLastName.Text, gender, txtStreet.Text, txtCity.Text, parish);

            FrmTransBooking frmBooking = new FrmTransBooking();
            frmBooking.Show();
            this.Hide();
        }

        //to open the schedule form
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            FrmScheduleAndFares frmSchedule = new FrmScheduleAndFares();
            frmSchedule.Show();
            this.Hide();
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

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //webBrowser1.Navigate("http://www.google.com");//if we want to set a default browser
        }

        
    }
}
