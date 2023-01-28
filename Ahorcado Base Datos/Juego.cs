using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ahorcado_Base_Datos
{
    public partial class Juego : Form
    {
        //Listas de palabras
        
        List<String>palabras= new List<String>();

        //Herramientas para crear palabras del ahorcado
        char[] alfabeto = "QWERTYUIOPASDFGHJKLÑZXCVBNM".ToCharArray();
        char[] guessedWord;
        string solucion;
        int segundos = 1;
        int puntos=10;
        int totalPalabras;
        int eleccion = 0;
        string nombreJugador;
        int conteo=2;
        int fallos = 6;
        int cuenta = 2;
        string category;
        int puntosTotales;
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public Juego()
        {
            InitializeComponent();
            iniciaJuego();
        }
        public Juego(string opcion,string nombre)
        {
            InitializeComponent();
            iniciaJuego();
            category= opcion;
            agregaPalabras(opcion);
            chooseWord();
            label2.Text = opcion;
            nombreJugador = nombre;
            
            lblFallos.Text = "Fallos: " + fallos;
            lblPuntos.Visible = true;
        }

        public void iniciaJuego()
        {
            FlLetras.Controls.Clear();
            rellenaTablero();
            activaPista();
            lblPuntos.Text = "Puntos: " + puntos;
            lblAciertos.Text = "Palabras acertadas: " + totalPalabras;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;

        }
        //Metodo que genera el tablero con las letras
        public void rellenaTablero()
        {
            foreach (char letra in alfabeto)
            {
                Button btnLetra = new Button();

                btnLetra.Tag = "";
                btnLetra.Text = letra.ToString();
                btnLetra.Width = 60;
                btnLetra.Height = 40;
                btnLetra.Click += compara;
                btnLetra.ForeColor = Color.White;
                btnLetra.BackgroundImageLayout = ImageLayout.Center;
                btnLetra.BackColor = Color.Transparent;
                btnLetra.Name = letra.ToString();
                FlLetras.Controls.Add(btnLetra);
                btnLetra.FlatAppearance.MouseOverBackColor = Color.Transparent;
                btnLetra.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btnLetra.FlatAppearance.BorderSize = 0;
                btnLetra.FlatStyle = FlatStyle.Flat;

            }
            LyPalabra.Controls.Clear();
        }
        public void agregaPalabras(string tipo)
        {
            Conexion conexion = new Conexion();
            MySqlCommand comando = new MySqlCommand("Select Palabra from categorias where nombre=@nombre", conexion.estableceConexion());
            comando.Parameters.Add(new MySqlParameter("@nombre", tipo));
           
            MySqlDataAdapter ad = new MySqlDataAdapter(comando);
           
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
               
                string words = reader.GetString(0);
                palabras.Add(words);


            }
        }
       
       
       
        private void chooseWord()
        {
            Random random = new Random();
            int idPalabra = random.Next(0, palabras.Count);
            char[] selectedWord = palabras[idPalabra].ToUpper().ToCharArray();
            guessedWord = selectedWord;
            solucion = new string(guessedWord);

            for (int i = 0; i < selectedWord.Length; i++)
            {
                Button btnLetra = new Button();

                btnLetra.Tag = selectedWord[i].ToString();
                btnLetra.Text = "__";
                btnLetra.Width = 46;
                btnLetra.Height = 80;
                btnLetra.ForeColor = Color.White;
                btnLetra.BackgroundImageLayout = ImageLayout.Center;
                btnLetra.BackColor = Color.Transparent;
                btnLetra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnLetra.Name = "Adivinado" + i.ToString();
                btnLetra.FlatAppearance.MouseOverBackColor = Color.Transparent;
                btnLetra.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btnLetra.FlatAppearance.BorderSize = 0;
                LyPalabra.Controls.Add(btnLetra);
            }
        }
        
        void compara(Object sender, EventArgs e)
        {
            activaPista();
            bool acierto = false;
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
            btn.ForeColor = Color.Black;
            btn.Enabled = false;


            for (int i = 0; i < guessedWord.Length; i++)
            {
                if (guessedWord[i] == Char.Parse(btn.Text))
                {

                    Button tbx = this.Controls.Find("Adivinado" + i, true).FirstOrDefault() as Button;
                    tbx.Text = guessedWord[i].ToString();
                    btn.BackColor = Color.Green;
                    guessedWord[i] = '-';
                    acierto = true;
                    

                }
                 
                
            }
            bool ganador = true;
            for (int i = 0; i < guessedWord.Length; i++)
            {
                if (guessedWord[i] != '-')
                {
                    ganador = false;
                }
            }

            if (ganador)
            {
                winner();
            }
            if (!acierto)
            {
                fallos--;
                perder();
                lblFallos.Text = "Fallos: " + fallos;
            }
            else
            {
                activaPista();
                puntos++;
                lblPuntos.Visible = true;
                lblPuntos.Text = "Puntos " + puntos;
            }
           
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            reiniciaJuego();
            chooseWord();
            agregaPalabras(category);
            fallos = 6;
            lblFallos.Text = "Fallos: " + fallos;
            puntos = 10;
            lblPuntos.Text = "Puntos: " + puntos;
            totalPalabras = 0;
            lblAciertos.Text = "Palabras acertadas " + totalPalabras;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "La palabra era "+solucion;
            pararJuego();
            fallos = 6;
            lblFallos.Text= "Fallos: " + fallos;
            pictureBox3.Visible= false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeleccionCategoria newCat= new SeleccionCategoria(nombreJugador);
            newCat.ShowDialog();
            
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            guardaResultado();
            sumaPuntos();
            addTotalPoints();
            this.Close();
           
        }

        private void guardaResultado()
        {
            try
            {

            Conexion conexion = new Conexion();
                String query2 = "Insert into puntuaciones(nombre, puntuacion,Palabras_acertadas) values(@nombre,@puntos,@aciertos)";
            //String query = "Update puntuaciones set puntuacion = @puntos where nombre= @nombre";
            MySqlCommand comando = new MySqlCommand(query2, conexion.estableceConexion());
                comando.Parameters.Add(new MySqlParameter("@puntos", puntos));
                comando.Parameters.Add(new MySqlParameter("@nombre", nombreJugador));
                comando.Parameters.Add(new MySqlParameter("@aciertos", totalPalabras));
                MySqlDataAdapter ad = new MySqlDataAdapter(comando);
                MySqlDataReader lector = comando.ExecuteReader();
               // MessageBox.Show("Se guardaron los registros los datos");

            while (lector.Read())
            {

            }
            conexion.deconectar();
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudo guardar los datos, "+ex.Message);
            }
        }
            


    

        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo--;
            if (conteo==0)
            {
                lblWin.Visible = false;
                iniciaJuego();
                agregaPalabras(category);
                chooseWord();
                conteo = 2;
                temporizador.Enabled = false;
                lblPista.Visible = false;
                btnPista.Visible = true;
                btnSurrender.Visible = true;

            }

        }
        private void activaPista()
        {
            if (puntos >= 10)
            {
                btnPista.Enabled = true;
            }
            else
            {
                btnPista.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            lblInformacion.Visible = true;
            mensajeTimer.Enabled = true;
            puntos = puntos-10;
                lblPuntos.Text = "Puntos " + puntos;
                char letra;
                Random random = new Random();
                for (int i = 0; i < guessedWord.Length; i++)
                {
                    if (guessedWord[i] != '-')
                    {
                    //letra = guessedWord[random.Next(0, guessedWord.Length)];
                    letra = guessedWord[i];
                        lblPista.Text = "La palabra contiene la letra " + letra;
                    }
                
                }
            lblPista.Visible = true;
            activaPista();
           
           
           

        }
        private void perder()
        {
            if(fallos==0)
            {
                lblLoss.Visible = true;
                btnPista.Visible = false;
                btnRestart.Visible = true;  
                btnSurrender.Visible = false;
                LyPalabra.Visible = false;
                FlLetras.Visible = false;
                lblCategoria.Visible = false;
                btnSwap.Visible = false;
                ImgHorca.Visible = true;
                lblPuntos.Visible = false;
                lblAciertos.Visible = false;
                    pictureBox2.Visible = false;
            }
        }

        private void pararJuego()
        {
            //Labels
            lblLoss.Visible = true;
            lblCategoria.Visible = false;
            lblFallos.Visible = false;
            label1.Visible = true;
            lblPuntos.Visible = false;
            lblAciertos.Visible = false;
            //Botones
            btnPista.Visible = false;
            btnRestart.Visible = true;
            btnSurrender.Visible = false;
            btnSwap.Visible = false;
            //Paneles
            LyPalabra.Enabled = false;
            FlLetras.Enabled = false;
            ImgHorca.Visible = true;
            puntos = 0;
            totalPalabras = 0;
            pictureBox2.Visible = false;


        }
        private void reiniciaJuego()
        {
            iniciaJuego();
            //Labels
            lblLoss.Visible = false;
            lblCategoria.Visible = true;
            lblFallos.Visible = true;
            label1.Visible = false;
            lblAciertos.Visible = true;
            lblPuntos.Visible = true;
            lblPista.Visible = false;
            //Botones
            btnSurrender.Visible = true;
            btnRestart.Visible = false;
            btnPista.Visible = true;
            btnSwap.Visible = true;
            //Paneles
            LyPalabra.Enabled = true;
            FlLetras.Enabled = true;
            ImgHorca.Visible = false;
            LyPalabra.Visible = true;
            FlLetras.Visible = true;
            pictureBox2.Visible = false;

            addTotalPoints();
        }
        private void winner()
        {
            puntos += 10;
            lblWin.Visible = true;
            totalPalabras++;
            temporizador.Enabled = true;
            lblPuntos.Text = "Puntos " + puntos;
            lblAciertos.Text = "Palabras acertadas " + totalPalabras;
            lblCategoria.Visible = false;
            fallos = 6;
            lblFallos.Text = "Fallos: " + fallos;
            btnPista.Visible = false;
            btnSurrender.Visible = false;
            pictureBox2.Visible = true;
        }

        private void mensajeTimer_Tick(object sender, EventArgs e)
        {
            
            cuenta--;
            if (cuenta == 0)
            {
                lblInformacion.Visible = false;
                cuenta = 2;
               
               
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {

            Historial historial = new Historial(nombreJugador);
            historial.ShowDialog();
           
            


        }

        private void Juego_Load(object sender, EventArgs e)
        {
           /* this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;*/
        }

        private void Juego_MouseDown(object sender, MouseEventArgs e)
        {
          /*  ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);*/
        }

        private void sumaPuntos()
        {
            try
            {

                Conexion conexion = new Conexion();
                String query2 = "select sum(puntuacion) from puntuaciones where nombre=@nombre";
                //String query = "Update puntuaciones set puntuacion = @puntos where nombre= @nombre";
                MySqlCommand comando = new MySqlCommand(query2, conexion.estableceConexion());
                comando.Parameters.Add(new MySqlParameter("@nombre", nombreJugador));
  
                MySqlDataAdapter ad = new MySqlDataAdapter(comando);
                MySqlDataReader lector = comando.ExecuteReader();
                // MessageBox.Show("Se guardaron los registros los datos");

                while (lector.Read())
                {
                    puntosTotales = lector.GetInt32(0);
                }
                conexion.deconectar();
            }
            catch (Exception ex)
            {
               // MessageBox.Show("No se pudo guardar los datos, " + ex.Message);
            }
        }
        private void addTotalPoints()
        {
            sumaPuntos();
            try
            {

                Conexion conexion = new Conexion();
                String query2 = "update  usuarios set Puntuacion=@puntuacion where nombre=@nombre";
                //String query = "Update puntuaciones set puntuacion = @puntos where nombre= @nombre";
                MySqlCommand comando = new MySqlCommand(query2, conexion.estableceConexion());
                comando.Parameters.Add(new MySqlParameter("@nombre", nombreJugador));
                comando.Parameters.Add(new MySqlParameter("@puntuacion", puntosTotales));
                MySqlDataAdapter ad = new MySqlDataAdapter(comando);
                MySqlDataReader lector = comando.ExecuteReader();
                 //MessageBox.Show("Se guardaron los registros los datos");

                while (lector.Read())
                {
                    puntosTotales = lector.GetInt32(0);
                }
                conexion.deconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar los datos, " + ex.Message);
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
