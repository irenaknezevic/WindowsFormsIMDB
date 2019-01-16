using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace ConsoleAppTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi film:");
            string sMovie = Console.ReadLine();
            Console.WriteLine("Upisi godinu:");
            string sYear = Console.ReadLine();
            var repo = new OMDBRepository();
            Console.WriteLine("Upisi ocjenu:");
            string Rating = Console.ReadLine();
            decimal fRating = Convert.ToDecimal(Rating);

            var provjera = repo.SearchOmdbMovie(sMovie, sYear);

            Console.WriteLine(provjera.Title);
            Console.WriteLine(provjera.Year);
            Console.WriteLine(provjera.Rated);
            Console.WriteLine(provjera.Released);
            Console.WriteLine(provjera.Runtime);
            Console.WriteLine(provjera.Genre);
            Console.WriteLine(provjera.Director);
            Console.WriteLine(provjera.Writer);
            Console.WriteLine(provjera.Actors);
            Console.WriteLine(provjera.Language);
            Console.WriteLine(provjera.Country);
            Console.WriteLine(provjera.Awards);
            Console.WriteLine(provjera.Poster);
            Console.WriteLine(provjera.Metascore);
            Console.WriteLine(provjera.imdbRating);
            Console.WriteLine(provjera.imdbVotes);
            Console.WriteLine(provjera.imdbID);
            Console.WriteLine(provjera.Type);
            Console.WriteLine(provjera.DVD);
            Console.WriteLine(provjera.BoxOffice);
            Console.WriteLine(provjera.Production);
            Console.WriteLine(provjera.Website);
            Console.WriteLine(provjera.Response);

            repo.AddMovie(provjera, (float)fRating);
            
            //Console.WriteLine(provjera.Actors +"\n" + provjera.Country);
            Console.ReadKey();
        }
    }
}
