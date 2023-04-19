using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador_WEB
{
    public partial class Frm3 : Form
    {
        public Frm3()
        {
            InitializeComponent();
        }

        private void btn_ir_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txt_buscar.Text);    
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Environment.Exit(0);
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();

        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
