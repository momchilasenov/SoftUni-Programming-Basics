using System;

namespace _05._Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMovies = int.Parse(Console.ReadLine());

            double maxRating = int.MinValue;
            string maxMovie = "";
            double minRating = int.MaxValue;
            string minMovie = "";

            double ratingSum = 0;

            for (int i = 1; i <= numberOfMovies; i++)
            {
                string movieName = Console.ReadLine();
                double ratingOfMovie = double.Parse(Console.ReadLine());
                ratingSum += ratingOfMovie;

                if (ratingOfMovie > maxRating)
                {
                    maxRating = ratingOfMovie;
                    maxMovie = movieName;
                }
                if (ratingOfMovie < minRating)
                {
                    minRating = ratingOfMovie;
                    minMovie = movieName;
                }
            }
            double averageRating = ratingSum / numberOfMovies;

            Console.WriteLine($"{maxMovie} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{minMovie} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {averageRating:f1}");
        }
    }
}
