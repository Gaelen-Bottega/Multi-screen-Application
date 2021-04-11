
namespace Project_Group3
{
    partial class formAwesomeness
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
            this.labelAwesomenessPrompt = new System.Windows.Forms.Label();
            this.buttonYes = new System.Windows.Forms.Button();
            this.ButtonLeftNo = new System.Windows.Forms.Button();
            this.ButtonRightNo = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelAwesomenessPrompt
            // 
            this.labelAwesomenessPrompt.AutoSize = true;
            this.labelAwesomenessPrompt.Location = new System.Drawing.Point(31, 14);
            this.labelAwesomenessPrompt.Name = "labelAwesomenessPrompt";
            this.labelAwesomenessPrompt.Size = new System.Drawing.Size(343, 40);
            this.labelAwesomenessPrompt.TabIndex = 0;
            this.labelAwesomenessPrompt.Text = ",The computer has detected that you are awesome\r\n?is it possible that you are awe" +
    "some ";
            this.labelAwesomenessPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(29, 72);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(77, 42);
            this.buttonYes.TabIndex = 1;
            this.buttonYes.Text = "&Yes";
            this.toolTip.SetToolTip(this.buttonYes, "CLick here if you are Awesome");
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.ButtonClickYes);
            // 
            // ButtonLeftNo
            // 
            this.ButtonLeftNo.Location = new System.Drawing.Point(142, 72);
            this.ButtonLeftNo.Name = "ButtonLeftNo";
            this.ButtonLeftNo.Size = new System.Drawing.Size(77, 42);
            this.ButtonLeftNo.TabIndex = 2;
            this.ButtonLeftNo.Text = "&No";
            this.toolTip.SetToolTip(this.ButtonLeftNo, "Click here if you are not Awesome");
            this.ButtonLeftNo.UseVisualStyleBackColor = true;
            this.ButtonLeftNo.Click += new System.EventHandler(this.HideLeft);
            this.ButtonLeftNo.MouseEnter += new System.EventHandler(this.HideLeft);
            // 
            // ButtonRightNo
            // 
            this.ButtonRightNo.Location = new System.Drawing.Point(255, 72);
            this.ButtonRightNo.Name = "ButtonRightNo";
            this.ButtonRightNo.Size = new System.Drawing.Size(77, 42);
            this.ButtonRightNo.TabIndex = 3;
            this.ButtonRightNo.Text = "&No";
            this.toolTip.SetToolTip(this.ButtonRightNo, "Click here if you are not Awesome");
            this.ButtonRightNo.UseVisualStyleBackColor = true;
            this.ButtonRightNo.Visible = false;
            this.ButtonRightNo.Click += new System.EventHandler(this.HideRight);
            this.ButtonRightNo.MouseEnter += new System.EventHandler(this.HideRight);
            // 
            // formAwesomeness
            // 
            this.AcceptButton = this.buttonYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 151);
            this.Controls.Add(this.ButtonRightNo);
            this.Controls.Add(this.ButtonLeftNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.labelAwesomenessPrompt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAwesomeness";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Awesomeness Detector";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAwesomenessPrompt;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button ButtonLeftNo;
        private System.Windows.Forms.Button ButtonRightNo;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

