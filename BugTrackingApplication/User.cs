using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingApplication
{
    /// <summary>
    /// Class representing a user
    /// </summary>
   public class User
    {
        private string username;
        private string password;
        private string id;
        private string name;

        /// <summary>
        /// Constructor for a user
        /// </summary>
        /// <param name="username">the username of the current user</param>
        /// <param name="password">the password of the current user</param>
        public User(string username, string password, string id, string name)
        {
            this.username = username;
            this.password = password;
            this.id = id;
            this.name = name;
        }

        /// <summary>
        /// Login function
        /// </summary>
        /// <returns>boolean based on success or not</returns>
        public bool Login()
        {

            return false;
        }

        /// <summary>
        /// logout function, destroys the user
        /// </summary>
        /// <returns>boolean based on success</returns>
        public bool Logout()
        {
            return false;
        }
    }
}
