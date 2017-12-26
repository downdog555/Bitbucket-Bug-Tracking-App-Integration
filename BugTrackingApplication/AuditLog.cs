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
        /// <summary>
        /// the ID of the audit log
        /// </summary>
        private int auditLogId;
        /// <summary>
        /// The message that is in the audit log
        /// </summary>
        private string message;
        /// <summary>
        /// When the audit log was created
        /// </summary>
        private string createdOn;
        /// <summary>
        /// Whom created the audit log
        /// </summary>
        private string ownerName;
        /// <summary>
        /// When the audit log was last updated
        /// </summary>
        private string updatedOn;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="auditLogId">Id string of this log</param>
        /// <param name="bugId">Id string of the bug</param>
        /// <param name="message">Message of the audit log</param>
        /// <param name="ownerId">Id string of the owner of this log</param>
        /// <param name="ownerName">Username of the owner of this log</param>
        /// <param name="bugLoc">A BugLocation object to represent he location</param>
        public AuditLog(int auditLogId,  string message, string createdOn, string ownerName, string updatedOn)
        {
            this.auditLogId = auditLogId;
            this.message = message;
            this.createdOn = createdOn;
            this.ownerName = ownerName;
            this.updatedOn = updatedOn;
        }

        /// <summary>
        /// getter and setter for message
        /// </summary>
        public string Message { get {return message; } set { message = value; } }

        /// <summary>
        /// getter for ownerID
        /// </summary>
        public string CreatedOn { get { return createdOn; } }

        /// <summary>
        /// getter for owner name
        /// </summary>
        public string OwnerName { get { return ownerName; } }
        /// <summary>
        /// Getter for audit log id
        /// </summary>
        public int AuditLogId { get { return auditLogId; } }

        /// <summary>
        /// getter and setter for the update date
        /// </summary>
        public string UpdatedOn
        {
            get
            {
                return updatedOn;
            }

            set
            {
                updatedOn = value;
            }
        }
    }
}
