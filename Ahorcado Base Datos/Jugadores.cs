using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Ahorcado_Base_Datos
{
    public partial class Jugadores : Form
        {
        
        int puntosTotales;
        int puntuacion;
        string nombre;
        string contrasena;
        bool admin;
        int opcion=0;
        string inde;

        public Jugadores()
        {
            InitializeComponent();
           
            cargarTabla();
        }
      
      

        private void cargarTabla()
        {
            
            dataGridView1.Refresh();
         
            Conexion conexion= new Conexion();
            MySqlCommand comando = new MySqlCommand("Select * from usuarios", conexion.estableceConexion());
            MySqlDataAdapter ad = new MySqlDataAdapter(comando);
            DataTable t = new DataTable();
            ad.Fill(t);
            dataGridView1.DataSource = t;
            conexion.deconectar();

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                cargarTabla();
            }
            else
            {
                string filtro = textBox1.Text;
                Conexion conexion= new Conexion();
                MySqlCommand command = new MySqlCommand("Select * from usuarios where nombre like '" + filtro + "%'", conexion.estableceConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conexion.deconectar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*NuevoUsuario userNew= new NuevoUsuario();   
            userNew.ShowDialog();*/
            emptyFields();
            opcion = 1;
            panelModificar.Visible = true;
            disableButtons();
            dataGridView1.Enabled= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opcion = 2;
            panelModificar.Visible = true;
            Usuario userSelected= new Usuario();
            userSelected.seleccionaUsuario(dataGridView1,txtNombre,txtPass,txtPoints);
            disableButtons();
            int codigo = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            guardarDatos();
           
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult dg = MessageBox.Show("Va a eliminar un jugador,¿Desea continuar?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dg == DialogResult.Yes)
                {
                    int codigo = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    inde = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    try
                    {

                    Conexion conexion = new Conexion();
                    MySqlCommand borrar = new MySqlCommand("delete from usuarios where id like '" + codigo + "'", conexion.estableceConexion());
                    borrar.ExecuteReader(0);
                    conexion.deconectar();
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    refrescar();


                }
            }
        }
        public void refrescar()
        {
            
            Conexion conexion = new Conexion();
            MySqlCommand comando = new MySqlCommand("Select * from usuarios", conexion.estableceConexion());
            MySqlDataAdapter ad = new MySqlDataAdapter(comando);
            DataTable t = new DataTable();
            ad.Fill(t);
            dataGridView1.DataSource = t;
            conexion.deconectar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            panelModificar.Visible= false;
            activateButtons();
            
            Usuario userSelected = new Usuario();
            if (txtPoints.Text.Equals("0"))
            {
                txtPoints.Text = "0";
            }
                if (opcion == 1)
                {
                guardarDatos();
                userSelected.addUserFull(nombre,contrasena,puntuacion,admin);


                }
                else if (opcion==2)
                {
                int codigo = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                guardarDatos();
                userSelected.modificaUsuario(nombre, contrasena, puntuacion, codigo,admin);


                }
            
                   refrescar();
                   opcion = 0;
                   dataGridView1.Enabled = true;
          


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuario userSelected = new Usuario();
            if (opcion == 1)
            {
                txtNombre.Text = string.Empty;
                txtPass.Text=string.Empty;
                txtPoints.Text = string.Empty;
            }
            int codigo = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            userSelected.seleccionaUsuario(dataGridView1, txtNombre, txtPass, txtPoints);
            label6.Text = inde;
            
        }

        private void disableButtons()
        {
            btnModificar.Enabled= false;
            btnAñadir.Enabled= false;
            btnBorrar.Enabled= false;
        }
        private void activateButtons()
        {
            btnModificar.Enabled = true;
            btnAñadir.Enabled = true;
            btnBorrar.Enabled = true;
        }
        private void guardarDatos()
        {
            nombre = txtNombre.Text;
            contrasena=txtPass.Text;
            if (txtPoints.Text.Equals(""))
            {
                txtPoints.Text = "0";
                puntuacion =Int32.Parse(txtPoints.Text);

            }
            else
            {
                puntuacion = Int32.Parse(txtPoints.Text);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelModificar.Visible = false;
            activateButtons();
        }
        private void emptyFields()
        {
            nombre=string.Empty;
            contrasena = string.Empty;
            puntuacion = 0;
            txtNombre.Text = string.Empty;
            txtPass.Text = string.Empty;    
            txtPoints.Text = string.Empty;
        }

        private void txtPoints_TextChanged(object sender, EventArgs e)
        {
            if (!(txtPoints.Text.All(Char.IsDigit)))
            {
                lblError.Visible = true;
            }
            else
            {
                lblError.Visible = false;
            }
        }

        private void rdOn_CheckedChanged(object sender, EventArgs e)
        {
            admin = true;
        }

        private void rdOff_CheckedChanged(object sender, EventArgs e)
        {
            admin = false;
        }
    }
}
