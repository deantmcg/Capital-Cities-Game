using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CapitalCityProgram
{
    public partial class frmGameOver : Form
    {
        public frmGameOver()
        {
            double possible = (frmAddCountriesCapitals.questions) * 15; // calculates maximum score user could have achieved
            InitializeComponent();
            if (frmGame.score == possible) // if score = 100%
                lblResult.Text = "Full Marks! Excellent score!";
            else if (frmGame.score >= ((possible / 100)*75)) // if score greater than 75%
                lblResult.Text = "Well done! Great Score!";

            else if (frmGame.score >= ((possible / 100) * 60) && frmGame.score < ((possible / 100) * 75)) // if score in range 65%-74%
                lblResult.Text = "Good Score!";

            else if (frmGame.score >= ((possible / 100) * 45) && frmGame.score < ((possible / 100) * 60)) // if score in range 45%-59%
                lblResult.Text = "You have work to do! Try again!";

            else // if score less than 45%
                lblResult.Text = "Poor score. Try again!";

            lblScored.Text = frmUserDetails.username.ToUpper()+" SCORED";
            lblScore.Text = frmGame.score.ToString(); // displays users score
            lblFromPossible.Text = "FROM A POSSIBLE "+possible.ToString();
            lblHintsPasses.Text = "Hints used: " + frmGame.hintsUsed + " Passes: "+frmGame.questionsPassed; // Displays pass and hint counts

            ToHighScores(frmUserDetails.username, frmGame.score); // sends username and score to be added to high scores
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmWelcome frmWelcome = new frmWelcome();
            this.Hide();
            frmWelcome.Show();
        } // Opens welcome form

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            frmHighScores frmHighScores = new frmHighScores();
            this.Hide();
            frmHighScores.Show();
        } // Opens High Scores form

        public void ToHighScores(string username, int score)
        {
            File.AppendAllText("High Scores.txt", (score + " - " + username.ToUpper()) + Environment.NewLine);
        } // Adds score and username to the end of High Scores.txt
    }
}
