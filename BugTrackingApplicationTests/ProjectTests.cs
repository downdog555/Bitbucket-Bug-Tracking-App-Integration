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
    /// Test class for the project class
    /// </summary>
    [TestClass()]
    public class ProjectTests
    {
        /// <summary>
        /// tests if the project construcotr works correctly
        /// </summary>
        [TestMethod()]
        public void ProjectConstructorTest()
        {
            Project project = new Project("test","test","test");
            Assert.IsNotNull(project);
        }

        /// <summary>
        /// Checks if the reset bug list method works properly
        /// </summary>
        [TestMethod()]
        public void ResetBugListTest()
        {
            Project project = new Project("test", "test", "test");
            project.AddBug(new Bug("test", "test", "test", "test", "test", "test", "test", "test", "test"));
            project.ResetBugList();
            Assert.IsTrue(project.Bugs.Count == 0);
        }

        /// <summary>
        /// checksi if a bug can be added to a project
        /// </summary>
        [TestMethod()]
        public void AddBugTest()
        {
            Project project = new Project("test", "test", "test");
            project.AddBug(new Bug("test", "test", "test", "test", "test", "test", "test", "test", "test"));

            Assert.IsTrue(project.Bugs.Count == 1);
        }

        /// <summary>
        /// checks if the override of to string works correctly
        /// </summary>
        [TestMethod()]
        public void ProjectToStringTest()
        {
            Project project = new Project("test", "this is the project name", "test");
            Assert.IsTrue(project.ProjectName.Equals("this is the project name"));
        }
    }
}