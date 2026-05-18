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
    public partial class FormSeleccionPlaylist : Form
    {
        //PARA EVITAR GUARDAR LA CANCION EN LA MISMA PLAYLISTS
        private int idPlaylistExcluir;

        public FormSeleccionPlaylist(int idExcluir = -1)
        {
            InitializeComponent();

            idPlaylistExcluir = idExcluir;
        }

        public Playlist1 PlaylistSeleccionada { get; private set; }

        private void FormSeleccionPlaylist_Load(object sender, EventArgs e)
        {
            GestorBaseDatos.NodoPlaylist aux =
                ConexionGlobal.Instancia.ObtenerPlaylists();

            while (aux != null)
            {
                if (aux.Dato.Id != idPlaylistExcluir)
                {
                    cmbPlaylists.Items.Add(aux.Dato);
                }
                aux = aux.Siguiente;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PlaylistSeleccionada =
                cmbPlaylists.SelectedItem as Playlist1;

            if (PlaylistSeleccionada == null)
            {
                MessageBox.Show("Selecciona una playlist");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
