namespace CapitalCityProgram
{
    partial class frmInstructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstructions));
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblScoring = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblHints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(23, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(308, 42);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "INSTRUCTIONS";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(30, 71);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(295, 229);
            this.lblText.TabIndex = 1;
            this.lblText.Text = resources.GetString("lblText.Text");
            this.lblText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblText.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblScoring
            // 
            this.lblScoring.AutoSize = true;
            this.lblScoring.BackColor = System.Drawing.Color.Transparent;
            this.lblScoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoring.Location = new System.Drawing.Point(369, 9);
            this.lblScoring.Name = "lblScoring";
            this.lblScoring.Size = new System.Drawing.Size(198, 42);
            this.lblScoring.TabIndex = 2;
            this.lblScoring.Text = "SCORING";
            this.lblScoring.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrect.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.Color.Lime;
            this.lblCorrect.Location = new System.Drawing.Point(341, 71);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(260, 44);
            this.lblCorrect.TabIndex = 3;
            this.lblCorrect.Text = "CORRECT +15";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblIncorrect.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrect.Location = new System.Drawing.Point(341, 119);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(270, 44);
            this.lblIncorrect.TabIndex = 4;
            this.lblIncorrect.Text = "INCORRECT -5";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.DimGray;
            this.lblPass.Location = new System.Drawing.Point(341, 163);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(174, 44);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "PASS -10";
            this.lblPass.Click += new System.EventHandler(this.label6_Click);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(534, 229);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(82, 71);
            this.picClose.TabIndex = 6;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(541, 206);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(68, 20);
            this.lblClose.TabIndex = 7;
            this.lblClose.Text = "CLOSE";
            // 
            // lblHints
            // 
            this.lblHints.AutoSize = true;
            this.lblHints.BackColor = System.Drawing.Color.Transparent;
            this.lblHints.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHints.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHints.Location = new System.Drawing.Point(341, 207);
            this.lblHints.Name = "lblHints";
            this.lblHints.Size = new System.Drawing.Size(164, 44);
            this.lblHints.TabIndex = 8;
            this.lblHints.Text = "HINTS -5";
            // 
            // frmInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(628, 309);
            this.Controls.Add(this.lblHints);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblScoring);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblInstructions);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInstructions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instructions";
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblScoring;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblHints;
    }
}