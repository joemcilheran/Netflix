using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Netflix;

namespace NetflixTest
{
    [TestClass]
    public class ShowTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void TestRatingPropertyThrowsException()
        {
            List<Episode> showEpisodeList = new List<Episode>();
            Show show = new Show("show", showEpisodeList, "romance");
            int? rating = show.Rating;           
        }
    }
}
