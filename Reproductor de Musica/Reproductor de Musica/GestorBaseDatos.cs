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
        public int GuardarCancion(Cancion c)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string query = @"
                INSERT INTO Cancion (nombre, artista, rutaArchivo, duracion)
                OUTPUT INSERTED.idCancion
                VALUES (@nombre, @artista, @ruta, @duracion)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@artista", c.Artista);
                cmd.Parameters.AddWithValue("@ruta", c.RutaArchivo);
                cmd.Parameters.AddWithValue("@duracion", c.Duracion.ToString(@"mm\:ss"));
                int id = (int)cmd.ExecuteScalar();
                return id;
            }
        }

        //Crear Playlist
        public void CrearPlaylist(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();

                string query = "INSERT INTO Playlist (nombrePlaylist) VALUES (@nombre)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombre", nombre);

                cmd.ExecuteNonQuery();
            }
        }

        //Agregar Cancion a una Playlist
        public void AgregarCancionPlaylist(int idCancion, int idPlaylist)
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

        public Playlist1 ObtenerCancion()
        {
            Playlist1 lista = new Playlist1(0, "Biblioteca");
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string query = "SELECT * FROM Cancion";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TimeSpan duracion = TimeSpan.Zero;
                    if (reader["duracion"] != DBNull.Value)
                    {
                        string valor = reader["duracion"].ToString(); 
                        TimeSpan.TryParse("00:" + valor, out duracion); 
                    }

                    Cancion c = new Cancion(
                        Convert.ToInt32(reader["idCancion"]),
                        reader["nombre"].ToString(),
                        reader["artista"].ToString(),
                        reader["rutaArchivo"].ToString(),
                        duracion
                    );
                    lista.AgregarCancion(c);
                }
                reader.Close();
            }
            return lista;
        }

        //Clase interna de nodoplaylist para manejar multiples playlists 
        public class NodoPlaylist
        {
            public Playlist1 Dato;
            public NodoPlaylist Siguiente;

            public NodoPlaylist(Playlist1 p)
            {
                Dato = p;
                Siguiente = null;
            }
        }

        public NodoPlaylist ObtenerPlaylists()
        {
            NodoPlaylist inicio = null;
            NodoPlaylist ultimo = null;

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();

                string query = "SELECT * FROM Playlist";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Playlist1 p = new Playlist1( Convert.ToInt32(reader["idPlaylist"]), reader["nombrePlaylist"].ToString() );

                    NodoPlaylist nuevo = new NodoPlaylist(p);

                    if (inicio == null)
                    {
                        inicio = nuevo;
                        ultimo = nuevo;
                    }
                    else
                    {
                        ultimo.Siguiente = nuevo;
                        ultimo = nuevo;
                    }
                }
            }

            return inicio;
        }

        //METODO PARA CARGAR LAS CANCIONES EN LAS PLAYLST
        public Playlist1 ObtenerPlaylistConCanciones(int idPlaylist, string nombrePlaylist)
        {
            Playlist1 playlist = new Playlist1(idPlaylist, nombrePlaylist);

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();

                string query = @"SELECT C.* FROM Cancion C INNER JOIN PlaylistCancion PC
                    ON C.idCancion = PC.idCancion
                WHERE PC.idPlaylist = @idPlaylist";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@idPlaylist", idPlaylist);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TimeSpan duracion = TimeSpan.Zero;

                    if (reader["duracion"] != DBNull.Value)
                    {
                        string valor = reader["duracion"].ToString();
                        TimeSpan.TryParse("00:" + valor, out duracion);
                    }

                    Cancion c = new Cancion(
                        Convert.ToInt32(reader["idCancion"]),
                        reader["nombre"].ToString(),
                        reader["artista"].ToString(),
                        reader["rutaArchivo"].ToString(),
                        duracion
                    );

                    playlist.AgregarCancion(c);
                }

                reader.Close();
            }

            return playlist;
        }

        //METODO PARA ELIMINAR CANCION DE LA PLAYLIST
        public void EliminarCancionDePlaylist(int idCancion, int idPlaylist)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();

                string query = @"DELETE FROM PlaylistCancion WHERE idCancion = @cancion AND idPlaylist = @playlist";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@cancion", idCancion);
                cmd.Parameters.AddWithValue("@playlist", idPlaylist);

                cmd.ExecuteNonQuery();
            }
        }

        //metodo para evitar canciones duplicadas en una Playlists
        public bool ExisteCancionEnPlaylist(int idCancion, int idPlaylist)
        {
            using (SqlConnection conn =
                new SqlConnection(cadenaConexion))
            {
                conn.Open();

                string query = @"SELECT COUNT(*) FROM PlaylistCancion WHERE idCancion = @cancion AND idPlaylist = @playlist";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@cancion", idCancion);
                cmd.Parameters.AddWithValue("@playlist", idPlaylist);

                int cantidad = (int)cmd.ExecuteScalar();

                return cantidad > 0;
            }
        }

        //Método para renombrar una playlist
        public void RenombrarPlaylist(int idPlaylist, string nuevoNombre)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();

                string query = @"UPDATE Playlist SET nombrePlaylist = @nombre WHERE idPlaylist = @id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombre", nuevoNombre);
                cmd.Parameters.AddWithValue("@id", idPlaylist);

                cmd.ExecuteNonQuery();
            }
        }

        //Metodo para eliminar una playlist completa
        public void EliminarPlaylist(int idPlaylist)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();

                // Primero se eliminan las relaciones en PlaylistCancion
                string query1 = @"DELETE FROM PlaylistCancion WHERE idPlaylist = @id";

                SqlCommand cmd1 = new SqlCommand(query1, conn);

                cmd1.Parameters.AddWithValue("@id", idPlaylist);
                cmd1.ExecuteNonQuery();

                // Luego se elimina la playlist
                string query2 = @"DELETE FROM Playlist WHERE idPlaylist = @id";

                SqlCommand cmd2 = new SqlCommand(query2, conn);

                cmd2.Parameters.AddWithValue("@id", idPlaylist);
                cmd2.ExecuteNonQuery();
            }
        }

    }
}
