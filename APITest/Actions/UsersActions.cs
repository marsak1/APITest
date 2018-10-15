using APITest.Controllers;
using APITest.Models;
using APITest.Paths;
using APITest.Schemas;
using APITest.Utilities.Objects;
using AutoFixture;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using RestSharp;
using System;
using System.Collections.Generic;


namespace APITest.Actions
{
    class UsersActions 
    {
        UsersController userController = new UsersController();
        UserSchemas userSchema = new UserSchemas();

        public List<User> GetListOfUsers()
        {
            IRestResponse<List<User>> response = userController.GetResponseListObject(new User(), EndpointPaths.GetUserPath);
            Response.StatusCode = (int)response.StatusCode;
            return response.Data;
        }

        public User GetUserById(string id)
        {
            IRestResponse<User> response = userController.GetResponseObjectUsingId(new User(), EndpointPaths.GetUserPath, id);
            Response.StatusCode = (int)response.StatusCode;
            return response.Data;
        }

        public User PostUser(User user)
        {
            IRestResponse<User> response = userController.PostObjectAsJson(user, EndpointPaths.GetUserPath);
            Response.StatusCode = (int)response.StatusCode;
            return response.Data;
        }

        public string PostUserWithIdAndRandomData(int id)
        {
            var fixture = new Fixture();
            User user = fixture.Build<User>().With(p => p.id, id).Create();

            IRestResponse<User> response = userController.PostObjectAsJson(user, EndpointPaths.GetUserPath);
            Response.StatusCode = (int)response.StatusCode;
            return response.Content;
        }

        public User PutUser(User user, string id)
        {
            IRestResponse<User> response = userController.PutObjectUsingId(user, EndpointPaths.GetUserPath, id);
            Response.StatusCode = (int)response.StatusCode;
            return response.Data;
        }

        public string DeleteUser(string id)
        {
            IRestResponse response = userController.DeleteObjectUsingId(EndpointPaths.GetUserPath, id);
            Response.StatusCode = (int)response.StatusCode;
            return response.Content;
        }

        public bool ValidatUsersArraySchema()
        {
            JArray user = JArray.Parse(JsonConvert.SerializeObject(GetListOfUsers()));
            return user.IsValid(userSchema.GetUsersSchema());
        }

        public bool ValidatUserSchema(string id)
        {
            JObject user = JObject.Parse(JsonConvert.SerializeObject(GetUserById(id)));
            return user.IsValid(userSchema.GetUserSchema());
        }
    }
}
