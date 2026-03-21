using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    public class Playlist1
    {
        public string nombre;
        public NodoCancion inicio;
        public NodoCancion final;

        public Playlist1(string nombre)
        {
            this.nombre = nombre;
            inicio = null;
            final = null;
        }

        public void AgregarCancion(Cancion cancion)
        {
            NodoCancion nuevo = new NodoCancion(cancion);

            if (inicio == null)
            {
                inicio = nuevo;
                final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                nuevo.Anterior = final;
                final = nuevo;
            }
        }

        public void EliminarCancion(int idCancion)
        {
            NodoCancion actual = inicio;

            while (actual != null)
            {
                if (actual.Dato.Id == idCancion)
                {
                    //Si es el primero en la lista se ejecuta este bloque primero
                    if (actual == inicio)
                    {
                        inicio = actual.Siguiente;
                        if (inicio != null)
                            inicio.Anterior = null;
                    }
                    //Si es el ultimo se ejecuta este 
                    else if (actual == final)
                    {
                        final = actual.Anterior;
                        final.Siguiente = null;
                    }
                    //Y si esta en el medio se ejecuta este, Esta la tengo que modificar todavia
                    else
                    {
                        actual.Anterior.Siguiente = actual.Siguiente;
                        actual.Siguiente.Anterior = actual.Anterior;
                    }

                    return;
                }

                actual = actual.Siguiente;
            }
        }

        public void MostrarCanciones()
        {
            NodoCancion actual = inicio;

            while (actual != null)
            {
                Console.WriteLine("ID: " + actual.Dato.Id + " Nombre: " + actual.Dato.Nombre + " Artista: " + actual.Dato.Artista);
                actual = actual.Siguiente;
            }
        }

        public List<Cancion> ObtenerLista()
        {
            List<Cancion> lista = new List<Cancion>();
            NodoCancion actual = inicio;

            while (actual != null)
            {
                lista.Add(actual.Dato);
                actual = actual.Siguiente;
            }

            return lista;
        }
    }
}
