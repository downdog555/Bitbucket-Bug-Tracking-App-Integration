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
    class Bug
    {
        private List<AuditLog> logs;

        private int bugID;
        private string createdOn;
        private string revision;
        private string className;
        private string method;
        private string lineNum;
        private string issue;
        private string createdby;

        public Bug( string revision, string className, string method, string lineNum, string issue, string createdby)
        {
          
            this.revision = revision;
            this.className = className;
            this.method = method;
            this.lineNum = lineNum;
            this.issue = issue;
            this.createdby = createdby;
        }

        public Bug()
        {
            
            this.revision = "";
            this.className = "";
            this.method = "";
            this.lineNum = "";
            this.issue = "";
            this.createdby = "";
        }


        public string REVISION { get => revision; set => revision = value; }
        public string CLASSNAME { get => className; set => className = value; }
        public string METHOD { get => method; set => method = value; }
        public string LINENUM { get => lineNum; set => lineNum = value; }
        public string ISSUE { get => issue; set => issue = value; }
        public string CREATEDBY { get => createdby; set => createdby = value; }
        public int BugID { get => bugID; set => bugID = value; }
        public string CreatedOn { get => createdOn; set => createdOn = value; }
    }
}
