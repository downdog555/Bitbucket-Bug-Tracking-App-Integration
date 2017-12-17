namespace BugTrackingApplication
{
    partial class ViewBugSource
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextPanel = new System.Windows.Forms.Panel();
            this.FileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextPanel
            // 
            this.TextPanel.Location = new System.Drawing.Point(4, 43);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(711, 578);
            this.TextPanel.TabIndex = 0;
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(13, 13);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(35, 13);
            this.FileName.TabIndex = 1;
            this.FileName.Text = "label1";
            // 
            // ViewBugSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 633);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.TextPanel);
            this.Name = "ViewBugSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViewBugSource";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewBugSource_FormClosing);
            this.Load += new System.EventHandler(this.ViewBugSource_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.Label FileName;
    }
}