using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTrackingApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BugTrackingApplication.Tests
{
    /// <summary>
    /// Test calss for the User class
    /// </summary>
    [TestClass()]
    public class UserTests
    {

        /// <summary>
        /// Checks if the user logs in propperly
        /// </summary>
        [TestMethod()]
        public void UserTestCorrectDetails()
        {
            User user = new User("test1@rsmithsolutions.co.uk", "Password1");
            
            Assert.IsTrue(user.Logged);
            
        }

        /// <summary>
        /// checks with false details
        /// </summary>
        [TestMethod()]
        public void UserTestFalseDetailsBoolCheck()
        {
            User user = new User("test1@rsmithsolutions.uk", "meowww");
            Assert.IsFalse(user.Logged);
        }

        /// <summary>
        /// this checks again with false details however by trying to access the sharpbucket api with wont be authorised if details are false
        /// </summary>
        [TestMethod()]
        public void UserTestFalseDetailsPropertyCheck()
        {
            User user = new User("test1@rsmithsolutions.uk", "meowww");
            
             
            Assert.IsNull(user.V1Api.UserEndPoint().GetInfo());
        }
    }
}