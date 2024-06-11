using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionGeneradorContrasenas
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        Random random = new Random();
        string[] Fuente;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarContraseña_Click(object sender, EventArgs e)
        {
            txtContrasena.Text = string.Empty;
            for (int i = 0; i < Convert.ToInt32(txtTamanoContrasena.Text); i++)
            {
                var randomPass = Fuente[random.Next(Fuente.Length)];
                txtContrasena.Text += randomPass[random.Next(randomPass.Length)];
            }
        }

        private void trackBarContrasena_Scroll(object sender, EventArgs e)
        {
            //Ancho de contraseña
            txtTamanoContrasena.Text = trackBarAnchoContrasena.Value.ToString();
        }

        private void cBox_CheckedChanged(object sender, EventArgs e)
        {
            Fuente = new string[this.Controls.OfType<CheckBox>().Where(x => x.Checked).Count()];
            
            foreach (var item in this.Controls.OfType<CheckBox>().Where(x => x.Checked))
            {
                for (int i = 0; i < 4; i++)
                {
                    if (Fuente[i] == null)
                    {
                        Fuente[i] = item.Tag.ToString();
                        break;
                    }
                }
            }
        }

        private void txtAnchoContrasena_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTamanoContrasena_Click(object sender, EventArgs e)
        {

        }

        private void botonCustom1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
