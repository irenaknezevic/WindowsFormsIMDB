using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OMDBRepository
    {
        public OmdbMovie _omdbMovie = new OmdbMovie();
        //public Movie _movie = new Movie();


        public OMDBRepository()
        {

        }

        /*public Movie SearchMovie(string searchMovie, string searchYear)
        {
            string url = KreiranjeUrl(searchMovie, searchYear);
            string json = CallRestMethod(url);

            Movie _movie = JsonConvert.DeserializeObject<Movie>(json);

            new Movie
            {
                Id = (int)_movie.Id,
                Rating=(float)_movie.Rating,

            };
          
            return _movie;
        }*/

        //vraca listu objekata klase omdb
        public OmdbMovie SearchMovie(string searchMovie, string searchYear)
        {
            string url = KreiranjeUrl(searchMovie, searchYear);
            string json = CallRestMethod(url);

            OmdbMovie _omdbMovie = JsonConvert.DeserializeObject<OmdbMovie>(json);
            /*
                JObject jsonObject = JObject.Parse(json);
                var title = jsonObject["Title"];
             * */
            //foreach (JObject item in jsonObject)
            //{
            new OmdbMovie
                {
                Title = (string)_omdbMovie.Title,
                Year = (string)_omdbMovie.Year,
                Rated = (string)_omdbMovie.Rated,
                Released = (string)_omdbMovie.Released,
                Runtime = (string)_omdbMovie.Runtime,
                Genre = (string)_omdbMovie.Genre,
                Director = (string)_omdbMovie.Director,
                Writer = (string)_omdbMovie.Writer,
                Actors = (string)_omdbMovie.Actors,
                Plot = (string)_omdbMovie.Plot,
                Language = (string)_omdbMovie.Language,
                Country = (string)_omdbMovie.Country,
                Awards = (string)_omdbMovie.Awards,
                Poster = (string)_omdbMovie.Poster,
                Metascore = (int)_omdbMovie.Metascore,
                imdbRating = (string)_omdbMovie.imdbRating,
                imdbVotes = (string)_omdbMovie.imdbVotes,
                imdbID = (string)_omdbMovie.imdbID,
                Type = (string)_omdbMovie.Type,
                DVD = (string)_omdbMovie.DVD,
                BoxOffice = (string)_omdbMovie.BoxOffice,
                Production = (string)_omdbMovie.Production,
                Website = (string)_omdbMovie.Website,
                Response = (string)_omdbMovie.Response
            };
            //}
            return _omdbMovie;
        }

        /*public void AddMovie(Movie movie)
        {
            movie.Add(movie);
        }*/

        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }

        public static string KreiranjeUrl(string movie, string year)
        {
            var link = "http://www.omdbapi.com/?t=" + movie + "&y="+ year +"&apikey=e55c1343";
            return link;
        }
    }
}
