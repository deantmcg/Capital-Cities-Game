using CapitalCityProgram.Models;
using CapitalCityTests.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapitalCityProgram
{
    public partial class frmHighScores : Form
    {
        public frmHighScores()
        {
            InitializeComponent();
            List<HighScore> highScores = HighScoresHelper.GetHighScores();
            
            // Displays high scores and usernames in the list box
            foreach (var entry in highScores)
            {
                lstScores.Items.Add($"{entry.Score} - {entry.Username}");
            } 
        }
        
        // Opens the Welcome form
        private void picClose_Click(object sender, EventArgs e)
        {
            frmWelcome frmWelcome = new frmWelcome();
            frmWelcome.Show();
            Hide(); 
        }
    }
}
