namespace Obligatorio
{
    partial class formularioActoresEnPeliculas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectorActor = new System.Windows.Forms.Label();
            this.txtSelectorPelicula = new System.Windows.Forms.Label();
            this.btnCerrarActoresEnPeliculas = new System.Windows.Forms.Button();
            this.dgvSelectorActor = new System.Windows.Forms.DataGridView();
            this.dgvSelectorPelicula = new System.Windows.Forms.DataGridView();
            this.txtMuestraActor = new System.Windows.Forms.TextBox();
            this.txtMuestraPelicula = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtIDActor = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDPelicula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectorActor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectorPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar actor a una película";
            // 
            // txtSelectorActor
            // 
            this.txtSelectorActor.AutoSize = true;
            this.txtSelectorActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectorActor.Location = new System.Drawing.Point(157, 63);
            this.txtSelectorActor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSelectorActor.Name = "txtSelectorActor";
            this.txtSelectorActor.Size = new System.Drawing.Size(166, 25);
            this.txtSelectorActor.TabIndex = 2;
            this.txtSelectorActor.Text = "Seleccionar Actor";
            // 
            // txtSelectorPelicula
            // 
            this.txtSelectorPelicula.AutoSize = true;
            this.txtSelectorPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectorPelicula.Location = new System.Drawing.Point(715, 63);
            this.txtSelectorPelicula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSelectorPelicula.Name = "txtSelectorPelicula";
            this.txtSelectorPelicula.Size = new System.Drawing.Size(188, 25);
            this.txtSelectorPelicula.TabIndex = 4;
            this.txtSelectorPelicula.Text = "Seleccionar Película";
            // 
            // btnCerrarActoresEnPeliculas
            // 
            this.btnCerrarActoresEnPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarActoresEnPeliculas.Location = new System.Drawing.Point(13, 13);
            this.btnCerrarActoresEnPeliculas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarActoresEnPeliculas.Name = "btnCerrarActoresEnPeliculas";
            this.btnCerrarActoresEnPeliculas.Size = new System.Drawing.Size(105, 32);
            this.btnCerrarActoresEnPeliculas.TabIndex = 3;
            this.btnCerrarActoresEnPeliculas.Text = "Volver";
            this.btnCerrarActoresEnPeliculas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrarActoresEnPeliculas.UseVisualStyleBackColor = true;
            this.btnCerrarActoresEnPeliculas.Click += new System.EventHandler(this.btnCerrarActoresEnPeliculas_Click);
            // 
            // dgvSelectorActor
            // 
            this.dgvSelectorActor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectorActor.Location = new System.Drawing.Point(27, 106);
            this.dgvSelectorActor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSelectorActor.Name = "dgvSelectorActor";
            this.dgvSelectorActor.RowHeadersWidth = 51;
            this.dgvSelectorActor.RowTemplate.Height = 24;
            this.dgvSelectorActor.Size = new System.Drawing.Size(440, 266);
            this.dgvSelectorActor.TabIndex = 0;
            this.dgvSelectorActor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectorActor_CellClick);
            // 
            // dgvSelectorPelicula
            // 
            this.dgvSelectorPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectorPelicula.Location = new System.Drawing.Point(579, 106);
            this.dgvSelectorPelicula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSelectorPelicula.Name = "dgvSelectorPelicula";
            this.dgvSelectorPelicula.RowHeadersWidth = 51;
            this.dgvSelectorPelicula.RowTemplate.Height = 24;
            this.dgvSelectorPelicula.Size = new System.Drawing.Size(440, 266);
            this.dgvSelectorPelicula.TabIndex = 1;
            this.dgvSelectorPelicula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectorPelicula_CellClick);
            // 
            // txtMuestraActor
            // 
            this.txtMuestraActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMuestraActor.Location = new System.Drawing.Point(109, 421);
            this.txtMuestraActor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMuestraActor.Name = "txtMuestraActor";
            this.txtMuestraActor.Size = new System.Drawing.Size(336, 30);
            this.txtMuestraActor.TabIndex = 8;
            // 
            // txtMuestraPelicula
            // 
            this.txtMuestraPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMuestraPelicula.Location = new System.Drawing.Point(651, 423);
            this.txtMuestraPelicula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMuestraPelicula.Name = "txtMuestraPelicula";
            this.txtMuestraPelicula.Size = new System.Drawing.Size(335, 30);
            this.txtMuestraPelicula.TabIndex = 9;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(464, 497);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(122, 38);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtIDActor
            // 
            this.txtIDActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDActor.Location = new System.Drawing.Point(109, 382);
            this.txtIDActor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDActor.Name = "txtIDActor";
            this.txtIDActor.Size = new System.Drawing.Size(49, 30);
            this.txtIDActor.TabIndex = 11;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(72, 385);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(37, 25);
            this.lbID.TabIndex = 12;
            this.lbID.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(606, 395);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID:";
            // 
            // txtIDPelicula
            // 
            this.txtIDPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPelicula.Location = new System.Drawing.Point(651, 387);
            this.txtIDPelicula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDPelicula.Name = "txtIDPelicula";
            this.txtIDPelicula.Size = new System.Drawing.Size(49, 30);
            this.txtIDPelicula.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(578, 426);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Título:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 426);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre:";
            // 
            // formularioActoresEnPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 546);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDPelicula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txtIDActor);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtMuestraPelicula);
            this.Controls.Add(this.txtMuestraActor);
            this.Controls.Add(this.dgvSelectorPelicula);
            this.Controls.Add(this.dgvSelectorActor);
            this.Controls.Add(this.btnCerrarActoresEnPeliculas);
            this.Controls.Add(this.txtSelectorPelicula);
            this.Controls.Add(this.txtSelectorActor);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formularioActoresEnPeliculas";
            this.Text = "Asignar un actor a una película";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectorActor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectorPelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtSelectorActor;
        private System.Windows.Forms.Label txtSelectorPelicula;
        private System.Windows.Forms.Button btnCerrarActoresEnPeliculas;
        private System.Windows.Forms.DataGridView dgvSelectorActor;
        private System.Windows.Forms.DataGridView dgvSelectorPelicula;
        private System.Windows.Forms.TextBox txtMuestraActor;
        private System.Windows.Forms.TextBox txtMuestraPelicula;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtIDActor;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDPelicula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}