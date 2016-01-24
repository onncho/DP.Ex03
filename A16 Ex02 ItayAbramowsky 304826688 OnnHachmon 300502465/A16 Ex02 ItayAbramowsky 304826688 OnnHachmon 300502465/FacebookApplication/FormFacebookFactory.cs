using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public static class FormFacebookFactory
    {
        public static Form CreateFacebookForm(Type i_TypeOfForm, User i_LoggedUser)
        {
            Form requestedForm = null;         
            if (i_TypeOfForm.Equals(typeof(LikeAnalyzerForm)))
            {
                requestedForm = new LikeAnalyzerForm(i_LoggedUser);
            }
            else if (i_TypeOfForm.Equals(typeof(FormMusic)))
            {
                requestedForm = new FormMusic(i_LoggedUser);
            }

            return requestedForm;
        }
    }
}
