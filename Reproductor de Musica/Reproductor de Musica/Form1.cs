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
            CargarDataGrid();
            dvgCanciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgCanciones.MultiSelect = false;
            dvgCanciones.ReadOnly = true;

            dvgCanciones.Columns["RutaArchivo"].Visible = false;
            dvgCanciones.Columns["Id"].Visible = false;

            reproductor = new Reproductor(biblioteca);

            reproductor.OnCancionCambiada += SeleccionarEnGrid;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de audio|*.mp3;*.wav";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string ruta = ofd.FileName;

                AgregarCancion(ruta);
            }
        }

        public void AgregarCancion(string rutaArchivo)
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

                string nombre = Path.GetFileNameWithoutExtension(rutaArchivo);

                //Temporal
                string artista = "Desconocido";

                Cancion nueva = new Cancion(0, nombre, artista, rutaRelativa);

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
            dvgCanciones.DataSource = null;
            dvgCanciones.DataSource = biblioteca.ObtenerLista();

        }

        public void SeleccionarEnGrid(int idCancion)
        {
            foreach (DataGridViewRow row in dvgCanciones.Rows)
            {
                Cancion c = (Cancion)row.DataBoundItem;

                if (c.Id == idCancion)
                {
                    row.Selected = true;

                  
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Visible)
                        {
                            dvgCanciones.CurrentCell = cell;
                            break;
                        }
                    }

                    dvgCanciones.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            if (dvgCanciones.CurrentRow != null)
            {
                Cancion c = (Cancion)dvgCanciones.CurrentRow.DataBoundItem;
                reproductor.ReproducirCancion(c);
            }
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
    }
}
