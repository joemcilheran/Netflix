using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    public class Genre: IEnumerable
    {
        List<Title> titleList;
        public string name;
        public List<Title> TitleList
        {
            get
            {
                return titleList;
            }
        }
        public Genre(List<Title> genreTitlelist, string Name)
        {
            titleList = genreTitlelist;
            name = Name;
        }
        public static Genre operator+(Genre genre,Genre genre2)
        {
            List<Title> hybridTitleList = new List<Title>();
            foreach(Title title in genre.titleList)
            {
                if(genre2.titleList.Contains(title))
                {
                    hybridTitleList.Add(title);
                }
            }
            string genreName = String.Format("{0}/{1}", genre.name, genre2.name);
            Genre hybridGenre = new Genre(hybridTitleList,genreName);
            return hybridGenre;
        }
        public IEnumerator GetEnumerator()
        {
            foreach(Title title in titleList)
            {
                yield return title;
            }
        }
        public static Genre operator+(Genre genre, Title title)
        {
            List<Title> plusOneTitleList = new List<Title>();
            plusOneTitleList.Add(title);
            plusOneTitleList.AddRange(genre.titleList);
            string genreName = String.Format("{0} and {1}", genre.name, title.name);
            Genre plusOneGenre = new Genre(plusOneTitleList,genreName);
            return plusOneGenre;
        }




    }
}
