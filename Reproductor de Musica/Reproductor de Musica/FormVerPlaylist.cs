using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Reproductor_de_Musica
{
    public partial class FormVerPlaylist : Form
    {
        public FormVerPlaylist()
        {
            CargarYDibujarPlaylists();
        }
        private void CargarYDibujarPlaylists()
        {
            try
            {
                GestorBaseDatos.NodoPlaylist actual = ConexionGlobal.Instancia.ObtenerPlaylists();
                int xInicial = 40;
                int yInicial = 100;
                int x = xInicial;
                int y = yInicial;
                int columnas = 0;

                // Por si no hay ningun registro en la BD
                //Se crea este label
                if (actual == null)
                {
                    System.Windows.Forms.Label lblVacio = new System.Windows.Forms.Label();
                    lblVacio.Text = "No tienes ninguna playlist guardada todavía.";
                    lblVacio.Font = new Font("Segoe UI", 11, FontStyle.Italic);
                    lblVacio.ForeColor = Color.DarkGray;
                    lblVacio.Location = new Point(40, 100);
                    lblVacio.Size = new Size(400, 30);
                    this.Controls.Add(lblVacio);
                    return;
                }

                // Ciclo while para recorrer los nodos
                while (actual != null)
                {
                    // Creamos un Rectángulo plano es decir un boton
                    Button btnRectangulo = new Button();
                    btnRectangulo.Text = actual.Dato.nombre; // Carga el nombre real de tu BD
                    btnRectangulo.Size = new System.Drawing.Size(180, 80);
                    btnRectangulo.Location = new Point(x, y);
                    btnRectangulo.BackColor = Color.FromArgb(0, 122, 204);
                    btnRectangulo.ForeColor = Color.White;
                    btnRectangulo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    btnRectangulo.FlatStyle = FlatStyle.Flat;
                    btnRectangulo.FlatAppearance.BorderSize = 0;

                    
                    btnRectangulo.Click += (playlistBtn, eBtn) =>
                    {
                        Playlist1 seleccionada = (Playlist1)((Button)playlistBtn).Tag;

                        MessageBox.Show("Abriendo playlist: " + seleccionada.nombre + "\n\nAqui se cargaran las canciones ", "Reproductor");
                    };

                    // Añadimos el botón al formulario activo
                    this.Controls.Add(btnRectangulo);  
                    x += 200;
                    columnas++;
                    if (columnas % 3 == 0)
                    {
                        x = xInicial; 
                        y += 100;     
                    }
                    actual = actual.Siguiente;
                }
            }
            catch (Exception ex)
            {
                //seguridad por si la BD tira algún error
                MessageBox.Show("Error al cargar las playlists desde SQL: " + ex.Message, "Error de Base de Datos");
            }
        }
    }
}
