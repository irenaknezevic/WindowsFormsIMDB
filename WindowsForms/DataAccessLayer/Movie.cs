using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Movie:OmdbMovie
    {
        public int Id { get; set; }
        public float Rating { get; set; }
    }
}
