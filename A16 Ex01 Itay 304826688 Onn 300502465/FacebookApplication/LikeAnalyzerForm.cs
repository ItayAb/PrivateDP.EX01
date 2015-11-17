using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookApplication
{
    public partial class LikeAnalyzerForm : Form
    {
        LikeAnalyzer m_LikeAnalyzer;
        User m_LoggedUser;

        public LikeAnalyzerForm(User i_LoggedUser)
        {
            InitializeComponent();
            if (i_LoggedUser != null)
            {
                m_LoggedUser = i_LoggedUser;
                initUiLikeAnaylzer();
            }
        }

        public User LoggedUser
        {
            get
            {
                return m_LoggedUser;
            }

            set
            {
                m_LoggedUser = value;
            }
        }

        public void initUiLikeAnaylzer()
        {
            pictureBoxCoverPhoto.LoadAsync(m_LoggedUser.Cover.SourceURL);            
            labelNameOfUser.Text = m_LoggedUser.Name;
            textBoxAmountOfPosts.Text = m_LoggedUser.Posts.Count.ToString();
        }

        private void button_RunAnalysis_Click(object sender, EventArgs e)
        {
            runLikeAnalysis();
        }

        private void resetUiForAnalysis()
        {
            listBoxRecentPost.Items.Clear();
            listBoxDescendingLikeFriends.Items.Clear();
        }

        private void runLikeAnalysis()
        {                        
            resetUiForAnalysis();
            if (m_LoggedUser != null)
            {
                int numOfPosts;
                m_LikeAnalyzer = new LikeAnalyzer(m_LoggedUser);
                if (int.TryParse(textBoxAmountPostsToParse.Text, out numOfPosts))
                {
                    // see if there are any posts to parse
                    if (numOfPosts > m_LoggedUser.Posts.Count || numOfPosts < 1)
                    {
                        MessageBox.Show(string.Format("The max value is {0}, min value is 0", m_LoggedUser.Posts.Count));
                    }
                    else
                    {
                        m_LikeAnalyzer.CalculateLikeToList(numOfPosts);
                    }
                }

                updateUi();
            }
            else
            {
                MessageBox.Show("Please login first");
            }
        }

        private void updateUi()
        {
            listBoxDescendingLikeFriends.Items.Clear();
            List<User> likers = m_LikeAnalyzer.GetDescendingTopLikeUserList();
            listBoxDescendingLikeFriends.DisplayMember = "Name";
            listBoxRecentPost.DisplayMember = "Message";

            foreach (User likeUser in likers)
            {
                listBoxDescendingLikeFriends.Items.Add(likeUser);

            }
        }

        private void listBoxDescendingLikeFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxRecentPost.Items.Clear();
            User selectedUser = listBoxDescendingLikeFriends.SelectedItem as User;
            if (selectedUser != null)
            {
                PictureBoxSelectedFriend.LoadAsync(selectedUser.PictureNormalURL);
                string amountOfLikesStr = m_LikeAnalyzer.GetAmountOfLikesByUser(selectedUser).ToString();
                textBoxAmountOfLikeForUser.Text = amountOfLikesStr;

                for (int i = 0; i < selectedUser.Posts.Count; i++)
                {
                    listBoxRecentPost.Items.Add(selectedUser.Posts[i]);
                }
            }

        }

        private void buttonLikeBack_Click(object sender, EventArgs e)
        {
            likeBackUserChosenPost();
        }

        private void likeBackUserChosenPost()
        {
            if (m_LoggedUser !=null)
            {
                if (listBoxRecentPost.SelectedItems.Count < 1)
                {
                    MessageBox.Show("Please select a post to like back");
                }
                else
                {
                    foreach (object postToLike in listBoxRecentPost.SelectedItems)
                    {
                        Post chosenPost = postToLike as Post;
                        if (chosenPost != null)
                        {
                            chosenPost.Like();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please login first");
            }
        }
    }
}
