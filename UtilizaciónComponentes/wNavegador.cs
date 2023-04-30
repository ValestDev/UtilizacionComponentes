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
    public partial class wNavegador : Form
    {
        public wNavegador()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate(txt_buscador.Text);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            webBrowser2.Refresh();
        }
    }
}
