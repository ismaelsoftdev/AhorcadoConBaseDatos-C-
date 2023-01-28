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

namespace Ahorcado_Base_Datos
{
    public partial class Historial : Form
    {
        public Historial(string nombre)
        {
            InitializeComponent();
            cargarTabla(nombre);
        }
        public void cargarTabla(string nombre)
        {
            Conexion conexion = new Conexion();
            MySqlCommand comando = new MySqlCommand("Select Nombre,puntuacion,palabras_Acertadas from puntuaciones where nombre =@nombre", conexion.estableceConexion());
            comando.Parameters.Add(new MySqlParameter("@nombre", nombre));
            MySqlDataAdapter ad = new MySqlDataAdapter(comando);
            DataTable t = new DataTable();
            ad.Fill(t);
            dataGridView1.DataSource = t;
            conexion.deconectar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
