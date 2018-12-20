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
        string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";

        public OmdbMovie _omdbMovie = new OmdbMovie();

        public Movie _movie = new Movie();
        public List<Movie> lista_movie = new List<Movie>();


        public OMDBRepository()
        {

        }

        public Movie SearchMovie(string searchMovie, string searchYear)
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
             * */
            //foreach (JObject item in jsonObject)
            //{
            new OmdbMovie
                {
                Title = (string)_omdbMovie.Title,
                Year = (int)_omdbMovie.Year,
                Rated = (char)_omdbMovie.Rated,
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
                imdbRating = (float)_omdbMovie.imdbRating,
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

        public void AddMovie(Movie movie)
        {
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO Omdb_Filmovi (ID, TITLE, YEAR, RATED, RELEASED, RUNTIME, GENRE, DIRECTOR, WRITER, ACTORS, PLOT, LANGUAGE, COUNTRY, AWARDS, POSTER, METASCORE, IMBDRATING) VALUES ('" + movie.Id + "', '" + movie.Title + "', '" + movie.Year + "', '" + movie.Rated + "', '" + movie.Released + "')";
                oConnection.Open();
                using (DbDataReader reader = oCommand.ExecuteReader())
                {
                    reader.Read();
                }
            }
        }

        public Movie GetMovies()
        {
            var movies = new List<Movie>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM [Omdb_Filmovi]";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        movies.Add(new Movie()
                        {
                            Id = (int)reader["Id"],
                            Rating=(float)reader["Rating"],
                            //nasljeđena klasa OmdbMovies
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
                oCommand.CommandText = "DELETE FROM Omdb_Filmovi WHERE USER_ID = " + movie; //??
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
