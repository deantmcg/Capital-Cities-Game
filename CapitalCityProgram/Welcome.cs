using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapitalCityProgram // The form which will open first when the program is loaded
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e) // Opens the high scores form
        {
            frmHighScores frmHighScores = new frmHighScores();
            this.Hide();
            frmHighScores.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInstructions_Click(object sender, EventArgs e) // Opens the instructions form
        {
            frmInstructions frmInstructions = new frmInstructions();
            frmInstructions.Show();
        }

        private void btnStart_Click(object sender, EventArgs e) // Starts the game - Opens the user details form
        {
            frmUserDetails frmUserDetails = new frmUserDetails();
            frmUserDetails.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closes the application
        }
    }
}
