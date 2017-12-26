using SharpBucket.V1.EndPoints;
using SharpBucket.V1.Pocos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingApplication
{
    /// <summary>
    /// Class that represents the form for adding an audit log
    /// </summary>
    public partial class AddAuditLog : Form
    {
        /// <summary>
        /// Project that the bug is to be added to
        /// </summary>
        private Project p;
        /// <summary>
        /// Bug that is going to have an audit log added to
        /// </summary>
        private Bug b;
        /// <summary>
        /// The current User that is logged in
        /// </summary>
        private User u;
        /// <summary>
        /// The reference to the current main window
        /// </summary>
        private MainWindow mw;

        /// <summary>
        /// Constructor for the Add Audit Log Class
        /// </summary>
        /// <param name="p">Project that the bug is a part of</param>
        /// <param name="b">The bug that the audit log is going to be added to</param>
        /// <param name="u">A reference to the current user that is logged in</param>
        /// <param name="mw">A reference to the current main window</param>
        public AddAuditLog(Project p, Bug b, User u, MainWindow mw)
        {
            InitializeComponent();
            this.p = p;
            this.b = b;
            this.u = u;
            this.mw = mw;
        }

        /// <summary>
        /// Function Called when the add button is clicked on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void auditLogAdd_Click(object sender, EventArgs e)
        {
            //Basic validity checking
            if (auditLogText.Text.Length <= 3)
            {
                //we open up message box if there is error
                MessageBox.Show("audit log cannot be left blank or shorter that 4 characters", "Error: Audit log too short", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            //create issue resource from the Sharp Bucket library
            IssuesResource issuesResource = u.V1Api.RepositoriesEndPoint(p.ProjectOwner,p.ProjectName).IssuesResource();
            //Comment is bitbucket/sharpbuckets version of an audit log
            Comment comment = new Comment { content = auditLogText.Text};
            //issue referse to  a specific issue or bug issues is all of the issues
            IssueResource i = issuesResource.IssueResource(b.BugID);
            //post comment means make a post request(which adds a comment/log)
            i.PostComment(comment);
            //show message box upon successful completion
            MessageBox.Show("Audit Log has been added", "Audit log added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //calls method on the main window to refresh the audit logs
            mw.ViewAuditLogs(b, p);
            //then close this window
            this.Close();
        }
    }
}
