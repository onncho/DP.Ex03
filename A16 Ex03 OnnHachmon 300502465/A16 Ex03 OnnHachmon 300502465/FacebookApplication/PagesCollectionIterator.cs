using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookApplication
{
    // Enumerator
    public class PagesCollectionIterator : IEnumerable
    {
        private List<Page> m_MusicPages;
        private User m_LoggedUser;

        public PagesCollectionIterator(User i_UserLoggedIn, string i_CategoryField)
        {
            m_LoggedUser = i_UserLoggedIn;
            
            // Strategy
            m_MusicPages = m_LoggedUser.LikedPages.ToList().FindAll((Page page) => page.Category == i_CategoryField);
        }

        public IEnumerator GetEnumerator()
        {
            return new PageIterator(this);
        }

        // Iterator
        private class PageIterator : IEnumerator
        {
            private PagesCollectionIterator m_Pages;
            private int m_CurrentIndex = -1;
            private int m_Count = -1;

            public PageIterator(PagesCollectionIterator i_PageList)
            {
                m_Pages = i_PageList;
                m_Count = m_Pages.m_MusicPages.Count;
            }

            public int GetPagesCount()
            {
                return m_Count;
            }

            public object Current
            {
                get { return m_Pages.m_MusicPages[m_CurrentIndex]; }
            }

            public string CurrentName
            {
                get { return m_Pages.m_MusicPages[m_CurrentIndex].Name; }
            }

            public bool MoveNext()
            {
                if (m_Count != m_Pages.m_MusicPages.Count)
                {
                    throw new Exception("Error during Iteration");
                }

                if (m_CurrentIndex >= m_Count)
                {
                    throw new Exception("No More Items in Collection");
                }

                return ++m_CurrentIndex < m_Count;
            }

            public void Reset()
            {
                m_CurrentIndex = -1;
            }
        }
    }
}
