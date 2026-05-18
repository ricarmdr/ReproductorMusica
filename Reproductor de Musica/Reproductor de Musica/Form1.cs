using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.Drawing.Drawing2D;


namespace Reproductor_de_Musica
{
    public partial class Form1 : Form
    {
        Playlist1 biblioteca = new Playlist1(0, "Biblioteca");
        Reproductor reproductor;
        private bool _scrubbing = false;
        private VistaCanciones vistaCanciones;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load_1;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Biblioteca
            biblioteca = ConexionGlobal.Instancia.ObtenerCancion();

            // Crear reproductor
            reproductor = new Reproductor(biblioteca);

            reproductor.OnCancionCambiada += ActualizarInfoCancion;

            // Mostrar vista de canciones con la biblioteca al iniciar
            MostrarVistaCanciones(biblioteca, "Biblioteca");

            //Inicializacion y configuracion del contro del volumen
            TrackBar trk = panelVol.Controls["trkVolumen"] as TrackBar;
            Label lbl = panelVol.Controls["lblVolumen"] as Label;

            if (trk != null)
            {
                trk.Minimum = 0;
                trk.Maximum = 100;
                trk.Value = 100;
                trk.TickFrequency = 10;
                trk.Size = new System.Drawing.Size(90, 90);
                trk.Scroll -= trkVolumen_Scroll;
                trk.Scroll += trkVolumen_Scroll;

            }

            if (lbl != null)
                lbl.Text = "Vol: 100%";  // valor inicial

            //Configuracion del timer y barra de reproduccion
            timerProgreso.Interval = 500;
            timerProgreso.Tick += timerProgreso_Tick;
            timerProgreso.Start();

            trackBarProgreso.Minimum = 0;
            trackBarProgreso.Maximum = 1000;
            trackBarProgreso.MouseDown += (s, ev) => _scrubbing = true;
            trackBarProgreso.MouseUp += (s, ev) => {
                _scrubbing = false;
                double ratio = trackBarProgreso.Value / 1000.0;
                reproductor.DetPosicion(TimeSpan.FromSeconds(ratio * reproductor.Duracion.TotalSeconds));
            };

            //Inicializa el botòn de play/pause con forma circular
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btnPlayPause.Width, btnPlayPause.Height);
            btnPlayPause.Region = new Region(path);

            //Agrega margen al botón de la biblioteca para separarlo del contenido superior
            btnBiblio.Margin = new Padding(3, 45, 3, 3);

            //Centra el panel de reproducción dentro del panel3
            panelRep.Left = (panel3.Width - panelRep.Width) / 2;

            panelHoy.Margin = new Padding(20, 0, 0, 0);
            panelHoy.Width = 300;

