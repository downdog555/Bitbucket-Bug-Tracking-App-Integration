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
        private int Line_Num;
        private string Method_Block;
        private string Class_Name;
        /// <summary>
        /// getters and setters
        /// </summary>
        public int Line_Num1 { get => Line_Num; set => Line_Num = value; }
        /// <summary>
        /// getters and setters
        /// </summary>
        public string Method_Block1 { get => Method_Block; set => Method_Block = value; }
        /// <summary>
        /// getters and setters
        /// </summary>
        public string Class_name1 { get => Class_Name; set => Class_Name = value; }

        /// <summary>
        /// gets an array with the bugs location
        /// </summary>
        /// <returns>String array in format of Line Number, Method Block, Class Name</returns>
        public string[] GetBugLocation()
        {
            string[] location = {Line_Num.ToString(), Method_Block, Class_Name };
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
            this.Line_Num = lineNum;
            this.Method_Block = methodBlock;
            this.Class_Name = className;
        }
    }
}
