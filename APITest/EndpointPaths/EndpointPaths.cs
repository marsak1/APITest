using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITest.Paths
{
    public class EndpointPaths
    {
        private static string usersPath = "users";
        private static string photosPath = "photos";


        public static string GetUserPath
        {
            get { return usersPath; }
        }

        public static string GetUserPathById(string id)
        {
            return usersPath + "/" + id;
        }

        public static string GetPhotosPath
        {
            get { return photosPath; }
        }
    }
}
