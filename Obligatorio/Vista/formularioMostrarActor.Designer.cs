namespace Obligatorio
{
    partial class formularioMostrarActor
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.dgvActores = new System.Windows.Forms.DataGridView();
            this.lbActor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActores)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(387, 28);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(345, 36);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Actuaciones en películas";
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Location = new System.Drawing.Point(151, 348);
            this.dgvPeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.RowHeadersWidth = 51;
            this.dgvPeliculas.Size = new System.Drawing.Size(733, 185);
            this.dgvPeliculas.TabIndex = 1;
            // 
            // dgvActores
            // 
            this.dgvActores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActores.Location = new System.Drawing.Point(151, 113);
            this.dgvActores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvActores.Name = "dgvActores";
            this.dgvActores.RowHeadersWidth = 51;
            this.dgvActores.Size = new System.Drawing.Size(733, 185);
            this.dgvActores.TabIndex = 0;
            this.dgvActores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActores_CellClick);
            // 
            // lbActor
            // 
            this.lbActor.AutoSize = true;
            this.lbActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActor.Location = new System.Drawing.Point(146, 84);
            this.lbActor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbActor.Name = "lbActor";
            this.lbActor.Size = new System.Drawing.Size(85, 25);
            this.lbActor.TabIndex = 3;
            this.lbActor.Text = "Actores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 320);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Peliculas donde ha actuado:";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(13, 13);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(105, 32);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // formularioMostrarActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 546);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbActor);
            this.Controls.Add(this.dgvActores);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.lbTitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formularioMostrarActor";
            this.Text = "Peliculas vinculadas a un actor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.DataGridView dgvActores;
        private System.Windows.Forms.Label lbActor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolver;
    }
}