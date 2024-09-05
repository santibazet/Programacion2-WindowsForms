namespace Obligatorio
{
    partial class formularioFiltradoPeliculas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbGenero = new System.Windows.Forms.RadioButton();
            this.rbAnio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.btnVolverFiltradoPeliculas = new System.Windows.Forms.Button();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.cbFiltradoActivo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroResultado = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // rbGenero
            // 
            this.rbGenero.AutoSize = true;
            this.rbGenero.Enabled = false;
            this.rbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGenero.Location = new System.Drawing.Point(393, 116);
            this.rbGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbGenero.Name = "rbGenero";
            this.rbGenero.Size = new System.Drawing.Size(98, 29);
            this.rbGenero.TabIndex = 2;
            this.rbGenero.Text = "Genero";
            this.rbGenero.UseVisualStyleBackColor = true;
            this.rbGenero.CheckedChanged += new System.EventHandler(this.rbGenero_CheckedChanged);
            this.rbGenero.EnabledChanged += new System.EventHandler(this.rbGenero_CheckedChanged);
            this.rbGenero.Click += new System.EventHandler(this.rbGenero_CheckedChanged);
            this.rbGenero.MouseCaptureChanged += new System.EventHandler(this.rbGenero_CheckedChanged);
            // 
            // rbAnio
            // 
            this.rbAnio.AutoSize = true;
            this.rbAnio.Enabled = false;
            this.rbAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnio.Location = new System.Drawing.Point(393, 157);
            this.rbAnio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAnio.Name = "rbAnio";
            this.rbAnio.Size = new System.Drawing.Size(69, 29);
            this.rbAnio.TabIndex = 4;
            this.rbAnio.Text = "Año";
            this.rbAnio.UseVisualStyleBackColor = true;
            this.rbAnio.CheckedChanged += new System.EventHandler(this.rbAnio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Películas";
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Location = new System.Drawing.Point(157, 254);
            this.dgvPeliculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.RowHeadersWidth = 51;
            this.dgvPeliculas.RowTemplate.Height = 24;
            this.dgvPeliculas.Size = new System.Drawing.Size(730, 281);
            this.dgvPeliculas.TabIndex = 6;
            // 
            // btnVolverFiltradoPeliculas
            // 
            this.btnVolverFiltradoPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverFiltradoPeliculas.Location = new System.Drawing.Point(12, 11);
            this.btnVolverFiltradoPeliculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolverFiltradoPeliculas.Name = "btnVolverFiltradoPeliculas";
            this.btnVolverFiltradoPeliculas.Size = new System.Drawing.Size(105, 32);
            this.btnVolverFiltradoPeliculas.TabIndex = 7;
            this.btnVolverFiltradoPeliculas.Text = "Volver";
            this.btnVolverFiltradoPeliculas.UseVisualStyleBackColor = true;
            this.btnVolverFiltradoPeliculas.Click += new System.EventHandler(this.btnVolverFiltradoPeliculas_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.Enabled = false;
            this.cmbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Todos",
            "Terror",
            "Accion",
            "Aventura",
            "Fantasia",
            "Ciencia Ficcion",
            "Drama",
            "Comedia",
            "Suspenso"});
            this.cmbGenero.Location = new System.Drawing.Point(506, 116);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(160, 33);
            this.cmbGenero.TabIndex = 3;
            this.cmbGenero.Text = "Todos";
            this.cmbGenero.SelectedIndexChanged += new System.EventHandler(this.cmbGenero_SelectedIndexChanged);
            // 
            // txtAnio
            // 
            this.txtAnio.Enabled = false;
            this.txtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.Location = new System.Drawing.Point(506, 157);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(160, 30);
            this.txtAnio.TabIndex = 5;
            this.txtAnio.TextChanged += new System.EventHandler(this.rbAnio_CheckedChanged);
            // 
            // cbFiltradoActivo
            // 
            this.cbFiltradoActivo.AutoSize = true;
            this.cbFiltradoActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltradoActivo.Location = new System.Drawing.Point(491, 70);
            this.cbFiltradoActivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFiltradoActivo.Name = "cbFiltradoActivo";
            this.cbFiltradoActivo.Size = new System.Drawing.Size(82, 29);
            this.cbFiltradoActivo.TabIndex = 1;
            this.cbFiltradoActivo.Text = "Filtrar";
            this.cbFiltradoActivo.UseVisualStyleBackColor = true;
            this.cbFiltradoActivo.CheckedChanged += new System.EventHandler(this.cbFiltradoActivo_CheckedChanged);
            this.cbFiltradoActivo.CheckStateChanged += new System.EventHandler(this.cbFiltradoActivo_CheckedChanged);
            this.cbFiltradoActivo.Click += new System.EventHandler(this.cbFiltradoActivo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Resultados obtenidos:";
            // 
            // txtNumeroResultado
            // 
            this.txtNumeroResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroResultado.Location = new System.Drawing.Point(835, 216);
            this.txtNumeroResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroResultado.Name = "txtNumeroResultado";
            this.txtNumeroResultado.Size = new System.Drawing.Size(52, 28);
            this.txtNumeroResultado.TabIndex = 10;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(402, 11);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(281, 36);
            this.lbTitulo.TabIndex = 11;
            this.lbTitulo.Text = "Filtrado de películas";
            // 
            // formularioFiltradoPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 546);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.txtNumeroResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFiltradoActivo);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.btnVolverFiltradoPeliculas);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbAnio);
            this.Controls.Add(this.rbGenero);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formularioFiltradoPeliculas";
            this.Text = "Filtar películas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbGenero;
        private System.Windows.Forms.RadioButton rbAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.Button btnVolverFiltradoPeliculas;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.CheckBox cbFiltradoActivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroResultado;
        private System.Windows.Forms.Label lbTitulo;
    }
}