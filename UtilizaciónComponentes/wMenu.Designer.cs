namespace UtilizaciónComponentes
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
            this.btn_reproductor = new System.Windows.Forms.Button();
            this.btn_lector_pdf = new System.Windows.Forms.Button();
            this.btn_navegador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_reproductor
            // 
            this.btn_reproductor.Location = new System.Drawing.Point(66, 50);
            this.btn_reproductor.Name = "btn_reproductor";
            this.btn_reproductor.Size = new System.Drawing.Size(179, 57);
            this.btn_reproductor.TabIndex = 0;
            this.btn_reproductor.Text = "Reproductor Multimedia";
            this.btn_reproductor.UseVisualStyleBackColor = true;
            this.btn_reproductor.Click += new System.EventHandler(this.btn_reproductor_Click);
            // 
            // btn_lector_pdf
            // 
            this.btn_lector_pdf.Location = new System.Drawing.Point(286, 50);
            this.btn_lector_pdf.Name = "btn_lector_pdf";
            this.btn_lector_pdf.Size = new System.Drawing.Size(179, 57);
            this.btn_lector_pdf.TabIndex = 1;
            this.btn_lector_pdf.Text = "Lector PDF";
            this.btn_lector_pdf.UseVisualStyleBackColor = true;
            this.btn_lector_pdf.Click += new System.EventHandler(this.btn_lector_pdf_Click);
            // 
            // btn_navegador
            // 
            this.btn_navegador.Location = new System.Drawing.Point(504, 50);
            this.btn_navegador.Name = "btn_navegador";
            this.btn_navegador.Size = new System.Drawing.Size(179, 57);
            this.btn_navegador.TabIndex = 2;
            this.btn_navegador.Text = "Navegador Web";
            this.btn_navegador.UseVisualStyleBackColor = true;
            this.btn_navegador.Click += new System.EventHandler(this.btn_navegador_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 196);
            this.Controls.Add(this.btn_navegador);
            this.Controls.Add(this.btn_lector_pdf);
            this.Controls.Add(this.btn_reproductor);
            this.Name = "Frm1";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Frm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_reproductor;
        private System.Windows.Forms.Button btn_lector_pdf;
        private System.Windows.Forms.Button btn_navegador;
    }
}

