using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    public partial class VentanaPrincipal : Form
    {
        Consultas consultas = new Consultas();
        DataTable misPokemons = new DataTable();

        public int idActual = 1; //el pokemon en pantalla es el 1

        public VentanaPrincipal()
        {
            InitializeComponent();
            Datos(idActual);
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
            if (idActual < 1) { idActual = 151; }
            Datos(idActual);
        }

        private void der_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual > 151) { idActual = 1; }
            Datos(idActual);

        }
        private void X_Click(object sender, EventArgs e)
        {
            this.Hide();
            Excell eligePokemon = new Excell();
            eligePokemon.Show();
        }

        public void Datos(int idActual)
        //Ahorro lineas de codigo creando éste método 
        //que me sirve tanto par botón izq como para el derecho
        {
            misPokemons = consultas.getPokemonPorId(idActual);

            id.Text = "Nº: " + (id.Text = misPokemons.Rows[0]["id"].ToString());
            NombrePokemon.Text = "Nombre: " + (NombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString());
            tipo1.Text = "Tipo1: " + (tipo1.Text = misPokemons.Rows[0]["tipo1"].ToString());
            tipo2.Text = "Tipo2: " + (tipo2.Text = misPokemons.Rows[0]["tipo2"].ToString());
            altura.Text = "Altura: " + (altura.Text = misPokemons.Rows[0]["altura"].ToString());
            peso.Text = "Peso: " + (peso.Text = misPokemons.Rows[0]["peso"].ToString());
            habitat.Text = "Habitat: " + (habitat.Text = misPokemons.Rows[0]["habitat"].ToString());
            especie.Text = "Especie: " + (especie.Text = misPokemons.Rows[0]["especie"].ToString());
            habilidad.Text = "Habiliad: " + (habilidad.Text = misPokemons.Rows[0]["habilidad"].ToString());
            descripcion.Text = "Descripcion: " + (descripcion.Text = misPokemons.Rows[0]["descripcion"].ToString());

            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }
    }
}
