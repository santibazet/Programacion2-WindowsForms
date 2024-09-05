using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligatorio
{
    public class Peliculas
    {

        

        #region Propiedades
        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        public int AñoEstreno { get; set; }
        public string Genero { get; set; }
        public int Duracion { get; set; }
        
        #endregion

        #region  Constructor
        public Peliculas(int idPelicula, string titulo, int añoEstreno, string genero, int duracion)
        {
            IdPelicula = idPelicula;
            Titulo = titulo;
            AñoEstreno = añoEstreno;
            Genero = genero;
            Duracion = duracion;

        }
        #endregion

        #region Métodos

        public override string ToString()
        {
            return $"ID: {IdPelicula}, Titulo: {Titulo}, Año de estreno: {AñoEstreno}, Genero: {Genero}, Duracion: {Duracion}";
        }
        #endregion


    }
}
