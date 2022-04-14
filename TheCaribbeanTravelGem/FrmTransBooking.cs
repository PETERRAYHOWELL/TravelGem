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
    public partial class FrmTransBooking : Form
    {
        private string rTime; //to add control the reservation time selected
        private int nGuest; //to add control the number of guest selected
        private int nAdults, nChildren, nInfants, nTotalGuest; //to add control the number of guest selected


        public FrmTransBooking()//default constructor
        {
            this.nGuest = 0;
            this.nAdults = 0;
            this.nChildren = 0;
            this.nInfants = 0;
            this.nTotalGuest = 0;
            InitializeComponent();
        }

        public FrmTransBooking(int NGuest, int NAdults, int NChildren, int NInfants, int NTotalGuest)//primary constructor
        {
            this.nGuest = NGuest;
            this.nAdults = NAdults;
            this.nChildren = NChildren;
            this.nInfants = NInfants;
            this.nTotalGuest = NTotalGuest;
            InitializeComponent();
        }

        #region//the button event for the time
        private void btnRTime9am_Click(object sender, EventArgs e)
        {
            
            btnRTime9am.Text = "9:00 AM";
            rTime= btnRTime9am.Text;
            
        }

        private void btnRTime10am_Click(object sender, EventArgs e)
        {
            
            btnRTime10am.Text = "10:00 AM";
            rTime = btnRTime10am.Text;
        }

        private void btnRTime11am_Click(object sender, EventArgs e)
        {
            
            btnRTime11am.Text = "11:00 AM";
            rTime = btnRTime11am.Text;
        }

        private void btnRTime12pm_Click(object sender, EventArgs e)
        {
            
            btnRTime12pm.Text = "12:00 PM";
            rTime = btnRTime12pm.Text;
        }

        private void btnRTime1pm_Click(object sender, EventArgs e)
        {
            
            btnRTime1pm.Text = "1:00 PM";
            rTime = btnRTime1pm.Text;
        }

        private void btnRTime2pm_Click(object sender, EventArgs e)
        {
            
            btnRTime2pm.Text = "2:00 PM";
            rTime = btnRTime2pm.Text;
        }

        private void btnRTime3pm_Click(object sender, EventArgs e)
        {
            
            btnRTime3pm.Text = "3:00 PM";
            rTime = btnRTime3pm.Text;
        }

        private void btnRTime4pm_Click(object sender, EventArgs e)
        {
            
            btnRTime4pm.Text = "4:00 PM";
            rTime = btnRTime4pm.Text;
        }

        private void btnRTime5pm_Click(object sender, EventArgs e)
        {
            
            btnRTime5pm.Text = "5:00 PM";
            rTime = btnRTime5pm.Text;
        }
        #endregion


        #region//to control the the validating email
        private void ValidateEmail()
        {
            string email = txtEmail.Texts;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                MessageBox.Show(email + " is Valid Email Address", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //to create an instance of the client class to gain the variables and attach to the form  
                TransBooking booking = new TransBooking();
                booking.FirstName = txtFirstName.Texts;
                booking.LastName = txtLastName.Texts;
                booking.Email = txtEmail.Texts;
                booking.Telephone = txtPhoneNumber.Texts;
                booking.NoGuest = nGuest;
                booking.ReservationDate = dtpReservationDate.Value.Date;
                booking.ReservationTime = rTime;
                booking.SpecialComments = txtSpecialComments.Texts;

                //send a small confirmation for the booking
                MessageBox.Show("Reservation booked for " + booking.FirstName + " " + booking.LastName + "\n" +
                    "Date: " + booking.ReservationDate.ToString("MM/dd/yyyy") + " and Time: " + booking.ReservationTime + "\nNo of guest: " + booking.NoGuest, "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Give access to the payment
                FrmTransPayment frmPayment = new FrmTransPayment(booking);
                frmPayment.Show();
                this.Hide();

            }
            else
            { MessageBox.Show(email + " is Invalid Email Address", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning); }// only if the email is invalid
        }
        #endregion


        #region//the code for the click event of the reserve button
        private void btnReserve_Click(object sender, EventArgs e)
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
            else if (txtEmail.Texts == "")//email
            {
                MessageBox.Show("Please enter email address", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
            else if (txtPhoneNumber.Texts == "")//phone
            {
                MessageBox.Show("Please enter your phone", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Focus();
            }
            else if (txtNoGuest.Texts == "")//no of guest
            {
                MessageBox.Show("Please enter the number of guest ", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoGuest.Focus();
            }
            else if (cbxAdults.Texts == "Adults")//no of guest
            {
                MessageBox.Show("Please select the number of people for the catergory ", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxAdults.Focus();
            }
            else if (dtpReservationDate.Value.Date == DateTime.Now.Date)//Reservation date
            {
                MessageBox.Show("Please enter your preferred reservation date", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpReservationDate.Focus();
            }
            else
            {
                #region// this is to control the combox box for number of adults, children and infant
                //this needs an exceptation handling due to the infant and children if statements
                if (cbxAdults.Texts == "Adult")
                {
                    cbxAdults.Texts = "0";
                }
                else if (cbxAdults.Texts != "Adult" || cbxAdults.Texts != "0")
                {
                    this.nAdults = Convert.ToInt16(cbxAdults.Texts);
                    //txtNoGuest.Texts = Convert.ToString(nGuest);
                }

                if (cbxChildren.Texts == "Children")
                {
                    cbxChildren.Texts = "0";
                }
                else if (cbxChildren.Texts != "Children" ||cbxChildren.Texts != "0")
                {
                    //System.Diagnostics.Debug.WriteLine(cbxChildren.Texts); --> to see where error occured
                    this.nChildren = Convert.ToInt16(cbxChildren.Texts);
                    
                    //txtNoGuest.Texts = Convert.ToString(nGuest);
                }

                if (cbxInfants.Texts == "Infants")
                {
                    cbxInfants.Texts = "0";
                }
                else if (cbxInfants.Texts != "Infants" || cbxInfants.Texts != "0")
                {
                    //System.Diagnostics.Debug.WriteLine(cbxInfants.Texts); --> to see where error occured
                    this.nInfants = Convert.ToInt16(cbxInfants.Texts);
                    
                }
                
                this.nGuest = nAdults + nChildren + nInfants;
                #endregion

                #region// this is to control and ensure the both numbers match
                if (txtNoGuest.Texts != "")
                { this.nTotalGuest = Convert.ToInt16(txtNoGuest.Texts); }

                if (nTotalGuest != nGuest)
                {
                    MessageBox.Show("Please confirm the number of guest entered");
                    txtNoGuest.Focus();
                }

                else
                {
                    ValidateEmail();// inside the validate email function you can see the the info being inputted in the class and output message box
                   
                }
                #endregion

            }
        }
        #endregion


        #region//to change the colour when focus enter or leave
        private void btnReserve_Enter(object sender, EventArgs e)
        {
            btnReserve.BackColor = Color.CornflowerBlue;
        }

        private void btnReserve_Leave(object sender, EventArgs e)
        {
            btnReserve.BackColor = Color.MediumSlateBlue;
        }

        #endregion

        #region//to control the back and forward between forms
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKnutsfordExpress back = new FrmKnutsfordExpress();
            back.Show();

        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTransPayment forward = new FrmTransPayment();
            forward.Show();

        }
        #endregion
    }
}
