using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace CapitalCityProgram
{
    public partial class frmAddCountriesCapitals : Form
    {
        List<string> countries = new List<string>();
        List<string> capitals = new List<string>();
        // Creates the lists to store the countries and capitals
        int index = 0; // Used to store the index of selected country in countries list 
        public static int questions = 0; // Used to store users choice of questions 

        public frmAddCountriesCapitals()
        {
            InitializeComponent();
            lblUsername.Text = frmUserDetails.username.ToUpper()+" PLAYING"; // Displays username of player

            StreamReader inputFile = File.OpenText("Countries.txt");
            while (!inputFile.EndOfStream)
            {
                countries.Add(inputFile.ReadLine());
            } 

            StreamReader inputFile2 = File.OpenText("Capitals.txt");
            while (!inputFile2.EndOfStream)
            {
                capitals.Add(inputFile2.ReadLine());
            } // Reads all lines of text files into the lists

            UpdateLists();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAddCountriesCapitals_Load(object sender, EventArgs e)
        {
            
        }

        public void UpdateLists() // "Refreshes the lists" - used after an entry is added or removed
        {
            lstCountries.Items.Clear();
            foreach (string country in countries)
            {
                lstCountries.Items.Add(country);
            }

            lstCapitals.Items.Clear();
            foreach (string city in capitals)
            {
                lstCapitals.Items.Add(city);
            }

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
                frmGame frmGame = new frmGame(countries, capitals); // Opens the game form
                frmGame.Show();
                this.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((((txtAddCountry.Text.Length < 4) || (txtAddCapital.Text.Length < 4))) || txtAddCountry.Text.Any(char.IsDigit) || txtAddCapital.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Valid entries only. Must be 4 characters or greater. No numbers.");
                txtAddCountry.Text = "";
                txtAddCapital.Text = "";
                txtAddCountry.Focus();
            } // Ensures text entered for both fields is over 4 characters in length
            // Ensures no numbers are entered

            else if (string.IsNullOrWhiteSpace(txtAddCountry.Text) || string.IsNullOrWhiteSpace(txtAddCapital.Text))
            {
                MessageBox.Show("Valid entries only. Must be 4 characters or greater. No numbers.");
                txtAddCountry.Text = "";
                txtAddCapital.Text = "";
                txtAddCountry.Focus();
            } // Ensures neither of the fields are left empty
            // Sourced and adapted from: https://stackoverflow.com/questions/6156458/check-if-textbox-is-empty-and-return-messagebox

            else if (!(txtAddCountry.Text.Any(char.IsLetter)) || !(txtAddCapital.Text.Any(char.IsLetter)))
            {
                MessageBox.Show("Valid entries only. Must be 4 characters or greater. No numbers.");
                txtAddCountry.Text = "";
                txtAddCapital.Text = "";
                txtAddCountry.Focus();
            }// Ensures only text is entered and special symbols (£, $, %, /)
             // Sourced and adapted from: https://stackoverflow.com/questions/1181419/verifying-that-a-string-contains-only-letters-in-c-sharp
             // user: Muhammad Hasan Khan

            else
            {
                countries.Add(txtAddCountry.Text);
                capitals.Add(txtAddCapital.Text);
                UpdateLists();
                txtAddCapital.Text = "";
                txtAddCountry.Text = "";
            } // Adds the country and corresponding city to countries and capitals lists
            // Clears the text boxes
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRemCountry.Text) || string.IsNullOrWhiteSpace(txtRemCapital.Text))
            {
                MessageBox.Show("Select a country and click 'SELECT COUNTRY'");
            } // Ensures user selects a country

            else
            {
                countries.RemoveAt(index);
                capitals.RemoveAt(index);
                UpdateLists();
            } // Removes selected country and corresponding city from countries and capitals lists
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstCountries.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a country first!");
            } // Ensures a country is selected

            else
            {
                index = lstCountries.SelectedIndex;
                txtRemCountry.Text = lstCountries.Items[index].ToString();
                txtRemCapital.Text = lstCapitals.Items[index].ToString();
                grpRemove.Text = "NOW CLICK REMOVE!";
                grpRemove.Font = new Font(grpRemove.Font, FontStyle.Bold);
            } // Displays selected country and its capital city in the 2 text boxes on screen
            // Instructs user to click Remove button next
        }
    }
}
