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
    public class ProjectTests
    {
        [TestMethod()]
        public void ProjectConstructorTest()
        {
            Project project = new Project("test","test","test");
            Assert.IsNotNull(project);
        }

        [TestMethod()]
        public void ResetBugListTest()
        {
            Project project = new Project("test", "test", "test");
            project.AddBug(new Bug("test", "test", "test", "test", "test", "test", "test", "test"));
            project.ResetBugList();
            Assert.IsTrue(project.Bugs.Count == 0);
        }

        [TestMethod()]
        public void AddBugTest()
        {
            Project project = new Project("test", "test", "test");
            project.AddBug(new Bug("test", "test", "test", "test", "test", "test", "test", "test"));

            Assert.IsTrue(project.Bugs.Count == 1);
        }

        [TestMethod()]
        public void ProjectToStringTest()
        {
            Project project = new Project("test", "this is the project name", "test");
            Assert.IsTrue(project.ProjectName.Equals("this is the project name"));
        }
    }
}