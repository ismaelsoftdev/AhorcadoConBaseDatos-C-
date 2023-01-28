using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ahorcado_Base_Datos
{
    public partial class CambiarContraseña : Form
    {
        string nombreJugador;
        public CambiarContraseña()
        {
            InitializeComponent();
        }
        public CambiarContraseña(string nombre)
        {
            InitializeComponent();
            nombreJugador = nombre;
        }
        /*private bool compruebaDatos()
        {
            Conexion conexion = new Conexion();
            String consulta = "Select nombre from usuarios where nombre = @vnombre ";
            MySqlCommand comando = new MySqlCommand(consulta, conexion.estableceConexion());
            comando.Parameters.AddWithValue("@vnombre", txtNombre.Text);

            MySqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                lblError.Visible = false;
                lblPass.Visible = true;
                txtPass.Visible= true;
                btnSalir.Visible = true;    
                conexion.deconectar();
                return true;
            }
            else
            {
                lblError.Visible = true;
            }

            return false;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
                 try
                {
                Conexion conexion = new Conexion();
                string query = "update usuarios set contrasena = @contrasena where nombre= @nombre ";

                
                MySqlCommand comando = new MySqlCommand(query, conexion.estableceConexion());
                comando.Parameters.Add(new MySqlParameter("@contrasena", txtPass.Text));
                comando.Parameters.Add(new MySqlParameter("@nombre", nombreJugador));
                MySqlDataAdapter ad = new MySqlDataAdapter(comando);
                MySqlDataReader lector = comando.ExecuteReader();
                MessageBox.Show("Contraseña actualizada");

                while (lector.Read())
                {

                }
                    conexion.deconectar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar los datos, " + ex.Message);
                }

            this.Close();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool validarContraseña()
        {
            if (txtPass.Text.Equals("Contraseña") || txtPass.Text.Trim().Equals("") || txtPass.Text.Length < 5)
            {
                lblContraseña.Visible = true;
                lblPass.Visible = false;
                return false;
            }
            lblContraseña.Visible = false;
            lblPass.Visible = true;
            return true;
           
        }
        private bool validarContraseñaNueva()
        {
            if (txtNewPass.Text.Trim().Equals("") || !(txtNewPass.Text.Equals(txtPass.Text)))
            {
                lblError.Visible = true;
                return false;
            }
            lblError.Visible = false;
            return true;
        }
       
       

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (validarContraseña())
            {
                txtNewPass.Visible = true;
                btnVer.Visible = true;
            }

        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                

                //Ocultamos los caracteres del campo de texto contraseña
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {

            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                
                txtPass.UseSystemPasswordChar = false;
            }
        }

        

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnSalir_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

       

       

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {

            if (validarContraseñaNueva())
            {
                btnGuardar.Visible = true;
            }
            else
            {
                btnGuardar.Visible = false;
            }
        }

        private void txtNewPass_Leave(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "")
            {
                txtNewPass.Text = "Contraseña";

                txtNewPass.UseSystemPasswordChar = false;
            }
        }

        private void txtNewPass_Enter(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "Contraseña")
            {
                txtNewPass.Text = "";


                //Ocultamos los caracteres del campo de texto contraseña
                txtNewPass.UseSystemPasswordChar = true;
            }
        }

        private void btnVer_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = false;
        }

        private void btnVer_MouseLeave(object sender, EventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = true;
        }
    }
}
