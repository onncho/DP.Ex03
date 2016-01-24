using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    public class ApplicationConfigurationData
    {
        public ApplicationConfigurationData()
        {
            RememberMe = false;
        }
        
        public string AccessToken { get; set; }

        public bool RememberMe { get; set; }
    }
}