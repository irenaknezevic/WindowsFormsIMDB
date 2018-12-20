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
            var provjera = repo.SearchOmdbMovie(sMovie, sYear);

            Console.WriteLine("Naslov: " + provjera.Title + "\n Glumci: " + provjera.Actors);
            Console.ReadKey();
        }
    }
}
