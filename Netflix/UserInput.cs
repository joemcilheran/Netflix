using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class UserInput
    {
        public UserInput()
        {

        }
        public void welcome()
        {
            Console.WriteLine("Welcome to the netflix catalogue viewer.");
        }
        public string get_search_option()
        {
            Console.WriteLine("Choose from the following:");
            Console.WriteLine("Enter 'title' to search for a title.");
            Console.WriteLine("Enter 'genre from titles' to view a combined genre from two title choices.");
            Console.WriteLine("Enter 'title and genre' to view a genre and a single title.");
            Console.WriteLine("Enter 'genre' to search by genre.");
            Console.WriteLine("Enter 'two genres' to view titles that fit both genres");
            string input = Console.ReadLine();
            return input;
        }
        public string get_title()
        {
            Console.WriteLine("Enter title");
            string input = Console.ReadLine();
            return input;
        }
        public string get_first_title()
        {
            Console.WriteLine("Enter first title");
            string input = Console.ReadLine();
            return input;
        }
        public string get_second_title()
        {
            Console.WriteLine("Enter second title");
            string input = Console.ReadLine();
            return input;
        }
        public string get_genre()
        {
            Console.WriteLine("Enter Genre: enter either 'Action', 'Comedy', or 'Romance'.");
            string input = Console.ReadLine();
            return input;
        }
        public string get_first_genre()
        {
            Console.WriteLine("Enter First Genre: enter either 'Action', 'Comedy', or 'Romance'.");
            string input = Console.ReadLine();
            return input;
        }
        public string get_second_genre()
        {
            Console.WriteLine("Enter Second Genre: enter either 'Action', 'Comedy', or 'Romance'.");
            string input = Console.ReadLine();
            return input;
        }
        public void invalid_input()
        {
            Console.WriteLine("Invalid input");
        }
        public string quit_or_try_again()
        {
            Console.WriteLine("What would you like to do? Enter: 'quit' or 'try again'.");
            string input = Console.ReadLine();
            return input;
        }
        public void say_goodbye()
        {
            Console.WriteLine("Goodbye.");
            Console.ReadKey();
            Environment.Exit(0);
        }
        public void title_does_not_exist(string searchTitleString)
        {
            Console.WriteLine("The title {0} cannot be found in the catalogue.", searchTitleString);
        }
        public void genre_does_not_exist()
        {
            Console.WriteLine("That genre cannot be found in the catalogue.");
        }
        public string get_viewAgain_choice()
        {
            Console.WriteLine("What would you like to do now? Enter: 'quit' or 'view something else'.");
            string input = Console.ReadLine();
            return input;
        }
    }
}
