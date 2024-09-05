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
    public partial class formularioActores : Form
    {
        private static formularioActores instance = null;
        private Controladora controlador;

        // Constructor privado para implementar el patrón Singleton
        internal formularioActores(Controladora controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            // Cargar datos de actores en el DataGridView
            dgvTablaActores.DataSource = controlador.GetActores();
        }

        // Método estático para obtener la instancia única del formulario
        internal static formularioActores GetInstance(Controladora controlador)
        {
            if( instance == null || instance.IsDisposed)
            {
                instance = new formularioActores(controlador);
            }
            return instance;
        }
        
        

        #region Boton Guardar Actores
        private void btnGuardarActores_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (string.IsNullOrEmpty(txtNombreActores.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios");
                return;
            }
            if (string.IsNullOrEmpty(txtNombreActores.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacions");
                return;
            }
            
            if (!DateTime.TryParse(txtFechaNacimientoActores.Text, out DateTime fecha))
            {
                MessageBox.Show("Debe estar en formato dd-MM-yyyy");
                return;
            }
            if (string.IsNullOrEmpty(txtNacionalidadActores.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios");
                return;
            }

            // Obtener un nuevo ID para el actor
            int id = controlador.GetIdActor();
            string nombre = txtNombreActores.Text;
            string apellido = txtApellidoActores.Text;
            string nacionalidad = txtNacionalidadActores.Text;

            // Crear un nuevo actor con los datos proporcionados
            Actores nuevoActor = new Actores(id, nombre, apellido,fecha, nacionalidad);
            
            // Agregar el actor al controlador y mostrar mensaje de éxito
            if (controlador.AgregarActor(nuevoActor))
            {
                MessageBox.Show($"El Actor {nuevoActor.Nombre} se ha agregado con exito");
            }
            // Limpiar datos de entrada y actualizar DataGridView
            LimpiarDatosEntrada();
            LimpiarDgvActores();
        }
        #endregion

        #region Metodos Complementarios
        private void LimpiarDgvActores()
        {
            dgvTablaActores.DataSource = null;
            dgvTablaActores.DataSource = controlador.GetActores();
        }

        private void LimpiarDatosEntrada()
        {
            txtNombreActores.Text = "";
            txtApellidoActores.Text = "";
            txtFechaNacimientoActores.Text = "";
            txtNacionalidadActores.Text = "";
            dgvTablaActores.ClearSelection();
        }
        #endregion

        #region Boton Eliminar
        private void btnEliminarActores_Click(object sender, EventArgs e)
        {
            // Confirmar eliminación con un cuadro de diálogo
            DialogResult resultado = MessageBox.Show("¿Quiere eliminar el actor", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
            }
            else
            {
                return;
            }

            // Obtener el ID del actor seleccionado en el DataGridView
            int id;
            if (dgvTablaActores.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTablaActores.SelectedRows[0];
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            }
            else
            {
                MessageBox.Show("No se ha podido capturar el valor del ID");
                return;
            }

            // Eliminar el actor del controlador y mostrar mensaje de éxito
            if (controlador.EliminarActor(id))
            {
                MessageBox.Show($"El actor {txtNombreActores.Text} ha sido eliminado con exito");
                LimpiarDgvActores();
            }
            LimpiarDatosEntrada();
        }
        #endregion

        #region DataGridView Actores

        // Evento al hacer clic en el contenido de una celda del DataGridView
        private void dgvTablaActores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el clic sea válido
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvTablaActores.Rows[e.RowIndex];

                // Obtener los datos de la fila y mostrarlos en los TextBox correspondientes
                string nombre = Convert.ToString(selectedRow.Cells["Nombre"].Value);
                string apellido = Convert.ToString(selectedRow.Cells["Apellido"].Value);
                DateTime fecha = Convert.ToDateTime(selectedRow.Cells["FechaNacimiento"].Value);
                string nacionalidad = Convert.ToString(selectedRow.Cells["Nacionalidad"].Value);

                txtNombreActores.Text = nombre;
                txtFechaNacimientoActores.Text = fecha.ToString("dd-MM-yyyy");
                txtNacionalidadActores.Text = nacionalidad;
                txtApellidoActores.Text = apellido;
            }
        }
        #endregion

        #region Boton Editar Actores
        private void btnEditarActores_Click(object sender, EventArgs e)
        {
            // Obtener el ID del actor seleccionado en el DataGridView
            int id;
            if (dgvTablaActores.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTablaActores.SelectedRows[0];
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            }
            else
            {
                MessageBox.Show("No se ha podido obtener el valor del ID");
                return;
            }
            // Validación de campos
            if (string.IsNullOrEmpty(txtNombreActores.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios");
                return;
            }
            if (string.IsNullOrEmpty(txtApellidoActores.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios");
                return;
            }
            if (string.IsNullOrEmpty(txtNacionalidadActores.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios");
                return;
            }
            if(!DateTime.TryParse(txtFechaNacimientoActores.Text, out DateTime fecha))
            {
                MessageBox.Show("Debe estar en formato dd-MM-yyyy");
                return;
            }

            // Obtener datos de entrada
            string nombre = txtNombreActores.Text;
            string apellido = txtApellidoActores.Text;
            string nacionalidad = txtNacionalidadActores.Text;

            // Modificar el actor en el controlador y mostrar mensaje de éxito
            if (controlador.ModificarActor(id, nombre, apellido, fecha, nacionalidad))
            {
                MessageBox.Show($"El actor ha sido modificado correctamente");
                LimpiarDgvActores();
            }
            // Limpiar datos de entrada
            LimpiarDatosEntrada();
        }
        #endregion

        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento al hacer clic en el encabezado de una fila del DataGridView
        private void dgvTablaActores_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Verificar que el clic sea válido
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvTablaActores.Rows[e.RowIndex];

                // Obtener los datos de la fila y mostrarlos en los TextBox correspondientes
                string nombre = Convert.ToString(selectedRow.Cells["Nombre"].Value);
                string apellido = Convert.ToString(selectedRow.Cells["Apellido"].Value);
                DateTime fecha = Convert.ToDateTime(selectedRow.Cells["FechaNacimiento"].Value);
                string nacionalidad = Convert.ToString(selectedRow.Cells["Nacionalidad"].Value);

                txtNombreActores.Text = nombre;
                txtFechaNacimientoActores.Text = fecha.ToString("dd-MM-yyyy");
                txtNacionalidadActores.Text = nacionalidad;
                txtApellidoActores.Text = apellido;
            }
        }

        // Método para limpiar los datos de entrada en los TextBox y deseleccionar la fila en el DataGridView
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatosEntrada();
        }
    }
}
