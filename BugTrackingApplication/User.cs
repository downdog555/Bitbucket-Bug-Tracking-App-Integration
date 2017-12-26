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
using RestSharp.Authenticators;
using RestSharp;


namespace BugTrackingApplication
{
    /// <summary>
    /// Class representing a user
    /// </summary>
    public class User
    {
        
        private string username;
        private string password;
        private string accountName = null;
        private SharpBucketV1 v1Api;
        private SharpBucketV2 v2Api;
        private RestClient client;


        /// <summary>
        /// Constructor for a user
        /// </summary>
        /// <param name="username">the username of the current user</param>
        /// <param name="password">the password of the current user</param>
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;

            
            //Sharp bucket has two versions of API so we authenticate with both as well as our own RESTSHARP client
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

            client = new RestClient("https://api.bitbucket.org/");
            client.Authenticator = new HttpBasicAuthenticator(username, password);
        }

        /// <summary>
        /// Gets the account name for the repositories
        /// </summary>
        public string AccountName { get { return accountName; } }

        /// <summary>
        /// gets the api object for the Version 1 api
        /// </summary>
        public SharpBucketV1 V1Api { get { return v1Api; } }

        /// <summary>
        /// Gets the v2 api for bitbucket
        /// </summary>
        public SharpBucketV2 V2Api { get { return v2Api; } }

        /// <summary>
        /// getter for the authenticator to make custom restsharp requests
        /// </summary>
        public RestClient Client { get { return client; } } 

        

    }
}