            lblTitulo.Text = "Biblioteca";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (AgregarCancion formAgregar = new AgregarCancion())
            {
                if (formAgregar.ShowDialog() == DialogResult.OK)
                {
                    // Llamar al método para agregar cancion
                    AgregarCancion1(
                        formAgregar.NombreCancion,
                        formAgregar.ArtistaCancion,
                        formAgregar.RutaCancion,
                        formAgregar.DuracionCancion
                    );
                }
            }
        }
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (reproductor.EstadoReproduccion == PlaybackState.Playing)
            {
                reproductor.PausarCancion();
            }
            else
            {
                Cancion c = vistaCanciones.ObtenerCancionSeleccionada();

                if (c == null)
                {
                    MessageBox.Show("Selecciona una canción primero.");
                    return;
                }

                reproductor.ReproducirCancion(c);
                MostrarCancionActual(c);
            }
            ActualizarBotonPlayPause();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            reproductor.CancionAnterior();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            reproductor.SiguienteCancion();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            NodoCancion historial = reproductor.ObtenerHistorial();

            FrmHistorial ventana = new FrmHistorial(historial);
            ventana.ShowDialog();
        }

        private void timerProgreso_Tick(object sender, EventArgs e)
        {
            if (_scrubbing || reproductor == null) return;
            var dur = reproductor.Duracion;
            var pos = reproductor.Posicion;
            if (dur.TotalSeconds > 0)
                trackBarProgreso.Value = (int)(pos.TotalSeconds / dur.TotalSeconds * 1000);
            lblTiempoActual.Text = pos.ToString(@"m\:ss");
            lblDuracion.Text = dur.ToString(@"m\:ss");
        }

        private void trkVolumen_Scroll(object sender, EventArgs e)
        {
            TrackBar trk = sender as TrackBar;
            Label lbl = panelVol.Controls["lblVolumen"] as Label;

            int volumenReal = trk.Value;
            reproductor.CambiarVolumen(volumenReal);

            if (lbl != null)
                lbl.Text = "Vol: " + volumenReal + "%";
        }
        private void btnrayitas_Click(object sender, EventArgs e)
        {
            //al darle click al boton de las rayitas, se muestra o se oculta el submenu
            psubmenu.Visible = !psubmenu.Visible;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Estás seguro que deseas salir?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.No)
                e.Cancel = true;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Form info = new FormInfo();
            info.ShowDialog();
        }

        private void btnCrearPlaylist_Click(object sender, EventArgs e)
        {
            FormCrearPlaylist ventanaCrear = new FormCrearPlaylist();
            DialogResult resultado = ventanaCrear.ShowDialog();
            // Si en este punto se guardo con exito en la playlist, se manda directo a verlas.
            if (resultado == DialogResult.OK)
            {
                btnverplaylist_Click(sender, e);
            }
        }

        private void btnverplaylist_Click(object sender, EventArgs e)
        {
            //Se crea la vista de ver playlists y se muestra en el panel de contenido, reemplazando a la vista de canciones.
            VistaVerPlaylists vistaPlaylists = new VistaVerPlaylists();
            vistaPlaylists.Dock = DockStyle.Fill;

            vistaPlaylists.PlaylistSeleccionada += AbrirPlaylist;

            // Agregar al panel
            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(vistaPlaylists);

            lblTitulo.Text = "Mis Playlists";
        }

        //METODO PARA ABRIR PLAYLIST CON SUS CANCIONES
        private void AbrirPlaylist(Playlist1 playlist)
        {
            Playlist1 playlistCompleta =
                ConexionGlobal.Instancia.ObtenerPlaylistConCanciones(
                    playlist.Id,
                    playlist.nombre
                );

            MostrarVistaCanciones(
                playlistCompleta,
                playlist.nombre
            );
        }

        private void btnBiblio_Click(object sender, EventArgs e)
        {
            MostrarVistaCanciones(biblioteca, "Biblioteca");
        }

        /*////////////////////////////////////////////////////////////////////////////////////
                                        METODOS Y FUNCIONES
        /////////////////////////////////////////////////////////////////////////////////////*/

        public void AgregarCancion1(string nombre, string artistas, string rutaArchivo, TimeSpan duracion)
        {
            try
            {

                if (!File.Exists(rutaArchivo))
                {
                    MessageBox.Show("El archivo no existe");
                    return;
                }

                // obtienee la carpeta musica
                string carpetaMusica = Path.Combine(Application.StartupPath, "Musica");

                //crea la carpeta si no existe 
                if (!Directory.Exists(carpetaMusica))
                {
                    Directory.CreateDirectory(carpetaMusica);
                }

                //crea la nueva ruta
                string nombreArchivo = Path.GetFileName(rutaArchivo);

                string rutaRelativa = Path.Combine("Musica", nombreArchivo);

                string nuevaRuta = Path.Combine(carpetaMusica, nombreArchivo);

                //copia el archivo a la carpeta musica
                try
                {
                    File.Copy(rutaArchivo, nuevaRuta, true);
                }
                catch (IOException)
                {
                    MessageBox.Show("El archivo está en uso. Cierra el reproductor o intenta con otra canción.");
                    return;
                }

                Cancion nueva = new Cancion(0, nombre, artistas, rutaRelativa, duracion);

                int id = ConexionGlobal.Instancia.GuardarCancion(nueva);
                nueva.Id = id;

                biblioteca.AgregarCancion(nueva);

                MessageBox.Show("Canción agregada correctamente");

                vistaCanciones.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar canción: " + ex.Message);
            }
        }

        private void ReproducirDesdeVista(Cancion c)
        {
            reproductor.ReproducirCancion(c);

            MostrarCancionActual(c);

            ActualizarBotonPlayPause();
        }
        private void ActualizarBotonPlayPause()
        {
            if (reproductor.EstadoReproduccion == PlaybackState.Playing)
                btnPlayPause.BackgroundImage = Properties.Resources.pausa;
            else
                btnPlayPause.BackgroundImage = Properties.Resources.play;
        }

        // Muestra la informacion de la canción actual en el panel de reproducción
        private void MostrarCancionActual(Cancion c)
        {
            if (c == null) return;

            lblName.Text = c.Nombre;
            lblArtist.Text = c.Artista;

            lblName.Visible = true;
            lblArtist.Visible = true;
            picAlbum.Visible = true;

            // imagen genérica
            picAlbum.Image = Properties.Resources.disco;
        }
        private void MostrarVistaCanciones(Playlist1 playlist, string titulo)
        {
            /* Si ya hay una vista de canciones se desenlazan los eventos para evitar problemas 
               al cambiar de playlist y que no se creen multiples suscripciones al mismo evento */
            if (vistaCanciones != null)
            {
                reproductor.OnCancionCambiada -= vistaCanciones.SeleccionarEnGrid;
            }

            // Actualizar la playlist activa del reproductor para que siguiente/anterior naveguen dentro de esta playlist y no de la biblioteca
            reproductor.CambiarPlaylist(playlist);

            //Se crea la vista de canciones con playlist seleccionada
            vistaCanciones = new VistaCanciones(playlist);
            vistaCanciones.Dock = DockStyle.Fill;

            // Agregar al panel de contenido
            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(vistaCanciones);

            //Se enlazan los eventos para que al seleccionar una cancion se reproduzca y para que al cambiar la canción desde el reproductor se seleccione en la vista
            vistaCanciones.CancionSeleccionada += ReproducirDesdeVista;
            reproductor.OnCancionCambiada += vistaCanciones.SeleccionarEnGrid;

            //Se actualiza el titulo del panelTitulo
            lblTitulo.Text = titulo;
        }

        private void btnAgregarPlaylist_Click(object sender, EventArgs e)
        {
            Cancion c = vistaCanciones.ObtenerCancionSeleccionada();

            if (c == null)
            {
                MessageBox.Show("Selecciona una canción");
                return;
            }

            FormSeleccionPlaylist frm =
                new FormSeleccionPlaylist();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                Playlist1 playlist =
                    frm.PlaylistSeleccionada;

                ConexionGlobal.Instancia.AgregarCancionPlaylist(
                    c.Id,
                    playlist.Id
                );

                MessageBox.Show(
                    "Canción agregada a la playlist"
                );
            }
        }

        //Metodo para actualizar la informacion de la cancion actual en el panel de reproduccion cada vez que se cambia de cancion
        //desde el reproductor (siguiente/anterior) o se reproduce una nueva desde la vista de canciones
        private void ActualizarInfoCancion(int idCancion)
        {
            NodoCancion actual = biblioteca.inicio;

            while (actual != null)
            {
                if (actual.Dato.Id == idCancion)
                {
                    MostrarCancionActual(actual.Dato);
                    return;
                }

                actual = actual.Siguiente;
            }
        }
    }
}

