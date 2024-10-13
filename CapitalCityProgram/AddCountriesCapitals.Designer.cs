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
            this.lblCustomise = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.grpQuestions = new System.Windows.Forms.GroupBox();
            this.txtQuestions = new System.Windows.Forms.TextBox();
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
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(141, 140);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(264, 74);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "PLAY!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // grpQuestions
            // 
            this.grpQuestions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpQuestions.Controls.Add(this.txtQuestions);
            this.grpQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQuestions.Location = new System.Drawing.Point(141, 47);
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
            // frmAddCountriesCapitals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(546, 249);
            this.Controls.Add(this.grpQuestions);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblCustomise);
            this.Controls.Add(this.lblUsername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCountriesCapitals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customise your game!";
            this.grpQuestions.ResumeLayout(false);
            this.grpQuestions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCustomise;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox grpQuestions;
        private System.Windows.Forms.TextBox txtQuestions;
    }
}