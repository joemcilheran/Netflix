using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    public class Show: Title
    {
        public List<Episode> episodeList;
        public int numberOfEpisodes;
        public Show(string Name,List<Episode> showEpisodeList, string Genre)
        {
            name = Name;
            episodeList = showEpisodeList;
            numberOfEpisodes = episodeList.Count;
            genre = Genre;
            

        }
        public override void display_title(Title show)
        {
            Console.WriteLine(show.ToString());
            foreach (Episode episode in episodeList)
            {
                episode.display_episode(episode.Rating, episode.Name);
            }
        }

        public override int? Rating
        {
            get
            {
                List<int> ratingList = new List<int>();
                foreach (Episode episode in episodeList)
                {
                    ratingList.Add(episode.Rating);
                }
                int aggregateRating = ((ratingList.Sum()) / numberOfEpisodes);
                return aggregateRating;
            }
        }
        public override string ToString()
        {
            string nameAndNumberOfEpisodes = String.Format("{0}:  {1} stars, {2} episodes", name, Rating, numberOfEpisodes);
            return nameAndNumberOfEpisodes;
        }
    }
}
