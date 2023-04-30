namespace UtilizaciónComponentes
{
    partial class wReproductor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wReproductor));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.btn_reproducir = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            this.btn_pausar = new System.Windows.Forms.Button();
            this.lbl_ruta = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_volver1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(2, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1104, 458);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(12, 479);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(75, 23);
            this.btn_cargar.TabIndex = 1;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // btn_reproducir
            // 
            this.btn_reproducir.Location = new System.Drawing.Point(93, 479);
            this.btn_reproducir.Name = "btn_reproducir";
            this.btn_reproducir.Size = new System.Drawing.Size(75, 23);
            this.btn_reproducir.TabIndex = 2;
            this.btn_reproducir.Text = "Reproducir";
            this.btn_reproducir.UseVisualStyleBackColor = true;
            this.btn_reproducir.Click += new System.EventHandler(this.btn_reproducir_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.Location = new System.Drawing.Point(174, 479);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(75, 23);
            this.btn_parar.TabIndex = 3;
            this.btn_parar.Text = "Parar";
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // btn_pausar
            // 
            this.btn_pausar.Location = new System.Drawing.Point(255, 479);
            this.btn_pausar.Name = "btn_pausar";
            this.btn_pausar.Size = new System.Drawing.Size(75, 23);
            this.btn_pausar.TabIndex = 4;
            this.btn_pausar.Text = "Pausar";
            this.btn_pausar.UseVisualStyleBackColor = true;
            this.btn_pausar.Click += new System.EventHandler(this.btn_pausar_Click);
            // 
            // lbl_ruta
            // 
            this.lbl_ruta.AutoSize = true;
            this.lbl_ruta.Location = new System.Drawing.Point(12, 522);
            this.lbl_ruta.Name = "lbl_ruta";
            this.lbl_ruta.Size = new System.Drawing.Size(30, 13);
            this.lbl_ruta.TabIndex = 5;
            this.lbl_ruta.Text = "Ruta";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_volver1
            // 
            this.btn_volver1.Location = new System.Drawing.Point(374, 479);
            this.btn_volver1.Name = "btn_volver1";
            this.btn_volver1.Size = new System.Drawing.Size(121, 23);
            this.btn_volver1.TabIndex = 6;
            this.btn_volver1.Text = "Volver al menú";
            this.btn_volver1.UseVisualStyleBackColor = true;
            this.btn_volver1.Click += new System.EventHandler(this.btn_volver1_Click);
            // 
            // wReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 612);
            this.Controls.Add(this.btn_volver1);
            this.Controls.Add(this.lbl_ruta);
            this.Controls.Add(this.btn_pausar);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.btn_reproducir);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "wReproductor";
            this.Text = "Reprodutor Multimedia";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btn_reproducir;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.Button btn_pausar;
        private System.Windows.Forms.Label lbl_ruta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_volver1;
    }
}