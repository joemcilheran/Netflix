using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Netflix;

namespace NetlfixTest
{
    [TestClass]
    public class MovieTest
    {
        [TestMethod]
        public void TestToString()
        {
            Movie movie = new Movie(90, 5, "Movie", "action");
            string expected = "Movie:  5 stars, 90 minutes";
            movie.ToString();
            string actual = movie.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
