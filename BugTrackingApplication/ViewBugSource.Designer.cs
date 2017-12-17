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
            this.srcViewer = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // srcViewer
            // 
            this.srcViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srcViewer.Location = new System.Drawing.Point(0, 0);
            this.srcViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.srcViewer.Name = "srcViewer";
            this.srcViewer.Size = new System.Drawing.Size(716, 633);
            this.srcViewer.TabIndex = 0;
            // 
            // ViewBugSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 633);
            this.Controls.Add(this.srcViewer);
            this.Name = "ViewBugSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBugSource";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser srcViewer;
    }
}