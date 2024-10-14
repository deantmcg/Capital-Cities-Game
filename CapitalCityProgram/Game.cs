using CapitalCityProgram.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CapitalCityProgram
{
    public partial class frmGame : Form
    {
        private GameDetails gameDetails;

        private QuestionFormat questionFormat;
        private int index; // index for random country and capital city
        
        private Country currentCountry;
        private int?[] hintIndexUsed = new int?[2];

        public frmGame(GameDetails details)
        {
            InitializeComponent();
            gameDetails = details;
            gameDetails.Score = 0; // Important for when a user decides to play again. Sets score back to zero

            lblUsername.Text = $"{details.Username} playing"; // Displays username in game - pulled from User Details form
            lblScore.Text = $"Score: {gameDetails.Score}";

            setValues(); // randomly generates indexes
            askQuestion(); // uses indexes to ask question
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        // Deducts from score when pass is clicked - increases pass count - clears text and asks new question
        private void btnPass_Click(object sender, EventArgs e)
        {
            UpdateScore(-10);
            setValues();
            askQuestion();
            gameDetails.Questions[index].Status = QuestionStatus.Passed;
            txtAnswer.Text = "";
            lblHint.Text = "";
        }

        private void btnNextQ_Click(object sender, EventArgs e)
        {
            bool answerIsCorrect = false;

            if (questionFormat == QuestionFormat.Country)
            {
                answerIsCorrect = gameDetails.Questions[index].Country.IsAnswerAccepted(txtAnswer.Text);
            }
            else if (questionFormat == QuestionFormat.CapitalCity)
            {
                answerIsCorrect = gameDetails.Questions[index].Country.CapitalCity.IsAnswerAccepted(txtAnswer.Text);
            }

             // if previous answer was correct adds 15 points
            if (answerIsCorrect)
            {
                UpdateScore(15);
                gameDetails.Questions[index].Status = QuestionStatus.Correct;
            }
            // if previous answer was incorrect deducts 5 points
            else
            {
                UpdateScore(-5);
                gameDetails.Questions[index].Status = QuestionStatus.Incorrect;
            }

            setValues();
            askQuestion();
            txtAnswer.Text = "";
            lblHint.Text = "";
            hintIndexUsed = new int?[2];
        }
        
        // Uses random to generate index and q variables
        public void setValues()
        {
            if (gameDetails.Questions.Count == 0)
                return;

            Random rand = new Random();
            index++;
            currentCountry = gameDetails.Questions[index].Country;
        } 

        public void askQuestion()
        {
            // asks question as long as questions asked doesn't match chosen amount
            if (gameDetails.QuestionsAsked < gameDetails.Questions.Count)
            {

                lblQuestionSpace.Text = gameDetails.Questions[index].Text;
            }
            // if questions asked matches chosen amount this opens Game Over form
            else
            {
                frmGameOver frmGameOver = new frmGameOver(gameDetails);
                Hide();
                frmGameOver.Show();
            }

            txtAnswer.Focus();
        }

        // Displays first letter of answer if hint is clicked - score decreased by 5 - hint count is increased by 1
        private void btnHint_Click(object sender, EventArgs e)
        {
            string hintText = "No hints left.";

            if (gameDetails.Questions[index].HintsUsed < 2)
            {
                gameDetails.Questions[index].HintsLeft--;
                Random random = new Random();
                int hintIndex = -1;

                while (hintIndex == -1)
                {
                    var tempIndex = random.Next(0, 3);
                    if (!hintIndexUsed.Contains(tempIndex))
                    {
                        hintIndex = tempIndex;
                    }
                }

                if (questionFormat == QuestionFormat.Country)
                {
                    hintText = gameDetails.Questions[index].Country.Hints[hintIndex];
                }
                else if (questionFormat == QuestionFormat.CapitalCity)
                {
                    hintText = gameDetails.Questions[index].Country.CapitalCity.Hints[hintIndex];
                }

                UpdateScore(-5);
                gameDetails.HintsUsed++;
            }
                
            lblHint.Text = hintText;
        }

        // takes an int variable and updates score
        public void UpdateScore(int change)
        {
            gameDetails.UpdateScore(change);
            lblScore.Text = $"Score: {gameDetails.Score}";
        }
    }
}
