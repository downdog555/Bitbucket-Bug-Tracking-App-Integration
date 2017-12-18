namespace BugTrackingApplication
{
    partial class CommitMessage
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
            this.commitMes = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.createCommit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commitMes
            // 
            this.commitMes.AutoSize = true;
            this.commitMes.Location = new System.Drawing.Point(12, 9);
            this.commitMes.Name = "commitMes";
            this.commitMes.Size = new System.Drawing.Size(221, 13);
            this.commitMes.TabIndex = 0;
            this.commitMes.Text = "Please Enter Your Message For Your Commit:";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(13, 26);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(259, 183);
            this.messageBox.TabIndex = 1;
            // 
            // createCommit
            // 
            this.createCommit.Location = new System.Drawing.Point(77, 216);
            this.createCommit.Name = "createCommit";
            this.createCommit.Size = new System.Drawing.Size(122, 23);
            this.createCommit.TabIndex = 2;
            this.createCommit.Text = "Create Message";
            this.createCommit.UseVisualStyleBackColor = true;
            this.createCommit.Click += new System.EventHandler(this.createCommit_Click);
            // 
            // CommitMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.createCommit);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.commitMes);
            this.Name = "CommitMessage";
            this.Text = "CommitMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label commitMes;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button createCommit;
    }
}