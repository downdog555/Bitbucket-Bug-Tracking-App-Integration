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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commitFileToRepositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileLocallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.methodBlock = new System.Windows.Forms.Label();
            this.lineNumber = new System.Windows.Forms.Label();
            this.classNameLabel = new System.Windows.Forms.Label();
            this.methodLabel = new System.Windows.Forms.Label();
            this.lineNumLabel = new System.Windows.Forms.Label();
            this.lineNumEndLabel = new System.Windows.Forms.Label();
            this.lineNumEnd = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
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
            this.FileName.Location = new System.Drawing.Point(127, 27);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(35, 13);
            this.FileName.TabIndex = 1;
            this.FileName.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commitFileToRepositoryToolStripMenuItem,
            this.saveFileLocallyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // commitFileToRepositoryToolStripMenuItem
            // 
            this.commitFileToRepositoryToolStripMenuItem.Name = "commitFileToRepositoryToolStripMenuItem";
            this.commitFileToRepositoryToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.commitFileToRepositoryToolStripMenuItem.Text = "Commit File To Repository";
            this.commitFileToRepositoryToolStripMenuItem.Click += new System.EventHandler(this.commitFileToRepositoryToolStripMenuItem_Click);
            // 
            // saveFileLocallyToolStripMenuItem
            // 
            this.saveFileLocallyToolStripMenuItem.Name = "saveFileLocallyToolStripMenuItem";
            this.saveFileLocallyToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.saveFileLocallyToolStripMenuItem.Text = "Save File Locally";
            this.saveFileLocallyToolStripMenuItem.Click += new System.EventHandler(this.saveFileLocallyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // methodBlock
            // 
            this.methodBlock.AutoSize = true;
            this.methodBlock.Location = new System.Drawing.Point(319, 27);
            this.methodBlock.Name = "methodBlock";
            this.methodBlock.Size = new System.Drawing.Size(35, 13);
            this.methodBlock.TabIndex = 3;
            this.methodBlock.Text = "label1";
            // 
            // lineNumber
            // 
            this.lineNumber.AutoSize = true;
            this.lineNumber.Location = new System.Drawing.Point(458, 27);
            this.lineNumber.Name = "lineNumber";
            this.lineNumber.Size = new System.Drawing.Size(35, 13);
            this.lineNumber.TabIndex = 4;
            this.lineNumber.Text = "label1";
            // 
            // classNameLabel
            // 
            this.classNameLabel.AutoSize = true;
            this.classNameLabel.Location = new System.Drawing.Point(6, 27);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(115, 13);
            this.classNameLabel.TabIndex = 5;
            this.classNameLabel.Text = "Class Name/FileName:";
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Location = new System.Drawing.Point(237, 27);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(76, 13);
            this.methodLabel.TabIndex = 4;
            this.methodLabel.Text = "Method Block:";
            // 
            // lineNumLabel
            // 
            this.lineNumLabel.AutoSize = true;
            this.lineNumLabel.Location = new System.Drawing.Point(382, 27);
            this.lineNumLabel.Name = "lineNumLabel";
            this.lineNumLabel.Size = new System.Drawing.Size(70, 13);
            this.lineNumLabel.TabIndex = 6;
            this.lineNumLabel.Text = "Line Number:";
            // 
            // lineNumEndLabel
            // 
            this.lineNumEndLabel.AutoSize = true;
            this.lineNumEndLabel.Location = new System.Drawing.Point(521, 27);
            this.lineNumEndLabel.Name = "lineNumEndLabel";
            this.lineNumEndLabel.Size = new System.Drawing.Size(92, 13);
            this.lineNumEndLabel.TabIndex = 8;
            this.lineNumEndLabel.Text = "Line Number End:";
            // 
            // lineNumEnd
            // 
            this.lineNumEnd.AutoSize = true;
            this.lineNumEnd.Location = new System.Drawing.Point(619, 27);
            this.lineNumEnd.Name = "lineNumEnd";
            this.lineNumEnd.Size = new System.Drawing.Size(35, 13);
            this.lineNumEnd.TabIndex = 7;
            this.lineNumEnd.Text = "label1";
            // 
            // ViewBugSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 633);
            this.Controls.Add(this.lineNumEndLabel);
            this.Controls.Add(this.lineNumEnd);
            this.Controls.Add(this.lineNumLabel);
            this.Controls.Add(this.methodBlock);
            this.Controls.Add(this.methodLabel);
            this.Controls.Add(this.classNameLabel);
            this.Controls.Add(this.lineNumber);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.TextPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewBugSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViewBugSource";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewBugSource_FormClosing);
            this.Load += new System.EventHandler(this.ViewBugSource_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commitFileToRepositoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileLocallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label methodBlock;
        private System.Windows.Forms.Label lineNumber;
        private System.Windows.Forms.Label classNameLabel;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.Label lineNumLabel;
        private System.Windows.Forms.Label lineNumEndLabel;
        private System.Windows.Forms.Label lineNumEnd;
    }
}