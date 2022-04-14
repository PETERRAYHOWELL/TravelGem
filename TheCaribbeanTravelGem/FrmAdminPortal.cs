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
    public partial class FrmAdminPortal : Form
    {
        FrmLogin cur_frmLogin;//this allows when logout it ccarries back to the login page

        //default constructor
        public FrmAdminPortal()
        {
            InitializeComponent();
            hideSubMenu();
        }

        //copy constructor
        public FrmAdminPortal(FrmLogin frmLogin)
        {
            InitializeComponent();
            hideSubMenu();
            cur_frmLogin = frmLogin;//this allows when logout it ccarries back to the login page
        }

        #region // the main things controlling the menu and submenu and child form
        //to hide the submenus on loading
        private void hideSubMenu()
        {
            panelAccomondSubMenu.Visible = false;
            panelAttrSubMenu.Visible = false;
            panelGastSubMenu.Visible = false;
            panelEveSubMenu.Visible = false;
            panelTransportSubMenu.Visible = false;
            panelAnaSubMenu.Visible = false;
            panelUserInfoSubMenu.Visible = false;
        }

        //to show the submenus when clicked on
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        //holds space for active form
        private Form activeForm = null;

        //tio place the forms as a childform inside the panel
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        private void FrmAdminPortal_Load(object sender, EventArgs e)
        {
            openChildForm(new FrmHome());


        }

        //to invoke the show and hide of the sub menu and show the selected form
        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmHome());
        }

        #region//to control the transportation button
        private void btnTransport_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTransportSubMenu);
            openChildForm(new FrmTransportation());
            /*FrmTransportation transport = new FrmTransportation();
            transport.Show();
            this.Hide();*/
        }

        private void btnTranListing_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTransListing());
            hideSubMenu();

        }

        private void btnTranBooking_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTransBooking());
            hideSubMenu();
        }

        private void btnTranPayment_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTransPayment());
            hideSubMenu();
        }

        private void btnTranSchedule_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmScheduleAndFares());
            hideSubMenu();
        }

        private void btnTranFAQ_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmFrequentlyAsked());
            hideSubMenu();
        }
        #endregion

        #region// to control the accommodation button
        private void btnAccommodation_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAccomondSubMenu);
            //openChildForm(new FrmAccomodation());
        }

        private void btnAccoListing_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAccoBooking_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAccoPayment_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAccoGallery_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAccoFAQ_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        #region// to control the gastronomy button
        private void btnGastronomy_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGastSubMenu);
            //openChildForm(new FrmGasteronomy());
        }

        private void btnGastListing_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnGastBooking_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnGastPayment_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnGastGallery_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnGastFAQ_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        #region//to control the attraction button
        private void btnAttraction_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAttrSubMenu);
            //openChildForm(new FrmAttraction());
        }

        private void btnAttrListing_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void btnAttrBooking_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAttrPayment_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAttrGallery_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAttrFAQ_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        #region//to control the event button
        private void btnEvent_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEveSubMenu);
            //openChildForm(new FrmEvent());
        }

        private void btnEveListing_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnEveBooking_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnEvePayment_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnEveGallery_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnEveFAQ_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }


        #endregion

        #region//to control the analysis button
        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAnaSubMenu);
            //openChildForm(new FrmAnalysis());
        }

        private void btnAnaTransport_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAnaAccomond_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAnaGast_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAnaAttr_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAnaEven_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }



        #endregion

        #region// to control the panel for the admin info
        private void btnAdminInfo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUserInfoSubMenu);
            panelUserInfoSubMenu.BringToFront();
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FrmProfile());

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (MessageBox.Show("Are you should you would like to logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                cur_frmLogin.Show(); //this allows when logout it carries back to the login page

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            hideSubMenu();
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
