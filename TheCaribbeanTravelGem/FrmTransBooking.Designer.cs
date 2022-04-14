namespace TheCaribbeanTravelGem
{
    partial class FrmTransBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransBooking));
            this.panelBooking = new System.Windows.Forms.Panel();
            this.tgridBooking = new System.Windows.Forms.TableLayoutPanel();
            this.panelBookingInfo = new System.Windows.Forms.Panel();
            this.cbxInfants = new CustomControl.TDControls.TDComboBox();
            this.cbxChildren = new CustomControl.TDControls.TDComboBox();
            this.cbxAdults = new CustomControl.TDControls.TDComboBox();
            this.btnReserve = new CustomControls.TDControls.TDButton();
            this.txtSpecialComments = new CustomControls.TDControls.TDTextBox();
            this.btnRTime5pm = new CustomControls.TDControls.TDButton();
            this.btnRTime2pm = new CustomControls.TDControls.TDButton();
            this.btnRTime11am = new CustomControls.TDControls.TDButton();
            this.btnRTime4pm = new CustomControls.TDControls.TDButton();
            this.btnRTime1pm = new CustomControls.TDControls.TDButton();
            this.btnRTime10am = new CustomControls.TDControls.TDButton();
            this.btnRTime3pm = new CustomControls.TDControls.TDButton();
            this.btnRTime12pm = new CustomControls.TDControls.TDButton();
            this.btnRTime9am = new CustomControls.TDControls.TDButton();
            this.dtpReservationDate = new CustomControl.TDControls.TDDatePicker();
            this.lblReservationTime = new System.Windows.Forms.Label();
            this.lblReservationDate = new System.Windows.Forms.Label();
            this.txtNoGuest = new CustomControls.TDControls.TDTextBox();
            this.txtPhoneNumber = new CustomControls.TDControls.TDTextBox();
            this.txtEmail = new CustomControls.TDControls.TDTextBox();
            this.txtLastName = new CustomControls.TDControls.TDTextBox();
            this.txtFirstName = new CustomControls.TDControls.TDTextBox();
            this.lblReservationNotice = new System.Windows.Forms.Label();
            this.lblReservation = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.panelBooking.SuspendLayout();
            this.tgridBooking.SuspendLayout();
            this.panelBookingInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBooking
            // 
            this.panelBooking.BackgroundImage = global::TheCaribbeanTravelGem.Properties.Resources.julian_b_solter_MUG9PUlGmCk_unsplash;
            this.panelBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBooking.Controls.Add(this.tgridBooking);
            this.panelBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBooking.Location = new System.Drawing.Point(0, 0);
            this.panelBooking.MinimumSize = new System.Drawing.Size(800, 600);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelBooking.Size = new System.Drawing.Size(800, 600);
            this.panelBooking.TabIndex = 0;
            // 
            // tgridBooking
            // 
            this.tgridBooking.BackColor = System.Drawing.Color.Transparent;
            this.tgridBooking.ColumnCount = 5;
            this.tgridBooking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tgridBooking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tgridBooking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tgridBooking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tgridBooking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tgridBooking.Controls.Add(this.panelBookingInfo, 2, 1);
            this.tgridBooking.Controls.Add(this.btnBack, 0, 0);
            this.tgridBooking.Controls.Add(this.btnForward, 1, 0);
            this.tgridBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgridBooking.Location = new System.Drawing.Point(0, 0);
            this.tgridBooking.Name = "tgridBooking";
            this.tgridBooking.RowCount = 3;
            this.tgridBooking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tgridBooking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tgridBooking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tgridBooking.Size = new System.Drawing.Size(800, 580);
            this.tgridBooking.TabIndex = 0;
            // 
            // panelBookingInfo
            // 
            this.panelBookingInfo.AutoScroll = true;
            this.panelBookingInfo.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.panelBookingInfo.BackColor = System.Drawing.Color.White;
            this.panelBookingInfo.Controls.Add(this.cbxInfants);
            this.panelBookingInfo.Controls.Add(this.cbxChildren);
            this.panelBookingInfo.Controls.Add(this.cbxAdults);
            this.panelBookingInfo.Controls.Add(this.btnReserve);
            this.panelBookingInfo.Controls.Add(this.txtSpecialComments);
            this.panelBookingInfo.Controls.Add(this.btnRTime5pm);
            this.panelBookingInfo.Controls.Add(this.btnRTime2pm);
            this.panelBookingInfo.Controls.Add(this.btnRTime11am);
            this.panelBookingInfo.Controls.Add(this.btnRTime4pm);
            this.panelBookingInfo.Controls.Add(this.btnRTime1pm);
            this.panelBookingInfo.Controls.Add(this.btnRTime10am);
            this.panelBookingInfo.Controls.Add(this.btnRTime3pm);
            this.panelBookingInfo.Controls.Add(this.btnRTime12pm);
            this.panelBookingInfo.Controls.Add(this.btnRTime9am);
            this.panelBookingInfo.Controls.Add(this.dtpReservationDate);
            this.panelBookingInfo.Controls.Add(this.lblReservationTime);
            this.panelBookingInfo.Controls.Add(this.lblReservationDate);
            this.panelBookingInfo.Controls.Add(this.txtNoGuest);
            this.panelBookingInfo.Controls.Add(this.txtPhoneNumber);
            this.panelBookingInfo.Controls.Add(this.txtEmail);
            this.panelBookingInfo.Controls.Add(this.txtLastName);
            this.panelBookingInfo.Controls.Add(this.txtFirstName);
            this.panelBookingInfo.Controls.Add(this.lblReservationNotice);
            this.panelBookingInfo.Controls.Add(this.lblReservation);
            this.panelBookingInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBookingInfo.Location = new System.Drawing.Point(190, 61);
            this.panelBookingInfo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.panelBookingInfo.MaximumSize = new System.Drawing.Size(500, 780);
            this.panelBookingInfo.MinimumSize = new System.Drawing.Size(450, 500);
            this.panelBookingInfo.Name = "panelBookingInfo";
            this.panelBookingInfo.Padding = new System.Windows.Forms.Padding(10);
            this.panelBookingInfo.Size = new System.Drawing.Size(450, 500);
            this.panelBookingInfo.TabIndex = 6;
            // 
            // cbxInfants
            // 
            this.cbxInfants.BackColor = System.Drawing.Color.White;
            this.cbxInfants.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxInfants.BorderSize = 1;
            this.cbxInfants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxInfants.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxInfants.ForeColor = System.Drawing.Color.Black;
            this.cbxInfants.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxInfants.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbxInfants.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxInfants.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxInfants.Location = new System.Drawing.Point(294, 309);
            this.cbxInfants.MinimumSize = new System.Drawing.Size(100, 30);
            this.cbxInfants.Name = "cbxInfants";
            this.cbxInfants.Padding = new System.Windows.Forms.Padding(1);
            this.cbxInfants.Size = new System.Drawing.Size(115, 30);
            this.cbxInfants.TabIndex = 156;
            this.cbxInfants.Texts = "Infants";
            // 
            // cbxChildren
            // 
            this.cbxChildren.BackColor = System.Drawing.Color.White;
            this.cbxChildren.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxChildren.BorderSize = 1;
            this.cbxChildren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxChildren.ForeColor = System.Drawing.Color.Black;
            this.cbxChildren.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxChildren.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbxChildren.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxChildren.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxChildren.Location = new System.Drawing.Point(166, 309);
            this.cbxChildren.MinimumSize = new System.Drawing.Size(100, 30);
            this.cbxChildren.Name = "cbxChildren";
            this.cbxChildren.Padding = new System.Windows.Forms.Padding(1);
            this.cbxChildren.Size = new System.Drawing.Size(115, 30);
            this.cbxChildren.TabIndex = 156;
            this.cbxChildren.Texts = "Children";
            // 
            // cbxAdults
            // 
            this.cbxAdults.BackColor = System.Drawing.Color.White;
            this.cbxAdults.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxAdults.BorderSize = 1;
            this.cbxAdults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxAdults.ForeColor = System.Drawing.Color.Black;
            this.cbxAdults.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxAdults.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbxAdults.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxAdults.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxAdults.Location = new System.Drawing.Point(35, 309);
            this.cbxAdults.MinimumSize = new System.Drawing.Size(100, 30);
            this.cbxAdults.Name = "cbxAdults";
            this.cbxAdults.Padding = new System.Windows.Forms.Padding(1);
            this.cbxAdults.Size = new System.Drawing.Size(115, 30);
            this.cbxAdults.TabIndex = 156;
            this.cbxAdults.Texts = "Adults";
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReserve.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReserve.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReserve.BorderRadius = 40;
            this.btnReserve.BorderSize = 0;
            this.btnReserve.FlatAppearance.BorderSize = 0;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.ForeColor = System.Drawing.Color.White;
            this.btnReserve.Location = new System.Drawing.Point(144, 685);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(150, 40);
            this.btnReserve.TabIndex = 155;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.TextColor = System.Drawing.Color.White;
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            this.btnReserve.Enter += new System.EventHandler(this.btnReserve_Enter);
            this.btnReserve.Leave += new System.EventHandler(this.btnReserve_Leave);
            // 
            // txtSpecialComments
            // 
            this.txtSpecialComments.BackColor = System.Drawing.SystemColors.Window;
            this.txtSpecialComments.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSpecialComments.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtSpecialComments.BorderRadius = 0;
            this.txtSpecialComments.BorderSize = 2;
            this.txtSpecialComments.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialComments.ForeColor = System.Drawing.Color.Black;
            this.txtSpecialComments.Location = new System.Drawing.Point(35, 598);
            this.txtSpecialComments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSpecialComments.Multiline = true;
            this.txtSpecialComments.Name = "txtSpecialComments";
            this.txtSpecialComments.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSpecialComments.PasswordChar = false;
            this.txtSpecialComments.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSpecialComments.PlaceholderText = "Special Mentions, Request or Requirement";
            this.txtSpecialComments.Size = new System.Drawing.Size(373, 80);
            this.txtSpecialComments.TabIndex = 154;
            this.txtSpecialComments.Texts = "";
            this.txtSpecialComments.UnderlinedStyle = false;
            // 
            // btnRTime5pm
            // 
            this.btnRTime5pm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime5pm.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime5pm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRTime5pm.BorderRadius = 32;
            this.btnRTime5pm.BorderSize = 0;
            this.btnRTime5pm.FlatAppearance.BorderSize = 0;
            this.btnRTime5pm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRTime5pm.ForeColor = System.Drawing.Color.White;
            this.btnRTime5pm.Location = new System.Drawing.Point(281, 543);
            this.btnRTime5pm.MinimumSize = new System.Drawing.Size(80, 20);
            this.btnRTime5pm.Name = "btnRTime5pm";
            this.btnRTime5pm.Size = new System.Drawing.Size(96, 32);
            this.btnRTime5pm.TabIndex = 153;
            this.btnRTime5pm.Text = "5:00 PM";
            this.btnRTime5pm.TextColor = System.Drawing.Color.White;
            this.btnRTime5pm.UseVisualStyleBackColor = false;
            this.btnRTime5pm.Click += new System.EventHandler(this.btnRTime5pm_Click);
            // 
            // btnRTime2pm
            // 
            this.btnRTime2pm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime2pm.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime2pm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRTime2pm.BorderRadius = 32;
            this.btnRTime2pm.BorderSize = 0;
            this.btnRTime2pm.FlatAppearance.BorderSize = 0;
            this.btnRTime2pm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRTime2pm.ForeColor = System.Drawing.Color.White;
            this.btnRTime2pm.Location = new System.Drawing.Point(281, 496);
            this.btnRTime2pm.MinimumSize = new System.Drawing.Size(80, 20);
            this.btnRTime2pm.Name = "btnRTime2pm";
            this.btnRTime2pm.Size = new System.Drawing.Size(96, 32);
            this.btnRTime2pm.TabIndex = 152;
            this.btnRTime2pm.Text = "2:00 PM";
            this.btnRTime2pm.TextColor = System.Drawing.Color.White;
            this.btnRTime2pm.UseVisualStyleBackColor = false;
            this.btnRTime2pm.Click += new System.EventHandler(this.btnRTime2pm_Click);
            // 
            // btnRTime11am
            // 
            this.btnRTime11am.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime11am.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime11am.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRTime11am.BorderRadius = 32;
            this.btnRTime11am.BorderSize = 0;
            this.btnRTime11am.FlatAppearance.BorderSize = 0;
            this.btnRTime11am.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRTime11am.ForeColor = System.Drawing.Color.White;
            this.btnRTime11am.Location = new System.Drawing.Point(281, 449);
            this.btnRTime11am.MinimumSize = new System.Drawing.Size(80, 20);
            this.btnRTime11am.Name = "btnRTime11am";
            this.btnRTime11am.Size = new System.Drawing.Size(96, 32);
            this.btnRTime11am.TabIndex = 151;
            this.btnRTime11am.Text = "11:00 AM";
            this.btnRTime11am.TextColor = System.Drawing.Color.White;
            this.btnRTime11am.UseVisualStyleBackColor = false;
            this.btnRTime11am.Click += new System.EventHandler(this.btnRTime11am_Click);
            // 
            // btnRTime4pm
            // 
            this.btnRTime4pm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime4pm.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime4pm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRTime4pm.BorderRadius = 32;
            this.btnRTime4pm.BorderSize = 0;
            this.btnRTime4pm.FlatAppearance.BorderSize = 0;
            this.btnRTime4pm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRTime4pm.ForeColor = System.Drawing.Color.White;
            this.btnRTime4pm.Location = new System.Drawing.Point(171, 543);
            this.btnRTime4pm.MinimumSize = new System.Drawing.Size(80, 20);
            this.btnRTime4pm.Name = "btnRTime4pm";
            this.btnRTime4pm.Size = new System.Drawing.Size(96, 32);
            this.btnRTime4pm.TabIndex = 150;
            this.btnRTime4pm.Text = "4:00 PM";
            this.btnRTime4pm.TextColor = System.Drawing.Color.White;
            this.btnRTime4pm.UseVisualStyleBackColor = false;
            this.btnRTime4pm.Click += new System.EventHandler(this.btnRTime4pm_Click);
            // 
            // btnRTime1pm
            // 
            this.btnRTime1pm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime1pm.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime1pm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRTime1pm.BorderRadius = 32;
            this.btnRTime1pm.BorderSize = 0;
            this.btnRTime1pm.FlatAppearance.BorderSize = 0;
            this.btnRTime1pm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRTime1pm.ForeColor = System.Drawing.Color.White;
            this.btnRTime1pm.Location = new System.Drawing.Point(171, 496);
            this.btnRTime1pm.MinimumSize = new System.Drawing.Size(80, 20);
            this.btnRTime1pm.Name = "btnRTime1pm";
            this.btnRTime1pm.Size = new System.Drawing.Size(96, 32);
            this.btnRTime1pm.TabIndex = 149;
            this.btnRTime1pm.Text = "1:00 PM";
            this.btnRTime1pm.TextColor = System.Drawing.Color.White;
            this.btnRTime1pm.UseVisualStyleBackColor = false;
            this.btnRTime1pm.Click += new System.EventHandler(this.btnRTime1pm_Click);
            // 
            // btnRTime10am
            // 
            this.btnRTime10am.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime10am.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime10am.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRTime10am.BorderRadius = 32;
            this.btnRTime10am.BorderSize = 0;
            this.btnRTime10am.FlatAppearance.BorderSize = 0;
            this.btnRTime10am.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRTime10am.ForeColor = System.Drawing.Color.White;
            this.btnRTime10am.Location = new System.Drawing.Point(170, 449);
            this.btnRTime10am.MinimumSize = new System.Drawing.Size(80, 20);
            this.btnRTime10am.Name = "btnRTime10am";
            this.btnRTime10am.Size = new System.Drawing.Size(96, 32);
            this.btnRTime10am.TabIndex = 148;
            this.btnRTime10am.Text = "10:00 AM";
            this.btnRTime10am.TextColor = System.Drawing.Color.White;
            this.btnRTime10am.UseVisualStyleBackColor = false;
            this.btnRTime10am.Click += new System.EventHandler(this.btnRTime10am_Click);
            // 
            // btnRTime3pm
            // 
            this.btnRTime3pm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime3pm.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime3pm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRTime3pm.BorderRadius = 32;
            this.btnRTime3pm.BorderSize = 0;
            this.btnRTime3pm.FlatAppearance.BorderSize = 0;
            this.btnRTime3pm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRTime3pm.ForeColor = System.Drawing.Color.White;
            this.btnRTime3pm.Location = new System.Drawing.Point(60, 543);
            this.btnRTime3pm.MinimumSize = new System.Drawing.Size(80, 20);
            this.btnRTime3pm.Name = "btnRTime3pm";
            this.btnRTime3pm.Size = new System.Drawing.Size(96, 32);
            this.btnRTime3pm.TabIndex = 147;
            this.btnRTime3pm.Text = "3:00 PM";
            this.btnRTime3pm.TextColor = System.Drawing.Color.White;
            this.btnRTime3pm.UseVisualStyleBackColor = false;
            this.btnRTime3pm.Click += new System.EventHandler(this.btnRTime3pm_Click);
            // 
            // btnRTime12pm
            // 
            this.btnRTime12pm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime12pm.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime12pm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRTime12pm.BorderRadius = 32;
            this.btnRTime12pm.BorderSize = 0;
            this.btnRTime12pm.FlatAppearance.BorderSize = 0;
            this.btnRTime12pm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRTime12pm.ForeColor = System.Drawing.Color.White;
            this.btnRTime12pm.Location = new System.Drawing.Point(60, 496);
            this.btnRTime12pm.MinimumSize = new System.Drawing.Size(80, 20);
            this.btnRTime12pm.Name = "btnRTime12pm";
            this.btnRTime12pm.Size = new System.Drawing.Size(96, 32);
            this.btnRTime12pm.TabIndex = 146;
            this.btnRTime12pm.Text = "12:00 PM";
            this.btnRTime12pm.TextColor = System.Drawing.Color.White;
            this.btnRTime12pm.UseVisualStyleBackColor = false;
            this.btnRTime12pm.Click += new System.EventHandler(this.btnRTime12pm_Click);
            // 
            // btnRTime9am
            // 
            this.btnRTime9am.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime9am.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRTime9am.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRTime9am.BorderRadius = 32;
            this.btnRTime9am.BorderSize = 0;
            this.btnRTime9am.FlatAppearance.BorderSize = 0;
            this.btnRTime9am.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRTime9am.ForeColor = System.Drawing.Color.White;
            this.btnRTime9am.Location = new System.Drawing.Point(60, 449);
            this.btnRTime9am.MinimumSize = new System.Drawing.Size(80, 20);
            this.btnRTime9am.Name = "btnRTime9am";
            this.btnRTime9am.Size = new System.Drawing.Size(96, 32);
            this.btnRTime9am.TabIndex = 145;
            this.btnRTime9am.Text = "9:00 AM";
            this.btnRTime9am.TextColor = System.Drawing.Color.White;
            this.btnRTime9am.UseVisualStyleBackColor = false;
            this.btnRTime9am.Click += new System.EventHandler(this.btnRTime9am_Click);
            // 
            // dtpReservationDate
            // 
            this.dtpReservationDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpReservationDate.BorderSize = 0;
            this.dtpReservationDate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReservationDate.Location = new System.Drawing.Point(60, 381);
            this.dtpReservationDate.MinDate = new System.DateTime(2022, 3, 28, 0, 0, 0, 0);
            this.dtpReservationDate.MinimumSize = new System.Drawing.Size(50, 20);
            this.dtpReservationDate.Name = "dtpReservationDate";
            this.dtpReservationDate.Size = new System.Drawing.Size(317, 32);
            this.dtpReservationDate.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpReservationDate.TabIndex = 144;
            this.dtpReservationDate.TextColor = System.Drawing.Color.White;
            // 
            // lblReservationTime
            // 
            this.lblReservationTime.AutoSize = true;
            this.lblReservationTime.BackColor = System.Drawing.Color.White;
            this.lblReservationTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblReservationTime.Location = new System.Drawing.Point(42, 427);
            this.lblReservationTime.Name = "lblReservationTime";
            this.lblReservationTime.Size = new System.Drawing.Size(146, 22);
            this.lblReservationTime.TabIndex = 142;
            this.lblReservationTime.Text = "Reservation Time";
            // 
            // lblReservationDate
            // 
            this.lblReservationDate.AutoSize = true;
            this.lblReservationDate.BackColor = System.Drawing.Color.White;
            this.lblReservationDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblReservationDate.Location = new System.Drawing.Point(42, 360);
            this.lblReservationDate.Name = "lblReservationDate";
            this.lblReservationDate.Size = new System.Drawing.Size(143, 22);
            this.lblReservationDate.TabIndex = 143;
            this.lblReservationDate.Text = "Reservation Date";
            // 
            // txtNoGuest
            // 
            this.txtNoGuest.BackColor = System.Drawing.Color.White;
            this.txtNoGuest.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNoGuest.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtNoGuest.BorderRadius = 0;
            this.txtNoGuest.BorderSize = 2;
            this.txtNoGuest.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoGuest.ForeColor = System.Drawing.Color.Black;
            this.txtNoGuest.Location = new System.Drawing.Point(239, 243);
            this.txtNoGuest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoGuest.MinimumSize = new System.Drawing.Size(100, 33);
            this.txtNoGuest.Multiline = false;
            this.txtNoGuest.Name = "txtNoGuest";
            this.txtNoGuest.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtNoGuest.PasswordChar = false;
            this.txtNoGuest.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNoGuest.PlaceholderText = "No. of Guests";
            this.txtNoGuest.Size = new System.Drawing.Size(170, 39);
            this.txtNoGuest.TabIndex = 140;
            this.txtNoGuest.Texts = "";
            this.txtNoGuest.UnderlinedStyle = true;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhoneNumber.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPhoneNumber.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtPhoneNumber.BorderRadius = 0;
            this.txtPhoneNumber.BorderSize = 2;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.Location = new System.Drawing.Point(35, 243);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNumber.MinimumSize = new System.Drawing.Size(100, 33);
            this.txtPhoneNumber.Multiline = false;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtPhoneNumber.PasswordChar = false;
            this.txtPhoneNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhoneNumber.PlaceholderText = "Phone Number";
            this.txtPhoneNumber.Size = new System.Drawing.Size(170, 39);
            this.txtPhoneNumber.TabIndex = 141;
            this.txtPhoneNumber.Texts = "";
            this.txtPhoneNumber.UnderlinedStyle = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtEmail.BorderRadius = 0;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(35, 184);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.MinimumSize = new System.Drawing.Size(100, 37);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(374, 39);
            this.txtEmail.TabIndex = 139;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLastName.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtLastName.BorderRadius = 0;
            this.txtLastName.BorderSize = 2;
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.Location = new System.Drawing.Point(239, 126);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.MinimumSize = new System.Drawing.Size(100, 33);
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtLastName.PasswordChar = false;
            this.txtLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.Size = new System.Drawing.Size(170, 39);
            this.txtLastName.TabIndex = 138;
            this.txtLastName.Texts = "";
            this.txtLastName.UnderlinedStyle = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFirstName.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtFirstName.BorderRadius = 0;
            this.txtFirstName.BorderSize = 2;
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(35, 126);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.MinimumSize = new System.Drawing.Size(100, 33);
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtFirstName.PasswordChar = false;
            this.txtFirstName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.Size = new System.Drawing.Size(170, 39);
            this.txtFirstName.TabIndex = 137;
            this.txtFirstName.Texts = "";
            this.txtFirstName.UnderlinedStyle = true;
            // 
            // lblReservationNotice
            // 
            this.lblReservationNotice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationNotice.Location = new System.Drawing.Point(32, 54);
            this.lblReservationNotice.Name = "lblReservationNotice";
            this.lblReservationNotice.Size = new System.Drawing.Size(382, 66);
            this.lblReservationNotice.TabIndex = 135;
            this.lblReservationNotice.Text = "Please fill the form below accurately to enable us serve you better!...\r\nWelcome " +
    "to our booking form!";
            // 
            // lblReservation
            // 
            this.lblReservation.AutoSize = true;
            this.lblReservation.BackColor = System.Drawing.Color.White;
            this.lblReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservation.Location = new System.Drawing.Point(45, 25);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(307, 40);
            this.lblReservation.TabIndex = 136;
            this.lblReservation.Text = "Make Reservation";
            this.lblReservation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::TheCaribbeanTravelGem.Properties.Resources.icons8_back_30;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 30);
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.Location = new System.Drawing.Point(33, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(30, 30);
            this.btnForward.TabIndex = 13;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // FrmTransBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelBooking);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FrmTransBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.panelBooking.ResumeLayout(false);
            this.tgridBooking.ResumeLayout(false);
            this.panelBookingInfo.ResumeLayout(false);
            this.panelBookingInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBooking;
        private System.Windows.Forms.TableLayoutPanel tgridBooking;
        private System.Windows.Forms.Panel panelBookingInfo;
        private CustomControls.TDControls.TDButton btnReserve;
        private CustomControls.TDControls.TDTextBox txtSpecialComments;
        private CustomControls.TDControls.TDButton btnRTime5pm;
        private CustomControls.TDControls.TDButton btnRTime2pm;
        private CustomControls.TDControls.TDButton btnRTime11am;
        private CustomControls.TDControls.TDButton btnRTime4pm;
        private CustomControls.TDControls.TDButton btnRTime1pm;
        private CustomControls.TDControls.TDButton btnRTime10am;
        private CustomControls.TDControls.TDButton btnRTime3pm;
        private CustomControls.TDControls.TDButton btnRTime12pm;
        private CustomControls.TDControls.TDButton btnRTime9am;
        private CustomControl.TDControls.TDDatePicker dtpReservationDate;
        private System.Windows.Forms.Label lblReservationTime;
        private System.Windows.Forms.Label lblReservationDate;
        private CustomControls.TDControls.TDTextBox txtNoGuest;
        private CustomControls.TDControls.TDTextBox txtPhoneNumber;
        private CustomControls.TDControls.TDTextBox txtEmail;
        private CustomControls.TDControls.TDTextBox txtLastName;
        private CustomControls.TDControls.TDTextBox txtFirstName;
        private System.Windows.Forms.Label lblReservationNotice;
        private System.Windows.Forms.Label lblReservation;
        private CustomControl.TDControls.TDComboBox cbxChildren;
        private CustomControl.TDControls.TDComboBox cbxAdults;
        private CustomControl.TDControls.TDComboBox cbxInfants;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
    }
}