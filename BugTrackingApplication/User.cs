using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpBucket.V1;
using SharpBucket.V1.Pocos;
using SharpBucket.V2;
using SharpBucket.V2.Pocos;


namespace BugTrackingApplication
{
    /// <summary>
    /// Class representing a user
    /// </summary>
   public class User
    {
        private bool logged;
        private string username;
        private string password;
        private string accountName = null;
        private SharpBucketV1 v1Api;
        private SharpBucketV2 v2Api;


        /// <summary>
        /// Constructor for a user
        /// </summary>
        /// <param name="username">the username of the current user</param>
        /// <param name="password">the password of the current user</param>
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;

            this.logged = true;
            //we need to get the consumer key and secretkey
            
            v1Api = new SharpBucketV1();
            v1Api.BasicAuthentication(username, password);
            try
            {
                this.accountName = v1Api.UserEndPoint().GetInfo().user.username;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            v2Api = new SharpBucketV2();
            v2Api.BasicAuthentication(username, password);
        }

        /// <summary>
        /// Gets the account name for the repositories
        /// </summary>
        public string AccountName { get => accountName; }

        /// <summary>
        /// gets the api object for the Version 1 api
        /// </summary>
        public SharpBucketV1 V1Api { get => v1Api; }

        /// <summary>
        /// Gets the v2 api for bitbucket
        /// </summary>
        public SharpBucketV2 V2Api { get => v2Api; }

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
/**
        private void ReadDataOauth()
        {
            // Reads test data information from a file, you should structure it like this:
            // By default it reads from c:\
            // ApiKey:yourApiKey
            // SecretApiKey:yourSecretApiKey
            // AccountName:yourAccountName
            // Repository:testRepository
            //Console.WriteLine(Directory.GetFiles(@"H:\test\").ToString());

            var lines = File.ReadAllLines(@"H:\test\TestInformationOauth.txt");
            consumerKey = lines[0].Split(':')[1];
            Console.WriteLine(consumerKey);
            consumerSecretKey = lines[1].Split(':')[1];
            accountName = lines[2].Split(':')[1];
        }
    **/
    }
}
