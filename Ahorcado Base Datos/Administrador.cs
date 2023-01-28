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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jugadores players= new Jugadores();
            players.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            Categorias categorias= new Categorias();
            categorias.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
