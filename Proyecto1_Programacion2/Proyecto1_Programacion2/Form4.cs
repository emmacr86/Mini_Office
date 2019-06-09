using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_Programacion2
{
    public partial class VisorFRM : Form
    {

        public VisorFRM()
        {
            InitializeComponent();
        }
        List<String> archivosListView = new List<string>();
        protected string[] cantidadArchivos;
        protected int imagenActual = -1;

        protected void ShowCurrentImage()
        {
            if (imagenActual >= 0 && imagenActual <= cantidadArchivos.Length - 1)
            {
                pictureBoxImagen.Image = Bitmap.FromFile(cantidadArchivos[imagenActual]);
            }
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog objOpenFileDialog = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "JPEG|*.jpg" })
            {
                if (objOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    archivosListView.Clear();
                    listViewFile.Items.Clear();
                    foreach (String fileName in objOpenFileDialog.FileNames)
                    {
                        FileInfo fi = new FileInfo(fileName);
                        archivosListView.Add(fi.FullName);
                        listViewFile.Items.Add(fi.Name, 0);
                        cantidadArchivos = objOpenFileDialog.FileNames;
                        imagenActual = 0;
                        ShowCurrentImage();
                    }
                }
            }
        }

        private void listViewFile_ItemActivate(object sender, EventArgs e)
        {
            if (listViewFile.FocusedItem != null)
            {
                Image img = Image.FromFile(archivosListView[listViewFile.FocusedItem.Index]);
                pictureBoxImagen.Image = img;
                imagenActual = listViewFile.FocusedItem.Index; 
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Desea salir del Visor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (cantidadArchivos.Length > 0)
            {
                imagenActual = imagenActual == 0 ? cantidadArchivos.Length - 1 : --imagenActual;
                ShowCurrentImage();
            }
        }

        private void btnFoward_Click(object sender, EventArgs e)
        {
            if (cantidadArchivos.Length > 0)
            {
                imagenActual = imagenActual == cantidadArchivos.Length - 1 ? 0 : ++imagenActual;
                ShowCurrentImage();
            }
        }
    }
}
