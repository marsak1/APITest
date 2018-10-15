using APITest.Utilities.Objects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace APITest.Steps
{
    [Binding]
    public class General
    {
        [Then(@"Response status code is ""(.*)""")]
        public void ThenResponseStatusCodeIs(int code)
        {
            Assert.AreEqual(code, Response.StatusCode, "Status code is incorrect");
        }


    }
}
