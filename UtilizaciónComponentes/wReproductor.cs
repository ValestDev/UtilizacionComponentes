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
    public partial class wReproductor : Form
    {
        private string ruta = ""; // Ruta del archivo a reproducir

        public wReproductor()
        {
            InitializeComponent();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            // Abre un cuadro de dialogo para seleccionar un archivo de audio o video
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName; // Obtiene la ruta del archivo seleccionado
                lbl_ruta.Text = ruta; // Muestra la ruta en un label
            }
        }

        private void btn_reproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta; // Establece la ruta del archivo en el reproductor
            axWindowsMediaPlayer1.Ctlcontrols.play(); // Reproduce el archivo
        }

        private void btn_parar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop(); // Detiene la reproducción del archivo
        }

        private void btn_pausar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause(); // Pausa la reproducción del archivo
        }

        private void btn_volver1_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana del reproductor
        }
    }
}
