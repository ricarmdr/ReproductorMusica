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



namespace Reproductor_de_Musica
{
    public partial class Form1 : Form
    {
        Playlist1 biblioteca = new Playlist1("Biblioteca");
        Reproductor reproductor;
        NodoCancion actual;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            biblioteca = ConexionGlobal.Instancia.ObtenerCancion(); 
            ConfigurarColumnasDGV();
            CargarDataGrid(); 
            reproductor = new Reproductor(biblioteca);
            reproductor.OnCancionCambiada += SeleccionarEnGrid;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (AgregarCancion formAgregar = new AgregarCancion())
            {
                if (formAgregar.ShowDialog() == DialogResult.OK)
                {
                    // Llamar a tu método ya corregido
                    AgregarCancion1(
                        formAgregar.NombreCancion,
                        formAgregar.ArtistaCancion,
                        formAgregar.RutaCancion,
                        formAgregar.DuracionCancion
                    );
                }
            }
        }

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

        private void dvgCanciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            Cancion c = ObtenerCancionSeleccionada();
            if (c == null) { MessageBox.Show("Selecciona una canción."); return; }
            reproductor.ReproducirCancion(c);
            ActualizarBotonPlayPause();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            reproductor.PausarCancion();
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

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            // Verifica que haya una cancinn seleccionada
            if (dvgCanciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una canción primero.");
                return;
            }

            // Obtiene la cancion seleccionada 
            int id = Convert.ToInt32(dvgCanciones.SelectedRows[0].Cells["Id"].Value);
            string nombre = dvgCanciones.SelectedRows[0].Cells["Nombre"].Value.ToString();
            string artista = dvgCanciones.SelectedRows[0].Cells["Artista"].Value.ToString();
            string ruta = dvgCanciones.SelectedRows[0].Cells["RutaArchivo"].Value.ToString();

            TimeSpan duracion = TimeSpan.Zero;
            if (dvgCanciones.SelectedRows[0].Cells["Duracion"].Value != null)
                TimeSpan.TryParse(dvgCanciones.SelectedRows[0].Cells["Duracion"].Value.ToString(), out duracion);

            Cancion seleccionada = new Cancion(id, nombre, artista, ruta, duracion);

            
            reproductor.ReproducirCancion(seleccionada);

            // Actualizar el boton segun el estado resultante
            ActualizarBotonPlayPause();
        }

        private void ActualizarBotonPlayPause()
        {
            if (reproductor.EstadoReproduccion == PlaybackState.Playing)
                btnPlayPause.Text = "⏸ Pausar";
            else
                btnPlayPause.Text = "▶ Reproducir";
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



    }
    }

