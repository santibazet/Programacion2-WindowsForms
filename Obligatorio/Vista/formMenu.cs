using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligatorio
{
    public partial class formMenu : Form
    {
        private Controladora controlador;
        private BindingList<Peliculas> peliculas;
        internal formMenu(Controladora controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
            peliculas = controlador.GetPeliculas();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        // Este método maneja el evento de clic en el botón de gestión de películas.
        // Muestra el formulario de películas usando un patrón Singleton.
        private void btnGestionPeliculas_Click(object sender, EventArgs e)
        {
            formularioPeliculas formulario = formularioPeliculas.GetInstance(controlador);
            formulario.Show();
        }

        // Este método maneja el evento de clic en el botón de filtrado de películas.
        // Muestra el formulario de filtrado de películas usando un patrón Singleton.
        private void btnFiltradoPelicula_Click(object sender, EventArgs e)
        {
            formularioFiltradoPeliculas formulario = formularioFiltradoPeliculas.GetInstance(controlador);
            formulario.Show();
        }

        // Este método maneja el evento de clic en el botón de gestión de actores.
        // Muestra el formulario de actores usando un patrón Singleton.
        private void btnGestionarActor_Click(object sender, EventArgs e)
        {
            formularioActores formulario = formularioActores.GetInstance(controlador);  
            formulario.Show();
        }

        // Este método maneja el evento de clic en el botón de gestión de actores en películas.
        // Muestra el formulario de actores en películas usando un patrón Singleton.
        private void button4_Click(object sender, EventArgs e)
        {
            formularioActoresEnPeliculas formulario = formularioActoresEnPeliculas.GetInstance(controlador);
            formulario.Show();
        }

        // Este método maneja el evento de clic en el botón de mostrar actores.
        // Muestra el formulario de mostrar actores usando un patrón Singleton.
        private void btnMostrarActores_Click(object sender, EventArgs e)
        {
            formularioMostrarActor formulario = formularioMostrarActor.GetInstance(controlador);
            formulario.Show();
        }
    }
}
