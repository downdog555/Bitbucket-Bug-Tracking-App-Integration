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
            /**
            //Console.WriteLine("meow");
            //db.Test();
            string[] param = { "cat" };

            List<List<string>> tempo = db.SubmitQuery("SELECT * FROM music WHERE artist_name = ?", param);
            Console.WriteLine("hello");
            foreach (List<string> m in tempo)
            {
                foreach (string s in m)
                {
                    Console.WriteLine(s);
                }
            }
    **/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
            //verify values


            //search using db 
            string[] param = { username };
            List<List<string>> users = db.SubmitQuery("SELECT * FROM users WHERE username = ?", param);
            foreach (List<string> m in users)
            {
                if (m.ElementAt(2).Equals(password))
                {
                    //we can then setup the user
                    user = new User(m.ElementAt(1), m.ElementAt(2), m.ElementAt(0), m.ElementAt(3));
                    this.Hide();
                    mw = new MainWindow(user, db);
                    mw.Show();
                
                    break;
                }
            }

        }
    }
}
