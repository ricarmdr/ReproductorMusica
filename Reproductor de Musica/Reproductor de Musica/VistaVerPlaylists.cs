using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor_de_Musica
{
    public partial class VistaVerPlaylists : UserControl
    {
        public VistaVerPlaylists()
        {
            InitializeComponent();
            CargarYDibujarPlaylists();
        }

        public event Action<Playlist1> PlaylistSeleccionada;

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
                    // Se crea un rectangulo plano 
                    Button btnRectangulo = new Button();
                    btnRectangulo.Text = actual.Dato.nombre; 
                    btnRectangulo.Tag = actual.Dato;
                    btnRectangulo.Size = new System.Drawing.Size(180, 80);
                    btnRectangulo.Location = new Point(x, y);
                    btnRectangulo.BackColor = Color.FromArgb(0, 122, 204);
                    btnRectangulo.ForeColor = Color.White;
                    btnRectangulo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    btnRectangulo.FlatStyle = FlatStyle.Flat;
                    btnRectangulo.FlatAppearance.BorderSize = 0;


                    btnRectangulo.Click += (playlistBtn, eBtn) =>
                    {
                        Playlist1 seleccionada =
                            (Playlist1)((Button)playlistBtn).Tag;

                        PlaylistSeleccionada?.Invoke(seleccionada);
                    };

                    // Añadimos el boton al formulario activo
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
                //seguridad por si la BD tira algun error
                MessageBox.Show("Error al cargar las playlists desde SQL: " + ex.Message, "Error de Base de Datos");
            }
        }
    }
}
