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
        private Film film = new Film();
        

        public OMDBRepository()
        {

        }

        //vraca listu objekata klase omdb
        public Film SearchMovie(string searchMovie, string searchYear)
        {
            string url = KreiranjeUrl(searchMovie, searchYear);
            string json = CallRestMethod(url);

            Film film = JsonConvert.DeserializeObject<Film>(json);
            /*
                JObject jsonObject = JObject.Parse(json);
                var title = jsonObject["Title"];
             * */
            //foreach (JObject item in jsonObject)
            //{
            new Film
                {
                Title = (string)film.Title,
                Year = (string)film.Year,
                Rated = (string)film.Rated,
                Released = (string)film.Released,
                Runtime = (string)film.Runtime,
                Genre = (string)film.Genre,
                Director = (string)film.Director,
                Writer = (string)film.Writer,
                Actors = (string)film.Actors,
                Plot = (string)film.Plot,
                Language = (string)film.Language,
                Country = (string)film.Country,
                Awards = (string)film.Awards,
                Poster = (string)film.Poster,
                Metascore = (int)film.Metascore,
                imdbRating = (string)film.imdbRating,
                imdbVotes = (string)film.imdbVotes,
                imdbID = (string)film.imdbID,
                Type = (string)film.Type,
                DVD = (string)film.DVD,
                BoxOffice = (string)film.BoxOffice,
                Production = (string)film.Production,
                Website = (string)film.Website,
                Response = (string)film.Response
            };
            //}
            return film;
        }

       

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
