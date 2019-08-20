using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.TEST
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetMyName()
        {
            var returnval = controller.Get(1);
            Assert.Equal("Brijen Makwana", returnval.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
