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
        //conexion a BBDD
        Conexion miConexion = new Conexion();
        //añadir BBDD a datatable
        DataTable misPokemons = new DataTable();

        public VentanaDescripcion(int idActual)
        {
            InitializeComponent();
            misPokemons = miConexion.getPokemonPorId(idActual);
            //descripción
            textoDescripcion.Text = misPokemons.Rows[0]["descripcion"].ToString();
            //titulo
            tituloTextoDescripcion.Text = "Descripción " + misPokemons.Rows[0]["nombre"].ToString();
        }

        private void tituloTextoDescripcion_Click(object sender, EventArgs e)
        {
            
        }
    }
}
