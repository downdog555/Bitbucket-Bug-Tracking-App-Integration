namespace BugTrackingApplication
{
    partial class AuditLogControl
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
            this.auditlogBox = new System.Windows.Forms.GroupBox();
            this.createdOnText = new System.Windows.Forms.Label();
            this.createdByText = new System.Windows.Forms.Label();
            this.createdOnLabel = new System.Windows.Forms.Label();
            this.createdByLabel = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.RichTextBox();
            this.updatedLabel = new System.Windows.Forms.Label();
            this.updatedOn = new System.Windows.Forms.Label();
            this.auditlogBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // auditlogBox
            // 
            this.auditlogBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.auditlogBox.Controls.Add(this.updatedOn);
            this.auditlogBox.Controls.Add(this.updatedLabel);
            this.auditlogBox.Controls.Add(this.createdOnText);
            this.auditlogBox.Controls.Add(this.createdByText);
            this.auditlogBox.Controls.Add(this.createdOnLabel);
            this.auditlogBox.Controls.Add(this.createdByLabel);
            this.auditlogBox.Controls.Add(this.messageText);
            this.auditlogBox.Location = new System.Drawing.Point(0, 0);
            this.auditlogBox.Name = "auditlogBox";
            this.auditlogBox.Size = new System.Drawing.Size(432, 117);
            this.auditlogBox.TabIndex = 0;
            this.auditlogBox.TabStop = false;
            this.auditlogBox.Text = "groupBox1";
            // 
            // createdOnText
            // 
            this.createdOnText.AutoSize = true;
            this.createdOnText.Location = new System.Drawing.Point(73, 77);
            this.createdOnText.Name = "createdOnText";
            this.createdOnText.Size = new System.Drawing.Size(35, 13);
            this.createdOnText.TabIndex = 4;
            this.createdOnText.Text = "label4";
            // 
            // createdByText
            // 
            this.createdByText.AutoSize = true;
            this.createdByText.Location = new System.Drawing.Point(73, 64);
            this.createdByText.Name = "createdByText";
            this.createdByText.Size = new System.Drawing.Size(35, 13);
            this.createdByText.TabIndex = 3;
            this.createdByText.Text = "label3";
            // 
            // createdOnLabel
            // 
            this.createdOnLabel.AutoSize = true;
            this.createdOnLabel.Location = new System.Drawing.Point(7, 77);
            this.createdOnLabel.Name = "createdOnLabel";
            this.createdOnLabel.Size = new System.Drawing.Size(64, 13);
            this.createdOnLabel.TabIndex = 2;
            this.createdOnLabel.Text = "Created On:";
            // 
            // createdByLabel
            // 
            this.createdByLabel.AutoSize = true;
            this.createdByLabel.Location = new System.Drawing.Point(7, 64);
            this.createdByLabel.Name = "createdByLabel";
            this.createdByLabel.Size = new System.Drawing.Size(62, 13);
            this.createdByLabel.TabIndex = 1;
            this.createdByLabel.Text = "Created By:";
            // 
            // messageText
            // 
            this.messageText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageText.Enabled = false;
            this.messageText.Location = new System.Drawing.Point(7, 20);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(419, 37);
            this.messageText.TabIndex = 0;
            this.messageText.Text = "";
            // 
            // updatedLabel
            // 
            this.updatedLabel.AutoSize = true;
            this.updatedLabel.Location = new System.Drawing.Point(7, 90);
            this.updatedLabel.Name = "updatedLabel";
            this.updatedLabel.Size = new System.Drawing.Size(68, 13);
            this.updatedLabel.TabIndex = 5;
            this.updatedLabel.Text = "Updated On:";
            // 
            // updatedOn
            // 
            this.updatedOn.AutoSize = true;
            this.updatedOn.Location = new System.Drawing.Point(73, 90);
            this.updatedOn.Name = "updatedOn";
            this.updatedOn.Size = new System.Drawing.Size(35, 13);
            this.updatedOn.TabIndex = 6;
            this.updatedOn.Text = "label4";
            // 
            // AuditLogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.auditlogBox);
            this.Name = "AuditLogControl";
            this.Size = new System.Drawing.Size(435, 116);
            this.auditlogBox.ResumeLayout(false);
            this.auditlogBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox auditlogBox;
        private System.Windows.Forms.Label createdOnText;
        private System.Windows.Forms.Label createdByText;
        private System.Windows.Forms.Label createdOnLabel;
        private System.Windows.Forms.Label createdByLabel;
        private System.Windows.Forms.RichTextBox messageText;
        private System.Windows.Forms.Label updatedOn;
        private System.Windows.Forms.Label updatedLabel;
    }
}
