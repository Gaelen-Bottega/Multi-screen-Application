//Author: Nimsith Fernandopulle
//Project: NETD Lab 5 - TextEditor
//Date: March 26th, 2021
//Description: This application is the budget version of notepad, basic file management services are available

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

namespace Lab5___Nimsith
{
    public partial class formTextEditor : Form
    {
        //This is the filepath of the active file, if applicable.
        string filepath = string.Empty;
        public formTextEditor()
        {
            InitializeComponent();
        }

        #region "Event Handlers"
        /// <summary>
        /// THis is used to create a new blank text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileNew(object sender, EventArgs e)
        {
            textBoxEditor.Clear();
            filepath = string.Empty;
            UpdateTitle();
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        private void FileExit(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// By clicking Open you can select any text file to open.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileOpen(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(openDialog.FileName));

                textBoxEditor.Text = read.ReadToEnd();
                read.Dispose();

                filepath = openDialog.FileName;

                UpdateTitle();
            }
        }

        /// <summary>
        /// Copying stuff to the clipboard
        /// </summary>
        private void EditCopy(object sender, EventArgs e)
        {
           if(textBoxEditor.Text.Length != 0)
           {
               Clipboard.SetText(textBoxEditor.SelectedText);
           }
        }

        /// <summary>
        /// After copying something to the clipboard you can paste it using this 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditPaste(object sender, EventArgs e)
        {
            if(Clipboard.ContainsText())
            {
                textBoxEditor.SelectedText = Clipboard.GetText();
            }

        }

        /// <summary>
        /// Cutting stuff from the clipboard, which removes text and using the select you can paste them again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCut(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxEditor.SelectedText);
            
            textBoxEditor.SelectedText = string.Empty;

        }

        /// <summary>
        /// by clicking you can select all the text in the editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditSelectAll(object sender, EventArgs e)
        {
            for(int i = 0; i < textBoxEditor.Text.Length; i++)
            {
                textBoxEditor.SelectAll();
            }
        }

        /// <summary>
        /// Saves the work done so far, if its saving for the first time it will tell the user to select a location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveClick(object sender, EventArgs e)
        {
            if(filepath == string.Empty)
            {
                FileSaveAs(sender, e);
            }
            else
            {
                SaveTextFile(filepath);
            }
        }

        /// <summary>
        /// The program will ask the user to select a location to save the file
        /// </summary>
        private void FileSaveAs(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = saveDialog.FileName;

                SaveTextFile(filepath);

                UpdateTitle();
            }

        }

        /// <summary>
        /// Displays a little message about this application in the help dropdown
        /// </summary>
        private void HelpAbout(object sender, EventArgs e)
        {
            MessageBox.Show("Text Editor\n" + "By Nimsith Fernandopulle\n\n" + "For NETD 2202" +
                "\n" + "March 2021", "About this Application");

        }

        /// <summary>
        /// 
        /// </summary>
        private void ConfirmClose(object sender, FormClosingEventArgs e)
        {

                if (MessageBox.Show("Do you want to save changes to your text?", "My Application",
                     MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    e.Cancel = true;
                    FileSaveAs(sender, e);
                } 

        }

        #endregion

        #region "Other Functions"
        /// <summary>
        /// Updates the title of the Interface once you save the file
        /// </summary>
        public void UpdateTitle()
        {
            this.Text = "Nimsith's Whiteboard";
            if(filepath != string.Empty)
            {
                this.Text += " - " + filepath;
            }
        }

        /// <summary>
        /// Saves the text File created
        /// </summary>
        /// <param name="path"> The path of the writer to </param>
        public void SaveTextFile(string path)
        {
            FileStream myFile = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(myFile);

            writer.Write(textBoxEditor.Text);

            writer.Close();
        }
        #endregion
    }
}
