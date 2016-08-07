using System;
using System.Linq;
using System.Windows.Forms;
using TweetSharp;

namespace twitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }

        private static TwitterService Baglan()
        {
            var service = new TwitterService("", "");
            service.AuthenticateWith("", "");
            return service;
        }

        private void ListeleUser(TwitterService service)
        {
            listBox1.Items.Clear();
            /*kullanıcı listeleme*/
            var list = service.ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions() { Count = 2700 });
            foreach (var item in list)
            {
                listBox1.Items.Add(item.Id + " " + item.User.ScreenName.ToString() + " " + item.Text.ToString());
            }
        }

        private void ListeleHome(TwitterService service)
        {
            listBox1.Items.Clear();
            /*anasayfa listeleme*/
            var list = service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions() { Count = 50 });
            foreach (var item in list)
            {
                listBox2.Items.Add(item.Id + " " + item.User.Id + " " + item.User.ScreenName.ToString() + " " + item.Text.ToString());
            }
        }

        private void ListeleFavorite(TwitterService service)
        {
            listBox1.Items.Clear();
            /*favorite listeleme*/
            var list = service.ListFavoriteTweets(new ListFavoriteTweetsOptions() { Count = 200 });
            foreach (var item in list)
            {
                listBox1.Items.Add(item.Id + " " + item.Text);
            }
        }

        private void MyDeleteMethod(TwitterService service)
        {
            var listString = listBox1.SelectedItems;

            foreach (var item in listString)
            {
                string i = item.ToString().Split(' ').ElementAt(0).ToString();

                service.DeleteTweet(new DeleteTweetOptions() { Id = long.Parse(i) });
            }
            ListeleUser(service);
        }

        private void btnTweetGonder_Click(object sender, EventArgs e)
        {
            var service = Baglan();
            service.SendTweet(new SendTweetOptions() { Status = textBox1.Text });
        }

        private void btnTweetListeleUser_Click(object sender, EventArgs e)
        {
            var service = Baglan();
            ListeleUser(service);
        }

        private void btnTweetSil_Click(object sender, EventArgs e)
        {
            var service = Baglan();
            MyDeleteMethod(service);
        }

        private void btnTweetListeleHome_Click(object sender, EventArgs e)
        {
            var service = Baglan();
            ListeleHome(service);
        }

        private void btnFavoriler_Click(object sender, EventArgs e)
        {
            var service = Baglan();
            ListeleFavorite(service);
        }
    }
}
