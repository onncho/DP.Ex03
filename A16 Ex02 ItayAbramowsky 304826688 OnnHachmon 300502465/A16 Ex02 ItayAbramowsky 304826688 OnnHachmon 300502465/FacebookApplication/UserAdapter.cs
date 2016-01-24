using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public class UserAdapter 
    {
        private User m_User;

        public int AmountOfLikesGiven { get; set; }

        public FacebookObjectCollection<Post> Posts 
        {
            get
            {                
                return m_User.Posts;
            }
        }
        
        public string Name 
        {
            get
            {
                return m_User.Name;
            }
        }
        
        public Image ImageNormal 
        {
            get
            {
                return m_User.ImageNormal;
            }
        }

        public UserAdapter(User i_UserInProxy)
        {
            m_User = i_UserInProxy;
        }
    }
}