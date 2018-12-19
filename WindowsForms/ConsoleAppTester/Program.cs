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
            var repo = new OmdbMovie();
            foreach(var title in repo.SearchMovie(sMovie, sYear))
            {
                Console.WriteLine(title.Genre+ " " + title.Year);
            }
            Console.ReadKey();
        }
    }
}
