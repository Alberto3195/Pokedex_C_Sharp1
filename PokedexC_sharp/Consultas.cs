using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace PokedexC_sharp
{
    public class Consultas
    {
        //Llamamos a la clase Conexion
        Conexion miClaseConexion = new Conexion();

        //Tabla sobre la que hacemos las consultas
        private static string tabla = "pokemon";

        //Consulta para obtener todos los datos de los Pokemon que aparecerán en la pokedex fera del dataGridView
        public string datos = "SELECT id, nombre, altura, peso, habitat, tipo1, tipo2, especie, habilidad, imagen FROM " + tabla;

        public DataTable getPokemonPorId(int id)
        {
            try
            {
                miClaseConexion.conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * " +
                                                         "FROM pokemon where id = '"
                                                         + id + "'", miClaseConexion.conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                miClaseConexion.conexion.Close();
                return pokemons;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public DataTable getTodosPokemons()
        {
            try
            {
                miClaseConexion.conexion.Open();
                MySqlCommand consulta = new MySqlCommand(datos, miClaseConexion.conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                miClaseConexion.conexion.Close();
                return pokemons;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public String actualizaPokemon(String id, String dato)
        {
            try
            {
                miClaseConexion.conexion.Open();
                MySqlCommand consulta = new MySqlCommand("UPDATE pokemon set nombre = '" + dato + "' WHERE id='" + id + "'", miClaseConexion.conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                String mensaje;
                if (resultado.RecordsAffected == 1)
                {
                    mensaje = "actualizado correctamente";
                }
                else
                {
                    mensaje = "error al actualizar el nombre del pokemon";
                }
                miClaseConexion.conexion.Close();
                return mensaje;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}