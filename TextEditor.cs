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

namespace Project_Group3
{
    public partial class formTextEditor : Form
    {
        //This is the filepath of the active file, if applicable.
        string filepath = string.Empty;

        bool isUnchanged = true;
        public formTextEditor()
        {
            InitializeComponent();
        }

        #region "Event Handlers"

        /// <summary>
        /// Text has been changed if fired.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextHasChanged(object sender, EventArgs e)
        {
            isUnchanged = false;
            UpdateTitle();
        }

        /// <summary>
        /// THis is used to create a new blank text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FileNew(object sender, EventArgs e)
        {
            textBoxEditor.Clear();
            filepath = string.Empty;
            UpdateTitle();
        }

        /// <summary>
        /// By clicking Open you can select any text file to open.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FileOpen(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                formTextEditor textEditorInstance = new formTextEditor();
                textEditorInstance = this;
                textEditorInstance.Show();
                textEditorInstance.Focus();
                StreamReader read = new StreamReader(File.OpenRead(openDialog.FileName));

                textBoxEditor.Text = read.ReadToEnd();
                read.Dispose();

                filepath = openDialog.FileName;
                isUnchanged = true;
                UpdateTitle();
            }
            else
            {
                formTextEditor textEditorInstance = (formTextEditor)this.ActiveMdiChild;
                textEditorInstance = this;
                textEditorInstance.Show();
                textEditorInstance.Close();
            }
        }

        /// <summary>
        /// Copying stuff to the clipboard
        /// </summary>
        public void EditCopy(object sender, EventArgs e)
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
        public void EditPaste(object sender, EventArgs e)
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
        public void EditCut(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxEditor.SelectedText);
            
            textBoxEditor.SelectedText = string.Empty;

        }

        /// <summary>
        /// Saves the work done so far, if its saving for the first time it will tell the user to select a location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SaveClick(object sender, EventArgs e)
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
        public void FileSaveAs(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = saveDialog.FileName;

                SaveTextFile(filepath);

                isUnchanged = true;

                UpdateTitle();
                
            }

        }

        /// <summary>
        /// Displays a little message about this application in the help dropdown
        /// </summary>
        public void HelpAbout(object sender, EventArgs e)
        {
            MessageBox.Show("Text Editor\n" + "By Nimsith Fernandopulle\n\n" + "For NETD 2202" +
                "\n" + "March 2021", "About this Application");

        }

        /// <summary>
        /// 
        /// </summary>
        public void ConfirmClose(object sender, FormClosingEventArgs e)
        {
            if (isUnchanged == false)
            {
                if (MessageBox.Show("Do you want to save changes to your text?", "My Application",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    e.Cancel = true;
                    SaveClick(sender, e);
                    MessageBox.Show("File has been saved", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = false;
                }
            }
        }

        #endregion

        #region "Other Functions"
        /// <summary>
        /// Updates the title of the Interface once you save the file
        /// </summary>
        public void UpdateTitle()
        {
            this.Text = "Text Editor";
            if(filepath != string.Empty)
            {
                this.Text += " - " + filepath;
            }

            if (!isUnchanged)
            {
                this.Text += "*";
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
            isUnchanged = true;
            UpdateTitle();
        }
        #endregion

       
    }
}
