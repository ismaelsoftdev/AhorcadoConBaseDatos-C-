using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado_Base_Datos
{
    public partial class VentanaAñadir : Form
    {
        String clave;
        string newCategory;
        public VentanaAñadir()
        {
            InitializeComponent();
            cargarCombo();
        }
        public VentanaAñadir(string newCategoria)
        {
            InitializeComponent();
            newCategory= newCategoria;
            cargarCombo();
        }
        private void cargarCombo()
        {
            combo.DataSource = null;
            combo.Items.Clear();
            String sql = "select nombre from Titulares";
            Conexion conexion = new Conexion();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion.estableceConexion());
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    combo.Items.Add(lector.GetString(0));
                }
                conexion.deconectar();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = combo.SelectedIndex;
            clave = combo.Items[indice].ToString();
           
        }

        private bool validar()
        {
            if (txtPalabra.Text.Trim().Equals(""))
            {
                txtError.Visible = true;
                return false;
            }

            return true;
        }

        private bool validaCombo()
        {
            if (combo.SelectedIndex<0)
            {
                txtErrorCombo.Visible= true;
                return false;
            }
            return true;
        }

       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validaCombo() && validar())
            {

                try
                {

                
                Conexion conexion = new Conexion();
                string insert = "Insert Into categorias (nombre,palabra) values (@nombre,@palabra);";
                MySqlCommand comando = new MySqlCommand(insert, conexion.estableceConexion());
                comando.Parameters.Add(new MySqlParameter("@nombre", clave));
                comando.Parameters.Add(new MySqlParameter("@palabra", txtPalabra.Text));
                MySqlDataAdapter ad = new MySqlDataAdapter(comando);


                MySqlDataReader lector = comando.ExecuteReader();
                MessageBox.Show("Se guardaron los registros los datos");

                while (lector.Read())
                {

                }
                conexion.deconectar();
                }catch(Exception ex)
                {
                    MessageBox.Show("Error la palabra ya existe");
                }
                this.Close();
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VentanaAñadir_Load(object sender, EventArgs e)
        {
           
        }
    }
}
