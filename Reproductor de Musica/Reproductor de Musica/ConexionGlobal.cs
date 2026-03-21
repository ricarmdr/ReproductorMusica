using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    public static class ConexionGlobal
    {
        public static GestorBaseDatos Instancia { get; private set; }

        static ConexionGlobal()
        {
            string conexion =  @"Server=localhost;
                   Database=ReproductorMusica;
                   Trusted_Connection=True;";

            Instancia = new GestorBaseDatos(conexion);
        }
    }
}
