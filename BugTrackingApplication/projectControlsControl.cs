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
    public partial class projectControlsControl : UserControl
    {
        private Bug b;
        private Project p;
        private MainWindow mw;
        public projectControlsControl(Bug b, Project p, MainWindow mw)
        {
            InitializeComponent();
            this.b = b;
            this.p = p;
            this.mw = mw;
        }

        private void projectControlsControl_Load(object sender, EventArgs e)
        {

        }
    }
}
