using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    public class ApplicationConfigurationData
    {
        private string m_AccessToken;
        private bool m_RememberMe = false;

        public ApplicationConfigurationData()
        {
        }

        public string AccessToken
        {
            get { return m_AccessToken; }
            set { m_AccessToken = value; }
        }

        public bool RememberMe
        {
            get { return m_RememberMe; }
            set { m_RememberMe = value; }
        }
    }
}
