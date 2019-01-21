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
    public partial class FormDetailedMovie : Form
    {
        public OMDBRepository _omdbRepository = new OMDBRepository();
        public Movie oMovie = new Movie();

        public FormDetailedMovie(int id, string sTitle)
        {
            InitializeComponent();
        }

        private void FormDetailedMovie_Load(object sender, EventArgs e)
        {

        }
    }
}
