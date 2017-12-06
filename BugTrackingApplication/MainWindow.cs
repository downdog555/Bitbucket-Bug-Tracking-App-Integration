using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
//sharpbucke libs
using SharpBucket.V1;
using SharpBucket.V1.Pocos;
using SharpBucket.V2;
using SharpBucket.V2.Pocos;
using RepositoryEndPoint = SharpBucket.V2.EndPoints.RepositoriesEndPoint;
using Comment = SharpBucket.V1.Pocos.Comment;
using Link = SharpBucket.V1.Pocos.Link;
using Repository = SharpBucket.V2.Pocos.Repository;

namespace BugTrackingApplication
{
    /// <summary>
    /// Class representing the main form area for the application
    /// </summary>
    public partial class MainWindow : Form
    {
        private User u;
        private DatabaseHandler db;
        private List<Project> currentProjects = new List<Project>();
        private RepositoryEndPoint reposEndPoint;

        /// <summary>
        /// Constructor for the main window class
        /// </summary>
        /// <param name="u">A User Object</param>
        /// <param name="db">A Database Handler Object</param>
        public MainWindow(User u, DatabaseHandler db)
        {
            InitializeComponent();

            this.u = u;
            this.db = db;
        }

        /// <summary>
        /// Load function for main window. Used to get the intial list of projects and their repositories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            reposEndPoint = u.V2Api.RepositoriesEndPoint();
            //first we need to get a list of projects
            //we need each branch
            
            //gets a list of projects from the version control service
           List<Repository> projects = reposEndPoint.ListRepositories(u.AccountName);
            foreach (Repository r in projects)
            {
                //we need to get the branches for the project
                Dictionary<string, BranchInfo> branch = u.V1Api.RepositoriesEndPoint(u.AccountName, r.name).ListBranches();
                //we need to add the project to the list
                Project p = new Project(r.links.self.href, r.name, r.owner, branch);
                currentProjects.Add(p);
                projectsList.Items.Add(p);


            }


            //we then need to populate a list of projects 
            


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
        /// Called when the project combo-box is changed
        /// Used to then get all the relevent branches from that project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void projectsList_SelectedValueChanged(object sender, EventArgs e)
        {
            Project p =(Project) projectsList.SelectedItem;
            branchesList.Items.Clear();
            foreach (KeyValuePair<string, BranchInfo> branch in p.Branches)
            {
                branchesList.Items.Add(branch.Key);
            }
        }

        /// <summary>
        /// Used when the branch list is changed
        /// Used to get the revision numbers relating to the branch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void branchesList_SelectedValueChanged(object sender, EventArgs e)
        {
            Project p = (Project)projectsList.SelectedItem;
            BranchInfo bi;
            p.Branches.TryGetValue((string)branchesList.SelectedItem, out bi);

            revisionsList.Items.Clear();
            var commits = u.V2Api.RepositoriesEndPoint().RepositoryResource(u.AccountName, p.ProjectName1).ListCommits(bi.branch);

            foreach (Commit c in commits)
            {
                
                revisionsList.Items.Add(c.hash +":" +c.message);
            }

            //we then need to get the issues/bugs
            LoadBugs(p, bi);
        }

        /// <summary>
        /// used when revision list is selected can be used to narrow down bugs to this version
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void revisionsList_SelectedValueChanged(object sender, EventArgs e)
        {
            Project p = (Project)projectsList.SelectedItem;
            BranchInfo bi;
            p.Branches.TryGetValue((string)branchesList.SelectedItem, out bi);
            string revision = revisionsList.SelectedText.Split(':')[0];

            LoadBugs(p, bi, revision);
        }

        /// <summary>
        /// Used to load bugs into the project object
        /// Gets issues from repository. Checks if there is a revision set, checks if issue has related then adds to project bugs
        /// </summary>
        /// <param name="p"></param>
        /// <param name="b"></param>
        /// <param name="revision"></param>
        private void LoadBugs(Project p, BranchInfo b, string revision = null)
        {
            p.ResetBugList();

            List<Issue> correctBugs = new List<Issue>();
            List<Issue> issues = u.V1Api.RepositoriesEndPoint(u.AccountName, p.ProjectName1).IssuesResource().ListIssues().issues;
            JsonSerializer serializer = new JsonSerializer();

            // serializer.Converters.Add(new StringEnumConverter());
       
      
            foreach (Issue i in issues)
            {
                //we need to check if issues have a certain format
                Console.WriteLine(i.content);
                Bug temp = JsonConvert.DeserializeObject<Bug>(i.content);
                temp.BugID =(int) i.local_id;
                temp.CreatedOn = i.created_on;
                if (revision != null)
                {
                    //if not null be only show certain bugs
                    if (temp.REVISION.Equals(revision))
                    {
                        p.AddBug(temp);
                    }
                    

                }
                else
                {
                    p.AddBug(temp);
                }

                //we also need to get all of the comments
            }
            string logText = "";
            foreach (Bug b1 in p.Bugs)
            {
                logText = logText + b1.REVISION + ": " + b1.ISSUE;
            }
            issuesLog.Clear();
            issuesLog.Text = logText;
        }


    }
}
