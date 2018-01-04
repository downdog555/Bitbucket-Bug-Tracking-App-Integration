using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTrackingApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingApplication.Tests
{
    [TestClass()]
    public class BugTests
    {
        [TestMethod()]
        public void BugConstructorTest()
        {
            Bug bug = new Bug("test1","test2","test3","test4","test5","test6","test7","test8","test9");
            Assert.IsTrue(bug.Revision.Equals("test1"));
            Assert.IsTrue(bug.ClassName.Equals("test2"));
            Assert.IsTrue(bug.Method.Equals("test3"));
            Assert.IsTrue(bug.LineNum.Equals("test4"));
            Assert.IsTrue(bug.Issue.Equals("test5"));
            Assert.IsTrue(bug.CreatedBy.Equals("test6"));
            Assert.IsTrue(bug.Title.Equals("test7"));
            Assert.IsTrue(bug.Status.Equals("test8"));
            Assert.IsTrue(bug.LineNumEnd.Equals("test9"));

        }

        [TestMethod()]
        public void AddAuditLogTest()
        {
            AuditLog ad1 = new AuditLog(1, "", "", "", "");
            Bug bug = new Bug("", "", "", "", "", "", "", "","");
            bug.AddAuditLog(ad1);
            Assert.IsTrue(bug.Logs.Count == 1);
        }

        [TestMethod()]
        public void FlipListTest()
        {
            AuditLog ad1 = new AuditLog(1, "","","","");
            AuditLog ad2 = new AuditLog(2, "", "", "", "");
            Bug bug = new Bug("","","","","","","","","");
            bug.AddAuditLog(ad1);
            bug.AddAuditLog(ad2);
            bug.FlipList();
            Assert.IsTrue(bug.Logs.ElementAt(1).AuditLogId == 1);
        }
    }
}