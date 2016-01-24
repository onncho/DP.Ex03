using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections;

namespace FacebookApplication
{
    public class FacbookCategoryPages
    {
        private User m_LoggedUser;

        //public IFetcher Fetcher { get; set; }

        public List<Page> PagesList { get; set; }

        PagesCollectionIterator m_PagesCollection;

        IEnumerator m_PagesIterateCollection;

        string m_CategoryField;

        public FacbookCategoryPages(User i_LoggedUser)
        {
            m_LoggedUser = i_LoggedUser;

            m_PagesCollection = new PagesCollectionIterator(m_LoggedUser, " ");
            m_PagesIterateCollection = (m_PagesCollection as IEnumerable).GetEnumerator();

        }
        
        public void fetch()
        {
            PagesList = new List<Page>();

            while (m_PagesIterateCollection.MoveNext())
            {
                // Add here template Method or strategy
                Page page = m_PagesIterateCollection.Current as Page;
                m_CategoryField = "";
                if (m_CategoryField == "Musician/Band")
                {
                    PagesList.Add(page);
                }
            }
        }
    }
}