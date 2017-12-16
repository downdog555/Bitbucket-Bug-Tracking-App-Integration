using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpBucket.V1.Pocos;
using SharpBucket.V2.Pocos;

namespace BugTrackingApplication
{
    public partial class UpdateBug : Form
    {
        private Project p;
        private Bug b;
        private User u;
        public UpdateBug(Project currentProject, Bug b, User u)
        {
            InitializeComponent();
            this.p = currentProject;
            this.b = b;
            this.u = u;

            List<Commit> commits = u.V2Api.RepositoriesEndPoint().RepositoryResource(p.ProjectOwner, p.ProjectName).ListCommits();
            foreach (Commit c in commits)
            {
                revsionBox.Items.Add(c.hash);
            }
        }

        private void addBug_Load(object sender, EventArgs e)
        {
            issueBox.Text = b.Issue;
            classData.Text = b.ClassName;
            methodBlockData.Text = b.Method;
            lineNumberBox.Text = b.LineNum;
            titleBox.Text = b.Title;
        }

        private void addBugButton_Click(object sender, EventArgs e)
        { //is issue text[REVISION:asdsadas,CLASSNAME:asdasdsa,METHODBLOCK:asdsada,LINENUM:dsasdas]
            //we need to create a new issue 
            string revision, classname, methodblock, linenum;
            if (revsionBox.SelectedText.Equals(""))
            {
                revision = "UNKNOWN";
            }
            else
            {
                revision = revsionBox.SelectedText;
            }

            if (classData.Text.Equals("") || classData.Text.Equals(" "))
            {
                classname = "UNKNOWN";
            }
            else
            {
                classname = classData.Text;
            }

            if (methodBlockData.Text.Equals("") || methodBlockData.Text.Equals(" "))
            {
                methodblock = "UNKNOWN";
            }
            else
            {
                methodblock = methodBlockData.Text;
            }

            if (lineNumberBox.Text.Equals("") || lineNumberBox.Text.Equals(" "))
            {
                linenum = "UNKNOWN";
            }
            else
            {
                linenum = lineNumberBox.Text ;
            }
            var newIssue = new Issue
            {
                title = titleBox.Text,
                content = issueBox.Text + "[REVISION:" + revision + ",CLASSNAME:" + classname + ",METHODBLOCK:" + methodblock + ",LINENUM:" + linenum + "]",
                kind = "bug",
                local_id = b.BugID
            };

            //var newIssueResult = 
            u.V1Api.RepositoriesEndPoint(p.ProjectOwner, p.ProjectName).IssuesResource().PutIssue(newIssue);

            this.Close();
        }
    }
}
