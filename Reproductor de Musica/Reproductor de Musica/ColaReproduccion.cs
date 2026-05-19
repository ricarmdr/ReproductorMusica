using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    public class ColaReproduccion
    {
        private NodoCola frente;
        private NodoCola final;
        public int Cantidad { get; private set; }

        public ColaReproduccion()
        {
            frente = null;
            final = null;
            Cantidad = 0;
        }

        // Encolar — agrega al final
        public void Encolar(Cancion c)
        {
            NodoCola nuevo = new NodoCola(c);

            if (final == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }

            Cantidad++;
        }

        // Desencolar — saca del frente
        public Cancion Desencolar()
        {
            if (frente == null) return null;

            Cancion dato = frente.Dato;
            frente = frente.Siguiente;

            if (frente == null)
                final = null;

            Cantidad--;
            return dato;
        }

        // Ver qué sigue sin sacar
        public Cancion Peek()
        {
            return frente?.Dato;
        }

        public NodoCola ObtenerFrente()
        {
            return frente;
        }

        public bool EstaVacia()
        {
            return frente == null;
        }
    }
}
