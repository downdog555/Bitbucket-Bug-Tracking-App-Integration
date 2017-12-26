using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingApplication
{
    /// <summary>
    /// Class to hold and provide functionalit to the bug location
    /// </summary>
    class BugLocation
    {
        /// <summary>
        /// the line number where the bug starts
        /// </summary>
        private int lineNum;
        /// <summary>
        /// the method block where the bug is
        /// </summary>
        private string methodBlock;
        /// <summary>
        /// the class name which the bug resides in
        /// </summary>
        private string className;

        /// <summary>
        /// getters and setters
        /// </summary>
        public int LineNum { get { return lineNum; } set { lineNum = value; } }

        /// <summary>
        /// getters and setters
        /// </summary>
        public string MethodBlock { get { return methodBlock; } set { methodBlock = value; } }

        /// <summary>
        /// getters and setters
        /// </summary>
        public string ClassName { get { return className; } set { className = value; } }

        /// <summary>
        /// gets an array with the bugs location
        /// </summary>
        /// <returns>String array in format of Line Number, Method Block, Class Name</returns>
        public string[] GetBugLocation()
        {
            string[] location = { lineNum.ToString(), methodBlock, className };
            return location;
        }

        /// <summary>
        /// method provided to update the bug location on mass
        /// </summary>
        /// <param name="lineNum">the line number for the bug</param>
        /// <param name="methodBlock">the name of the method block where the bug is located</param>
        /// <param name="className">the name of the calss where the bug is located</param>
        public void UpdateBugLocation(int lineNum, string methodBlock, string className)
        {
            this.lineNum = lineNum;
            this.methodBlock = methodBlock;
            this.className = className;
        }

        /// <summary>
        /// Method to update the bug lcoation with a bug location object provided
        /// </summary>
        /// <param name="bg">bug location object</param>
        public void UpdateBugLocation(BugLocation bg)
        {
            this.lineNum = bg.LineNum;
            this.methodBlock = bg.MethodBlock;
            this.className = bg.ClassName;
        }
    }
}
