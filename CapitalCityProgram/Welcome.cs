using CapitalCityProgram.Models;
using CapitalCityTests.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapitalCityProgram // The form which will open first when the program is loaded
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnHighScores_Click(object sender, EventArgs e) // Opens the high scores form
        {
            frmHighScores frmHighScores = new frmHighScores();
            Hide();
            frmHighScores.Show();
        }

        private void btnInstructions_Click(object sender, EventArgs e) // Opens the instructions form
        {
            frmInstructions frmInstructions = new frmInstructions();
            frmInstructions.Show();
        }

        private void btnStart_Click(object sender, EventArgs e) // Starts the game - Opens the user details form
        {
            frmGameConfig frmUserDetails = new frmGameConfig();
            frmUserDetails.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closes the application
        }
    }
}
