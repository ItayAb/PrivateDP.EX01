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
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace FacebookApplication
{
    public partial class FormMain : Form
    {
        private string m_PathOfAppDataFile = string.Format("{0}\\{1}", AppDomain.CurrentDomain.BaseDirectory, "Facebook App Config.txt");
        private const string k_AppId = "843647649088563";
        private User m_LoggedInUser;
        private LikeAnalyzerForm m_likeAnalyzerForm;

        private ApplicationConfigurationData m_AppConfig;

        public FormMain()
        {
            m_AppConfig = new ApplicationConfigurationData();

            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 1000;

            if (SaveLoadUtil.LoadAppData(m_PathOfAppDataFile, ref m_AppConfig))
            {
                if (m_AppConfig.RememberMe)
                {
                    autoLogin();
                }
            }
        }

        private void autoLogin()
        {
            LoginResult resultOfLogin = FacebookService.Connect(m_AppConfig.AccessToken);
            if (resultOfLogin != null)
            {
                m_LoggedInUser = resultOfLogin.LoggedInUser;
                fillUserInformation();
            }
            else
            {
                MessageBox.Show("Error in autoLogin");
            }
        }

        private void loginAndInit()
        {
            // allready logged in
            if (m_LoggedInUser != null)
            {
                MessageBox.Show(string.Format("Already logged in as {0} {1}", m_LoggedInUser.FirstName, m_LoggedInUser.LastName));
            }
            else
            {
                LoginResult result = FacebookService.Login(k_AppId, /// (desig patter's "Design Patterns Course App 2.4" app)
                    "public_profile",
                    "user_education_history",
                    "user_birthday",
                    "user_actions.video",
                    "user_actions.news",
                    "user_actions.music",
                    "user_actions.fitness",
                    "user_actions.books",
                    "user_about_me",
                    "user_friends",
                    "publish_actions",
                    "user_events",
                    "user_games_activity",
                    "user_groups", // (This permission is only available for apps using Graph API version v2.3 or older.)
                    "user_hometown",
                    "user_likes",
                    "user_location",
                    "user_managed_groups",
                    "user_photos",
                    "user_posts",
                    "user_relationships",
                    "user_relationship_details",
                    "user_religion_politics",

                    //"user_status" (This permission is only available for apps using Graph API version v2.3 or older.)
                    "user_tagged_places",
                    "user_videos",
                    "user_website",
                    "user_work_history",
                    "read_custom_friendlists",

                    // "read_mailbox", (This permission is only available for apps using Graph API version v2.3 or older.)
                    "read_page_mailboxes",
                    // "read_stream", (This permission is only available for apps using Graph API version v2.3 or older.)
                    // "manage_notifications", (This permission is only available for apps using Graph API version v2.3 or older.)
                    "manage_pages",
                    "publish_pages",
                    "publish_actions",

                    "rsvp_event"
                    );

                if (!string.IsNullOrEmpty(result.AccessToken))
                {
                    m_AppConfig.AccessToken = result.AccessToken;
                    m_LoggedInUser = result.LoggedInUser;
                    fillUserInformation();
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
        } 

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void fillUserInformation()
        {
            // setting the images profile & cover 
            if (!string.IsNullOrEmpty(m_LoggedInUser.PictureNormalURL))
            {
                pictureProfilePhoto.LoadAsync(m_LoggedInUser.PictureNormalURL);
            }

            if (!string.IsNullOrEmpty(m_LoggedInUser.Cover.SourceURL))
            {
                pictureCoverPhoto.LoadAsync(m_LoggedInUser.Cover.SourceURL);
            }

            // writing the posts to the 'news feed' (needs work)
            for (int i = 0; i < m_LoggedInUser.Posts.Count; i++)
            {
                if (m_LoggedInUser.Posts[i].Message != null)
                {
                    if (m_LoggedInUser.Posts[i].Caption != null)
                    {
                        listBoxPosts.Items.Add(string.Format("{0}     {1}", m_LoggedInUser.Posts[i].Message, m_LoggedInUser.Posts[i].Caption));
                    }
                    else
                    {
                        listBoxPosts.Items.Add(m_LoggedInUser.Posts[i].Message);
                    }
                }
            }

            checkBoxRemeberMe.Checked = m_AppConfig.RememberMe;
        }

        private void buttonLikeAnalyzer_Click(object sender, EventArgs e)
        {
            m_likeAnalyzerForm = new LikeAnalyzerForm(m_LoggedInUser);
            m_likeAnalyzerForm.ShowDialog();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //  m_RememberMe = checkBox_RememberMe.Checked ? true : false;
            SaveLoadUtil.SaveAppData(m_PathOfAppDataFile, m_AppConfig);
            base.OnClosing(e);
        }

        private void checkBoxRemeberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRemeberMe.Checked)
            {
                m_AppConfig.RememberMe = true;
            }
            else
            {
                m_AppConfig.RememberMe = false;
            }
        }
    }
}
