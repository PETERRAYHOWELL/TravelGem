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
    public partial class FrmTransListing : Form
    {
        public FrmTransListing()
        {
            InitializeComponent();
        }

        private void btnKnutsfordInfo_Click(object sender, EventArgs e)
        {
            FrmKnutsfordExpress frmKnutsford = new FrmKnutsfordExpress();
            frmKnutsford.Show();
            this.Hide();
        }

        private void btnKingston_Click(object sender, EventArgs e)
        {
            FrmClubKingston frmClubKingston = new FrmClubKingston();
            frmClubKingston.Show();
            this.Hide();
        }

        

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
            FrmKnutsfordExpress forward = new FrmKnutsfordExpress();
            forward.Show();

        }
        #endregion
    }
}
