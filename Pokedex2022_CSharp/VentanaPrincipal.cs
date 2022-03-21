using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex2022_CSharp
{
    public partial class VentanaPrincipal : Form
    {
        //conexión a BBDD
        Conexion miConexion = new Conexion();
        //pasar la BBDD a una datatable
        DataTable misPokemons = new DataTable();
        int idActual = 1; //guarda el id del pokemon que se esta viendo.
        int idAnterior = 0;
        int idSiguiente = 2;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void izquierda_Click(object sender, EventArgs e)
        {
            //para que no se pase en el primero
            if (idActual > 1)
            {
                idActual--;
                idAnterior--;
                idSiguiente--;
            }
            //parametros que enseñar cuando le demos a este botón
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pesoPokemon.Text = "Peso: " + misPokemons.Rows[0]["peso"].ToString() + "kg";
            alturaPokemon.Text = "Altura: " + misPokemons.Rows[0]["altura"].ToString() + "m";
            tipos.Text = "Tipo/s:    " + misPokemons.Rows[0]["tipo1"].ToString() + "    " + misPokemons.Rows[0]["tipo2"].ToString();
            especiePokemon.Text = "Especie: " + misPokemons.Rows[0]["especie"].ToString();
            habitatPokemon.Text = "Habitat: " + misPokemons.Rows[0]["habitat"].ToString();
            habilidadPokemon.Text = "Habilidad: " + misPokemons.Rows[0]["habilidad"].ToString();
            movimiento1.Text = "Movimiento 1:" + misPokemons.Rows[0]["movimiento1"].ToString();
            movimiento2.Text = "Movimiento 2:" + misPokemons.Rows[0]["movimiento2"].ToString();
            movimiento3.Text = "Movimiento 3:" + misPokemons.Rows[0]["movimiento3"].ToString();
            movimiento4.Text = "Movimiento 4:" + misPokemons.Rows[0]["movimiento4"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            if (misPokemons.Rows[0]["preEvolucion"] != DBNull.Value)
            {
                misPokemons = miConexion.getPokemonPorId(idAnterior);
                preEvolucion.Text = "PreEvolucion: " + misPokemons.Rows[0]["nombre"].ToString();
            }
            else
            {
                preEvolucion.Text = "No tiene pre evolucion";
            }
            misPokemons = miConexion.getPokemonPorId(idActual);
            if (misPokemons.Rows[0]["posEvolucion"] != DBNull.Value)
            {
                misPokemons = miConexion.getPokemonPorId(idSiguiente);
                posEvolucion.Text = "PosEvolucion: " + misPokemons.Rows[0]["nombre"].ToString();
            }
            else
            {
                posEvolucion.Text = "No tiene post evolucion";
            } 
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void derecha_Click(object sender, EventArgs e)
        {
            //para que no se pase en el último
            if (idActual<151)
            {
                idActual++;
                idAnterior++;
                idSiguiente++;
            }
            //parametros que enseñar cuando le demos a este botón
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pesoPokemon.Text = "Peso: " + misPokemons.Rows[0]["peso"].ToString() + "kg";
            alturaPokemon.Text = "Altura: " + misPokemons.Rows[0]["altura"].ToString() + "m";
            tipos.Text = "Tipo/s:    " + misPokemons.Rows[0]["tipo1"].ToString() + "    " + misPokemons.Rows[0]["tipo2"].ToString();
            especiePokemon.Text = "Especie: " + misPokemons.Rows[0]["especie"].ToString();
            habitatPokemon.Text = "Habitat: " + misPokemons.Rows[0]["habitat"].ToString();
            habilidadPokemon.Text = "Habilidad: " + misPokemons.Rows[0]["habilidad"].ToString();
            movimiento1.Text = "Movimiento 1:" + misPokemons.Rows[0]["movimiento1"].ToString();
            movimiento2.Text = "Movimiento 2:" + misPokemons.Rows[0]["movimiento2"].ToString();
            movimiento3.Text = "Movimiento 3:" + misPokemons.Rows[0]["movimiento3"].ToString();
            movimiento4.Text = "Movimiento 4:" + misPokemons.Rows[0]["movimiento4"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            if (misPokemons.Rows[0]["preEvolucion"] != DBNull.Value)
            {
                misPokemons = miConexion.getPokemonPorId(idAnterior);
                preEvolucion.Text = "PreEvolucion: " + misPokemons.Rows[0]["nombre"].ToString();
            }
            else
            {
                preEvolucion.Text = "No tiene pre evolucion";
            }
            misPokemons = miConexion.getPokemonPorId(idActual);
            if (misPokemons.Rows[0]["posEvolucion"] != DBNull.Value)
            {
                misPokemons = miConexion.getPokemonPorId(idSiguiente);
                posEvolucion.Text = "PosEvolucion: " + misPokemons.Rows[0]["nombre"].ToString();
            }
            else
            {
                posEvolucion.Text = "No tiene post evolucion";
            }
        }

        private void descripcion_Click(object sender, EventArgs e)
        {
            //crear el segundo formm y mostrarlo pasandole el parametro del pokemon.
            VentanaDescripcion desc = new VentanaDescripcion(idActual);
            desc.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pesoPokemon_Click(object sender, EventArgs e)
        {

        }

        private void tipo1_Click(object sender, EventArgs e)
        {

        }

        private void tipo2_Click(object sender, EventArgs e)
        {

        }

        private void especiePokemon_Click(object sender, EventArgs e)
        {

        }

        private void habitatPokemon_Click(object sender, EventArgs e)
        {

        }

        private void habilidadPokemon_Click(object sender, EventArgs e)
        {

        }

        private void movimiento1_Click(object sender, EventArgs e)
        {

        }

        private void movimiento2_Click(object sender, EventArgs e)
        {

        }

        private void movimiento3_Click(object sender, EventArgs e)
        {

        }

        private void movimiento4_Click(object sender, EventArgs e)
        {

        }
    }
}
