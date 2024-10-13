using CapitalCityProgram.Models;
using CapitalCityTests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CapitalCityProgram
{
    public partial class frmAddCountriesCapitals : Form
    {
        List<Country> countries = new List<Country>(); 
        public static int questions = 0; // Used to store users choice of questions 

        public frmAddCountriesCapitals()
        {
            InitializeComponent();
            lblUsername.Text = frmUserDetails.username.ToUpper()+" PLAYING"; // Displays username of player

            countries = CountriesAndCapitalsReader.GetCountries();
            txtQuestions.Focus();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!(txtQuestions.Text.Any(char.IsDigit))) // Ensures all data entered is numeric
            {
                MessageBox.Show("Please enter a number!");
                txtQuestions.Text = "";
                txtQuestions.Focus();
            }

            else if (txtQuestions.Text == "") // Ensures text isn't left blank
            {
                MessageBox.Show("Please enter a number!");
                txtQuestions.Text = "";
                txtQuestions.Focus();
            }

            else if (Convert.ToInt32(txtQuestions.Text) < 5) // Ensures chosen number is 5 or more
            {
                MessageBox.Show("Minimum of 5 questions!");
                txtQuestions.Text = "";
                txtQuestions.Focus();
            }

            else if (Convert.ToInt32(txtQuestions.Text) > countries.Count) // Ensures chosen number of questions doesn't exceed the maximum amount
            {
                MessageBox.Show("Maximum of " + countries.Count + " questions!");
                txtQuestions.Text = "";
                txtQuestions.Focus();
            }

            else if (Convert.ToInt32(txtQuestions.Text) > 0 && Convert.ToInt32(txtQuestions.Text) <= countries.Count)
            {
                questions = Convert.ToInt32(txtQuestions.Text); // Stores text entered in questions variable
                frmGame frmGame = new frmGame(countries); // Opens the game form
                frmGame.Show();
                this.Hide();
            }
        }
    }
}
