using SharpBucket.V1.EndPoints;
using SharpBucket.V1.Pocos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingApplication
{
    public partial class AddAuditLog : Form
    {
        private Project p;
        private Bug b;
        private User u;
        public AddAuditLog(Project p, Bug b, User u)
        {
            InitializeComponent();
            this.p = p;
            this.b = b;
            this.u = u;
        }

        private void auditLogAdd_Click(object sender, EventArgs e)
        {
            
            if (auditLogText.Text.Length <= 3)
            {
                //we open up message box if there is error
                MessageBox.Show("audit log cannot be left blank or shorter that 4 characters", "Error: Audit log too short", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            IssuesResource issuesResource = u.V1Api.RepositoriesEndPoint(p.ProjectOwner,p.ProjectName).IssuesResource();
            
            Comment comment = new Comment { content = auditLogText.Text};
            IssueResource i = issuesResource.IssueResource(b.BugID);
            i.PostComment(comment);
            MessageBox.Show("Audit Log has been added", "Audit log added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
