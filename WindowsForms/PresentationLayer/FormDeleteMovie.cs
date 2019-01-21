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

namespace PresentationLayer
{
    public partial class FormDeleteMovie : Form
    {
        Movie _movie = new Movie();
        OMDBRepository _omdbRepository = new OMDBRepository();
        
        public FormDeleteMovie(Movie movie)
        {
            _movie = movie;
            InitializeComponent();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            _omdbRepository.DeleteMovie(_movie.Id);

            FormDeleteMovie close = new FormDeleteMovie(_movie);
            this.Close();

            Form1 Update = new Form1();
            Update.Show();
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            FormDeleteMovie close = new FormDeleteMovie(_movie);
            this.Close();

            Form1 Update = new Form1();
            Update.Show();
        }
    }
}
