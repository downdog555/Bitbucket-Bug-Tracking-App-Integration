﻿namespace BugTrackingApplication
{
    partial class ProjectControl
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
            this.ProjectName = new System.Windows.Forms.GroupBox();
            this.projectOwnerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.branchSelectorBox = new System.Windows.Forms.ComboBox();
            this.branchSelector = new System.Windows.Forms.Label();
            this.projectOwnerText = new System.Windows.Forms.Label();
            this.projectURLText = new System.Windows.Forms.Label();
            this.viewBugsLink = new System.Windows.Forms.LinkLabel();
            this.ProjectName.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectName
            // 
            this.ProjectName.Controls.Add(this.viewBugsLink);
            this.ProjectName.Controls.Add(this.projectURLText);
            this.ProjectName.Controls.Add(this.projectOwnerText);
            this.ProjectName.Controls.Add(this.branchSelector);
            this.ProjectName.Controls.Add(this.branchSelectorBox);
            this.ProjectName.Controls.Add(this.label2);
            this.ProjectName.Controls.Add(this.projectOwnerLabel);
            this.ProjectName.Location = new System.Drawing.Point(4, 4);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(693, 93);
            this.ProjectName.TabIndex = 0;
            this.ProjectName.TabStop = false;
            this.ProjectName.Text = "ProjectName";
            this.ProjectName.Enter += new System.EventHandler(this.ProjectName_Enter);
            // 
            // projectOwnerLabel
            // 
            this.projectOwnerLabel.AutoSize = true;
            this.projectOwnerLabel.Location = new System.Drawing.Point(7, 20);
            this.projectOwnerLabel.Name = "projectOwnerLabel";
            this.projectOwnerLabel.Size = new System.Drawing.Size(38, 13);
            this.projectOwnerLabel.TabIndex = 0;
            this.projectOwnerLabel.Text = "Owner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Repository URL";
            // 
            // branchSelectorBox
            // 
            this.branchSelectorBox.FormattingEnabled = true;
            this.branchSelectorBox.Location = new System.Drawing.Point(96, 47);
            this.branchSelectorBox.Name = "branchSelectorBox";
            this.branchSelectorBox.Size = new System.Drawing.Size(121, 21);
            this.branchSelectorBox.TabIndex = 2;
            // 
            // branchSelector
            // 
            this.branchSelector.AutoSize = true;
            this.branchSelector.Location = new System.Drawing.Point(7, 50);
            this.branchSelector.Name = "branchSelector";
            this.branchSelector.Size = new System.Drawing.Size(83, 13);
            this.branchSelector.TabIndex = 3;
            this.branchSelector.Text = "Branch Selector";
            // 
            // projectOwnerText
            // 
            this.projectOwnerText.AutoSize = true;
            this.projectOwnerText.Location = new System.Drawing.Point(93, 20);
            this.projectOwnerText.Name = "projectOwnerText";
            this.projectOwnerText.Size = new System.Drawing.Size(35, 13);
            this.projectOwnerText.TabIndex = 4;
            this.projectOwnerText.Text = "label4";
            // 
            // projectURLText
            // 
            this.projectURLText.AutoSize = true;
            this.projectURLText.Location = new System.Drawing.Point(93, 33);
            this.projectURLText.Name = "projectURLText";
            this.projectURLText.Size = new System.Drawing.Size(35, 13);
            this.projectURLText.TabIndex = 5;
            this.projectURLText.Text = "label4";
            // 
            // viewBugsLink
            // 
            this.viewBugsLink.AutoSize = true;
            this.viewBugsLink.Location = new System.Drawing.Point(630, 55);
            this.viewBugsLink.Name = "viewBugsLink";
            this.viewBugsLink.Size = new System.Drawing.Size(57, 13);
            this.viewBugsLink.TabIndex = 6;
            this.viewBugsLink.TabStop = true;
            this.viewBugsLink.Text = "View Bugs";
            this.viewBugsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewBugsLink_LinkClicked);
            // 
            // ProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProjectName);
            this.Name = "ProjectControl";
            this.Size = new System.Drawing.Size(700, 100);
            this.ProjectName.ResumeLayout(false);
            this.ProjectName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProjectName;
        private System.Windows.Forms.Label projectURLText;
        private System.Windows.Forms.Label projectOwnerText;
        private System.Windows.Forms.Label branchSelector;
        private System.Windows.Forms.ComboBox branchSelectorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label projectOwnerLabel;
        private System.Windows.Forms.LinkLabel viewBugsLink;
    }
}