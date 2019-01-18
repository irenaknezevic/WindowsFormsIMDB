using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class OMDBRepository
    {
        string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";

        public OmdbMovie _omdbMovie = new OmdbMovie();

        public Movie movie = new Movie();
        public List<Movie> lista_movie = new List<Movie>();


        public OMDBRepository()
        {
            lista_movie = GetMovies();
        }

        //vraca listu objekata klase omdb
        public OmdbMovie SearchOmdbMovie(string searchMovie, string searchYear)
        {
            string url = KreiranjeUrl(searchMovie, searchYear);
            string json = CallRestMethod(url);

            OmdbMovie _omdbMovie = JsonConvert.DeserializeObject<OmdbMovie>(json);
            /*
                JObject jsonObject = JObject.Parse(json);
                var title = jsonObject["Title"];
            */
            //foreach (JObject item in jsonObject)
            //{
            new OmdbMovie
            {
                Title = (string)_omdbMovie.Title,
                Year = (int)_omdbMovie.Year,
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
                imdbVotes = (float)_omdbMovie.imdbVotes,
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

  
        public void AddMovie(OmdbMovie omdbMovie, string rating)
        {

            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                var query = "INSERT INTO Omdb_Filmovi (Title, Year, Rated, Released, Runtime, Genre, Director, Writer, Actors, Plot, Language, Country, Awards, Poster, Metascore, imdbRating, imdbVotes, imdbID, Type, DVD, BoxOffice, Production, Website, Response, Rating) VALUES ('" + omdbMovie.Title + "', '" + omdbMovie.Year + "', '" + omdbMovie.Rated + "', '" + omdbMovie.Released + "', '" + omdbMovie.Runtime + "', '" + omdbMovie.Genre + "', '" + omdbMovie.Director + "', '" + omdbMovie.Writer + "', '" + omdbMovie.Actors + "', '" + omdbMovie.Plot + "', '" + omdbMovie.Language + "', '" + omdbMovie.Country + "', '" + omdbMovie.Awards + "', '" + omdbMovie.Poster + "', '" + omdbMovie.Metascore + "', '" + omdbMovie.imdbRating + "', '" + omdbMovie.imdbVotes + "', '" + omdbMovie.imdbID + "', '" + omdbMovie.Type + "', '" + omdbMovie.DVD + "', '" + omdbMovie.BoxOffice + "', '" + omdbMovie.Production + "', '" + omdbMovie.Website + "', '" + omdbMovie.Response + "', '" + rating + "')";

                Console.WriteLine(query);
                oCommand.CommandText = query;
                oConnection.Open();
                using (DbDataReader reader = oCommand.ExecuteReader())
                {
                    reader.Read();
                }
            }
        }

        public List<Movie> GetMovies()
        {
            var movies = new List<Movie>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT Title, Year, Genre, Director FROM Omdb_Filmovi";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        movies.Add(new Movie()
                        {
                            Title = (string)reader["Title"],
                            Year = (int)reader["Year"],
                            Genre = (string)reader["Genre"],
                            Director = (string)reader["Director"]
                        });
                    }
                }
            }
            return movies;
        }
        


        public void DeleteMovie(Movie movie)
        {
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Omdb_Filmovi WHERE Id = " + movie.Id;
                oConnection.Open();
                using (DbDataReader reader = oCommand.ExecuteReader())
                {
                    reader.Read();
                }
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

        public static string KreiranjeUrl(string movie, string year)
        {
            var link = "http://www.omdbapi.com/?t=" + movie + "&y="+ year +"&apikey=e55c1343";
            return link;
        }
    }
}
