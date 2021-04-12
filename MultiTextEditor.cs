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
        //This is the filepath of the active file, if applicable.
        string filepath = string.Empty;
        public formMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the text editor.
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
        /// Creates instance of text editor and calls the FileOpen event handler from the text editor CS file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FileOpen(object sender, EventArgs e)
        {

            // Make a new instance of a text editor
            formTextEditor textEditorInstance = new formTextEditor();
            textEditorInstance.MdiParent = this;
            textEditorInstance.Show();
            textEditorInstance.Focus();
            // Call the open event handler 
            textEditorInstance.FileOpen(sender, e);

            //if (this.MdiChildren.Length > 0)
            //{
            //    if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
            //    {
            //        formTextEditor textEditorInstance = (formTextEditor)this.ActiveMdiChild;
            //        textEditorInstance.MdiParent = this;
            //        textEditorInstance.Show();
            //        textEditorInstance.Focus();
            //        textEditorInstance.FileOpen(sender, e);
            //    }
            //    else
            //    {
            //        formTextEditor textEditorInstance = new formTextEditor();
            //        textEditorInstance.MdiParent = this;
            //        textEditorInstance.Show();
            //        textEditorInstance.Focus();
            //        textEditorInstance.FileOpen(sender, e);
            //    }
            //}
            //else
            //{
            //    formTextEditor textEditorInstance = new formTextEditor();
            //    textEditorInstance.MdiParent = this;
            //    textEditorInstance.Show();
            //    textEditorInstance.Focus();
            //    textEditorInstance.FileOpen(sender, e);
            //}
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
            else
            {
                MessageBox.Show("The copy operation is not supported with no windows open.");
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
            else
            {
                MessageBox.Show("The cut operation is not supported with no windows open.");
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
            else
            {
                MessageBox.Show("The paste operation is not supported with no windows open.");
            }
        }
        /// <summary>
        /// Saves a file if it is of type text editor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileSave(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
                {
                    formTextEditor textEditorInstance = (formTextEditor)this.ActiveMdiChild;
                    textEditorInstance.SaveClick(sender, e);

                }
                else if (this.ActiveMdiChild.GetType() == typeof(AverageUnitsShipped))
                {
                    AverageUnitsShipped UnitsShippedInstance = (AverageUnitsShipped)
                        this.ActiveMdiChild;
                    MessageBox.Show("This application doesn’t support that functionality");
                }
                else if (this.ActiveMdiChild.GetType() == typeof(CarInventory))
                {
                    CarInventory UnitsShippedInstance = (CarInventory)
                        this.ActiveMdiChild;
                    MessageBox.Show("This application doesn’t support that functionality");
                }
                else if (this.ActiveMdiChild.GetType() == typeof(formAwesomeness))
                {
                    formAwesomeness UnitsShippedInstance = (formAwesomeness)
                        this.ActiveMdiChild;
                    MessageBox.Show("This application doesn’t support that functionality");
                }

            }
            else
            {
                MessageBox.Show("Please open a text editor to perform the save functionality.");
            }
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
                    MessageBox.Show("This application doesn’t support that functionality");
                }
                else if (this.ActiveMdiChild.GetType() == typeof(CarInventory))
                {
                    CarInventory UnitsShippedInstance = (CarInventory)
                        this.ActiveMdiChild;
                    MessageBox.Show("This application doesn’t support that functionality");
                }
                else if (this.ActiveMdiChild.GetType() == typeof(formAwesomeness))
                {
                    formAwesomeness UnitsShippedInstance = (formAwesomeness)
                        this.ActiveMdiChild;
                    MessageBox.Show("This application doesn’t support that functionality");
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
            else
            {
                MessageBox.Show("Final Project\n" + "By Nimsith Fernandopulle and Gaelen Rhoads\n\n" + "For NETD 2202" +
                "\n" + "April 2021", "About this Application");
            }
        }

        /// <summary>
        /// This Event Handler closes the active Mdi Child one at a time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FileClose(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        /// <summary>
        /// This Event Handler Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileExit(object sender, EventArgs e)
        {
            Close();
        }
    }
}
