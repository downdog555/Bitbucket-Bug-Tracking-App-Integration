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
    /// Class representing the main form area for the application
    /// </summary>
    public partial class MainWindow : Form
    {
        private User u;
        private DatabaseHandler db;
        private List<List<string>> projects;

        public MainWindow(User u, DatabaseHandler db)
        {
            InitializeComponent();

            this.u = u;
            this.db = db;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM projects";
            string[] param = null;
            projects = db.SubmitQuery(query, param);
            Console.WriteLine(projects.Count);
            projects_table.RowCount = projects.Count + 1;
            projects_table.


        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
