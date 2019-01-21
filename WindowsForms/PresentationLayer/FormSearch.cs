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
    public partial class FormSearch : Form
    {
        public BindingSource _tableBindingSourceMovie = new BindingSource();
        public OMDBRepository _omdbRepo = new OMDBRepository();

        public FormSearch(string movie, string year)
        {
            InitializeComponent();
            _tableBindingSourceMovie.DataSource = _omdbRepo.SearchOmdbMovie(movie, year);
            dataGridView1.DataSource = _tableBindingSourceMovie;
            //SearchMovie(movie, year);
        }
    }
}
