using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITest.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Address address { get; set; }
        public Company company { get; set; }
    }

    
    class UserBuider
    {
        private User user = new User();

        public UserBuider WithId(int id)
        {
            user.id = id;
            return this;
        }

        public UserBuider Withname(string name)
        {
            user.name = name;
            return this;
        }

        public UserBuider WithUsername(string username)
        {
            user.username = username;
            return this;
        }

        public UserBuider WithEmail(string email)
        {
            user.email = email;
            return this;
        }

        public UserBuider WithPhone(string phone)
        {
            user.phone = phone;
            return this;
        }

        public UserBuider WithWebsite(string website)
        {
            user.website = website;
            return this;
        }

        public User Build()
        {
            return user;
        }

    }
    
    
}
