using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    public class Episode
    {
        int rating;
        string name;
        public int Rating
        {
            get
            {
                return rating;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Episode(string episodeName, int episodeRating)
        {
            rating = episodeRating;
            name = episodeName;
        }
        public void display_episode(int rating, string name)
        {
            Console.WriteLine("\t{0}:  {1} stars", name, rating);
        }

    }
}
