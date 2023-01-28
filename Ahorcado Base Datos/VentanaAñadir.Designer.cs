namespace Ahorcado_Base_Datos
{
    partial class VentanaAñadir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAñadir));
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.Label();
            this.txtErrorCombo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPalabra
            // 
            this.txtPalabra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalabra.Location = new System.Drawing.Point(137, 142);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(181, 28);
            this.txtPalabra.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Silver;
            this.btnGuardar.Location = new System.Drawing.Point(169, 189);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 36);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // combo
            // 
            this.combo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo.ForeColor = System.Drawing.Color.Silver;
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(109, 86);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(230, 29);
            this.combo.TabIndex = 2;
            this.combo.Tag = "";
            this.combo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione la categoria para agregar";
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.ForeColor = System.Drawing.Color.Red;
            this.txtError.Location = new System.Drawing.Point(134, 123);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(173, 16);
            this.txtError.TabIndex = 4;
            this.txtError.Text = "Debe introducir una palabra";
            this.txtError.Visible = false;
            // 
            // txtErrorCombo
            // 
            this.txtErrorCombo.AutoSize = true;
            this.txtErrorCombo.ForeColor = System.Drawing.Color.Red;
            this.txtErrorCombo.Location = new System.Drawing.Point(123, 67);
            this.txtErrorCombo.Name = "txtErrorCombo";
            this.txtErrorCombo.Size = new System.Drawing.Size(199, 16);
            this.txtErrorCombo.TabIndex = 5;
            this.txtErrorCombo.Text = "Debe seleccionar una categoria";
            this.txtErrorCombo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // VentanaAñadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(457, 257);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtErrorCombo);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPalabra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(457, 257);
            this.MinimumSize = new System.Drawing.Size(457, 257);
            this.Name = "VentanaAñadir";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaAñadir";
            this.Load += new System.EventHandler(this.VentanaAñadir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.Label txtErrorCombo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}