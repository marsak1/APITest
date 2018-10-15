using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITest.Utilities.Objects
{
    public class Response
    {
        private static int statusCode;


        public static int StatusCode
        {
            get { return statusCode; }
            set { statusCode = value; }
        }
    }
}
