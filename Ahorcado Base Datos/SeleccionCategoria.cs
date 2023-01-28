using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado_Base_Datos
{
    public partial class SeleccionCategoria : Form
    {
        string opcion;
        string nombreJugador;
        bool admin;
        public SeleccionCategoria()
        {
            InitializeComponent();
            cargarCombo();

        }
        private void cargarCombo()
        {
            CBCategorias.DataSource = null;
            CBCategorias.Items.Clear();
           
            String sql = "select nombre from Titulares";
            Conexion conexion = new Conexion();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion.estableceConexion());
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    CBCategorias.Items.Add(lector.GetString(0));
                    
                }
                conexion.deconectar();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public SeleccionCategoria(string jugador)
        {
            InitializeComponent();
            nombreJugador= jugador; 
            label2.Text = "Bienvenido "+jugador.ToString();
            cargarCombo();

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Juego game= new Juego(opcion,nombreJugador);
            game.ShowDialog();
            
          
        }

       

        private void CBCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            eligeCategoria();

            if (CBCategorias.SelectedIndex >= 0)
            {
                btnJugar.Visible = true;
            }
        }
        private void eligeCategoria()
        {
            int indice=CBCategorias.SelectedIndex;
            opcion= CBCategorias.Items[indice].ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeleccionCategoria_Load(object sender, EventArgs e)
        {

            compruebaAdmin();
            //label3.Text = admin.ToString();
            activaAdmin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CambiarContraseña newPass = new CambiarContraseña(nombreJugador);
            newPass.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial(nombreJugador);
            historial.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();
            admin.ShowDialog();
        }
        private void compruebaAdmin()
        {
            Conexion conexion= new Conexion();
            MySqlCommand comando = new MySqlCommand("Select adminitrador from usuarios where nombre=@nombre", conexion.estableceConexion());
            comando.Parameters.Add(new MySqlParameter("@nombre", nombreJugador));
            MySqlDataAdapter ad = new MySqlDataAdapter(comando);
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                if (lector.IsDBNull(0))
                {
                    admin = false;
                }
                else
                {

                admin = lector.GetBoolean(0);
                }
                
            }
            conexion.deconectar();
        } private void activaAdmin()
            {
            if (admin)
            {
                btnAdmin.Visible = true;
            }
            else
            {
                btnAdmin.Visible = false;
            }
            }

       
       
    }
   
}
