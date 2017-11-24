using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingApplication
{
    /// <summary>
    ///  This class handles all interaction with the database
    ///  including refreshing data at a set interval
    /// </summary>
    class DatabaseHandler
    {
        private string DatabaseName;
        private string DatabaseUsername;
        private string DatabasePassword;
        private Timer UpdateTimer;
        private SqlConnection mySqlConnection;

        /// <summary>
        /// The class constructor. 
        /// </summary>
        public DatabaseHandler(string DatabaseName, string DatabaseUsername, string DatabasePassword)
        {
            this.DatabaseName = DatabaseName;
            this.DatabaseUsername = DatabaseUsername;
            this.DatabasePassword = DatabasePassword;
            mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\c3453855\Documents\TestDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        }

        /// <summary>
        /// <para>Method used to submit a query.</para>
        /// <param name="Query"><para>Query to be used to search.</para> Add '?' to you query where your parameters would be if they are required</param>
        /// <param name="Parameters"><para>Parameters to be added to query.</para> <para>Pass an empty array if there are no parameters to be added</para></param>
        /// <returns><para>Returns a string array with your results</para></returns>
        /// </summary>
        public string[] SubmitQuery(string Query, string[] Parameters)
        {
            if (Query.Equals(null))
            {
                throw new Exception("invalid query");
            }
            else
            {
                if (!Parameters.Equals(null) && Parameters.Length != 0)
                {
                    int count = 0;
                    int y = 0;
                    while (y < Query.Length  )
                        {
                        if (Query[y].Equals('?'))
                        {
                            count++;
                        }
                        y++;
                    } 

                    Console.WriteLine("MEOWWWWWW");

                    if (count == Parameters.Length)
                    {
                        //we can continue
                        //we can split on ?
                        string[] QuerySplit = Query.Split('?');
                        for (int x = 0; x < QuerySplit.Length; x++)
                        {
                            Query = QuerySplit[x] + Parameters[x];
                            if (Parameters[x+1].Length <= 1)
                            {
                                break;
                            }
                        }
                        Console.WriteLine(Query);
                    }
                    else
                    {
                        throw new Exception("Number of parameters do not match markers");
                    }
                }
                Console.WriteLine("hello");


            }
            string[] meow = new string[100];
            
            return meow ;
        }

        public void RefreshProjectLogs()
        {

        }

        public void Test()
        {
            String[] myData = new String[100];
            
            

            String selcmd = "SELECT * FROM music ";


            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);


            mySqlConnection.Open();


            SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            int i = 0;
            while (mySqlDataReader.Read())
            {
                Console.WriteLine(mySqlDataReader["song_name"]); //reads a line of the query result at a time
                myData[i++] = (String)mySqlDataReader["song_name"]; //store in an array too for use later

            }

            for (int j = 0; j < i; j++) //now iterate through our good old, bog standard array
            {
                Console.WriteLine("***" + myData[j] + "***");
            }

        }

    }
}
