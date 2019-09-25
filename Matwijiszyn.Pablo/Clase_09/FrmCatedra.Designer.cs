namespace Clase_09
{
    partial class FrmCatedra
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
            this.grpAlumnos = new System.Windows.Forms.GroupBox();
            this.cmbOrdenamiento = new System.Windows.Forms.ComboBox();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpAlumnosCalificados = new System.Windows.Forms.GroupBox();
            this.lstAlumnosCalificados = new System.Windows.Forms.ListBox();
            this.grpAlumnos.SuspendLayout();
            this.grpAlumnosCalificados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAlumnos
            // 
            this.grpAlumnos.Controls.Add(this.cmbOrdenamiento);
            this.grpAlumnos.Controls.Add(this.lstAlumnos);
            this.grpAlumnos.Controls.Add(this.btnModificar);
            this.grpAlumnos.Controls.Add(this.btnCalificar);
            this.grpAlumnos.Controls.Add(this.btnAgregar);
            this.grpAlumnos.Location = new System.Drawing.Point(12, 12);
            this.grpAlumnos.Name = "grpAlumnos";
            this.grpAlumnos.Size = new System.Drawing.Size(492, 239);
            this.grpAlumnos.TabIndex = 0;
            this.grpAlumnos.TabStop = false;
            this.grpAlumnos.Text = "Alumnos";
            // 
            // cmbOrdenamiento
            // 
            this.cmbOrdenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenamiento.FormattingEnabled = true;
            this.cmbOrdenamiento.Location = new System.Drawing.Point(21, 202);
            this.cmbOrdenamiento.Name = "cmbOrdenamiento";
            this.cmbOrdenamiento.Size = new System.Drawing.Size(447, 21);
            this.cmbOrdenamiento.TabIndex = 4;
            this.cmbOrdenamiento.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenamiento_SelectedIndexChanged);
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.Location = new System.Drawing.Point(21, 48);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(447, 147);
            this.lstAlumnos.TabIndex = 3;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(393, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(208, 19);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(75, 23);
            this.btnCalificar.TabIndex = 1;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grpAlumnosCalificados
            // 
            this.grpAlumnosCalificados.Controls.Add(this.lstAlumnosCalificados);
            this.grpAlumnosCalificados.Location = new System.Drawing.Point(12, 257);
            this.grpAlumnosCalificados.Name = "grpAlumnosCalificados";
            this.grpAlumnosCalificados.Size = new System.Drawing.Size(492, 210);
            this.grpAlumnosCalificados.TabIndex = 1;
            this.grpAlumnosCalificados.TabStop = false;
            this.grpAlumnosCalificados.Text = "Alumnos Calificados";
            // 
            // lstAlumnosCalificados
            // 
            this.lstAlumnosCalificados.FormattingEnabled = true;
            this.lstAlumnosCalificados.Location = new System.Drawing.Point(21, 19);
            this.lstAlumnosCalificados.Name = "lstAlumnosCalificados";
            this.lstAlumnosCalificados.Size = new System.Drawing.Size(447, 173);
            this.lstAlumnosCalificados.TabIndex = 4;
            // 
            // FrmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 483);
            this.Controls.Add(this.grpAlumnosCalificados);
            this.Controls.Add(this.grpAlumnos);
            this.Name = "FrmCatedra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCatedra";
            this.Load += new System.EventHandler(this.FrmCatedra_Load);
            this.grpAlumnos.ResumeLayout(false);
            this.grpAlumnosCalificados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAlumnos;
        private System.Windows.Forms.ComboBox cmbOrdenamiento;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpAlumnosCalificados;
        private System.Windows.Forms.ListBox lstAlumnosCalificados;
        protected System.Windows.Forms.ListBox lstAlumnos;
    }
}