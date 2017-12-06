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
    public class AuditLog
    {
        private int auditLogId;
        private string message;
        private string createdOn;
        private string ownerName;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="auditLogId">Id string of this log</param>
        /// <param name="bugId">Id string of the bug</param>
        /// <param name="message">Message of the audit log</param>
        /// <param name="ownerId">Id string of the owner of this log</param>
        /// <param name="ownerName">Username of the owner of this log</param>
        /// <param name="bugLoc">A BugLocation object to represent he location</param>
        public AuditLog(int auditLogId,  string message, string createdOn, string ownerName)
        {
            this.auditLogId = auditLogId;
            this.message = message;
            this.createdOn = createdOn;
            this.ownerName = ownerName;
        }

        /// <summary>
        /// getter and setter for message
        /// </summary>
        public string Message { get => message; set => message = value; }

        /// <summary>
        /// getter for ownerID
        /// </summary>
        public string CreatedOn { get => createdOn; }

        /// <summary>
        /// getter for owner name
        /// </summary>
        public string OwnerName { get => ownerName;  }






    }
}
