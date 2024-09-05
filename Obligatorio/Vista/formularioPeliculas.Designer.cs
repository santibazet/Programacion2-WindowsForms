namespace Obligatorio
{
    partial class formularioPeliculas
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
            this.btnEliminarPeliculas = new System.Windows.Forms.Button();
            this.btnEditarPeliculas = new System.Windows.Forms.Button();
            this.btnGuardarPeliculas = new System.Windows.Forms.Button();
            this.txtDuracionPeliculas = new System.Windows.Forms.TextBox();
            this.txtFechaEstrenoPeliculas = new System.Windows.Forms.TextBox();
            this.dgvTablaPeliculas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGeneroPeliculas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTituloPeliculas = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarPeliculas
            // 
            this.btnEliminarPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPeliculas.Location = new System.Drawing.Point(485, 278);
            this.btnEliminarPeliculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarPeliculas.Name = "btnEliminarPeliculas";
            this.btnEliminarPeliculas.Size = new System.Drawing.Size(105, 32);
            this.btnEliminarPeliculas.TabIndex = 6;
            this.btnEliminarPeliculas.Text = "Eliminar";
            this.btnEliminarPeliculas.UseVisualStyleBackColor = true;
            this.btnEliminarPeliculas.Click += new System.EventHandler(this.btnEliminarPeliculas_Click);
            // 
            // btnEditarPeliculas
            // 
            this.btnEditarPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPeliculas.Location = new System.Drawing.Point(374, 278);
            this.btnEditarPeliculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarPeliculas.Name = "btnEditarPeliculas";
            this.btnEditarPeliculas.Size = new System.Drawing.Size(105, 32);
            this.btnEditarPeliculas.TabIndex = 5;
            this.btnEditarPeliculas.Text = "Editar";
            this.btnEditarPeliculas.UseVisualStyleBackColor = true;
            this.btnEditarPeliculas.Click += new System.EventHandler(this.btnEditarPeliculas_Click);
            // 
            // btnGuardarPeliculas
            // 
            this.btnGuardarPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPeliculas.Location = new System.Drawing.Point(322, 226);
            this.btnGuardarPeliculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarPeliculas.Name = "btnGuardarPeliculas";
            this.btnGuardarPeliculas.Size = new System.Drawing.Size(421, 46);
            this.btnGuardarPeliculas.TabIndex = 4;
            this.btnGuardarPeliculas.Text = "Guardar";
            this.btnGuardarPeliculas.UseVisualStyleBackColor = true;
            this.btnGuardarPeliculas.Click += new System.EventHandler(this.btnGuardarPeliculas_Click);
            // 
            // txtDuracionPeliculas
            // 
            this.txtDuracionPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracionPeliculas.Location = new System.Drawing.Point(221, 161);
            this.txtDuracionPeliculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDuracionPeliculas.Name = "txtDuracionPeliculas";
            this.txtDuracionPeliculas.Size = new System.Drawing.Size(207, 28);
            this.txtDuracionPeliculas.TabIndex = 2;
            // 
            // txtFechaEstrenoPeliculas
            // 
            this.txtFechaEstrenoPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaEstrenoPeliculas.Location = new System.Drawing.Point(615, 93);
            this.txtFechaEstrenoPeliculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFechaEstrenoPeliculas.Name = "txtFechaEstrenoPeliculas";
            this.txtFechaEstrenoPeliculas.Size = new System.Drawing.Size(207, 28);
            this.txtFechaEstrenoPeliculas.TabIndex = 1;
            // 
            // dgvTablaPeliculas
            // 
            this.dgvTablaPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaPeliculas.Location = new System.Drawing.Point(169, 325);
            this.dgvTablaPeliculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTablaPeliculas.Name = "dgvTablaPeliculas";
            this.dgvTablaPeliculas.ReadOnly = true;
            this.dgvTablaPeliculas.RowHeadersWidth = 51;
            this.dgvTablaPeliculas.RowTemplate.Height = 24;
            this.dgvTablaPeliculas.Size = new System.Drawing.Size(726, 201);
            this.dgvTablaPeliculas.TabIndex = 8;
            this.dgvTablaPeliculas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTablaPeliculas_RowHeaderMouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(403, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 36);
            this.label6.TabIndex = 51;
            this.label6.Text = "Gestión de películas";
            // 
            // cmbGeneroPeliculas
            // 
            this.cmbGeneroPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGeneroPeliculas.FormattingEnabled = true;
            this.cmbGeneroPeliculas.Items.AddRange(new object[] {
            "Terror",
            "Accion",
            "Aventura",
            "Fantasia",
            "Ciencia Ficcion",
            "Drama",
            "Comedia",
            "Suspenso"});
            this.cmbGeneroPeliculas.Location = new System.Drawing.Point(615, 159);
            this.cmbGeneroPeliculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGeneroPeliculas.Name = "cmbGeneroPeliculas";
            this.cmbGeneroPeliculas.Size = new System.Drawing.Size(207, 30);
            this.cmbGeneroPeliculas.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 22);
            this.label5.TabIndex = 49;
            this.label5.Text = "Duración en minutos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(691, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "Género";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(625, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 22);
            this.label3.TabIndex = 47;
            this.label3.Text = "Año de estreno (AAAA)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "Título";
            // 
            // txtTituloPeliculas
            // 
            this.txtTituloPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloPeliculas.Location = new System.Drawing.Point(221, 93);
            this.txtTituloPeliculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTituloPeliculas.Name = "txtTituloPeliculas";
            this.txtTituloPeliculas.Size = new System.Drawing.Size(207, 28);
            this.txtTituloPeliculas.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 13);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(105, 32);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(597, 278);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 32);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // formularioPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 546);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminarPeliculas);
            this.Controls.Add(this.btnEditarPeliculas);
            this.Controls.Add(this.btnGuardarPeliculas);
            this.Controls.Add(this.txtDuracionPeliculas);
            this.Controls.Add(this.txtFechaEstrenoPeliculas);
            this.Controls.Add(this.dgvTablaPeliculas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbGeneroPeliculas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTituloPeliculas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formularioPeliculas";
            this.Text = "Gestión de películas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarPeliculas;
        private System.Windows.Forms.Button btnEditarPeliculas;
        private System.Windows.Forms.Button btnGuardarPeliculas;
        private System.Windows.Forms.TextBox txtDuracionPeliculas;
        private System.Windows.Forms.TextBox txtFechaEstrenoPeliculas;
        private System.Windows.Forms.DataGridView dgvTablaPeliculas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbGeneroPeliculas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTituloPeliculas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLimpiar;
    }
}