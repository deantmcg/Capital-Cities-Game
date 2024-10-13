using CapitalCityProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CapitalCityProgram
{
    public enum QuestionFormat
    {
        Country,
        CapitalCity
    }

    public partial class frmGame : Form
    {
        // these will increase/decrease during game depending on user performance
        public static int score = 0;
        public static int hintsUsed = 0;
        public static int questionsPassed = 0;
        int questionsAsked = 0;

        // This is the 2 possible question formats that can be asked
        string[] questions = new string[2] { "What is the capital city of ", " is the capital of which country?" };

        QuestionFormat questionFormat;
        int q; // index for random question format (questions[])
        int index; // index for random country and capital city

        string answer;
        
        // creates lists to store the lists sent from previous method
        List<Country> countries;
        Country currentCountry;
        int hintsLeftForQuestion = 2;
        int?[] hintIndexUsed = new int?[2];

        public frmGame(List<Country> list1) // Two lists sent to this method are from previous form
        {
            InitializeComponent();
            score = score - score; // Important for when a user decides to play again. Sets score back to zero
            countries = list1;

            lblUsername.Text = frmUserDetails.username + " playing"; // Displays username in game - pulled from User Details form
            lblScore.Text = "Score: " + score;

            setValues(); // randomly generates indexes
            askQuestion(); // uses indexes to ask question
        }

        private void frmGame_Load(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            scoreUpdate(-10);
            setValues();
            askQuestion();
            questionsPassed = questionsPassed + 1;
            txtAnswer.Text = "";
            lblHint.Text = "";
        } // Deducts from score when pass is clicked - increases pass count - clears text and asks new question

        private void btnNextQ_Click(object sender, EventArgs e)
        {
            bool answerIsCorrect = false;

            if (questionFormat == QuestionFormat.Country)
            {
                answerIsCorrect = currentCountry.IsAnswerAccepted(txtAnswer.Text);
            }
            else if (questionFormat == QuestionFormat.CapitalCity)
            {
                answerIsCorrect = currentCountry.CapitalCity.IsAnswerAccepted(txtAnswer.Text);
            }

             // if previous answer was correct adds 15 points
            if (answerIsCorrect)
            {
                scoreUpdate(15);
            }
            // if previous answer was incorrect deducts 5 points
            else
            {
                scoreUpdate(-5);
            }

            setValues();
            askQuestion();
            txtAnswer.Text = "";
            lblHint.Text = "";
            hintsLeftForQuestion = 2;
            hintIndexUsed = new int?[2];
        }

        public void setValues()
        {
            Random rand = new Random();
            q = rand.Next(0, 2);
            index = rand.Next(0, (countries.Count));
            currentCountry = countries[index];
        } // Uses random to generate index and q variables

        public void askQuestion()
        {
            // asks question as long as questions asked doesn't match chosen amount
            if (questionsAsked < frmAddCountriesCapitals.questions) 
            {
                questionsAsked++;

                // Constructs question "What is the capital city of *COUNTRY*"
                if (q == 0)
                {
                    questionFormat = QuestionFormat.CapitalCity;
                    lblQuestionSpace.Text = $"What is the capital city of {countries[index].Name}?";
                }
                // Constructs question "*CAPITAL CITY* is the capital of which country?"
                else if (q == 1)
                {
                    questionFormat = QuestionFormat.Country;
                    lblQuestionSpace.Text = $"{countries[index].CapitalCity.Name} is the capital city of which country?";
                }
                countries.RemoveAt(index);
                // Once question is asked the country and capital are removed from lists to prevent repetition of questions
            }

            else
            {
                frmGameOver frmGameOver = new frmGameOver();
                this.Hide();
                frmGameOver.Show();
            } // if questions asked matches chosen amount this opens Game Over form

            txtAnswer.Focus();
            
        }

        // Displays first letter of answer if hint is clicked - score decreased by 5 - hint count is increased by 1
        private void btnHint_Click(object sender, EventArgs e)
        {
            string hintText = "No hints left.";

            if (hintsLeftForQuestion > 0)
            {
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
                    hintText = currentCountry.Hints[hintIndex];
                }
                else if (questionFormat == QuestionFormat.CapitalCity)
                {
                    hintText = currentCountry.CapitalCity.Hints[hintIndex];
                }

                scoreUpdate(-5);
                hintsUsed = hintsUsed + 1;
                hintsLeftForQuestion--;
            }
                
            lblHint.Text = hintText;
        }

        // takes an int variable and updates score
        public void scoreUpdate(int change)
        {
            score = score + change;
            lblScore.Text = $"Score: {score.ToString()}";
        }
    }
}
