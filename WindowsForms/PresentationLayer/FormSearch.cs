using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using System.Diagnostics;

namespace PresentationLayer
{
    public partial class FormSearch : Form
    {
        public OMDBRepository _omdbRepository = new OMDBRepository();
        public Movie oMovie = new Movie();
        public OmdbMovie omdbNewMovie = new OmdbMovie();

        string sNewTitle;
        string sYear;
        public FormSearch(string newTitle, string year)
        {
            InitializeComponent();

            sNewTitle = newTitle;
            sYear = year;
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            string omdbTitle = sNewTitle + "(" + sYear + ")";
            lblTitleNew.Text = sNewTitle;
            omdbNewMovie = _omdbRepository.SearchOmdbMovie(sNewTitle, sYear);

            string sWriters = omdbNewMovie.Writer;
            sWriters = sWriters.Replace(", ", "\n");
            string sActors = omdbNewMovie.Actors;
            sActors = sActors.Replace(", ", "\n");

            pictureBoxNew.ImageLocation = omdbNewMovie.Poster;
            pictureBoxNew.SizeMode = PictureBoxSizeMode.StretchImage;
            lblRatedNew.Text = omdbNewMovie.Rated;
            lblRuntimeNew.Text = omdbNewMovie.Runtime;
            lblGenreNew.Text = omdbNewMovie.Genre;
            lblDirectorNew.Text = omdbNewMovie.Director;
            lblWriterNew.Text = sWriters;
            lblActorsNew.Text = sActors;
            lblPlotNew.Text = omdbNewMovie.Plot;
            lblReleasedNew.Text = omdbNewMovie.Released;
            lblRuntime2New.Text = omdbNewMovie.Runtime;
            labelGenre2New.Text = omdbNewMovie.Genre;
            lblCountryNew.Text = omdbNewMovie.Country;
            lblLanguageNew.Text = omdbNewMovie.Language;
            lblAwardsNew.Text = omdbNewMovie.Awards;
            lblBoxOfficeNew.Text = omdbNewMovie.BoxOffice;
            lblProductionNew.Text = omdbNewMovie.Production;
            lblTypeNew.Text = omdbNewMovie.Type;
            lblDVDNew.Text = omdbNewMovie.DVD;
            lblMetascoreNew.Text = Convert.ToString(omdbNewMovie.Metascore);
            lblimdbRatingNew.Text = omdbNewMovie.imdbRating;
            lblimdbVotesNew.Text = Convert.ToString(omdbNewMovie.imdbVotes);
            lblimdbIDNew.Text = omdbNewMovie.imdbID;
            lblResponseNew.Text = omdbNewMovie.Response;
            
            if (omdbNewMovie.Website != "N/A")
            {
                webBrowser.Url = new Uri(omdbNewMovie.Website);
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var rating = textBoxYourRating.Text;
            _omdbRepository.AddMovie(omdbNewMovie, rating);

            FormSearch close = new FormSearch(sNewTitle, sYear);
            this.Close();

            Form1 Update = new Form1();
            Update.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormSearch close = new FormSearch(sNewTitle, sYear);
            this.Close();

            Form1 Update = new Form1();
            Update.Show();
        }
    }
}
