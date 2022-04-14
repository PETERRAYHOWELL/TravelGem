namespace TheCaribbeanTravelGem
{
    partial class FrmKnutsfordExpress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKnutsfordExpress));
            this.TableInformation = new System.Windows.Forms.TableLayoutPanel();
            this.panelPicture1 = new System.Windows.Forms.Panel();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelPlaceInfo = new System.Windows.Forms.Panel();
            this.tdComboBox1 = new CustomControl.TDControls.TDComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.optSenior = new CustomControl.TDControls.TDRadioButton();
            this.optStudent = new CustomControl.TDControls.TDRadioButton();
            this.optChild = new CustomControl.TDControls.TDRadioButton();
            this.optAdult = new CustomControl.TDControls.TDRadioButton();
            this.optEarly = new CustomControl.TDControls.TDRadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSchedule = new CustomControls.TDControls.TDButton();
            this.btnBookNow = new CustomControls.TDControls.TDButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPicture2 = new System.Windows.Forms.Panel();
            this.panelPicture3 = new System.Windows.Forms.Panel();
            this.panelPicture4 = new System.Windows.Forms.Panel();
            this.panelPicture5 = new System.Windows.Forms.Panel();
            this.panelGoogleMap = new System.Windows.Forms.Panel();
            this.wbrKnutsford = new System.Windows.Forms.WebBrowser();
            this.panelContactInfo = new System.Windows.Forms.Panel();
            this.lblCompanyNumbers = new System.Windows.Forms.Label();
            this.lblCompanyEmail = new System.Windows.Forms.Label();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.TableInformation.SuspendLayout();
            this.panelPicture1.SuspendLayout();
            this.panelPlaceInfo.SuspendLayout();
            this.panelGoogleMap.SuspendLayout();
            this.panelContactInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableInformation
            // 
            this.TableInformation.ColumnCount = 3;
            this.TableInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableInformation.Controls.Add(this.panelPicture1, 0, 0);
            this.TableInformation.Controls.Add(this.panelPlaceInfo, 0, 1);
            this.TableInformation.Controls.Add(this.panelPicture2, 1, 1);
            this.TableInformation.Controls.Add(this.panelPicture3, 2, 1);
            this.TableInformation.Controls.Add(this.panelPicture4, 1, 2);
            this.TableInformation.Controls.Add(this.panelPicture5, 2, 2);
            this.TableInformation.Controls.Add(this.panelGoogleMap, 0, 3);
            this.TableInformation.Controls.Add(this.panelContactInfo, 0, 4);
            this.TableInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableInformation.Location = new System.Drawing.Point(0, 0);
            this.TableInformation.Name = "TableInformation";
            this.TableInformation.RowCount = 5;
            this.TableInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.56753F));
            this.TableInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28845F));
            this.TableInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28845F));
            this.TableInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.56752F));
            this.TableInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28805F));
            this.TableInformation.Size = new System.Drawing.Size(800, 675);
            this.TableInformation.TabIndex = 0;
            // 
            // panelPicture1
            // 
            this.panelPicture1.BackgroundImage = global::TheCaribbeanTravelGem.Properties.Resources.knutsfordexpressmontegobay;
            this.panelPicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TableInformation.SetColumnSpan(this.panelPicture1, 3);
            this.panelPicture1.Controls.Add(this.btnForward);
            this.panelPicture1.Controls.Add(this.btnBack);
            this.panelPicture1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPicture1.Location = new System.Drawing.Point(3, 3);
            this.panelPicture1.Name = "panelPicture1";
            this.panelPicture1.Size = new System.Drawing.Size(794, 186);
            this.panelPicture1.TabIndex = 0;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.Location = new System.Drawing.Point(36, 0);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(30, 30);
            this.btnForward.TabIndex = 13;
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::TheCaribbeanTravelGem.Properties.Resources.icons8_back_30;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelPlaceInfo
            // 
            this.panelPlaceInfo.AutoScroll = true;
            this.panelPlaceInfo.AutoScrollMinSize = new System.Drawing.Size(2, 2);
            this.panelPlaceInfo.Controls.Add(this.tdComboBox1);
            this.panelPlaceInfo.Controls.Add(this.label7);
            this.panelPlaceInfo.Controls.Add(this.optSenior);
            this.panelPlaceInfo.Controls.Add(this.optStudent);
            this.panelPlaceInfo.Controls.Add(this.optChild);
            this.panelPlaceInfo.Controls.Add(this.optAdult);
            this.panelPlaceInfo.Controls.Add(this.optEarly);
            this.panelPlaceInfo.Controls.Add(this.label6);
            this.panelPlaceInfo.Controls.Add(this.btnSchedule);
            this.panelPlaceInfo.Controls.Add(this.btnBookNow);
            this.panelPlaceInfo.Controls.Add(this.label5);
            this.panelPlaceInfo.Controls.Add(this.label4);
            this.panelPlaceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlaceInfo.Location = new System.Drawing.Point(3, 195);
            this.panelPlaceInfo.Name = "panelPlaceInfo";
            this.TableInformation.SetRowSpan(this.panelPlaceInfo, 2);
            this.panelPlaceInfo.Size = new System.Drawing.Size(474, 186);
            this.panelPlaceInfo.TabIndex = 1;
            // 
            // tdComboBox1
            // 
            this.tdComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tdComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tdComboBox1.BorderSize = 1;
            this.tdComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.tdComboBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.tdComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.tdComboBox1.Items.AddRange(new object[] {
            "Angels to May Pen (via Kingston)",
            "Angels(Spanish Town) to Falmouth",
            "Annotto Bay to Kingston (via Ocho Rios)",
            "Annotto Bay to Montego Bay(MBJ Airport)",
            "Annotto Bay to Port Maria",
            "Falmouth to Kingston",
            "Falmouth to Montego Bay(MBJ Airport)",
            "Kingston to Montego Bay(MBJ Airport)",
            "Kingston to Negril",
            "Kingston to Ocho Rios (Drax Hall)",
            "Lucea to Negril",
            "Montego Bay(MBJ Airport) to New Kingston"});
            this.tdComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.tdComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.tdComboBox1.Location = new System.Drawing.Point(40, 182);
            this.tdComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.tdComboBox1.Name = "tdComboBox1";
            this.tdComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.tdComboBox1.Size = new System.Drawing.Size(384, 30);
            this.tdComboBox1.TabIndex = 15;
            this.tdComboBox1.Texts = "Select Desired Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "The Available Locations:";
            // 
            // optSenior
            // 
            this.optSenior.AutoSize = true;
            this.optSenior.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.optSenior.Location = new System.Drawing.Point(83, 284);
            this.optSenior.MinimumSize = new System.Drawing.Size(0, 21);
            this.optSenior.Name = "optSenior";
            this.optSenior.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.optSenior.Size = new System.Drawing.Size(133, 26);
            this.optSenior.TabIndex = 0;
            this.optSenior.TabStop = true;
            this.optSenior.Text = "Senior: $750+";
            this.optSenior.UnCheckedColor = System.Drawing.Color.Gray;
            this.optSenior.UseVisualStyleBackColor = true;
            // 
            // optStudent
            // 
            this.optStudent.AutoSize = true;
            this.optStudent.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.optStudent.Location = new System.Drawing.Point(243, 284);
            this.optStudent.MinimumSize = new System.Drawing.Size(0, 21);
            this.optStudent.Name = "optStudent";
            this.optStudent.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.optStudent.Size = new System.Drawing.Size(144, 26);
            this.optStudent.TabIndex = 0;
            this.optStudent.TabStop = true;
            this.optStudent.Text = "Student: $700+";
            this.optStudent.UnCheckedColor = System.Drawing.Color.Gray;
            this.optStudent.UseVisualStyleBackColor = true;
            // 
            // optChild
            // 
            this.optChild.AutoSize = true;
            this.optChild.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.optChild.Location = new System.Drawing.Point(312, 252);
            this.optChild.MinimumSize = new System.Drawing.Size(0, 21);
            this.optChild.Name = "optChild";
            this.optChild.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.optChild.Size = new System.Drawing.Size(123, 26);
            this.optChild.TabIndex = 0;
            this.optChild.TabStop = true;
            this.optChild.Text = "Child: $650+";
            this.optChild.UnCheckedColor = System.Drawing.Color.Gray;
            this.optChild.UseVisualStyleBackColor = true;
            // 
            // optAdult
            // 
            this.optAdult.AutoSize = true;
            this.optAdult.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.optAdult.Location = new System.Drawing.Point(165, 252);
            this.optAdult.MinimumSize = new System.Drawing.Size(0, 21);
            this.optAdult.Name = "optAdult";
            this.optAdult.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.optAdult.Size = new System.Drawing.Size(126, 26);
            this.optAdult.TabIndex = 0;
            this.optAdult.TabStop = true;
            this.optAdult.Text = "Adult: $900+";
            this.optAdult.UnCheckedColor = System.Drawing.Color.Gray;
            this.optAdult.UseVisualStyleBackColor = true;
            // 
            // optEarly
            // 
            this.optEarly.AutoSize = true;
            this.optEarly.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.optEarly.Location = new System.Drawing.Point(20, 252);
            this.optEarly.MinimumSize = new System.Drawing.Size(0, 21);
            this.optEarly.Name = "optEarly";
            this.optEarly.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.optEarly.Size = new System.Drawing.Size(125, 26);
            this.optEarly.TabIndex = 0;
            this.optEarly.TabStop = true;
            this.optEarly.Text = "Early: $900+";
            this.optEarly.UnCheckedColor = System.Drawing.Color.Gray;
            this.optEarly.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Price Range: ";
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSchedule.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSchedule.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSchedule.BorderRadius = 40;
            this.btnSchedule.BorderSize = 0;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Location = new System.Drawing.Point(60, 327);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(150, 40);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.Text = "See Schedule";
            this.btnSchedule.TextColor = System.Drawing.Color.White;
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnBookNow
            // 
            this.btnBookNow.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBookNow.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBookNow.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBookNow.BorderRadius = 40;
            this.btnBookNow.BorderSize = 0;
            this.btnBookNow.FlatAppearance.BorderSize = 0;
            this.btnBookNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookNow.ForeColor = System.Drawing.Color.White;
            this.btnBookNow.Location = new System.Drawing.Point(227, 327);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(150, 40);
            this.btnBookNow.TabIndex = 0;
            this.btnBookNow.Text = "Book Now";
            this.btnBookNow.TextColor = System.Drawing.Color.White;
            this.btnBookNow.UseVisualStyleBackColor = false;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(435, 95);
            this.label5.TabIndex = 2;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "Knutsford Express";
            // 
            // panelPicture2
            // 
            this.panelPicture2.BackgroundImage = global::TheCaribbeanTravelGem.Properties.Resources.knutsford_bus;
            this.panelPicture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPicture2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPicture2.Location = new System.Drawing.Point(483, 195);
            this.panelPicture2.Name = "panelPicture2";
            this.panelPicture2.Size = new System.Drawing.Size(154, 90);
            this.panelPicture2.TabIndex = 2;
            // 
            // panelPicture3
            // 
            this.panelPicture3.BackgroundImage = global::TheCaribbeanTravelGem.Properties.Resources.knutsfordexpressochorios;
            this.panelPicture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPicture3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPicture3.Location = new System.Drawing.Point(643, 195);
            this.panelPicture3.Name = "panelPicture3";
            this.panelPicture3.Size = new System.Drawing.Size(154, 90);
            this.panelPicture3.TabIndex = 3;
            // 
            // panelPicture4
            // 
            this.panelPicture4.BackgroundImage = global::TheCaribbeanTravelGem.Properties.Resources.knutsfordcharters;
            this.panelPicture4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPicture4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPicture4.Location = new System.Drawing.Point(483, 291);
            this.panelPicture4.Name = "panelPicture4";
            this.panelPicture4.Size = new System.Drawing.Size(154, 90);
            this.panelPicture4.TabIndex = 4;
            // 
            // panelPicture5
            // 
            this.panelPicture5.BackgroundImage = global::TheCaribbeanTravelGem.Properties.Resources.courier_web_advt_610_354;
            this.panelPicture5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPicture5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPicture5.Location = new System.Drawing.Point(643, 291);
            this.panelPicture5.Name = "panelPicture5";
            this.panelPicture5.Size = new System.Drawing.Size(154, 90);
            this.panelPicture5.TabIndex = 5;
            // 
            // panelGoogleMap
            // 
            this.TableInformation.SetColumnSpan(this.panelGoogleMap, 3);
            this.panelGoogleMap.Controls.Add(this.wbrKnutsford);
            this.panelGoogleMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGoogleMap.Location = new System.Drawing.Point(3, 387);
            this.panelGoogleMap.Name = "panelGoogleMap";
            this.panelGoogleMap.Size = new System.Drawing.Size(794, 186);
            this.panelGoogleMap.TabIndex = 6;
            // 
            // wbrKnutsford
            // 
            this.wbrKnutsford.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbrKnutsford.Location = new System.Drawing.Point(0, 0);
            this.wbrKnutsford.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrKnutsford.Name = "wbrKnutsford";
            this.wbrKnutsford.Size = new System.Drawing.Size(794, 186);
            this.wbrKnutsford.TabIndex = 0;
            this.wbrKnutsford.Url = new System.Uri("https://goo.gl/maps/3P3pyimT263onuSo8", System.UriKind.Absolute);
            this.wbrKnutsford.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // panelContactInfo
            // 
            this.TableInformation.SetColumnSpan(this.panelContactInfo, 3);
            this.panelContactInfo.Controls.Add(this.lblCompanyNumbers);
            this.panelContactInfo.Controls.Add(this.lblCompanyEmail);
            this.panelContactInfo.Controls.Add(this.lblCompanyAddress);
            this.panelContactInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContactInfo.Location = new System.Drawing.Point(3, 579);
            this.panelContactInfo.Name = "panelContactInfo";
            this.panelContactInfo.Size = new System.Drawing.Size(794, 93);
            this.panelContactInfo.TabIndex = 7;
            // 
            // lblCompanyNumbers
            // 
            this.lblCompanyNumbers.AutoSize = true;
            this.lblCompanyNumbers.Location = new System.Drawing.Point(332, 1);
            this.lblCompanyNumbers.Name = "lblCompanyNumbers";
            this.lblCompanyNumbers.Size = new System.Drawing.Size(187, 90);
            this.lblCompanyNumbers.TabIndex = 5;
            this.lblCompanyNumbers.Text = "Contact number:\r\n1-876-940-0064\r\n\r\nBookings Contact numbers:\r\n1-876-971-1822\r\n";
            // 
            // lblCompanyEmail
            // 
            this.lblCompanyEmail.AutoSize = true;
            this.lblCompanyEmail.Location = new System.Drawing.Point(573, 1);
            this.lblCompanyEmail.Name = "lblCompanyEmail";
            this.lblCompanyEmail.Size = new System.Drawing.Size(201, 90);
            this.lblCompanyEmail.TabIndex = 4;
            this.lblCompanyEmail.Text = "Email:\r\ninfo(at)knutsfordexpress.com\r\n\r\nCareers:\r\nhr(at)knutsfordexpress.com";
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Location = new System.Drawing.Point(20, 1);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(173, 90);
            this.lblCompanyAddress.TabIndex = 3;
            this.lblCompanyAddress.Text = "Corporate Office:\r\n1310 Providence drive\r\nIronshore Montego Bay, \r\nJamaica W.I.\r\n" +
    "\r\n";
            // 
            // FrmKnutsfordExpress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.TableInformation);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FrmKnutsfordExpress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knutsford Express";
            this.TableInformation.ResumeLayout(false);
            this.panelPicture1.ResumeLayout(false);
            this.panelPlaceInfo.ResumeLayout(false);
            this.panelPlaceInfo.PerformLayout();
            this.panelGoogleMap.ResumeLayout(false);
            this.panelContactInfo.ResumeLayout(false);
            this.panelContactInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableInformation;
        private System.Windows.Forms.Panel panelPicture1;
        private System.Windows.Forms.Panel panelPlaceInfo;
        private System.Windows.Forms.Panel panelPicture2;
        private System.Windows.Forms.Panel panelPicture3;
        private System.Windows.Forms.Panel panelPicture4;
        private System.Windows.Forms.Panel panelPicture5;
        private System.Windows.Forms.Panel panelGoogleMap;
        private System.Windows.Forms.Panel panelContactInfo;
        private CustomControls.TDControls.TDButton btnBookNow;
        private CustomControl.TDControls.TDRadioButton optAdult;
        private CustomControl.TDControls.TDRadioButton optEarly;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCompanyNumbers;
        private System.Windows.Forms.Label lblCompanyEmail;
        private System.Windows.Forms.Label lblCompanyAddress;
        private CustomControls.TDControls.TDButton btnSchedule;
        private CustomControl.TDControls.TDRadioButton optSenior;
        private CustomControl.TDControls.TDRadioButton optStudent;
        private CustomControl.TDControls.TDRadioButton optChild;
        private CustomControl.TDControls.TDComboBox tdComboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.WebBrowser wbrKnutsford;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
    }
}