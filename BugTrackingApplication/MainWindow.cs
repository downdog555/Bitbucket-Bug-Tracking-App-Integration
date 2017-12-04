using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public MainWindow(User u, DatabaseHandler db)
        {
            InitializeComponent();

            this.u = u;
            this.db = db;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            reposEndPoint = u.V2Api.RepositoriesEndPoint();
            //first we need to get a list of projects
            //we need each branch
            
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

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void projectsList_SelectedValueChanged(object sender, EventArgs e)
        {
            Project p =(Project) projectsList.SelectedItem;
            branchesList.Items.Clear();
            foreach (KeyValuePair<string, BranchInfo> branch in p.Branches)
            {
                branchesList.Items.Add(branch.Key);
            }
        }

        private void branchesList_SelectedValueChanged(object sender, EventArgs e)
        {
            Project p = (Project)projectsList.SelectedItem;
            BranchInfo bi;
            p.Branches.TryGetValue((string)branchesList.SelectedItem, out bi);

            revisionsList.Items.Clear();
            var commits = u.V2Api.RepositoriesEndPoint().RepositoryResource(u.AccountName, p.ProjectName1).ListCommits(bi.branch);

            foreach (Commit c in commits)
            {
                
                revisionsList.Items.Add(c.hash +": " +c.message);
            }
        }

        private void revisionsList_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
