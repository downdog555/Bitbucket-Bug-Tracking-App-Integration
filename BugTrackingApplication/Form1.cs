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
    public partial class Form1 : Form
    {
        private DatabaseHandler db = new DatabaseHandler("u", "sa","asd");
        private User user;
        private MainWindow mw;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            //we need to use basic auth on the user account to get the api keys

                    //we can then setup the user
                    user = new User(username, password);
                    
                    mw = new MainWindow(user, db);
                    mw.Show();
                    this.Hide();
                   
            
        }
    }
}
