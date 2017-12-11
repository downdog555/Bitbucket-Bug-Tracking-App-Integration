using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
//sharpbucke libs
using SharpBucket.V1;
using SharpBucket.V1.Pocos;
using SharpBucket.V2;
using SharpBucket.V2.Pocos;
using RepositoryEndPoint = SharpBucket.V2.EndPoints.RepositoriesEndPoint;
using Comment = SharpBucket.V1.Pocos.Comment;
using SharpUser = SharpBucket.V1.Pocos.User;
using Link = SharpBucket.V1.Pocos.Link;
//using Repository = SharpBucket.V2.Pocos.Repository;
using Repository = SharpBucket.V1.Pocos.Repository;

namespace BugTrackingApplication
{
    /// <summary>
    /// Class representing the main form area for the application
    /// </summary>
    public partial class MainWindow : Form
    {
        private User u;
        private List<Project> currentProjects = new List<Project>();
        private RepositoryEndPoint reposEndPoint;
        private int positionX = 7;
        private int positionY = 20;
        private Project currentProject;
        private Bug currentBug;
        
        /// <summary>
        /// Constructor for the main window class
        /// </summary>
        /// <param name="u">A User Object</param>
        /// <param name="db">A Database Handler Object</param>
        public MainWindow(User u)
        {
            InitializeComponent();

            this.u = u;
            
        }

        /// <summary>
        /// Load function for main window. Used to get the intial list of projects and their repositories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            tabPage2.Hide();
            reposEndPoint = u.V2Api.RepositoriesEndPoint();
            //first we need to get a list of projects
            //we need each branch

            //gets a list of projects from the version control service
            List<Repository> projects = u.V1Api.UserEndPoint().ListRepositories();

            //List<Repository> projects = u.V2Api.UsersEndPoint(u.AccountName).ListRepositories();

            Console.WriteLine(projects.Count);
            foreach (Repository r in projects)
            {

                //we need to load the project controls

                //we need to get the branches for the project
                Dictionary<string, BranchInfo> branch = u.V1Api.RepositoriesEndPoint(r.owner, r.name).ListBranches();
                //we need to add the project to the list
                Project p = new Project(r.name, r.owner, branch);
                
                currentProjects.Add(p);
               
                ProjectControl pc = new ProjectControl(r.owner, r.name, branch, this, p);
                //pc.Location.X = positionX;
                //pc.Location.Y = positionY;

                Projects.Controls.Add(pc);
                pc.Location = new System.Drawing.Point(positionX, positionY);
                positionY = positionY + 100;
            }

            Console.WriteLine(currentProjects.Count);
           
            


        }

        /// <summary>
        /// Function to load the audit logs of a bug
        /// </summary>
        /// <param name="b">bug to be loaded</param>
        /// <param name="p">the project that the bug is from</param>
        internal void ViewAuditLogs(Bug bug, Project p)
        {
            currentBug = bug;
            //first update the bug detail list
            this.bugIssueBox.Text = bug.Issue;
            this.className.Text = bug.ClassName;
            this.methodBlock.Text = bug.Method;
            this.lineNumber.Text = bug.LineNum;
            this.reportedBy.Text = bug.CreatedBy;
            this.lastUpdated.Text = bug.CreatedOn;
            this.assignBugLink.Tag = bug;
            int x = 0;
            int y = 10;
            foreach (AuditLog a in bug.Logs)
            {
                //foreach audit log add a control for it
                AuditLogControl alc = new AuditLogControl(a);
                alc.Location = new System.Drawing.Point(x, y);
                this.auditLogPanel.Controls.Add(alc);
                y = y + 100;
            }
        }

        

        /// <summary>
        /// Called when main form window is closing.
        /// Event is cancelled if they do not want to close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Called when main window has closed and resources free(no point of return)
        /// Have to still call application.exit as the application is still running with the entry point of the login form just hidden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Used to load bugs into the project object
        /// Gets issues from repository. Checks if there is a revision set, checks if issue has related then adds to project bugs
        /// </summary>
        /// <param name="p"></param>
        /// <param name="b"></param>
        /// <param name="revision"></param>
        internal void LoadBugs(Project p, BranchInfo b, string revision = null, bool myBugs = false)
        {
            currentProject = p;
            p.ResetBugList();
            bugPanel.Controls.Clear();
            List<Issue> correctBugs = new List<Issue>();
            //limit searches to bugs
            IssueSearchParameters searchParam = new IssueSearchParameters();
            searchParam.kind = "bug";
            //if we just want the current users assigned bugs then add responsible to the search param
            if (myBugs)
            {
                searchParam.responsible = u.AccountName;
            }
            //get list of issues
            List<Issue> issues = u.V1Api.RepositoriesEndPoint(p.ProjectOwner, p.ProjectName).IssuesResource().ListIssues(searchParam).issues;
            JsonSerializer serializer = new JsonSerializer();

            projectOwner.Text = p.ProjectOwner;
            projectTitle.Text = p.ProjectName;
            // serializer.Converters.Add(new StringEnumConverter());

            //if there are no issues of type bug then we have nobugs so inform the user
            if (issues == null || issues.Count == 0)
            {
                MessageBox.Show("No Bugs were found", "No Bugs were Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            foreach (Issue i in issues)
            {
                Console.WriteLine(i.responsible.display_name+"Mepw");
                //we need to check if issues have a certain format
               // Console.WriteLine(i.metadata.kind);
                Bug temp = JsonConvert.DeserializeObject<Bug>(i.content);
                temp.BugID =(int) i.local_id;
                temp.CreatedOn = i.created_on;
                int issueID = (int)i.local_id;
                List<Comment> comments = u.V1Api.RepositoriesEndPoint(p.ProjectOwner, p.ProjectName).IssuesResource().IssueResource(issueID).ListComments();
                
                Console.WriteLine(comments.Count);
                foreach (Comment comment in comments)
                {
                    AuditLog log = new AuditLog((int)comment.comment_id, comment.content, comment.utc_created_on, comment.author_info.display_name);
                    temp.AddAuditLog(log);
                    Console.WriteLine(log.Message);
                    temp.FlipList();
                }
                if (revision != null)
                {
                    //if not null be only show certain bugs
                    if (temp.Revision.Equals(revision))
                    {
                        p.AddBug(temp);
                    }
                    

                }
                else
                {
                    p.AddBug(temp);
                }
                int bugX = 2;
                int bugY = 10;
                foreach (Bug bug in p.Bugs)
                {
                    BugList bl = new BugList(this, p , bug);
                    bl.Location = new System.Drawing.Point(bugX, bugY);
                    bugPanel.Controls.Add(bl);
                    bugY = bugY + 100;
                }

                //we also need to get all of the comments
            }

            //issuesLog.Clear();
            //issuesLog.Text = logText;
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                Application.Exit();
            

        }

        private void assignBugLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Issue issue = u.V1Api.RepositoriesEndPoint(currentProject.ProjectOwner, currentProject.ProjectName).IssuesResource().GetIssue(currentBug.BugID);
            
            UserInfo currentUserInfo = u.V1Api.UserEndPoint().GetInfo();
            issue.title = "meowwww";
            try
            {
               var result =  u.V1Api.RepositoriesEndPoint(currentProject.ProjectOwner, currentProject.ProjectName).IssuesResource().PutIssue(issue);
                Console.WriteLine(result.title);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
            Console.WriteLine("Issue should have been updated");
        }
    }
}
