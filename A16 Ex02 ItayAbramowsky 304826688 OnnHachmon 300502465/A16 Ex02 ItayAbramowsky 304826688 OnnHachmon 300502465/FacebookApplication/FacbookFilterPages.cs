using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections;
using System.Reflection;

namespace FacebookApplication
{
    public class FacbookFilterPages
    {
        private User m_LoggedUser;

        public IFetcher Fetcher;

        public List<Page> MusicPagesList { get; set; }

        FacbookObjectIterator m_PagesCollection;

        IEnumerator m_PagesIterateCollection;

        


        public FacbookFilterPages(IEnumerable i_Fetcher)
        {
            //m_LoggedUser = i_LoggedUser;
            //Fetcher = i_Fetcher;
            m_PagesIterateCollection = i_Fetcher.GetEnumerator();
            
            //m_PagesCollection = new PagesIterator(Fetcher);
            //m_PagesIterateCollection = (m_PagesCollection as IEnumerable).GetEnumerator();
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

        private object getFieldFilter(object i_Object, string i_propName)
        {
            return i_Object.GetType().GetProperty(i_propName).GetValue(i_Object, null);
        }
    }
}