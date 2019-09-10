namespace Clase_06
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPaletaMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPaleta = new System.Windows.Forms.GroupBox();
            this.lstPaleta = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.grpPaleta.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearPaletaMnu});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // crearPaletaMnu
            // 
            this.crearPaletaMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperaToolStripMenuItem});
            this.crearPaletaMnu.Name = "crearPaletaMnu";
            this.crearPaletaMnu.Size = new System.Drawing.Size(180, 22);
            this.crearPaletaMnu.Text = "Crear Paleta";
            this.crearPaletaMnu.Click += new System.EventHandler(this.crearPaletaMnu_Click);
            // 
            // temperaToolStripMenuItem
            // 
            this.temperaToolStripMenuItem.Name = "temperaToolStripMenuItem";
            this.temperaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temperaToolStripMenuItem.Text = "Tempera";
            this.temperaToolStripMenuItem.Click += new System.EventHandler(this.temperaToolStripMenuItem_Click);
            // 
            // grpPaleta
            // 
            this.grpPaleta.Controls.Add(this.lstPaleta);
            this.grpPaleta.Location = new System.Drawing.Point(12, 27);
            this.grpPaleta.Name = "grpPaleta";
            this.grpPaleta.Size = new System.Drawing.Size(269, 211);
            this.grpPaleta.TabIndex = 1;
            this.grpPaleta.TabStop = false;
            this.grpPaleta.Text = "Paleta";
            // 
            // lstPaleta
            // 
            this.lstPaleta.FormattingEnabled = true;
            this.lstPaleta.Location = new System.Drawing.Point(6, 19);
            this.lstPaleta.Name = "lstPaleta";
            this.lstPaleta.Size = new System.Drawing.Size(257, 186);
            this.lstPaleta.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 263);
            this.Controls.Add(this.grpPaleta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clase 06";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpPaleta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPaletaMnu;
        private System.Windows.Forms.ToolStripMenuItem temperaToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpPaleta;
        private System.Windows.Forms.ListBox lstPaleta;
    }
}

