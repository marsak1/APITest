using APITest.Models;
using APITest.Utilities.Configurations;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITest.Controllers
{
    class UsersController : GeneralController
    {
        private IRestResponse<User> responseUser;
        private IRestResponse<List<User>> responseUsersList;
        private IRestResponse response;

        /*
        public IRestResponse<List<User>> GetUsers()
        {
            request = new RestRequest(endpoint, Method.GET);
            responseUsersList = GetRestClient().Execute<List<User>>(request);
            return responseUsersList;
        }

        public IRestResponse<User> GetUserById(string id)
        {
            request = new RestRequest(endpoint + "/{id}", Method.GET);
            request.AddUrlSegment("id", id);
            responseUser = GetRestClient().Execute<User>(request);
            return responseUser;
        }

        public IRestResponse<User> PostUser(User user)
        {
            request = new RestRequest(endpoint, Method.POST);
            request.AddJsonBody(user);
            responseUser = GetRestClient().Execute<User>(request);
            return responseUser;
        }

        public IRestResponse<User> PutUser(User user, string id)
        {
            request = new RestRequest(endpoint + "/{id}", Method.PUT);
            request.AddUrlSegment("id", id);
            request.AddJsonBody(user);
            responseUser = GetRestClient().Execute<User>(request);
            return responseUser;
        }

        public IRestResponse DeleteUser(string id)
        {
            request = new RestRequest(endpoint + "/{id}", Method.DELETE);
            request.AddUrlSegment("id", id);
            response = GetRestClient().Execute(request);
            return response;
        }
        */
    }


}
