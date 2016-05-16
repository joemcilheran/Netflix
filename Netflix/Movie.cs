using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Movie: Title
    {
        int duration;
        public Movie(int Duration, int Rating, string Name,string Genre)
        {
            rating = Rating;
            duration = Duration;
            name = Name;
            genre = Genre;
        }
        public override void display_title(Title movie)
        {
            Console.WriteLine(movie.ToString());
        }
        public override string ToString()
        {
            string movieString = String.Format("{0}:  {1} stars, {2} minutes", name, rating, duration);
            return movieString;          
        }
    }
}
