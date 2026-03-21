using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;


namespace Reproductor_de_Musica
{
    public class Cancion
    {
        public int Id { get; set; } //Id para el servidor de SQL
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public string RutaArchivo { get; set; }
        public TimeSpan Duracion { get; set; }


        public Cancion(int id, string nombre, string artista, string rutaarchivo)
        {
            Id = id;
            Nombre = nombre;
            Artista = artista;
            RutaArchivo = rutaarchivo;

        }
    }  
}
