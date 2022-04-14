namespace TheCaribbeanTravelGem
{
    partial class FrmTransPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransPayment));
            this.panelPayment = new System.Windows.Forms.Panel();
            this.tgridPayment = new System.Windows.Forms.TableLayoutPanel();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelPaymentInfo = new System.Windows.Forms.Panel();
            this.btnPay = new CustomControls.TDControls.TDButton();
            this.cbxCountry = new CustomControl.TDControls.TDComboBox();
            this.txtApt = new CustomControls.TDControls.TDTextBox();
            this.txtStreetAddress = new CustomControls.TDControls.TDTextBox();
            this.txtZipCode = new CustomControls.TDControls.TDTextBox();
            this.txtCity = new CustomControls.TDControls.TDTextBox();
            this.txtState = new CustomControls.TDControls.TDTextBox();
            this.txtExpirationDate = new CustomControls.TDControls.TDTextBox();
            this.txtCVC = new CustomControls.TDControls.TDTextBox();
            this.txtCardNumber = new CustomControls.TDControls.TDTextBox();
            this.lblReservationNotice = new System.Windows.Forms.Label();
            this.lblResrvation = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.panelPayment.SuspendLayout();
            this.tgridPayment.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panelPaymentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPayment
            // 
            this.panelPayment.BackgroundImage = global::TheCaribbeanTravelGem.Properties.Resources.beach_holiday_vacation_caribbean;
            this.panelPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPayment.Controls.Add(this.tgridPayment);
            this.panelPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPayment.Location = new System.Drawing.Point(0, 0);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(800, 675);
            this.panelPayment.TabIndex = 0;
            // 
            // tgridPayment
            // 
            this.tgridPayment.BackColor = System.Drawing.Color.Transparent;
            this.tgridPayment.ColumnCount = 6;
            this.tgridPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tgridPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tgridPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tgridPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tgridPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tgridPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tgridPayment.Controls.Add(this.panelTotal, 4, 1);
            this.tgridPayment.Controls.Add(this.panelPaymentInfo, 3, 1);
            this.tgridPayment.Controls.Add(this.btnBack, 0, 0);
            this.tgridPayment.Controls.Add(this.btnForward, 1, 0);
            this.tgridPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgridPayment.Location = new System.Drawing.Point(0, 0);
            this.tgridPayment.Name = "tgridPayment";
            this.tgridPayment.RowCount = 3;
            this.tgridPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tgridPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tgridPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tgridPayment.Size = new System.Drawing.Size(800, 675);
            this.tgridPayment.TabIndex = 0;
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelTotal.Controls.Add(this.label6);
            this.panelTotal.Controls.Add(this.label5);
            this.panelTotal.Controls.Add(this.label4);
            this.panelTotal.Controls.Add(this.label3);
            this.panelTotal.Controls.Add(this.label2);
            this.panelTotal.Controls.Add(this.panel2);
            this.panelTotal.Controls.Add(this.lblTotal);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTotal.Location = new System.Drawing.Point(519, 115);
            this.panelTotal.MinimumSize = new System.Drawing.Size(50, 450);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(144, 450);
            this.panelTotal.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 124;
            this.label6.Text = "Price: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 125;
            this.label5.Text = "No of Guest: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 126;
            this.label4.Text = "Subtotal: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 127;
            this.label3.Text = "GCT: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 128;
            this.label2.Text = "Total: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 5);
            this.panel2.TabIndex = 123;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(15, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(97, 40);
            this.lblTotal.TabIndex = 122;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelPaymentInfo
            // 
            this.panelPaymentInfo.BackColor = System.Drawing.SystemColors.Control;
            this.panelPaymentInfo.Controls.Add(this.btnPay);
            this.panelPaymentInfo.Controls.Add(this.cbxCountry);
            this.panelPaymentInfo.Controls.Add(this.txtApt);
            this.panelPaymentInfo.Controls.Add(this.txtStreetAddress);
            this.panelPaymentInfo.Controls.Add(this.txtZipCode);
            this.panelPaymentInfo.Controls.Add(this.txtCity);
            this.panelPaymentInfo.Controls.Add(this.txtState);
            this.panelPaymentInfo.Controls.Add(this.txtExpirationDate);
            this.panelPaymentInfo.Controls.Add(this.txtCVC);
            this.panelPaymentInfo.Controls.Add(this.txtCardNumber);
            this.panelPaymentInfo.Controls.Add(this.lblReservationNotice);
            this.panelPaymentInfo.Controls.Add(this.lblResrvation);
            this.panelPaymentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPaymentInfo.Location = new System.Drawing.Point(169, 115);
            this.panelPaymentInfo.MinimumSize = new System.Drawing.Size(350, 450);
            this.panelPaymentInfo.Name = "panelPaymentInfo";
            this.panelPaymentInfo.Size = new System.Drawing.Size(350, 450);
            this.panelPaymentInfo.TabIndex = 3;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPay.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPay.BorderRadius = 40;
            this.btnPay.BorderSize = 0;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(104, 394);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(150, 45);
            this.btnPay.TabIndex = 121;
            this.btnPay.Text = "Pay Now";
            this.btnPay.TextColor = System.Drawing.Color.White;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            this.btnPay.Enter += new System.EventHandler(this.btnPay_Enter);
            this.btnPay.Leave += new System.EventHandler(this.btnPay_Leave);
            // 
            // cbxCountry
            // 
            this.cbxCountry.BackColor = System.Drawing.SystemColors.Control;
            this.cbxCountry.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxCountry.BorderSize = 1;
            this.cbxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxCountry.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCountry.ForeColor = System.Drawing.Color.Black;
            this.cbxCountry.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxCountry.Items.AddRange(new object[] {
            "Albania",
            "Argentina",
            "Australia",
            "Bangladesh",
            "Belgium",
            "Brazil",
            "Bulgaria",
            "Canada",
            "Cape Verde",
            "Chile",
            "China",
            "Colombia",
            "Croatia",
            "Czech Republic",
            "Denmark",
            "Dominican Republic",
            "Egypt",
            "El Salvador",
            "Estonia",
            "Finland",
            "France",
            "Germany",
            "Ghana",
            "Greece",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Ireland",
            "Italy",
            "Japan",
            "Jordan",
            "Latvia",
            "Lebanon",
            "Lithuania",
            "Luxembourg",
            "Malaysia",
            "Malta",
            "Mexico",
            "Morocco",
            "Mozambique",
            "Netherlands",
            "New Zealand",
            "Nigeria",
            "Norway",
            "Pakistan",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Republic of Korea",
            "Romania",
            "Russian Federation",
            "Saudi Arabia",
            "Serbia",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "South Africa",
            "Spain",
            "Sweden",
            "Switzerland",
            "Thailand",
            "Trinidad and Tobago",
            "Turkey",
            "Ukraine",
            "United Kingdom",
            "United Republic of Tanzania",
            "United States of America",
            "Venezuela",
            "Vietnam",
            "Zambia"});
            this.cbxCountry.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxCountry.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxCountry.Location = new System.Drawing.Point(25, 299);
            this.cbxCountry.MinimumSize = new System.Drawing.Size(200, 34);
            this.cbxCountry.Name = "cbxCountry";
            this.cbxCountry.Padding = new System.Windows.Forms.Padding(1);
            this.cbxCountry.Size = new System.Drawing.Size(290, 34);
            this.cbxCountry.TabIndex = 120;
            this.cbxCountry.Texts = "Select Country";
            // 
            // txtApt
            // 
            this.txtApt.BackColor = System.Drawing.SystemColors.Control;
            this.txtApt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtApt.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtApt.BorderRadius = 0;
            this.txtApt.BorderSize = 2;
            this.txtApt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApt.ForeColor = System.Drawing.Color.Black;
            this.txtApt.Location = new System.Drawing.Point(25, 245);
            this.txtApt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApt.Multiline = false;
            this.txtApt.Name = "txtApt";
            this.txtApt.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtApt.PasswordChar = false;
            this.txtApt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtApt.PlaceholderText = "Apt, Suite, Unit, etc. (optional)";
            this.txtApt.Size = new System.Drawing.Size(290, 39);
            this.txtApt.TabIndex = 119;
            this.txtApt.Texts = "";
            this.txtApt.UnderlinedStyle = true;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtStreetAddress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtStreetAddress.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtStreetAddress.BorderRadius = 0;
            this.txtStreetAddress.BorderSize = 2;
            this.txtStreetAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetAddress.ForeColor = System.Drawing.Color.Black;
            this.txtStreetAddress.Location = new System.Drawing.Point(25, 194);
            this.txtStreetAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStreetAddress.Multiline = false;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtStreetAddress.PasswordChar = false;
            this.txtStreetAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtStreetAddress.PlaceholderText = "Street Address";
            this.txtStreetAddress.Size = new System.Drawing.Size(290, 39);
            this.txtStreetAddress.TabIndex = 118;
            this.txtStreetAddress.Texts = "";
            this.txtStreetAddress.UnderlinedStyle = true;
            // 
            // txtZipCode
            // 
            this.txtZipCode.BackColor = System.Drawing.SystemColors.Control;
            this.txtZipCode.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtZipCode.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtZipCode.BorderRadius = 0;
            this.txtZipCode.BorderSize = 2;
            this.txtZipCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZipCode.ForeColor = System.Drawing.Color.Black;
            this.txtZipCode.Location = new System.Drawing.Point(245, 342);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtZipCode.Multiline = false;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtZipCode.PasswordChar = false;
            this.txtZipCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtZipCode.PlaceholderText = "ZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(70, 39);
            this.txtZipCode.TabIndex = 117;
            this.txtZipCode.Texts = "";
            this.txtZipCode.UnderlinedStyle = true;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.Control;
            this.txtCity.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCity.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtCity.BorderRadius = 0;
            this.txtCity.BorderSize = 2;
            this.txtCity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.Black;
            this.txtCity.Location = new System.Drawing.Point(25, 342);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCity.Multiline = false;
            this.txtCity.Name = "txtCity";
            this.txtCity.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtCity.PasswordChar = false;
            this.txtCity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCity.PlaceholderText = "City";
            this.txtCity.Size = new System.Drawing.Size(100, 39);
            this.txtCity.TabIndex = 117;
            this.txtCity.Texts = "";
            this.txtCity.UnderlinedStyle = true;
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.SystemColors.Control;
            this.txtState.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtState.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtState.BorderRadius = 0;
            this.txtState.BorderSize = 2;
            this.txtState.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.ForeColor = System.Drawing.Color.Black;
            this.txtState.Location = new System.Drawing.Point(136, 342);
            this.txtState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtState.Multiline = false;
            this.txtState.Name = "txtState";
            this.txtState.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtState.PasswordChar = false;
            this.txtState.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtState.PlaceholderText = "State";
            this.txtState.Size = new System.Drawing.Size(100, 39);
            this.txtState.TabIndex = 117;
            this.txtState.Texts = "";
            this.txtState.UnderlinedStyle = true;
            // 
            // txtExpirationDate
            // 
            this.txtExpirationDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtExpirationDate.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtExpirationDate.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtExpirationDate.BorderRadius = 0;
            this.txtExpirationDate.BorderSize = 2;
            this.txtExpirationDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpirationDate.ForeColor = System.Drawing.Color.Black;
            this.txtExpirationDate.Location = new System.Drawing.Point(25, 142);
            this.txtExpirationDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExpirationDate.Multiline = false;
            this.txtExpirationDate.Name = "txtExpirationDate";
            this.txtExpirationDate.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtExpirationDate.PasswordChar = false;
            this.txtExpirationDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtExpirationDate.PlaceholderText = "MM/YY";
            this.txtExpirationDate.Size = new System.Drawing.Size(113, 39);
            this.txtExpirationDate.TabIndex = 117;
            this.txtExpirationDate.Texts = "";
            this.txtExpirationDate.UnderlinedStyle = true;
            // 
            // txtCVC
            // 
            this.txtCVC.BackColor = System.Drawing.SystemColors.Control;
            this.txtCVC.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCVC.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtCVC.BorderRadius = 0;
            this.txtCVC.BorderSize = 2;
            this.txtCVC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC.ForeColor = System.Drawing.Color.Black;
            this.txtCVC.Location = new System.Drawing.Point(202, 142);
            this.txtCVC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCVC.Multiline = false;
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtCVC.PasswordChar = false;
            this.txtCVC.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCVC.PlaceholderText = "CVC";
            this.txtCVC.Size = new System.Drawing.Size(113, 39);
            this.txtCVC.TabIndex = 117;
            this.txtCVC.Texts = "";
            this.txtCVC.UnderlinedStyle = true;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtCardNumber.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCardNumber.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtCardNumber.BorderRadius = 0;
            this.txtCardNumber.BorderSize = 2;
            this.txtCardNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.ForeColor = System.Drawing.Color.Black;
            this.txtCardNumber.Location = new System.Drawing.Point(25, 93);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCardNumber.Multiline = false;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtCardNumber.PasswordChar = false;
            this.txtCardNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCardNumber.PlaceholderText = "Card Number";
            this.txtCardNumber.Size = new System.Drawing.Size(290, 39);
            this.txtCardNumber.TabIndex = 117;
            this.txtCardNumber.Texts = "";
            this.txtCardNumber.UnderlinedStyle = true;
            // 
            // lblReservationNotice
            // 
            this.lblReservationNotice.BackColor = System.Drawing.SystemColors.Control;
            this.lblReservationNotice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationNotice.Location = new System.Drawing.Point(22, 55);
            this.lblReservationNotice.Name = "lblReservationNotice";
            this.lblReservationNotice.Size = new System.Drawing.Size(246, 30);
            this.lblReservationNotice.TabIndex = 115;
            this.lblReservationNotice.Text = "Please enter your payment details";
            // 
            // lblResrvation
            // 
            this.lblResrvation.AutoSize = true;
            this.lblResrvation.BackColor = System.Drawing.SystemColors.Control;
            this.lblResrvation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResrvation.Location = new System.Drawing.Point(25, 16);
            this.lblResrvation.Name = "lblResrvation";
            this.lblResrvation.Size = new System.Drawing.Size(375, 40);
            this.lblResrvation.TabIndex = 116;
            this.lblResrvation.Text = "Confirm your Payment";
            this.lblResrvation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnForward.Size = new System.Drawing.Size(24, 30);
            this.btnForward.TabIndex = 13;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // FrmTransPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.panelPayment);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FrmTransPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.panelPayment.ResumeLayout(false);
            this.tgridPayment.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panelPaymentInfo.ResumeLayout(false);
            this.panelPaymentInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.TableLayoutPanel tgridPayment;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panelPaymentInfo;
        private CustomControls.TDControls.TDButton btnPay;
        private CustomControl.TDControls.TDComboBox cbxCountry;
        private CustomControls.TDControls.TDTextBox txtApt;
        private CustomControls.TDControls.TDTextBox txtStreetAddress;
        private CustomControls.TDControls.TDTextBox txtZipCode;
        private CustomControls.TDControls.TDTextBox txtCity;
        private CustomControls.TDControls.TDTextBox txtState;
        private CustomControls.TDControls.TDTextBox txtExpirationDate;
        private CustomControls.TDControls.TDTextBox txtCVC;
        private CustomControls.TDControls.TDTextBox txtCardNumber;
        private System.Windows.Forms.Label lblReservationNotice;
        private System.Windows.Forms.Label lblResrvation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
    }
}