/*
Author: Hae Yeon (Lucy) Kang
Date: 2016-03-06
Application: Assignment2
Description: This application will display tweets from other user's timeline or by hashtag.
*/

using System;
using System.Linq;
using System.Windows.Forms;
using TweetSharp;

namespace Assignment2
{
    public partial class twitterNewsfeeder : Form
    {
        TwitterService sTwitterService; //interact with Twitter

        //keys to access to the twuitter account
        const string consumerKeyString = "BEH8IXcJmeo8fPtbgWjzPJJVs";
        const string consumerSecretString = "MP0IOA79lx8933XfJT4B2Fn08adm5Q0udmnTY38iaf0GTMdAf5";
        const string tokenString = "223717690-qVkQXWvxl7DvTfVSvqQHjcsJW54usgzGn7beOX9z";
        const string tokenSecret = "Qrd7Q4vgOd5XzDVZ4rFKHMW5mp1n4znwpJfST9sQB8FNs";


        public twitterNewsfeeder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initiate a new twitter service
            sTwitterService = new TwitterService(consumerKeyString, consumerSecretString);
            //authenticate connection
            sTwitterService.AuthenticateWith(tokenString, tokenSecret);

            //when the form is loaded, initialise it with blank fields.
            numOfTweetsTextBox.Text = "";
            handleTextBox.Text = "";
            resultRichTextBox.Text = "";
        }

        //search by user
        private void userBtn_Click(object sender, EventArgs e)
        {
            try //try and catch Parse conversion error.
            {
                //change the string entered by the user to integer type and store that into the variable.
                int numOfTweets = int.Parse(numOfTweetsTextBox.Text);

                if (numOfTweets <= 0) //validate if the # Tweets is not negative value or zero.
                {
                    MessageBox.Show("The # Tweets cannot be negative value or zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (handleTextBox.Text.Length == 0) //validate if anything was entered in handle/hastag field.
                {
                    MessageBox.Show("Please enter the @username in the Handle/HashTag field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //when everything is validated, run the following code.
                {
                    ListTweetsOnUserTimelineOptions lt = new ListTweetsOnUserTimelineOptions();
                    lt.ScreenName = handleTextBox.Text; //get the screenname to find its tweets.
                    lt.Count = numOfTweets; //get the number of tweets to display.

                    //retrieve and store tweets from the screenname's timeline into a variable.
                    var tweets = sTwitterService.ListTweetsOnUserTimeline(lt);

                    //in case there was a result from previous search, reset the textbox.
                    resultRichTextBox.Text = "";

                    try
                    {
                        if (tweets.Any()) //if there is any tweet, display them as much as it was specified by the user.
                        {
                            foreach (var tweet in tweets)
                            {
                                resultRichTextBox.Text += "User Name: " + tweet.User.ScreenName + "\nTweet: " + tweet.Text + "\nTwitted Date: " + tweet.CreatedDate + "\n---------------------------------\n";
                            }
                        }
                        else //if there's none, throw exception.
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception) //handles null exception by displaying message.
                    {
                        resultRichTextBox.Text = "No Tweets Found.";
                    }
                }
            }
            catch (Exception) //handles exception for Parse convertion.
            {
                MessageBox.Show("You did not enter valid value in the \"# Tweets\" field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }//end of userBtn_Click

        //search by hashtag
        private void hashTagBtn_Click(object sender, EventArgs e)
        {
            try //try and catch Parse conversion error.
            {
                int numOfTweets = int.Parse(numOfTweetsTextBox.Text);

                if (numOfTweets <= 0) //validation for # Tweets
                {
                    MessageBox.Show("The number of tweets cannot be negative value or zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else if (handleTextBox.Text.Length == 0) //validation for handle/hashtag field
                {
                    MessageBox.Show("Please enter a #word in the Handle/HashTag field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //when validation was successful, continue.
                {
                    SearchOptions so = new SearchOptions();
                    so.Q = handleTextBox.Text; // the Hashtag to look for 
                    so.Count = numOfTweets; // the number of tweets to obtain 

                    var results = sTwitterService.Search(so); //store the searched results in the variable results.

                    //in case there was a result from previous search, reset the textbox.
                    resultRichTextBox.Text = "";

                    try
                    {
                        if (results.Statuses.Any()) // verify if any tweets exist, if there's any, display them.
                        { 
                            foreach (var result in results.Statuses)
                            {
                                resultRichTextBox.Text += "User Name: " + result.User.ScreenName + "\nTweet: " + result.Text + "\nTwitted Date: " + result.CreatedDate + "\n---------------------------------\n";
                            }
                        }
                        else //if there's none, throw exception.
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception) //handles null exception by displaying message.
                    {
                        resultRichTextBox.Text = "No Tweets Found.";
                    }
                }
            }
            catch (Exception) //handles exception for Parse convertion.
            {
                MessageBox.Show("You did not enter valid value in the \"# Tweets\" field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//end of hashTagBtn_Click

        //close the app when exit button is clicked.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //display a message box when user clicks about menu.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Name: Twitter Newsfeeder\n" +
                "Author: Hae Yeon (Lucy) Kang\n" +
                "Last Updated: 2016-03-06\n" +
                "This application displays tweets by specified user or by hashtag as much as the number of the ."
                , "About Twitter Newfeeder", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
    }
}
