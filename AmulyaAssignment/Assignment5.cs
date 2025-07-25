using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmulyaAssignment
{
    class Movie
    {
        public string Title {  get; set; }
        public string Genre { get; set; }
        public int Year {  get; set; }
        public double Rating {  get; set; }
        
    }
    internal class Assignment5
    {
        static List<Movie> movieList = new List<Movie>();
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n ///////Movie Database Menu////////");
                Console.WriteLine("1.Add Movie");
                Console.WriteLine("2.Remove Movie");
                Console.WriteLine("3.Find Movie by title");
                Console.WriteLine("4.Update Movie");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter your choice");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddMovie();
                        break;
                    case 2:
                        RemoveMovie();
                        break;
                    case 3:
                        FindMovie();
                        break;
                    case 4:
                        UpdateMovie();
                        break;
                    case 5:
                        Console.WriteLine("Exiting the program");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice.Please try again");
                        break;

                }
            } while (choice != 5);

        }
        static void AddMovie()
        {
            Console.WriteLine("\n Add Movie");
            Movie movie = new Movie();
            Console.Write("Enter Title:");
            movie.Title = Console.ReadLine();
            Console.Write("Enter Genre:");
            movie.Genre = Console.ReadLine();
            Console.Write("Enter Year:");
            movie.Year = int.Parse(Console.ReadLine());
            Console.Write("Enter the Rating 0-10:");
            movie.Rating = double.Parse(Console.ReadLine());
            movieList.Add(movie);
            Console.WriteLine("Movie added successfully");
        }
        static void RemoveMovie()
        {
            Console.WriteLine("\n Remove Movie");
            Console.Write("Enter the title of the movie to remove:");
            string title = Console.ReadLine();
            Movie movie = movieList.Find(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (movie != null)
            {
                movieList.Remove(movie);
                Console.WriteLine("Movie removed successfully");
            }
            else
            {
                Console.WriteLine("Movie not found");
            }
        }
        static void FindMovie()
        {
            Console.WriteLine("\n FindMovie");
            Console.Write("Enter the title of the movieto find:");
            string title= Console.ReadLine();
            Movie movie= movieList.Find(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (movie != null)
            {
                Console.WriteLine($"Movie {movie.Title}");
                Console.WriteLine($"Genre:{movie.Genre}");
                Console.WriteLine($"Year:{movie.Year}");
                Console.WriteLine($"Rating:{movie.Rating}");
            }
            else
            {
                Console.WriteLine("Movie not found");
            }
        }
        static void UpdateMovie()
        {
            Console.WriteLine("\nUpdate movie");
            Console.Write("Enter the title of the movie to update:");
            string title = Console.ReadLine();
            Movie movie = movieList.Find( m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (movie != null)
            {
                Console.WriteLine("Enter new Genre(leave blankto keep unchanged):");
                string genre = Console.ReadLine();
                if (!string.IsNullOrEmpty(genre))
                {
                    movie.Genre = genre;
                }
                Console.WriteLine("Enter the new year(or press enter to keep unchanged):");
                string yearInput= Console.ReadLine();
                if(int.TryParse(yearInput, out int year)) { movie.Year = year; }
                Console.Write("Enter new rating(or press enter to keep unchanged):");
                string ratingInput= Console.ReadLine();
                if(double.TryParse(ratingInput, out double rating)) { movie.Rating = rating; }
                Console.WriteLine("Movie Updatd");
            }
            else
            {
                Console.WriteLine("Movie not found");
            } }

        } }
