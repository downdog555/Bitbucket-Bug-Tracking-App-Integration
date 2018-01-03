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
    /// Class that represents the form that is used to add a new bug
    /// </summary>
    public partial class AddBugs : Form
    {
        /// <summary>
        /// The project that is going to have a bug added to it
        /// </summary>
        private Project p;
        /// <summary>
        /// A string that represents the selected branch of the repository
        /// </summary>
        private string branch;
        /// <summary>
        /// reference to the current user that is logged in
        /// </summary>
        private User u;
        /// <summary>
        /// Reference to the current main window
        /// </summary>
        private MainWindow mw;

        /// <summary>
        /// Constructor for the AddBug Form
        /// </summary>
        /// <param name="currentProject">The Project that is going have a bug added to it</param>
        /// <param name="branch">The selected branch that the bug is from</param>
        /// <param name="u">The current user</param>
        /// <param name="mw">The current mainwindow</param>
        public AddBugs(Project currentProject, string branch, User u, MainWindow mw)
        {
            InitializeComponent();
            this.p = currentProject;
            this.branch = branch;
            this.u = u;
            this.mw = mw;

            //get a list of the commits to allow user to select a specific revision that hte bug belongs to.
            List<Commit> commits = u.V2Api.RepositoriesEndPoint().RepositoryResource(p.ProjectOwner, p.ProjectName).ListCommits();
            foreach (Commit c in commits)
            {
                revsionBox.Items.Add(c.hash);
            }
        }

      
        /// <summary>
        /// Function called when the add bug button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBugButton_Click(object sender, EventArgs e)
        {
            //for us to allow the location of the bug to be stored with the issue we have a specific layout for the content of the issue
            ///issue text[REVISION:asdsadas,CLASSNAME:asdasdsa,METHODBLOCK:asdsada,LINENUM:dsasdas]
            //we need to create a new issue 

            //we create local strings before hand so we can set them to a defualt value if there is not a value entered.
            string revision, classname, methodblock, linenum, linenumEnd;
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

            if (lineNumEndBox.Text.Equals("") || lineNumEndBox.Text.Equals(" "))
            {
                linenumEnd = "UNKNOWN";
            }
            else
            {
                linenumEnd = lineNumEndBox.Text;
            }

            //we then use the sharpbucket class for a issue(bug)
            var newIssue = new Issue
            {
            title = titleBox.Text,
                //Creates the specified layout for the issue content
                content = issueBox.Text + "[REVISION:" + revision + ",CLASSNAME:" + classname + ",METHODBLOCK:" + methodblock + ",LINENUM:" + linenum + ",LINENUMEND:" + linenumEnd + "]",
                status = "new",
            //we can have different kinds of issues however we only require bugs
            kind = "bug"
            };

            
            //we then use the user refeerence with the sharpbucket api to post a new issue
            u.V1Api.RepositoriesEndPoint(p.ProjectOwner, p.ProjectName).IssuesResource().PostIssue(newIssue);
            //we use the reference to the mainwindow to refresh the bugs
            mw.LoadBugs(p,branch);
            //then close window
            this.Close();
        }
    }
}
