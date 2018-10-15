using System;
using System.Configuration;

namespace APITest.Utilities.Configurations
{
    public class TestConfiguration
    {
        public static String BaseUri
        {
            get { return ConfigurationManager.AppSettings["baseUri"]; }
        }        
    }
}
