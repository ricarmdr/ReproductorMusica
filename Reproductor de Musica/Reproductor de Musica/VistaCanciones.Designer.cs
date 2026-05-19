namespace Reproductor_de_Musica
{
    partial class VistaCanciones
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgCanciones = new System.Windows.Forms.DataGridView();
            this.agregarAPlaylistToolStripMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarAPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAColaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarCanciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCanciones)).BeginInit();
            this.agregarAPlaylistToolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgCanciones
            // 
            this.dvgCanciones.AllowUserToResizeColumns = false;
            this.dvgCanciones.AllowUserToResizeRows = false;
            this.dvgCanciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCanciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dvgCanciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgCanciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgCanciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCanciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgCanciones.ColumnHeadersHeight = 40;
            this.dvgCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgCanciones.ContextMenuStrip = this.agregarAPlaylistToolStripMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgCanciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgCanciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgCanciones.EnableHeadersVisualStyles = false;
            this.dvgCanciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dvgCanciones.Location = new System.Drawing.Point(0, 0);
            this.dvgCanciones.Margin = new System.Windows.Forms.Padding(22, 2, 2, 2);
            this.dvgCanciones.MultiSelect = false;
            this.dvgCanciones.Name = "dvgCanciones";
            this.dvgCanciones.ReadOnly = true;
            this.dvgCanciones.RowHeadersVisible = false;
            this.dvgCanciones.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            this.dvgCanciones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgCanciones.RowTemplate.Height = 35;
            this.dvgCanciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCanciones.Size = new System.Drawing.Size(695, 410);
            this.dvgCanciones.TabIndex = 2;
            this.dvgCanciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCanciones_CellClick);
            this.dvgCanciones.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgCanciones_CellMouseDown);
            this.dvgCanciones.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCanciones_CellMouseEnter);
            this.dvgCanciones.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCanciones_CellMouseLeave);
            // 
            // agregarAPlaylistToolStripMenu
            // 
            this.agregarAPlaylistToolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAPlaylistToolStripMenuItem,
            this.agregarAColaToolStripMenuItem,
            this.eliminarDePlaylistToolStripMenuItem,
            this.EliminarCanciónToolStripMenuItem});
            this.agregarAPlaylistToolStripMenu.Name = "agregarAPlaylistToolStripMenu";
            this.agregarAPlaylistToolStripMenu.Size = new System.Drawing.Size(196, 114);
            // 
            // agregarAPlaylistToolStripMenuItem
            // 
            this.agregarAPlaylistToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.agregarAPlaylistToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarAPlaylistToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.agregarAPlaylistToolStripMenuItem.Name = "agregarAPlaylistToolStripMenuItem";
            this.agregarAPlaylistToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.agregarAPlaylistToolStripMenuItem.Text = "+ Agregar a Playlist";
            this.agregarAPlaylistToolStripMenuItem.Click += new System.EventHandler(this.agregarAPlaylistToolStripMenuItem_Click);
            // 
            // agregarAColaToolStripMenuItem
            // 
            this.agregarAColaToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.agregarAColaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarAColaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.agregarAColaToolStripMenuItem.Name = "agregarAColaToolStripMenuItem";
            this.agregarAColaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.agregarAColaToolStripMenuItem.Text = "+ Agregar a Cola";
            this.agregarAColaToolStripMenuItem.Click += new System.EventHandler(this.agregarAColaToolStripMenuItem_Click);
            // 
            // eliminarDePlaylistToolStripMenuItem
            // 
            this.eliminarDePlaylistToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.eliminarDePlaylistToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarDePlaylistToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(184)))), ((int)(((byte)(85)))));
            this.eliminarDePlaylistToolStripMenuItem.Name = "eliminarDePlaylistToolStripMenuItem";
            this.eliminarDePlaylistToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.eliminarDePlaylistToolStripMenuItem.Text = "X Eliminar de Playlist";
            this.eliminarDePlaylistToolStripMenuItem.Click += new System.EventHandler(this.eliminarDePlaylistToolStripMenuItem_Click);
            // 
            // EliminarCanciónToolStripMenuItem
            // 
            this.EliminarCanciónToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.EliminarCanciónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarCanciónToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.EliminarCanciónToolStripMenuItem.Name = "EliminarCanciónToolStripMenuItem";
            this.EliminarCanciónToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.EliminarCanciónToolStripMenuItem.Text = "X Eliminar Canción";
            this.EliminarCanciónToolStripMenuItem.Click += new System.EventHandler(this.EliminarCanciónToolStripMenuItem_Click);
            // 
            // VistaCanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.dvgCanciones);
            this.Name = "VistaCanciones";
            this.Size = new System.Drawing.Size(695, 410);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCanciones)).EndInit();
            this.agregarAPlaylistToolStripMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCanciones;
        private System.Windows.Forms.ContextMenuStrip agregarAPlaylistToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem agregarAPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAColaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EliminarCanciónToolStripMenuItem;
    }
}
