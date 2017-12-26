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
    /// <summary>
    /// This is a custom user control for an AuditLog
    /// </summary>
    public partial class AuditLogControl : UserControl
    {
        /// <summary>
        /// Constructor for AuditLogControl
        /// </summary>
        /// <param name="l">A referece to the audit log that this control will be referencing</param>
        public AuditLogControl(AuditLog l)
        {
            InitializeComponent();
            auditlogBox.Text = "Audit Log: " + l.AuditLogId;
            messageText.Text = l.Message;
            createdByText.Text = l.OwnerName;
            createdOnText.Text = l.CreatedOn;
            updatedOn.Text = l.UpdatedOn;
        }
    }
}
