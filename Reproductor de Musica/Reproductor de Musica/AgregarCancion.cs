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
    public partial class AgregarCancion : Form
    {
        public string NombreCancion { get; private set; }
        public string ArtistaCancion { get; private set; }
        public string RutaCancion { get; private set; }
        public TimeSpan DuracionCancion { get; private set; }
        public AgregarCancion()
        {
            InitializeComponent();
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Archivos de audio|*.mp3;*.wav;*.flac;*.ogg";
                dialog.Title = "Seleccionar canción";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtRuta.Text = dialog.FileName;

                    // Habilitar controles
                    txtNombre.Enabled = true;
                    txtNombre.BackColor = Color.FromArgb(30,30,30);
                    txtArtista.Enabled = true;
                    txtArtista.BackColor = Color.FromArgb(30,30,30);

                    // Autocompleta el nombre si esta vacío
                    if (string.IsNullOrWhiteSpace(txtNombre.Text))
                        txtNombre.Text = Path.GetFileNameWithoutExtension(dialog.FileName);

                    // Obtener duracion automaticamente
                    DuracionCancion = ObtenerDuracion(dialog.FileName);
                    
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private TimeSpan ObtenerDuracion(string rutaArchivo)
        {
            try
            {
                using (var reader = new AudioFileReader(rutaArchivo))
                {
                    return reader.TotalTime;
                }
            }
            catch
            {
                return TimeSpan.Zero;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingresa el nombre de la canción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtArtista.Text))
            {
                MessageBox.Show("Ingresa el artista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRuta.Text) || !File.Exists(txtRuta.Text))
            {
                MessageBox.Show("Selecciona un archivo de audio válido.", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                return;
            }

            // Guardar valores en las propiedades
            NombreCancion = txtNombre.Text.Trim();
            ArtistaCancion = txtArtista.Text.Trim();
            RutaCancion = txtRuta.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
