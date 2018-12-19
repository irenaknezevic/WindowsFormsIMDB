using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class Movie
    {
        public int Id { get; set; }
        public float Rating { get; set; }
        public OmdbMovie _omdbMovie = new OmdbMovie();
    }
}
