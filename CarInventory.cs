// Customer.cs
// Author:  Gaelen Rhoads and Kyle Chapman's slides
// Date:    March 14, 2021
// Description: This program will give the user the ability to add cars to a list view interface. They can view any car present in the list view and edit the values.
// This program is validated (in the most work around way...) to not except empty strings in any field. It also will not accept a negative number in the price field.

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
    public partial class CarInventory : Form
    {
        private List<Car> carList = new List<Car>();
        // This flag is used to indicate whether the program is checking boxes as opposed to a human.
        private bool isAutomated = false;
        // Variable representing the current selected index in the ListView.
        // This is being used to simplify a few reference to indexes.
        private int selectedIndex = -1;
        public CarInventory()
        {
            InitializeComponent();
        }

        private static CarInventory instance;

        #region "Event Handlers"

        /// <summary>
        /// Form Load. This code will execute on form load event. It adds some cars to the list view box by default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoad(object sender, EventArgs e)
        {
            // Declare some dummy data on Form load
            Car myCar = new Car("Ford", "Focus", 2012, false, 8000);
            Car myDreamCar = new Car("Tesla", "Roadster", 2021, true, 99000);
            Car myProjectCar = new Car("Shelby", "GT500", 1967, false, 65000);

            // Add all of the new customer objects from above to the list.
            carList.Add(myCar);
            carList.Add(myDreamCar);
            carList.Add(myProjectCar);

            PopulateListView(carList);
        }

        /// <summary>
        /// This event will fire when the enter button is clicked. It will empty out the error box, call the validate function on the three parameters, and 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Empty the error label; it will fill with NEW errors if anything is wrong.
            labelOutput.Text = String.Empty;

            //// Check if the customer is valid.
            if (IsCarValid(comboBoxMake.Text, textBoxModel.Text, textBoxPrice.TextLength))
            {
                // stuff I tried instead of being dumb and using ".TextLength". I could not get it to except just "textBoxPrice.Text". There must
                // be a better way to do this...
                //Convert.ToDecimal(textBoxPrice.Text)
                //decimal.Parse(textBoxPrice.Text)

                Car newCarToAdd = new Car(comboBoxMake.Text, textBoxModel.Text, (int)numericUpDownYear.Value, checkBoxNew.Checked, decimal.Parse(textBoxPrice.Text));
                
                if (selectedIndex >= 0)
                {
                    // Replace the old version of that car with the new one!
                    carList[selectedIndex] = newCarToAdd;
                }
                else
                {
                    // Otherwise, add a car with the entered details to the end of the list.
                    carList.Add(newCarToAdd);
                }

                // Refresh the entire listView.
                PopulateListView(carList);

                // Reset the form to allow new entries.
                SetDefaults();
            }
               
        }
        /// <summary>
        /// Calls the setDefaults function and resets the form. This actually takes two presses to fire when the form first loads and you try and display a car.
        /// Really, really weird bug I have not figured out yet. Works for all other resetting.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }
        /// <summary>
        /// Exits the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Displays the car when selected in the list view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // If the list is populated and something is selected...
            if (listViewEntries.Items.Count > 0 && listViewEntries.FocusedItem != null)
            {
                // ...fill in the entry fields with values based on the selected customer.
                comboBoxMake.Text = listViewEntries.FocusedItem.SubItems[2].Text;
                textBoxModel.Text = listViewEntries.FocusedItem.SubItems[3].Text;
                numericUpDownYear.Text = listViewEntries.FocusedItem.SubItems[4].Text;
                textBoxPrice.Text = listViewEntries.FocusedItem.SubItems[5].Text;
                checkBoxNew.Checked = listViewEntries.FocusedItem.Checked;

                // Set the selectedIndex to match the listView.
                selectedIndex = listViewEntries.FocusedItem.Index;
            }
            else
            {
                // If nothing is selected, set the selectedIndex to -1.
                selectedIndex = -1;
            }
        }

        /// <summary>
        /// Prevents a user from checking boxes in the list view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreventCheck(object sender, ItemCheckEventArgs e)
        {
            // Only prevent checking if it's being done by the user.
            if (!isAutomated)
            {
                // Change the new value of the checkbox equal to the old state of the checkbox.
                e.NewValue = e.CurrentValue;
            }
        }

        #endregion

        #region "Functions"
        /// <summary>
        /// Sets the default state of things.
        /// </summary>
        private void SetDefaults()
        {
            comboBoxMake.SelectedIndex = -1;
            textBoxModel.Text = String.Empty;
            numericUpDownYear.Value = 2021;
            textBoxPrice.Text = String.Empty;
            checkBoxNew.Checked = false;
            listViewEntries.SelectedItems.Clear();
            labelOutput.Text = String.Empty;
            selectedIndex = -1;

            // set focus
            comboBoxMake.Focus();
        }

        /// <summary>
        /// Validates the users input for entry of a car.
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        private bool IsCarValid(string make, string model, decimal price)
        {
            bool isValid = true;
            const int ZERO = 0;

            if (make == String.Empty)
            {
                isValid &= false;
                labelOutput.Text += "Please select a Make of car.\n";
            }

            if (model == String.Empty)
            {
                isValid &= false;
                labelOutput.Text += "Please type in a model of car.\n";
            }
            // I know this is silly. Very silly. But I could not figure out how to get the decimal contents of the textBox. It just kept yelling at me about strings
            if (textBoxPrice.TextLength == ZERO || textBoxPrice.Text.Contains("-"))
            {
                isValid &= false;
                labelOutput.Text += "Please enter a real number greater than or equal to 0";
            }

            return isValid;
        }
        /// <summary>
        /// Populates the list view with all the items in the collection!
        /// </summary>
        /// <param name="carList"></param>
        private void PopulateListView(List<Car> carList)
        {
            listViewEntries.Items.Clear();

            foreach (Car newCar in carList)
            {
                ListViewItem carItem = new ListViewItem();

                isAutomated = true;
                carItem.Checked = newCar.NewStatus;
                carItem.SubItems.Add(newCar.Id.ToString());
                carItem.SubItems.Add(newCar.Make);
                carItem.SubItems.Add(newCar.Model);
                carItem.SubItems.Add(newCar.Year.ToString());
                carItem.SubItems.Add(newCar.Price.ToString());

                // Add the customerItem to the ListView.
                listViewEntries.Items.Add(carItem);

                // Disallow the user from modifying the ListView's checkboxes.
                isAutomated = false;
            }
        }

        #endregion
        /// <summary>
        /// Tracks number of instances of car inventory is currently open, if there are no instances: open an instance. If one is open, refer to the window open.
        /// </summary>
        public static CarInventory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CarInventory();
                }

                return instance;
            }
        }
        /// <summary>
        /// Resets the instance variable when the form closes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarInventoryClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        public void CarHelp()
        {
            MessageBox.Show("Car Inventory Application\n" + "By Gaelen Rhoads\n\n" + "For NETD 2202" +
               "\n" + "March 2021", "About this Application");
        }
    }
}
