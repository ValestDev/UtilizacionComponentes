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
            // Navega a la dirección especificada en la barra de búsqueda
            webBrowser2.Navigate(txt_buscador.Text);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Cierra la ventana actual del navegador
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Retrocede una página en el historial del navegador
            webBrowser2.GoBack();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // Avanza una página en el historial del navegador
            webBrowser2.GoForward();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            // Refresca la página actual en el navegador
            webBrowser2.Refresh();
        }
    }
}
