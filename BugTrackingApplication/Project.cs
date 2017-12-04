using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpBucket.V1;
using SharpBucket.V1.Pocos;

namespace BugTrackingApplication
{
    /// <summary>
    /// class representing a project
    /// </summary>
    class Project
    {
        private List<Bug> bugs;
        private string RepositoryURL;
        private string ProjectName;
        private string ProjectOwner;
        private Dictionary<string, BranchInfo> branches;

        public Dictionary<string, BranchInfo> Branches { get => branches;}
        public string ProjectName1 { get => ProjectName; set => ProjectName = value; }

        /// <summary>
        /// Constructor for the project class
        /// </summary>
        /// <param name="bugs">list of associated bugs</param>
        /// <param name="RepositoryURL">URL of the repository for code</param>
        /// <param name="ProjectName">Name of the project </param>
        /// <param name="ProjectOwner">Owner of the project</param>
        public Project(List<Bug> bugs, string RepositoryURL, string ProjectName, string ProjectOwner, Dictionary<string, BranchInfo> branches)
        {
            this.bugs = bugs;
            this.RepositoryURL = RepositoryURL;
            this.ProjectName1 = ProjectName;
            this.ProjectOwner = ProjectOwner;
            this.branches = branches;

        }

        /// <summary>
        /// Constructor for the project class
        /// </summary>
        /// <param name="RepositoryURL">URL of the repository for code</param>
        /// <param name="ProjectName">Name of project</param>
        /// <param name="ProjectOwner">Owner of project</param>
        public Project(string RepositoryURL, string ProjectName, string ProjectOwner, Dictionary<string, BranchInfo> branches)
        {
            
            this.RepositoryURL = RepositoryURL;
            this.ProjectName1 = ProjectName;
            this.ProjectOwner = ProjectOwner;
            this.branches = branches;

        }

        /// <summary>
        /// Override of to string
        /// </summary>
        /// <returns>the name of this project</returns>
        public override string ToString()
        {
            return this.ProjectName1;
        }


    }

}
