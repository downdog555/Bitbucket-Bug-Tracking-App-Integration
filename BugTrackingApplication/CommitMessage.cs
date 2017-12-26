using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingApplication
{
    /// <summary>
    /// Class represnting the commit form when editing the source code of a bug.
    /// </summary>
    public partial class CommitMessage : Form
    {
        /// <summary>
        /// The class that handels the editing of the source(Form containing a text area)
        /// </summary>
        private ViewBugSource bugSource;
        public CommitMessage(ViewBugSource vbs)
        {
            this.bugSource = vbs;
            InitializeComponent();
        }

        /// <summary>
        /// Function called when the create commit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createCommit_Click(object sender, EventArgs e)
        {
            //basic error checking
            if (messageBox.Text.Length < 10)
            {

                MessageBox.Show("The message needs to be longer than 10 charaters", "Message Needs to be longer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //calls bug source and commits with the message from this form
                bugSource.CommitFile(messageBox.Text);
                //then close this form
                this.Close();
            }
            
        }
    }
}
