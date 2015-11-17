using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.IO;

namespace FacebookApplication
{
    class LikeAnalyzer
    {
        Dictionary<User, int> m_LikeDataAnalysis;
        User m_LoggedUser;
        AnalysisProgressBar m_progressBarForm;

        public LikeAnalyzer(User i_LoggedUser)
        {
            m_LikeDataAnalysis = new Dictionary<User, int>();
            m_LoggedUser = i_LoggedUser;
        }

        public void CalculateLikeToList(int i_NumOfPosts)
        {
            initProgressBar(i_NumOfPosts);
            //Reset the Dictionary
            m_LikeDataAnalysis.Clear();

            // iterating all the posts 
            //foreach (Post postCurrentlyCalculating in m_LoggedUser.Posts)
            for (int i = 0; i < i_NumOfPosts; i++)
            {
                // iterating all user who liked the post
                foreach (User userWhoLikedThePost in m_LoggedUser.Posts[i].LikedBy)
                {
                    // if the user already appeared in previous calculations
                    if (checkIfUserExistsInDictionary(userWhoLikedThePost))
                    {
                        updateRecordInDictionary(userWhoLikedThePost);
                        //int likeCountForCurrentCalculatedUser = m_LikeDataAnalysis[userWhoLikedThePost];
                        //likeCountForCurrentCalculatedUser++;
                        //m_LikeDataAnalysis[userWhoLikedThePost] = likeCountForCurrentCalculatedUser;                    
                    }
                    else
                    {
                        m_LikeDataAnalysis.Add(userWhoLikedThePost, 1);
                    }
                }

                m_progressBarForm.incrementProgressBar();
            }
        }

        private void initProgressBar(int i_NumOfPosts)
        {
            if (m_progressBarForm != null)
            {
                m_progressBarForm.resetProgress(i_NumOfPosts);
            }
            else
            {
                m_progressBarForm = new AnalysisProgressBar(i_NumOfPosts);
                m_progressBarForm.Show();
            }
        }

        private bool checkIfUserExistsInDictionary(User i_UserToCheck)
        {
            bool doesExist = false;

            foreach (User userInDictionary in m_LikeDataAnalysis.Keys)
            {
                if (userInDictionary.Name.Equals(i_UserToCheck.Name))
                {
                    doesExist = true;
                    break;
                }
            }

            return doesExist;
        }

        private void updateRecordInDictionary(User i_UserToUpdate)
        {
            foreach (User userInDictionary in m_LikeDataAnalysis.Keys)
            {
                if (userInDictionary.Name.Equals(i_UserToUpdate.Name))
                {
                    int currentUserAmountOfLikesInDictionary = m_LikeDataAnalysis[userInDictionary];
                    currentUserAmountOfLikesInDictionary++;
                    m_LikeDataAnalysis[userInDictionary] = currentUserAmountOfLikesInDictionary;
                    break;
                }
            }
        }

        public List<User> GetDescendingTopLikeUserList()
        {
            List<User> topLikeUsers = new List<User>();

            foreach (KeyValuePair<User, int> currentPairInCalculatedData in m_LikeDataAnalysis.OrderByDescending(Key => Key.Value))
            {
                topLikeUsers.Add(currentPairInCalculatedData.Key);
            }

            return topLikeUsers;
        }

        public int GetAmountOfLikesByUser(User i_UserToCheck)
        {
            int amountOfLikes = 0;

            if (m_LikeDataAnalysis.ContainsKey(i_UserToCheck))
            {
                amountOfLikes = m_LikeDataAnalysis[i_UserToCheck];
            }

            return amountOfLikes;
        }

    }
}
