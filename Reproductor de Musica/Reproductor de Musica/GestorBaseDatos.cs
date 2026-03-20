using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Reproductor_de_Musica
{
    public class GestorBaseDatos
    {
        private string cadenaConexion;

        //metodo constructor
        public GestorBaseDatos(string conexion)
        {
            cadenaConexion = conexion;
        }

        //metodo para guardar una cancion
        public void GuardarCancion(Cancion c)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();

                string query = "INSERT INTO Cancion (nombre, artista, rutaArchivo) VALUES (@nombre, @artista, @ruta)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@artista", c.Artista);
                cmd.Parameters.AddWithValue("@ruta", c.RutaArchivo);

                cmd.ExecuteNonQuery();
            }
        }

        //Crear Playlist
        public void CrearPlaylist(string nombre) 
        {
            using SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();

                string query = "INSERT INTO Playlist (nombrePlaylist) VALUES (@nombre)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombre", nombre);

                cmd.ExecuteNonQuery();
            }
        }

        //Agregar Cancion a una Playlist
        public void AgregarCancionPlaylist()
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();

                string query = "INSERT INTO PlaylistCancion (idCancion, idPlaylist) VALUES (@cancion, @playlist)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@cancion", idCancion);  
                cmd.Parameters.AddWithValue("@playlist", idPlaylist);

                cmd.ExecuteNonQuery();
            }
        }

    }
}
