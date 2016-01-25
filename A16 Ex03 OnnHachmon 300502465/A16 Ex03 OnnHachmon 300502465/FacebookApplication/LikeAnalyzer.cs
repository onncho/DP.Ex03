using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookApplication
{
    public class LikeAnalyzer
    {
        private Dictionary<User, int> m_LikeDataAnalysis;
        private User m_LoggedUser;

        public event EventHandler ParsedPost;

        public LikeAnalyzer(User i_LoggedUser)
        {
            m_LikeDataAnalysis = new Dictionary<User, int>();
            m_LoggedUser = i_LoggedUser;
        }

        public List<UserAdapter> DescendingListOfLikes
        {
            get
            {
                List<UserAdapter> topLikeUsers = new List<UserAdapter>();
                if (m_LikeDataAnalysis.Count > 0)
                {
                    foreach (KeyValuePair<User, int> currentPairInCalculatedData in m_LikeDataAnalysis.OrderByDescending(Key => Key.Value))
                    {
                        UserAdapter UserAdapter = new UserAdapter(currentPairInCalculatedData.Key);
                        UserAdapter.AmountOfLikesGiven = currentPairInCalculatedData.Value;
                        topLikeUsers.Add(UserAdapter);
                    }
                }

                return topLikeUsers;
            }
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

        public void CalculateLikeToList(int i_NumOfPosts)
        {
            // Reset the Dictionary
            m_LikeDataAnalysis.Clear();

            // iterating all the posts 
            for (int i = 0; i < i_NumOfPosts; i++)
            {
                // iterating all user who liked the post
                foreach (User userWhoLikedThePost in m_LoggedUser.Posts[i].LikedBy)
                {
                    // if the user already appeared in previous calculations
                    if (checkIfUserExistsInDictionary(userWhoLikedThePost))
                    {
                        updateRecordInDictionary(userWhoLikedThePost);
                    }
                    else
                    {
                        m_LikeDataAnalysis.Add(userWhoLikedThePost, 1);
                    }
                }

                onParsedPost();
            }
        }

        protected void onParsedPost()
        {
            if (ParsedPost != null)
            {
                ParsedPost.Invoke(this, null);
            }
        }

        private bool checkIfUserExistsInDictionary(User i_UserToCheck)
        {
            bool doesExist = false;

            foreach (User userInDictionary in m_LikeDataAnalysis.Keys)
            {
                if (userInDictionary.Id.Equals(i_UserToCheck.Id))
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
    }
}