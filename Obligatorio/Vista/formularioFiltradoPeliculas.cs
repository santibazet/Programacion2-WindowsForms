using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligatorio
{
    public partial class formularioFiltradoPeliculas : Form
    {
        private static formularioFiltradoPeliculas instance = null;
        private Controladora controlador;
        private BindingList<Peliculas> peliculas;

        // Constructor del formulario
        internal formularioFiltradoPeliculas(Controladora controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false; 
            peliculas = controlador.GetPeliculas();
            dgvPeliculas.DataSource = controlador.GetPeliculas();




        }

        // Evento al hacer clic en el botón "Volver", para cerrar el formulario.
        private void btnVolverFiltradoPeliculas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método estático para obtener una instancia del formulario (patrón Singleton)
        internal static formularioFiltradoPeliculas GetInstance(Controladora controlador)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new formularioFiltradoPeliculas(controlador);
            }
            return instance;
        }



        #region Filtrado por Genero
        // Evento al cambiar el estado del RadioButton de Género
        private void rbGenero_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica si el RadioButton de Género está marcado
            if (rbGenero.Checked)
            {
                // Obtiene el género seleccionado en el ComboBox
                string generoSleccionado = cmbGenero.Text;
                // Filtra las películas por género
                if (generoSleccionado == "Todos")
                {
                    List<Peliculas> peliculasA = peliculas.OrderBy(p => p.Titulo).ToList();
                    dgvPeliculas.DataSource = peliculasA;
                    txtNumeroResultado.Text = peliculasA.Count.ToString();
                }
                else
                {
                    List<Peliculas> peliculasFiltradas = peliculas
                        .Where(pelicula => pelicula.Genero == generoSleccionado)
                        .OrderBy(pelicula => pelicula.Titulo)
                        .ToList();
                    dgvPeliculas.DataSource = peliculasFiltradas;
                    txtNumeroResultado.Text = peliculasFiltradas.Count.ToString();
                }
            }
        }

        // Evento al cambiar la selección en el ComboBox de Género
        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si el RadioButton de Género está marcado
            if (rbGenero.Checked)
            {
                // Obtiene el género seleccionado en el ComboBox
                string generoSleccionado = cmbGenero.Text;
                // Filtra las películas por género
                if (generoSleccionado == "Todos")
                {
                    List<Peliculas> peliculasA = peliculas.OrderBy(p => p.Titulo).ToList();
                    dgvPeliculas.DataSource = peliculasA;
                    txtNumeroResultado.Text = peliculasA.Count.ToString();
                }
                else
                {
                    List<Peliculas> peliculasFiltradas = peliculas
                        .Where(pelicula => pelicula.Genero == generoSleccionado)
                        .OrderBy(pelicula => pelicula.Titulo)
                        .ToList();
                    dgvPeliculas.DataSource = peliculasFiltradas.OrderBy(pelicula => pelicula.Titulo).ToList(); ;
                    txtNumeroResultado.Text = peliculasFiltradas.Count.ToString();
                }
            }
        }
        #endregion
        #region Casillas Filtrado
        // Evento al cambiar el estado de la casilla de Filtrado Activo
        private void cbFiltradoActivo_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica si la casilla de Filtrado Activo está marcada
            if (cbFiltradoActivo.Checked)
            {
                // Habilita los controles relacionados con el filtrado
                rbGenero.Enabled = true;
                rbAnio.Enabled = true;
                cmbGenero.Enabled = true;
                txtAnio.Enabled = true;
                txtNumeroResultado.Enabled = true;
            }else
            {
                // Restablece la lista de películas y deshabilita los controles
                dgvPeliculas.DataSource = peliculas;
                txtNumeroResultado.Text = null;
                txtNumeroResultado.Enabled = false;
                rbGenero.Enabled = false;
                rbAnio.Enabled = false;
                cmbGenero.Enabled = false;
                txtAnio.Enabled = false;
                rbGenero.Checked = false;
                rbAnio.Checked = false;
            }
        }
        #endregion
        #region Filtrado por Anio
        // Evento al cambiar el estado del RadioButton de Año
        private void rbAnio_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica si el RadioButton de Año está marcado
            if (rbAnio.Checked)
            {
                // Intenta convertir el texto del TextBox a un entero (año)
                if (int.TryParse(txtAnio.Text, out int anioSeleccionado))
                {
                    // Filtra las películas por año
                    List<Peliculas> peliculasFiltradas = peliculas
                        .Where(pelicula => pelicula.AñoEstreno == anioSeleccionado)
                        .OrderBy(pelicula => pelicula.Titulo) 
                        .ToList();
                    dgvPeliculas.DataSource = peliculasFiltradas;
                    txtNumeroResultado.Text = peliculasFiltradas.Count.ToString();
                }
                else
                {
                    // Si no se puede convertir, muestra todas las películas ordenadas por título
                    dgvPeliculas.DataSource = peliculas.OrderBy(pelicula => pelicula.Titulo).ToList();
                    txtNumeroResultado.Text = peliculas.Count.ToString();
                }
            }
            else
            {
                // Si el RadioButton de Año no está marcado, muestra todas las películas ordenadas por título
                dgvPeliculas.DataSource = peliculas.OrderBy(pelicula => pelicula.Titulo).ToList();
                txtNumeroResultado.Text = peliculas.Count().ToString();
            }
        }
        #endregion
    }
}
