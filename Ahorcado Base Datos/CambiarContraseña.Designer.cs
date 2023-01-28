namespace Ahorcado_Base_Datos
{
    partial class CambiarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarContraseña));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnVer = new System.Windows.Forms.PictureBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(77, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nueva contraseña";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Silver;
            this.btnGuardar.Location = new System.Drawing.Point(140, 255);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 43);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(82, 97);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(264, 32);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "Contraseña";
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.Silver;
            this.lblPass.Location = new System.Drawing.Point(78, 158);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(206, 29);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Repite contraseña";
            this.lblPass.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.ForeColor = System.Drawing.Color.Red;
            this.lblContraseña.Location = new System.Drawing.Point(79, 142);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(224, 16);
            this.lblContraseña.TabIndex = 9;
            this.lblContraseña.Text = "Contraseña debe tener 5 caracteres ";
            this.lblContraseña.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(368, 97);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(41, 32);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 10;
            this.btnSalir.TabStop = false;
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSalir_MouseUp);
            // 
            // btnVer
            // 
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.Location = new System.Drawing.Point(368, 201);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(41, 32);
            this.btnVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVer.TabIndex = 11;
            this.btnVer.TabStop = false;
            this.btnVer.Visible = false;
            this.btnVer.MouseLeave += new System.EventHandler(this.btnVer_MouseLeave);
            this.btnVer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVer_MouseUp);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(82, 201);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(264, 32);
            this.txtNewPass.TabIndex = 12;
            this.txtNewPass.Text = "Contraseña";
            this.txtNewPass.Visible = false;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            this.txtNewPass.Enter += new System.EventHandler(this.txtNewPass_Enter);
            this.txtNewPass.Leave += new System.EventHandler(this.txtNewPass_Leave);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(115, 13);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(185, 16);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "Las contraseñas no coinciden";
            this.lblError.Visible = false;
            // 
            // CambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(449, 322);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(449, 322);
            this.MinimumSize = new System.Drawing.Size(449, 322);
            this.Name = "CambiarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarContraseña";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnVer;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblError;
    }
}