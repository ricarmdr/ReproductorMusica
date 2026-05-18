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
    public partial class FormRenombrar : Form
    {
        public string NuevoNombre
        {
            get { return txtNombre.Text.Trim(); } //Elimina espacios al inicio y al final del nombre
        }
        public FormRenombrar(string nombreActual)
        {
            InitializeComponent();

            txtNombre.Text = nombreActual; // Se muestra el nombre actual en el TextBox para que el usuario pueda editarlo
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Escribe un nombre");
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
