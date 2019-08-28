namespace Clase_04.WindowsForm
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
            this.labelEntero = new System.Windows.Forms.Label();
            this.labelCadena = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.txtEntero = new System.Windows.Forms.TextBox();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lstMostrar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelEntero
            // 
            this.labelEntero.AutoSize = true;
            this.labelEntero.Location = new System.Drawing.Point(30, 35);
            this.labelEntero.Name = "labelEntero";
            this.labelEntero.Size = new System.Drawing.Size(38, 13);
            this.labelEntero.TabIndex = 0;
            this.labelEntero.Text = "Entero";
            // 
            // labelCadena
            // 
            this.labelCadena.AutoSize = true;
            this.labelCadena.Location = new System.Drawing.Point(30, 72);
            this.labelCadena.Name = "labelCadena";
            this.labelCadena.Size = new System.Drawing.Size(44, 13);
            this.labelCadena.TabIndex = 1;
            this.labelCadena.Text = "Cadena";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(30, 110);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 1;
            this.labelFecha.Text = "Fecha";
            // 
            // txtEntero
            // 
            this.txtEntero.Location = new System.Drawing.Point(88, 35);
            this.txtEntero.Name = "txtEntero";
            this.txtEntero.Size = new System.Drawing.Size(169, 20);
            this.txtEntero.TabIndex = 2;
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(88, 72);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(169, 20);
            this.txtCadena.TabIndex = 2;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(88, 110);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(169, 20);
            this.txtFecha.TabIndex = 2;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(99, 270);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lstMostrar
            // 
            this.lstMostrar.FormattingEnabled = true;
            this.lstMostrar.Location = new System.Drawing.Point(33, 157);
            this.lstMostrar.Name = "lstMostrar";
            this.lstMostrar.Size = new System.Drawing.Size(224, 95);
            this.lstMostrar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 320);
            this.Controls.Add(this.lstMostrar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.txtEntero);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelCadena);
            this.Controls.Add(this.labelEntero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEntero;
        private System.Windows.Forms.Label labelCadena;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox txtEntero;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ListBox lstMostrar;
    }
}

