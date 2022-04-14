namespace TheCaribbeanTravelGem
{
    partial class FrmQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuestion));
            this.tgridAskQuestion = new System.Windows.Forms.TableLayoutPanel();
            this.panelAskQuestion = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbxAskQuestion = new System.Windows.Forms.PictureBox();
            this.lblAskAQuestion = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtName = new CustomControls.TDControls.TDTextBox();
            this.txtEmail = new CustomControls.TDControls.TDTextBox();
            this.txtQuestion = new CustomControls.TDControls.TDTextBox();
            this.cbxTopic = new CustomControl.TDControls.TDComboBox();
            this.btnSubmit = new CustomControls.TDControls.TDButton();
            this.tgridAskQuestion.SuspendLayout();
            this.panelAskQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAskQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // tgridAskQuestion
            // 
            this.tgridAskQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.tgridAskQuestion.ColumnCount = 3;
            this.tgridAskQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tgridAskQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tgridAskQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tgridAskQuestion.Controls.Add(this.panelAskQuestion, 0, 0);
            this.tgridAskQuestion.Controls.Add(this.lblInfo, 1, 3);
            this.tgridAskQuestion.Controls.Add(this.txtName, 1, 5);
            this.tgridAskQuestion.Controls.Add(this.txtEmail, 1, 7);
            this.tgridAskQuestion.Controls.Add(this.txtQuestion, 1, 11);
            this.tgridAskQuestion.Controls.Add(this.cbxTopic, 1, 9);
            this.tgridAskQuestion.Controls.Add(this.btnSubmit, 1, 13);
            this.tgridAskQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgridAskQuestion.Location = new System.Drawing.Point(10, 10);
            this.tgridAskQuestion.Name = "tgridAskQuestion";
            this.tgridAskQuestion.RowCount = 15;
            this.tgridAskQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.265723F));
            this.tgridAskQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.64847F));
            this.tgridAskQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tgridAskQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.32861F));
            this.tgridAskQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tgridAskQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.32861F));
            this.tgridAskQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tgridAskQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.32861F));
            this.tgridAskQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tgridAskQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.32861F));
            this.tgridAskQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tgridAskQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.17331F));
            this.tgridAskQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tgridAskQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.33235F));
            this.tgridAskQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.265722F));
            this.tgridAskQuestion.Size = new System.Drawing.Size(330, 430);
            this.tgridAskQuestion.TabIndex = 0;
            // 
            // panelAskQuestion
            // 
            this.panelAskQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(9)))), ((int)(((byte)(52)))));
            this.tgridAskQuestion.SetColumnSpan(this.panelAskQuestion, 3);
            this.panelAskQuestion.Controls.Add(this.btnClose);
            this.panelAskQuestion.Controls.Add(this.pbxAskQuestion);
            this.panelAskQuestion.Controls.Add(this.lblAskAQuestion);
            this.panelAskQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAskQuestion.Location = new System.Drawing.Point(3, 3);
            this.panelAskQuestion.Name = "panelAskQuestion";
            this.tgridAskQuestion.SetRowSpan(this.panelAskQuestion, 2);
            this.panelAskQuestion.Size = new System.Drawing.Size(324, 89);
            this.panelAskQuestion.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TheCaribbeanTravelGem.Properties.Resources.icons8_close_15;
            this.btnClose.Location = new System.Drawing.Point(291, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbxAskQuestion
            // 
            this.pbxAskQuestion.Image = global::TheCaribbeanTravelGem.Properties.Resources.icons8_ask_question_501;
            this.pbxAskQuestion.Location = new System.Drawing.Point(108, 3);
            this.pbxAskQuestion.Name = "pbxAskQuestion";
            this.pbxAskQuestion.Size = new System.Drawing.Size(100, 50);
            this.pbxAskQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxAskQuestion.TabIndex = 1;
            this.pbxAskQuestion.TabStop = false;
            // 
            // lblAskAQuestion
            // 
            this.lblAskAQuestion.AutoSize = true;
            this.lblAskAQuestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAskAQuestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskAQuestion.ForeColor = System.Drawing.Color.White;
            this.lblAskAQuestion.Location = new System.Drawing.Point(0, 45);
            this.lblAskAQuestion.Name = "lblAskAQuestion";
            this.lblAskAQuestion.Padding = new System.Windows.Forms.Padding(70, 10, 70, 10);
            this.lblAskAQuestion.Size = new System.Drawing.Size(324, 44);
            this.lblAskAQuestion.TabIndex = 0;
            this.lblAskAQuestion.Text = "ASK A QUESTION";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(52, 105);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(225, 41);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Please enter valid data. We will answer your questions as soon as possible";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(21)))), ((int)(((byte)(126)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(52, 160);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "Name";
            this.txtName.Size = new System.Drawing.Size(225, 32);
            this.txtName.TabIndex = 2;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(21)))), ((int)(((byte)(126)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtEmail.BorderRadius = 0;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(52, 211);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(225, 32);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuestion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(21)))), ((int)(((byte)(126)))));
            this.txtQuestion.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtQuestion.BorderRadius = 0;
            this.txtQuestion.BorderSize = 2;
            this.txtQuestion.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.ForeColor = System.Drawing.Color.Black;
            this.txtQuestion.Location = new System.Drawing.Point(52, 313);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQuestion.PasswordChar = false;
            this.txtQuestion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQuestion.PlaceholderText = "Question";
            this.txtQuestion.Size = new System.Drawing.Size(225, 48);
            this.txtQuestion.TabIndex = 4;
            this.txtQuestion.Texts = "";
            this.txtQuestion.UnderlinedStyle = false;
            // 
            // cbxTopic
            // 
            this.cbxTopic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxTopic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(21)))), ((int)(((byte)(126)))));
            this.cbxTopic.BorderSize = 1;
            this.cbxTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxTopic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxTopic.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTopic.ForeColor = System.Drawing.Color.Black;
            this.cbxTopic.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(21)))), ((int)(((byte)(126)))));
            this.cbxTopic.Items.AddRange(new object[] {
            "Transportation",
            "Accomondation",
            "Gasteromony",
            "Attractions",
            "Events",
            "Others"});
            this.cbxTopic.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxTopic.ListTextColor = System.Drawing.Color.Black;
            this.cbxTopic.Location = new System.Drawing.Point(52, 261);
            this.cbxTopic.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxTopic.Name = "cbxTopic";
            this.cbxTopic.Padding = new System.Windows.Forms.Padding(1);
            this.cbxTopic.Size = new System.Drawing.Size(225, 35);
            this.cbxTopic.TabIndex = 6;
            this.cbxTopic.Texts = "Select Topic";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(21)))), ((int)(((byte)(126)))));
            this.btnSubmit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(21)))), ((int)(((byte)(126)))));
            this.btnSubmit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSubmit.BorderRadius = 30;
            this.btnSubmit.BorderSize = 0;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(89, 378);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 35);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextColor = System.Drawing.Color.White;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.Enter += new System.EventHandler(this.btnSubmit_Enter);
            this.btnSubmit.Leave += new System.EventHandler(this.btnSubmit_Leave);
            // 
            // FrmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.tgridAskQuestion);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(200, 450);
            this.Name = "FrmQuestion";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question";
            this.TopMost = true;
            this.tgridAskQuestion.ResumeLayout(false);
            this.tgridAskQuestion.PerformLayout();
            this.panelAskQuestion.ResumeLayout(false);
            this.panelAskQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAskQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tgridAskQuestion;
        private System.Windows.Forms.Panel panelAskQuestion;
        private System.Windows.Forms.PictureBox pbxAskQuestion;
        private System.Windows.Forms.Label lblAskAQuestion;
        private System.Windows.Forms.Label lblInfo;
        private CustomControls.TDControls.TDTextBox txtName;
        private CustomControls.TDControls.TDTextBox txtEmail;
        private CustomControls.TDControls.TDTextBox txtQuestion;
        private CustomControl.TDControls.TDComboBox cbxTopic;
        private CustomControls.TDControls.TDButton btnSubmit;
        private System.Windows.Forms.Button btnClose;
    }
}