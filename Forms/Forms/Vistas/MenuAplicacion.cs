using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Vistas
{
    public partial class MenuAplicacion : Form
    {
        public MenuAplicacion()
        {
            InitializeComponent();
        }

        private void MenuAplicacion_Load(object sender, EventArgs e)
        {

        }

        private void formularioEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();

            estudiante.MdiParent = this;
            estudiante.Show();
        }

        private void formularioDivisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDivision frmDivision = new FrmDivision();
            frmDivision.MdiParent = this;
            frmDivision.Show();
        }

        private void formularioMultiplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMultiplicacion frmMultiplicacion = new FrmMultiplicacion();
            frmMultiplicacion.MdiParent = this;
            frmMultiplicacion.Show();
        }

        private void formularioRestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmResta frmResta = new FrmResta();
            frmResta.MdiParent = this;
            frmResta.Show();
        }

        private void formularioSumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSuma frmSuma = new FrmSuma();
            frmSuma.MdiParent = this;
            frmSuma.Show();
        }
    }
}
