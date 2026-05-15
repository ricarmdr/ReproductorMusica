using System;
using System.Drawing;
using System.Windows.Forms;

namespace Reproductor_de_Musica
{
    public partial class FrmHistorial : Form
    {
        // Constructor vacío
        public FrmHistorial()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        // Constructor con historial
        public FrmHistorial(NodoCancion cima)
        {
            InitializeComponent();
            ConfigurarGrid();

            dgvHistorial.Columns.Clear();

            dgvHistorial.Columns.Add("Nombre", "Canción");
            dgvHistorial.Columns.Add("Artista", "Artista");

            NodoCancion actual = cima;

            while (actual != null)
            {
                dgvHistorial.Rows.Add(
                    actual.Dato.Nombre,
                    actual.Dato.Artista
                );

                actual = actual.Siguiente;
            }
        }

        // Método para estilos
        private void ConfigurarGrid()
        {
            dgvHistorial.EnableHeadersVisualStyles = false;

            // HEADER
            dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistorial.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 30, 30);
            dgvHistorial.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            // FILAS
            dgvHistorial.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            dgvHistorial.DefaultCellStyle.ForeColor = Color.White;

            // SELECCIÓN
            dgvHistorial.DefaultCellStyle.SelectionBackColor = Color.FromArgb(249, 115, 22);
            dgvHistorial.DefaultCellStyle.SelectionForeColor = Color.White;

            // GRID
            dgvHistorial.BackgroundColor = Color.FromArgb(18, 18, 18);
            dgvHistorial.GridColor = Color.FromArgb(40, 40, 40);
            dgvHistorial.BorderStyle = BorderStyle.None;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}