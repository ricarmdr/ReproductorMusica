using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    internal class Historial
    {
        public NodoCancion Cima { get; set; }

        public void Push(Cancion c)
        {
            NodoCancion nuevo = new NodoCancion(c);
            nuevo.Siguiente = Cima;
            Cima = nuevo;
        }
        public NodoCancion Pop()
        {
            if (Cima == null)
            {
                Console.WriteLine("Historial vacio");
                return null;
            }
            NodoCancion temp = Cima;
            Cima = Cima.Siguiente;
            return temp;
        }
        public NodoCancion Peek()
        {
            return Cima;
        }
        public bool EstaVacio()
        {
            return Cima == null;
        }
        public void MostrarHistorial()
        {
            NodoCancion actual = Cima;
            Console.WriteLine("=== Historial ===");
            while (actual != null)
            {
                Console.WriteLine(actual.Dato.Nombre + " - " + actual.Dato.Artista);
                actual = actual.Siguiente;            }
        }
        public void LimpiarHistorial()
        {
            Cima = null;
        }
    }
}
