using CapitalCityTests.Helpers;
using System;
using System.Windows.Forms;

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

            SaveScore(frmUserDetails.username, frmGame.score); // sends username and score to be added to high scores
        }
        
        // Opens welcome form
        private void button1_Click(object sender, EventArgs e)
        {
            frmWelcome frmWelcome = new frmWelcome();
            Hide();
            frmWelcome.Show();
        } 

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        // Opens High Scores form
        private void btnHighScores_Click(object sender, EventArgs e)
        {
            frmHighScores frmHighScores = new frmHighScores();
            Hide();
            frmHighScores.Show();
        } 

        // Adds score and username to the end of High Scores.txt
        public void SaveScore(string username, int score)
        {
            HighScoresHelper.AddNewHighScore(username, score);
        }
    }
}