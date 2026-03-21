using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    public class ColaReproduccion
    {
        private NodoCancion frente;
        private NodoCancion final;

        //metodo constructor
        public ColaReproduccion()
        {
            frente = null;
            final = null;
        }

        //verificar si la cola esta vacia
        public bool EstaVacia()
        {
            if (frente == null)
                return true;
            else
                return false;
        }

        //agregar una cancion a la cola
        public void Encolar(Cancion cancion)
        {
            NodoCancion nuevo = new NodoCancion(cancion);

            if (EstaVacia())
                frente = final = nuevo;
            else
            {
                final.Siguiente = nuevo;
                nuevo.Anterior = final;
                final = nuevo;
            }
        }

        //eliminar una cancion de la cola
        public Cancion Desencolar()
        {
            //si la cola esta vacia
            if (EstaVacia())
                return null;

            //si la cola no está vacia
            NodoCancion aux = frente;
            Cancion c = aux.Dato;

            frente = frente.Siguiente;

            if (frente == null)
                final = null;
            else
                frente.Anterior = null;

            return c;
        }
    }
}
