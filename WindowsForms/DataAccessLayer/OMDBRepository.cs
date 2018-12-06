using System;
using Newtonsoft.Json.Linq;
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
        private List<OMDB> _omdb = new List<OMDB>();
        

        public OMDBRepository()
        {
           
        }
        //vraca listu objekata klase omdb
        public List<OMDB> SearchMovie(string searchText)
        {
            string url = KreiranjeUrl(searchText);
            string json = CallRestMethod(url);

            JArray jsonObject = JArray.Parse(json);
            foreach (JObject item in jsonObject)
            {
                _omdb.Add(new OMDB
                {
                    Title = (string)item.GetValue("Title"),
                    Year = (string)item.GetValue("Year"),
                    Rated = (string)item.GetValue("Rated"),
                    Released = (string)item.GetValue("Released"),
                    Runtime = (string)item.GetValue("Runtime"),
                    Genre = (string)item.GetValue("Genre"),
                    Director = (string)item.GetValue("Director"),
                    Writer = (string)item.GetValue("Writer"),
                    Actors = (string)item.GetValue("Actors"),
                    Plot = (string)item.GetValue("Plot"),
                    Language = (string)item.GetValue("Language"),
                    Country = (string)item.GetValue("Country"),
                    Awards = (string)item.GetValue("Awards"),
                    Poster = (string)item.GetValue("Poster"),

                    Metascore = (int)item.GetValue("Metascore"),
                    imdbRating = (string)item.GetValue("imdbRating"),
                    imdbVotes = (string)item.GetValue("imdbVotes"),
                    imdbID = (string)item.GetValue("imdbID"),
                    Type = (string)item.GetValue("Type"),
                    DVD = (string)item.GetValue("DVD"),
                    BoxOffice = (string)item.GetValue("BoxOffice"),
                    Production = (string)item.GetValue("Production"),
                    Website = (string)item.GetValue("Website"),
                    Response = (string)item.GetValue("Response")
                });
                return _omdb;
            }
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

        public static string KreiranjeUrl(string film)
        {
            var link = "http://www.omdbapi.com/?t=" + film + "&apikey=e55c1343";
            return link;
        }
    }
}
