using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }

        public Persona()
        {
            
        }

        public Persona(int id, string nombre, string apellido, DateTime fechaNacimiento, string nacionalidad)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Nacionalidad = nacionalidad;
        }
    }
}
