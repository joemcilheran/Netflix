using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Netflix;
using System.Collections.Generic;

namespace NetlfixTest
{
    [TestClass]
    public class GenreTest
    {
        [TestMethod]
        public void TestgenreGenrePlusOperator()
        {
            List<Title> genre1titleList = new List<Title>();
            Genre genre1 = new Genre(genre1titleList, "genre1");
            List<Title> genre2titleList = new List<Title>();
            Genre genre2 = new Genre(genre2titleList, "genre2");
            Assert.IsInstanceOfType((genre1 + genre2), typeof(Genre));       
        }
        [TestMethod]
        public void TestgenreTitlePlusOperator()
        {
            List<Title> genre1titleList = new List<Title>();
            Genre genre = new Genre(genre1titleList, "genre");
            Movie movie = new Movie(124, 4, "movie", "horror");
            Assert.IsInstanceOfType((genre + movie), typeof(Genre));
        }

    }
}
