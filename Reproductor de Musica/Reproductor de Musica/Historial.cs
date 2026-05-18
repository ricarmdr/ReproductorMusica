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
        
    }
    }
