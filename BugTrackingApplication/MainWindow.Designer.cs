namespace BugTrackingApplication
{
    partial class MainWindow
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
            this.menuBar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bugsBox = new System.Windows.Forms.GroupBox();
            this.bugPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.controlsBox = new System.Windows.Forms.GroupBox();
            this.projectInfoBox = new System.Windows.Forms.GroupBox();
            this.viewBugInformation = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAuditLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeKeyLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Projects = new System.Windows.Forms.GroupBox();
            this.menuBar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.bugsBox.SuspendLayout();
            this.viewBugInformation.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuBar.Controls.Add(this.tabPage1);
            this.menuBar.Controls.Add(this.tabPage2);
            this.menuBar.Controls.Add(this.viewBugInformation);
            this.menuBar.Location = new System.Drawing.Point(12, 27);
            this.menuBar.Name = "menuBar";
            this.menuBar.SelectedIndex = 0;
            this.menuBar.Size = new System.Drawing.Size(785, 482);
            this.menuBar.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Projects);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View All Projects";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bugsBox);
            this.tabPage2.Controls.Add(this.controlsBox);
            this.tabPage2.Controls.Add(this.projectInfoBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View All Bugs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bugsBox
            // 
            this.bugsBox.Controls.Add(this.bugPanel);
            this.bugsBox.Location = new System.Drawing.Point(7, 130);
            this.bugsBox.Name = "bugsBox";
            this.bugsBox.Size = new System.Drawing.Size(764, 310);
            this.bugsBox.TabIndex = 2;
            this.bugsBox.TabStop = false;
            this.bugsBox.Text = "Bugs:";
            // 
            // bugPanel
            // 
            this.bugPanel.Location = new System.Drawing.Point(0, 20);
            this.bugPanel.Name = "bugPanel";
            this.bugPanel.Size = new System.Drawing.Size(764, 284);
            this.bugPanel.TabIndex = 0;
            // 
            // controlsBox
            // 
            this.controlsBox.Location = new System.Drawing.Point(272, 7);
            this.controlsBox.Name = "controlsBox";
            this.controlsBox.Size = new System.Drawing.Size(499, 116);
            this.controlsBox.TabIndex = 1;
            this.controlsBox.TabStop = false;
            this.controlsBox.Text = "Controls";
            // 
            // projectInfoBox
            // 
            this.projectInfoBox.Location = new System.Drawing.Point(7, 7);
            this.projectInfoBox.Name = "projectInfoBox";
            this.projectInfoBox.Size = new System.Drawing.Size(258, 116);
            this.projectInfoBox.TabIndex = 0;
            this.projectInfoBox.TabStop = false;
            this.projectInfoBox.Text = "Project Info";
            // 
            // viewBugInformation
            // 
            this.viewBugInformation.Controls.Add(this.groupBox2);
            this.viewBugInformation.Controls.Add(this.groupBox1);
            this.viewBugInformation.Location = new System.Drawing.Point(4, 22);
            this.viewBugInformation.Name = "viewBugInformation";
            this.viewBugInformation.Padding = new System.Windows.Forms.Padding(3);
            this.viewBugInformation.Size = new System.Drawing.Size(777, 456);
            this.viewBugInformation.TabIndex = 2;
            this.viewBugInformation.Text = "View Bug Information";
            this.viewBugInformation.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(320, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 443);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audit Logs";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 443);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bug Information";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.optionsToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBugToolStripMenuItem,
            this.newAuditLogToolStripMenuItem,
            this.newProjectToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newBugToolStripMenuItem
            // 
            this.newBugToolStripMenuItem.Name = "newBugToolStripMenuItem";
            this.newBugToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newBugToolStripMenuItem.Text = "New Bug";
            // 
            // newAuditLogToolStripMenuItem
            // 
            this.newAuditLogToolStripMenuItem.Name = "newAuditLogToolStripMenuItem";
            this.newAuditLogToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newAuditLogToolStripMenuItem.Text = "New Audit Log";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.optionsToolStripMenuItem1.Text = "Refresh";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeKeyLocationToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // changeKeyLocationToolStripMenuItem
            // 
            this.changeKeyLocationToolStripMenuItem.Name = "changeKeyLocationToolStripMenuItem";
            this.changeKeyLocationToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.changeKeyLocationToolStripMenuItem.Text = "Change Key Location";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Projects
            // 
            this.Projects.Location = new System.Drawing.Point(4, 7);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(767, 446);
            this.Projects.TabIndex = 0;
            this.Projects.TabStop = false;
            this.Projects.Text = "Projects";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 521);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuBar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.bugsBox.ResumeLayout(false);
            this.viewBugInformation.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl menuBar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabPage viewBugInformation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAuditLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox bugsBox;
        private System.Windows.Forms.GroupBox controlsBox;
        private System.Windows.Forms.GroupBox projectInfoBox;
        private System.Windows.Forms.ToolStripMenuItem changeKeyLocationToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel bugPanel;
        private System.Windows.Forms.GroupBox Projects;
    }
}