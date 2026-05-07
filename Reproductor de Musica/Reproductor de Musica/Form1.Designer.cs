using System.Windows.Forms;

namespace Reproductor_de_Musica
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timerProgreso = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnrayitas = new System.Windows.Forms.Button();
            this.psubmenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnBiblio = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCrearPlaylist = new System.Windows.Forms.Button();
            this.btnverplaylist = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dvgCanciones = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelHoy = new System.Windows.Forms.Panel();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picAlbum = new System.Windows.Forms.PictureBox();
            this.panelVol = new System.Windows.Forms.Panel();
            this.trkVolumen = new System.Windows.Forms.TrackBar();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.panelRep = new System.Windows.Forms.Panel();
            this.lblTiempoActual = new System.Windows.Forms.Label();
            this.trackBarProgreso = new System.Windows.Forms.TrackBar();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.psubmenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCanciones)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).BeginInit();
            this.panelVol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolumen)).BeginInit();
            this.panelRep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgreso)).BeginInit();
            this.SuspendLayout();
            // 
            // timerProgreso
            // 
            this.timerProgreso.Tick += new System.EventHandler(this.timerProgreso_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 450);
            this.panel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnrayitas);
            this.flowLayoutPanel1.Controls.Add(this.psubmenu);
            this.flowLayoutPanel1.Controls.Add(this.btnBiblio);
            this.flowLayoutPanel1.Controls.Add(this.btnAgregar);
            this.flowLayoutPanel1.Controls.Add(this.btnCrearPlaylist);
            this.flowLayoutPanel1.Controls.Add(this.btnverplaylist);
            this.flowLayoutPanel1.Controls.Add(this.btnHistorial);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(225, 450);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // btnrayitas
            // 
            this.btnrayitas.BackColor = System.Drawing.Color.Transparent;
            this.btnrayitas.BackgroundImage = global::Reproductor_de_Musica.Properties.Resources.menu;
            this.btnrayitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnrayitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrayitas.FlatAppearance.BorderSize = 0;
            this.btnrayitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnrayitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnrayitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrayitas.Location = new System.Drawing.Point(3, 3);
            this.btnrayitas.Name = "btnrayitas";
            this.btnrayitas.Size = new System.Drawing.Size(40, 48);
            this.btnrayitas.TabIndex = 8;
            this.btnrayitas.UseVisualStyleBackColor = false;
            this.btnrayitas.Click += new System.EventHandler(this.btnrayitas_Click);
            // 
            // psubmenu
            // 
            this.psubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.psubmenu.Controls.Add(this.btnSalir);
            this.psubmenu.Controls.Add(this.btnInfo);
            this.psubmenu.Location = new System.Drawing.Point(3, 57);
            this.psubmenu.Name = "psubmenu";
            this.psubmenu.Size = new System.Drawing.Size(225, 78);
            this.psubmenu.TabIndex = 14;
            this.psubmenu.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 39);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(225, 39);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(0, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(225, 39);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Información";
            this.btnInfo.UseVisualStyleBackColor = false;
            // 
            // btnBiblio
            // 
            this.btnBiblio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnBiblio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBiblio.FlatAppearance.BorderSize = 0;
            this.btnBiblio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBiblio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBiblio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiblio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiblio.ForeColor = System.Drawing.Color.White;
            this.btnBiblio.Location = new System.Drawing.Point(3, 141);
            this.btnBiblio.Name = "btnBiblio";
            this.btnBiblio.Size = new System.Drawing.Size(225, 56);
            this.btnBiblio.TabIndex = 9;
            this.btnBiblio.Text = "Biblioteca";
            this.btnBiblio.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(2, 202);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(225, 56);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar Cancion";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCrearPlaylist
            // 
            this.btnCrearPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnCrearPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearPlaylist.FlatAppearance.BorderSize = 0;
            this.btnCrearPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCrearPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCrearPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPlaylist.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnCrearPlaylist.Location = new System.Drawing.Point(3, 263);
            this.btnCrearPlaylist.Name = "btnCrearPlaylist";
            this.btnCrearPlaylist.Size = new System.Drawing.Size(225, 56);
            this.btnCrearPlaylist.TabIndex = 11;
            this.btnCrearPlaylist.Text = "Crear Playlist";
            this.btnCrearPlaylist.UseVisualStyleBackColor = false;
            // 
            // btnverplaylist
            // 
            this.btnverplaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnverplaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnverplaylist.FlatAppearance.BorderSize = 0;
            this.btnverplaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnverplaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnverplaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverplaylist.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverplaylist.ForeColor = System.Drawing.Color.White;
            this.btnverplaylist.Location = new System.Drawing.Point(3, 325);
            this.btnverplaylist.Name = "btnverplaylist";
            this.btnverplaylist.Size = new System.Drawing.Size(225, 56);
            this.btnverplaylist.TabIndex = 12;
            this.btnverplaylist.Text = "Ver Playlists";
            this.btnverplaylist.UseVisualStyleBackColor = false;
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.Location = new System.Drawing.Point(2, 386);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(225, 56);
            this.btnHistorial.TabIndex = 13;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel2.Controls.Add(this.dvgCanciones);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(225, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 450);
            this.panel2.TabIndex = 4;
            // 
            // dvgCanciones
            // 
            this.dvgCanciones.AllowUserToResizeRows = false;
            this.dvgCanciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCanciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dvgCanciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgCanciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgCanciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCanciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dvgCanciones.ColumnHeadersHeight = 40;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgCanciones.DefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5);
            this.dvgCanciones.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dvgCanciones.RowTemplate.Height = 35;
            this.dvgCanciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCanciones.Size = new System.Drawing.Size(701, 450);
            this.dvgCanciones.TabIndex = 1;
            this.dvgCanciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCanciones_CellClick);
            this.dvgCanciones.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCanciones_CellMouseEnter);
            this.dvgCanciones.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCanciones_CellMouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel3.Controls.Add(this.panelHoy);
            this.panel3.Controls.Add(this.panelVol);
            this.panel3.Controls.Add(this.panelRep);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 450);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(926, 106);
            this.panel3.TabIndex = 5;
            // 
            // panelHoy
            // 
            this.panelHoy.BackColor = System.Drawing.Color.Transparent;
            this.panelHoy.Controls.Add(this.lblArtist);
            this.panelHoy.Controls.Add(this.lblName);
            this.panelHoy.Controls.Add(this.picAlbum);
            this.panelHoy.Location = new System.Drawing.Point(20, 3);
            this.panelHoy.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.panelHoy.Name = "panelHoy";
            this.panelHoy.Size = new System.Drawing.Size(141, 100);
            this.panelHoy.TabIndex = 19;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.ForeColor = System.Drawing.Color.Gray;
            this.lblArtist.Location = new System.Drawing.Point(86, 51);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(38, 15);
            this.lblArtist.TabIndex = 2;
            this.lblArtist.Text = "label2";
            this.lblArtist.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(86, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            this.lblName.Visible = false;
            // 
            // picAlbum
            // 
            this.picAlbum.Image = global::Reproductor_de_Musica.Properties.Resources.disco;
            this.picAlbum.Location = new System.Drawing.Point(5, 19);
            this.picAlbum.Name = "picAlbum";
            this.picAlbum.Size = new System.Drawing.Size(66, 66);
            this.picAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAlbum.TabIndex = 0;
            this.picAlbum.TabStop = false;
            this.picAlbum.Visible = false;
            // 
            // panelVol
            // 
            this.panelVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVol.Controls.Add(this.trkVolumen);
            this.panelVol.Controls.Add(this.lblVolumen);
            this.panelVol.Location = new System.Drawing.Point(790, 22);
            this.panelVol.Name = "panelVol";
            this.panelVol.Size = new System.Drawing.Size(120, 67);
            this.panelVol.TabIndex = 18;
            // 
            // trkVolumen
            // 
            this.trkVolumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trkVolumen.Location = new System.Drawing.Point(2, 21);
            this.trkVolumen.Margin = new System.Windows.Forms.Padding(2);
            this.trkVolumen.Name = "trkVolumen";
            this.trkVolumen.Size = new System.Drawing.Size(101, 45);
            this.trkVolumen.TabIndex = 15;
            this.trkVolumen.Scroll += new System.EventHandler(this.trkVolumen_Scroll);
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.ForeColor = System.Drawing.Color.White;
            this.lblVolumen.Location = new System.Drawing.Point(78, 2);
            this.lblVolumen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(35, 13);
            this.lblVolumen.TabIndex = 16;
            this.lblVolumen.Text = "label2";
            // 
            // panelRep
            // 
            this.panelRep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRep.BackColor = System.Drawing.Color.Transparent;
            this.panelRep.Controls.Add(this.lblTiempoActual);
            this.panelRep.Controls.Add(this.trackBarProgreso);
            this.panelRep.Controls.Add(this.btnAnterior);
            this.panelRep.Controls.Add(this.lblDuracion);
            this.panelRep.Controls.Add(this.btnSiguiente);
            this.panelRep.Controls.Add(this.btnPlayPause);
            this.panelRep.Location = new System.Drawing.Point(253, 5);
            this.panelRep.Name = "panelRep";
            this.panelRep.Size = new System.Drawing.Size(477, 100);
            this.panelRep.TabIndex = 17;
            // 
            // lblTiempoActual
            // 
            this.lblTiempoActual.AutoSize = true;
            this.lblTiempoActual.ForeColor = System.Drawing.Color.White;
            this.lblTiempoActual.Location = new System.Drawing.Point(2, 47);
            this.lblTiempoActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiempoActual.Name = "lblTiempoActual";
            this.lblTiempoActual.Size = new System.Drawing.Size(35, 13);
            this.lblTiempoActual.TabIndex = 10;
            this.lblTiempoActual.Text = "label1";
            // 
            // trackBarProgreso
            // 
            this.trackBarProgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.trackBarProgreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarProgreso.Location = new System.Drawing.Point(41, 47);
            this.trackBarProgreso.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarProgreso.Name = "trackBarProgreso";
            this.trackBarProgreso.Size = new System.Drawing.Size(395, 45);
            this.trackBarProgreso.TabIndex = 5;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.btnAnterior.BackgroundImage = global::Reproductor_de_Musica.Properties.Resources.ant;
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.btnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(166, 5);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(40, 40);
            this.btnAnterior.TabIndex = 14;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.ForeColor = System.Drawing.Color.White;
            this.lblDuracion.Location = new System.Drawing.Point(440, 47);
            this.lblDuracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(35, 13);
            this.lblDuracion.TabIndex = 11;
            this.lblDuracion.Text = "label2";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.BackgroundImage = global::Reproductor_de_Musica.Properties.Resources.sig;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.btnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(271, 5);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(0);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(40, 40);
            this.btnSiguiente.TabIndex = 13;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.BackgroundImage = global::Reproductor_de_Musica.Properties.Resources.play;
            this.btnPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayPause.FlatAppearance.BorderSize = 0;
            this.btnPlayPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.btnPlayPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.btnPlayPause.Location = new System.Drawing.Point(219, 7);
            this.btnPlayPause.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(40, 38);
            this.btnPlayPause.TabIndex = 12;
            this.btnPlayPause.Text = " ";
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(926, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Reproductor de Musica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.psubmenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCanciones)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelHoy.ResumeLayout(false);
            this.panelHoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).EndInit();
            this.panelVol.ResumeLayout(false);
            this.panelVol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolumen)).EndInit();
            this.panelRep.ResumeLayout(false);
            this.panelRep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgreso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerProgreso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dvgCanciones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.TrackBar trkVolumen;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblTiempoActual;
        private System.Windows.Forms.TrackBar trackBarProgreso;
        private Button btnBiblio;
        private Button btnrayitas;
        private Button btnHistorial;
        private Button btnverplaylist;
        private Button btnCrearPlaylist;
        private Button btnAgregar;
        private Panel psubmenu;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnInfo;
        private Button btnSalir;
        private Panel panelRep;
        private Panel panelVol;
        private Panel panelHoy;
        private PictureBox picAlbum;
        private Label lblArtist;
        private Label lblName;
    }
}

