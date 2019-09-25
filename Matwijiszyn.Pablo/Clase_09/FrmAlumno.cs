using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_09.Entidades;

namespace Clase_09
{
    public partial class FrmAlumno : Form
    {
        public Alumno alumno;

        public Alumno UnAlumno
        {
            get
            {
                return this.alumno;
            }
        }

        public FrmAlumno()
        {
            InitializeComponent();
        }

        private void FrmAlumno_Load(object sender, EventArgs e)
        {
            foreach (ETipoExamen examen in Enum.GetValues(typeof(ETipoExamen)))
            {
                this.cmbTipoDeExamen.Items.Add(examen);
            }

            this.cmbTipoDeExamen.SelectedItem = ETipoExamen.Final;
        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            alumno = new Alumno(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtLegajo.Text), (ETipoExamen)this.cmbTipoDeExamen.SelectedItem);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
