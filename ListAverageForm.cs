using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListAverageToluA
{
    public partial class ListAverageForm : Form
    {
        public ListAverageForm()
        {
            InitializeComponent();
        }

 /*
 * Created by: Tolu Adebayo
 * Created on: 05-06-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - List Average
 * This program caluclates the average of the numbers added to a list
*/
        // Create Empty List
        List<int> myListOfIntegers = new List<int>();

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // declare local variables
            int userMark = -1;
            // convert the value in the text box to an integer
            try
            {
                userMark = int.Parse(txtNumber.Text);
            }
            // if the user did not enter a valid number, write the error to the command line
            catch (Exception parseError)
            {
                Console.WriteLine("An error occured : '{0} ' ", parseError);
            }
            // Check if the user entered a number between 0 and 100
            if ((userMark >= 0) && (userMark <= 100))
            {
                this.lstNumbers.Items.Add(userMark);

                // add mark to list
                myListOfIntegers.Add(userMark);
            }
            // otherwise, display an error
            else
            {
                MessageBox.Show("Please enter a number between 0 and 100", "Invalid Number");
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double average = 0;
            double sum = 0;

            // create a for loop starting from 0 until list Count, adding the contents each time
            for (int counter = 0; counter < myListOfIntegers.Count; counter++)
            {
                sum = sum + myListOfIntegers[counter];
            }

            // Calculate the average of the value in the array 
            average = sum / myListOfIntegers.Count;
            // Display Average 
            this.lblAnswer.Text = "The Average is : " + average;

        }
    }
}
