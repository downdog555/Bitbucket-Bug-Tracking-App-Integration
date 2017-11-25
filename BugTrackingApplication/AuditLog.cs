using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingApplication
{
    /// <summary>
    /// Class representing an audit log, it contains the message of the log and the owner
    /// </summary>
    class AuditLog
    {
        private string auditLogId;
        private string bugId;
        private string message;
        private string ownerId;
        private string ownerName;
        private BugLocation bugLoc;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="auditLogId">Id string of this log</param>
        /// <param name="bugId">Id string of the bug</param>
        /// <param name="message">Message of the audit log</param>
        /// <param name="ownerId">Id string of the owner of this log</param>
        /// <param name="ownerName">Username of the owner of this log</param>
        /// <param name="bugLoc">A BugLocation object to represent he location</param>
        public AuditLog(string auditLogId, string bugId, string message, string ownerId, string ownerName, BugLocation bugLoc)
        {
            this.auditLogId = auditLogId;
            this.bugId = bugId;
            this.message = message;
            this.ownerId = ownerId;
            this.ownerName = ownerName;
            this.bugLoc = bugLoc;
        }

        /// <summary>
        /// getter and setter for message
        /// </summary>
        public string Message { get => message; set => message = value; }

        /// <summary>
        /// getter for ownerID
        /// </summary>
        public string OwnerId { get => ownerId; }

        /// <summary>
        /// getter for owner name
        /// </summary>
        public string OwnerName { get => ownerName;  }

        /// <summary>
        /// Updates the bug location for this log
        /// </summary>
        /// <param name="lineNum">Line number of this bug</param>
        /// <param name="methodBlock">Method block that the bug is a part of</param>
        /// <param name="className">Class of the bug</param>
        public void UpdateBugLocation(int lineNum, string methodBlock, string className)
        {
            bugLoc.UpdateBugLocation(lineNum, methodBlock, className);
        }

        /// <summary>
        /// Method to update hte bug location relating to this audit log
        /// </summary>
        /// <param name="bg">Bug Location object</param>
        public void UpdateBugLocation(BugLocation bg)
        {
            bugLoc.UpdateBugLocation(bg);
        }



    }
}
