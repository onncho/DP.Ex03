using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookApplication
{
    public class PageFilter
    {
        /*
        public object getFieldFilter(Page i_Object, string i_propName)
        {
            return i_Object.GetType().GetProperty(i_propName).GetValue(i_Object, null);
        }
         */

        public FacebookObjectCollection<Page> getFacebookObjectCollection(User i_LoggedUser)
        {
            return i_LoggedUser.LikedPages;
        }
    }
}
