﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections;
using System.Reflection;

namespace FacebookApplication
{
    public class FacbookMusicPages : IFetcher
    {
        private User m_LoggedUser;

        //public IFetcher Fetcher { get; set; }

        public List<Page> MusicPagesList { get; set; }

        PagesFilter m_PagesCollection;

        IEnumerator m_PagesIterateCollection;


        public FacbookMusicPages(User i_LoggedUser)
        {
            m_LoggedUser = i_LoggedUser;

            m_PagesCollection = new PagesFilter(m_LoggedUser);
            m_PagesIterateCollection = (m_PagesCollection as IEnumerable).GetEnumerator();
        }
        
        public void fetch()
        {
            MusicPagesList = new List<Page>();

            while (m_PagesIterateCollection.MoveNext())
            {
                // TODO: Add here template Method or strategy
                Page page = m_PagesIterateCollection.Current as Page;

                // TODO: Change To Parameter
                if ((string) (getFieldFilter(page , "Category")) == "Musician/Band")
                {
                    MusicPagesList.Add(page);
                }
            }
        }


        public object getFieldFilter(object i_Object, string i_propName)
        {
            return i_Object.GetType().GetProperty(i_propName).GetValue(i_Object, null);
        }

    }
}