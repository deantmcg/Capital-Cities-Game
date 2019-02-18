using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapitalCityProgram
{
    public partial class frmGame : Form
    {
        public static int score = 0;
        public static int hints = 0;
        public static int pass = 0;
        // these will increase/decrease during game depending on user performance

        string[] questions = new string[2] { "What is the capital city of ", " is the capital of which country?" };
        // This is the 2 possible question formats that can be asked

        int numQuestions = frmAddCountriesCapitals.questions; // pulls questions variable from previous form
        int questionsAsked = 0;

        int q; // index for random question format (questions[])
        int index; // index for random country and capital city

        string answer;
        
        List<string> countries;
        List<string> capitals;
        // creates lists to store the lists sent from previous method

        public frmGame(List<string> list1, List<string> list2) // Two lists sent to this method are from previous form
        {
            InitializeComponent();
            score = score - score; // Important for when a user decides to play again. Sets score back to zero
            countries = list1;
            capitals = list2;

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
            pass = pass + 1;
            txtAnswer.Text = "";
            lblHint.Text = "";
        } // Deducts from score when pass is clicked - increases pass count - clears text and asks new question

        private void btnNextQ_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.ToUpper() == answer.ToUpper())
            {
                scoreUpdate(15);
            } // if previous answer was correct adds 15 points

            else if (txtAnswer.Text.ToUpper() != answer.ToUpper())
            {
                scoreUpdate(-5);
            } // if previous answer was incorrect deducts 5 points
            setValues();
            askQuestion();
            txtAnswer.Text = "";
            lblHint.Text = "";
        }

        public void setValues()
        {
            Random rand = new Random();
            q = rand.Next(0, 2);
            index = rand.Next(0, (countries.Count));
        } // Uses random to generate index and q variables

        public void askQuestion()
        {
            if (questionsAsked < frmAddCountriesCapitals.questions) 
            { // asks question as long as questions asked doesn't match chosen amount
                questionsAsked = questionsAsked + 1;

                if (q == 0)
                {
                    lblQuestionSpace.Text = "" + questions[q] + countries[index] + "?";
                    answer = capitals[index];
                } // Constructs question "What is the capital city of *COUNTRY*"

                else if (q == 1)
                {
                    lblQuestionSpace.Text = capitals[index] + questions[q];
                    answer = countries[index];
                } // Constructs question "*CAPITAL CITY* is the capital of which country?"
                countries.RemoveAt(index);
                capitals.RemoveAt(index);
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

        private void btnHint_Click(object sender, EventArgs e)
        {
            lblHint.Text = "First letter: "+answer[0].ToString();
            scoreUpdate(-5);
            hints = hints + 1;
        } // Displays first letter of answer if hint is clicked - score decreased by 5 - hint count is increased by 1

        public void scoreUpdate(int change)
        { // takes a score change int variable
            score = score + change;
            lblScore.Text = "Score: "+score.ToString();
        } // updates score
    }
}
