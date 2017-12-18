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
    public partial class CommitMessage : Form
    {
        private ViewBugSource bugSource;
        public CommitMessage(ViewBugSource vbs)
        {
            this.bugSource = vbs;
            InitializeComponent();
        }

        private void createCommit_Click(object sender, EventArgs e)
        {
            if (messageBox.Text.Length < 10)
            {

                MessageBox.Show("The message needs to be longer than 10 charaters", "Message Needs to be longer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bugSource.CommitFile(messageBox.Text);
                this.Close();
            }
            
        }
    }
}
