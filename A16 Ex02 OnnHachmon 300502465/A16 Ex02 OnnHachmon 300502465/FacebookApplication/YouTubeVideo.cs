using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    public class YouTubeVideo
    {
        public string VideoName { get; set; }

        public string VideoKey { get; set; }

        public string VideoUrl { get; set; }

        public string VideoLinkForPlayer { get; set; }

        public string YouTubeChannelUrl { get; set; }

        public override string ToString() 
        {
            return VideoName;
        }      
    }
}
