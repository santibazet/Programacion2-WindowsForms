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
    public partial class formularioMostrarActor : Form
    {
        private static formularioMostrarActor instance = null;
        private Controladora controlador;
        private BindingList<Actores> actores;
        internal formularioMostrarActor(Controladora controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
            actores = controlador.GetActores();
            dgvActores.DataSource = actores;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        // Este método proporciona una instancia única del formularioMostrarActor utilizando un patrón Singleton.
        internal static formularioMostrarActor GetInstance(Controladora controlador)
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new formularioMostrarActor(controlador);
            }
            return instance;
        }

        // Este método maneja el evento de clic en una celda del DataGridView de actores.
        // Obtiene el actor seleccionado y muestra las películas asociadas en el DataGridView de películas.
        private void dgvActores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedrow = dgvActores.Rows[e.RowIndex];

            int id = Convert.ToInt32(selectedrow.Cells["Id"].Value);//Chequeo
            Actores actorSeleccionado = actores.First(a => a.Id == id);
            dgvPeliculas.DataSource = actorSeleccionado.peliculaActores;
        }

        // Este método maneja el evento de clic en el botón de volver.
        // Cierra el formulario actual.
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
