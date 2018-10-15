using APITest.Actions;
using APITest.Helpers;
using APITest.Models;
using APITest.Schemas;
using AutoFixture;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;


namespace APITest.Steps
{
    [Binding]
    public class UsersSteps
    {
        UsersActions usersActions = new UsersActions();
        UserSchemas schema;
        User newUser, updatedUser, userResponse;
        string errorMessage;

        [When(@"Users list is requested")]
        public void GivenUsersListIsRequested()
        {
            usersActions.GetListOfUsers();         
        }

        [When(@"User with id ""(.*)"" is requested")]
        [Given(@"User with id ""(.*)"" is requested")]
        public void GivenUserWithIdIsRequested(string id)
        {
            ScenarioContext.Current["id"] = id;
            userResponse = usersActions.GetUserById(id);
        }

        [Then(@"Response users schema is correct")]
        public void ThenResponseUsersSchamaIsCorrect()
        {
            Assert.True(usersActions.ValidatUsersArraySchema(), "Response users schema is not correct");
            //UserValidator.ValidateReturnedUserResponse(userResponse);
        }

        [Then(@"Response user schema is correct")]
        public void ThenResponseUserSchemaIsCorrect()
        {
            var id = ScenarioContext.Current.Get<String>("id");
            Assert.True(usersActions.ValidatUserSchema(id), "Response user schema is not correct");
        }

        [Then(@"User id is correct")]
        public void ThenUserIdIsCorrect()
        {
            var id = ScenarioContext.Current.Get<String>("id");
            Assert.AreEqual(id, userResponse.id.ToString(), "User id is not correct");
        }

        [Given(@"User object is filled with random data")]
        public void GivenUserObjectIsPopulatedWithRandomData()
        {
            var fixture = new Fixture();
            newUser = fixture.Create<User>();
        }

        [When(@"User upload his data")]
        public void WhenUserUploadHisData()
        {
            userResponse = usersActions.PostUser(newUser);
        }
    
        [Then(@"User is correctly added")]
        public void ThenUserIsCorrectlyAdded()
        {
            Assert.That(newUser.id, Is.EqualTo(userResponse.id));
            Assert.That(JsonConvert.SerializeObject(newUser), Is.EqualTo(JsonConvert.SerializeObject(userResponse)));
        }

        [When(@"Selected user ""(.*)"" email update is requested")]
        public void WhenSelectedUserEmailUpdateIsRequested(string id)
        {
            userResponse.email = "test@test.pl";
            updatedUser = usersActions.PutUser(userResponse, id);
        }

        [Then(@"User email is updated")]
        public void ThenUserEmailIsUpdated()
        {
            Assert.AreEqual(userResponse.email, updatedUser.email, "User email is not updated");
        }

        [When(@"Delete user with id ""(.*)"" is requested")]
        public void WhenDeleteUserWithIdIsRequested(string id)
        {
            var deleteResponse = usersActions.DeleteUser(id);
            ScenarioContext.Current["deleteResponse"] = deleteResponse;
        }

        [Then(@"Response is empty")]
        public void ThenResponseIsEmpty()
        {
            var deleteResponse = ScenarioContext.Current.Get<String>("deleteResponse");
            Assert.AreEqual("{}", deleteResponse, "User has not been deleted");
        }

        [When(@"User upload his data with id ""(.*)"" and other data is random")]
        public void WhenUserUploadHisDataWithIdAndOtherDataIsRandom(int id)
        {
            errorMessage = usersActions.PostUserWithIdAndRandomData(id);
        }

        [Then(@"Error message ""(.*)"" appears")]
        public void ThenErrorMessageAppears(string message)
        {
            Assert.True(errorMessage.Contains(message), "Error message is incorrect");
        }

        
    }
}
