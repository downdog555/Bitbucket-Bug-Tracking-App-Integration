using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /// <summary>
        /// Constructor for the project class
        /// </summary>
        /// <param name="bugs">list of associated bugs</param>
        /// <param name="RepositoryURL">URL of the repository for code</param>
        /// <param name="ProjectName">Name of the project </param>
        /// <param name="ProjectOwner">Owner of the project</param>
        public Project(List<Bug> bugs, string RepositoryURL, string ProjectName, string ProjectOwner)
        {
            this.bugs = bugs;
            this.RepositoryURL = RepositoryURL;
            this.ProjectName = ProjectName;
            this.ProjectOwner = ProjectOwner;

        }

        /// <summary>
        /// Constructor for the project class
        /// </summary>
        /// <param name="RepositoryURL">URL of the repository for code</param>
        /// <param name="ProjectName">Name of project</param>
        /// <param name="ProjectOwner">Owner of project</param>
        public Project(string RepositoryURL, string ProjectName, string ProjectOwner)
        {
            
            this.RepositoryURL = RepositoryURL;
            this.ProjectName = ProjectName;
            this.ProjectOwner = ProjectOwner;

        }


    }

}
