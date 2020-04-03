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

namespace PokedexC_sharp
{
    public partial class VentanaPrincipal : Form
    {
        Consultas consultas = new Consultas();
        DataTable misPokemons = new DataTable();
        int idActual = 1; //el pokemon en pantalla es el 1
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        public Image convierteBlobAImagen(byte[] img)
            //Convierte el Blob almacenado en la base a una imagen legible
        { 
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void izq_Click(object sender, EventArgs e)
        {
            idActual--;
            if(idActual <= 0) { idActual = 1; };
            Datos();
        }

        private void der_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 151) { idActual = 151; }
            Datos();;
        }
        private void X_Click(object sender, EventArgs e)
        {
            Excell eligePokemon = new Excell();
            eligePokemon.ShowDialog();
            idActual = eligePokemon.idSeleccionado;
            //MessageBox.Show(eligePokemon.idSeleccionado.ToString());
            misPokemons = consultas.getPokemonPorId(eligePokemon.idSeleccionado);

            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            id.Text = misPokemons.Rows[0]["id"].ToString();
            tipo.Text = misPokemons.Rows[0]["tipo1"].ToString();
            habilidad.Text = misPokemons.Rows[0]["habilidad"].ToString();
            especie.Text = misPokemons.Rows[0]["especie"].ToString();
            habitat.Text = misPokemons.Rows[0]["habitat"].ToString();
            altura.Text = misPokemons.Rows[0]["altura"].ToString();
            peso.Text = misPokemons.Rows[0]["peso"].ToString();
        }
        private void Datos()
        //Ahorro lineas de codigo creando éste método 
        //que me sirve tanto par botón izq como para el derecho
        {
            misPokemons = consultas.getPokemonPorId(idActual);
            id.Text = misPokemons.Rows[0]["id"].ToString();
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            tipo.Text = misPokemons.Rows[0]["tipo1"].ToString();
            altura.Text = misPokemons.Rows[0]["altura"].ToString();
            peso.Text = misPokemons.Rows[0]["peso"].ToString();
            habitat.Text = misPokemons.Rows[0]["habitat"].ToString();
            especie.Text = misPokemons.Rows[0]["especie"].ToString();
            habilidad.Text = misPokemons.Rows[0]["habilidad"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }
    }
}
