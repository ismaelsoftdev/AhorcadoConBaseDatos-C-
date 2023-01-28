using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Ahorcado_Base_Datos
{
    public partial class NuevoUsuario : Form
    {  
        Conexion conexion = new Conexion();
        public NuevoUsuario()
        {
            InitializeComponent();
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            validarContraseña();
            if (!txtPass.Text.Equals(""))
            {
            btnGuardar.Visible = true;

            }
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            conexion.estableceConexion();
           
        }

        private void txtGuardar_Click(object sender, EventArgs e)
        {

                Usuario user= new Usuario();
                user.insertarUsuario(txtNombre,txtPass);
                conexion.deconectar();


            txtNombre.Text=string.Empty;
            txtPass.Text=string.Empty;
                

            this.Close();
            
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Usuario")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Usuario";
                txtNombre.ForeColor = Color.DimGray;
            }
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;

                //Ocultamos los caracteres del campo de texto contraseña
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

       
        

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private bool validarUsuario()
        {
            if (txtNombre.Text.Equals("Usuario") || txtNombre.Text.Trim().Equals("") || txtNombre.Text.Length<4)
            {
                lblUsuario.Visible= true;
                return false;
            }
            lblUsuario.Visible = false;
            return true;
        }
        private bool validarContraseña()
        {
            if (txtPass.Text.Equals("Contraseña") || txtPass.Text.Trim().Equals("") || txtPass.Text.Length < 5)
            {
                lblContraseña.Visible = true;
                return false;
            }
            lblContraseña.Visible = false;

            return true;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validarUsuario();
        }
    }
}
