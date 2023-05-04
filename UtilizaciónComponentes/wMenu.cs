using System; // directiva de uso del espacio de nombres System
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // directiva de uso del espacio de nombres Windows Forms

namespace UtilizaciónComponentes
{
    public partial class Frm1 : Form
    {
        /// <summary>
        /// Constructor de la clase Frm1
        /// </summary>
        public Frm1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Controlador de eventos del botón "Reproductor".
        /// Abre una nueva instancia de la clase wReproductor y muestra el formulario.
        /// </summary>
        private void btn_reproductor_Click(object sender, EventArgs e)
        {
            Form Reproductor = new wReproductor();
            Reproductor.Show();
        }

        /// <summary>
        /// Controlador de eventos del botón "Lector PDF".
        /// Abre una nueva instancia de la clase wLectorpdf y muestra el formulario.
        /// </summary>
        private void btn_lector_pdf_Click(object sender, EventArgs e)
        {
            Form Lector = new wLectorpdf();
            Lector.Show();
        }

        /// <summary>
        /// Controlador de eventos del botón "Navegador".
        /// Abre una nueva instancia de la clase wNavegador y muestra el formulario.
        /// </summary>
        private void btn_navegador_Click(object sender, EventArgs e)
        {
            Form Navegador = new wNavegador();
            Navegador.Show();
        }

       
    }
}
