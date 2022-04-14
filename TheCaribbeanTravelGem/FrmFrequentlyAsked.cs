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
    public partial class FrmFrequentlyAsked : Form
    {

        //default constructor
        public FrmFrequentlyAsked()
        {
            InitializeComponent();
        }

       

        #region// to control the pop up ask question form for users
        private void btnQuestion_Click(object sender, EventArgs e)
        {
            Form frmBackground = new Form();

            try
            {
                using (FrmQuestion question = new FrmQuestion())
                {
                    frmBackground.StartPosition = FormStartPosition.CenterScreen;
                    frmBackground.FormBorderStyle= FormBorderStyle.None;
                    frmBackground.Opacity = .70d;
                    frmBackground.BackColor = Color.Black;
                    frmBackground.WindowState = FormWindowState.Maximized;
                    frmBackground.TopMost = true;
                    frmBackground.Location = this.Location;
                    frmBackground.ShowInTaskbar = false;
                    frmBackground.Show();

                    question.Owner = frmBackground;
                    question.ShowDialog();

                    frmBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                frmBackground.Dispose();
            }
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
            FrmQuestion forward = new FrmQuestion();
            forward.Show();

        }
        #endregion

    }
}
