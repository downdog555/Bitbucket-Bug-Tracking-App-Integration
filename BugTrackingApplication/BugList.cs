using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingApplication
{
    /// <summary>
    /// Usercontrol extended class for displaying the dynamic bug listings
    /// </summary>
    public partial class BugList : UserControl
    {
        private MainWindow mw;
        private string projectName;
        private int bugId;
        /// <summary>
        /// Constructor.
        /// Creates bug list usercontrol
        /// </summary>
        /// <param name="issue">The issue text to be displayed</param>
        /// <param name="reportedBy">Who the issue was first reported by</param>
        /// <param name="numAuditLogs">the number of audit logs avaiable</param>
        /// <param name="projectName">the name of the project</param>
        /// <param name="bugId">The id of the current bug</param>
        /// <param name="mw">The main window reference so we can update it</param>
        public BugList(string issue, string reportedBy, string numAuditLogs, string projectName, int bugId ,MainWindow mw)
        {
            InitializeComponent();
            issueText.Text = issue;
            reportedByText.Text = reportedBy;
            numAuditText.Text = numAuditLogs;
            auditLink.Tag = projectName;
            this.mw = mw;
            this.projectName = projectName;
            this.bugId = bugId;
        }

        private void auditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //when link is clicked we need to pass information to the main window
            mw.ViewAuditLogs(bugId, projectName);
        }
    }
}
