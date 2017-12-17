namespace BugTrackingApplication
{
    partial class UpdateBug
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.bugIssueLabel = new System.Windows.Forms.Label();
            this.classNameLabel = new System.Windows.Forms.Label();
            this.methodLabel = new System.Windows.Forms.Label();
            this.lineNumLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.classData = new System.Windows.Forms.TextBox();
            this.methodBlockData = new System.Windows.Forms.TextBox();
            this.lineNumberBox = new System.Windows.Forms.TextBox();
            this.issueBox = new System.Windows.Forms.RichTextBox();
            this.addBugButton = new System.Windows.Forms.Button();
            this.revsionLabel = new System.Windows.Forms.Label();
            this.revsionBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(25, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // bugIssueLabel
            // 
            this.bugIssueLabel.AutoSize = true;
            this.bugIssueLabel.Location = new System.Drawing.Point(25, 61);
            this.bugIssueLabel.Name = "bugIssueLabel";
            this.bugIssueLabel.Size = new System.Drawing.Size(35, 13);
            this.bugIssueLabel.TabIndex = 1;
            this.bugIssueLabel.Text = "Issue:";
            // 
            // classNameLabel
            // 
            this.classNameLabel.AutoSize = true;
            this.classNameLabel.Location = new System.Drawing.Point(25, 138);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(66, 13);
            this.classNameLabel.TabIndex = 2;
            this.classNameLabel.Text = "Class Name:";
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Location = new System.Drawing.Point(25, 164);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(77, 13);
            this.methodLabel.TabIndex = 3;
            this.methodLabel.Text = "Method Name:";
            // 
            // lineNumLabel
            // 
            this.lineNumLabel.AutoSize = true;
            this.lineNumLabel.Location = new System.Drawing.Point(25, 190);
            this.lineNumLabel.Name = "lineNumLabel";
            this.lineNumLabel.Size = new System.Drawing.Size(70, 13);
            this.lineNumLabel.TabIndex = 4;
            this.lineNumLabel.Text = "Line Number:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(108, 9);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(121, 20);
            this.titleBox.TabIndex = 5;
            // 
            // classData
            // 
            this.classData.Location = new System.Drawing.Point(108, 138);
            this.classData.Name = "classData";
            this.classData.Size = new System.Drawing.Size(121, 20);
            this.classData.TabIndex = 6;
            // 
            // methodBlockData
            // 
            this.methodBlockData.Location = new System.Drawing.Point(108, 164);
            this.methodBlockData.Name = "methodBlockData";
            this.methodBlockData.Size = new System.Drawing.Size(121, 20);
            this.methodBlockData.TabIndex = 7;
            // 
            // lineNumberBox
            // 
            this.lineNumberBox.Location = new System.Drawing.Point(108, 190);
            this.lineNumberBox.Name = "lineNumberBox";
            this.lineNumberBox.Size = new System.Drawing.Size(121, 20);
            this.lineNumberBox.TabIndex = 8;
            // 
            // issueBox
            // 
            this.issueBox.Location = new System.Drawing.Point(108, 61);
            this.issueBox.Name = "issueBox";
            this.issueBox.Size = new System.Drawing.Size(256, 71);
            this.issueBox.TabIndex = 9;
            this.issueBox.Text = "";
            // 
            // addBugButton
            // 
            this.addBugButton.Location = new System.Drawing.Point(108, 239);
            this.addBugButton.Name = "addBugButton";
            this.addBugButton.Size = new System.Drawing.Size(75, 23);
            this.addBugButton.TabIndex = 10;
            this.addBugButton.Text = "Update Bug";
            this.addBugButton.UseVisualStyleBackColor = true;
            this.addBugButton.Click += new System.EventHandler(this.addBugButton_Click);
            // 
            // revsionLabel
            // 
            this.revsionLabel.AutoSize = true;
            this.revsionLabel.Location = new System.Drawing.Point(25, 34);
            this.revsionLabel.Name = "revsionLabel";
            this.revsionLabel.Size = new System.Drawing.Size(49, 13);
            this.revsionLabel.TabIndex = 11;
            this.revsionLabel.Text = "Revsion:";
            // 
            // revsionBox
            // 
            this.revsionBox.FormattingEnabled = true;
            this.revsionBox.Location = new System.Drawing.Point(108, 34);
            this.revsionBox.Name = "revsionBox";
            this.revsionBox.Size = new System.Drawing.Size(121, 21);
            this.revsionBox.TabIndex = 12;
            // 
            // UpdateBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 324);
            this.Controls.Add(this.revsionBox);
            this.Controls.Add(this.revsionLabel);
            this.Controls.Add(this.addBugButton);
            this.Controls.Add(this.issueBox);
            this.Controls.Add(this.lineNumberBox);
            this.Controls.Add(this.methodBlockData);
            this.Controls.Add(this.classData);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.lineNumLabel);
            this.Controls.Add(this.methodLabel);
            this.Controls.Add(this.classNameLabel);
            this.Controls.Add(this.bugIssueLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "UpdateBug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Bug";
            this.Load += new System.EventHandler(this.addBug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label bugIssueLabel;
        private System.Windows.Forms.Label classNameLabel;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.Label lineNumLabel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox classData;
        private System.Windows.Forms.TextBox methodBlockData;
        private System.Windows.Forms.TextBox lineNumberBox;
        private System.Windows.Forms.RichTextBox issueBox;
        private System.Windows.Forms.Button addBugButton;
        private System.Windows.Forms.Label revsionLabel;
        private System.Windows.Forms.ComboBox revsionBox;
    }
}