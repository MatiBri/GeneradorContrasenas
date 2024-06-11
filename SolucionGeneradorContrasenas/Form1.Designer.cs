namespace SolucionGeneradorContrasenas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.cBoxMayusculas = new System.Windows.Forms.CheckBox();
            this.cBoxMinúsculas = new System.Windows.Forms.CheckBox();
            this.cBoxNúmeros = new System.Windows.Forms.CheckBox();
            this.cBoxSímbolos = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarAnchoContrasena = new System.Windows.Forms.TrackBar();
            this.txtTamanoContrasena = new System.Windows.Forms.Label();
            this.btnGenerarContraseña = new SolucionGeneradorContrasenas.BotonCustom();
            this.botonCustom1 = new SolucionGeneradorContrasenas.BotonCustom();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAnchoContrasena)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(178, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generador de contraseñas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.White;
            this.txtContrasena.Location = new System.Drawing.Point(63, 190);
            this.txtContrasena.Multiline = true;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(325, 57);
            this.txtContrasena.TabIndex = 3;
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtAnchoContrasena_TextChanged);
            // 
            // cBoxMayusculas
            // 
            this.cBoxMayusculas.AutoSize = true;
            this.cBoxMayusculas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxMayusculas.Location = new System.Drawing.Point(138, 274);
            this.cBoxMayusculas.Name = "cBoxMayusculas";
            this.cBoxMayusculas.Size = new System.Drawing.Size(131, 27);
            this.cBoxMayusculas.TabIndex = 4;
            this.cBoxMayusculas.Tag = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.cBoxMayusculas.Text = "Mayúsculas";
            this.cBoxMayusculas.UseVisualStyleBackColor = true;
            this.cBoxMayusculas.CheckedChanged += new System.EventHandler(this.cBox_CheckedChanged);
            // 
            // cBoxMinúsculas
            // 
            this.cBoxMinúsculas.AutoSize = true;
            this.cBoxMinúsculas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxMinúsculas.Location = new System.Drawing.Point(138, 307);
            this.cBoxMinúsculas.Name = "cBoxMinúsculas";
            this.cBoxMinúsculas.Size = new System.Drawing.Size(126, 27);
            this.cBoxMinúsculas.TabIndex = 5;
            this.cBoxMinúsculas.Tag = "abcdefghijklmnopqrstuvwxyz";
            this.cBoxMinúsculas.Text = "Minúsculas";
            this.cBoxMinúsculas.UseVisualStyleBackColor = true;
            this.cBoxMinúsculas.CheckedChanged += new System.EventHandler(this.cBox_CheckedChanged);
            // 
            // cBoxNúmeros
            // 
            this.cBoxNúmeros.AutoSize = true;
            this.cBoxNúmeros.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxNúmeros.Location = new System.Drawing.Point(138, 340);
            this.cBoxNúmeros.Name = "cBoxNúmeros";
            this.cBoxNúmeros.Size = new System.Drawing.Size(108, 27);
            this.cBoxNúmeros.TabIndex = 6;
            this.cBoxNúmeros.Tag = "0123456789";
            this.cBoxNúmeros.Text = "Números";
            this.cBoxNúmeros.UseVisualStyleBackColor = true;
            this.cBoxNúmeros.CheckedChanged += new System.EventHandler(this.cBox_CheckedChanged);
            // 
            // cBoxSímbolos
            // 
            this.cBoxSímbolos.AutoSize = true;
            this.cBoxSímbolos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxSímbolos.Location = new System.Drawing.Point(139, 373);
            this.cBoxSímbolos.Name = "cBoxSímbolos";
            this.cBoxSímbolos.Size = new System.Drawing.Size(107, 27);
            this.cBoxSímbolos.TabIndex = 7;
            this.cBoxSímbolos.Tag = "!@#$%^&*()_+~|}{[]:;?><,./-=";
            this.cBoxSímbolos.Text = "Símbolos";
            this.cBoxSímbolos.UseVisualStyleBackColor = true;
            this.cBoxSímbolos.CheckedChanged += new System.EventHandler(this.cBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tamaño";
            // 
            // trackBarAnchoContrasena
            // 
            this.trackBarAnchoContrasena.Location = new System.Drawing.Point(63, 455);
            this.trackBarAnchoContrasena.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarAnchoContrasena.Minimum = 1;
            this.trackBarAnchoContrasena.Name = "trackBarAnchoContrasena";
            this.trackBarAnchoContrasena.Size = new System.Drawing.Size(269, 56);
            this.trackBarAnchoContrasena.TabIndex = 9;
            this.trackBarAnchoContrasena.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarAnchoContrasena.Value = 6;
            this.trackBarAnchoContrasena.Scroll += new System.EventHandler(this.trackBarContrasena_Scroll);
            // 
            // txtTamanoContrasena
            // 
            this.txtTamanoContrasena.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamanoContrasena.Location = new System.Drawing.Point(335, 455);
            this.txtTamanoContrasena.Name = "txtTamanoContrasena";
            this.txtTamanoContrasena.Size = new System.Drawing.Size(40, 25);
            this.txtTamanoContrasena.TabIndex = 10;
            this.txtTamanoContrasena.Text = "6";
            this.txtTamanoContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTamanoContrasena.Click += new System.EventHandler(this.txtTamanoContrasena_Click);
            // 
            // btnGenerarContraseña
            // 
            this.btnGenerarContraseña.BackColor = System.Drawing.Color.SlateBlue;
            this.btnGenerarContraseña.ColorBorde = System.Drawing.Color.Indigo;
            this.btnGenerarContraseña.colorFondo = System.Drawing.Color.SlateBlue;
            this.btnGenerarContraseña.colorTexto = System.Drawing.Color.White;
            this.btnGenerarContraseña.FlatAppearance.BorderSize = 0;
            this.btnGenerarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarContraseña.ForeColor = System.Drawing.Color.White;
            this.btnGenerarContraseña.Location = new System.Drawing.Point(27, 501);
            this.btnGenerarContraseña.Name = "btnGenerarContraseña";
            this.btnGenerarContraseña.RadioBorde = 50;
            this.btnGenerarContraseña.Size = new System.Drawing.Size(399, 62);
            this.btnGenerarContraseña.TabIndex = 11;
            this.btnGenerarContraseña.TamanoBorde = 2;
            this.btnGenerarContraseña.Text = "Generar Contraseña";
            this.btnGenerarContraseña.UseVisualStyleBackColor = false;
            this.btnGenerarContraseña.Click += new System.EventHandler(this.btnGenerarContraseña_Click);
            // 
            // botonCustom1
            // 
            this.botonCustom1.BackColor = System.Drawing.Color.Red;
            this.botonCustom1.ColorBorde = System.Drawing.Color.RoyalBlue;
            this.botonCustom1.colorFondo = System.Drawing.Color.Red;
            this.botonCustom1.colorTexto = System.Drawing.Color.White;
            this.botonCustom1.FlatAppearance.BorderSize = 0;
            this.botonCustom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCustom1.ForeColor = System.Drawing.Color.White;
            this.botonCustom1.Location = new System.Drawing.Point(395, 12);
            this.botonCustom1.Name = "botonCustom1";
            this.botonCustom1.RadioBorde = 30;
            this.botonCustom1.Size = new System.Drawing.Size(43, 44);
            this.botonCustom1.TabIndex = 12;
            this.botonCustom1.TamanoBorde = 3;
            this.botonCustom1.Text = "X";
            this.botonCustom1.UseVisualStyleBackColor = false;
            this.botonCustom1.Click += new System.EventHandler(this.botonCustom1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.botonCustom1);
            this.Controls.Add(this.btnGenerarContraseña);
            this.Controls.Add(this.txtTamanoContrasena);
            this.Controls.Add(this.trackBarAnchoContrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxSímbolos);
            this.Controls.Add(this.cBoxNúmeros);
            this.Controls.Add(this.cBoxMinúsculas);
            this.Controls.Add(this.cBoxMayusculas);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAnchoContrasena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.CheckBox cBoxMayusculas;
        private System.Windows.Forms.CheckBox cBoxMinúsculas;
        private System.Windows.Forms.CheckBox cBoxNúmeros;
        private System.Windows.Forms.CheckBox cBoxSímbolos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarAnchoContrasena;
        private System.Windows.Forms.Label txtTamanoContrasena;
        private BotonCustom btnGenerarContraseña;
        private BotonCustom botonCustom1;
    }
}

