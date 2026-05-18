namespace Reproductor_de_Musica
{
    partial class VistaVerPlaylists
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
            this.ContextMenuPlaylist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renombrarPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuPlaylist.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenuPlaylist
            // 
            this.ContextMenuPlaylist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renombrarPlaylistToolStripMenuItem,
            this.eliminarPlaylistToolStripMenuItem});
            this.ContextMenuPlaylist.Name = "contextMenuStrip1";
            this.ContextMenuPlaylist.Size = new System.Drawing.Size(185, 70);
            // 
            // renombrarPlaylistToolStripMenuItem
            // 
            this.renombrarPlaylistToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.renombrarPlaylistToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renombrarPlaylistToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.renombrarPlaylistToolStripMenuItem.Name = "renombrarPlaylistToolStripMenuItem";
            this.renombrarPlaylistToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.renombrarPlaylistToolStripMenuItem.Text = "Renombrar Playlist";
            this.renombrarPlaylistToolStripMenuItem.Click += new System.EventHandler(this.renombrarPlaylistToolStripMenuItem_Click);
            // 
            // eliminarPlaylistToolStripMenuItem
            // 
            this.eliminarPlaylistToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.eliminarPlaylistToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarPlaylistToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eliminarPlaylistToolStripMenuItem.Name = "eliminarPlaylistToolStripMenuItem";
            this.eliminarPlaylistToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.eliminarPlaylistToolStripMenuItem.Text = "Eliminar Playlist";
            this.eliminarPlaylistToolStripMenuItem.Click += new System.EventHandler(this.eliminarPlaylistToolStripMenuItem_Click);
            // 
            // VistaVerPlaylists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Name = "VistaVerPlaylists";
            this.Size = new System.Drawing.Size(553, 386);
            this.ContextMenuPlaylist.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ContextMenuPlaylist;
        private System.Windows.Forms.ToolStripMenuItem renombrarPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPlaylistToolStripMenuItem;
    }
}
