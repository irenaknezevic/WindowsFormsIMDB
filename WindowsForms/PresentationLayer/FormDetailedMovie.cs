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
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace PresentationLayer
{
    public partial class FormDetailedMovie : Form
    {
        public OMDBRepository _omdbRepository = new OMDBRepository();
        public Movie oMovie = new Movie();

        string sTitle;
        int nId;
        public FormDetailedMovie(int id, string title)
        {
            InitializeComponent();

            sTitle = title;
            nId = id;
        }

        private void FormDetailedMovie_Load(object sender, EventArgs e)
        {
            lblTitle.Text = sTitle;
            foreach (var movie in _omdbRepository.GetThisMovie(nId))
            {
                string sWriters = movie.Writer;
                sWriters = sWriters.Replace(", ", "\n");
                string sActors = movie.Actors;
                sActors = sActors.Replace(", ", "\n");

                pictureBox.ImageLocation = movie.Poster;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                lblRated.Text = movie.Rated;
                lblRuntime.Text = movie.Runtime;
                lblGenre.Text = movie.Genre;
                lblDirector.Text = movie.Director;
                lblWriter.Text = sWriters;
                lblActors.Text = sActors;
                lblPlot.Text = movie.Plot;
                lblReleased.Text = movie.Released;
                lblRuntime2.Text = movie.Runtime;
                labelGenre2.Text = movie.Genre;
                lblCountry.Text = movie.Country;
                lblLanguage.Text = movie.Language;
                lblAwards.Text = movie.Awards;
                lblBoxOffice.Text = movie.BoxOffice;
                lblProduction.Text = movie.Production;
                lblType.Text = movie.Type;
                lblDVD.Text = movie.DVD;
                lblMetascore.Text = Convert.ToString(movie.Metascore);
                lblimdbRating.Text = movie.imdbRating;
                lblimdbVotes.Text = Convert.ToString(movie.imdbVotes);
                lblimdbID.Text = movie.imdbID;
                lblResponse.Text = movie.Response;
                lblMyRating.Text = Convert.ToString(movie.Rating);

                if(movie.Website != "N/A")
                {
                    webBrowser1.Url = new Uri(movie.Website);
                }
            }
        }

        private void buttonCloseDetails_Click(object sender, EventArgs e)
        {
            FormDeleteMovie close = new FormDeleteMovie(oMovie);
            this.Close();

            Form1 Update = new Form1();
            Update.Show();
        }
    }
}
