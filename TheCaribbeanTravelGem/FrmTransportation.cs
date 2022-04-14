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
    public partial class FrmTransportation : Form
    {
        private int imageNumber; // to help control the slider

        public FrmTransportation()
        {
            InitializeComponent();
            panelTranportInfo.BackColor = Color.FromArgb(80, 0, 0, 0);//change alpha(A) to get desired opacity.
        }

        #region // to control the slider
        private void LoadNextImage()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;

            }

            pbxSlider.ImageLocation = string.Format(@"Transportation\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timerSlider_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        #endregion

        #region//to control the listing btn
        private void btnListing_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTransListing listing = new FrmTransListing();
            listing.Show();
        }
        #endregion

        #region//to control the back and forward between forms
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTransportation back = new FrmTransportation();
            back.Show();

        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTransListing forward = new FrmTransListing();
            forward.Show();

        }
        #endregion

        
    }
}
