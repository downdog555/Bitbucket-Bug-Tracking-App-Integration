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
    /// 
    public class Bug
    {
        /// <summary>
        /// List of audit logs relating to this bug
        /// </summary>
        private List<AuditLog> logs = new List<AuditLog>();
        /// <summary>
        /// The ID of the bug
        /// </summary>
        private int bugID;
        /// <summary>
        /// When this bug was created on
        /// </summary>
        private string createdOn;
        /// <summary>
        /// The revision this bug applies to
        /// </summary>
        private string revision;
        /// <summary>
        /// The class name where the bug is located
        /// </summary>
        private string className;
        /// <summary>
        /// the method name that the bug is a part of
        /// </summary>
        private string method;
        /// <summary>
        /// The line number where the bug is located
        /// </summary>
        private string lineNum;
        /// <summary>
        /// The actual issue of the bug such as how to reproduce it
        /// </summary>
        private string issue;
        /// <summary>
        /// who the bug was reported by
        /// </summary>
        private string createdby;
        /// <summary>
        /// whom is reponsible for fixing the bug
        /// </summary>
        private string responsible;
        /// <summary>
        /// The title of the bug
        /// </summary>
        private string title;
        /// <summary>
        /// the status of the bug
        /// </summary>
        private string status;

        /// <summary>
        /// Constructor for Bug Class
        /// </summary>
        /// <param name="revision">Revision hash if exists</param>
        /// <param name="className">Class name of where the bug resides</param>
        /// <param name="method">Method where the bug resides</param>
        /// <param name="lineNum">Line num of where the bug resides</param>
        /// <param name="issue">Comment relating to the bug</param>
        /// <param name="createdby">Who this was created By</param>
        public Bug( string revision, string className, string method, string lineNum, string issue, string createdby, string title, string status)
        {
          
            this.revision = revision;
            this.className = className;
            this.method = method;
            this.lineNum = lineNum;
            this.issue = issue;
            this.createdby = createdby;
            this.title = title;
            this.status = status;
            
        }

        /// <summary>
        /// Add an audit log to the bug 
        /// </summary>
        /// <param name="log">The log to be added</param>
        public void AddAuditLog(AuditLog log)
        {
            logs.Add(log);
        }

        /// <summary>
        /// Flips the list of audit logs so the latest log is at the end
        /// </summary>
        public void FlipList()
        {
            logs.Reverse();
        }
        
        /// <summary>
        /// Getter and setter for Revision
        /// </summary>
        public string Revision { get { return revision; } set { revision = value; } }
        /// <summary>
        /// Getter and setter for Class Name
        /// </summary>
        public string ClassName { get { return className; } set { className = value; } }
        /// <summary>
        /// Getter and setter for Method name
        /// </summary>
        public string Method { get { return method; } set { method = value; } }
        /// <summary>
        /// Getter and setter for Line Number
        /// </summary>
        public string LineNum { get { return lineNum; } set { lineNum = value; } }
        /// <summary>
        /// Getter and setter for Issue
        /// </summary>
        public string Issue { get { return issue; } set { issue = value; } }
        /// <summary>
        /// Getter and setter for Created By
        /// </summary>
        public string CreatedBy { get { return createdby; } set { createdby = value; } }
        /// <summary>
        /// Getter and setter for Bug ID
        /// </summary>
        public int BugID { get { return bugID; } set { bugID = value; } }
        /// <summary>
        /// Getter and setter for Created on
        /// </summary>
        public string CreatedOn { get { return createdOn; } set { createdOn = value; } }
        /// <summary>
        /// Getter for the audit logs
        /// </summary>
        public List<AuditLog> Logs { get { return logs; } }
        /// <summary>
        /// Getter and setter for Who is repsonsible for the bug
        /// </summary>
        public string Responsible { get { return responsible; } set { responsible = value; } }
        /// <summary>
        /// Getter and setter for the title of the bug
        /// </summary>
        public string Title { get { return title; } set { title = value; } }
        /// <summary>
        /// Getter and setter for Status of the bug
        /// </summary>
        public string Status { get { return status; } set { status = value; } }
    }
}
