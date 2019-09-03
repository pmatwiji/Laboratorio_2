using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase__04.Entidades;

namespace Clase_04.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            int entero = int.Parse(this.txtEntero.Text);
            string cadena = this.txtCadena.Text;
            DateTime fecha = Convert.ToDateTime(this.txtFecha.Text);

            Cosa MiCosa = new Cosa(cadena,fecha,entero);

            MessageBox.Show(MiCosa.Mostrar());

            lstMostrar.Items.Add(MiCosa.Mostrar());
        }

        
    }
}
