using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpBucket.V1;
using SharpBucket.V1.Pocos;
using SharpBucket.V2;
using SharpBucket.V2.Pocos;

namespace BugTrackingApplication
{
    public partial class ProjectControl : UserControl
    {
        private string projectOwner;
        private string projectName;
        private MainWindow mw;
        private Project p;
        private Dictionary<string, BranchInfo> branches;
        private User u;

        /// <summary>
        /// Control for the projects
        /// </summary>
        /// <param name="projectOwner"></param>
        /// <param name="projectName"></param>
        /// <param name="branches"></param>
        /// <param name="mw"></param>
        public ProjectControl(string projectOwner, string projectName, Dictionary<string, BranchInfo> branches, MainWindow mw, Project p, User u)
        {
            InitializeComponent();
            //this.Dock = DockStyle.Fill;
            this.projectName = ProjectName.Text = projectName;

            this.u = u;
            projectOwnerText.Text = this.projectOwner = projectOwner;
            this.branches = branches;
            foreach (KeyValuePair<string, BranchInfo> branch in branches)
            {
                branchSelectorBox.Items.Add(branch.Key);
            }
            viewBugsLink.Tag = projectName;
            this.mw = mw;
            this.p = p;
        }

        private void viewBugsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //we can call load bugs;
            string branch = "";
            if (branchSelectorBox.Text.Equals(""))
            {
                branch = "Master";
            }
            else
            {
                foreach (KeyValuePair<string, BranchInfo> b in u.V1Api.RepositoriesEndPoint(p.ProjectOwner, p.ProjectName).ListBranches())
                {
                    if (b.Key.Equals(branchSelectorBox.Text))
                    {
                        branch = branchSelectorBox.Text;
                    }
                    else
                    {
                        branch = "Master";
                    }

                }
            }
            
            mw.LoadBugs(p, branch);
        }

        private void ProjectName_Enter(object sender, EventArgs e)
        {

        }

        private void viewMyBugsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //we can call load bugs;
            string branch = "";
            if (branchSelectorBox.Text.Equals(""))
            {
                branch = "Master";
            }
            else
            {
                foreach (KeyValuePair<string, BranchInfo> b in u.V1Api.RepositoriesEndPoint(p.ProjectOwner, p.ProjectName).ListBranches())
                {
                    if (b.Key.Equals(branchSelectorBox.Text))
                    {
                        branch = branchSelectorBox.Text;
                    }
                    else
                    {
                        branch = "Master";
                    }

                }
            }

            mw.LoadBugs(p, branch, null, true);
        }
    }
}
