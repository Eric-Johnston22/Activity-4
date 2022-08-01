using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_4
{
    public partial class timeConverter : Form
    {
        public timeConverter()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            int userInput; // Hold user input
            int results; // Hold converted results

            // Use the TryParse method to validate input
            if (!int.TryParse(tbx_seconds.Text, out userInput))
            {
                MessageBox.Show("Please enter a valid integer.");
            }
            else
            {
                // Test for minutes
                if (userInput >= 60 && userInput < 3600)
                {
                    results = userInput / 60; // Calculate number of minutes
                    tbx_results.Text = results.ToString() + " minutes"; // Display minutes
                }
                // Test for hours
                else if (userInput >= 3600 && userInput < 86400)
                {
                    results = userInput / 3600; // Calculate number of hours
                    tbx_results.Text = results.ToString() + " hours"; // Display hours
                }
                // Test for days
                else if (userInput >= 86400)
                {
                    results = userInput / 86400; // Calculate number of days
                    tbx_results.Text = results.ToString() + " days"; // Display days
                }
            }
        }
    }
}
