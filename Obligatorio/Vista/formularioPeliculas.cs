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
    public partial class formularioPeliculas : Form
    {
        private static formularioPeliculas instance = null;
        private Controladora controlador = new Controladora();

        // Constructor del formulario
        internal formularioPeliculas(Controladora controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            dgvTablaPeliculas.DataSource = controlador.GetPeliculas();
        }


        #region Singleton
        
        public void SetPersonas(BindingList<Peliculas> peliculas)
        {
            dgvTablaPeliculas.DataSource = peliculas;
        }

        // Método para obtener una instancia única del formulario
        internal static formularioPeliculas GetInstance(Controladora controlador)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new formularioPeliculas(controlador);
            }
            return instance;
        }


        #endregion

        #region Botón guardar película
        // Evento al hacer clic en el botón de guardar película
        private void btnGuardarPeliculas_Click(object sender, EventArgs e)
        {
            // Validaciones de entrada de datos
            if ((txtDuracionPeliculas.Text).Length > 3)
            {
                MessageBox.Show("La duración en minutos no puede exceder los 3 dígitos.");
                return;
            }

            if ((txtFechaEstrenoPeliculas.Text).Length > 4)
            {
                MessageBox.Show("El año no puede exceder los 4 dígitos.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTituloPeliculas.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios");
                return;
            }

            // Obtención de datos del formulario
            int id = controlador.GetIdPelicula();
            


            if (!int.TryParse(txtFechaEstrenoPeliculas.Text, out int añoEstreno))
            {
                MessageBox.Show("El año de estreno debe ser un número entero.");
                return;
            }

            if (!int.TryParse(txtDuracionPeliculas.Text, out int duracionEnMinutos))
            {
                MessageBox.Show("La duracion en minutos debe ser un número entero.");
                return;
            }

            if (cmbGeneroPeliculas.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un género para la película.");
                return;
            }

            string titulo = txtTituloPeliculas.Text;
            string generoSeleccionado = cmbGeneroPeliculas.SelectedItem.ToString();

            // Creación de una nueva instancia de Pelicula y agregación a la lista.
            Peliculas nuevaPelicula = new Peliculas(id, titulo, añoEstreno, generoSeleccionado, duracionEnMinutos);

            if (controlador.AgregarPelicula(nuevaPelicula))
            {
                MessageBox.Show($"La película {titulo} fue agregada con éxito.");
                ActualizarListadoPeliculas();
            }
            LimpiarCajasFormulario();
        }

        #endregion


        #region Métodos complementarios
        // Método para actualizar el listado de películas en el DataGridView
        private void ActualizarListadoPeliculas()
        {
            dgvTablaPeliculas.DataSource = null;
            dgvTablaPeliculas.DataSource = controlador.GetPeliculas();
        }

        // Método para limpiar los campos del formulario
        private void LimpiarCajasFormulario()
        {
           
            txtTituloPeliculas.Text = "";
            txtFechaEstrenoPeliculas.Text = ""; 
            txtDuracionPeliculas.Text = "";
            cmbGeneroPeliculas.SelectedIndex = -1;
            dgvTablaPeliculas.ClearSelection();
        }



        #endregion


        #region Botón editar película
        // Evento al hacer clic en el botón de editar película
        private void btnEditarPeliculas_Click(object sender, EventArgs e)//Modificada
        {
            // Comprobaciones de selección y validaciones
            int id;
            if(dgvTablaPeliculas.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dgvTablaPeliculas.SelectedRows[0];
                id = Convert.ToInt32(selectedRow.Cells["IdPelicula"].Value);
            }else
            {
                MessageBox.Show("Debe seleccionar una pelicula");
                return;
            }

            if (string.IsNullOrEmpty(txtTituloPeliculas.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios");
                return;
            }
            if (string.IsNullOrEmpty(cmbGeneroPeliculas.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios");
                return;
            }
  
            
            string nuevoTitulo = Convert.ToString(txtTituloPeliculas.Text);
            string nuevoGenero = Convert.ToString(cmbGeneroPeliculas.Text);
            if(!int.TryParse(txtFechaEstrenoPeliculas.Text, out int fechaEstreno))
            {
                MessageBox.Show("Los campos no pueden estar vacios");
                return;
            }
            int.TryParse(txtDuracionPeliculas.Text, out int duracion);

            if ((txtDuracionPeliculas.Text).Length > 3)
            {
                MessageBox.Show("La duración en minutos no puede exceder los 3 dígitos.");
                return;
            }

            if((txtFechaEstrenoPeliculas.Text).Length > 4)
            {
                MessageBox.Show("El año no puede exceder los 4 dígitos.");
                return;
            }


            // Modificación de la película seleccionada
            if (controlador.ModificarPelicula(id, nuevoTitulo, fechaEstreno, nuevoGenero, duracion))
            {
                MessageBox.Show("La pelicula se ha modificado con exito");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            LimpiarCajasFormulario();
            ActualizarListadoPeliculas();
        }


        #endregion


        #region Botón eliminar pelicula

        // Evento al hacer clic en el botón de eliminar película
        private void btnEliminarPeliculas_Click(object sender, EventArgs e)
        {

            //Pregunta si quiere eliminar la pelicula
            DialogResult resultado = MessageBox.Show("¿Quiere eliminar la Pelicula?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                
            }
            else
            {
                return;
            }

            // Comprobaciones y obtención del ID
            int id;
            if(dgvTablaPeliculas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTablaPeliculas.SelectedRows[0];
               id = Convert.ToInt32(selectedRow.Cells["IdPelicula"].Value);
            }
            else
            {
                MessageBox.Show("Los campos no deben estar vacios");
                return;
            }
            
            //Elimina la pelicula
            if (controlador.EliminarPelicula(id))
            {
                MessageBox.Show($"La pelicula {txtTituloPeliculas.Text} ha sido eliminada con exito");
                ActualizarListadoPeliculas();
            }
            LimpiarCajasFormulario();
        }

        #endregion

        #region Boton Volver
        // Evento al hacer clic en el botón de volver
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Boton DataGrid
        // Evento al hacer clic en el encabezado de una fila del DataGridView
        private void dgvTablaPeliculas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvTablaPeliculas.Rows[e.RowIndex];

                // Obtención de datos de la película seleccionada y llenado de los campos del formulario
                string titulo = Convert.ToString(selectedRow.Cells["Titulo"].Value);
                string fecha = Convert.ToString(selectedRow.Cells["AñoEstreno"].Value);
                string genero = Convert.ToString(selectedRow.Cells["Genero"].Value);
                int duracion = Convert.ToInt32(selectedRow.Cells["Duracion"].Value);

                
                txtTituloPeliculas.Text = titulo;
                txtFechaEstrenoPeliculas.Text = fecha;
                cmbGeneroPeliculas.SelectedItem = genero;
                txtDuracionPeliculas.Text = duracion.ToString();
            }
        }
        #endregion

        #region Boton Limpiar
        // Evento al hacer clic en el botón de limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpia todos las casillas y quita cualquier seleccion en el datagrid
            txtTituloPeliculas.Text = "";
            txtFechaEstrenoPeliculas.Text = "";
            txtDuracionPeliculas.Text = "";
            cmbGeneroPeliculas.SelectedIndex = -1;
            dgvTablaPeliculas.ClearSelection();
        }
        #endregion
    }


}
