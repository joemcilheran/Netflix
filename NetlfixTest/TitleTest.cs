using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Netflix;

namespace NetlfixTest
{
    [TestClass]
    public class TitleTest 
    {
        [TestMethod]
        public void TestplusOperatorOverload()
        {
            Movie movie1 = new Movie(90, 5, "movie1", "action");
            Movie movie2 = new Movie(123, 3, "movie2", "romance");
            Assert.IsInstanceOfType((movie1 + movie2),typeof(Genre));
        }
    }
}
