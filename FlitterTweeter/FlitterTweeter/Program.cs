using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Diagnostics;
using TweetSharp;
using TweetSharp.Model;

namespace FlitterTweeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //This app's unique Consumer Key (first argument) and Consumer Secret (second argument)
            TwitterService t_serv = new TwitterService("agvQyQIx2FFciJSpgCSwQ", "vdmcbG4EHveIQPA65WWzW1KYRFFFZY2B7MWFf2BHXqc");

            // Use this app's consumer info (consumer key and consumer secret) to get request token
            OAuthRequestToken r_token = t_serv.GetRequestToken();
            
            // Use request token and send user to Twitter to get a PIN
            Uri uri_1 = t_serv.GetAuthorizationUri(r_token); // get authorization URI using request token
            Process.Start(uri_1.ToString()); // 

            // Take in PIN and generate an access token and secret
            Console.WriteLine("Please enter the PIN number you received from Twitter: ");
            string ver_num = Console.ReadLine();
            OAuthAccessToken a_token = t_serv.GetAccessToken(r_token, ver_num);

            // Console.WriteLine("The PIN you entered was " + ver_num + ".");
            
            // authenticate using the access token and secret
            t_serv.AuthenticateWith(a_token.Token, a_token.TokenSecret);

            // get the tweets on the user's public timeline
            string user_sn = t_serv.GetUserProfile().ScreenName;

            Console.WriteLine("user id: " + user_sn);
            /*
            foreach (var tweet in lastTweets)
            {
                Console.WriteLine("{0} says {1}", tweet.User.ScreenName, tweet.Text);
            }
            */
           
            // step 4: save user data in a database

            // step 5: display database info in a webpage

            Console.ReadKey(true);
        }
    }
}
