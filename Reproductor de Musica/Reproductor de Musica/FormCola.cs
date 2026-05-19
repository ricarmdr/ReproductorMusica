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
    public partial class FormCola : Form
    {
        public FormCola(ColaReproduccion cola)
        {
            InitializeComponent();

            // Se configuran las columnas del DGV
            dgvCola.Columns.Clear();
            dgvCola.AutoGenerateColumns = false;
            dgvCola.AllowUserToAddRows = false;
            dgvCola.ReadOnly = true;

            dgvCola.Columns.Add(new DataGridViewTextBoxColumn{ Name = "Nombre", HeaderText = "Canción", Width = 200});
            dgvCola.Columns.Add(new DataGridViewTextBoxColumn{ Name = "Artista", HeaderText = "Artista", Width = 150});

            // LUEGO recorrer la cola y agregar filas
            NodoCola temp = cola.ObtenerFrente();
            while (temp != null)
            {
                dgvCola.Rows.Add(temp.Dato.Nombre, temp.Dato.Artista);
                temp = temp.Siguiente;
            }

            // Si la cola está vacía, mostrar mensaje
            if (cola.EstaVacia())
            {
                MessageBox.Show("La cola está vacía", "Cola de reproducción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
