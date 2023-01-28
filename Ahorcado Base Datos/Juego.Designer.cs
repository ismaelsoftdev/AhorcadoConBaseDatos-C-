namespace Ahorcado_Base_Datos
{
    partial class Juego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.LyPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.FlLetras = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblAciertos = new System.Windows.Forms.Label();
            this.btnSurrender = new System.Windows.Forms.Button();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLoss = new System.Windows.Forms.Label();
            this.btnSwap = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.btnPista = new System.Windows.Forms.Button();
            this.lblPista = new System.Windows.Forms.Label();
            this.lblFallos = new System.Windows.Forms.Label();
            this.ImgHorca = new System.Windows.Forms.PictureBox();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.mensajeTimer = new System.Windows.Forms.Timer(this.components);
            this.btnHistorial = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHorca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LyPalabra
            // 
            this.LyPalabra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LyPalabra.BackColor = System.Drawing.Color.Transparent;
            this.LyPalabra.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LyPalabra.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LyPalabra.Location = new System.Drawing.Point(33, 520);
            this.LyPalabra.Margin = new System.Windows.Forms.Padding(2);
            this.LyPalabra.Name = "LyPalabra";
            this.LyPalabra.Size = new System.Drawing.Size(716, 77);
            this.LyPalabra.TabIndex = 3;
            // 
            // FlLetras
            // 
            this.FlLetras.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FlLetras.BackColor = System.Drawing.Color.Transparent;
            this.FlLetras.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlLetras.ForeColor = System.Drawing.Color.White;
            this.FlLetras.Location = new System.Drawing.Point(50, 601);
            this.FlLetras.Margin = new System.Windows.Forms.Padding(2);
            this.FlLetras.Name = "FlLetras";
            this.FlLetras.Size = new System.Drawing.Size(716, 241);
            this.FlLetras.TabIndex = 4;
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestart.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(335, 459);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(133, 37);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Volver a jugar";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(77, 465);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 6;
            // 
            // lblPuntos
            // 
            this.lblPuntos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPuntos.Location = new System.Drawing.Point(91, 61);
            this.lblPuntos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(0, 25);
            this.lblPuntos.TabIndex = 7;
            // 
            // lblAciertos
            // 
            this.lblAciertos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAciertos.AutoSize = true;
            this.lblAciertos.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAciertos.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAciertos.Location = new System.Drawing.Point(91, 14);
            this.lblAciertos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAciertos.Name = "lblAciertos";
            this.lblAciertos.Size = new System.Drawing.Size(0, 25);
            this.lblAciertos.TabIndex = 8;
            // 
            // btnSurrender
            // 
            this.btnSurrender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSurrender.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurrender.Location = new System.Drawing.Point(505, 22);
            this.btnSurrender.Margin = new System.Windows.Forms.Padding(2);
            this.btnSurrender.Name = "btnSurrender";
            this.btnSurrender.Size = new System.Drawing.Size(88, 37);
            this.btnSurrender.TabIndex = 9;
            this.btnSurrender.Text = "Rendirse";
            this.btnSurrender.UseVisualStyleBackColor = true;
            this.btnSurrender.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblWin
            // 
            this.lblWin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.Silver;
            this.lblWin.Location = new System.Drawing.Point(218, 346);
            this.lblWin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(368, 85);
            this.lblWin.TabIndex = 10;
            this.lblWin.Text = "Has ganado";
            this.lblWin.Visible = false;
            // 
            // lblLoss
            // 
            this.lblLoss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoss.AutoSize = true;
            this.lblLoss.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoss.ForeColor = System.Drawing.Color.Silver;
            this.lblLoss.Location = new System.Drawing.Point(199, 346);
            this.lblLoss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(387, 85);
            this.lblLoss.TabIndex = 11;
            this.lblLoss.Text = "Has perdido";
            this.lblLoss.Visible = false;
            // 
            // btnSwap
            // 
            this.btnSwap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSwap.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwap.Location = new System.Drawing.Point(14, 22);
            this.btnSwap.Margin = new System.Windows.Forms.Padding(2);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(169, 36);
            this.btnSwap.TabIndex = 12;
            this.btnSwap.Text = "Cambiar categoria";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(306, 797);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 34);
            this.button4.TabIndex = 13;
            this.button4.Text = "Salir del juego";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCategoria.Location = new System.Drawing.Point(-42, 102);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(0, 41);
            this.lblCategoria.TabIndex = 14;
            // 
            // temporizador
            // 
            this.temporizador.Interval = 1000;
            this.temporizador.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPista
            // 
            this.btnPista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPista.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPista.Location = new System.Drawing.Point(187, 23);
            this.btnPista.Margin = new System.Windows.Forms.Padding(2);
            this.btnPista.Name = "btnPista";
            this.btnPista.Size = new System.Drawing.Size(155, 36);
            this.btnPista.TabIndex = 16;
            this.btnPista.Text = "Comprar pista";
            this.btnPista.UseVisualStyleBackColor = true;
            this.btnPista.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblPista
            // 
            this.lblPista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPista.AutoSize = true;
            this.lblPista.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPista.ForeColor = System.Drawing.Color.Red;
            this.lblPista.Location = new System.Drawing.Point(507, 465);
            this.lblPista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPista.Name = "lblPista";
            this.lblPista.Size = new System.Drawing.Size(0, 25);
            this.lblPista.TabIndex = 17;
            this.lblPista.Visible = false;
            // 
            // lblFallos
            // 
            this.lblFallos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFallos.AutoSize = true;
            this.lblFallos.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFallos.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblFallos.Location = new System.Drawing.Point(42, 24);
            this.lblFallos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFallos.Name = "lblFallos";
            this.lblFallos.Size = new System.Drawing.Size(0, 46);
            this.lblFallos.TabIndex = 18;
            // 
            // ImgHorca
            // 
            this.ImgHorca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImgHorca.Image = ((System.Drawing.Image)(resources.GetObject("ImgHorca.Image")));
            this.ImgHorca.Location = new System.Drawing.Point(-7, 20);
            this.ImgHorca.Margin = new System.Windows.Forms.Padding(2);
            this.ImgHorca.Name = "ImgHorca";
            this.ImgHorca.Size = new System.Drawing.Size(399, 475);
            this.ImgHorca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgHorca.TabIndex = 19;
            this.ImgHorca.TabStop = false;
            this.ImgHorca.Visible = false;
            // 
            // lblInformacion
            // 
            this.lblInformacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblInformacion.Location = new System.Drawing.Point(62, 204);
            this.lblInformacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(322, 25);
            this.lblInformacion.TabIndex = 20;
            this.lblInformacion.Text = "Has consumido 10 pts por la pista";
            this.lblInformacion.Visible = false;
            // 
            // mensajeTimer
            // 
            this.mensajeTimer.Interval = 1000;
            this.mensajeTimer.Tick += new System.EventHandler(this.mensajeTimer_Tick);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHistorial.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.Location = new System.Drawing.Point(347, 22);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(154, 36);
            this.btnHistorial.TabIndex = 21;
            this.btnHistorial.Text = "Ver puntuaciones";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(218, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 85);
            this.label2.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 593);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(345, 304);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(340, 1060);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 40);
            this.label3.TabIndex = 24;
            this.label3.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(53, 307);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(359, 372);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImgHorca);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.lblFallos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 861);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btnSwap);
            this.panel2.Controls.Add(this.btnSurrender);
            this.panel2.Controls.Add(this.btnPista);
            this.panel2.Controls.Add(this.btnHistorial);
            this.panel2.Location = new System.Drawing.Point(101, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 76);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lblAciertos);
            this.panel3.Controls.Add(this.lblPuntos);
            this.panel3.Controls.Add(this.lblInformacion);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1210, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 861);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblLoss);
            this.panel4.Controls.Add(this.lblWin);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.btnRestart);
            this.panel4.Controls.Add(this.lblPista);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.FlLetras);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.LyPalabra);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(408, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(802, 861);
            this.panel4.TabIndex = 30;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1684, 861);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.Juego_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Juego_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.ImgHorca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LyPalabra;
        private System.Windows.Forms.FlowLayoutPanel FlLetras;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblAciertos;
        private System.Windows.Forms.Button btnSurrender;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLoss;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.Button btnPista;
        private System.Windows.Forms.Label lblPista;
        private System.Windows.Forms.Label lblFallos;
        private System.Windows.Forms.PictureBox ImgHorca;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Timer mensajeTimer;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}