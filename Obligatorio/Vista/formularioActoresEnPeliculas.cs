using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Obligatorio
{
    public partial class formularioActoresEnPeliculas : Form
    {
        private static formularioActoresEnPeliculas instance = null;
        private Controladora controlador;
        private BindingList<Peliculas> peliculas;
        private BindingList<Actores> actores;

        // Constructor del formulario
        internal formularioActoresEnPeliculas(Controladora controlador)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.controlador = controlador;
            peliculas = controlador.GetPeliculas();
            actores = controlador.GetActores();
            dgvSelectorActor.DataSource = actores;
            dgvSelectorPelicula.DataSource = peliculas;
            txtIDActor.ReadOnly = true; 
            txtMuestraActor.ReadOnly = true;
            txtIDPelicula.ReadOnly = true;
            txtMuestraPelicula.ReadOnly = true;
            dgvSelectorActor.ReadOnly = true;
            dgvSelectorPelicula.ReadOnly = true;
        }

        // Evento al hacer clic en el botón "Cerrar"
        private void btnCerrarActoresEnPeliculas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método estático para obtener una instancia del formulario (patrón Singleton)
        internal static formularioActoresEnPeliculas GetInstance(Controladora controlador)
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new formularioActoresEnPeliculas(controlador);
            }
            return instance;
        }


        #region DataGridView
        // Evento al hacer clic en una celda del DataGridView de actores
        private void dgvSelectorActor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvSelectorActor.Rows[e.RowIndex];
            if (selectedRow != null)
            {
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string nombre = Convert.ToString(selectedRow.Cells["Nombre"].Value);
                string apellido = Convert.ToString(selectedRow.Cells["Apellido"].Value);

                txtMuestraActor.Text = $"{nombre} {apellido}";
                txtIDActor.Text = $"{id}";
            }
        }

        // Evento al hacer clic en una celda del DataGridView de películas
        private void dgvSelectorPelicula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvSelectorPelicula.Rows[e.RowIndex];
            if (selectedRow != null)
            {
                int id = Convert.ToInt32(selectedRow.Cells["IdPelicula"].Value);
                string titulo = Convert.ToString(selectedRow.Cells["Titulo"].Value);

                txtIDPelicula.Text = $"{id}";
                txtMuestraPelicula.Text = $"{titulo}";
            }
        }

        #endregion

        #region Boton Confirmar
        // Evento al hacer clic en el botón "Confirmar"
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Validar y obtener los IDs de actor y película
            if (!int.TryParse(txtIDActor.Text, out int idActor))
            {
                MessageBox.Show("No se ha podido reconocer el id de Actores");
                return;
            }
            if (!int.TryParse(txtIDPelicula.Text, out int idPelicula))
            {
                MessageBox.Show("Ha ocurrido un error con el id de Peliculas");
                return;
            }
            // Llamar al método de la controladora para agregar el actor a la película
            controlador.AgregarActorAPelicula(idActor, idPelicula);
            

        }
        #endregion
    }
}
