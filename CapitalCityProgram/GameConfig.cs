using CapitalCityProgram.Helpers;
using CapitalCityProgram.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapitalCityProgram
{
    public partial class frmGameConfig : Form
    {
        private List<Country> countries;

        public frmGameConfig(List<Country> allCountries)
        {
            InitializeComponent();
            countries = allCountries;
        }

        private static string username = string.Empty;

        public void btnGo_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length < 3 || txtUsername.Text.Length > 14) // Ensures text entered is a valid length
            {
                MessageBox.Show("Username must be at least 3 charatcers long and no longer than 14 characters");
                txtUsername.Text = "";
                txtUsername.Focus();
            }

            else
            {
                QuestionsGenerator generator = new QuestionsGenerator();
                var questions = generator.GetQuestions(GetDifficultyLevel(drpDifficulty.SelectedItem.ToString()));

                var gameDetails = new GameDetails 
                { 
                    Username = txtUsername.Text, 
                    Difficulty = GetDifficultyLevel(drpDifficulty.SelectedText),
                    Questions = questions
                };

                frmGame frmGame = new frmGame(gameDetails);
                frmGame.Show();
                Close();
            } // Assigns the text entered to username - Opens the Add Countries and Capitals form
        }

        private DifficultyLevel GetDifficultyLevel(string selection)
        {
            switch (selection)
            {
                case "Easy":
                    return DifficultyLevel.Easy;
                case "Medium":
                    return DifficultyLevel.Medium;
                case "Hard":
                    return DifficultyLevel.Hard;
                case "Very Hard":
                    return DifficultyLevel.VeryHard;
                default:
                    return DifficultyLevel.Medium;
            }
        }
    }
}