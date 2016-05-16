using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    
    abstract class Title
    {
        public string name;
        public int? rating;
        public string genre;
        public Title(string Name, int Rating,string Genre)
        {
            name = Name;
            rating = Rating;
            genre = Genre;
        }
        public Title()
        {
            name = null;
            rating = null;
            genre = null;
        }
        public virtual int? Rating
        {
            get
            {
                return rating;
            }

        }
        public virtual void display_title(Title title)
        {
            

        }
        public static Genre operator+(Title title1, Title title2)
        {
            List<Title> titleList = new List<Title>() { title1, title2 };
            string genreName = String.Format("{0}/{1}", title1.name, title2.name );
            Genre newGenre = new Genre(titleList, genreName);
            return newGenre;
            
        }

        
    }
}
