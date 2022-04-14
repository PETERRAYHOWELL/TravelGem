namespace TheCaribbeanTravelGem
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.tgridLogin = new System.Windows.Forms.TableLayoutPanel();
            this.panelLoginForm = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.btnLogin = new CustomControls.TDControls.TDButton();
            this.txtPassword = new CustomControls.TDControls.TDTextBox();
            this.txtUsername = new CustomControls.TDControls.TDTextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.tgridLogin.SuspendLayout();
            this.panelLoginForm.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.AutoSize = true;
            this.panelLogin.BackgroundImage = global::TheCaribbeanTravelGem.Properties.Resources.pexels_asad_photo_maldives_3155666;
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogin.Controls.Add(this.tgridLogin);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(800, 600);
            this.panelLogin.TabIndex = 0;
            // 
            // tgridLogin
            // 
            this.tgridLogin.BackColor = System.Drawing.Color.Transparent;
            this.tgridLogin.ColumnCount = 3;
            this.tgridLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tgridLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tgridLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tgridLogin.Controls.Add(this.panelLoginForm, 1, 2);
            this.tgridLogin.Controls.Add(this.btnClose, 2, 0);
            this.tgridLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgridLogin.Location = new System.Drawing.Point(0, 0);
            this.tgridLogin.Name = "tgridLogin";
            this.tgridLogin.RowCount = 4;
            this.tgridLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tgridLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tgridLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tgridLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tgridLogin.Size = new System.Drawing.Size(800, 600);
            this.tgridLogin.TabIndex = 0;
            // 
            // panelLoginForm
            // 
            this.panelLoginForm.BackColor = System.Drawing.Color.White;
            this.panelLoginForm.Controls.Add(this.panelInfo);
            this.panelLoginForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginForm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLoginForm.Location = new System.Drawing.Point(93, 123);
            this.panelLoginForm.MinimumSize = new System.Drawing.Size(450, 300);
            this.panelLoginForm.Name = "panelLoginForm";
            this.panelLoginForm.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelLoginForm.Size = new System.Drawing.Size(494, 394);
            this.panelLoginForm.TabIndex = 6;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.lblSignUp);
            this.panelInfo.Controls.Add(this.lblCancel);
            this.panelInfo.Controls.Add(this.btnLogin);
            this.panelInfo.Controls.Add(this.txtPassword);
            this.panelInfo.Controls.Add(this.txtUsername);
            this.panelInfo.Controls.Add(this.lblWelcome);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(494, 384);
            this.panelInfo.TabIndex = 0;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.DimGray;
            this.lblSignUp.Location = new System.Drawing.Point(145, 318);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(157, 18);
            this.lblSignUp.TabIndex = 17;
            this.lblSignUp.Text = "Dont Have An Account";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.DimGray;
            this.lblCancel.Location = new System.Drawing.Point(210, 350);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(50, 18);
            this.lblCancel.TabIndex = 16;
            this.lblCancel.Text = "Cancel";
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 40;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(168, 257);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.Enter += new System.EventHandler(this.btnLogin_Enter);
            this.btnLogin.Leave += new System.EventHandler(this.btnLogin_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtPassword.BorderRadius = 0;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(76, 198);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.MinimumSize = new System.Drawing.Size(250, 40);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(350, 40);
            this.txtPassword.TabIndex = 13;
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
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(76, 131);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.MinimumSize = new System.Drawing.Size(250, 40);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(350, 40);
            this.txtUsername.TabIndex = 14;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcome.Font = new System.Drawing.Font("Cream Cake", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(46, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(10);
            this.lblWelcome.Size = new System.Drawing.Size(408, 118);
            this.lblWelcome.TabIndex = 12;
            this.lblWelcome.Text = "Welcome to The Caribbean Travel Gem";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnClose.Size = new System.Drawing.Size(30, 34);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FrmLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.tgridLogin.ResumeLayout(false);
            this.panelLoginForm.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TableLayoutPanel tgridLogin;
        private System.Windows.Forms.Panel panelLoginForm;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblCancel;
        private CustomControls.TDControls.TDButton btnLogin;
        private CustomControls.TDControls.TDTextBox txtPassword;
        private CustomControls.TDControls.TDTextBox txtUsername;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnClose;
    }
}

