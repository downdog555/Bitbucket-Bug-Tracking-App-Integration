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
            this.viewBugInformation = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.auditLogPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editBug = new System.Windows.Forms.LinkLabel();
            this.bugStatusText = new System.Windows.Forms.Label();
            this.bugStatusLabel = new System.Windows.Forms.Label();
            this.closeBug = new System.Windows.Forms.LinkLabel();
            this.newAuditLogLink = new System.Windows.Forms.LinkLabel();
            this.assignedToText = new System.Windows.Forms.Label();
            this.assignedLabel = new System.Windows.Forms.Label();
            this.assignBugLink = new System.Windows.Forms.LinkLabel();
            this.viewSourceLabel = new System.Windows.Forms.LinkLabel();
            this.className = new System.Windows.Forms.Label();
            this.lineNumber = new System.Windows.Forms.Label();
            this.lastUpdated = new System.Windows.Forms.Label();
            this.reportedBy = new System.Windows.Forms.Label();
            this.methodBlock = new System.Windows.Forms.Label();
            this.timeCreatedLabel = new System.Windows.Forms.Label();
            this.reportedByLabel = new System.Windows.Forms.Label();
            this.lineNumLabel = new System.Windows.Forms.Label();
            this.methodLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.bugIssueBox = new System.Windows.Forms.RichTextBox();
            this.bugIssue = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bugsBox = new System.Windows.Forms.GroupBox();
            this.bugPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.controlsBox = new System.Windows.Forms.GroupBox();
            this.createNewBug = new System.Windows.Forms.LinkLabel();
            this.projectInfoBox = new System.Windows.Forms.GroupBox();
            this.projectTitle = new System.Windows.Forms.Label();
            this.projectOwner = new System.Windows.Forms.Label();
            this.projectOwnerLabel = new System.Windows.Forms.Label();
            this.projectTitleLabel = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Projects = new System.Windows.Forms.GroupBox();
            this.menuBar = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.lineNumEnd = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.viewBugInformation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.bugsBox.SuspendLayout();
            this.controlsBox.SuspendLayout();
            this.projectInfoBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.auditLogPanel);
            this.groupBox2.Location = new System.Drawing.Point(320, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 443);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audit Logs";
            // 
            // auditLogPanel
            // 
            this.auditLogPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.auditLogPanel.AutoScroll = true;
            this.auditLogPanel.Location = new System.Drawing.Point(7, 20);
            this.auditLogPanel.Name = "auditLogPanel";
            this.auditLogPanel.Size = new System.Drawing.Size(438, 417);
            this.auditLogPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lineNumEnd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.editBug);
            this.groupBox1.Controls.Add(this.bugStatusText);
            this.groupBox1.Controls.Add(this.bugStatusLabel);
            this.groupBox1.Controls.Add(this.closeBug);
            this.groupBox1.Controls.Add(this.newAuditLogLink);
            this.groupBox1.Controls.Add(this.assignedToText);
            this.groupBox1.Controls.Add(this.assignedLabel);
            this.groupBox1.Controls.Add(this.assignBugLink);
            this.groupBox1.Controls.Add(this.viewSourceLabel);
            this.groupBox1.Controls.Add(this.className);
            this.groupBox1.Controls.Add(this.lineNumber);
            this.groupBox1.Controls.Add(this.lastUpdated);
            this.groupBox1.Controls.Add(this.reportedBy);
            this.groupBox1.Controls.Add(this.methodBlock);
            this.groupBox1.Controls.Add(this.timeCreatedLabel);
            this.groupBox1.Controls.Add(this.reportedByLabel);
            this.groupBox1.Controls.Add(this.lineNumLabel);
            this.groupBox1.Controls.Add(this.methodLabel);
            this.groupBox1.Controls.Add(this.classLabel);
            this.groupBox1.Controls.Add(this.bugIssueBox);
            this.groupBox1.Controls.Add(this.bugIssue);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 443);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bug Information";
            // 
            // editBug
            // 
            this.editBug.AutoSize = true;
            this.editBug.Location = new System.Drawing.Point(199, 326);
            this.editBug.Name = "editBug";
            this.editBug.Size = new System.Drawing.Size(102, 13);
            this.editBug.TabIndex = 20;
            this.editBug.TabStop = true;
            this.editBug.Text = "Edit Bug Information";
            this.editBug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editBug_LinkClicked);
            // 
            // bugStatusText
            // 
            this.bugStatusText.AutoSize = true;
            this.bugStatusText.Location = new System.Drawing.Point(87, 425);
            this.bugStatusText.Name = "bugStatusText";
            this.bugStatusText.Size = new System.Drawing.Size(35, 13);
            this.bugStatusText.TabIndex = 19;
            this.bugStatusText.Text = "meow";
            // 
            // bugStatusLabel
            // 
            this.bugStatusLabel.AutoSize = true;
            this.bugStatusLabel.Location = new System.Drawing.Point(10, 425);
            this.bugStatusLabel.Name = "bugStatusLabel";
            this.bugStatusLabel.Size = new System.Drawing.Size(62, 13);
            this.bugStatusLabel.TabIndex = 18;
            this.bugStatusLabel.Text = "Bug Status:";
            // 
            // closeBug
            // 
            this.closeBug.AutoSize = true;
            this.closeBug.Location = new System.Drawing.Point(246, 427);
            this.closeBug.Name = "closeBug";
            this.closeBug.Size = new System.Drawing.Size(55, 13);
            this.closeBug.TabIndex = 17;
            this.closeBug.TabStop = true;
            this.closeBug.Text = "Close Bug";
            this.closeBug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.closeBug_LinkClicked);
            // 
            // newAuditLogLink
            // 
            this.newAuditLogLink.AutoSize = true;
            this.newAuditLogLink.Location = new System.Drawing.Point(190, 16);
            this.newAuditLogLink.Name = "newAuditLogLink";
            this.newAuditLogLink.Size = new System.Drawing.Size(111, 13);
            this.newAuditLogLink.TabIndex = 16;
            this.newAuditLogLink.TabStop = true;
            this.newAuditLogLink.Text = "Create New Audit Log";
            this.newAuditLogLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newAuditLogLink_LinkClicked);
            // 
            // assignedToText
            // 
            this.assignedToText.AutoSize = true;
            this.assignedToText.Location = new System.Drawing.Point(87, 412);
            this.assignedToText.Name = "assignedToText";
            this.assignedToText.Size = new System.Drawing.Size(29, 13);
            this.assignedToText.TabIndex = 15;
            this.assignedToText.Text = "label";
            // 
            // assignedLabel
            // 
            this.assignedLabel.AutoSize = true;
            this.assignedLabel.Location = new System.Drawing.Point(10, 412);
            this.assignedLabel.Name = "assignedLabel";
            this.assignedLabel.Size = new System.Drawing.Size(69, 13);
            this.assignedLabel.TabIndex = 14;
            this.assignedLabel.Text = "Assigned To:";
            // 
            // assignBugLink
            // 
            this.assignBugLink.AutoSize = true;
            this.assignBugLink.Location = new System.Drawing.Point(207, 412);
            this.assignBugLink.Name = "assignBugLink";
            this.assignBugLink.Size = new System.Drawing.Size(94, 13);
            this.assignBugLink.TabIndex = 13;
            this.assignBugLink.TabStop = true;
            this.assignBugLink.Text = "Assign Bug To Me";
            this.assignBugLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.assignBugLink_LinkClicked);
            // 
            // viewSourceLabel
            // 
            this.viewSourceLabel.AutoSize = true;
            this.viewSourceLabel.Location = new System.Drawing.Point(212, 339);
            this.viewSourceLabel.Name = "viewSourceLabel";
            this.viewSourceLabel.Size = new System.Drawing.Size(89, 13);
            this.viewSourceLabel.TabIndex = 12;
            this.viewSourceLabel.TabStop = true;
            this.viewSourceLabel.Text = "View Bug Source";
            this.viewSourceLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewSourceLabel_LinkClicked);
            // 
            // className
            // 
            this.className.AutoSize = true;
            this.className.Location = new System.Drawing.Point(87, 313);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(35, 13);
            this.className.TabIndex = 11;
            this.className.Text = "label5";
            // 
            // lineNumber
            // 
            this.lineNumber.AutoSize = true;
            this.lineNumber.Location = new System.Drawing.Point(87, 339);
            this.lineNumber.Name = "lineNumber";
            this.lineNumber.Size = new System.Drawing.Size(35, 13);
            this.lineNumber.TabIndex = 10;
            this.lineNumber.Text = "label4";
            // 
            // lastUpdated
            // 
            this.lastUpdated.AutoSize = true;
            this.lastUpdated.Location = new System.Drawing.Point(87, 387);
            this.lastUpdated.Name = "lastUpdated";
            this.lastUpdated.Size = new System.Drawing.Size(35, 13);
            this.lastUpdated.TabIndex = 9;
            this.lastUpdated.Text = "label3";
            // 
            // reportedBy
            // 
            this.reportedBy.AutoSize = true;
            this.reportedBy.Location = new System.Drawing.Point(87, 374);
            this.reportedBy.Name = "reportedBy";
            this.reportedBy.Size = new System.Drawing.Size(35, 13);
            this.reportedBy.TabIndex = 8;
            this.reportedBy.Text = "label2";
            // 
            // methodBlock
            // 
            this.methodBlock.AutoSize = true;
            this.methodBlock.Location = new System.Drawing.Point(87, 326);
            this.methodBlock.Name = "methodBlock";
            this.methodBlock.Size = new System.Drawing.Size(35, 13);
            this.methodBlock.TabIndex = 7;
            this.methodBlock.Text = "label1";
            // 
            // timeCreatedLabel
            // 
            this.timeCreatedLabel.AutoSize = true;
            this.timeCreatedLabel.Location = new System.Drawing.Point(10, 387);
            this.timeCreatedLabel.Name = "timeCreatedLabel";
            this.timeCreatedLabel.Size = new System.Drawing.Size(74, 13);
            this.timeCreatedLabel.TabIndex = 6;
            this.timeCreatedLabel.Text = "Last Updated:";
            // 
            // reportedByLabel
            // 
            this.reportedByLabel.AutoSize = true;
            this.reportedByLabel.Location = new System.Drawing.Point(10, 374);
            this.reportedByLabel.Name = "reportedByLabel";
            this.reportedByLabel.Size = new System.Drawing.Size(69, 13);
            this.reportedByLabel.TabIndex = 5;
            this.reportedByLabel.Text = "Reported By:";
            // 
            // lineNumLabel
            // 
            this.lineNumLabel.AutoSize = true;
            this.lineNumLabel.Location = new System.Drawing.Point(10, 339);
            this.lineNumLabel.Name = "lineNumLabel";
            this.lineNumLabel.Size = new System.Drawing.Size(70, 13);
            this.lineNumLabel.TabIndex = 4;
            this.lineNumLabel.Text = "Line Number:";
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Location = new System.Drawing.Point(10, 326);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(76, 13);
            this.methodLabel.TabIndex = 3;
            this.methodLabel.Text = "Method Block:";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(10, 313);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(66, 13);
            this.classLabel.TabIndex = 2;
            this.classLabel.Text = "Class Name:";
            // 
            // bugIssueBox
            // 
            this.bugIssueBox.Enabled = false;
            this.bugIssueBox.Location = new System.Drawing.Point(7, 37);
            this.bugIssueBox.Name = "bugIssueBox";
            this.bugIssueBox.Size = new System.Drawing.Size(294, 269);
            this.bugIssueBox.TabIndex = 1;
            this.bugIssueBox.Text = "";
            // 
            // bugIssue
            // 
            this.bugIssue.AutoSize = true;
            this.bugIssue.Location = new System.Drawing.Point(7, 20);
            this.bugIssue.Name = "bugIssue";
            this.bugIssue.Size = new System.Drawing.Size(57, 13);
            this.bugIssue.TabIndex = 0;
            this.bugIssue.Text = "Bug Issue:";
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
            this.bugsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.bugPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bugPanel.AutoScroll = true;
            this.bugPanel.Location = new System.Drawing.Point(0, 20);
            this.bugPanel.Name = "bugPanel";
            this.bugPanel.Size = new System.Drawing.Size(764, 284);
            this.bugPanel.TabIndex = 0;
            // 
            // controlsBox
            // 
            this.controlsBox.Controls.Add(this.createNewBug);
            this.controlsBox.Location = new System.Drawing.Point(272, 7);
            this.controlsBox.Name = "controlsBox";
            this.controlsBox.Size = new System.Drawing.Size(499, 116);
            this.controlsBox.TabIndex = 1;
            this.controlsBox.TabStop = false;
            this.controlsBox.Text = "Controls";
            // 
            // createNewBug
            // 
            this.createNewBug.AutoSize = true;
            this.createNewBug.Location = new System.Drawing.Point(7, 15);
            this.createNewBug.Name = "createNewBug";
            this.createNewBug.Size = new System.Drawing.Size(85, 13);
            this.createNewBug.TabIndex = 0;
            this.createNewBug.TabStop = true;
            this.createNewBug.Text = "Create New Bug";
            this.createNewBug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewBug_LinkClicked);
            // 
            // projectInfoBox
            // 
            this.projectInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectInfoBox.Controls.Add(this.projectTitle);
            this.projectInfoBox.Controls.Add(this.projectOwner);
            this.projectInfoBox.Controls.Add(this.projectOwnerLabel);
            this.projectInfoBox.Controls.Add(this.projectTitleLabel);
            this.projectInfoBox.Location = new System.Drawing.Point(7, 7);
            this.projectInfoBox.Name = "projectInfoBox";
            this.projectInfoBox.Size = new System.Drawing.Size(258, 116);
            this.projectInfoBox.TabIndex = 0;
            this.projectInfoBox.TabStop = false;
            this.projectInfoBox.Text = "Project Info";
            // 
            // projectTitle
            // 
            this.projectTitle.AutoSize = true;
            this.projectTitle.Location = new System.Drawing.Point(89, 16);
            this.projectTitle.Name = "projectTitle";
            this.projectTitle.Size = new System.Drawing.Size(35, 13);
            this.projectTitle.TabIndex = 3;
            this.projectTitle.Text = "label2";
            // 
            // projectOwner
            // 
            this.projectOwner.AutoSize = true;
            this.projectOwner.Location = new System.Drawing.Point(89, 29);
            this.projectOwner.Name = "projectOwner";
            this.projectOwner.Size = new System.Drawing.Size(35, 13);
            this.projectOwner.TabIndex = 2;
            this.projectOwner.Text = "label1";
            // 
            // projectOwnerLabel
            // 
            this.projectOwnerLabel.AutoSize = true;
            this.projectOwnerLabel.Location = new System.Drawing.Point(6, 29);
            this.projectOwnerLabel.Name = "projectOwnerLabel";
            this.projectOwnerLabel.Size = new System.Drawing.Size(77, 13);
            this.projectOwnerLabel.TabIndex = 1;
            this.projectOwnerLabel.Text = "Project Owner:";
            // 
            // projectTitleLabel
            // 
            this.projectTitleLabel.AutoSize = true;
            this.projectTitleLabel.Location = new System.Drawing.Point(6, 16);
            this.projectTitleLabel.Name = "projectTitleLabel";
            this.projectTitleLabel.Size = new System.Drawing.Size(66, 13);
            this.projectTitleLabel.TabIndex = 0;
            this.projectTitleLabel.Text = "Project Title:";
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
            // Projects
            // 
            this.Projects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Projects.Location = new System.Drawing.Point(4, 7);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(767, 446);
            this.Projects.TabIndex = 0;
            this.Projects.TabStop = false;
            this.Projects.Text = "Projects";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Line Num End:";
            // 
            // lineNumEnd
            // 
            this.lineNumEnd.AutoSize = true;
            this.lineNumEnd.Location = new System.Drawing.Point(87, 352);
            this.lineNumEnd.Name = "lineNumEnd";
            this.lineNumEnd.Size = new System.Drawing.Size(64, 13);
            this.lineNumEnd.TabIndex = 22;
            this.lineNumEnd.Text = "lineNumEnd";
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.viewBugInformation.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.bugsBox.ResumeLayout(false);
            this.controlsBox.ResumeLayout(false);
            this.controlsBox.PerformLayout();
            this.projectInfoBox.ResumeLayout(false);
            this.projectInfoBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAuditLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeKeyLocationToolStripMenuItem;
        private System.Windows.Forms.TabPage viewBugInformation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel viewSourceLabel;
        private System.Windows.Forms.Label className;
        private System.Windows.Forms.Label lineNumber;
        private System.Windows.Forms.Label lastUpdated;
        private System.Windows.Forms.Label reportedBy;
        private System.Windows.Forms.Label methodBlock;
        private System.Windows.Forms.Label timeCreatedLabel;
        private System.Windows.Forms.Label reportedByLabel;
        private System.Windows.Forms.Label lineNumLabel;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.RichTextBox bugIssueBox;
        private System.Windows.Forms.Label bugIssue;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox bugsBox;
        private System.Windows.Forms.FlowLayoutPanel bugPanel;
        private System.Windows.Forms.GroupBox controlsBox;
        private System.Windows.Forms.GroupBox projectInfoBox;
        private System.Windows.Forms.Label projectTitle;
        private System.Windows.Forms.Label projectOwner;
        private System.Windows.Forms.Label projectOwnerLabel;
        private System.Windows.Forms.Label projectTitleLabel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox Projects;
        private System.Windows.Forms.TabControl menuBar;
        private System.Windows.Forms.Label assignedLabel;
        private System.Windows.Forms.LinkLabel assignBugLink;
        private System.Windows.Forms.Label assignedToText;
        private System.Windows.Forms.LinkLabel createNewBug;
        private System.Windows.Forms.LinkLabel newAuditLogLink;
        private System.Windows.Forms.LinkLabel closeBug;
        private System.Windows.Forms.Label bugStatusText;
        private System.Windows.Forms.Label bugStatusLabel;
        private System.Windows.Forms.FlowLayoutPanel auditLogPanel;
        private System.Windows.Forms.LinkLabel editBug;
        private System.Windows.Forms.Label lineNumEnd;
        private System.Windows.Forms.Label label1;
    }
}