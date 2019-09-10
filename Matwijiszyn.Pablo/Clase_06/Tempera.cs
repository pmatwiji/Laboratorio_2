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
    public partial class Tempera : Form
    {
        private Entidades.Tempera tempera;

        public Entidades.Tempera MiTempera
        {
            get { return tempera; }
        }

        public Tempera()
        {
            InitializeComponent();
        }

        private void Tempera_Load(object sender, EventArgs e)
        {
            foreach(ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cmbColor.Items.Add(color);
            }

            
            this.cmbColor.SelectedItem = ConsoleColor.Magenta;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Entidades.Tempera tempera = new Entidades.Tempera((ConsoleColor)this.cmbColor.SelectedItem, this.txtMarca.Text, int.Parse(this.txtCantidad.Text));
            
            MessageBox.Show(tempera);

            
        }
    }
}
