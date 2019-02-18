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
    public partial class frmUserDetails : Form
    {
        public frmUserDetails()
        {
            InitializeComponent();
        }

        private void User_Details_Load(object sender, EventArgs e)
        {

        }

        public static string username = "";

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
                username = txtUsername.Text;
                frmAddCountriesCapitals frmAddCountriesCapitals = new frmAddCountriesCapitals();
                frmAddCountriesCapitals.Show();
                this.Close();
            } // Assigns the text entered to username - Opens the Add Countries and Capitals form
        }
    }
}
