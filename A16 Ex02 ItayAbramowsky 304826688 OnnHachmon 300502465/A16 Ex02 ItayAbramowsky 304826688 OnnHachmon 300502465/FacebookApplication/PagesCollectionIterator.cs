using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections;

namespace FacebookApplication
{

    // The concrete aggregate. 
    public class PagesCollectionIterator : IEnumerable
    {
       // private readonly List<Page> m_AllPages;
        private List<Page> m_MusicPages;
        User m_LoggedUser;

        public PagesCollectionIterator(User i_UserLoggedIn, String i_CategoryField)
        {
            
            // TODO: Add Filter To Music
            m_LoggedUser = i_UserLoggedIn;
            //List<Page> LikedPages = m_LoggedUser.LikedPages.CopyTo(LikedPages, );
            m_MusicPages = m_LoggedUser.LikedPages.ToList().FindAll((Page page) => page.Category == i_CategoryField);
        }

        public IEnumerator GetEnumerator()
        {
            return new PageFeatureNameIterator(this);
        }

        // The ConcreteIterator.
        private class PageFeatureNameIterator : IEnumerator
        {
            private PagesCollectionIterator m_PageFeatures;

            private int m_CurrentIndex = -1;
            private int m_Count = -1;

            public PageFeatureNameIterator(PagesCollectionIterator i_Collection)
            {
                m_PageFeatures = i_Collection;
                m_Count = m_PageFeatures.m_MusicPages.Count;
            }

            public int GetPagesCount()
            {
                return m_Count;
            }

            public object Current
            {
                get { return m_PageFeatures.m_MusicPages[m_CurrentIndex]; }
            }

            public string CurrentName
            {
                get { return m_PageFeatures.m_MusicPages[m_CurrentIndex].Name; }
            }

            public bool MoveNext()
            {
                if (m_Count != m_PageFeatures.m_MusicPages.Count)
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
