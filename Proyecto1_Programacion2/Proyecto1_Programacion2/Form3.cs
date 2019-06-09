using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto1_Programacion2
{
    public partial class FRMPaint : Form
    {
        Graphics graficos;
        Pen lapiz = new Pen(Color.Black, 1);
        Pen borrarLineas = new Pen(Color.White, 50);
        SolidBrush pintura = new SolidBrush(Color.Black);
        Point inicio = new Point(0, 0);
        Point final = new Point(0, 0);
        int numero = 0;
        int width = 0;
        int height = 0;


        Boolean dibujar = true;
        Boolean hacerCuadro = false;
        Boolean hacerCirculo = false;
        Boolean hacerCuadroRelleno = false;
        Boolean hacerCirculoRelleno = false;
        Boolean borrar = false;
        Boolean colorearFondo = false;
        private bool puedeDibujar;

        private int inicioX, inicioY;
        private Rectangle cuadro;
        private Rectangle circulo;
        private Rectangle cuadroRelleno;
        private Rectangle circuloRelleno;

        private Bitmap objDrawingSurface;
        private Rectangle rectBounds1;

        public FRMPaint()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (hacerCuadro == true)
            {
                {
                    e.Graphics.DrawRectangle(lapiz, cuadro);
                }
            }
            else
            {
                if (hacerCirculo == true)
                {
                    {
                        e.Graphics.DrawEllipse(lapiz, circulo);
                    }
                }
                else
                {
                    if (hacerCuadroRelleno == true)
                    {
                        e.Graphics.DrawRectangle(lapiz, cuadroRelleno);
                        e.Graphics.FillRectangle(pintura, cuadroRelleno);
                    }
                    else
                    {
                        if (hacerCirculoRelleno == true)
                        {
                            e.Graphics.DrawEllipse(lapiz, circuloRelleno);
                            e.Graphics.FillEllipse(pintura, circuloRelleno);
                        }
                    }
                }
            }
        }

        private void pictureBoxNegro_Click(object sender, EventArgs e)
        {
            lapiz.Color = pictureBoxNegro.BackColor;
            pintura.Color = pictureBoxNegro.BackColor;
            pictureBoxColorPrincipal.BackColor = pictureBoxNegro.BackColor;
        }

        private void pictureBoxRojo_Click(object sender, EventArgs e)
        {
            lapiz.Color = pictureBoxRojo.BackColor;
            pintura.Color = pictureBoxRojo.BackColor;
            pictureBoxColorPrincipal.BackColor = pictureBoxRojo.BackColor;
        }

        private void pictureBoxAzul_Click(object sender, EventArgs e)
        {
            lapiz.Color = pictureBoxAzul.BackColor;
            pintura.Color = pictureBoxAzul.BackColor;
            pictureBoxColorPrincipal.BackColor = pictureBoxAzul.BackColor;
        }

        private void pictureBoxVerde_Click(object sender, EventArgs e)
        {
            lapiz.Color = pictureBoxVerde.BackColor;
            pintura.Color = pictureBoxVerde.BackColor;
            pictureBoxColorPrincipal.BackColor = pictureBoxVerde.BackColor;
        }

        private void pictureBoxAmarillo_Click(object sender, EventArgs e)
        {
            lapiz.Color = pictureBoxAmarillo.BackColor;
            pintura.Color = pictureBoxAmarillo.BackColor;
            pictureBoxColorPrincipal.BackColor = pictureBoxAmarillo.BackColor;
        }

        private void pictureBoxBlanco_Click(object sender, EventArgs e)
        {
            lapiz.Color = pictureBoxBlanco.BackColor;
            pintura.Color = pictureBoxBlanco.BackColor;
            pictureBoxColorPrincipal.BackColor = pictureBoxBlanco.BackColor;
        }

        private void pictureBoxChocolate_Click(object sender, EventArgs e)
        {
            lapiz.Color = pictureBoxChocolate.BackColor;
            pintura.Color = pictureBoxChocolate.BackColor;
            pictureBoxColorPrincipal.BackColor = pictureBoxChocolate.BackColor;
        }

        private void pictureBoxAqua_Click(object sender, EventArgs e)
        {
            lapiz.Color = pictureBoxAqua.BackColor;
            pintura.Color = pictureBoxAqua.BackColor;
            pictureBoxColorPrincipal.BackColor = pictureBoxAqua.BackColor;
        }

        private void pictureBoxFuchsia_Click(object sender, EventArgs e)
        {
            lapiz.Color = pictureBoxFuchsia.BackColor;
            pintura.Color = pictureBoxFuchsia.BackColor;
            pictureBoxColorPrincipal.BackColor = pictureBoxFuchsia.BackColor;
        }

        private void pictureBoxGris_Click(object sender, EventArgs e)
        {
            lapiz.Color = pictureBoxGris.BackColor;
            pintura.Color = pictureBoxGris.BackColor;
            pictureBoxColorPrincipal.BackColor = pictureBoxGris.BackColor;
        }

        private void Paint_MouseDown(object sender, MouseEventArgs e)
        {
            if (dibujar == true)
            {
                inicio = e.Location;
                if (e.Button == MouseButtons.Left)
                {
                    numero = 1;
                }
            }
            else
            {
                if (borrar == true)
                {
                    inicio = e.Location;
                    if (e.Button == MouseButtons.Left)
                    {
                        numero = 1;
                    }
                }
                else
                {
                    if (colorearFondo == true)
                    {
                        BackColor = pictureBoxColorPrincipal.BackColor;
                    }
                }

            }
            puedeDibujar = true;
            inicioX = e.X;
            inicioY = e.Y;
        }

        private void Paint_MouseUp(object sender, MouseEventArgs e)
        {
            numero = 0;
            puedeDibujar = false;
        }

        private void Paint_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujar == true)
            {
                if (numero == 1)
                {
                    final = e.Location;
                    graficos = this.CreateGraphics();
                    graficos.DrawLine(lapiz, inicio, final);
                }
                inicio = final;
            }
            else
            {
                if (hacerCuadro == true)
                {
                    if (!puedeDibujar) return;
                    int x = Math.Min(inicioX, e.X);
                    int y = Math.Min(inicioY, e.Y);
                    int width = Math.Max(inicioX, e.X) - Math.Min(inicioX, e.X);
                    int height = Math.Max(inicioY, e.Y) - Math.Min(inicioY, e.Y);
                    cuadro = new Rectangle(x, y, width, height);
                    this.Refresh();

                }
                else
                {
                    if (hacerCirculo == true)
                    {
                        if (!puedeDibujar) return;
                        int x = Math.Min(inicioX, e.X);
                        int y = Math.Min(inicioY, e.Y);
                        int width = Math.Max(inicioX, e.X) - Math.Min(inicioX, e.X);
                        int height = Math.Max(inicioY, e.Y) - Math.Min(inicioY, e.Y);
                        circulo = new Rectangle(x, y, width, height);
                        Refresh();

                    }
                    else
                    {
                        if (hacerCuadroRelleno == true)
                        {
                            if (!puedeDibujar) return;
                            int x = Math.Min(inicioX, e.X);
                            int y = Math.Min(inicioY, e.Y);
                            int width = Math.Max(inicioX, e.X) - Math.Min(inicioX, e.X);
                            int height = Math.Max(inicioY, e.Y) - Math.Min(inicioY, e.Y);
                            cuadroRelleno = new Rectangle(x, y, width, height);
                            Refresh();
                        }
                        else
                        {
                            if (hacerCirculoRelleno == true)
                            {
                                if (!puedeDibujar) return;
                                int x = Math.Min(inicioX, e.X);
                                int y = Math.Min(inicioY, e.Y);
                                int width = Math.Max(inicioX, e.X) - Math.Min(inicioX, e.X);
                                int height = Math.Max(inicioY, e.Y) - Math.Min(inicioY, e.Y);
                                circuloRelleno = new Rectangle(x, y, width, height);
                                Refresh();
                            }
                            else
                            {
                                if (borrar == true)
                                {
                                    if (numero == 1)
                                    {
                                        final = e.Location;
                                        graficos = this.CreateGraphics();
                                        graficos.DrawLine(borrarLineas, inicio, final);
                                    }
                                    inicio = final;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                objDrawingSurface = new Bitmap(this.Width, this.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                rectBounds1 = new Rectangle(0, 0, this.Width, this.Height);
                this.DrawToBitmap(objDrawingSurface, rectBounds1);
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "JPG Files (*.JPG) |*.JPG";
                if ((sfd.ShowDialog() == DialogResult.OK))
                {
                    objDrawingSurface.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Desea salir del MiniPaint?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Graphics graphics = this.CreateGraphics();
                Image image = new Bitmap(openDialog.FileName);
                graphics.DrawImage(image, new Point(0, 0));
            }
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            dibujar = true;
            hacerCuadro = false;
            hacerCirculo = false;
            hacerCuadroRelleno = false;
            hacerCirculoRelleno = false;
            borrar = false;
            colorearFondo = false;
        }

        private void btnCuadro_Click(object sender, EventArgs e)
        {
            dibujar = false;
            hacerCuadro = true;
            hacerCirculo = false;
            hacerCuadroRelleno = false;
            hacerCirculoRelleno = false;
            borrar = false;
            colorearFondo = false;
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            dibujar = false;
            hacerCuadro = false;
            hacerCirculo = true;
            hacerCuadroRelleno = false;
            hacerCirculoRelleno = false;
            borrar = false;
            colorearFondo = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dibujar = false;
            hacerCuadro = false;
            hacerCirculo = false;
            hacerCuadroRelleno = false;
            hacerCirculoRelleno = true;
            borrar = false;
            colorearFondo = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dibujar = false;
            hacerCuadro = false;
            hacerCirculo = false;
            hacerCuadroRelleno = false;
            hacerCirculoRelleno = false;
            borrar = true;
            colorearFondo = false;
        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            dibujar = false;
            hacerCuadro = false;
            hacerCirculo = false;
            hacerCuadroRelleno = false;
            hacerCirculoRelleno = false;
            borrar = false;
            colorearFondo = true;
        }

        private void btnCuadroRelleno_Click(object sender, EventArgs e)
        {
            dibujar = false;
            hacerCuadro = false;
            hacerCirculo = false;
            hacerCuadroRelleno = true;
            hacerCirculoRelleno = false;
            borrar = false;
            colorearFondo = false;
        }
    }
}
