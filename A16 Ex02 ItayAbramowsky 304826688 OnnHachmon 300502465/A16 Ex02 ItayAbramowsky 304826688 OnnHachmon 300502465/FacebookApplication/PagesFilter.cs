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
    public class PagesFilter : IEnumerable
    {
       // private readonly List<Page> m_AllPages;
        private FacebookObjectCollection<Page> m_MusicPages;
        public int Count { get; private set; }

        public PagesFilter(User i_User)
        {
            // TODO: Add Filter To Music
            m_MusicPages = i_User.LikedPages;
            Count = m_MusicPages.Count;
        }

        public IEnumerator GetEnumerator()
        {
            return new PageFeatureNameIterator(this);
        }

        // The ConcreteIterator.
        private class PageFeatureNameIterator : IEnumerator
        {
            private PagesFilter m_PageFeatures;

            private int m_CurrentIndex = -1;
            private int m_Count = -1;

            public PageFeatureNameIterator(PagesFilter i_Collection)
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
