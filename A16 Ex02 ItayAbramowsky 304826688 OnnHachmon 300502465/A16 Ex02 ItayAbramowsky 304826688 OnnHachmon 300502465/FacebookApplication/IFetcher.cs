using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookApplication
{
    public interface IFetcher
    {
        object getFacebookObjectCollection();
    }
}
