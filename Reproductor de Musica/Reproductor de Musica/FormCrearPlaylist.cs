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
    public partial class FormCrearPlaylist : Form
    {
        public FormCrearPlaylist()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePlaylist.Text))
            {
                MessageBox.Show("Por favor, escribe un nombre para la playlist.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                ConexionGlobal.Instancia.CrearPlaylist(txtNombrePlaylist.Text.Trim());
                MessageBox.Show("¡Playlist creada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con SQL Server: " + ex.Message, "Error de Base de Datos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
