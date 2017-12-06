namespace BugTrackingApplication
{
    partial class BugList
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
            this.bugTitle = new System.Windows.Forms.GroupBox();
            this.issueLabel = new System.Windows.Forms.Label();
            this.numOfAuditLogsLabel = new System.Windows.Forms.Label();
            this.reportedByLabel = new System.Windows.Forms.Label();
            this.auditLink = new System.Windows.Forms.LinkLabel();
            this.reportedByText = new System.Windows.Forms.Label();
            this.numAuditText = new System.Windows.Forms.Label();
            this.issueText = new System.Windows.Forms.Label();
            this.bugTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // bugTitle
            // 
            this.bugTitle.Controls.Add(this.issueText);
            this.bugTitle.Controls.Add(this.numAuditText);
            this.bugTitle.Controls.Add(this.reportedByText);
            this.bugTitle.Controls.Add(this.auditLink);
            this.bugTitle.Controls.Add(this.reportedByLabel);
            this.bugTitle.Controls.Add(this.numOfAuditLogsLabel);
            this.bugTitle.Controls.Add(this.issueLabel);
            this.bugTitle.Location = new System.Drawing.Point(3, 3);
            this.bugTitle.Name = "bugTitle";
            this.bugTitle.Size = new System.Drawing.Size(748, 68);
            this.bugTitle.TabIndex = 0;
            this.bugTitle.TabStop = false;
            this.bugTitle.Text = "groupBox1";
            // 
            // issueLabel
            // 
            this.issueLabel.AutoSize = true;
            this.issueLabel.Location = new System.Drawing.Point(6, 16);
            this.issueLabel.Name = "issueLabel";
            this.issueLabel.Size = new System.Drawing.Size(35, 13);
            this.issueLabel.TabIndex = 0;
            this.issueLabel.Text = "Issue:";
            // 
            // numOfAuditLogsLabel
            // 
            this.numOfAuditLogsLabel.AutoSize = true;
            this.numOfAuditLogsLabel.Location = new System.Drawing.Point(6, 42);
            this.numOfAuditLogsLabel.Name = "numOfAuditLogsLabel";
            this.numOfAuditLogsLabel.Size = new System.Drawing.Size(114, 13);
            this.numOfAuditLogsLabel.TabIndex = 1;
            this.numOfAuditLogsLabel.Text = "Number Of Audit Logs:";
            // 
            // reportedByLabel
            // 
            this.reportedByLabel.AutoSize = true;
            this.reportedByLabel.Location = new System.Drawing.Point(6, 29);
            this.reportedByLabel.Name = "reportedByLabel";
            this.reportedByLabel.Size = new System.Drawing.Size(69, 13);
            this.reportedByLabel.TabIndex = 2;
            this.reportedByLabel.Text = "Reported By:";
            // 
            // auditLink
            // 
            this.auditLink.AutoSize = true;
            this.auditLink.Location = new System.Drawing.Point(659, 42);
            this.auditLink.Name = "auditLink";
            this.auditLink.Size = new System.Drawing.Size(83, 13);
            this.auditLink.TabIndex = 3;
            this.auditLink.TabStop = true;
            this.auditLink.Text = "View Audit Logs";
            this.auditLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.auditLink_LinkClicked);
            // 
            // reportedByText
            // 
            this.reportedByText.AutoSize = true;
            this.reportedByText.Location = new System.Drawing.Point(125, 29);
            this.reportedByText.Name = "reportedByText";
            this.reportedByText.Size = new System.Drawing.Size(63, 13);
            this.reportedByText.TabIndex = 4;
            this.reportedByText.Text = "reportedtext";
            // 
            // numAuditText
            // 
            this.numAuditText.AutoSize = true;
            this.numAuditText.Location = new System.Drawing.Point(126, 42);
            this.numAuditText.Name = "numAuditText";
            this.numAuditText.Size = new System.Drawing.Size(67, 13);
            this.numAuditText.TabIndex = 5;
            this.numAuditText.Text = "numaudittext";
            // 
            // issueText
            // 
            this.issueText.AutoSize = true;
            this.issueText.Location = new System.Drawing.Point(125, 16);
            this.issueText.Name = "issueText";
            this.issueText.Size = new System.Drawing.Size(48, 13);
            this.issueText.TabIndex = 6;
            this.issueText.Text = "issuetext";
            // 
            // BugList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bugTitle);
            this.Name = "BugList";
            this.Size = new System.Drawing.Size(754, 74);
            this.bugTitle.ResumeLayout(false);
            this.bugTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bugTitle;
        private System.Windows.Forms.Label reportedByLabel;
        private System.Windows.Forms.Label numOfAuditLogsLabel;
        private System.Windows.Forms.Label issueLabel;
        private System.Windows.Forms.Label issueText;
        private System.Windows.Forms.Label numAuditText;
        private System.Windows.Forms.Label reportedByText;
        private System.Windows.Forms.LinkLabel auditLink;
    }
}
