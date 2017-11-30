using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingApplication
{
    /// <summary>
    /// class used to represent a bug
    /// </summary>
    class Bug
    {
        private List<AuditLog> logs;
        private string reportedBy;
        private string bugId;
        private string projectID;

        /// <summary>
        /// Constructor for bug class
        /// </summary>
        /// <param name="logs">list of audit logs</param>
        /// <param name="reportedBy">who the bug was reported by</param>
        /// <param name="bugId">the id of the bug</param>
        /// <param name="projectId">the id of the project</param>
        public Bug(List<AuditLog> logs, string reportedBy, string bugId, string projectId)
        {
            this.logs = logs;
            this.reportedBy = reportedBy;
            this.bugId = bugId;
        }

        /// <summary>
        /// Constructor for bug class
        /// </summary>
        /// <param name="reportedBy">Who the bug was reported by </param>
        /// <param name="bugId">The id of the bug</param>
        public Bug(string reportedBy, string bugId)
        {
           
            this.reportedBy = reportedBy;
            this.bugId = bugId;
        }

        /// <summary>
        /// Adds and audit log to the list for this bug and then adds to the database.
        /// </summary>
        /// <param name="log"></param>
        public void AddAuditLog(AuditLog log)
        {
            this.logs.Add(log);
            //we need to add to database 

            //TODO: add to db
        }

        /// <summary>
        /// Removes from the list as well as the db
        /// </summary>
        /// <param name="auditLogId">the id of the log to remove</param>
        public void RemoveAuditLog(string auditLogId)
        {

        }





    }
}
