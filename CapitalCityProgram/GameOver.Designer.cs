namespace CapitalCityProgram
{
    partial class frmGameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameOver));
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblScored = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFromPossible = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblHintsPasses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGameOver
            // 
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(12, 9);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(400, 82);
            this.lblGameOver.TabIndex = 0;
            this.lblGameOver.Text = "GAME OVER!";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScored
            // 
            this.lblScored.BackColor = System.Drawing.Color.Transparent;
            this.lblScored.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScored.Location = new System.Drawing.Point(12, 121);
            this.lblScored.Name = "lblScored";
            this.lblScored.Size = new System.Drawing.Size(400, 40);
            this.lblScored.TabIndex = 1;
            this.lblScored.Text = "YOU SCORED";
            this.lblScored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 161);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(400, 73);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "-";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(99, 315);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(225, 44);
            this.btnMainMenu.TabIndex = 3;
            this.btnMainMenu.Text = "MAIN MENU";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHighScores
            // 
            this.btnHighScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHighScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScores.Location = new System.Drawing.Point(99, 365);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(225, 44);
            this.btnHighScores.TabIndex = 4;
            this.btnHighScores.Text = "HIGH SCORES";
            this.btnHighScores.UseVisualStyleBackColor = true;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(99, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(225, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFromPossible
            // 
            this.lblFromPossible.BackColor = System.Drawing.Color.Transparent;
            this.lblFromPossible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromPossible.Location = new System.Drawing.Point(12, 234);
            this.lblFromPossible.Name = "lblFromPossible";
            this.lblFromPossible.Size = new System.Drawing.Size(400, 40);
            this.lblFromPossible.TabIndex = 6;
            this.lblFromPossible.Text = "FROM A POSSIBLE";
            this.lblFromPossible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 91);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(400, 40);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "WELL DONE / TRY AGAIN";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHintsPasses
            // 
            this.lblHintsPasses.BackColor = System.Drawing.Color.Transparent;
            this.lblHintsPasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHintsPasses.Location = new System.Drawing.Point(9, 272);
            this.lblHintsPasses.Name = "lblHintsPasses";
            this.lblHintsPasses.Size = new System.Drawing.Size(400, 40);
            this.lblHintsPasses.TabIndex = 8;
            this.lblHintsPasses.Text = "HINTS / PASSES";
            this.lblHintsPasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(421, 474);
            this.Controls.Add(this.lblHintsPasses);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblFromPossible);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScored);
            this.Controls.Add(this.lblGameOver);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAME OVER";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblScored;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFromPossible;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblHintsPasses;
    }
}