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
    public partial class Form1 : Form
    {

        public OMDBRepository _omdbRepository = new OMDBRepository();
        public BindingSource _tableBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            _tableBindingSource.DataSource = _omdbRepository.GetMovies();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewFilmovi.AutoGenerateColumns = false;
            dataGridViewFilmovi.DataSource = _tableBindingSource;

            DataGridViewImageColumn view_button = new DataGridViewImageColumn();
            view_button.Name = "Details";
            view_button.Image = Image.FromFile("F:/programiranje projekti/povecalo.png");
            view_button.Width = 20;
            view_button.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFilmovi.Columns.Add(view_button);

            DataGridViewImageColumn delete_button = new DataGridViewImageColumn();
            delete_button.Name = "Delete";
            delete_button.Image = Image.FromFile("F:/programiranje projekti/delete.png");
            delete_button.Width = 20;
            delete_button.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFilmovi.Columns.Add(delete_button);
        }

        private void dataGridViewFilmovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFilmovi.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                var id = Convert.ToInt32(dataGridViewFilmovi.Rows[e.RowIndex].Cells[0].Value.ToString());
                var title = dataGridViewFilmovi.Rows[e.RowIndex].Cells[1].Value.ToString();
                var year = Convert.ToInt32(dataGridViewFilmovi.Rows[e.RowIndex].Cells[2].Value.ToString());
                var genre = dataGridViewFilmovi.Rows[e.RowIndex].Cells[3].Value.ToString();
                var director = dataGridViewFilmovi.Rows[e.RowIndex].Cells[4].Value.ToString();

                var sTitle = title + " (" + year + ")";
                FormDetailedMovie formDetailedMovie = new FormDetailedMovie(id, sTitle);
                formDetailedMovie.Show();

                this.Hide();
            }

            if (dataGridViewFilmovi.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                var id = Convert.ToInt32(dataGridViewFilmovi.Rows[e.RowIndex].Cells[0].Value.ToString());
                var title = dataGridViewFilmovi.Rows[e.RowIndex].Cells[1].Value.ToString();
                var year = Convert.ToInt32(dataGridViewFilmovi.Rows[e.RowIndex].Cells[2].Value.ToString());
                var genre = dataGridViewFilmovi.Rows[e.RowIndex].Cells[3].Value.ToString();
                var director = dataGridViewFilmovi.Rows[e.RowIndex].Cells[4].Value.ToString();

                var movie = new Movie
                {
                    Id = id,
                    Title = title,
                    Year = year,
                    Genre = genre,
                    Director = director
                };

                FormDeleteMovie formDeleteMovie = new FormDeleteMovie(movie);
                formDeleteMovie.Show();

                this.Hide();
            }
        }

        private void buttonPretraga_Click(object sender, EventArgs e)
        {
            var newTitle = textBoxPretraga.Text.ToString();
            var year = textBoxGodina.Text.ToString();
            FormSearch newMovie = new FormSearch(newTitle, year);
            newMovie.Show();
            //this.Close();
            this.Hide();
        }
    }
}
