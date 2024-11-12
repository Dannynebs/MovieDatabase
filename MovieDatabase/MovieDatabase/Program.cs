
using MovieDatabase;
using System.Reflection;

List<Movie> movieList = new List<Movie>()
{
    new Movie("It","Horror"),
    new Movie("The interview","Comedy"),
    new Movie("focus","action"),
    new Movie("Harry Potter","Fantasy"),
    new Movie("John Wick","action"),
    new Movie("interstellar","SciFi"),
    new Movie("jumanji","adventure"),
    new Movie("Lost City","adventure"),
    new Movie("Ironman","superhero"),
    new Movie("thor","superhero"),
};

foreach (Movie movie in movieList)
{
    Console.WriteLine($"{movie.title} - {movie.category}");
}

bool goAgain = true;
while (goAgain == true)
{
    Console.WriteLine("What genre of movie would you like to see?");
    string userCategory = Console.ReadLine();

    List<Movie> subset = movieList.Where(x => x.category == userCategory.ToLower()).ToList();
    if (subset.Count == 0)
    {
        Console.WriteLine("There are no movies of that category in this movie list");
    }
    else
    {
        Console.WriteLine($"The {userCategory} movies on the list are:");
        foreach (Movie movie in subset)
        {
            Console.WriteLine(movie.title);
        }
        // How do I display the movies associated with that category
    }
    Console.WriteLine("Do you want to search for another category? (yes/no)");
    string userGoAgain = Console.ReadLine().ToLower();
    if (userGoAgain == "yes")
    {
        goAgain = true;
    }
    else
    {
        goAgain= false;
        Console.WriteLine("Goodbye!");
    }

}