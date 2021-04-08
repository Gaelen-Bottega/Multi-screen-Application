﻿//Author: Nimsith & Gaelen
//Project: NETD Project - TextEditor
//Date: April 8th, 2021
//Description: This is the final application for NETD where one screen can open a text editor, average units shipped calculator, car list, and an awesomeness application...

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Group3
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// OPens the text editor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowNewTextEditor(object sender, EventArgs e)
        {
            formTextEditor textInstance = new formTextEditor();
            textInstance.MdiParent = this;
            textInstance.Show();
            textInstance.Focus();
        }

        /// <summary>
        /// Opens the car list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowNewCarList(object sender, EventArgs e)
        {
            CarInventory myCarInventory = CarInventory.Instance;
            myCarInventory.MdiParent = this;
            myCarInventory.Show();
            myCarInventory.Focus();
        }

        /// <summary>
        /// Opens the average units shipped calculator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowNewAverageUnitsShipped(object sender, EventArgs e)
        {
            AverageUnitsShipped averageUnitsShippedInstance = new AverageUnitsShipped();
            averageUnitsShippedInstance.MdiParent = this;
            averageUnitsShippedInstance.Show();
            averageUnitsShippedInstance.Focus();
        }

        /// <summary>
        /// Opens Awesomeness application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowNewAwesomeness(object sender, EventArgs e)
        {
            formAwesomeness awesomenessInstance = new formAwesomeness();
            awesomenessInstance.MdiParent = this;
            awesomenessInstance.Show();
            awesomenessInstance.Focus();
        }

        /// <summary>
        /// Copying stuff to the clipboard and deleting it from the window if selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCopy(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
                {
                    formTextEditor textEditorInstance = (formTextEditor)this.ActiveMdiChild;
                    textEditorInstance.EditCopy(sender, e);

                }
                else
                {
                    MessageBox.Show("The copy operation is not supposted by the current selected window.");
                }
            }
        }
        /// <summary>
        /// Cutting stuff from the clipboard, which removes text and using the select you can paste them again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCut(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
                {
                    formTextEditor textEditorInstance = (formTextEditor)this.ActiveMdiChild;
                    textEditorInstance.EditCut(sender, e);

                }
                else
                {
                    MessageBox.Show("The copy operation is not supported by the current selected window.");
                }
            }
        }

        /// <summary>
        /// After copying something to the clipboard you can paste it using this 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditPaste(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
                {
                    formTextEditor textEditorInstance = (formTextEditor)this.ActiveMdiChild;
                    textEditorInstance.EditPaste(sender, e);

                }
                else
                {
                    MessageBox.Show("The Paste operation is not supported by the current selected window.");
                }
            }
        }
        /// <summary>
        /// Saves a file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileSave(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Saves a file to the users computer for the first time. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileSaveAs(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
                {
                    formTextEditor textEditorInstance = (formTextEditor)this.ActiveMdiChild;
                    textEditorInstance.FileSaveAs(sender, e);

                }
                else if (this.ActiveMdiChild.GetType() == typeof(AverageUnitsShipped))
                {
                    AverageUnitsShipped UnitsShippedInstance = (AverageUnitsShipped)
                        this.ActiveMdiChild;
                    UnitsShippedInstance.ButtonEnterClick(sender, e);
                }       
            }
        }
        /// <summary>
        /// Cascades the windows and arranges them accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowCascade(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        /// <summary>
        /// Arranges the windows horizontally.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowTileHorizontal(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        /// <summary>
        /// Arranges the windows vertically.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TileVertical(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        /// <summary>
        /// Prints information about the current application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Help(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
                {
                    formTextEditor textEditorInstance = (formTextEditor)this.ActiveMdiChild;
                    textEditorInstance.HelpAbout(sender, e);

                }
                else if (this.ActiveMdiChild.GetType() == typeof(AverageUnitsShipped))
                {
                    AverageUnitsShipped averageUnitsShippedInstance = (AverageUnitsShipped)this.ActiveMdiChild;
                    averageUnitsShippedInstance.AverageUnitsShippedHelp();
                }
                else if (this.ActiveMdiChild.GetType() == typeof(formAwesomeness))
                {
                    formAwesomeness awesomenessInstance = (formAwesomeness)this.ActiveMdiChild;
                    awesomenessInstance.AwesomenessHelp();
                }
                else if (this.ActiveMdiChild.GetType() == typeof(CarInventory))
                {
                    CarInventory carHelpInstance = (CarInventory)this.ActiveMdiChild;
                    carHelpInstance.CarHelp();
                }
                else
                {
                    MessageBox.Show("The Help operation is not supported by the current selected window.");
                }
            }
        }
    }
}
