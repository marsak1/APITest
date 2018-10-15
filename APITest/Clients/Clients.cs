using APITest.Utilities.Configurations;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITest.Client
{
    class Clients
    {
        private static RestClient client;

        public static RestClient GetRestClient()
        {
            client = new RestClient(TestConfiguration.BaseUri);
            return client;
        }
    }
}
