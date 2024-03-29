﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
//sharpbucke libs
using SharpBucket.V1.Pocos;
using RepositoryEndPoint = SharpBucket.V2.EndPoints.RepositoriesEndPoint;
using Comment = SharpBucket.V1.Pocos.Comment;
//using Repository = SharpBucket.V2.Pocos.Repository;
using Repository = SharpBucket.V1.Pocos.Repository;
using RestSharp;

namespace BugTrackingApplication
{
    /// <summary>
    /// Class representing the main form area for the application
    /// </summary>
    public partial class MainWindow : Form
    {
        /// <summary>
        /// the user that has been autheticated
        /// </summary>
        private User u;
        private List<Project> currentProjects = new List<Project>();
        private RepositoryEndPoint reposEndPoint;
        /// <summary>
        /// position x for the project controls to be added
        /// </summary>
        private int positionX = 7;
        /// <summary>
        /// postion y for the project controls to be added
        /// </summary>
        private int positionY = 20;
        private Project currentProject;
        private Bug currentBug;
        private string branchCurrent;
        private bool validSource;

        public bool ValidSource { get { return validSource; } set { validSource = value; } }

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



            LoadProjects();
            validSource = false;

        }

        
        /// <summary>
        /// Method used to load the projects 
        /// </summary>
        private void LoadProjects()
        {
            Projects.Controls.Clear();
            reposEndPoint = u.V2Api.RepositoriesEndPoint();
           

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
                if (currentProject != null && p.ProjectName.Equals(currentProject.ProjectName))
                {
                    currentProject = p;
                }
                currentProjects.Add(p);

                ProjectControl pc = new ProjectControl(r.owner, r.name, branch, this, p, u);
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
        /// <param name="bug">bug to be loaded</param>
        /// <param name="project">the project that the bug is from</param>
        internal void ViewAuditLogs(Bug bug, Project project)
        {
            
            //we need to load the logs first
            bug = LoadBugsAuditLogs(bug, project);

            currentBug = bug;
            //first update the bug detail list
            this.bugIssueBox.Text = bug.Issue;
            this.className.Text = bug.ClassName;
            this.methodBlock.Text = bug.Method;
            this.lineNumber.Text = bug.LineNum;
            this.reportedBy.Text = bug.CreatedBy;
            this.lastUpdated.Text = bug.CreatedOn;
            this.assignBugLink.Tag = bug;
            this.assignedToText.Text = bug.Responsible;
            this.bugStatusText.Text = bug.Status;
            this.lineNumEnd.Text = bug.LineNumEnd;
            if (bug.Status.Equals("closed"))
            {
               closeBug.Text = "Open Bug";
            }
            else
            {
                closeBug.Text = "Close Bug";
            }
            int x = 0;
            int y = 10;

            //clear audit log panel
            auditLogPanel.Controls.Clear();
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
        /// Used to load bugs into the project object
        /// Gets issues from repository. Checks if there is a revision set, checks if issue has related then adds to project bugs
        /// </summary>
        /// <param name="p">the project to load the bugs for</param>
        /// <param name="branch">teh branch to load the bugs from</param>
        /// <param name="revision">the revision that the bug is for</param>
        internal void LoadBugs(Project p, string branch, string revision = null, bool myBugs = false)
        {
            currentProject = p;
            p.ResetBugList();
            bugPanel.Controls.Clear();
            branchCurrent = branch;
            auditLogPanel.Controls.Clear();
            
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
                //Format of bug content
                //is issue text[REVISION:asdsadas,CLASSNAME:asdasdsa,METHODBLOCK:asdsada,LINENUM:dsasdas]
                //We need to strip out the formatting from the data in the bug content string
                string content = i.content;
                
                //removes left brace gives the bug issue in position 0 and rest of data in position 1
                string[] splitRemoveBracket = content.Split('[');
                string issue = splitRemoveBracket[0];
                //we then split on comma to give revision class name etc into separete array locations
                string[] bugData = splitRemoveBracket[1].Split(',');
                //we then split each bugdata postion on: and take position 1 which gives us the correct data
                string revsionData = bugData[0].Split(':')[1];
                string classData = bugData[1].Split(':')[1];
                string methodData = bugData[2].Split(':')[1];
                string lineData = bugData[3].Split(':')[1];
                string lineDataEnd = bugData[4].Split(':')[1];
                //for the last value we need to remove the ending brace so split and take the position 0
                lineDataEnd = lineDataEnd.Split(']')[0];


                Bug temp = new Bug(revsionData, classData, methodData, lineData, issue,i.reported_by.username,i.title,i.status, lineDataEnd);
                if (temp == null)
                {
                    Console.WriteLine("tmp is null");
                }

                if (i.responsible != null)
                {
                    //if username is null sets the value to a blank string
                    temp.Responsible = i.responsible.username ?? "";
                }
                //set the values of the temp bug
                temp.BugID =(int) i.local_id;
                temp.CreatedOn = i.created_on;
                temp = LoadBugsAuditLogs(temp, p);
                //checks if we are looking for bugs relating to a specific version
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
             
                //we also need to get all of the comments
            }
            int bugX = 2;
            int bugY = 10;
            // Console.WriteLine(p.Bugs.Count + "num of bugs");
            //we clear the bug panel just before adding the new ones
            bugPanel.Controls.Clear();
            foreach (Bug bug in p.Bugs)
            {
                BugList bl = new BugList(this, p, bug);
                bl.Location = new System.Drawing.Point(bugX, bugY);
                bugPanel.Controls.Add(bl);
                bugY = bugY + 100;
            }

           

        }

        /// <summary>
        /// Method Used to Load the audit logs for a specific bug
        /// </summary>
        /// <param name="bug">the bug of which the logs are going to be loaded</param>
        /// <param name="project">The project of which is going to be loaded</param>
        /// <returns></returns>
        private Bug LoadBugsAuditLogs(Bug bug, Project project)
        {
            int issueID = bug.BugID;
            bug.Logs.Clear();
            List<Comment> comments = u.V1Api.RepositoriesEndPoint(project.ProjectOwner, project.ProjectName).IssuesResource().IssueResource(issueID).ListComments();

            Console.WriteLine(comments.Count);
            foreach (Comment comment in comments)
            {
                AuditLog log = new AuditLog((int)comment.comment_id, comment.content, comment.utc_created_on, comment.author_info.display_name, comment.utc_updated_on);
                bug.AddAuditLog(log);
                Console.WriteLine(log.Message);

            }
            bug.FlipList();

            return bug;
        }

        /// <summary>
        /// Exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                Application.Exit();
            

        }

