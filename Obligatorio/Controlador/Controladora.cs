using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligatorio
{
    internal class Controladora
    {
    
        #region Atributos
        public BindingList<Peliculas> peliculas;
        public BindingList<Actores> actores;
        public int IdActores { get; set; }
        public int IdPeliculas { get; set; }
        #endregion

        #region Constructor
        public Controladora()
        {
            peliculas = new BindingList<Peliculas>();
            actores = new BindingList<Actores>();
            IdActores = 1;
            IdPeliculas = 1;
            
        }
        #endregion

        #region ID Actores y Peliculas

        public int GetIdActor()
        {
            int id = IdActores;
            IdActores++;
            return id;
        }

        public int GetIdPelicula()
        {
            int id = IdPeliculas;
            IdPeliculas++;
            return id;
        }
        #endregion

        #region Métodos del CRUD

        #region Actores

        public void AgregarActorAPelicula(int idActor, int idPelicula)//metodo para asignarle una pelicula a un actor
        {
            if (idActor > 0  && idActor > 0)//Verifica que existan los dos ID
            {
               //Busca el actor y la pelicula que coincidan con los id enviados por parametros 
               var actorSeleccionado = actores.First(actor => actor.Id == idActor);
               var peliculaSeleccionada = peliculas.First(pelicula => pelicula.IdPelicula == idPelicula);

               if(actorSeleccionado.peliculaActores.Any(p => p.IdPelicula == peliculaSeleccionada.IdPelicula))//Verifica si la pelicula ya esta asignada al actor
                {
                    MessageBox.Show("El Actor ya se encuentra vinculado a esta pelicula");
                }
                else
                {
                    actorSeleccionado.peliculaActores.Add(peliculaSeleccionada);//Si la pelicula no esta asignada al actor, la agrega a la List que posee el actor
                    MessageBox.Show("Se ha agregado el actor a la pelicula");
                }
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error, intentelo otra vez");
                
            }
        }
        public bool AgregarActor(Actores actor)//Metodo que recibe un actor ya creado y lo asigna a la List actores de la controladora
        {
            if (actor != null)//Comprueba que exista el actor
            {
                if ((actores.Any(p => p.Id == actor.Id)))//Verifica si el actor ya se encuentra en la List actores
                {
                    MessageBox.Show($"El id {actor.Id} ya se encuentra ingresado, utiliza un id único");
                    return false;
                }
                else
                {
                    actores.Add(actor);//Si no se encuentra en la lista
                    return true;
                }
            }
            return false;
        }

       

        internal bool EliminarActor(int idActor)//Busca un actor por su id y luego lo elimina
        {
            var actorEliminado = actores.First(p => p.Id == idActor);
            if (actorEliminado != null)
            {
                actores.Remove(actorEliminado);
                return true;
            }
            return false;
        }

        //Obtiene todos las propiedades de un actor por parametro.
        internal bool ModificarActor(int id, string nuevoNombre, string nuevoApellido, DateTime NuevafechaNacimiento, string nacionalidad)
        {
            bool respuesta = false;
            
            Actores actorActual = actores.FirstOrDefault(p => p.Id == id);//Encuentra el primer actor que conincida con el id
            
            int indiceDelActor = actores.IndexOf(actorActual);//busca el indice del actor

            if (indiceDelActor >= 0)//si existe, modifica al actor y devuelve true
            {
                respuesta = true;

                actores[indiceDelActor].Nombre = nuevoNombre;
                actores[indiceDelActor].Apellido = nuevoApellido;
                actores[indiceDelActor].FechaNacimiento = NuevafechaNacimiento;
                actores[indiceDelActor].Nacionalidad = nacionalidad;
            }
            return respuesta;
        }

        #endregion

        #region Peliculas

        //Recibe una pelicula para luego agregarla
        public bool AgregarPelicula(Peliculas pelicula)
        {
            if (pelicula != null)
            {
                if ((peliculas.Any(p => p.IdPelicula == pelicula.IdPelicula)))
                {
                    MessageBox.Show($"El id {pelicula.IdPelicula} ya se encuentra ingresado, utiliza un id único");
                    return false;
                }
                else
                {
                    peliculas.Add(pelicula);
                    return true;
                }
            }
            return false;
        }

        internal bool EliminarPelicula(int idPelicula)
        {
            var peliculaEliminada = peliculas.First(p => p.IdPelicula == idPelicula);
            if (peliculaEliminada != null)
            {
                peliculas.Remove(peliculaEliminada);
                return true;
            }
            return false;
        }

        internal bool ModificarPelicula(int id, string nuevoTitulo, int nuevoAñoEstreno, string nuevoGenero, int nuevaDuracion)
        {
            bool respuesta = false;

            Peliculas peliculaActual = peliculas.FirstOrDefault(p => p.IdPelicula == id);

            int indiceDePelicula = peliculas.IndexOf(peliculaActual);

            if (indiceDePelicula >= 0)
            {
                respuesta = true;

                peliculas[indiceDePelicula].Titulo = nuevoTitulo;
                peliculas[indiceDePelicula].AñoEstreno = nuevoAñoEstreno;
                peliculas[indiceDePelicula].Genero = nuevoGenero;
                peliculas[indiceDePelicula].Duracion = nuevaDuracion;
            }
            return respuesta;
        }


        #endregion

        #region Métodos complementarios
        public BindingList<Actores> GetActores()
        {
            return actores;
        }

        public BindingList<Peliculas> GetPeliculas()
        {
            return peliculas;
        }

        #endregion

        #endregion

       
    }
}
