using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado_Base_Datos
{
    internal class Categorias_Clase
    {

        //Metodos que hacen llamada a las consultas
    public void insertarCategoria(string nombre)
        {
            try
            {
                Conexion connect = new Conexion();


                String consulta = "insert into Titulares (NOMBRE)" +
                     "values(@nombre);";

                MySqlCommand comando = new MySqlCommand(consulta, connect.estableceConexion());
               
                comando.Parameters.Add(new MySqlParameter("@nombre", nombre));
               
                MySqlDataAdapter ad = new MySqlDataAdapter(comando);
                MySqlDataReader lector = comando.ExecuteReader();
                //MessageBox.Show("Se guardaron los registros los datos");

                while (lector.Read())
                {

                }
                connect.deconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esa categoria ya existe");
            }
        }
        public void deleteCategory(string nombre)
        {
            DialogResult dg = MessageBox.Show("Va a borrar una categoria,¿Desea continuar?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dg == DialogResult.Yes)
            {

            
            try
            {
                Conexion connect = new Conexion();


                String consulta = "delete  from Titulares where nombre=@nombre ";

                MySqlCommand comando = new MySqlCommand(consulta, connect.estableceConexion());

                comando.Parameters.Add(new MySqlParameter("@nombre", nombre));
                

                MySqlDataAdapter ad = new MySqlDataAdapter(comando);
                MySqlDataReader lector = comando.ExecuteReader();
                //MessageBox.Show("Datos borrados");

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
        public void deleteCategoryInfo(string nombre)
        {
           
                try
                {
                    Conexion connect = new Conexion();


                    String consulta = "delete  from categorias where nombre=@nombre ";

                    MySqlCommand comando = new MySqlCommand(consulta, connect.estableceConexion());

                    comando.Parameters.Add(new MySqlParameter("@nombre", nombre));


                    MySqlDataAdapter ad = new MySqlDataAdapter(comando);
                    MySqlDataReader lector = comando.ExecuteReader();
                    

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
        public void modifyCategory(string nombre,string palabra,int id)
        {
            try
            {

                Conexion conexion = new Conexion();
                String query = "Update categorias set Nombre =@nombre, palabra = @palabra where id= @id";
                MySqlCommand comando = new MySqlCommand(query, conexion.estableceConexion());
                comando.Parameters.Add(new MySqlParameter("@palabra", palabra));
                comando.Parameters.Add(new MySqlParameter("@nombre", nombre));
                comando.Parameters.Add(new MySqlParameter("@id", id));
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

      
    }
}
