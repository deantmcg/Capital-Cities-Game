namespace CapitalCityProgram
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblQuestionSpace = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnNextQ = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(692, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(255, 23);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "username here";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(692, 32);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(255, 23);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score here";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(880, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "EXIT";
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(865, 418);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(80, 80);
            this.picClose.TabIndex = 6;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lblQuestionSpace
            // 
            this.lblQuestionSpace.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionSpace.ForeColor = System.Drawing.Color.Black;
            this.lblQuestionSpace.Location = new System.Drawing.Point(47, 73);
            this.lblQuestionSpace.Name = "lblQuestionSpace";
            this.lblQuestionSpace.Size = new System.Drawing.Size(899, 184);
            this.lblQuestionSpace.TabIndex = 8;
            this.lblQuestionSpace.Text = "CLICK NEXT QUESTION TO START";
            this.lblQuestionSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(47, 260);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(623, 62);
            this.txtAnswer.TabIndex = 1;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPass
            // 
            this.btnPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.Location = new System.Drawing.Point(258, 430);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(183, 68);
            this.btnPass.TabIndex = 5;
            this.btnPass.Text = "PASS";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnNextQ
            // 
            this.btnNextQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQ.Location = new System.Drawing.Point(47, 328);
            this.btnNextQ.Name = "btnNextQ";
            this.btnNextQ.Size = new System.Drawing.Size(623, 61);
            this.btnNextQ.TabIndex = 2;
            this.btnNextQ.Text = "NEXT QUESTION";
            this.btnNextQ.UseVisualStyleBackColor = true;
            this.btnNextQ.Click += new System.EventHandler(this.btnNextQ_Click);
            // 
            // btnHint
            // 
            this.btnHint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.Location = new System.Drawing.Point(676, 328);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(270, 61);
            this.btnHint.TabIndex = 4;
            this.btnHint.Text = "HINT";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // lblHint
            // 
            this.lblHint.BackColor = System.Drawing.Color.White;
            this.lblHint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.Location = new System.Drawing.Point(676, 260);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(270, 62);
            this.lblHint.TabIndex = 3;
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(959, 501);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnNextQ);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblQuestionSpace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblUsername);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblQuestionSpace;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnNextQ;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Label lblHint;
    }
}