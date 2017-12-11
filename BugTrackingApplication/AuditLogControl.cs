using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingApplication
{
    public partial class AuditLogControl : UserControl
    {
        public AuditLogControl(AuditLog l)
        {
            InitializeComponent();
            auditlogBox.Text = "Audit Log: " + l.AuditLogId;
            messageText.Text = l.Message;
            createdByText.Text = l.OwnerName;
            createdOnText.Text = l.CreatedOn;
        }
    }
}
