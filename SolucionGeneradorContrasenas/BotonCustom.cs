using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referencias
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace SolucionGeneradorContrasenas
{
    public class BotonCustom : Button
    {
        //Campos
        private int tamanoBorde = 0;
        private int radioBorde = 0;
        private Color colorBorde = Color.PaleVioletRed;

        //Propiedades del boton
        [Category("Propiedades boton")]
        public int TamanoBorde { 
            get
            {
                return tamanoBorde;
            }
            set
            {
                tamanoBorde=value;
                this.Invalidate();
            }
        }
        [Category("Propiedades boton")]
        public int RadioBorde {
            get
            {
                return radioBorde;
            }
            set
            {
                radioBorde=value;
                this.Invalidate();
            }
        }
        [Category("Propiedades boton")]
        public Color ColorBorde
        {
            get
            {
                return colorBorde;
            }
            set 
            { 
                colorBorde=value;
                this.Invalidate();
            }
        }

        //Propiedades para cambiar el color de fondo y texto
        [Category("Propiedades boton")]
        public Color colorFondo
        {
            get { return this.BackColor; }
            set { this.BackColor = value;}
        }
        [Category ("Propiedades boton")]
        public Color colorTexto
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //Constructor
        public BotonCustom()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if(radioBorde > this.Height)
            {
                radioBorde = this.Height; //El borde del radio será del mismo alto que el botón
            }
        }

        //Metodo para la ruta del gráfico del boton
        private GraphicsPath obtenerRutaGrafico(RectangleF rect, float radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
            path.AddArc(rect.Width-radio, rect.Y, radio, radio, 270, 90);
            path.AddArc(rect.Width-radio, rect.Height-radio, radio, radio, 0, 90);
            path.AddArc(rect.X, rect.Height - radio, radio, radio, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectanguloSuperficie = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectanguloBordeBoton = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if(radioBorde > 2) //Boton con esquinas redondeadas
            {
                using (GraphicsPath superficieRuta = obtenerRutaGrafico(rectanguloSuperficie, radioBorde))
                using (GraphicsPath rutaBorde = obtenerRutaGrafico(rectanguloBordeBoton, radioBorde - 1F))
                using (Pen  superficieBoton = new Pen(this.Parent.BackColor, 2))
                using (Pen  bordeBoton = new Pen(colorBorde, tamanoBorde))
                {
                    bordeBoton.Alignment = PenAlignment.Inset;
                    //Superficie del boton
                    this.Region = new Region(superficieRuta);
                    //Dibujo el borde la superficie
                    e.Graphics.DrawPath(superficieBoton, superficieRuta);

                    //Borde del boton
                    if(tamanoBorde >= 1)
                    {
                        //Dibujo el borde del boton
                        e.Graphics.DrawPath(bordeBoton, rutaBorde);
                    }
                }
            }
            else //Boton normal
            {
                //Superficie boton
                this.Region = new Region(rectanguloSuperficie);
                //Borde boton
                if(tamanoBorde >= 1)
                {
                    using (Pen lapizBorde = new Pen(colorBorde, tamanoBorde))
                    {
                        lapizBorde.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(lapizBorde, 0, 0, this.Width - 1, this.Height -1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                this.Invalidate();
            }
        }
    }
}
