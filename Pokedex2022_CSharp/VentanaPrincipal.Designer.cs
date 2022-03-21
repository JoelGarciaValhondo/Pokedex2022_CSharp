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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.izquierda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.derecha = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.alturaPokemon = new System.Windows.Forms.Label();
            this.pesoPokemon = new System.Windows.Forms.Label();
            this.tipos = new System.Windows.Forms.Label();
            this.especiePokemon = new System.Windows.Forms.Label();
            this.habitatPokemon = new System.Windows.Forms.Label();
            this.movimiento1 = new System.Windows.Forms.Label();
            this.movimiento2 = new System.Windows.Forms.Label();
            this.movimiento3 = new System.Windows.Forms.Label();
            this.movimiento4 = new System.Windows.Forms.Label();
            this.habilidadPokemon = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Button();
            this.preEvolucion = new System.Windows.Forms.Label();
            this.posEvolucion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // izquierda
            // 
            this.izquierda.BackColor = System.Drawing.Color.Black;
            this.izquierda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izquierda.ForeColor = System.Drawing.Color.White;
            this.izquierda.Location = new System.Drawing.Point(40, 480);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(116, 70);
            this.izquierda.TabIndex = 0;
            this.izquierda.Text = "<";
            this.izquierda.UseVisualStyleBackColor = false;
            this.izquierda.Click += new System.EventHandler(this.izquierda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(85, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 156);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // derecha
            // 
            this.derecha.BackColor = System.Drawing.Color.Black;
            this.derecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.derecha.ForeColor = System.Drawing.Color.White;
            this.derecha.Location = new System.Drawing.Point(186, 480);
            this.derecha.Name = "derecha";
            this.derecha.Size = new System.Drawing.Size(116, 70);
            this.derecha.TabIndex = 2;
            this.derecha.Text = ">";
            this.derecha.UseVisualStyleBackColor = false;
            this.derecha.Click += new System.EventHandler(this.derecha_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.Color.Transparent;
            this.nombrePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.Location = new System.Drawing.Point(85, 404);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(217, 39);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.Text = "Pokemon";
            this.nombrePokemon.Click += new System.EventHandler(this.label1_Click);
            // 
            // alturaPokemon
            // 
            this.alturaPokemon.BackColor = System.Drawing.Color.SteelBlue;
            this.alturaPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alturaPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturaPokemon.ForeColor = System.Drawing.Color.White;
            this.alturaPokemon.Location = new System.Drawing.Point(308, 218);
            this.alturaPokemon.Name = "alturaPokemon";
            this.alturaPokemon.Size = new System.Drawing.Size(142, 30);
            this.alturaPokemon.TabIndex = 4;
            this.alturaPokemon.Text = "Altura";
            // 
            // pesoPokemon
            // 
            this.pesoPokemon.BackColor = System.Drawing.Color.SteelBlue;
            this.pesoPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pesoPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoPokemon.ForeColor = System.Drawing.Color.White;
            this.pesoPokemon.Location = new System.Drawing.Point(472, 218);
            this.pesoPokemon.Name = "pesoPokemon";
            this.pesoPokemon.Size = new System.Drawing.Size(144, 30);
            this.pesoPokemon.TabIndex = 5;
            this.pesoPokemon.Text = "Peso";
            this.pesoPokemon.Click += new System.EventHandler(this.pesoPokemon_Click);
            // 
            // tipos
            // 
            this.tipos.BackColor = System.Drawing.Color.SteelBlue;
            this.tipos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipos.ForeColor = System.Drawing.Color.White;
            this.tipos.Location = new System.Drawing.Point(308, 276);
            this.tipos.Name = "tipos";
            this.tipos.Size = new System.Drawing.Size(261, 30);
            this.tipos.TabIndex = 6;
            this.tipos.Text = "Tipos";
            this.tipos.Click += new System.EventHandler(this.tipo1_Click);
            // 
            // especiePokemon
            // 
            this.especiePokemon.BackColor = System.Drawing.Color.SteelBlue;
            this.especiePokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.especiePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especiePokemon.ForeColor = System.Drawing.Color.White;
            this.especiePokemon.Location = new System.Drawing.Point(308, 327);
            this.especiePokemon.Name = "especiePokemon";
            this.especiePokemon.Size = new System.Drawing.Size(125, 48);
            this.especiePokemon.TabIndex = 8;
            this.especiePokemon.Text = "Especie";
            this.especiePokemon.Click += new System.EventHandler(this.especiePokemon_Click);
            // 
            // habitatPokemon
            // 
            this.habitatPokemon.BackColor = System.Drawing.Color.SteelBlue;
            this.habitatPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.habitatPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitatPokemon.ForeColor = System.Drawing.Color.White;
            this.habitatPokemon.Location = new System.Drawing.Point(492, 368);
            this.habitatPokemon.Name = "habitatPokemon";
            this.habitatPokemon.Size = new System.Drawing.Size(124, 48);
            this.habitatPokemon.TabIndex = 9;
            this.habitatPokemon.Text = "Habitat";
            this.habitatPokemon.Click += new System.EventHandler(this.habitatPokemon_Click);
            // 
            // movimiento1
            // 
            this.movimiento1.BackColor = System.Drawing.Color.LawnGreen;
            this.movimiento1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movimiento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento1.ForeColor = System.Drawing.Color.Black;
            this.movimiento1.Location = new System.Drawing.Point(308, 480);
            this.movimiento1.Margin = new System.Windows.Forms.Padding(3);
            this.movimiento1.Name = "movimiento1";
            this.movimiento1.Size = new System.Drawing.Size(149, 48);
            this.movimiento1.TabIndex = 10;
            this.movimiento1.Text = "Movimiento1";
            this.movimiento1.Click += new System.EventHandler(this.movimiento1_Click);
            // 
            // movimiento2
            // 
            this.movimiento2.BackColor = System.Drawing.Color.LawnGreen;
            this.movimiento2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movimiento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento2.ForeColor = System.Drawing.Color.Black;
            this.movimiento2.Location = new System.Drawing.Point(463, 480);
            this.movimiento2.Name = "movimiento2";
            this.movimiento2.Size = new System.Drawing.Size(153, 48);
            this.movimiento2.TabIndex = 11;
            this.movimiento2.Text = "Movimiento2";
            this.movimiento2.Click += new System.EventHandler(this.movimiento2_Click);
            // 
            // movimiento3
            // 
            this.movimiento3.BackColor = System.Drawing.Color.LawnGreen;
            this.movimiento3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movimiento3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento3.ForeColor = System.Drawing.Color.Black;
            this.movimiento3.Location = new System.Drawing.Point(308, 567);
            this.movimiento3.Name = "movimiento3";
            this.movimiento3.Size = new System.Drawing.Size(149, 48);
            this.movimiento3.TabIndex = 12;
            this.movimiento3.Text = "Movimiento3";
            this.movimiento3.Click += new System.EventHandler(this.movimiento3_Click);
            // 
            // movimiento4
            // 
            this.movimiento4.BackColor = System.Drawing.Color.LawnGreen;
            this.movimiento4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movimiento4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento4.ForeColor = System.Drawing.Color.Black;
            this.movimiento4.Location = new System.Drawing.Point(463, 567);
            this.movimiento4.Name = "movimiento4";
            this.movimiento4.Size = new System.Drawing.Size(153, 48);
            this.movimiento4.TabIndex = 13;
            this.movimiento4.Text = "Movimiento4";
            this.movimiento4.Click += new System.EventHandler(this.movimiento4_Click);
            // 
            // habilidadPokemon
            // 
            this.habilidadPokemon.BackColor = System.Drawing.Color.SteelBlue;
            this.habilidadPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.habilidadPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilidadPokemon.ForeColor = System.Drawing.Color.White;
            this.habilidadPokemon.Location = new System.Drawing.Point(308, 404);
            this.habilidadPokemon.Name = "habilidadPokemon";
            this.habilidadPokemon.Size = new System.Drawing.Size(142, 48);
            this.habilidadPokemon.TabIndex = 14;
            this.habilidadPokemon.Text = "Habilidad";
            this.habilidadPokemon.Click += new System.EventHandler(this.habilidadPokemon_Click);
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descripcion.Location = new System.Drawing.Point(40, 571);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(262, 44);
            this.descripcion.TabIndex = 15;
            this.descripcion.Text = "Descripción";
            this.descripcion.UseVisualStyleBackColor = false;
            this.descripcion.Click += new System.EventHandler(this.descripcion_Click);
            // 
            // preEvolucion
            // 
            this.preEvolucion.BackColor = System.Drawing.Color.Black;
            this.preEvolucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preEvolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preEvolucion.ForeColor = System.Drawing.Color.Yellow;
            this.preEvolucion.Location = new System.Drawing.Point(276, 139);
            this.preEvolucion.Name = "preEvolucion";
            this.preEvolucion.Size = new System.Drawing.Size(157, 50);
            this.preEvolucion.TabIndex = 16;
            this.preEvolucion.Text = "PreEvolucion:";
            // 
            // posEvolucion
            // 
            this.posEvolucion.BackColor = System.Drawing.Color.Black;
            this.posEvolucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.posEvolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posEvolucion.ForeColor = System.Drawing.Color.Yellow;
            this.posEvolucion.Location = new System.Drawing.Point(448, 139);
            this.posEvolucion.Name = "posEvolucion";
            this.posEvolucion.Size = new System.Drawing.Size(168, 50);
            this.posEvolucion.TabIndex = 17;
            this.posEvolucion.Text = "PosEvolucion:";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(633, 655);
            this.Controls.Add(this.posEvolucion);
            this.Controls.Add(this.preEvolucion);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.habilidadPokemon);
            this.Controls.Add(this.movimiento4);
            this.Controls.Add(this.movimiento3);
            this.Controls.Add(this.movimiento2);
            this.Controls.Add(this.movimiento1);
            this.Controls.Add(this.habitatPokemon);
            this.Controls.Add(this.especiePokemon);
            this.Controls.Add(this.tipos);
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
        private System.Windows.Forms.Label tipos;
        private System.Windows.Forms.Label especiePokemon;
        private System.Windows.Forms.Label habitatPokemon;
        private System.Windows.Forms.Label movimiento1;
        private System.Windows.Forms.Label movimiento2;
        private System.Windows.Forms.Label movimiento3;
        private System.Windows.Forms.Label movimiento4;
        private System.Windows.Forms.Label habilidadPokemon;
        private System.Windows.Forms.Button descripcion;
        private System.Windows.Forms.Label preEvolucion;
        private System.Windows.Forms.Label posEvolucion;
    }
}

