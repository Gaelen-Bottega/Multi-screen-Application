//Name: Nimsith Fernandopulle
//Date: February 24th, 2021
//Type of Document - Lab 3 - Units Shipped by employees
//Description: this program takes the number of units shipped by 3 employees and finds the average of each employee and total average.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Group3
{
    public partial class AverageUnitsShipped : System.Windows.Forms.Form
    {
        //Constant Declerations
        const int NumberOfEmployees = 3;
        const int NumberOfDays = 7;

        // Class-Level variale declerations
        int currentEmployee = 0;
        int currentDay = 0;

        int[,] entryArray = new int[NumberOfEmployees, NumberOfDays];

        //Output arrays
        TextBox[] employeeTextBoxes;
        Label[] employeeAverages;

        public AverageUnitsShipped()
        {
            InitializeComponent();

            //Populating aarrays
            employeeTextBoxes = new TextBox[] { textBoxPastEntry1,
                textBoxPastEntry2, textBoxPastEntry3};
            employeeAverages = new Label[] { labelOutput1, labelOutput2, labelOutput3};

        }

        /// <summary>
        /// The Purpose of the Enter Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ButtonEnterClick(object sender, EventArgs e)
        {
            //Declearing constants and variables
            const int MinimumUnits = 0;
            const int MaximumUnits = 5000;

            //Validating the number entered to be a whole number
            if (int.TryParse(textBoxEntry.Text, out entryArray[currentEmployee, currentDay]))
            {
                // Validating the number entered is between 0 and 5000
                if (entryArray[currentEmployee, currentDay] >= MinimumUnits && entryArray
                    [currentEmployee, currentDay] <= MaximumUnits)
                {
                    //Enter the current (valid) entry in the currect employee's textbox.
                    employeeTextBoxes[currentEmployee].Text += entryArray[currentEmployee, currentDay] + "\r\n";
                    textBoxEntry.Clear();

                    //Check if we entered day 7
                    if (currentDay++ >= NumberOfDays - 1)
                    {
                        double employeeTotal = 0;

                        //Calculate and display employee 1's average
                        for (int day = 0; day < NumberOfDays; day++)
                        {
                            employeeTotal += entryArray[currentEmployee, day];
                        }

                        //Calculate and disply the employee's average in their output label.
                        employeeAverages[currentEmployee].Text = "Average: " + Math.Round
                        ((double)employeeTotal / NumberOfDays, 2);

                        //Reset the day counter when entering for another employee
                        currentDay = 0;
                        currentEmployee++;

                    }

                    if (currentEmployee == 0)
                    {
                        labelEmployee1.Font = new Font(this.Font, FontStyle.Bold);
                        labelEmployee2.Font = new Font(this.Font, FontStyle.Regular);
                        labelEmployee3.Font = new Font(this.Font, FontStyle.Regular);
                    }

                    else if (currentEmployee == 1)
                    {
                        labelEmployee1.Font = new Font(this.Font, FontStyle.Regular);
                        labelEmployee2.Font = new Font(this.Font, FontStyle.Bold);

                    }

                    else if(currentEmployee == 2)
                    {
                        labelEmployee1.Font = new Font(this.Font, FontStyle.Regular);
                        labelEmployee2.Font = new Font(this.Font, FontStyle.Regular);
                        labelEmployee3.Font = new Font(this.Font, FontStyle.Bold);
                    }
                   
                    // Check if we have entered all employees.
                    if (currentEmployee >= NumberOfEmployees)
                    {
                        double totalEmployee = 0;

                        for (int j = 0; j < NumberOfEmployees; j++)
                        {
                            for (int i = 0; i < NumberOfDays; i++)
                            {
                                totalEmployee += entryArray[j, i];
                                labelTotalAverage.Text = "Average Per Day: " + Math.Round((double)totalEmployee / (NumberOfEmployees * NumberOfDays), 2);
                            }
                        }

                            currentDay = 0;
                        currentEmployee = 0;

                        //Set focus
                        textBoxEntry.Enabled = false;
                        buttonEnter.Enabled = false;
                        buttonReset.Focus();
                    

                    }

                    //Adjust the day and set the day ecounter.
                   
                    labelDay.Text = "Day " + (currentDay + 1);

                }
                else
                {
                    //The value entered is less than 0 or greater than 5000
                    MessageBox.Show("Enter a value between " + MinimumUnits + " and " + MaximumUnits + ".", "Invalid Entry!");
                    textBoxEntry.SelectAll();
                    textBoxEntry.Focus();
                }
            }
            else
            {
                //The value entered is not an integer
                MessageBox.Show("Entry must be a numerical value.", "Invalid Entry!");
                textBoxEntry.SelectAll();
                textBoxEntry.Focus();
            }
        }

        /// <summary>
        ///Resets the whole form for new data entries. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            ResetForm();
        }

        /// <summary>
        /// Click to exit out of the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Resets the form for new data entry
        /// </summary>
        private void ResetForm()
        {
            //CLear the input and output fields.
            textBoxEntry.Clear();
            textBoxPastEntry1.Clear();
            textBoxPastEntry2.Clear();
            textBoxPastEntry3.Clear();
            labelOutput1.Text = string.Empty;
            labelOutput2.Text = string.Empty;
            labelOutput3.Text = string.Empty;
            labelTotalAverage.Text = string.Empty;

            //reset the global variables
            currentDay = 0;
            labelDay.Text = "Day " + currentDay;

            //Reset the fonts to their default states.
            labelEmployee1.Font = new Font(this.Font, FontStyle.Bold);
            labelEmployee2.Font = new Font(this.Font, FontStyle.Regular);
            labelEmployee3.Font = new Font(this.Font, FontStyle.Regular);

            //Re - enable any controls that may be disabled/
            textBoxEntry.Enabled = true;
            buttonEnter.Enabled = true;

            //Set focus for easy data entry.
            textBoxEntry.Focus();

        }
        /// <summary>
        /// About this application
        /// </summary>
        public void AverageUnitsShippedHelp()
        {
            MessageBox.Show("Average Units Shipped\n" + "By Nimsith Fernandopulle\n\n" + "For NETD 2202" +
                "\n" + "2021", "About this Application");
        }
    }
}
