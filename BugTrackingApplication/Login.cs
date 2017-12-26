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
    /// Class that represents first form to be opened in program and the login form
    /// </summary>
    public partial class Login : Form
    {
       /// <summary>
       /// The user that is going to be loggedin/authorised
       /// </summary>
        private User user;

        /// <summary>
        /// THe main window object to be shown when authorisation is complete
        /// </summary>
        private MainWindow mw;

        /// <summary>
        /// Constructor
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        


        /// <summary>
        /// called when exit button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Called when login button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //get values 
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            

            //we can then call the user constructor
            user = new User(username, password);
            //if the account name is not set it means the user was not authorised/the data could not be recieved
            if (user.AccountName == null)
            {
                MessageBox.Show("Cannot Authenticate User. Incorrect Details entered or Lack of Internet Connection", "Error: Cannot Authenticate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }   
            //create the mainwindow passing the current user to it
            mw = new MainWindow(user);
            //show mainwindow
            mw.Show();

            this.Hide();
                   
            
        }

       

        /// <summary>
        /// Function called when key is pressed. Used to add a shortcut when logging in(allows enter to activate the login button click)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
