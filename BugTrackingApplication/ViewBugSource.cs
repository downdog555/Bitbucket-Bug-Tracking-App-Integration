using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorCode;
using SharpBucket.V1;
using SharpBucket.V1.Pocos;
using SharpBucket.V2;
using SharpBucket.V2.Pocos;
using RestSharp;

namespace BugTrackingApplication
{
    public partial class ViewBugSource : Form
    {
        private Project project;
        private Bug bug;
        private string revision;
        private User user;

        /// <summary>
        /// Constructor which gets revision it is not provided and then gets the source of the given location.
        /// </summary>
        /// <param name="project">The project that the bug is a part of</param>
        /// <param name="bug">The bug which is having it's source loaded</param>
        /// <param name="user">The current authenticated iser</param>
        public ViewBugSource(Project project, Bug bug, User user)
        {
            InitializeComponent();
            this.project = project;
            this.bug = bug;
            this.user = user;
            //if the bug revision is unknown
            if (bug.Revision.Equals("UNKNOWN"))
            {
                //we need  to get the latest revision
                List<Commit> commits = user.V2Api.RepositoriesEndPoint().RepositoryResource(project.ProjectOwner, project.ProjectName).ListCommits();
                //we just need to first one
                Commit c = commits.ElementAt<Commit>(0);
                revision = c.hash;
                
            }
            //we need to craft the rest request
            RestRequest request = new RestRequest("/2.0/repositories/{username}/{repo_slug}/src/{node}/{path}", Method.GET);
            //Console.WriteLine(revision);

            //these replace what are in brackets
            request.AddUrlSegment("username", project.ProjectOwner);
            request.AddUrlSegment("repo_slug", project.ProjectName);
            request.AddUrlSegment("node", revision);
            request.AddUrlSegment("path", bug.ClassName);
            

           


            IRestResponse r = user.Client.Execute(request);
            string src = r.Content;
            string colorizedSourceCode = new CodeColorizer().Colorize(src, Languages.CSharp);
            srcViewer.DocumentText = colorizedSourceCode;
        }
    }
}
