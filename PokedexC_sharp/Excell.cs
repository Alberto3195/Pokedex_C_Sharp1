using System;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    public partial class Excell : Form
    {
        public int idSeleccionado;
        public int nombre;
        public int peso;
        
        Consultas consulta = new Consultas();
        //Esto llama a la clase
        VentanaPrincipal V = new VentanaPrincipal();
        //Esto crea un objeto de tipo Form, vamos una ventanita de esas
        Form ventanaActiva = new Form();

        //Constructor de la clase, recibe por parametro el From padre desde el que le llamamos
        public Excell()
        {
            InitializeComponent();
            dataGridView1.DataSource = consulta.getTodosPokemons();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //Igualamos nuestro Form al Form padre para luego jugar con el
            //ventanaActiva = ventanaPrincipal;
            //ventanaActiva.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idSeleccionado = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            Console.WriteLine(idSeleccionado);
            this.Close();
            //Problema de esto, que no le encuentro otra forma de hacerlo aun que seguro que la hay,
            //al hacer doble click en un pokemon se cierra el Form que contiene el dataGridView
            //y se abre otro Form con la Pokedex, pero este Form no es la pantalla principal aun que
            //contenga toda la apariencia de la misma.
            //El fallo viene cuando al cerrar la Pokedex desde este form nuevo, se ve que no se cierra
            //se cierra el Form pero el programa sigue corriendo.
            V.Datos(idSeleccionado);
            V.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                V.idActual = int.Parse(elemento.Text);
                V.Datos(V.idActual);
                V.Show();
                elemento.Text = "";//Dejamos el buscador de ID vacío
                this.Hide();
            }
            catch (Exception ex)
            {//Si el id no es valido salta un aviso
                MessageBox.Show("ID no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                elemento.Text = "";
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                V.idActual = int.Parse(consulta.getPokemonPorNombre(elemento.Text.ToLower()));
                V.Datos(V.idActual);
                V.Show();
                elemento.Text = "";//Dejamos el buscador de ID vacío
                this.Close();
            }
            catch (Exception ex)
            {//Si el id no es valido salta un aviso
                MessageBox.Show("Nombre no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                elemento.Text = "";
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            String id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            String nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();

            MessageBox.Show(consulta.actualizaPokemon(nombre, id));
        }
    }
}
