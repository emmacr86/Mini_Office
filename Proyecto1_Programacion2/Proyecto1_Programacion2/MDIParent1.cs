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
    public partial class MDIMenuPrincipal : Form
    {

        public MDIMenuPrincipal()
        {
            InitializeComponent();
        }

        public void CreateChildForm(Form childForm)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Desea Salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void notePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotePad objNotepad = new NotePad();
            objNotepad.MdiParent = this;
            CreateChildForm(objNotepad);
        }

        private void visorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisorFRM objVisor = new VisorFRM();
            objVisor.MdiParent = this;
            CreateChildForm(objVisor);
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMPaint objPaint = new FRMPaint();
            objPaint.MdiParent = this;
            CreateChildForm(objPaint);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NotePad objNotepad = new NotePad();
            objNotepad.MdiParent = this;
            CreateChildForm(objNotepad);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            VisorFRM objVisor = new VisorFRM();
            objVisor.MdiParent = this;
            CreateChildForm(objVisor);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FRMPaint objPaint = new FRMPaint();
            objPaint.MdiParent = this;
            CreateChildForm(objPaint);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox objAboutBox = new AboutBox();
            objAboutBox.Show();
        }
    }
}
