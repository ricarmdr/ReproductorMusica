using System;
using System.Drawing;
using System.Windows.Forms;

namespace Reproductor_de_Musica
{
    public partial class FrmHistorial : Form
    {
        // Constructor con historial
        public FrmHistorial(NodoCancion cima)
        {
            InitializeComponent();
            ConfigurarGrid();

            dgvHistorial.Columns.Clear();

            dgvHistorial.Columns.Add("Nombre", "Canción");
            dgvHistorial.Columns.Add("Artista", "Artista");

            //CONFIGURACION DE ASPECTOS DE LAS COLUMNAS
            dgvHistorial.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvHistorial.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvHistorial.Columns["Artista"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvHistorial.Columns["Artista"].SortMode = DataGridViewColumnSortMode.NotSortable;

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

        // Metodo para estilos y propiedades
        private void ConfigurarGrid()
        { 
            //GENERAL
            dgvHistorial.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvHistorial.EnableHeadersVisualStyles = false;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.AllowUserToResizeColumns = false;
            dgvHistorial.AllowUserToResizeRows = false;
            dgvHistorial.MultiSelect = false;
            dgvHistorial.ReadOnly = true;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // HEADER
            dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(180, 180, 180);
            dgvHistorial.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvHistorial.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(18, 18, 18);
            dgvHistorial.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgvHistorial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; 
            dgvHistorial.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvHistorial.ColumnHeadersDefaultCellStyle.Padding = new Padding(40, 0, 0, 0);
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHistorial.ColumnHeadersHeight = 40;

            // FILAS
            dgvHistorial.RowsDefaultCellStyle.BackColor = Color.FromArgb(18, 18 ,18);
            dgvHistorial.RowsDefaultCellStyle.ForeColor = Color.White;
            dgvHistorial.RowsDefaultCellStyle.Font =  new Font("Segoe UI", 10, FontStyle.Regular);
            dgvHistorial.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(28, 28, 28);
            dgvHistorial.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvHistorial.RowTemplate.Height = 32;

            // SELECCIÓN
            dgvHistorial.DefaultCellStyle.SelectionBackColor = dgvHistorial.DefaultCellStyle.BackColor;
            dgvHistorial.DefaultCellStyle.SelectionForeColor = dgvHistorial.DefaultCellStyle.ForeColor;
            dgvHistorial.DefaultCellStyle.Padding = new Padding(40,0,0,0);

            // GRID
            dgvHistorial.BackgroundColor = Color.FromArgb(18, 18, 18);
            dgvHistorial.GridColor = Color.FromArgb(18, 18, 18);
            dgvHistorial.BorderStyle = BorderStyle.None;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}