namespace TheCaribbeanTravelGem
{
    partial class FrmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.panelHome = new System.Windows.Forms.Panel();
            this.tgridHome = new System.Windows.Forms.TableLayoutPanel();
            this.panelSlider = new System.Windows.Forms.Panel();
            this.pbxSlider = new System.Windows.Forms.PictureBox();
            this.panelHomeInfo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSignUp = new CustomControls.TDControls.TDButton();
            this.btnLogin = new CustomControls.TDControls.TDButton();
            this.timerSlider = new System.Windows.Forms.Timer(this.components);
            this.panelHome.SuspendLayout();
            this.tgridHome.SuspendLayout();
            this.panelSlider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlider)).BeginInit();
            this.panelHomeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackgroundImage = global::TheCaribbeanTravelGem.Properties.Resources.cedric_frixon_Me7ySkVmWcw_unsplash__1_;
            this.panelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHome.Controls.Add(this.tgridHome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(800, 675);
            this.panelHome.TabIndex = 0;
            // 
            // tgridHome
            // 
            this.tgridHome.BackColor = System.Drawing.Color.Transparent;
            this.tgridHome.ColumnCount = 5;
            this.tgridHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tgridHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tgridHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tgridHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tgridHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tgridHome.Controls.Add(this.panelSlider, 0, 0);
            this.tgridHome.Controls.Add(this.panelHomeInfo, 3, 0);
            this.tgridHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgridHome.Location = new System.Drawing.Point(0, 0);
            this.tgridHome.Name = "tgridHome";
            this.tgridHome.RowCount = 3;
            this.tgridHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tgridHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tgridHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tgridHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tgridHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tgridHome.Size = new System.Drawing.Size(800, 675);
            this.tgridHome.TabIndex = 2;
            // 
            // panelSlider
            // 
            this.panelSlider.BackColor = System.Drawing.SystemColors.Control;
            this.tgridHome.SetColumnSpan(this.panelSlider, 3);
            this.panelSlider.Controls.Add(this.pbxSlider);
            this.panelSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSlider.Location = new System.Drawing.Point(3, 3);
            this.panelSlider.Name = "panelSlider";
            this.tgridHome.SetRowSpan(this.panelSlider, 3);
            this.panelSlider.Size = new System.Drawing.Size(511, 669);
            this.panelSlider.TabIndex = 0;
            // 
            // pbxSlider
            // 
            this.pbxSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxSlider.Image = global::TheCaribbeanTravelGem.Properties.Resources.to_add_to_home_page_a_bamboo_raft_on_the_rio_grande_river;
            this.pbxSlider.Location = new System.Drawing.Point(0, 0);
            this.pbxSlider.Name = "pbxSlider";
            this.pbxSlider.Size = new System.Drawing.Size(511, 669);
            this.pbxSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSlider.TabIndex = 0;
            this.pbxSlider.TabStop = false;
            // 
            // panelHomeInfo
            // 
            this.panelHomeInfo.BackColor = System.Drawing.Color.Black;
            this.tgridHome.SetColumnSpan(this.panelHomeInfo, 2);
            this.panelHomeInfo.Controls.Add(this.label2);
            this.panelHomeInfo.Controls.Add(this.lblTagline);
            this.panelHomeInfo.Controls.Add(this.lblWelcome);
            this.panelHomeInfo.Controls.Add(this.btnSignUp);
            this.panelHomeInfo.Controls.Add(this.btnLogin);
            this.panelHomeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHomeInfo.Location = new System.Drawing.Point(520, 3);
            this.panelHomeInfo.Name = "panelHomeInfo";
            this.tgridHome.SetRowSpan(this.panelHomeInfo, 3);
            this.panelHomeInfo.Size = new System.Drawing.Size(277, 669);
            this.panelHomeInfo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 203);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(546, 236);
            this.label2.TabIndex = 15;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // lblTagline
            // 
            this.lblTagline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTagline.AutoSize = true;
            this.lblTagline.BackColor = System.Drawing.Color.Transparent;
            this.lblTagline.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagline.ForeColor = System.Drawing.Color.White;
            this.lblTagline.Location = new System.Drawing.Point(1, 151);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.lblTagline.Size = new System.Drawing.Size(361, 43);
            this.lblTagline.TabIndex = 14;
            this.lblTagline.Text = "Tagline: Beauty, Charm And Adventure";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcome.Font = new System.Drawing.Font("Cream Cake", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(-7, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.lblWelcome.Size = new System.Drawing.Size(294, 133);
            this.lblWelcome.TabIndex = 13;
            this.lblWelcome.Text = "Welcome to The Caribbean Travel Gem";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignUp.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSignUp.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSignUp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignUp.BorderRadius = 40;
            this.btnSignUp.BorderSize = 0;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(73, 487);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(150, 45);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.TextColor = System.Drawing.Color.White;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 40;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(73, 436);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 45);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // timerSlider
            // 
            this.timerSlider.Enabled = true;
            this.timerSlider.Interval = 2000;
            this.timerSlider.Tick += new System.EventHandler(this.timerSlider_Tick);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.panelHome);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHome";
            this.panelHome.ResumeLayout(false);
            this.tgridHome.ResumeLayout(false);
            this.panelSlider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlider)).EndInit();
            this.panelHomeInfo.ResumeLayout(false);
            this.panelHomeInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.TableLayoutPanel tgridHome;
        private System.Windows.Forms.Panel panelSlider;
        private System.Windows.Forms.PictureBox pbxSlider;
        private System.Windows.Forms.Panel panelHomeInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Timer timerSlider;
        private CustomControls.TDControls.TDButton btnSignUp;
        private CustomControls.TDControls.TDButton btnLogin;
    }
}