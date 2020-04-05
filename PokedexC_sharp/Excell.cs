using System;
using System.Data;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    public partial class Excell : Form
    {
        public int idSeleccionado;
        public int nombre;
        public int peso;
        Consultas consultas = new Consultas();
        DataTable misPokemons = new DataTable();

        public Excell()
        {
            InitializeComponent();

            dataGridView1.DataSource = consultas.getTodosPokemons();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idSeleccionado = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString()); 

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            String id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            String nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();

            MessageBox.Show(consultas.actualizaPokemon(nombre, id));
        }
    }
}
