using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    public class Actores : Persona
    {
        #region Propiedades
        
        public List<Peliculas> peliculaActores { get; set; }
        #endregion

        #region Constructor
        public Actores(int idactor, string nombre, string apellido, DateTime fechaNacimiento, string nacionalidad) :
            base(idactor, nombre, apellido, fechaNacimiento, nacionalidad)
        {
            
            peliculaActores = new List<Peliculas>();
        }
    }
        #endregion
}