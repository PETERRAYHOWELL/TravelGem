namespace TheCaribbeanTravelGem
{
    partial class FrmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignUp));
            this.panelSignUp = new System.Windows.Forms.Panel();
            this.tgridSignUp = new System.Windows.Forms.TableLayoutPanel();
            this.panelSignUpForm = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.tbtnNotice = new CustomControls.TDControls.TDToggleButton();
            this.lblNotice = new System.Windows.Forms.Label();
            this.btnSignUp = new CustomControls.TDControls.TDButton();
            this.txtPassword = new CustomControls.TDControls.TDTextBox();
            this.txtUsername = new CustomControls.TDControls.TDTextBox();
            this.txtPhoneNumber2 = new CustomControls.TDControls.TDTextBox();
            this.txtEmail = new CustomControls.TDControls.TDTextBox();
            this.txtPhoneNumber1 = new CustomControls.TDControls.TDTextBox();
            this.cbxNationality = new CustomControl.TDControls.TDComboBox();
            this.cbxCountry = new CustomControl.TDControls.TDComboBox();
            this.dtpDOB = new CustomControl.TDControls.TDDatePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.gbxGender = new System.Windows.Forms.GroupBox();
            this.optOthers = new CustomControl.TDControls.TDRadioButton();
            this.optFemale = new CustomControl.TDControls.TDRadioButton();
            this.optMale = new CustomControl.TDControls.TDRadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtLastName = new CustomControls.TDControls.TDTextBox();
            this.txtFirstName = new CustomControls.TDControls.TDTextBox();
            this.lblThanks = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelSignUp.SuspendLayout();
            this.tgridSignUp.SuspendLayout();
            this.panelSignUpForm.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.gbxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSignUp
            // 
            this.panelSignUp.BackgroundImage = global::TheCaribbeanTravelGem.Properties.Resources.pexels_photo_3822155;
            this.panelSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSignUp.Controls.Add(this.tgridSignUp);
            this.panelSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSignUp.Location = new System.Drawing.Point(0, 0);
            this.panelSignUp.Name = "panelSignUp";
            this.panelSignUp.Size = new System.Drawing.Size(800, 675);
            this.panelSignUp.TabIndex = 0;
            // 
            // tgridSignUp
            // 
            this.tgridSignUp.BackColor = System.Drawing.Color.Transparent;
            this.tgridSignUp.ColumnCount = 3;
            this.tgridSignUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tgridSignUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 474F));
            this.tgridSignUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tgridSignUp.Controls.Add(this.panelSignUpForm, 1, 1);
            this.tgridSignUp.Controls.Add(this.btnClose, 2, 0);
            this.tgridSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgridSignUp.Location = new System.Drawing.Point(0, 0);
            this.tgridSignUp.Name = "tgridSignUp";
            this.tgridSignUp.RowCount = 3;
            this.tgridSignUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tgridSignUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 512F));
            this.tgridSignUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tgridSignUp.Size = new System.Drawing.Size(800, 675);
            this.tgridSignUp.TabIndex = 0;
            // 
            // panelSignUpForm
            // 
            this.panelSignUpForm.BackColor = System.Drawing.Color.White;
            this.panelSignUpForm.Controls.Add(this.panelInfo);
            this.panelSignUpForm.Controls.Add(this.lblThanks);
            this.panelSignUpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSignUpForm.Location = new System.Drawing.Point(166, 84);
            this.panelSignUpForm.Name = "panelSignUpForm";
            this.panelSignUpForm.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.panelSignUpForm.Size = new System.Drawing.Size(468, 506);
            this.panelSignUpForm.TabIndex = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.AutoScroll = true;
            this.panelInfo.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.panelInfo.Controls.Add(this.lblRegister);
            this.panelInfo.Controls.Add(this.lblLogin);
            this.panelInfo.Controls.Add(this.lblCancel);
            this.panelInfo.Controls.Add(this.tbtnNotice);
            this.panelInfo.Controls.Add(this.lblNotice);
            this.panelInfo.Controls.Add(this.btnSignUp);
            this.panelInfo.Controls.Add(this.txtPassword);
            this.panelInfo.Controls.Add(this.txtUsername);
            this.panelInfo.Controls.Add(this.txtPhoneNumber2);
            this.panelInfo.Controls.Add(this.txtEmail);
            this.panelInfo.Controls.Add(this.txtPhoneNumber1);
            this.panelInfo.Controls.Add(this.cbxNationality);
            this.panelInfo.Controls.Add(this.cbxCountry);
            this.panelInfo.Controls.Add(this.dtpDOB);
            this.panelInfo.Controls.Add(this.lblDOB);
            this.panelInfo.Controls.Add(this.gbxGender);
            this.panelInfo.Controls.Add(this.txtLastName);
            this.panelInfo.Controls.Add(this.txtFirstName);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(5, 56, 5, 56);
            this.panelInfo.Size = new System.Drawing.Size(468, 484);
            this.panelInfo.TabIndex = 138;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.White;
            this.lblRegister.Font = new System.Drawing.Font("Cream Cake", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(68, 22);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(358, 70);
            this.lblRegister.TabIndex = 171;
            this.lblRegister.Text = "Thank you for registering with us at\r\nThe Caribbean Travel Gem";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.DimGray;
            this.lblLogin.Location = new System.Drawing.Point(162, 716);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(174, 18);
            this.lblLogin.TabIndex = 170;
            this.lblLogin.Text = "Already Have An Account";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.DimGray;
            this.lblCancel.Location = new System.Drawing.Point(221, 743);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(50, 18);
            this.lblCancel.TabIndex = 169;
            this.lblCancel.Text = "Cancel";
            this.lblCancel.Click += new System.EventHandler(this.labelCancel_Click);
            // 
            // tbtnNotice
            // 
            this.tbtnNotice.AutoSize = true;
            this.tbtnNotice.Location = new System.Drawing.Point(59, 593);
            this.tbtnNotice.MinimumSize = new System.Drawing.Size(45, 25);
            this.tbtnNotice.Name = "tbtnNotice";
            this.tbtnNotice.OffBackColor = System.Drawing.Color.Gray;
            this.tbtnNotice.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbtnNotice.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbtnNotice.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbtnNotice.Size = new System.Drawing.Size(45, 25);
            this.tbtnNotice.TabIndex = 167;
            this.tbtnNotice.UseVisualStyleBackColor = true;
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.Location = new System.Drawing.Point(131, 580);
            this.lblNotice.MinimumSize = new System.Drawing.Size(285, 54);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(295, 57);
            this.lblNotice.TabIndex = 166;
            this.lblNotice.Text = "By clicking, you are agreeing to allow our team \r\nuse your information for survey" +
    "s to assist \r\nthe Ministry of Tourism in Jamaica.";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSignUp.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSignUp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignUp.BorderRadius = 40;
            this.btnSignUp.BorderSize = 0;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(165, 660);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(150, 45);
            this.btnSignUp.TabIndex = 165;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.TextColor = System.Drawing.Color.White;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            this.btnSignUp.Enter += new System.EventHandler(this.btnSignUp_Enter);
            this.btnSignUp.Leave += new System.EventHandler(this.btnSignUp_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtPassword.BorderRadius = 0;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(259, 509);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.MinimumSize = new System.Drawing.Size(160, 37);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(160, 37);
            this.txtPassword.TabIndex = 161;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUsername.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtUsername.BorderRadius = 0;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(62, 509);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.MinimumSize = new System.Drawing.Size(160, 37);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(160, 37);
            this.txtUsername.TabIndex = 162;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = true;
            // 
            // txtPhoneNumber2
            // 
            this.txtPhoneNumber2.BackColor = System.Drawing.Color.White;
            this.txtPhoneNumber2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPhoneNumber2.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtPhoneNumber2.BorderRadius = 0;
            this.txtPhoneNumber2.BorderSize = 2;
            this.txtPhoneNumber2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber2.ForeColor = System.Drawing.Color.DimGray;
            this.txtPhoneNumber2.Location = new System.Drawing.Point(259, 456);
            this.txtPhoneNumber2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNumber2.MinimumSize = new System.Drawing.Size(160, 37);
            this.txtPhoneNumber2.Multiline = false;
            this.txtPhoneNumber2.Name = "txtPhoneNumber2";
            this.txtPhoneNumber2.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtPhoneNumber2.PasswordChar = false;
            this.txtPhoneNumber2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhoneNumber2.PlaceholderText = "Phone Number #2";
            this.txtPhoneNumber2.Size = new System.Drawing.Size(160, 37);
            this.txtPhoneNumber2.TabIndex = 158;
            this.txtPhoneNumber2.Texts = "";
            this.txtPhoneNumber2.UnderlinedStyle = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtEmail.BorderRadius = 0;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(59, 402);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.MinimumSize = new System.Drawing.Size(160, 37);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "Email Address";
            this.txtEmail.Size = new System.Drawing.Size(357, 37);
            this.txtEmail.TabIndex = 160;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // txtPhoneNumber1
            // 
            this.txtPhoneNumber1.BackColor = System.Drawing.Color.White;
            this.txtPhoneNumber1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPhoneNumber1.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtPhoneNumber1.BorderRadius = 0;
            this.txtPhoneNumber1.BorderSize = 2;
            this.txtPhoneNumber1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber1.ForeColor = System.Drawing.Color.DimGray;
            this.txtPhoneNumber1.Location = new System.Drawing.Point(62, 456);
            this.txtPhoneNumber1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNumber1.MinimumSize = new System.Drawing.Size(160, 37);
            this.txtPhoneNumber1.Multiline = false;
            this.txtPhoneNumber1.Name = "txtPhoneNumber1";
            this.txtPhoneNumber1.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtPhoneNumber1.PasswordChar = false;
            this.txtPhoneNumber1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhoneNumber1.PlaceholderText = "Phone Number #1";
            this.txtPhoneNumber1.Size = new System.Drawing.Size(160, 37);
            this.txtPhoneNumber1.TabIndex = 159;
            this.txtPhoneNumber1.Texts = "";
            this.txtPhoneNumber1.UnderlinedStyle = true;
            // 
            // cbxNationality
            // 
            this.cbxNationality.BackColor = System.Drawing.Color.White;
            this.cbxNationality.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxNationality.BorderSize = 1;
            this.cbxNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxNationality.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNationality.ForeColor = System.Drawing.Color.DimGray;
            this.cbxNationality.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxNationality.Items.AddRange(new object[] {
            "African",
            "American",
            "Argentinian",
            "Austrian",
            "Australian",
            "Bangladesh(i)",
            "Belgian",
            "Brazilian",
            "British",
            "Cambodian",
            "Chilean",
            "Chinese",
            "Colombian",
            "Croatian",
            "Czech",
            "Danish",
            "English",
            "Finnish",
            "French",
            "German",
            "Greek",
            "Dutch",
            "Hungarian",
            "Icelandic",
            "Indian",
            "Indonesian",
            "Iranian",
            "Iraqi",
            "Irish",
            "Israeli",
            "Jamaican",
            "Japanese",
            "Mexican",
            "Moroccan",
            "Norwegian",
            "Peruvian",
            "Philippine",
            "Polish",
            "Portuguese",
            "Rumanian",
            "Russian",
            "Saudi, Saudi Arabian",
            "Scottish",
            "Serbian",
            "Slovak",
            "Swedish",
            "Swiss",
            "Thai",
            "American",
            "Tunisian",
            "Turkish",
            "Vietnamese",
            "Welsh",
            "Yugoslav"});
            this.cbxNationality.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxNationality.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxNationality.Location = new System.Drawing.Point(249, 353);
            this.cbxNationality.MinimumSize = new System.Drawing.Size(100, 22);
            this.cbxNationality.Name = "cbxNationality";
            this.cbxNationality.Padding = new System.Windows.Forms.Padding(1);
            this.cbxNationality.Size = new System.Drawing.Size(165, 29);
            this.cbxNationality.TabIndex = 157;
            this.cbxNationality.Texts = "Select Nationality";
            // 
            // cbxCountry
            // 
            this.cbxCountry.BackColor = System.Drawing.Color.White;
            this.cbxCountry.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxCountry.BorderSize = 1;
            this.cbxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxCountry.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCountry.ForeColor = System.Drawing.Color.DimGray;
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
            this.cbxCountry.Location = new System.Drawing.Point(57, 353);
            this.cbxCountry.MinimumSize = new System.Drawing.Size(100, 22);
            this.cbxCountry.Name = "cbxCountry";
            this.cbxCountry.Padding = new System.Windows.Forms.Padding(1);
            this.cbxCountry.Size = new System.Drawing.Size(165, 29);
            this.cbxCountry.TabIndex = 156;
            this.cbxCountry.Texts = "Select Country";
            // 
            // dtpDOB
            // 
            this.dtpDOB.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpDOB.BorderSize = 0;
            this.dtpDOB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(96, 291);
            this.dtpDOB.MinimumSize = new System.Drawing.Size(100, 25);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(317, 26);
            this.dtpDOB.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpDOB.TabIndex = 155;
            this.dtpDOB.TextColor = System.Drawing.Color.White;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(76, 261);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(91, 18);
            this.lblDOB.TabIndex = 154;
            this.lblDOB.Text = "Date of Birth";
            // 
            // gbxGender
            // 
            this.gbxGender.BackColor = System.Drawing.Color.White;
            this.gbxGender.Controls.Add(this.optOthers);
            this.gbxGender.Controls.Add(this.optFemale);
            this.gbxGender.Controls.Add(this.optMale);
            this.gbxGender.Controls.Add(this.lblGender);
            this.gbxGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxGender.Location = new System.Drawing.Point(57, 168);
            this.gbxGender.Name = "gbxGender";
            this.gbxGender.Size = new System.Drawing.Size(357, 78);
            this.gbxGender.TabIndex = 153;
            this.gbxGender.TabStop = false;
            // 
            // optOthers
            // 
            this.optOthers.AutoSize = true;
            this.optOthers.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.optOthers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optOthers.Location = new System.Drawing.Point(260, 42);
            this.optOthers.MinimumSize = new System.Drawing.Size(0, 24);
            this.optOthers.Name = "optOthers";
            this.optOthers.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.optOthers.Size = new System.Drawing.Size(78, 26);
            this.optOthers.TabIndex = 129;
            this.optOthers.TabStop = true;
            this.optOthers.Text = "Other";
            this.optOthers.UnCheckedColor = System.Drawing.Color.Gray;
            this.optOthers.UseVisualStyleBackColor = true;
            // 
            // optFemale
            // 
            this.optFemale.AutoSize = true;
            this.optFemale.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.optFemale.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optFemale.Location = new System.Drawing.Point(157, 42);
            this.optFemale.MinimumSize = new System.Drawing.Size(0, 24);
            this.optFemale.Name = "optFemale";
            this.optFemale.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.optFemale.Size = new System.Drawing.Size(88, 26);
            this.optFemale.TabIndex = 130;
            this.optFemale.TabStop = true;
            this.optFemale.Text = "Female";
            this.optFemale.UnCheckedColor = System.Drawing.Color.Gray;
            this.optFemale.UseVisualStyleBackColor = true;
            // 
            // optMale
            // 
            this.optMale.AutoSize = true;
            this.optMale.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.optMale.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMale.Location = new System.Drawing.Point(70, 42);
            this.optMale.MinimumSize = new System.Drawing.Size(0, 24);
            this.optMale.Name = "optMale";
            this.optMale.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.optMale.Size = new System.Drawing.Size(71, 26);
            this.optMale.TabIndex = 131;
            this.optMale.TabStop = true;
            this.optMale.Text = "Male";
            this.optMale.UnCheckedColor = System.Drawing.Color.Gray;
            this.optMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(19, 6);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(55, 18);
            this.lblGender.TabIndex = 128;
            this.lblGender.Text = "Gender";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLastName.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtLastName.BorderRadius = 0;
            this.txtLastName.BorderSize = 2;
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.DimGray;
            this.txtLastName.Location = new System.Drawing.Point(254, 116);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.MinimumSize = new System.Drawing.Size(160, 37);
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtLastName.PasswordChar = false;
            this.txtLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.Size = new System.Drawing.Size(160, 37);
            this.txtLastName.TabIndex = 144;
            this.txtLastName.Texts = "";
            this.txtLastName.UnderlinedStyle = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFirstName.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtFirstName.BorderRadius = 0;
            this.txtFirstName.BorderSize = 2;
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.txtFirstName.Location = new System.Drawing.Point(57, 116);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.MinimumSize = new System.Drawing.Size(160, 37);
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtFirstName.PasswordChar = false;
            this.txtFirstName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.Size = new System.Drawing.Size(160, 37);
            this.txtFirstName.TabIndex = 145;
            this.txtFirstName.Texts = "";
            this.txtFirstName.UnderlinedStyle = true;
            // 
            // lblThanks
            // 
            this.lblThanks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblThanks.BackColor = System.Drawing.Color.White;
            this.lblThanks.Font = new System.Drawing.Font("Cream Cake", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.Location = new System.Drawing.Point(-3, -14);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Padding = new System.Windows.Forms.Padding(10, 17, 10, 11);
            this.lblThanks.Size = new System.Drawing.Size(474, 112);
            this.lblThanks.TabIndex = 137;
            this.lblThanks.Text = "Thank you for registering with us at\r\nThe Caribbean Travel Gem\r\n";
            this.lblThanks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TheCaribbeanTravelGem.Properties.Resources.icons8_close_18;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(767, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(20);
            this.btnClose.Size = new System.Drawing.Size(30, 75);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.panelSignUp);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FrmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.panelSignUp.ResumeLayout(false);
            this.tgridSignUp.ResumeLayout(false);
            this.panelSignUpForm.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.gbxGender.ResumeLayout(false);
            this.gbxGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSignUp;
        private System.Windows.Forms.TableLayoutPanel tgridSignUp;
        private System.Windows.Forms.Panel panelSignUpForm;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Panel panelInfo;
        private CustomControls.TDControls.TDTextBox txtLastName;
        private CustomControls.TDControls.TDTextBox txtFirstName;
        private System.Windows.Forms.GroupBox gbxGender;
        private CustomControl.TDControls.TDRadioButton optOthers;
        private CustomControl.TDControls.TDRadioButton optFemale;
        private CustomControl.TDControls.TDRadioButton optMale;
        private System.Windows.Forms.Label lblGender;
        private CustomControl.TDControls.TDDatePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private CustomControl.TDControls.TDComboBox cbxNationality;
        private CustomControl.TDControls.TDComboBox cbxCountry;
        private CustomControls.TDControls.TDTextBox txtPhoneNumber2;
        private CustomControls.TDControls.TDTextBox txtEmail;
        private CustomControls.TDControls.TDTextBox txtPhoneNumber1;
        private CustomControls.TDControls.TDTextBox txtPassword;
        private CustomControls.TDControls.TDTextBox txtUsername;
        private CustomControls.TDControls.TDButton btnSignUp;
        private CustomControls.TDControls.TDToggleButton tbtnNotice;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRegister;
    }
}