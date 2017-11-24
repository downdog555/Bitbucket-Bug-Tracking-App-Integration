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
        DatabaseHandler db = new DatabaseHandler("u", "sa","asd");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("meow");
            db.Test();
            string[] param = { "cat" };

            db.SubmitQuery("SELECT * FROM music WHERE artist_name = ?", param);
        }
    }
}
