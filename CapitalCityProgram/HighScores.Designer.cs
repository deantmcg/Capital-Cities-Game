namespace CapitalCityProgram
{
    partial class frmHighScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHighScores));
            this.lblHighSc = new System.Windows.Forms.Label();
            this.lstScores = new System.Windows.Forms.ListBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHighSc
            // 
            this.lblHighSc.BackColor = System.Drawing.Color.Transparent;
            this.lblHighSc.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighSc.ForeColor = System.Drawing.Color.White;
            this.lblHighSc.Location = new System.Drawing.Point(47, 6);
            this.lblHighSc.Name = "lblHighSc";
            this.lblHighSc.Size = new System.Drawing.Size(370, 72);
            this.lblHighSc.TabIndex = 0;
            this.lblHighSc.Text = "HIGH SCORES";
            this.lblHighSc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstScores
            // 
            this.lstScores.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lstScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstScores.FormattingEnabled = true;
            this.lstScores.ItemHeight = 20;
            this.lstScores.Location = new System.Drawing.Point(47, 81);
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(370, 404);
            this.lstScores.TabIndex = 1;
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(193, 491);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(80, 80);
            this.picClose.TabIndex = 6;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // frmHighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(443, 585);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lstScores);
            this.Controls.Add(this.lblHighSc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHighScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HIGH SCORES";
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHighSc;
        private System.Windows.Forms.ListBox lstScores;
        private System.Windows.Forms.PictureBox picClose;
    }
}