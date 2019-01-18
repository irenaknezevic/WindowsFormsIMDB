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
            
            DataGridViewImageColumn delete_button = new DataGridViewImageColumn();
            delete_button.Image = Image.FromFile("D:/Irena/FAKS/2.godina/NET-projekt/delete.png");
            delete_button.Width = 20;
            delete_button.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFilmovi.Columns.Add(delete_button);

            
        }

        private void textBoxPretraga_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void buttonPretraga_Click(object sender, EventArgs e)
        {
            var film = textBoxPretraga.Text;

        }
    }
}
