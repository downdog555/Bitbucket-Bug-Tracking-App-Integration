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
    /// <summary>
    /// Class representing a custom control for displaying the projects
    /// </summary>
    public partial class ProjectControl : UserControl
    {
        private string projectOwner;
        private string projectName;
        /// <summary>
        /// Reference to the MainWindow Object
        /// </summary>
        private MainWindow mw;
        /// <summary>
        /// Project that this control represents
        /// </summary>
        private Project p;
        private Dictionary<string, BranchInfo> branches;
        /// <summary>
        /// User that is current authorised
        /// </summary>
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

            //displays data onto control
            this.projectName = ProjectName.Text = projectName;

            this.u = u;
            projectOwnerText.Text = this.projectOwner = projectOwner;
            this.branches = branches;
            //displays all the availabl branches for this project
            foreach (KeyValuePair<string, BranchInfo> branch in branches)
            {
                branchSelectorBox.Items.Add(branch.Key);
            }
            viewBugsLink.Tag = projectName;
            this.mw = mw;
            this.p = p;
        }

        /// <summary>
        /// Function called when the view bugs link is called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewBugsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //we can call load bugs;
            string branch = "";
            //if we have blank value for branch just select master
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

        
        /// <summary>
        /// Function called whne the view my bugs link is called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            //sets bool at end if true only loads the authrised users bugs
            mw.LoadBugs(p, branch, null, true);
        }
    }
}
