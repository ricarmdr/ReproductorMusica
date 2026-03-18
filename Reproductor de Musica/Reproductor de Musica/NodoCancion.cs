using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    internal class NodoCancion
    {
        public Cancion Dato { get; set; }
        public NodoCancion Siguiente { get; set; }
        public NodoCancion Anterior { get; set; }


        public NodoCancion(Cancion cancion)
        {
            Dato = cancion;
            Siguiente = null;
            Anterior = null;    
        }
    }
}