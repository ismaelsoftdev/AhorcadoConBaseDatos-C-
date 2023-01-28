using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado_Base_Datos
{
    internal class Conexion
    {
        MySqlConnection conex = new MySqlConnection();
        static string servidor = "localhost";
        static string bd = "ahorcado";
        static string usuario = "root";
        static string password = "12345678";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
        public MySqlConnection estableceConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
               // MessageBox.Show("Conexion establecida con: "+conex.Database+" exitosa");
               
            }
            catch (MySqlException e)
            {
                 //MessageBox.Show("No se pudo establecer la conexion "+e.ToString());
            }

            return conex;
        }

        public MySqlConnection deconectar()
        {
            conex.Close();



            return conex;
        }
    }
   
    }

