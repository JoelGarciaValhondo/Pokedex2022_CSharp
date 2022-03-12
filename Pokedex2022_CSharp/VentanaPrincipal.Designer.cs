namespace Pokedex2022_CSharp
{
    partial class VentanaPrincipal
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
            this.izquierda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.derecha = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.alturaPokemon = new System.Windows.Forms.Label();
            this.pesoPokemon = new System.Windows.Forms.Label();
            this.tipo1 = new System.Windows.Forms.Label();
            this.tipo2 = new System.Windows.Forms.Label();
            this.especiePokemon = new System.Windows.Forms.Label();
            this.habitatPokemon = new System.Windows.Forms.Label();
            this.movimiento1 = new System.Windows.Forms.Label();
            this.movimiento2 = new System.Windows.Forms.Label();
            this.movimiento3 = new System.Windows.Forms.Label();
            this.movimiento4 = new System.Windows.Forms.Label();
            this.habilidadPokemon = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // izquierda
            // 
            this.izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izquierda.Location = new System.Drawing.Point(40, 413);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(116, 70);
            this.izquierda.TabIndex = 0;
            this.izquierda.Text = "<";
            this.izquierda.UseVisualStyleBackColor = true;
            this.izquierda.Click += new System.EventHandler(this.izquierda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 326);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // derecha
            // 
            this.derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.derecha.Location = new System.Drawing.Point(186, 413);
            this.derecha.Name = "derecha";
            this.derecha.Size = new System.Drawing.Size(116, 70);
            this.derecha.TabIndex = 2;
            this.derecha.Text = ">";
            this.derecha.UseVisualStyleBackColor = true;
            this.derecha.Click += new System.EventHandler(this.derecha_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.Location = new System.Drawing.Point(365, 45);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(189, 48);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.Text = "Pokemon";
            this.nombrePokemon.Click += new System.EventHandler(this.label1_Click);
            // 
            // alturaPokemon
            // 
            this.alturaPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturaPokemon.Location = new System.Drawing.Point(348, 118);
            this.alturaPokemon.Name = "alturaPokemon";
            this.alturaPokemon.Size = new System.Drawing.Size(54, 48);
            this.alturaPokemon.TabIndex = 4;
            this.alturaPokemon.Text = "Altura";
            // 
            // pesoPokemon
            // 
            this.pesoPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoPokemon.Location = new System.Drawing.Point(463, 118);
            this.pesoPokemon.Name = "pesoPokemon";
            this.pesoPokemon.Size = new System.Drawing.Size(50, 48);
            this.pesoPokemon.TabIndex = 5;
            this.pesoPokemon.Text = "Peso";
            this.pesoPokemon.Click += new System.EventHandler(this.pesoPokemon_Click);
            // 
            // tipo1
            // 
            this.tipo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo1.Location = new System.Drawing.Point(348, 180);
            this.tipo1.Name = "tipo1";
            this.tipo1.Size = new System.Drawing.Size(125, 48);
            this.tipo1.TabIndex = 6;
            this.tipo1.Text = "Tipo1";
            this.tipo1.Click += new System.EventHandler(this.tipo1_Click);
            // 
            // tipo2
            // 
            this.tipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo2.Location = new System.Drawing.Point(492, 180);
            this.tipo2.Name = "tipo2";
            this.tipo2.Size = new System.Drawing.Size(97, 48);
            this.tipo2.TabIndex = 7;
            this.tipo2.Text = "Tipo2";
            this.tipo2.Click += new System.EventHandler(this.tipo2_Click);
            // 
            // especiePokemon
            // 
            this.especiePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especiePokemon.Location = new System.Drawing.Point(348, 244);
            this.especiePokemon.Name = "especiePokemon";
            this.especiePokemon.Size = new System.Drawing.Size(91, 48);
            this.especiePokemon.TabIndex = 8;
            this.especiePokemon.Text = "Especie";
            this.especiePokemon.Click += new System.EventHandler(this.especiePokemon_Click);
            // 
            // habitatPokemon
            // 
            this.habitatPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitatPokemon.Location = new System.Drawing.Point(477, 244);
            this.habitatPokemon.Name = "habitatPokemon";
            this.habitatPokemon.Size = new System.Drawing.Size(97, 48);
            this.habitatPokemon.TabIndex = 9;
            this.habitatPokemon.Text = "Habitat";
            this.habitatPokemon.Click += new System.EventHandler(this.habitatPokemon_Click);
            // 
            // movimiento1
            // 
            this.movimiento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento1.Location = new System.Drawing.Point(325, 413);
            this.movimiento1.Name = "movimiento1";
            this.movimiento1.Size = new System.Drawing.Size(132, 48);
            this.movimiento1.TabIndex = 10;
            this.movimiento1.Text = "Movimiento1";
            this.movimiento1.Click += new System.EventHandler(this.movimiento1_Click);
            // 
            // movimiento2
            // 
            this.movimiento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento2.Location = new System.Drawing.Point(463, 413);
            this.movimiento2.Name = "movimiento2";
            this.movimiento2.Size = new System.Drawing.Size(126, 48);
            this.movimiento2.TabIndex = 11;
            this.movimiento2.Text = "Movimiento2";
            this.movimiento2.Click += new System.EventHandler(this.movimiento2_Click);
            // 
            // movimiento3
            // 
            this.movimiento3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento3.Location = new System.Drawing.Point(325, 522);
            this.movimiento3.Name = "movimiento3";
            this.movimiento3.Size = new System.Drawing.Size(132, 48);
            this.movimiento3.TabIndex = 12;
            this.movimiento3.Text = "Movimiento3";
            this.movimiento3.Click += new System.EventHandler(this.movimiento3_Click);
            // 
            // movimiento4
            // 
            this.movimiento4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento4.Location = new System.Drawing.Point(463, 522);
            this.movimiento4.Name = "movimiento4";
            this.movimiento4.Size = new System.Drawing.Size(126, 48);
            this.movimiento4.TabIndex = 13;
            this.movimiento4.Text = "Movimiento4";
            this.movimiento4.Click += new System.EventHandler(this.movimiento4_Click);
            // 
            // habilidadPokemon
            // 
            this.habilidadPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilidadPokemon.Location = new System.Drawing.Point(348, 327);
            this.habilidadPokemon.Name = "habilidadPokemon";
            this.habilidadPokemon.Size = new System.Drawing.Size(91, 48);
            this.habilidadPokemon.TabIndex = 14;
            this.habilidadPokemon.Text = "Habilidad";
            this.habilidadPokemon.Click += new System.EventHandler(this.habilidadPokemon_Click);
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descripcion.Location = new System.Drawing.Point(40, 514);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(262, 44);
            this.descripcion.TabIndex = 15;
            this.descripcion.Text = "Descripción";
            this.descripcion.UseVisualStyleBackColor = false;
            this.descripcion.Click += new System.EventHandler(this.descripcion_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 637);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.habilidadPokemon);
            this.Controls.Add(this.movimiento4);
            this.Controls.Add(this.movimiento3);
            this.Controls.Add(this.movimiento2);
            this.Controls.Add(this.movimiento1);
            this.Controls.Add(this.habitatPokemon);
            this.Controls.Add(this.especiePokemon);
            this.Controls.Add(this.tipo2);
            this.Controls.Add(this.tipo1);
            this.Controls.Add(this.pesoPokemon);
            this.Controls.Add(this.alturaPokemon);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.derecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.izquierda);
            this.Name = "VentanaPrincipal";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button izquierda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button derecha;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.Label alturaPokemon;
        private System.Windows.Forms.Label pesoPokemon;
        private System.Windows.Forms.Label tipo1;
        private System.Windows.Forms.Label tipo2;
        private System.Windows.Forms.Label especiePokemon;
        private System.Windows.Forms.Label habitatPokemon;
        private System.Windows.Forms.Label movimiento1;
        private System.Windows.Forms.Label movimiento2;
        private System.Windows.Forms.Label movimiento3;
        private System.Windows.Forms.Label movimiento4;
        private System.Windows.Forms.Label habilidadPokemon;
        private System.Windows.Forms.Button descripcion;
    }
}

