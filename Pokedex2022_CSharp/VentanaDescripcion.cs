using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex2022_CSharp
{
    public partial class VentanaDescripcion : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();

        int idActual;

        public VentanaDescripcion(int idActual)
        {
            InitializeComponent();
            this.idActual = idActual;
            misPokemons = miConexion.getPokemonPorId(idActual);
            textoDescripcion.Text = misPokemons.Rows[0]["descripcion"].ToString();
            tituloTextoDescripcion.Text = "Descripción " + misPokemons.Rows[0]["nombre"].ToString();
        }

        private void tituloTextoDescripcion_Click(object sender, EventArgs e)
        {
            
        }
    }
}
