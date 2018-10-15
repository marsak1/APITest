using APITest.Models;
using NUnit.Framework;


namespace APITest.Helpers
{
    public static class UserValidator
    {
        public static void ValidateReturnedUserResponse(User user)
        {       
            Assert.IsNotNull(user.name);
            Assert.IsNotNull(user.username);
            Assert.IsNotNull(user.email);
            Assert.IsNotNull(user.address.street);
            Assert.IsNotNull(user.address.suite);
            Assert.IsNotNull(user.address.city);
            Assert.IsNotNull(user.address.zipcode);
            Assert.IsNotNull(user.address.geo.lat);
            Assert.IsNotNull(user.address.geo.lng);
            Assert.IsNotNull(user.phone);
            Assert.IsNotNull(user.website);
            Assert.IsNotNull(user.company.name);
            Assert.IsNotNull(user.company.catchPhrase);
            Assert.IsNotNull(user.company.bs);           
        }
    }
}
