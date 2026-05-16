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
    public partial class FormHistorial : Form
    {
        private Historial historial;
        public FormHistorial(Historial historial)
        {
            InitializeComponent();

            this.historial = historial;

            CargarHistorial();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarHistorial()
        {
            dgvHistorial.Rows.Clear();

            NodoCancion actual = historial.Peek(); // Obtener la canción más reciente sin eliminarla

            while (actual != null) // Recorrer la pila mientras no esté vacía
            {
                dgvHistorial.Rows.Add(actual.Dato.Nombre,actual.Dato.Artista); // Agregar la canción al DataGridView

                actual = actual.Siguiente; // Mover al siguiente nodo (canción anterior en la pila)
            }

        }

    }
}
