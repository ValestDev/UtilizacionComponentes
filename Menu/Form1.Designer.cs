namespace Menu
{
    partial class frm4
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
            this.btn_reproductor = new System.Windows.Forms.Button();
            this.btn_navegador = new System.Windows.Forms.Button();
            this.btn_lector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_reproductor
            // 
            this.btn_reproductor.Location = new System.Drawing.Point(52, 44);
            this.btn_reproductor.Name = "btn_reproductor";
            this.btn_reproductor.Size = new System.Drawing.Size(192, 67);
            this.btn_reproductor.TabIndex = 0;
            this.btn_reproductor.Text = "Reproductor Multimedia";
            this.btn_reproductor.UseVisualStyleBackColor = true;
            this.btn_reproductor.Click += new System.EventHandler(this.btn_reproductor_Click);
            // 
            // btn_navegador
            // 
            this.btn_navegador.Location = new System.Drawing.Point(292, 44);
            this.btn_navegador.Name = "btn_navegador";
            this.btn_navegador.Size = new System.Drawing.Size(192, 67);
            this.btn_navegador.TabIndex = 1;
            this.btn_navegador.Text = "Navegador Web";
            this.btn_navegador.UseVisualStyleBackColor = true;
            // 
            // btn_lector
            // 
            this.btn_lector.Location = new System.Drawing.Point(524, 44);
            this.btn_lector.Name = "btn_lector";
            this.btn_lector.Size = new System.Drawing.Size(192, 67);
            this.btn_lector.TabIndex = 2;
            this.btn_lector.Text = "Lector PDF";
            this.btn_lector.UseVisualStyleBackColor = true;
            // 
            // frm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 204);
            this.Controls.Add(this.btn_lector);
            this.Controls.Add(this.btn_navegador);
            this.Controls.Add(this.btn_reproductor);
            this.Name = "frm4";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_reproductor;
        private System.Windows.Forms.Button btn_navegador;
        private System.Windows.Forms.Button btn_lector;
    }
}

