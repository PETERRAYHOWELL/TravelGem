namespace TheCaribbeanTravelGem
{
    partial class MdiMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiMain));
            this.panelRibbon = new System.Windows.Forms.Panel();
            this.lblCompany = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.PullDownColours = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRibbon.SuspendLayout();
            this.PullDownColours.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRibbon
            // 
            this.panelRibbon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(64)))), ((int)(((byte)(99)))));
            this.panelRibbon.Controls.Add(this.lblCompany);
            this.panelRibbon.Controls.Add(this.btnClose);
            this.panelRibbon.Controls.Add(this.btnMaximize);
            this.panelRibbon.Controls.Add(this.btnMinimize);
            this.panelRibbon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRibbon.Location = new System.Drawing.Point(0, 0);
            this.panelRibbon.Name = "panelRibbon";
            this.panelRibbon.Size = new System.Drawing.Size(964, 40);
            this.panelRibbon.TabIndex = 7;
            this.panelRibbon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRibbon_MouseDown);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompany.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.ForeColor = System.Drawing.Color.White;
            this.lblCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCompany.Location = new System.Drawing.Point(0, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Padding = new System.Windows.Forms.Padding(10);
            this.lblCompany.Size = new System.Drawing.Size(253, 41);
            this.lblCompany.TabIndex = 13;
            this.lblCompany.Text = "The Caribbean Travel Gem";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TheCaribbeanTravelGem.Properties.Resources.icons8_close_18;
            this.btnClose.Location = new System.Drawing.Point(934, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::TheCaribbeanTravelGem.Properties.Resources.icons8_maximize_window_18;
            this.btnMaximize.Location = new System.Drawing.Point(910, 6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(18, 18);
            this.btnMaximize.TabIndex = 11;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::TheCaribbeanTravelGem.Properties.Resources.icons8_subtract_18;
            this.btnMinimize.Location = new System.Drawing.Point(886, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(18, 18);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // PullDownColours
            // 
            this.PullDownColours.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PullDownColours.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.purpleToolStripMenuItem,
            this.greenToolStripMenuItem});
            this.PullDownColours.Name = "PullDownColours";
            this.PullDownColours.Size = new System.Drawing.Size(121, 76);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.redToolStripMenuItem.Text = "Blue";
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.purpleToolStripMenuItem.Text = "Purple";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.greenToolStripMenuItem.Text = "Green";
            // 
            // MdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 706);
            this.Controls.Add(this.panelRibbon);
            this.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "MdiMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Caribbean Travel Gem";
            this.Load += new System.EventHandler(this.MdiMain_Load);
            this.panelRibbon.ResumeLayout(false);
            this.panelRibbon.PerformLayout();
            this.PullDownColours.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRibbon;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.ContextMenuStrip PullDownColours;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
    }
}