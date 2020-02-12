namespace Estadistica
{
    partial class Form1
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
            this.btnMediaAritmetica = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblRespuesta_Serie = new System.Windows.Forms.Label();
            this.btnCalcularEstandar = new System.Windows.Forms.Button();
            this.btnCalcularTipica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMediaAritmetica
            // 
            this.btnMediaAritmetica.Location = new System.Drawing.Point(12, 157);
            this.btnMediaAritmetica.Name = "btnMediaAritmetica";
            this.btnMediaAritmetica.Size = new System.Drawing.Size(104, 23);
            this.btnMediaAritmetica.TabIndex = 0;
            this.btnMediaAritmetica.Text = "Calcular X";
            this.btnMediaAritmetica.UseVisualStyleBackColor = true;
            this.btnMediaAritmetica.Click += new System.EventHandler(this.btnMediaAritmetica_Click);
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(74, 36);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(199, 20);
            this.txtSerie.TabIndex = 1;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(26, 39);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(42, 13);
            this.lblSerie.TabIndex = 2;
            this.lblSerie.Text = "SERIE:";
            // 
            // lblRespuesta_Serie
            // 
            this.lblRespuesta_Serie.AutoSize = true;
            this.lblRespuesta_Serie.Location = new System.Drawing.Point(26, 90);
            this.lblRespuesta_Serie.Name = "lblRespuesta_Serie";
            this.lblRespuesta_Serie.Size = new System.Drawing.Size(14, 13);
            this.lblRespuesta_Serie.TabIndex = 3;
            this.lblRespuesta_Serie.Text = "X";
            // 
            // btnCalcularEstandar
            // 
            this.btnCalcularEstandar.Location = new System.Drawing.Point(122, 157);
            this.btnCalcularEstandar.Name = "btnCalcularEstandar";
            this.btnCalcularEstandar.Size = new System.Drawing.Size(104, 23);
            this.btnCalcularEstandar.TabIndex = 4;
            this.btnCalcularEstandar.Text = "Calcular Estandar";
            this.btnCalcularEstandar.UseVisualStyleBackColor = true;
            this.btnCalcularEstandar.Click += new System.EventHandler(this.btnCalcularEstandar_Click);
            // 
            // btnCalcularTipica
            // 
            this.btnCalcularTipica.Location = new System.Drawing.Point(232, 157);
            this.btnCalcularTipica.Name = "btnCalcularTipica";
            this.btnCalcularTipica.Size = new System.Drawing.Size(104, 23);
            this.btnCalcularTipica.TabIndex = 5;
            this.btnCalcularTipica.Text = "Calcular Tipica";
            this.btnCalcularTipica.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 289);
            this.Controls.Add(this.btnCalcularTipica);
            this.Controls.Add(this.btnCalcularEstandar);
            this.Controls.Add(this.lblRespuesta_Serie);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.btnMediaAritmetica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMediaAritmetica;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblRespuesta_Serie;
        private System.Windows.Forms.Button btnCalcularEstandar;
        private System.Windows.Forms.Button btnCalcularTipica;
    }
}

