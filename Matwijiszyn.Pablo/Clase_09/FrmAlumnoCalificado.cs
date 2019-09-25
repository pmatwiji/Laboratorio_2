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
    public partial class FrmAlumnoCalificado : FrmAlumno
    {

        public AlumnoCalificado alumnoCalificado;

        

        public AlumnoCalificado UnAlumnoCalificado
        {
            get { return this.alumnoCalificado; }
        }

        


        public FrmAlumnoCalificado()
        {
            InitializeComponent();
            
        }

        private void FrmAlumnoCalificado_Load(object sender, EventArgs e)
        {

             

        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            this.alumnoCalificado = new AlumnoCalificado(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtLegajo.Text), (ETipoExamen)this.cmbTipoDeExamen.SelectedItem, Convert.ToDouble(this.txtNota.Text));
            this.DialogResult = DialogResult.OK;
        }
    }
}
