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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgCanciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCanciones)).BeginInit();
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
            this.dvgCanciones.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCanciones_CellMouseEnter);
            this.dvgCanciones.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCanciones_CellMouseLeave);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCanciones;
    }
}
