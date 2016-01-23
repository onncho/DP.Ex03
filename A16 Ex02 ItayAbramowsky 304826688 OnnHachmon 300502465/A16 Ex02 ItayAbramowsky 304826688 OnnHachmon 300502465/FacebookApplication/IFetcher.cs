using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    interface IFetcher
    {
        object getFieldFilter(object i_Object, string i_propName);
    }
}
