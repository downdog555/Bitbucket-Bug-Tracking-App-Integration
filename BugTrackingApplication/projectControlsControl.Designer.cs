namespace BugTrackingApplication
{
    partial class projectControlsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createBugLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // createBugLabel
            // 
            this.createBugLabel.AutoSize = true;
            this.createBugLabel.Location = new System.Drawing.Point(20, 27);
            this.createBugLabel.Name = "createBugLabel";
            this.createBugLabel.Size = new System.Drawing.Size(71, 13);
            this.createBugLabel.TabIndex = 2;
            this.createBugLabel.TabStop = true;
            this.createBugLabel.Text = "Add new Bug";
            // 
            // projectControlsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createBugLabel);
            this.Name = "projectControlsControl";
            this.Size = new System.Drawing.Size(486, 94);
            this.Load += new System.EventHandler(this.projectControlsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel createBugLabel;
    }
}
