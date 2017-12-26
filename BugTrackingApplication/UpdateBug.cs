using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpBucket.V1.Pocos;
using SharpBucket.V2.Pocos;

namespace BugTrackingApplication
{
    /// <summary>
    /// Class that represents the Update Bug Form
    /// </summary>
    public partial class UpdateBug : Form
    {
        /// <summary>
        /// Project that the bug belongs to
        /// </summary>
        private Project p;
        /// <summary>
        /// The bug to be edited
        /// </summary>
        private Bug b;
        /// <summary>
        /// the authorised user
        /// </summary>
        private User u;
        /// <summary>
        /// THe current main window
        /// </summary>
        private MainWindow mw;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="currentProject">Current project</param>
        /// <param name="b">Bug to  be edited</param>
        /// <param name="u">current authroised user</param>
        /// <param name="mw">the current mainwindow</param>
        public UpdateBug(Project currentProject, Bug b, User u, MainWindow mw)
        {
            InitializeComponent();
            //sets values
            this.p = currentProject;
            this.b = b;
            this.u = u;
            this.mw = mw;
            List<Commit> commits = u.V2Api.RepositoriesEndPoint().RepositoryResource(p.ProjectOwner, p.ProjectName).ListCommits();
            foreach (Commit c in commits)
            {
                revsionBox.Items.Add(c.hash);
            }
        }

        /// <summary>
        /// Called when form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBug_Load(object sender, EventArgs e)
        {
            //sets values
            issueBox.Text = b.Issue;
            classData.Text = b.ClassName;
            methodBlockData.Text = b.Method;
            lineNumberBox.Text = b.LineNum;
            titleBox.Text = b.Title;
        }

        /// <summary>
        /// Function called hwne add/update bug is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBugButton_Click(object sender, EventArgs e)
        { //is issue text[REVISION:asdsadas,CLASSNAME:asdasdsa,METHODBLOCK:asdsada,LINENUM:dsasdas]
            //we need to create a new issue 
            string revision, classname, methodblock, linenum;
            if (revsionBox.SelectedText.Equals(""))
            {
                revision = "UNKNOWN";
            }
            else
            {
                revision = revsionBox.SelectedText;
            }

            if (classData.Text.Equals("") || classData.Text.Equals(" "))
            {
                classname = "UNKNOWN";
            }
            else
            {
                classname = classData.Text;
            }

            if (methodBlockData.Text.Equals("") || methodBlockData.Text.Equals(" "))
            {
                methodblock = "UNKNOWN";
            }
            else
            {
                methodblock = methodBlockData.Text;
            }

            if (lineNumberBox.Text.Equals("") || lineNumberBox.Text.Equals(" "))
            {
                linenum = "UNKNOWN";
            }
            else
            {
                linenum = lineNumberBox.Text ;
            }
            //we still create a new issue and just have the data in it that we want to update, with the bug id
            var newIssue = new Issue
            {
                title = titleBox.Text,
                content = issueBox.Text + "[REVISION:" + revision + ",CLASSNAME:" + classname + ",METHODBLOCK:" + methodblock + ",LINENUM:" + linenum + "]",
                kind = "bug",
                local_id = b.BugID
            };

            
            u.V1Api.RepositoriesEndPoint(p.ProjectOwner, p.ProjectName).IssuesResource().PutIssue(newIssue);
            this.Close();
            //reload bugs after editing one
            mw.ReloadBugs();
        }
    }
}
