
namespace Project_Group3
{
    partial class formMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.windowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.windowTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.windowTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.windowCarList = new System.Windows.Forms.ToolStripMenuItem();
            this.windowAverageUnits = new System.Windows.Forms.ToolStripMenuItem();
            this.windowAwesomeness = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.windowTextEditor1 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowTextEditor2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolstripNewFile = new System.Windows.Forms.ToolStripButton();
            this.toolstripOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolstripSaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripCut = new System.Windows.Forms.ToolStripButton();
            this.toolstripCopy = new System.Windows.Forms.ToolStripButton();
            this.toolstripPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripHelp = new System.Windows.Forms.ToolStripButton();
            this.menuTop.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTop
            // 
            this.menuTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuWindow,
            this.menuHelp});
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(983, 24);
            this.menuTop.TabIndex = 0;
            this.menuTop.Text = "menuStrip";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.toolStripSeparator,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.toolStripSeparator1,
            this.menuFileClose,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            this.menuFile.ToolTipText = "Options related to file management";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("menuFileNew.Image")));
            this.menuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(150, 26);
            this.menuFileNew.Text = "&New";
            this.menuFileNew.ToolTipText = "click to create a new file";
            this.menuFileNew.Click += new System.EventHandler(this.WindowNewTextEditor);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuFileOpen.Image")));
            this.menuFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(150, 26);
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.ToolTipText = "Click to Open a new File";
            this.menuFileOpen.Click += new System.EventHandler(this.FileOpen);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(147, 6);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("menuFileSave.Image")));
            this.menuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(150, 26);
            this.menuFileSave.Text = "&Save";
            this.menuFileSave.ToolTipText = "Click to save the document";
            this.menuFileSave.Click += new System.EventHandler(this.FileSave);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(150, 26);
            this.menuFileSaveAs.Text = "Save &As";
            this.menuFileSaveAs.ToolTipText = "Click to find a file location to save the newly created file.";
            this.menuFileSaveAs.Click += new System.EventHandler(this.FileSaveAs);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // menuFileClose
            // 
            this.menuFileClose.Name = "menuFileClose";
            this.menuFileClose.Size = new System.Drawing.Size(150, 26);
            this.menuFileClose.Text = "&Close";
            this.menuFileClose.ToolTipText = "Click to close a file";
            this.menuFileClose.Click += new System.EventHandler(this.FileClose);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(150, 26);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.ToolTipText = "Click to exit the current application";
            this.menuFileExit.Click += new System.EventHandler(this.FileExit);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "&Edit";
            // 
            // menuEditCut
            // 
            this.menuEditCut.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCut.Image")));
            this.menuEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuEditCut.Size = new System.Drawing.Size(144, 22);
            this.menuEditCut.Text = "Cu&t";
            this.menuEditCut.ToolTipText = "Click to remove the current selection and to keep it in the clipboard";
            this.menuEditCut.Click += new System.EventHandler(this.EditCut);
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCopy.Image")));
            this.menuEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuEditCopy.Size = new System.Drawing.Size(144, 22);
            this.menuEditCopy.Text = "&Copy";
            this.menuEditCopy.ToolTipText = "Click to copy selected words ";
            this.menuEditCopy.Click += new System.EventHandler(this.EditCopy);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("menuEditPaste.Image")));
            this.menuEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuEditPaste.Size = new System.Drawing.Size(144, 22);
            this.menuEditPaste.Text = "&Paste";
            this.menuEditPaste.ToolTipText = "Click to paste the contents in the clipboard";
            this.menuEditPaste.Click += new System.EventHandler(this.EditPaste);
            // 
            // menuWindow
            // 
            this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowCascade,
            this.windowTileVertical,
            this.windowTileHorizontal,
            this.toolStripSeparator2,
            this.windowCarList,
            this.windowAverageUnits,
            this.windowAwesomeness,
            this.toolStripSeparator3,
            this.windowTextEditor1,
            this.windowTextEditor2});
            this.menuWindow.Name = "menuWindow";
            this.menuWindow.Size = new System.Drawing.Size(63, 20);
            this.menuWindow.Text = "&Window";
            // 
            // windowCascade
            // 
            this.windowCascade.Name = "windowCascade";
            this.windowCascade.Size = new System.Drawing.Size(252, 22);
            this.windowCascade.Text = "Cascade";
            this.windowCascade.ToolTipText = "Click to cascade the window";
            this.windowCascade.Click += new System.EventHandler(this.WindowCascade);
            // 
            // windowTileVertical
            // 
            this.windowTileVertical.Name = "windowTileVertical";
            this.windowTileVertical.Size = new System.Drawing.Size(252, 22);
            this.windowTileVertical.Text = "Tile Vertical";
            this.windowTileVertical.ToolTipText = "Click to Tile Vertically";
            this.windowTileVertical.Click += new System.EventHandler(this.TileVertical);
            // 
            // windowTileHorizontal
            // 
            this.windowTileHorizontal.Name = "windowTileHorizontal";
            this.windowTileHorizontal.Size = new System.Drawing.Size(252, 22);
            this.windowTileHorizontal.Text = "Tile Horizontal";
            this.windowTileHorizontal.ToolTipText = "Click to tile Horizontally";
            this.windowTileHorizontal.Click += new System.EventHandler(this.WindowTileHorizontal);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(249, 6);
            // 
            // windowCarList
            // 
            this.windowCarList.Name = "windowCarList";
            this.windowCarList.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.windowCarList.Size = new System.Drawing.Size(252, 22);
            this.windowCarList.Text = "Open Car &List";
            this.windowCarList.ToolTipText = "Click to Open the Car list program";
            this.windowCarList.Click += new System.EventHandler(this.WindowNewCarList);
            // 
            // windowAverageUnits
            // 
            this.windowAverageUnits.Name = "windowAverageUnits";
            this.windowAverageUnits.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.windowAverageUnits.Size = new System.Drawing.Size(252, 22);
            this.windowAverageUnits.Text = "Open &Average Units";
            this.windowAverageUnits.ToolTipText = "Click to open the Average units program";
            this.windowAverageUnits.Click += new System.EventHandler(this.WindowNewAverageUnitsShipped);
            // 
            // windowAwesomeness
            // 
            this.windowAwesomeness.Name = "windowAwesomeness";
            this.windowAwesomeness.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.windowAwesomeness.Size = new System.Drawing.Size(252, 22);
            this.windowAwesomeness.Text = "Awesome&ness Application";
            this.windowAwesomeness.ToolTipText = "Click to Open the Awesomeness application";
            this.windowAwesomeness.Click += new System.EventHandler(this.WindowNewAwesomeness);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(249, 6);
            // 
            // windowTextEditor1
            // 
            this.windowTextEditor1.Name = "windowTextEditor1";
            this.windowTextEditor1.Size = new System.Drawing.Size(252, 22);
            this.windowTextEditor1.Text = "1 Text Editor 1 - New";
            this.windowTextEditor1.ToolTipText = "Click to Open a new Text Editor";
            this.windowTextEditor1.Click += new System.EventHandler(this.WindowNewTextEditor);
            // 
            // windowTextEditor2
            // 
            this.windowTextEditor2.Name = "windowTextEditor2";
            this.windowTextEditor2.Size = new System.Drawing.Size(252, 22);
            this.windowTextEditor2.Text = "2 Text Editor 2 - New";
            this.windowTextEditor2.ToolTipText = "Click to Open another new Text Editor";
            this.windowTextEditor2.Click += new System.EventHandler(this.WindowNewTextEditor);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            // 
            // helpAbout
            // 
            this.helpAbout.Name = "helpAbout";
            this.helpAbout.Size = new System.Drawing.Size(116, 22);
            this.helpAbout.Text = "&About...";
            this.helpAbout.ToolTipText = "Click to show the details of the application";
            this.helpAbout.Click += new System.EventHandler(this.Help);
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripNewFile,
            this.toolstripOpenFile,
            this.toolstripSaveFile,
            this.toolStripSeparator4,
            this.toolstripCut,
            this.toolstripCopy,
            this.toolstripPaste,
            this.toolStripSeparator5,
            this.toolstripHelp});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(983, 27);
            this.toolStrip.TabIndex = 2;
            // 
            // toolstripNewFile
            // 
            this.toolstripNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripNewFile.Image = ((System.Drawing.Image)(resources.GetObject("toolstripNewFile.Image")));
            this.toolstripNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripNewFile.Name = "toolstripNewFile";
            this.toolstripNewFile.Size = new System.Drawing.Size(24, 24);
            this.toolstripNewFile.Text = "&New";
            this.toolstripNewFile.Click += new System.EventHandler(this.WindowNewTextEditor);
            // 
            // toolstripOpenFile
            // 
            this.toolstripOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolstripOpenFile.Image")));
            this.toolstripOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripOpenFile.Name = "toolstripOpenFile";
            this.toolstripOpenFile.Size = new System.Drawing.Size(24, 24);
            this.toolstripOpenFile.Text = "&Open";
            // 
            // toolstripSaveFile
            // 
            this.toolstripSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("toolstripSaveFile.Image")));
            this.toolstripSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripSaveFile.Name = "toolstripSaveFile";
            this.toolstripSaveFile.Size = new System.Drawing.Size(24, 24);
            this.toolstripSaveFile.Text = "&Save";
            this.toolstripSaveFile.Click += new System.EventHandler(this.FileSave);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolstripCut
            // 
            this.toolstripCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripCut.Image = ((System.Drawing.Image)(resources.GetObject("toolstripCut.Image")));
            this.toolstripCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripCut.Name = "toolstripCut";
            this.toolstripCut.Size = new System.Drawing.Size(24, 24);
            this.toolstripCut.Text = "C&ut";
            this.toolstripCut.Click += new System.EventHandler(this.EditCut);
            // 
            // toolstripCopy
            // 
            this.toolstripCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolstripCopy.Image")));
            this.toolstripCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripCopy.Name = "toolstripCopy";
            this.toolstripCopy.Size = new System.Drawing.Size(24, 24);
            this.toolstripCopy.Text = "&Copy";
            this.toolstripCopy.Click += new System.EventHandler(this.EditCopy);
            // 
            // toolstripPaste
            // 
            this.toolstripPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolstripPaste.Image")));
            this.toolstripPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripPaste.Name = "toolstripPaste";
            this.toolstripPaste.Size = new System.Drawing.Size(24, 24);
            this.toolstripPaste.Text = "&Paste";
            this.toolstripPaste.Click += new System.EventHandler(this.EditPaste);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolstripHelp
            // 
            this.toolstripHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolstripHelp.Image")));
            this.toolstripHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripHelp.Name = "toolstripHelp";
            this.toolstripHelp.Size = new System.Drawing.Size(24, 24);
            this.toolstripHelp.Text = "He&lp";
            this.toolstripHelp.Click += new System.EventHandler(this.Help);
            // 
            // formMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(983, 786);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuTop);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuTop;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Text Editor";
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTop;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuWindow;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem helpAbout;
        private System.Windows.Forms.ToolStripMenuItem menuFileClose;
        private System.Windows.Forms.ToolStripMenuItem windowCascade;
        private System.Windows.Forms.ToolStripMenuItem windowTileVertical;
        private System.Windows.Forms.ToolStripMenuItem windowTileHorizontal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem windowCarList;
        private System.Windows.Forms.ToolStripMenuItem windowAverageUnits;
        private System.Windows.Forms.ToolStripMenuItem windowAwesomeness;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem windowTextEditor1;
        private System.Windows.Forms.ToolStripMenuItem windowTextEditor2;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolstripNewFile;
        private System.Windows.Forms.ToolStripButton toolstripOpenFile;
        private System.Windows.Forms.ToolStripButton toolstripSaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolstripCut;
        private System.Windows.Forms.ToolStripButton toolstripCopy;
        private System.Windows.Forms.ToolStripButton toolstripPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolstripHelp;
    }
}

