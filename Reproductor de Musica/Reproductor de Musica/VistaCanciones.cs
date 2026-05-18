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
    public partial class VistaCanciones : UserControl
    {
        private Playlist1 playlistActual;
        public event Action<Cancion> CancionSeleccionada;

        public VistaCanciones(Playlist1 playlist)
        {
            InitializeComponent();

            //ESTE IF ES PARA QUE EN LA BIBLIOTECA NO APAREZCA LA OPCION ELIMINAR 
            //CANCION DE PLAYLIST
            if (playlist.Id == 0)
            {
                eliminarDePlaylistToolStripMenuItem.Visible = false;
            }

            this.playlistActual = playlist;

            ConfigurarColumnasDGV();
            CargarDataGrid();
        }

        private void ConfigurarColumnasDGV()
        {
            dvgCanciones.AutoGenerateColumns = false;
            dvgCanciones.AllowUserToAddRows = false;
            dvgCanciones.Columns.Clear();

            dvgCanciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "No", DataPropertyName = "No", HeaderText = "No.", Width = 50 });
            dvgCanciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", Visible = false });
            dvgCanciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", DataPropertyName = "Nombre", HeaderText = "Canción", Width = 200 });
            dvgCanciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Artista", DataPropertyName = "Artista", HeaderText = "Artista", Width = 150 });
            dvgCanciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "RutaArchivo", DataPropertyName = "RutaArchivo", Visible = false });
            dvgCanciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Duracion", DataPropertyName = "Duracion", HeaderText = "Duración", Width = 80 });

            //Se deshabilita la ordenación de la columna al dar doble clic al encabezado
            dvgCanciones.Columns["Id"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvgCanciones.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvgCanciones.Columns["Artista"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dvgCanciones.Columns["Duracion"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void CargarDataGrid()
        {
            DataTable tabla = new DataTable();
            int numero = 1;

            tabla.Columns.Add("No", typeof(int));
            tabla.Columns.Add("Id", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Artista", typeof(string));
            tabla.Columns.Add("RutaArchivo", typeof(string));
            tabla.Columns.Add("Duracion", typeof(string));

            // Usa biblioteca directamente, no vuelve a consultar la BD
            NodoCancion temp = playlistActual.inicio;
            while (temp != null)
            {
                // Formato correcto para TimeSpan
                string duracionTexto = string.Format("{0}:{1:D2}",
                    (int)temp.Dato.Duracion.TotalMinutes,
                    temp.Dato.Duracion.Seconds);

                tabla.Rows.Add(
                    numero,
                    temp.Dato.Id,
                    temp.Dato.Nombre,
                    temp.Dato.Artista,
                    temp.Dato.RutaArchivo,
                    duracionTexto
                );

                numero++;
                temp = temp.Siguiente;
            }

            dvgCanciones.DataSource = tabla;
        }

        public Cancion ObtenerCancionSeleccionada()
        {
            if (dvgCanciones.CurrentRow == null) return null;

            DataRowView fila = (DataRowView)dvgCanciones.CurrentRow.DataBoundItem;
            if (fila == null) return null;

            TimeSpan duracion = TimeSpan.Zero;
            TimeSpan.TryParse("00:" + fila["Duracion"].ToString(), out duracion);

            return new Cancion(
                Convert.ToInt32(fila["Id"]),
                fila["Nombre"].ToString(),
                fila["Artista"].ToString(),
                fila["RutaArchivo"].ToString(),
                duracion
            );
        }

        private void dvgCanciones_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dvgCanciones.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void dvgCanciones_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dvgCanciones.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
        }
        public void SeleccionarEnGrid(int idCancion)
        {
            if (dvgCanciones.InvokeRequired)
            {
                dvgCanciones.Invoke((Action)(() => SeleccionarEnGrid(idCancion)));
                return;
            }

            foreach (DataGridViewRow row in dvgCanciones.Rows)
            {
                if (row.Cells["Id"].Value != null && Convert.ToInt32(row.Cells["Id"].Value) == idCancion)
                {
                    dvgCanciones.ClearSelection();
                    row.Selected = true;
                    dvgCanciones.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        //Al darle clic a la fila de la cancion, se reproduce esa cancion
        private void dvgCanciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evita que falle si hacen click en encabezados
            if (e.RowIndex < 0) return;

            Cancion c = ObtenerCancionSeleccionada();

            if (c == null) return;

            CancionSeleccionada?.Invoke(c);
        }

        private void dvgCanciones_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == MouseButtons.Right)
            {
                dvgCanciones.ClearSelection();
                dvgCanciones.Rows[e.RowIndex].Selected = true;
                dvgCanciones.CurrentCell =
                dvgCanciones.Rows[e.RowIndex].Cells["Nombre"];
            }
        }

        private void agregarAPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancion c = ObtenerCancionSeleccionada();

            if (c == null)
            {
                MessageBox.Show("Selecciona una canción");
                return;
            }

            FormSeleccionPlaylist frm = new FormSeleccionPlaylist(playlistActual.Id);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                Playlist1 playlist = frm.PlaylistSeleccionada;

                bool existe = ConexionGlobal.Instancia.ExisteCancionEnPlaylist(c.Id, playlist.Id);

                if (existe)
                {
                    MessageBox.Show("La canción ya existe en esta playlist");
                    return;
                }

                ConexionGlobal.Instancia.AgregarCancionPlaylist(c.Id, playlist.Id);

                MessageBox.Show("Canción agregada a playlist");
            }
        }

        private void eliminarDePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancion c = ObtenerCancionSeleccionada();

            if (c == null)
            {
                MessageBox.Show("Selecciona una canción");
                return;
            }

            DialogResult resp = MessageBox.Show("¿Eliminar canción de la playlist?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.No)
                return;

            ConexionGlobal.Instancia.EliminarCancionDePlaylist(c.Id, playlistActual.Id);

            playlistActual.EliminarCancion(c.Id);

            CargarDataGrid();

            MessageBox.Show("Canción eliminada de la playlist");
        }
    }
}
