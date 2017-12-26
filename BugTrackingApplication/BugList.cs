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
        /// <summary>
        /// Reference to the main window
        /// </summary>
        private MainWindow mw;
        /// <summary>
        /// The project name
        /// </summary>
        private string projectName;
        /// <summary>
        /// The Id of the bug
        /// </summary>
        private int bugId;
        /// <summary>
        /// the project that the control is representitive of
        /// </summary>
        private Project p;
        /// <summary>
        /// the bug that the control is representive of
        /// </summary>
        private Bug b;
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
        /// <param name="p">The projet this bug is a part of</param>
        public BugList(MainWindow mw, Project p, Bug b)
        {
            InitializeComponent();
            this.mw = mw;
            this.p = p;
            this.b = b;
            this.bugTitle.Text = b.Title;
            issueText.Text = b.Issue;
            reportedByText.Text = b.CreatedBy;
            numAuditText.Text = ""+b.Logs.Count;
        }

        /// <summary>
        /// Function is called when link is clicked on this control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void auditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //when link is clicked we need to pass information to the main window
            mw.ViewAuditLogs(b, p);
        }
    }
}
