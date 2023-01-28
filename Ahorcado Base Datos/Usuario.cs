using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ahorcado_Base_Datos
{
    internal class Usuario
    {
        public int puntuacion { get; set; }
        public string nombre { get; set; }
        public int partidas { get; set; }

        public Usuario() {

        }
        
        public void insertarUsuario(TextBox nombre,TextBox contrasena)
        {
            try
            {
                Conexion connect = new Conexion();


                String consulta = "insert into usuarios(nombre, contrasena)" +
                    "values('" + nombre.Text + "','"+contrasena.Text+"');";
              
                MySqlCommand comando = new MySqlCommand(consulta, connect.estableceConexion());
            
                MySqlDataReader lector = comando.ExecuteReader();
                //MessageBox.Show("Se guardaron los registros los datos");

                while (lector.Read())
                {

                }
                connect.deconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Este usuario ya existe, introduzca otro");
            }
        }
        public void seleccionaUsuario(DataGridView tablaUsuarios,  TextBox nombre, TextBox contrasena,TextBox puntuacion)
        {
            try
            {
                nombre.Text = tablaUsuarios.CurrentRow.Cells[1].Value.ToString();
                contrasena.Text = tablaUsuarios.CurrentRow.Cells[2].Value.ToString();
                puntuacion.Text = tablaUsuarios.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo seleccionar" + ex.Message);
            }
        }
        public void modificaUsuario(String nombre, String contrasena, int puntuacion, int id, bool admins)
        {
            try
            {

                Conexion conexion = new Conexion();
                String query = "Update usuarios set Nombre =@nombre, contrasena = @contrasena, Puntuacion = @puntos,adminitrador=@administrativo where id= @id";
                MySqlCommand comando = new MySqlCommand(query, conexion.estableceConexion());
                comando.Parameters.Add(new MySqlParameter("@puntos", puntuacion));
                comando.Parameters.Add(new MySqlParameter("@nombre", nombre));
                comando.Parameters.Add(new MySqlParameter("@contrasena", contrasena));
                comando.Parameters.Add(new MySqlParameter("@id", id));
                comando.Parameters.Add(new MySqlParameter("@administrativo", admins));
                MySqlDataAdapter ad = new MySqlDataAdapter(comando);
                MySqlDataReader lector = comando.ExecuteReader();
                MessageBox.Show("Se guardaron los registros los datos");

                while (lector.Read())
                {

                }
                conexion.deconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar los datos, " + ex.Message);
            }
        }
        public void addUserFull(string nombre, string contrasena, int puntuacion,bool admins)
        {
            try
            {
                Conexion connect = new Conexion();


                String consulta = "insert into usuarios (nombre, contrasena, puntuacion,adminitrador)" +
                    "values(@nombre,@contrasena,@puntuacion,@administrador);";

                MySqlCommand comando = new MySqlCommand(consulta, connect.estableceConexion());
                comando.Parameters.Add(new MySqlParameter("@puntuacion", puntuacion));
                comando.Parameters.Add(new MySqlParameter("@nombre", nombre));
                comando.Parameters.Add(new MySqlParameter("@contrasena", contrasena));
                comando.Parameters.Add(new MySqlParameter("@administrador", admins));
                MySqlDataAdapter ad = new MySqlDataAdapter(comando);
                MySqlDataReader lector = comando.ExecuteReader();
                MessageBox.Show("Se guardaron los registros los datos");

                while (lector.Read())
                {

                }
                connect.deconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
