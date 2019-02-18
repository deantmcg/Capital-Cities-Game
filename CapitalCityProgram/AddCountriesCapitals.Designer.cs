namespace CapitalCityProgram
{
    partial class frmAddCountriesCapitals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCountriesCapitals));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustomise = new System.Windows.Forms.Label();
            this.lstCountries = new System.Windows.Forms.ListBox();
            this.lstCapitals = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtAddCountry = new System.Windows.Forms.TextBox();
            this.txtAddCapital = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddCountry = new System.Windows.Forms.Label();
            this.lblAddCapital = new System.Windows.Forms.Label();
            this.lblCountries = new System.Windows.Forms.Label();
            this.lblCapitals = new System.Windows.Forms.Label();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.grpRemove = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtRemCountry = new System.Windows.Forms.TextBox();
            this.txtRemCapital = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblRemCapital = new System.Windows.Forms.Label();
            this.lblRemCountry = new System.Windows.Forms.Label();
            this.grpQuestions = new System.Windows.Forms.GroupBox();
            this.txtQuestions = new System.Windows.Forms.TextBox();
            this.lblOptionals = new System.Windows.Forms.Label();
            this.grpAdd.SuspendLayout();
            this.grpRemove.SuspendLayout();
            this.grpQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(282, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(260, 23);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "username here";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(525, 95);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "You can remove or add some countries and cities of your own if you like! ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomise
            // 
            this.lblCustomise.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomise.Location = new System.Drawing.Point(12, 9);
            this.lblCustomise.Name = "lblCustomise";
            this.lblCustomise.Size = new System.Drawing.Size(215, 23);
            this.lblCustomise.TabIndex = 2;
            this.lblCustomise.Text = "CUSTOMISE YOUR GAME";
            // 
            // lstCountries
            // 
            this.lstCountries.FormattingEnabled = true;
            this.lstCountries.Location = new System.Drawing.Point(21, 143);
            this.lstCountries.Name = "lstCountries";
            this.lstCountries.Size = new System.Drawing.Size(120, 550);
            this.lstCountries.TabIndex = 3;
            // 
            // lstCapitals
            // 
            this.lstCapitals.FormattingEnabled = true;
            this.lstCapitals.Location = new System.Drawing.Point(147, 143);
            this.lstCapitals.Name = "lstCapitals";
            this.lstCapitals.Size = new System.Drawing.Size(120, 550);
            this.lstCapitals.TabIndex = 4;
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(273, 236);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(264, 74);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "PLAY!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtAddCountry
            // 
            this.txtAddCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCountry.Location = new System.Drawing.Point(8, 53);
            this.txtAddCountry.Name = "txtAddCountry";
            this.txtAddCountry.Size = new System.Drawing.Size(121, 26);
            this.txtAddCountry.TabIndex = 6;
            this.txtAddCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddCapital
            // 
            this.txtAddCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCapital.Location = new System.Drawing.Point(135, 53);
            this.txtAddCapital.Name = "txtAddCapital";
            this.txtAddCapital.Size = new System.Drawing.Size(121, 26);
            this.txtAddCapital.TabIndex = 7;
            this.txtAddCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(8, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(247, 56);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddCountry
            // 
            this.lblAddCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblAddCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCountry.Location = new System.Drawing.Point(8, 26);
            this.lblAddCountry.Name = "lblAddCountry";
            this.lblAddCountry.Size = new System.Drawing.Size(121, 24);
            this.lblAddCountry.TabIndex = 9;
            this.lblAddCountry.Text = "COUNTRY";
            this.lblAddCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddCapital
            // 
            this.lblAddCapital.BackColor = System.Drawing.Color.Transparent;
            this.lblAddCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCapital.Location = new System.Drawing.Point(134, 26);
            this.lblAddCapital.Name = "lblAddCapital";
            this.lblAddCapital.Size = new System.Drawing.Size(121, 24);
            this.lblAddCapital.TabIndex = 10;
            this.lblAddCapital.Text = "CAPITAL CITY";
            this.lblAddCapital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountries
            // 
            this.lblCountries.BackColor = System.Drawing.Color.Transparent;
            this.lblCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountries.Location = new System.Drawing.Point(20, 117);
            this.lblCountries.Name = "lblCountries";
            this.lblCountries.Size = new System.Drawing.Size(121, 24);
            this.lblCountries.TabIndex = 11;
            this.lblCountries.Text = "COUNTRIES";
            this.lblCountries.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCapitals
            // 
            this.lblCapitals.BackColor = System.Drawing.Color.Transparent;
            this.lblCapitals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitals.Location = new System.Drawing.Point(144, 117);
            this.lblCapitals.Name = "lblCapitals";
            this.lblCapitals.Size = new System.Drawing.Size(123, 24);
            this.lblCapitals.TabIndex = 12;
            this.lblCapitals.Text = "CAPITAL CITIES";
            this.lblCapitals.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // grpAdd
            // 
            this.grpAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpAdd.Controls.Add(this.txtAddCountry);
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Controls.Add(this.txtAddCapital);
            this.grpAdd.Controls.Add(this.lblAddCapital);
            this.grpAdd.Controls.Add(this.lblAddCountry);
            this.grpAdd.Location = new System.Drawing.Point(273, 371);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(264, 158);
            this.grpAdd.TabIndex = 13;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "ADD A COUNTRY AND CAPITAL";
            // 
            // grpRemove
            // 
            this.grpRemove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpRemove.Controls.Add(this.btnSelect);
            this.grpRemove.Controls.Add(this.txtRemCountry);
            this.grpRemove.Controls.Add(this.txtRemCapital);
            this.grpRemove.Controls.Add(this.btnRemove);
            this.grpRemove.Controls.Add(this.lblRemCapital);
            this.grpRemove.Controls.Add(this.lblRemCountry);
            this.grpRemove.Location = new System.Drawing.Point(273, 535);
            this.grpRemove.Name = "grpRemove";
            this.grpRemove.Size = new System.Drawing.Size(264, 158);
            this.grpRemove.TabIndex = 14;
            this.grpRemove.TabStop = false;
            this.grpRemove.Text = "SELECT A COUNTRY AND CLICK \'SELECT COUNTRY\' TO REMOVE IT AND ITS CAPITAL";
            // 
            // btnSelect
            // 
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(8, 85);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(247, 33);
            this.btnSelect.TabIndex = 15;
            this.btnSelect.Text = "SELECT COUNTRY";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtRemCountry
            // 
            this.txtRemCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemCountry.Location = new System.Drawing.Point(8, 53);
            this.txtRemCountry.Name = "txtRemCountry";
            this.txtRemCountry.Size = new System.Drawing.Size(121, 26);
            this.txtRemCountry.TabIndex = 7;
            this.txtRemCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRemCapital
            // 
            this.txtRemCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemCapital.Location = new System.Drawing.Point(135, 53);
            this.txtRemCapital.Name = "txtRemCapital";
            this.txtRemCapital.Size = new System.Drawing.Size(121, 26);
            this.txtRemCapital.TabIndex = 6;
            this.txtRemCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(8, 119);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(247, 33);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblRemCapital
            // 
            this.lblRemCapital.BackColor = System.Drawing.Color.Transparent;
            this.lblRemCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemCapital.Location = new System.Drawing.Point(134, 26);
            this.lblRemCapital.Name = "lblRemCapital";
            this.lblRemCapital.Size = new System.Drawing.Size(121, 24);
            this.lblRemCapital.TabIndex = 10;
            this.lblRemCapital.Text = "CAPITAL CITY";
            this.lblRemCapital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemCountry
            // 
            this.lblRemCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblRemCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemCountry.Location = new System.Drawing.Point(8, 26);
            this.lblRemCountry.Name = "lblRemCountry";
            this.lblRemCountry.Size = new System.Drawing.Size(121, 24);
            this.lblRemCountry.TabIndex = 9;
            this.lblRemCountry.Text = "COUNTRY";
            this.lblRemCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpQuestions
            // 
            this.grpQuestions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpQuestions.Controls.Add(this.txtQuestions);
            this.grpQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQuestions.Location = new System.Drawing.Point(273, 143);
            this.grpQuestions.Name = "grpQuestions";
            this.grpQuestions.Size = new System.Drawing.Size(264, 87);
            this.grpQuestions.TabIndex = 15;
            this.grpQuestions.TabStop = false;
            this.grpQuestions.Text = "SELECT HOW MANY QUESTIONS YOU WISH TO ANSWER";
            // 
            // txtQuestions
            // 
            this.txtQuestions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestions.Location = new System.Drawing.Point(97, 44);
            this.txtQuestions.Name = "txtQuestions";
            this.txtQuestions.Size = new System.Drawing.Size(58, 26);
            this.txtQuestions.TabIndex = 7;
            this.txtQuestions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOptionals
            // 
            this.lblOptionals.BackColor = System.Drawing.Color.Transparent;
            this.lblOptionals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionals.ForeColor = System.Drawing.Color.White;
            this.lblOptionals.Location = new System.Drawing.Point(273, 344);
            this.lblOptionals.Name = "lblOptionals";
            this.lblOptionals.Size = new System.Drawing.Size(171, 24);
            this.lblOptionals.TabIndex = 16;
            this.lblOptionals.Text = "OPTIONALS";
            this.lblOptionals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddCountriesCapitals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(546, 701);
            this.Controls.Add(this.lblOptionals);
            this.Controls.Add(this.grpQuestions);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.grpRemove);
            this.Controls.Add(this.lblCapitals);
            this.Controls.Add(this.lblCountries);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lstCapitals);
            this.Controls.Add(this.lstCountries);
            this.Controls.Add(this.lblCustomise);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCountriesCapitals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customise your game!";
            this.Load += new System.EventHandler(this.frmAddCountriesCapitals_Load);
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.grpRemove.ResumeLayout(false);
            this.grpRemove.PerformLayout();
            this.grpQuestions.ResumeLayout(false);
            this.grpQuestions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustomise;
        private System.Windows.Forms.ListBox lstCountries;
        private System.Windows.Forms.ListBox lstCapitals;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtAddCountry;
        private System.Windows.Forms.TextBox txtAddCapital;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddCountry;
        private System.Windows.Forms.Label lblAddCapital;
        private System.Windows.Forms.Label lblCountries;
        private System.Windows.Forms.Label lblCapitals;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.GroupBox grpRemove;
        private System.Windows.Forms.TextBox txtRemCountry;
        private System.Windows.Forms.TextBox txtRemCapital;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblRemCapital;
        private System.Windows.Forms.Label lblRemCountry;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox grpQuestions;
        private System.Windows.Forms.TextBox txtQuestions;
        private System.Windows.Forms.Label lblOptionals;
    }
}