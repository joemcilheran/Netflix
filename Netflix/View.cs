using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class View
    {
        public Catalogue catalogue;
        UserInput userInput;
        public View()
        {
            catalogue = new Catalogue();
            userInput = new UserInput();
        }
        public void run_viewer()
        {
            userInput.welcome();
            run_view();
        }
        public void run_view()
        {
            string input = userInput.get_search_option();
            switch(input)
            {
                case "title":
                    view_title();
                    break;
                case "genre from titles":
                    view_genre_from_titles();
                    break;
                case "title and genre":
                    view_title_and_genre();
                    break;
                case "genre":
                    view_genre();
                    break;
                case "two genres":
                    view_combined_genres();
                    break;
                default:
                    invalid_view_input();
                    break;
            }
            view_again();
        }
        public void invalid_view_input()
        {
            userInput.invalid_input();
            string answer = userInput.quit_or_try_again();
            switch (answer)
            {
                case "quit":
                    userInput.say_goodbye();
                    break;
                case "try again":
                    run_view();
                    break;
                default:
                    invalid_view_input();
                    break;
            }
        }
        public void view_again()
        {
            string answer = userInput.get_viewAgain_choice();
            switch (answer)
            {
                case "quit":
                    userInput.say_goodbye();
                    break;
                case "view something else":
                    run_view();
                    break;
                default:
                    invalid_view_input();
                    break;
            }
        }
        public void view_title()
        {
            List<int> titleCheckList = new List<int>();
            string searchTitleString = userInput.get_title();
            foreach (Title title in catalogue.AllTitlesList)
            {
                if (title.name == searchTitleString)
                {
                    title.display_title(title);
                    titleCheckList.Add(1);
                }

            }
            if (titleCheckList.Count == 0)
            {
                title_does_not_exist2(searchTitleString);
            }
        }
        public void title_does_not_exist(string searchTitleString)
        {
            userInput.title_does_not_exist(searchTitleString);
            string answer = userInput.quit_or_try_again();
            switch (answer)
            {
                case "quit":
                    userInput.say_goodbye();
                    break;
                case "try again":
                    view_title();
                    break;
                default:
                    invalid_view_input();
                    break;
            }
        }
        public void title_does_not_exist2(string searchTitleString)
        {
            userInput.title_does_not_exist(searchTitleString);
            string answer = userInput.quit_or_try_again();
            switch (answer)
            {
                case "quit":
                    userInput.say_goodbye();
                    break;
                case "try again":
                    view_title();
                    break;
                default:
                    invalid_view_input();
                    break;
            }
        }
        public void view_genre_from_titles()
        {
            List<Title> newtitleList = new List<Title>();
            string titleString1 = userInput.get_first_title();
            check_for_title(titleString1);
            string titleString2 = userInput.get_second_title();
            check_for_title(titleString2);
            foreach (Title title in catalogue.AllTitlesList)
            {
                if (title.name == titleString1 | title.name == titleString2)
                {
                    newtitleList.Add(title);
                }
            }
            Genre newGenre = newtitleList[0] + newtitleList[1];
            display_genre(newGenre);


        }
        public void check_for_title(string titleString)
        {
            List<int> titleCheckList = new List<int>();
            foreach (Title title in catalogue.AllTitlesList)
            {
                if (title.name == titleString)
                {
                    titleCheckList.Add(1);
                }
            }
            if (titleCheckList.Count == 0)
            {
                title_does_not_exist2(titleString);
            }
        }
        public void display_genre(Genre genre)
        {
            Console.WriteLine("{0}", genre.name);
            foreach (Title title in genre)
            {
                title.display_title(title);
            }
        }
        public void view_title_and_genre()
        {
            List<int> genreCheckList = new List<int>();
            List<int> titleCheckList = new List<int>();
            Title titleToAdd;
            string titleString = userInput.get_title();
            string genreString = userInput.get_genre();
            foreach (Title title in catalogue.AllTitlesList)
            {
                if (title.name == titleString)
                {
                    titleCheckList.Add(1);
                    titleToAdd = title;
                    foreach (Genre genre in catalogue)
                        if (genreString == genre.name)
                        {
                            genreCheckList.Add(1);
                            Genre newGenre = (genre + titleToAdd);
                            display_genre(newGenre);
                        }
                    if (genreCheckList.Count == 0)
                    {
                        genre_does_not_exist();
                    }

                }
            }
            if(titleCheckList.Count == 0)
            {
                title_does_not_exist2(titleString);
            }
           
        }
        public void genre_does_not_exist()
        {
            userInput.genre_does_not_exist();
            string answer = userInput.quit_or_try_again();
            switch (answer)
            {
                case "quit":
                    userInput.say_goodbye();
                    break;
                case "try again":
                    view_title_and_genre();
                    break;
                default:
                    invalid_view_input();
                    break;
            }
        }
        public void genre_does_not_exist2()
        {
            userInput.genre_does_not_exist();
            string answer = userInput.quit_or_try_again();
            switch (answer)
            {
                case "quit":
                    userInput.say_goodbye();
                    break;
                case "try again":
                    view_combined_genres();
                    break;
                default:
                    invalid_view_input();
                    break;
            }
        }
        public void view_genre()
        {
            List<int> genreCheckList = new List<int>();
            string genreString = userInput.get_genre();
            foreach (Genre genre in catalogue)
                if (genreString == genre.name)
                {
                    genreCheckList.Add(1);
                    display_genre(genre);
                }
            if (genreCheckList.Count == 0)
            {
                genre_does_not_exist();
            }
        }
        public void view_combined_genres()
        {
            List<Genre> combinedGenreList = new List<Genre>();
            string genreString1 = userInput.get_first_genre();
            check_for_genre(genreString1);
            string genreString2 = userInput.get_second_genre();
            check_for_genre(genreString2);
            foreach(Genre genre in catalogue)
            {
                if (genre.name == genreString1 | genre.name == genreString2)
                {
                    combinedGenreList.Add(genre);
                }
            }
            Genre combinedGenre = (combinedGenreList[0] + combinedGenreList[1]);
            display_genre(combinedGenre);
        }
        public void check_for_genre(string genreString)
        {
            List<int> genreCheckList = new List<int>();
            foreach (Genre genre in catalogue)
                if (genreString == genre.name)
                {
                    genreCheckList.Add(1);
                }
            if (genreCheckList.Count == 0)
            {
                genre_does_not_exist2();
            }
        }







    }
}
