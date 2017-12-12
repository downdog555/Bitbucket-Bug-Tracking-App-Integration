namespace BugTrackingApplication
{
    partial class AddAuditLog
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
            this.auditLabel = new System.Windows.Forms.Label();
            this.auditLogAdd = new System.Windows.Forms.Button();
            this.auditLogText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // auditLabel
            // 
            this.auditLabel.AutoSize = true;
            this.auditLabel.Location = new System.Drawing.Point(12, 33);
            this.auditLabel.Name = "auditLabel";
            this.auditLabel.Size = new System.Drawing.Size(156, 13);
            this.auditLabel.TabIndex = 0;
            this.auditLabel.Text = "Please enter log messag below:";
            // 
            // auditLogAdd
            // 
            this.auditLogAdd.Location = new System.Drawing.Point(78, 226);
            this.auditLogAdd.Name = "auditLogAdd";
            this.auditLogAdd.Size = new System.Drawing.Size(108, 23);
            this.auditLogAdd.TabIndex = 1;
            this.auditLogAdd.Text = "Add Audit Log";
            this.auditLogAdd.UseVisualStyleBackColor = true;
            this.auditLogAdd.Click += new System.EventHandler(this.auditLogAdd_Click);
            // 
            // auditLogText
            // 
            this.auditLogText.Location = new System.Drawing.Point(15, 49);
            this.auditLogText.Name = "auditLogText";
            this.auditLogText.Size = new System.Drawing.Size(257, 171);
            this.auditLogText.TabIndex = 2;
            this.auditLogText.Text = "";
            // 
            // AddAuditLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.auditLogText);
            this.Controls.Add(this.auditLogAdd);
            this.Controls.Add(this.auditLabel);
            this.Name = "AddAuditLog";
            this.Text = "AddAuditLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label auditLabel;
        private System.Windows.Forms.Button auditLogAdd;
        private System.Windows.Forms.RichTextBox auditLogText;
    }
}