﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTrackingApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingApplication.Tests
{
    /// <summary>
    /// Test class for the audit log class
    /// </summary>
    [TestClass()]
    public class AuditLogTests
    {
        /// <summary>
        /// Test seeing if the audit log constructor assigns value properly
        /// </summary>
        [TestMethod()]
        public void AuditLogConstructorTest()
        {
            AuditLog log = new AuditLog(1,"test1","test2","test3","test4");
            Assert.IsTrue(log.AuditLogId == 1);
            Assert.IsTrue(log.Message.Equals("test1"));
            Assert.IsTrue(log.CreatedOn.Equals("test2"));
            Assert.IsTrue(log.OwnerName.Equals("test3"));
            Assert.IsTrue(log.UpdatedOn.Equals("test4"));
        }
    }
}