using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using YouTubeSearch;

namespace FacebookApplication
{
    public class YouTubeProxy
    {
        private readonly string r_YouTubeChannelLink = "https://www.youtube.com/channel/";
        private readonly string r_YouTubeVideoLink = "https://www.youtube.com/watch?v=";
        private readonly string r_YouTubeVideoLinkForPlayer = "https://www.youtube.com/v/";
        private Dictionary<string, List<YouTubeVideo>> m_CacheVideos;
        private YouTubeClass m_YouTubeSearchObject;
        private List<Tuple<string, string>> m_YouTubeSearchResult;
        private List<YouTubeVideo> m_YouTubeVideoList;

        public string Musician { get; set; }

        public List<YouTubeVideo> YouTubeVideoList
        {
            get 
            { 
                SearchProxy();
                return m_YouTubeVideoList;
            }

            set 
            {
               m_YouTubeVideoList = value;   
            }
        }
        
        /// <summary>
        /// Search if The Artist is Locally stores or go and Search him on YouTube
        /// Also Create List of Video Object for the MUISC FORM
        /// </summary>
        public void SearchProxy()
        {
            // check if the Dictionary was initilized
            if (m_CacheVideos == null)
            {
                m_CacheVideos = new Dictionary<string, List<YouTubeVideo>>();
            }

            if (m_CacheVideos.ContainsKey(Musician))
            {
                m_YouTubeVideoList = m_CacheVideos[Musician];
            }
            else
            {
                searchYouTube();
                updateCached();

                if (m_CacheVideos.ContainsKey(Musician))
                {
                    m_YouTubeVideoList = m_CacheVideos[Musician];
                } 
            }
        }

        private void searchYouTube()
        {
            // initate the youtube object
            if (m_YouTubeSearchObject == null)
            {
                m_YouTubeSearchObject = new YouTubeSearch.YouTubeClass();
            }
            else
            {
                m_YouTubeSearchObject.getMusicianVideos.Clear();
                
                if (m_YouTubeSearchResult != null)
	            {
                    m_YouTubeSearchResult.Clear();
	            }
            }

            try
            {
                m_YouTubeSearchObject.YouTubeSearch(Musician);
                
                m_YouTubeSearchResult = new List<Tuple<string, string>>(m_YouTubeSearchObject.getMusicianVideos);

                Console.WriteLine("Finished Search");
            }
            catch (Exception error)
            {
                Console.Error.Write(error);
            }
        }

        private void updateCached()
        {
            List<YouTubeVideo> videoList = new List<YouTubeVideo>();

            if (m_YouTubeSearchObject != null)
            {
                foreach (Tuple<string, string> tupleRunner in m_YouTubeSearchResult)
                {
                    YouTubeVideo videoToAdd = new YouTubeVideo();
                    videoToAdd.VideoKey = tupleRunner.Item2;
                    videoToAdd.VideoName = tupleRunner.Item1;
                    videoToAdd.VideoUrl = r_YouTubeVideoLink + tupleRunner.Item2;
                    videoToAdd.VideoLinkForPlayer = r_YouTubeVideoLinkForPlayer + tupleRunner.Item2;
                    videoToAdd.YouTubeChannelUrl = r_YouTubeChannelLink + m_YouTubeSearchObject.getMusicianChannelID;

                    videoList.Add(videoToAdd);
                }
            }

            if (videoList.Count > 0)
            {
                if (!m_CacheVideos.ContainsKey(Musician))
                {
                    m_CacheVideos.Add(Musician, videoList);
                }
            }
        }
    }
}