        /// <summary>
        /// Used to assign the bug to the current user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void assignBugLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //we have to use the RestSharp lib here as the SharpBucket does not handel this properly


            //create the request with the rest of the URL(the client contains the base url)
            RestRequest request = new RestRequest("1.0/repositories/{accountname}/{repo_slug}/issues/{issueID}", Method.PUT);
            //these replace what are in brackets
            request.AddUrlSegment("accountname", currentProject.ProjectOwner);
            request.AddUrlSegment("repo_slug", currentProject.ProjectName);
            request.AddUrlSegment("issueID", currentBug.BugID.ToString());

            request.AddParameter("responsible", u.AccountName);
            Console.WriteLine(u.AccountName);

            IRestResponse response = u.Client.Execute(request);
            var content = response.Content;
            Console.WriteLine("Bug may have been assigned?");
         

        }

        /// <summary>
        /// Function called when the create new bug link is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNewBug_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //we need to show a bug creation form
            //we need to create a new add bug form

            AddBugs addBugform = new AddBugs(currentProject, branchCurrent, u, this);
            addBugform.Show();
            
            
        }

        /// <summary>
        /// Link to close the bug
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeBug_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (closeBug.Text.Equals("Open Bug"))
            {
                //we need the current bug id
                Issue changedIssue = new Issue { status = "new", local_id = currentBug.BugID };
                Issue changedIssueResult = u.V1Api.RepositoriesEndPoint(currentProject.ProjectOwner, currentProject.ProjectName).IssuesResource().PutIssue(changedIssue);
            }
            else
            {
                //we need the current bug id
                Issue changedIssue = new Issue { status = "closed", local_id = currentBug.BugID };
                Issue changedIssueResult = u.V1Api.RepositoriesEndPoint(currentProject.ProjectOwner, currentProject.ProjectName).IssuesResource().PutIssue(changedIssue);
            }

            //we then need to update the bug
            LoadBugs(currentProject, branchCurrent);
            //we need to set the current bug
            foreach (Bug b in currentProject.Bugs)
            {
                if (b.BugID == currentBug.BugID)
                {
                    currentBug = b;
                }
            }
            //we need to clear audit logs panel
            auditLogPanel.Controls.Clear();
            //we then need to call view audit logs again
            ViewAuditLogs(currentBug, currentProject);
        }

        /// <summary>
        /// Method to insert a new audit log opens a small form to allow message entry then inserts to website
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newAuditLogLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddAuditLog audit = new AddAuditLog(currentProject,currentBug,u, this);
            
            audit.Show();
        }

        /// <summary>
        /// Function that opens the edit bug form when the link is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editBug_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //we need to open the update bug form
            UpdateBug ub = new UpdateBug(currentProject, currentBug, u, this);
            ub.Show();


       
        }

        /// <summary>
        /// Function that runs when the view source is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewSourceLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewBugSource viewSource = new ViewBugSource(currentProject, currentBug, u, this);
            if (validSource)
            {
                viewSource.Show();
            }

            
            
        }

        /// <summary>
        /// Used to reload all the bugs relating to a specific project and then reassign the current bug
        /// </summary>
        public void ReloadBugs()
        {
            //we then need to update the bug
            LoadBugs(currentProject, branchCurrent);
            //we need to set the current bug
            foreach (Bug b in currentProject.Bugs)
            {
                if (b.BugID == currentBug.BugID)
                {
                    currentBug = b;
                }
            }
            //we need to clear audit logs panel
            //auditLogPanel.Controls.Clear();
            //we then need to call view audit logs again
            ViewAuditLogs(currentBug, currentProject);
            
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

        
    }
}
