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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dvgCanciones = new System.Windows.Forms.DataGridView();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSiguiente);
            this.groupBox1.Controls.Add(this.btnReproducir);
            this.groupBox1.Controls.Add(this.btnPausar);
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Location = new System.Drawing.Point(5, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reproductor ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHistorial);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 338);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(6, 85);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(142, 44);
            this.btnHistorial.TabIndex = 1;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 21);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 44);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dvgCanciones);
            this.groupBox3.Location = new System.Drawing.Point(166, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 338);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Biblioteca musical";
            // 
            // dvgCanciones
            // 
            this.dvgCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCanciones.Location = new System.Drawing.Point(15, 24);
            this.dvgCanciones.Name = "dvgCanciones";
            this.dvgCanciones.RowHeadersWidth = 51;
            this.dvgCanciones.RowTemplate.Height = 24;
            this.dvgCanciones.Size = new System.Drawing.Size(511, 296);
            this.dvgCanciones.TabIndex = 0;
            this.dvgCanciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCanciones_CellContentClick);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(34, 34);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(131, 44);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(202, 34);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(131, 44);
            this.btnPausar.TabIndex = 1;
            this.btnPausar.Text = "Pausa";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnReproducir
            // 
            this.btnReproducir.Location = new System.Drawing.Point(382, 34);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(131, 44);
            this.btnReproducir.TabIndex = 2;
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.UseVisualStyleBackColor = true;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(556, 34);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(131, 44);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Reproductor de Musica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCanciones)).EndInit();
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
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.Button btnPausar;
    }
}

