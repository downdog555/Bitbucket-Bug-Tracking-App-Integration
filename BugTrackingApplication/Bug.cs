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
    [Serializable]
    public class Bug
    {
        private List<AuditLog> logs = new List<AuditLog>();

        private int bugID;
        private string createdOn;
        private string revision;
        private string className;
        private string method;
        private string lineNum;
        private string issue;
        private string createdby;

        /// <summary>
        /// Constructor for Bug Class
        /// </summary>
        /// <param name="revision">Revision hash if exists</param>
        /// <param name="className">Class name fo where the bug resides</param>
        /// <param name="method">Method where the bug resides</param>
        /// <param name="lineNum">Line num of where the bug resides</param>
        /// <param name="issue">Comment relating to the bug</param>
        /// <param name="createdby">Who this was created By</param>
        public Bug( string revision, string className, string method, string lineNum, string issue, string createdby)
        {
          
            this.revision = revision;
            this.className = className;
            this.method = method;
            this.lineNum = lineNum;
            this.issue = issue;
            this.createdby = createdby;
            
        }

        /// <summary>
        /// Blank Constructor required for serilzation
        /// </summary>
        public Bug()
        {
            
            this.revision = "";
            this.className = "";
            this.method = "";
            this.lineNum = "";
            this.issue = "";
            this.createdby = "";
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
        //Getters and setters
        public string REVISION { get => revision; set => revision = value; }
        public string CLASSNAME { get => className; set => className = value; }
        public string METHOD { get => method; set => method = value; }
        public string LINENUM { get => lineNum; set => lineNum = value; }
        public string ISSUE { get => issue; set => issue = value; }
        public string CREATEDBY { get => createdby; set => createdby = value; }
        public int BugID { get => bugID; set => bugID = value; }
        public string CreatedOn { get => createdOn; set => createdOn = value; }
        internal List<AuditLog> Logs { get => logs; set => logs = value; }
    }
}
