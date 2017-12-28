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
    public class UserTests
    {
        [TestMethod()]
        public void UserTestCorrectDetails()
        {
            User user = new User("test1@rsmithsolutions.co.uk", "Password1");
            
            Assert.IsTrue(user.Logged);
            
        }

        [TestMethod()]
        public void UserTestFalseDetailsBoolCheck()
        {
            User user = new User("test1@rsmithsolutions.uk", "meowww");
            Assert.IsFalse(user.Logged);
        }

        [TestMethod()]
        public void UserTestFalseDetailsPropertyCheck()
        {
            User user = new User("test1@rsmithsolutions.uk", "meowww");
            
             
            Assert.IsNull(user.V1Api.UserEndPoint().GetInfo());
        }
    }
}