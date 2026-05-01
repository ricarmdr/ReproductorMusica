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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblTiempoActual = new System.Windows.Forms.Label();
            this.trackBarProgreso = new System.Windows.Forms.TrackBar();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dvgCanciones = new System.Windows.Forms.DataGridView();
            this.timerProgreso = new System.Windows.Forms.Timer(this.components);
            this.trkVolumen = new System.Windows.Forms.TrackBar();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgreso)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCanciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolumen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVolumen);
            this.groupBox1.Controls.Add(this.trkVolumen);
            this.groupBox1.Controls.Add(this.btnHistorial);
            this.groupBox1.Controls.Add(this.lblDuracion);
            this.groupBox1.Controls.Add(this.btnSiguiente);
            this.groupBox1.Controls.Add(this.lblTiempoActual);
            this.groupBox1.Controls.Add(this.trackBarProgreso);
            this.groupBox1.Controls.Add(this.btnPlayPause);
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Location = new System.Drawing.Point(6, 543);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1130, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reproductor ";
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(12, 100);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(142, 44);
            this.btnHistorial.TabIndex = 1;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(881, 38);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(44, 16);
            this.lblDuracion.TabIndex = 6;
            this.lblDuracion.Text = "label2";
            // 
            // lblTiempoActual
            // 
            this.lblTiempoActual.AutoSize = true;
            this.lblTiempoActual.Location = new System.Drawing.Point(246, 38);
            this.lblTiempoActual.Name = "lblTiempoActual";
            this.lblTiempoActual.Size = new System.Drawing.Size(44, 16);
            this.lblTiempoActual.TabIndex = 5;
            this.lblTiempoActual.Text = "label1";
            // 
            // trackBarProgreso
            // 
            this.trackBarProgreso.Location = new System.Drawing.Point(305, 36);
            this.trackBarProgreso.Name = "trackBarProgreso";
            this.trackBarProgreso.Size = new System.Drawing.Size(570, 56);
            this.trackBarProgreso.TabIndex = 4;
            this.trackBarProgreso.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(483, 98);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(213, 46);
            this.btnPlayPause.TabIndex = 2;
            this.btnPlayPause.Text = "▶ Reproducir";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(323, 98);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(131, 44);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(734, 99);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(131, 44);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 531);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 21);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 44);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Cancion";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dvgCanciones);
            this.groupBox3.Location = new System.Drawing.Point(329, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(807, 525);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Playlist Actual";
            // 
            // dvgCanciones
            // 
            this.dvgCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCanciones.Location = new System.Drawing.Point(222, 21);
            this.dvgCanciones.Name = "dvgCanciones";
            this.dvgCanciones.RowHeadersWidth = 51;
            this.dvgCanciones.RowTemplate.Height = 24;
            this.dvgCanciones.Size = new System.Drawing.Size(563, 485);
            this.dvgCanciones.TabIndex = 0;
            this.dvgCanciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCanciones_CellContentClick);
            // 
            // timerProgreso
            // 
            this.timerProgreso.Tick += new System.EventHandler(this.timerProgreso_Tick);
            // 
            // trkVolumen
            // 
            this.trkVolumen.Location = new System.Drawing.Point(923, 96);
            this.trkVolumen.Name = "trkVolumen";
            this.trkVolumen.Size = new System.Drawing.Size(135, 56);
            this.trkVolumen.TabIndex = 7;
            this.trkVolumen.Scroll += new System.EventHandler(this.trkVolumen_Scroll);
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(1064, 99);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(44, 16);
            this.lblVolumen.TabIndex = 8;
            this.lblVolumen.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1160, 707);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Reproductor de Musica";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgreso)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCanciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolumen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dvgCanciones;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.TrackBar trackBarProgreso;
        private System.Windows.Forms.Timer timerProgreso;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblTiempoActual;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.TrackBar trkVolumen;
    }
}

