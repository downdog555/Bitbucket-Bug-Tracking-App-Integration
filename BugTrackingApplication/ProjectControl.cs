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
        private string projectURL;
        private string projectName;
        private MainWindow mw;
        private Project p;
        private Dictionary<string, BranchInfo> branches;

        /// <summary>
        /// Control for the projects
        /// </summary>
        /// <param name="projectOwner"></param>
        /// <param name="projectURL"></param>
        /// <param name="projectName"></param>
        /// <param name="branches"></param>
        /// <param name="mw"></param>
        public ProjectControl(string projectOwner, string projectURL, string projectName, Dictionary<string, BranchInfo> branches, MainWindow mw, Project p)
        {
            InitializeComponent();

            this.projectName = ProjectName.Text = projectName;

            projectURLText.Text = this.projectURL = projectURL;
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
            BranchInfo branch;
            if (branchSelectorBox.Text.Equals(""))
            {
                branches.TryGetValue("Master", out branch);
            }
            else
            {
                branches.TryGetValue(branchSelectorBox.Text, out branch);
            }

            mw.LoadBugs(p, branch);
        }

        private void ProjectName_Enter(object sender, EventArgs e)
        {

        }
    }
}
