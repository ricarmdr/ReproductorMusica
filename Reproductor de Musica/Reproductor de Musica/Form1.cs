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
        Playlist1 biblioteca = new Playlist1("Biblioteca");
        Reproductor reproductor;
        NodoCancion actual;
        private bool _scrubbing = false;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load_1;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Biblioteca general
            biblioteca = ConexionGlobal.Instancia.ObtenerCancion();
            //Configurar y cargar dgv con las cnaciones
            ConfigurarColumnasDGV();
            CargarDataGrid();
            dvgCanciones.ClearSelection();

            //Inicializacion del reproductor
            reproductor = new Reproductor(biblioteca);
            reproductor.OnCancionCambiada += SeleccionarEnGrid;

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
                lbl.Text = "Vol: 100%";  // valor inicial correcto

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
            btnBiblio.Margin = new Padding(3,45,3,3);

            //Centra el panel de reproducción dentro del panel3
            panelRep.Left = (panel3.Width - panelRep.Width) / 2;

            panelHoy.Margin = new Padding(20, 0, 0, 0);
            panelHoy.Width = 300;
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

        //Al darle clic a la fila de la cancion, se reproduce esa cancion
        private void dvgCanciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evita que falle si hacen click en encabezados
            if (e.RowIndex < 0) return;

            Cancion c = ObtenerCancionSeleccionada();

            if (c == null) return;

            reproductor.ReproducirCancion(c);

            MostrarCancionActual(c);
            ActualizarBotonPlayPause();
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (reproductor.EstadoReproduccion == PlaybackState.Playing)
            {
                reproductor.PausarCancion();
            }
            else
            {
                Cancion c = ObtenerCancionSeleccionada();

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
            string historialTexto = reproductor.ObtenerHistorialTexto();
            MessageBox.Show(historialTexto);
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
        private void dvgCanciones_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dvgCanciones.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void dvgCanciones_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dvgCanciones.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
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

                CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar canción: " + ex.Message);
            }
        }

        public void CargarDataGrid()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Artista", typeof(string));
            tabla.Columns.Add("RutaArchivo", typeof(string));
            tabla.Columns.Add("Duracion", typeof(string));

            // Usa biblioteca directamente, no vuelvas a consultar la BD
            NodoCancion temp = biblioteca.inicio;
            while (temp != null)
            {
                // Formato correcto para TimeSpan
                string duracionTexto = string.Format("{0}:{1:D2}",
                    (int)temp.Dato.Duracion.TotalMinutes,
                    temp.Dato.Duracion.Seconds);

                tabla.Rows.Add(
                    temp.Dato.Id,
                    temp.Dato.Nombre,
                    temp.Dato.Artista,
                    temp.Dato.RutaArchivo,
                    duracionTexto
                );
                temp = temp.Siguiente;
            }

            dvgCanciones.DataSource = tabla;
        }
        public void SeleccionarEnGrid(int idCancion)
        {
            if (dvgCanciones.InvokeRequired)
            {
                dvgCanciones.Invoke((Action)(() => SeleccionarEnGrid(idCancion)));
                return;
            }

            foreach (DataGridViewRow row in dvgCanciones.Rows)
            {
                if (row.Cells["Id"].Value != null && Convert.ToInt32(row.Cells["Id"].Value) == idCancion)
                {
                    dvgCanciones.ClearSelection();
                    row.Selected = true;
                    dvgCanciones.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }
        private void ActualizarBotonPlayPause()
        {
            if (reproductor.EstadoReproduccion == PlaybackState.Playing)
                btnPlayPause.BackgroundImage = Properties.Resources.pausa;
            else
                btnPlayPause.BackgroundImage = Properties.Resources.play;
        }
        private void ConfigurarColumnasDGV()
        {
            dvgCanciones.AutoGenerateColumns = false;
            dvgCanciones.AllowUserToAddRows = false;
            dvgCanciones.Columns.Clear();

            dvgCanciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", Visible = false });
            dvgCanciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", DataPropertyName = "Nombre", HeaderText = "Canción", Width = 200 });
            dvgCanciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Artista", DataPropertyName = "Artista", HeaderText = "Artista", Width = 150 });
            dvgCanciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "RutaArchivo", DataPropertyName = "RutaArchivo", Visible = false });
            dvgCanciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Duracion", DataPropertyName = "Duracion", HeaderText = "Duración", Width = 80 });
        }

        private Cancion ObtenerCancionSeleccionada()
        {
            if (dvgCanciones.CurrentRow == null) return null;

            DataRowView fila = (DataRowView)dvgCanciones.CurrentRow.DataBoundItem;
            if (fila == null) return null;

            TimeSpan duracion = TimeSpan.Zero;
            TimeSpan.TryParse("00:" + fila["Duracion"].ToString(), out duracion);

            return new Cancion(
                Convert.ToInt32(fila["Id"]),
                fila["Nombre"].ToString(),
                fila["Artista"].ToString(),
                fila["RutaArchivo"].ToString(),
                duracion
            );
        }

        // Muestra la información de la canción actual en el panel de reproducción
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Estás seguro que deseas salir?", "Confirmar Salida" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.No)
                e.Cancel = true;
        }
    }
}

