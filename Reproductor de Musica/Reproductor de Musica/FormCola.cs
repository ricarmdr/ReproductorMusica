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
        private ColaReproduccion _cola; // referencia a la cola guardada
        public FormCola(ColaReproduccion cola)
        {
            _cola = cola; // guardar referencia

            InitializeComponent();
            
            ConfigurarColumnas();
            RefrescarGrid();

            // Si la cola está vacía, mostrar mensaje
            if (cola.EstaVacia())
            {
                MessageBox.Show("La cola está vacía", "Cola de reproducción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void ConfigurarColumnas()
        {
            // Se configuran las columnas del DGV
            dgvCola.Columns.Clear();
            dgvCola.AutoGenerateColumns = false;
            dgvCola.AllowUserToAddRows = false;
            dgvCola.ReadOnly = true;

            // Columna Id oculta para identificar la canción
            dgvCola.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", Visible = false});
            dgvCola.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Canción", Width = 200 });
            dgvCola.Columns.Add(new DataGridViewTextBoxColumn { Name = "Artista", HeaderText = "Artista", Width = 150 });

        }

        private void RefrescarGrid()
        {
            dgvCola.Rows.Clear();

            // Recorrer la cola y agregar filas
            NodoCola temp = _cola.ObtenerFrente();
            while (temp != null)
            {
                dgvCola.Rows.Add(temp.Dato.Id, temp.Dato.Nombre, temp.Dato.Artista);
                temp = temp.Siguiente;
            }
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvCola.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una canción de la cola", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el id de la fila seleccionada
            int idCancion = Convert.ToInt32(dgvCola.CurrentRow.Cells["Id"].Value);

            _cola.EliminarDeCola(idCancion);
            RefrescarGrid();

            MessageBox.Show("Canción quitada de la cola", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
