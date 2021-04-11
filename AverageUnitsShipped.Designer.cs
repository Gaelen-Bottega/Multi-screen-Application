
namespace Project_Group3
{
    partial class AverageUnitsShipped
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
            this.labelUnits = new System.Windows.Forms.Label();
            this.textBoxEntry = new System.Windows.Forms.TextBox();
            this.labelEmployee1 = new System.Windows.Forms.Label();
            this.labelEmployee3 = new System.Windows.Forms.Label();
            this.labelEmployee2 = new System.Windows.Forms.Label();
            this.textBoxPastEntry1 = new System.Windows.Forms.TextBox();
            this.textBoxPastEntry2 = new System.Windows.Forms.TextBox();
            this.textBoxPastEntry3 = new System.Windows.Forms.TextBox();
            this.labelAverage1 = new System.Windows.Forms.Label();
            this.labelOutput2 = new System.Windows.Forms.Label();
            this.labelOutput3 = new System.Windows.Forms.Label();
            this.labelTotalAverage = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelOutput1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelUnits
            // 
            this.labelUnits.AutoSize = true;
            this.labelUnits.Location = new System.Drawing.Point(33, 63);
            this.labelUnits.Name = "labelUnits";
            this.labelUnits.Size = new System.Drawing.Size(42, 20);
            this.labelUnits.TabIndex = 1;
            this.labelUnits.Text = "&Units";
            // 
            // textBoxEntry
            // 
            this.textBoxEntry.Location = new System.Drawing.Point(97, 60);
            this.textBoxEntry.Name = "textBoxEntry";
            this.textBoxEntry.Size = new System.Drawing.Size(50, 27);
            this.textBoxEntry.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxEntry, "Text box to enter the number of units shipped by day ");
            // 
            // labelEmployee1
            // 
            this.labelEmployee1.AutoSize = true;
            this.labelEmployee1.Location = new System.Drawing.Point(74, 105);
            this.labelEmployee1.Name = "labelEmployee1";
            this.labelEmployee1.Size = new System.Drawing.Size(87, 20);
            this.labelEmployee1.TabIndex = 3;
            this.labelEmployee1.Text = "Employee &1";
            // 
            // labelEmployee3
            // 
            this.labelEmployee3.AutoSize = true;
            this.labelEmployee3.Location = new System.Drawing.Point(428, 105);
            this.labelEmployee3.Name = "labelEmployee3";
            this.labelEmployee3.Size = new System.Drawing.Size(87, 20);
            this.labelEmployee3.TabIndex = 5;
            this.labelEmployee3.Text = "Employee &3";
            // 
            // labelEmployee2
            // 
            this.labelEmployee2.AutoSize = true;
            this.labelEmployee2.Location = new System.Drawing.Point(248, 105);
            this.labelEmployee2.Name = "labelEmployee2";
            this.labelEmployee2.Size = new System.Drawing.Size(87, 20);
            this.labelEmployee2.TabIndex = 4;
            this.labelEmployee2.Text = "Employee &2";
            // 
            // textBoxPastEntry1
            // 
            this.textBoxPastEntry1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPastEntry1.Location = new System.Drawing.Point(34, 144);
            this.textBoxPastEntry1.Multiline = true;
            this.textBoxPastEntry1.Name = "textBoxPastEntry1";
            this.textBoxPastEntry1.ReadOnly = true;
            this.textBoxPastEntry1.Size = new System.Drawing.Size(171, 222);
            this.textBoxPastEntry1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBoxPastEntry1, "The units shipped by Employee 1 entered for each day will be stored here");
            // 
            // textBoxPastEntry2
            // 
            this.textBoxPastEntry2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPastEntry2.Location = new System.Drawing.Point(211, 144);
            this.textBoxPastEntry2.Multiline = true;
            this.textBoxPastEntry2.Name = "textBoxPastEntry2";
            this.textBoxPastEntry2.ReadOnly = true;
            this.textBoxPastEntry2.Size = new System.Drawing.Size(171, 222);
            this.textBoxPastEntry2.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxPastEntry2, "The units shipped by Employee 2 entered for each day will be stored here");
            // 
            // textBoxPastEntry3
            // 
            this.textBoxPastEntry3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPastEntry3.Location = new System.Drawing.Point(388, 144);
            this.textBoxPastEntry3.Multiline = true;
            this.textBoxPastEntry3.Name = "textBoxPastEntry3";
            this.textBoxPastEntry3.ReadOnly = true;
            this.textBoxPastEntry3.Size = new System.Drawing.Size(171, 222);
            this.textBoxPastEntry3.TabIndex = 8;
            this.toolTip1.SetToolTip(this.textBoxPastEntry3, "The units shipped by Employee 3 entered for each day will be stored here");
            // 
            // labelAverage1
            // 
            this.labelAverage1.AutoSize = true;
            this.labelAverage1.Location = new System.Drawing.Point(32, 380);
            this.labelAverage1.Name = "labelAverage1";
            this.labelAverage1.Size = new System.Drawing.Size(0, 20);
            this.labelAverage1.TabIndex = 9;
            // 
            // labelOutput2
            // 
            this.labelOutput2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutput2.Location = new System.Drawing.Point(211, 380);
            this.labelOutput2.Name = "labelOutput2";
            this.labelOutput2.Size = new System.Drawing.Size(171, 33);
            this.labelOutput2.TabIndex = 10;
            this.labelOutput2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelOutput2, "Average of units shipped by Employee 2");
            // 
            // labelOutput3
            // 
            this.labelOutput3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutput3.Location = new System.Drawing.Point(388, 380);
            this.labelOutput3.Name = "labelOutput3";
            this.labelOutput3.Size = new System.Drawing.Size(171, 33);
            this.labelOutput3.TabIndex = 11;
            this.labelOutput3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelOutput3, "Average of units shipped by Employee 3");
            // 
            // labelTotalAverage
            // 
            this.labelTotalAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalAverage.Location = new System.Drawing.Point(32, 426);
            this.labelTotalAverage.Name = "labelTotalAverage";
            this.labelTotalAverage.Size = new System.Drawing.Size(527, 34);
            this.labelTotalAverage.TabIndex = 12;
            this.labelTotalAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelTotalAverage, "Total average units shipped by all 3 Employees");
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(32, 19);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(43, 20);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "&Day1";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(32, 487);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(173, 43);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "Enter Button to enter the number of units shipped for each employee");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(211, 487);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(171, 43);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Reset Button to Reset the whole form");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(388, 487);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(171, 43);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.buttonExit, "Exit Button to exit out of the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonCloseClick);
            // 
            // labelOutput1
            // 
            this.labelOutput1.BackColor = System.Drawing.SystemColors.Control;
            this.labelOutput1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutput1.Location = new System.Drawing.Point(32, 380);
            this.labelOutput1.Name = "labelOutput1";
            this.labelOutput1.Size = new System.Drawing.Size(173, 33);
            this.labelOutput1.TabIndex = 9;
            this.labelOutput1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelOutput1, "Average of units shipped by Employee 1");
            // 
            // AverageUnitsShipped
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(599, 585);
            this.Controls.Add(this.labelOutput1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelTotalAverage);
            this.Controls.Add(this.labelOutput3);
            this.Controls.Add(this.labelOutput2);
            this.Controls.Add(this.labelAverage1);
            this.Controls.Add(this.textBoxPastEntry3);
            this.Controls.Add(this.textBoxPastEntry2);
            this.Controls.Add(this.textBoxPastEntry1);
            this.Controls.Add(this.labelEmployee2);
            this.Controls.Add(this.labelEmployee3);
            this.Controls.Add(this.labelEmployee1);
            this.Controls.Add(this.textBoxEntry);
            this.Controls.Add(this.labelUnits);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AverageUnitsShipped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped by Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnits;
        private System.Windows.Forms.TextBox textBoxEntry;
        private System.Windows.Forms.Label labelEmployee1;
        private System.Windows.Forms.Label labelEmployee2;
        private System.Windows.Forms.TextBox textBoxPastEntry1;
        private System.Windows.Forms.TextBox textBoxPastEntry3;
        private System.Windows.Forms.Label labelAverage1;
        private System.Windows.Forms.Label labelOutput2;
        private System.Windows.Forms.Label labelTotalAverage;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelEmployee3;
        private System.Windows.Forms.Label labelOutput1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxPastEntry2;
        private System.Windows.Forms.Label labelOutput3;
    }
}

