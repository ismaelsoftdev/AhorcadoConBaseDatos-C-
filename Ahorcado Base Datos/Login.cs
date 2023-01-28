using System;
using MySqlConnector;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Ahorcado_Base_Datos
{   
    public partial class Login : Form
    {
        //Variables
        string jugador;
        
        public Login()
        {
            InitializeComponent();
           
            
        }


        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        

        private void button1_Click(object sender, EventArgs e)
        {
            //txtName.ForeColor = Color.LightGray;
            if (txtName.Text.Equals("Admin") && txtPass.Text.Equals("Admin1"))
            {
                Administrador admin = new Administrador();
                admin.ShowDialog();
                txtName.ForeColor = Color.DimGray;
                txtPass.ForeColor = Color.DimGray;
                txtName.Text = "Usuario";
                txtPass.Text = "Contraseña";
            }
            else {  
            Conexion conexion = new Conexion();
            String consulta = "Select nombre, contrasena from usuarios where nombre = @vnombre and contrasena = @contrasena";
            MySqlCommand comando = new MySqlCommand(consulta, conexion.estableceConexion());
            comando.Parameters.AddWithValue("@vnombre",txtName.Text);
            comando.Parameters.AddWithValue("@contrasena", txtPass.Text);

            MySqlDataReader lector= comando.ExecuteReader();
            
            if (lector.Read())
            {
               
               
               jugador=txtName.Text;
               conexion.deconectar();
               SeleccionCategoria categoria= new SeleccionCategoria(jugador);
               categoria.ShowDialog();

                    txtName.ForeColor = Color.DimGray;
                    txtPass.ForeColor = Color.DimGray;
                    txtName.Text = "Usuario";
                    txtPass.Text = "Contraseña";
                    txtPass.UseSystemPasswordChar = false;


                }
            else 
              {
                label3.Visible = true;
              }

            }
            
           
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodos para mantener el campo de texto usuario con su placeholder

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Usuario")
            {
                txtName.Text = "";
                txtName.ForeColor= Color.LightGray;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Usuario";
                txtName.ForeColor = Color.DimGray;
            }
        }
        //Metodos para mantener el campo de texto contraseña con su placeholder

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

        private void label2_Click(object sender, EventArgs e)
        {
            NuevoUsuario userNew= new NuevoUsuario();
            userNew.ShowDialog();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();  
            admin.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            CambiarContraseña newPass = new CambiarContraseña();
            newPass.ShowDialog();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals(""))
            {
                label3.Visible = false;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Name.Equals(""))
            {
                label3.Visible = false;
            }
        }
    }
}
