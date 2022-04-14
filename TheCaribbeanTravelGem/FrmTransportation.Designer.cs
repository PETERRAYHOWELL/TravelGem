namespace TheCaribbeanTravelGem
{
    partial class FrmTransportation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransportation));
            this.timerSlider = new System.Windows.Forms.Timer(this.components);
            this.panelTransportation = new System.Windows.Forms.Panel();
            this.tgridTransportation = new System.Windows.Forms.TableLayoutPanel();
            this.panelSlider = new System.Windows.Forms.Panel();
            this.pbxSlider = new System.Windows.Forms.PictureBox();
            this.panelTranportInfo = new System.Windows.Forms.Panel();
            this.tgridInfo = new System.Windows.Forms.TableLayoutPanel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnListing = new CustomControls.TDControls.TDButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelTransportation.SuspendLayout();
            this.tgridTransportation.SuspendLayout();
            this.panelSlider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlider)).BeginInit();
            this.panelTranportInfo.SuspendLayout();
            this.tgridInfo.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerSlider
            // 
            this.timerSlider.Enabled = true;
            this.timerSlider.Interval = 2000;
            this.timerSlider.Tick += new System.EventHandler(this.timerSlider_Tick);
            // 
            // panelTransportation
            // 
            this.panelTransportation.BackgroundImage = global::TheCaribbeanTravelGem.Properties.Resources.pexels_photo_37035111;
            this.panelTransportation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTransportation.Controls.Add(this.tgridTransportation);
            this.panelTransportation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTransportation.Location = new System.Drawing.Point(0, 0);
            this.panelTransportation.Name = "panelTransportation";
            this.panelTransportation.Size = new System.Drawing.Size(800, 600);
            this.panelTransportation.TabIndex = 0;
            // 
            // tgridTransportation
            // 
            this.tgridTransportation.BackColor = System.Drawing.Color.Transparent;
            this.tgridTransportation.ColumnCount = 6;
            this.tgridTransportation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tgridTransportation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tgridTransportation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tgridTransportation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tgridTransportation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tgridTransportation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tgridTransportation.Controls.Add(this.panelSlider, 0, 0);
            this.tgridTransportation.Controls.Add(this.panelTranportInfo, 3, 0);
            this.tgridTransportation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgridTransportation.Location = new System.Drawing.Point(0, 0);
            this.tgridTransportation.Name = "tgridTransportation";
            this.tgridTransportation.RowCount = 5;
            this.tgridTransportation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tgridTransportation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tgridTransportation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tgridTransportation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 460F));
            this.tgridTransportation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tgridTransportation.Size = new System.Drawing.Size(800, 600);
            this.tgridTransportation.TabIndex = 1;
            // 
            // panelSlider
            // 
            this.panelSlider.BackColor = System.Drawing.Color.White;
            this.tgridTransportation.SetColumnSpan(this.panelSlider, 3);
            this.panelSlider.Controls.Add(this.pbxSlider);
            this.panelSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSlider.Location = new System.Drawing.Point(3, 3);
            this.panelSlider.MinimumSize = new System.Drawing.Size(480, 594);
            this.panelSlider.Name = "panelSlider";
            this.tgridTransportation.SetRowSpan(this.panelSlider, 5);
            this.panelSlider.Size = new System.Drawing.Size(480, 594);
            this.panelSlider.TabIndex = 0;
            // 
            // pbxSlider
            // 
            this.pbxSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxSlider.Image = global::TheCaribbeanTravelGem.Properties.Resources.beach_holiday_vacation_caribbean;
            this.pbxSlider.Location = new System.Drawing.Point(0, 0);
            this.pbxSlider.Name = "pbxSlider";
            this.pbxSlider.Size = new System.Drawing.Size(480, 594);
            this.pbxSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSlider.TabIndex = 0;
            this.pbxSlider.TabStop = false;
            // 
            // panelTranportInfo
            // 
            this.panelTranportInfo.BackColor = System.Drawing.Color.Black;
            this.tgridTransportation.SetColumnSpan(this.panelTranportInfo, 3);
            this.panelTranportInfo.Controls.Add(this.tgridInfo);
            this.panelTranportInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTranportInfo.Location = new System.Drawing.Point(483, 3);
            this.panelTranportInfo.Name = "panelTranportInfo";
            this.tgridTransportation.SetRowSpan(this.panelTranportInfo, 5);
            this.panelTranportInfo.Size = new System.Drawing.Size(314, 594);
            this.panelTranportInfo.TabIndex = 1;
            // 
            // tgridInfo
            // 
            this.tgridInfo.ColumnCount = 3;
            this.tgridInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tgridInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tgridInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tgridInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tgridInfo.Controls.Add(this.panelInfo, 1, 5);
            this.tgridInfo.Controls.Add(this.btnListing, 1, 7);
            this.tgridInfo.Controls.Add(this.panelTitle, 0, 2);
            this.tgridInfo.Controls.Add(this.btnForward, 2, 1);
            this.tgridInfo.Controls.Add(this.btnBack, 1, 1);
            this.tgridInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgridInfo.Location = new System.Drawing.Point(0, 0);
            this.tgridInfo.Name = "tgridInfo";
            this.tgridInfo.RowCount = 9;
            this.tgridInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tgridInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tgridInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tgridInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tgridInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tgridInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 410F));
            this.tgridInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tgridInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tgridInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tgridInfo.Size = new System.Drawing.Size(314, 594);
            this.tgridInfo.TabIndex = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.AutoScroll = true;
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.Controls.Add(this.lblInfo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(34, 123);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(245, 404);
            this.panelInfo.TabIndex = 18;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(3, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.lblInfo.Size = new System.Drawing.Size(256, 1388);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // btnListing
            // 
            this.btnListing.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnListing.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnListing.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnListing.BorderRadius = 4;
            this.btnListing.BorderSize = 0;
            this.btnListing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListing.FlatAppearance.BorderSize = 0;
            this.btnListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListing.ForeColor = System.Drawing.Color.White;
            this.btnListing.Image = global::TheCaribbeanTravelGem.Properties.Resources.icons8_forward_24;
            this.btnListing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListing.Location = new System.Drawing.Point(34, 543);
            this.btnListing.Name = "btnListing";
            this.btnListing.Size = new System.Drawing.Size(245, 34);
            this.btnListing.TabIndex = 5;
            this.btnListing.Text = "See Listing";
            this.btnListing.TextColor = System.Drawing.Color.White;
            this.btnListing.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnListing.UseVisualStyleBackColor = false;
            this.btnListing.Click += new System.EventHandler(this.btnListing_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Transparent;
            this.tgridInfo.SetColumnSpan(this.panelTitle, 4);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle.Location = new System.Drawing.Point(3, 43);
            this.panelTitle.Name = "panelTitle";
            this.tgridInfo.SetRowSpan(this.panelTitle, 2);
            this.panelTitle.Size = new System.Drawing.Size(308, 64);
            this.panelTitle.TabIndex = 19;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10);
            this.lblTitle.Size = new System.Drawing.Size(361, 76);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome To Our \r\nCollection Of Transportation";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.Location = new System.Drawing.Point(285, 13);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(24, 24);
            this.btnForward.TabIndex = 21;
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::TheCaribbeanTravelGem.Properties.Resources.icons8_back_30;
            this.btnBack.Location = new System.Drawing.Point(255, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 24);
            this.btnBack.TabIndex = 20;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmTransportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelTransportation);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FrmTransportation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transportation ";
            this.panelTransportation.ResumeLayout(false);
            this.tgridTransportation.ResumeLayout(false);
            this.panelSlider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlider)).EndInit();
            this.panelTranportInfo.ResumeLayout(false);
            this.tgridInfo.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTransportation;
        private System.Windows.Forms.Timer timerSlider;
        private System.Windows.Forms.TableLayoutPanel tgridTransportation;
        private System.Windows.Forms.Panel panelSlider;
        private System.Windows.Forms.PictureBox pbxSlider;
        private System.Windows.Forms.Panel panelTranportInfo;
        private System.Windows.Forms.TableLayoutPanel tgridInfo;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblInfo;
        private CustomControls.TDControls.TDButton btnListing;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
    }
}