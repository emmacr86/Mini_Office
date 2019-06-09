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
    public partial class NotePad : Form
    {
        public NotePad()
        {
            InitializeComponent();
        }


        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string archivo;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
            archivo = file.ReadLine();
            textBoxPrincipal.Text = archivo.ToString();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Sin Titulo.txt";
            var guardarArchivo = saveFileDialog1.ShowDialog();
            if (guardarArchivo == DialogResult.OK)
            {
                using (var Savefile = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    Savefile.WriteLine(textBoxPrincipal.Text);
                }
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var color = colorDialog1.ShowDialog();
            if (color == DialogResult.OK)
            {
                textBoxPrincipal.ForeColor = colorDialog1.Color;
            }
        }

        private void letraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formato = fontDialog1.ShowDialog();
            if (formato == DialogResult.OK)
            {
                textBoxPrincipal.Font = fontDialog1.Font;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Desea salir del NotePad?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxPrincipal.Cut();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxPrincipal.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxPrincipal.Paste();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotePad objNotePad = new NotePad();
            objNotePad.MdiParent = this.ParentForm;
            objNotePad.Show();
        }

        private void impresoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
