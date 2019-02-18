using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CapitalCityProgram
{
    public partial class frmHighScores : Form
    {
        

        public frmHighScores()
        {
            InitializeComponent();

            List<string> highScores = new List<string>();
            StreamReader inputFile = File.OpenText("High Scores.txt");
            while (!inputFile.EndOfStream)
            {
                highScores.Add(inputFile.ReadLine());
            } // reads in high scores text file into newly created list

            highScores.Sort(); // sorts list alphabetically
            foreach (string line in highScores)
            {
                lstScores.Items.Add(line);
            } // Displays high scores and usernames in the list box
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            frmWelcome frmWelcome = new frmWelcome();
            frmWelcome.Show();
            this.Hide(); // Opens the Welcome form
        }
    }
}
