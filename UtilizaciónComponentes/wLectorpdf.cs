using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilizaciónComponentes
{
    public partial class wLectorpdf : Form
    {
        public wLectorpdf()
        {
            InitializeComponent();
        }

        private void abrirPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); // Abre menu desplegable 
            axAcroPDF1.src = openFileDialog1.FileName;// Abre el archivo y lo despliega en el visualizador
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar el programa?", "Cerrar programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Cierra la ventana actual

            }
        }
    }
}
