using CapitalCityProgram.Models;
using System;
using System.Windows.Forms;

namespace CapitalCityProgram
{
    public partial class frmGame : Form
    {
        private GameDetails game;

        public frmGame(GameDetails details)
        {
            InitializeComponent();
            game = details;
            game.Score = 0; // Important for when a user decides to play again. Sets score back to zero

            lblUsername.Text = $"{details.Username} playing"; // Displays username in game - pulled from User Details form
            lblScore.Text = $"Score: {game.Score}";

            setQuestion();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        // Deducts from score when pass is clicked - increases pass count - clears text and asks new question
        private void btnPass_Click(object sender, EventArgs e)
        {
            UpdateScore(-10);
            PassQuestion();
            txtAnswer.Text = "";
            lblHint.Text = "";
        }

        private void btnNextQ_Click(object sender, EventArgs e)
        {
            bool answerIsCorrect = game.CurrentQuestion.IsCorrect(txtAnswer.Text);

            // if previous answer was correct adds 15 points
            if (answerIsCorrect)
            {
                UpdateScore(15);
                game.CurrentQuestion.Status = QuestionStatus.Correct;
            }
            // if previous answer was incorrect deducts 5 points
            else
            {
                UpdateScore(-5);
                game.CurrentQuestion.Status = QuestionStatus.Incorrect;
            }

            NextQuestion();
            txtAnswer.Text = "";
            lblHint.Text = "";
        }

        private void NextQuestion()
        {
            game.NextQuestion();
            setQuestion();
        }

        private void PassQuestion()
        {
            game.PassQuestion();
            setQuestion();
        }

        public void setQuestion()
        {
            // asks question as long as questions asked doesn't match chosen amount
            if (game.QuestionsAsked < 5)
            {
                lblQuestionSpace.Text = game.CurrentQuestion.Text;
            }
            // if questions asked matches chosen amount this opens Game Over form
            else
            {
                frmGameOver frmGameOver = new frmGameOver(game);
                Hide();
                frmGameOver.Show();
            }

            txtAnswer.Focus();
        }

        // Displays hint - score decreased by 5 - hint count is increased by 1
        private void btnHint_Click(object sender, EventArgs e)
        {
            if (game.CurrentQuestion.HintsLeft > 0)
            {
                UpdateScore(-5);
            }
                
            string hintText = game.CurrentQuestion.GetHint();
            lblHint.Text = hintText;
        }

        // takes an int variable and updates score
        public void UpdateScore(int change)
        {
            game.UpdateScore(change);
            lblScore.Text = $"Score: {game.Score}";
        }
    }
}