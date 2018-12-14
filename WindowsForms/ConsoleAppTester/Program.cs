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
            string movie = Console.ReadLine();
            Console.WriteLine("Upisi godinu:");
            string year = Console.ReadLine();
            var repo = new OMDBRepository();
            foreach(var naslov in repo.SearchMovie(movie, year))
            {
                Console.WriteLine(naslov.Genre+" "+ naslov.Year);
            }
            Console.ReadKey();
        }
    }
}
