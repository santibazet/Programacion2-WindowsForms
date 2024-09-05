namespace Obligatorio
{
    partial class formularioActores
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
            this.btnEliminarActores = new System.Windows.Forms.Button();
            this.btnEditarActores = new System.Windows.Forms.Button();
            this.btnGuardarActores = new System.Windows.Forms.Button();
            this.txtFechaNacimientoActores = new System.Windows.Forms.TextBox();
            this.txtApellidoActores = new System.Windows.Forms.TextBox();
            this.dgvTablaActores = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreActores = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtNacionalidadActores = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaActores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarActores
            // 
            this.btnEliminarActores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarActores.Location = new System.Drawing.Point(502, 288);
            this.btnEliminarActores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarActores.Name = "btnEliminarActores";
            this.btnEliminarActores.Size = new System.Drawing.Size(105, 32);
            this.btnEliminarActores.TabIndex = 6;
            this.btnEliminarActores.Text = "Eliminar";
            this.btnEliminarActores.UseVisualStyleBackColor = true;
            this.btnEliminarActores.Click += new System.EventHandler(this.btnEliminarActores_Click);
            // 
            // btnEditarActores
            // 
            this.btnEditarActores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarActores.Location = new System.Drawing.Point(391, 288);
            this.btnEditarActores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarActores.Name = "btnEditarActores";
            this.btnEditarActores.Size = new System.Drawing.Size(105, 32);
            this.btnEditarActores.TabIndex = 5;
            this.btnEditarActores.Text = "Editar";
            this.btnEditarActores.UseVisualStyleBackColor = true;
            this.btnEditarActores.Click += new System.EventHandler(this.btnEditarActores_Click);
            // 
            // btnGuardarActores
            // 
            this.btnGuardarActores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarActores.Location = new System.Drawing.Point(323, 235);
            this.btnGuardarActores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarActores.Name = "btnGuardarActores";
            this.btnGuardarActores.Size = new System.Drawing.Size(464, 46);
            this.btnGuardarActores.TabIndex = 4;
            this.btnGuardarActores.Text = "Guardar";
            this.btnGuardarActores.UseVisualStyleBackColor = true;
            this.btnGuardarActores.Click += new System.EventHandler(this.btnGuardarActores_Click);
            // 
            // txtFechaNacimientoActores
            // 
            this.txtFechaNacimientoActores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimientoActores.Location = new System.Drawing.Point(225, 179);
            this.txtFechaNacimientoActores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFechaNacimientoActores.Name = "txtFechaNacimientoActores";
            this.txtFechaNacimientoActores.Size = new System.Drawing.Size(207, 28);
            this.txtFechaNacimientoActores.TabIndex = 2;
            // 
            // txtApellidoActores
            // 
            this.txtApellidoActores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoActores.Location = new System.Drawing.Point(619, 93);
            this.txtApellidoActores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoActores.Name = "txtApellidoActores";
            this.txtApellidoActores.Size = new System.Drawing.Size(207, 28);
            this.txtApellidoActores.TabIndex = 1;
            // 
            // dgvTablaActores
            // 
            this.dgvTablaActores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaActores.Location = new System.Drawing.Point(172, 334);
            this.dgvTablaActores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTablaActores.Name = "dgvTablaActores";
            this.dgvTablaActores.ReadOnly = true;
            this.dgvTablaActores.RowHeadersWidth = 51;
            this.dgvTablaActores.RowTemplate.Height = 24;
            this.dgvTablaActores.Size = new System.Drawing.Size(726, 201);
            this.dgvTablaActores.TabIndex = 8;
            this.dgvTablaActores.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTablaActores_RowHeaderMouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(404, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 36);
            this.label6.TabIndex = 23;
            this.label6.Text = "Gestión de actores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha de nacimiento (DD/MM/AAAA)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(665, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nacionalidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(687, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // txtNombreActores
            // 
            this.txtNombreActores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreActores.Location = new System.Drawing.Point(225, 93);
            this.txtNombreActores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreActores.Name = "txtNombreActores";
            this.txtNombreActores.Size = new System.Drawing.Size(207, 28);
            this.txtNombreActores.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1043, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtNacionalidadActores
            // 
            this.txtNacionalidadActores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidadActores.Location = new System.Drawing.Point(619, 179);
            this.txtNacionalidadActores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNacionalidadActores.Name = "txtNacionalidadActores";
            this.txtNacionalidadActores.Size = new System.Drawing.Size(207, 28);
            this.txtNacionalidadActores.TabIndex = 3;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(13, 13);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnLimpiar.Location = new System.Drawing.Point(614, 288);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 32);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // formularioActores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 546);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtNacionalidadActores);
            this.Controls.Add(this.btnEliminarActores);
            this.Controls.Add(this.btnEditarActores);
            this.Controls.Add(this.btnGuardarActores);
            this.Controls.Add(this.txtFechaNacimientoActores);
            this.Controls.Add(this.txtApellidoActores);
            this.Controls.Add(this.dgvTablaActores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreActores);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formularioActores";
            this.Text = "Gestión de actores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaActores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarActores;
        private System.Windows.Forms.Button btnEditarActores;
        private System.Windows.Forms.Button btnGuardarActores;
        private System.Windows.Forms.TextBox txtFechaNacimientoActores;
        private System.Windows.Forms.TextBox txtApellidoActores;
        private System.Windows.Forms.DataGridView dgvTablaActores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreActores;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtNacionalidadActores;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLimpiar;
    }
}