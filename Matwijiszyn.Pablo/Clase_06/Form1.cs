using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_06.Entidades;

namespace Clase_06
{
    public partial class Form1 : Form
    {
        Paleta miPaleta;

        public Form1()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.grpPaleta.Visible = false;
        }

        private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tempera frm = new Tempera();

            //frm.MdiParent = this;

            frm.ShowDialog();

            //this.miPaleta += frm.MiTempera;
            //this.lstPaleta.Items.Add(miPaleta);
        }

        private void crearPaletaMnu_Click(object sender, EventArgs e)
        {
            this.grpPaleta.Visible = true;
            //this.crearPaletaMnu.Enabled = false;
        }
    }
}
