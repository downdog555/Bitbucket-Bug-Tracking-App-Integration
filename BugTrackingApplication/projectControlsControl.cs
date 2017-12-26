using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingApplication
{
    /// <summary>
    /// Class to represent the controls for a project(adding stuff to a project)
    /// </summary>
    public partial class projectControlsControl : UserControl
    {
        private Bug b;
        private Project p;
        private MainWindow mw;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="b"></param>
        /// <param name="p"></param>
        /// <param name="mw"></param>
        public projectControlsControl(Bug b, Project p, MainWindow mw)
        {
            InitializeComponent();
            this.b = b;
            this.p = p;
            this.mw = mw;
        }

       
    }
}
