using APITest.Client;
using APITest.Models;
using APITest.Utilities.Configurations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace APITest
{
    class GeneralController : Clients
    {
        public  static RestRequest request;
        public static IRestResponse response;
        public static string baseUrl = TestConfiguration.BaseUri;



        public IRestResponse GetResponse(string endpoint)
        {
            request = new RestRequest(endpoint, Method.GET);
            response = GetRestClient().Execute(request);
            return response;
        }
        
        public IRestResponse<TObject> GetResponseObject<TObject>(TObject obj, string endpoint) where TObject : new()
        {
            request = new RestRequest(endpoint, Method.GET);
            IRestResponse<TObject> response = GetRestClient().Execute<TObject>(request);
            return response;
        }

        public IRestResponse<List<TObject>> GetResponseListObject<TObject>(TObject obj, string endpoint) where TObject : new()
        {
            request = new RestRequest(endpoint, Method.GET);
            IRestResponse<List<TObject>> response = GetRestClient().Execute<List<TObject>>(request);
            return response;
        }

        public IRestResponse GetResponseUsingId(string endpoint, string id)
        {
            request = new RestRequest(endpoint + "/{id}", Method.GET);
            request.AddUrlSegment("id", id);
            response = GetRestClient().Execute(request);
            return response;
        }

        public IRestResponse<TObject> GetResponseObjectUsingId<TObject>(TObject obj, string endpoint, string id) where TObject : new()
        {
            request = new RestRequest(endpoint + "/{id}", Method.GET);
            request.AddUrlSegment("id", id);
            IRestResponse<TObject> response = GetRestClient().Execute<TObject>(request);
            return response;
        }

        public IRestResponse<TObject> PostObjectAsJson<TObject>(TObject obj , string endpoint) where TObject : new()
        {
            request = new RestRequest(endpoint, Method.POST);
            request.AddJsonBody(obj);
            IRestResponse<TObject> response = GetRestClient().Execute<TObject>(request);
            return response;
        }

        public IRestResponse<TObject> PutObjectUsingId<TObject>(TObject obj, string endpoint, string id) where TObject : new()
        {
            request = new RestRequest(endpoint + "/{id}", Method.PUT);
            request.AddUrlSegment("id", id);
            request.AddJsonBody(obj);
            IRestResponse<TObject> response = GetRestClient().Execute<TObject>(request);
            return response;
        }

        public IRestResponse DeleteObjectUsingId(string endpoint, string id) 
        {
            request = new RestRequest(endpoint + "/{id}", Method.DELETE);
            request.AddUrlSegment("id", id);
            IRestResponse response = GetRestClient().Execute(request);
            return response;
        }

    }
}
