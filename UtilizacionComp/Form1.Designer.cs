namespace UtilizacionComp
{
    partial class Frm1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm1));
            this.btn_cargar = new System.Windows.Forms.Button();
            this.btn_reproducir = new System.Windows.Forms.Button();
            this.btn_pausar = new System.Windows.Forms.Button();
            this.lbl_ruta = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_parar = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(36, 520);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(75, 23);
            this.btn_cargar.TabIndex = 1;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // btn_reproducir
            // 
            this.btn_reproducir.Location = new System.Drawing.Point(117, 520);
            this.btn_reproducir.Name = "btn_reproducir";
            this.btn_reproducir.Size = new System.Drawing.Size(75, 23);
            this.btn_reproducir.TabIndex = 2;
            this.btn_reproducir.Text = "Reproducir ";
            this.btn_reproducir.UseVisualStyleBackColor = true;
            this.btn_reproducir.Click += new System.EventHandler(this.btn_reproducir_Click);
            // 
            // btn_pausar
            // 
            this.btn_pausar.Location = new System.Drawing.Point(279, 520);
            this.btn_pausar.Name = "btn_pausar";
            this.btn_pausar.Size = new System.Drawing.Size(75, 23);
            this.btn_pausar.TabIndex = 3;
            this.btn_pausar.Text = "Pausar";
            this.btn_pausar.UseVisualStyleBackColor = true;
            this.btn_pausar.Click += new System.EventHandler(this.btn_pausar_Click);
            // 
            // lbl_ruta
            // 
            this.lbl_ruta.AutoSize = true;
            this.lbl_ruta.Location = new System.Drawing.Point(35, 562);
            this.lbl_ruta.Name = "lbl_ruta";
            this.lbl_ruta.Size = new System.Drawing.Size(76, 13);
            this.lbl_ruta.TabIndex = 4;
            this.lbl_ruta.Text = "Ruta del video";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*";
            // 
            // btn_parar
            // 
            this.btn_parar.Location = new System.Drawing.Point(198, 520);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(75, 23);
            this.btn_parar.TabIndex = 5;
            this.btn_parar.Text = "Parar";
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(36, -7);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1067, 521);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 652);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.lbl_ruta);
            this.Controls.Add(this.btn_pausar);
            this.Controls.Add(this.btn_reproducir);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Frm1";
            this.Text = "Reproductor";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btn_reproducir;
        private System.Windows.Forms.Button btn_pausar;
        private System.Windows.Forms.Label lbl_ruta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_parar;
        private System.Diagnostics.EventLog eventLog1;
    }
}

