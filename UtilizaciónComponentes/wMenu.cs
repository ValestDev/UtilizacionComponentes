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
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void btn_reproductor_Click(object sender, EventArgs e)
        {
            Form Reproductor = new wReproductor();
            
            Reproductor.Show();

        }

        private void btn_lector_pdf_Click(object sender, EventArgs e)
        {
            Form Lector = new wLectorpdf();
            
            Lector.Show();
        }

        private void btn_navegador_Click(object sender, EventArgs e)
        {
            Form Navegador = new wNavegador();
            Navegador.Show();
        }

        private void Frm1_Load(object sender, EventArgs e)
        {

        }
    }
}
