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
    public class Project
    {
        private List<Bug> bugs = new List<Bug>();
        private string RepositoryURL;
        private string projectName;
        private string projectOwner;
        private Dictionary<string, BranchInfo> branches;

        //getters and setters
        public Dictionary<string, BranchInfo> Branches { get {return branches; } }
        public string ProjectName { get {return projectName; } set { projectName = value; } }
        public List<Bug> Bugs { get { return bugs; } set { bugs = value; } }
        public string ProjectOwner { get { return projectOwner; } }

        /// <summary>
        /// Constructor for projects class
        /// </summary>
        /// <param name="projectName">Name of the project</param>
        /// <param name="projectOwner">The name of the owner of the project</param>
        /// <param name="branches">A dictionary of branch names and branch info objects</param>
        public Project( string projectName, string projectOwner, Dictionary<string, BranchInfo> branches)
        {
            this.Bugs = bugs;
            
            this.projectName = projectName;
            this.projectOwner = projectOwner;
            this.branches = branches;


        }

        /// <summary>
        /// Constructor for the project class
        /// </summary>
        /// <param name="bugs">list of associated bugs</param>
        /// <param name="RepositoryURL">URL of the repository for code</param>
        /// <param name="ProjectName">Name of the project </param>
        /// <param name="ProjectOwner">Owner of the project</param>
        public Project(List<Bug> bugs, string RepositoryURL, string ProjectName, string projectOwner, Dictionary<string, BranchInfo> branches)
        {
            this.Bugs = bugs;
            this.RepositoryURL = RepositoryURL;
            this.ProjectName = projectName;
            this.projectOwner = projectOwner;
            this.branches = branches;
           

        }

        /// <summary>
        /// Constructor for the project class
        /// </summary>
        /// <param name="RepositoryURL">URL of the repository for code</param>
        /// <param name="ProjectName">Name of project</param>
        /// <param name="ProjectOwner">Owner of project</param>
        public Project(string RepositoryURL, string projectName, string projectOwner, Dictionary<string, BranchInfo> branches)
        {
            
            this.RepositoryURL = RepositoryURL;
            this.projectName = projectName;
            this.projectOwner = projectOwner;
            this.branches = branches;


        }

        /// <summary>
        /// Constructor for the project class
        /// </summary>
        /// <param name="RepositoryURL">URL of the repository for code</param>
        /// <param name="ProjectName">Name of project</param>
        /// <param name="ProjectOwner">Owner of project</param>
        public Project(string RepositoryURL, string projectName, string projectOwner)
        {

            this.RepositoryURL = RepositoryURL;
            this.projectName = projectName;
            this.projectOwner = projectOwner;
            


        }

        /// <summary>
        /// Override of to string
        /// </summary>
        /// <returns>the name of this project</returns>
        public override string ToString()
        {
            return this.ProjectName;
        }

        /// <summary>
        /// Add bug to this project
        /// </summary>
        /// <param name="b"></param>
        public void AddBug(Bug b)
        {
            Bugs.Add(b);
        }

        /// <summary>
        /// clears the list of bugs
        /// </summary>
        public void ResetBugList()
        {
            Bugs = new List<Bug>();
        }


    }

}
