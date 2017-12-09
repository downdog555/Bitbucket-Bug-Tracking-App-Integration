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
            this.updateBug = new System.Windows.Forms.LinkLabel();
            this.createBugLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // updateBug
            // 
            this.updateBug.AutoSize = true;
            this.updateBug.Location = new System.Drawing.Point(80, 20);
            this.updateBug.Name = "updateBug";
            this.updateBug.Size = new System.Drawing.Size(64, 13);
            this.updateBug.TabIndex = 1;
            this.updateBug.TabStop = true;
            this.updateBug.Text = "Update Bug";
            // 
            // createBugLabel
            // 
            this.createBugLabel.AutoSize = true;
            this.createBugLabel.Location = new System.Drawing.Point(3, 20);
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
            this.Controls.Add(this.updateBug);
            this.Name = "projectControlsControl";
            this.Size = new System.Drawing.Size(486, 94);
            this.Load += new System.EventHandler(this.projectControlsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel updateBug;
        private System.Windows.Forms.LinkLabel createBugLabel;
    }
}
