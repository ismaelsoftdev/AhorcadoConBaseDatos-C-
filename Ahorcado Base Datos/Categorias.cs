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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ahorcado_Base_Datos
{
    public partial class Categorias : Form
    {
        string newCategoria;
        string clave;
        string palabra;
        public Categorias()
        {
            InitializeComponent();
            cargarCombo();
            compruebaCombo();
            clave = combo.Items[0].ToString();
            levi.Visible = true;

        }
       private void cargarCombo()
        {
            combo.DataSource = null;
            combo.Items.Clear();
            combo2.Items.Clear();
            String sql = "select nombre from Titulares";
            Conexion conexion= new Conexion();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql,conexion.estableceConexion());
                MySqlDataAdapter data= new MySqlDataAdapter(comando);
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    combo.Items.Add(lector.GetString(0));
                    combo2.Items.Add(lector.GetString(0));
                }
                conexion.deconectar();


            }
            catch(MySqlException ex){
                MessageBox.Show(ex.Message);
            }

        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabla= combo.SelectedIndex;
            clave= combo.Items[tabla].ToString();
           
            if (combo.SelectedIndex >= 0)
            {
                Categorias_Clase newCategory= new Categorias_Clase();
                Conexion connect = new Conexion();
              
                MySqlCommand comando = new MySqlCommand("Select * from categorias where nombre=@nombre", connect.estableceConexion());
                comando.Parameters.Add(new MySqlParameter("@nombre", clave));
                MySqlDataAdapter ad = new MySqlDataAdapter(comando);
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {

                }
                connect.deconectar();
                DataTable t = new DataTable();
                ad.Fill(t);
                dataGridView1.DataSource = t;
               

                btnAgregar.Enabled = true;
                btnBorrar.Enabled = true;  
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaAñadir añadir = new VentanaAñadir(newCategoria);
            añadir.ShowDialog();
            refrescar();
           


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int codigo = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                
                try
                {

                    Conexion conexion = new Conexion();
                    MySqlCommand borrar = new MySqlCommand("delete from categorias where id like '" + codigo + "'", conexion.estableceConexion());
                    borrar.ExecuteReader(0);
                    conexion.deconectar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                refrescar();
               
            } 
           
        }
        public void refrescar()
        {
            int tabla = combo.SelectedIndex;
            clave = combo.Items[tabla].ToString();
            if (combo.SelectedIndex >= 0)
            {
                Categorias_Clase newCategory = new Categorias_Clase();
                Conexion connect = new Conexion();

                MySqlCommand comando = new MySqlCommand("Select * from categorias where nombre=@nombre", connect.estableceConexion());
                comando.Parameters.Add(new MySqlParameter("@nombre", clave));
                MySqlDataAdapter ad = new MySqlDataAdapter(comando);
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {

                }
                connect.deconectar();
                DataTable t = new DataTable();
                ad.Fill(t);
                dataGridView1.DataSource = t;
                
            }
        }
        
        public void compruebaCombo()
        {
            if(combo.SelectedIndex < 0)
            {
                btnAgregar.Enabled = false;
                btnBorrar.Enabled= false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelCategory.Visible = true;
            levi.Visible = false;
            disableButtons();
        }
        private void disableButtons()
        {
            btnAgregar.Enabled = false;
            btnBorrar.Enabled = false;
            btnAddCategory.Enabled = false;
            btnDeleteCategory.Enabled = false;

        }
        private void activateButtons()
        {
            btnAgregar.Enabled = true;
            btnBorrar.Enabled = true;
            btnAddCategory.Enabled = true;
            btnDeleteCategory.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            activateButtons();
            levi.Visible = true;
            Categorias_Clase newCategory= new Categorias_Clase();
            newCategory.insertarCategoria(txtCategoria.Text);
            panelCategory.Visible = false;
            cargarCombo();
            combo.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            activateButtons();
            levi.Visible = true;
            panelCategory.Visible = false;
            compruebaCombo();
        }


        private void button2_Click_2(object sender, EventArgs e)
        {
            clave = combo.Items[0].ToString();
            levi.Visible = false;
            panelBorrar.Visible = true;
            disableButtons();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelBorrar.Visible = false;
            levi.Visible= true;
            activateButtons();
            compruebaCombo();
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panelBorrar.Visible = false;
            levi.Visible = true;
            Categorias_Clase categorias = new Categorias_Clase();
            categorias.deleteCategory(palabra);
            categorias.deleteCategoryInfo(palabra);
            activateButtons();
            compruebaCombo();
            cargarCombo();
            combo.SelectedIndex = 0;
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            clave = combo.Items[0].ToString();
        }

        private void combo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabla = combo2.SelectedIndex;
            palabra = combo2.Items[tabla].ToString();
        }
    }
}
