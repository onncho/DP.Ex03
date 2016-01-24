using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public class LikedPages : IFetcher
    {
        private User m_LoggedUser;

        public LikedPages(User i_LoggedUser)
        {
            m_LoggedUser = i_LoggedUser;
        }
        public object getFacebookObjectCollection()
        {
           return m_LoggedUser.LikedPages;
        }
    }
}
