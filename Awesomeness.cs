// Author: Nimsith Fernandopulle
// Date: January 14th, 2021
// Description: This program forces the user to click yes which automatically makes him awesome.
//There are 3 buttons used where 2 dissappears whenever they are interacted with.



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
    public partial class formAwesomeness : Form
    {
        public formAwesomeness()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Display a congratulatory message and ends the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ButtonClickYes(object sender, EventArgs e)
        {
            MessageBox.Show("Yes, you are Awesome. Congradulations! and have a nice day.");
            Close();
        }

        /// <summary>
        /// Hides the left "No" button and shows the right "No" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideLeft(object sender, EventArgs e)
        {
            ButtonLeftNo.Visible = false;
            ButtonRightNo.Visible = true;
        }

        /// <summary>
        /// Hides the right "No" and shows the left "No" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideRight(object sender, EventArgs e)
        {
            ButtonRightNo.Hide();
            ButtonLeftNo.Show();
        }
        /// <summary>
        /// About this application
        /// </summary>
        public void AwesomenessHelp()
        {
            MessageBox.Show("Awesomeness Application\n" + "By Nimsith Fernandopulle\n\n" + "For NETD 2202" +
                "\n" + "2021", "About this Application");
        }
    }
}
