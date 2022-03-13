namespace Pokedex2022_CSharp
{
    partial class VentanaDescripcion
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
            this.tituloTextoDescripcion = new System.Windows.Forms.Label();
            this.textoDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tituloTextoDescripcion
            // 
            this.tituloTextoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTextoDescripcion.ForeColor = System.Drawing.Color.Red;
            this.tituloTextoDescripcion.Location = new System.Drawing.Point(12, 26);
            this.tituloTextoDescripcion.Name = "tituloTextoDescripcion";
            this.tituloTextoDescripcion.Size = new System.Drawing.Size(252, 29);
            this.tituloTextoDescripcion.TabIndex = 0;
            this.tituloTextoDescripcion.Text = "Descripción";
            this.tituloTextoDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tituloTextoDescripcion.Click += new System.EventHandler(this.tituloTextoDescripcion_Click);
            // 
            // textoDescripcion
            // 
            this.textoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDescripcion.ForeColor = System.Drawing.Color.Red;
            this.textoDescripcion.Location = new System.Drawing.Point(38, 55);
            this.textoDescripcion.Name = "textoDescripcion";
            this.textoDescripcion.Size = new System.Drawing.Size(198, 169);
            this.textoDescripcion.TabIndex = 1;
            this.textoDescripcion.Text = "Texto Descripción";
            this.textoDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VentanaDescripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(276, 248);
            this.Controls.Add(this.textoDescripcion);
            this.Controls.Add(this.tituloTextoDescripcion);
            this.Name = "VentanaDescripcion";
            this.Text = "VentanaDescripcion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tituloTextoDescripcion;
        private System.Windows.Forms.Label textoDescripcion;
    }
}