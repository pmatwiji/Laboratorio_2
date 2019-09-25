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
    public partial class FrmCatedra : Form
    {
        private Catedra catedra = new Catedra();
        public List<Alumno> listaAlumnos = new List<Alumno>();
        

        public FrmCatedra()
        {
            InitializeComponent();
        }

        private void FrmCatedra_Load(object sender, EventArgs e)
        {
            foreach (ETipoOrdenamiento ordenamiento in Enum.GetValues(typeof(ETipoOrdenamiento)))
            {
                this.cmbOrdenamiento.Items.Add(ordenamiento);
            }

            this.cmbOrdenamiento.SelectedItem = ETipoOrdenamiento.LegajoAscendente;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlumno frmAlumno = new FrmAlumno();
            Alumno alumno;
            bool LegajoDuplicado = false;
            frmAlumno.ShowDialog();

            if (frmAlumno.DialogResult == DialogResult.OK)
            {
                alumno = frmAlumno.UnAlumno;
                foreach(Alumno MiAlumno in catedra.Alumnos)
                {
                    if(MiAlumno.Legajo == alumno.Legajo)
                    {
                        MessageBox.Show("El legajo ya existe, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LegajoDuplicado = true;
                        break;
                    }
                }
                if(LegajoDuplicado != true)
                {
                    catedra.Alumnos.Add(alumno);
                    MessageBox.Show("Alumno cargado con exito", "Carga de Alumno", MessageBoxButtons.OK);
                }
                
            }

            ImprimirLista();
        }

        private void cmbOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarListadoAlumnos();
        }

        private void ActualizarListadoAlumnos()
        {
            switch (this.cmbOrdenamiento.SelectedItem)
            {
                case ETipoOrdenamiento.ApellidoAscendente:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorApellidoAsc);
                    ImprimirLista();
                    break;

                case ETipoOrdenamiento.ApellidoDescendente:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorApellidoDesc);
                    ImprimirLista();
                    break;

                case ETipoOrdenamiento.LegajoAscendente:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorLegajoAsc);
                    ImprimirLista();
                    break;

                case ETipoOrdenamiento.LegajoDescendente:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorLegajoDesc);
                    ImprimirLista();
                    break;

            }
        }

        private void ImprimirLista()
        {
            this.lstAlumnos.Items.Clear();
            foreach (Alumno auxiliar in catedra.Alumnos)
            {
                this.lstAlumnos.Items.Add(auxiliar);
            }
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            FrmAlumnoCalificado frmAlumnoCalificado = new FrmAlumnoCalificado();
            if (this.lstAlumnos.SelectedItem != null)
            {
                frmAlumnoCalificado.txtNombre.Text = this.catedra.Alumnos[this.lstAlumnos.SelectedIndex].Nombre;
                frmAlumnoCalificado.txtNombre.Enabled = false;
                frmAlumnoCalificado.txtApellido.Text = this.catedra.Alumnos[this.lstAlumnos.SelectedIndex].Apellido;
                frmAlumnoCalificado.txtApellido.Enabled = false;
                frmAlumnoCalificado.txtLegajo.Text = this.catedra.Alumnos[this.lstAlumnos.SelectedIndex].Legajo.ToString();
                frmAlumnoCalificado.txtLegajo.Enabled = false;
                frmAlumnoCalificado.cmbTipoDeExamen.Text = this.catedra.Alumnos[this.lstAlumnos.SelectedIndex].Examen.ToString();
                frmAlumnoCalificado.cmbTipoDeExamen.Enabled = false;
                frmAlumnoCalificado.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un alumno a calificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(frmAlumnoCalificado.DialogResult == DialogResult.OK)
            {
                this.listaAlumnos.Add(frmAlumnoCalificado.UnAlumnoCalificado);
                this.catedra.Alumnos.Remove(catedra.Alumnos[this.lstAlumnos.SelectedIndex]);
                this.ActualizarListadoAlumnos();

                lstAlumnosCalificados.Items.Clear();

                foreach(AlumnoCalificado calificado in this.listaAlumnos)
                {
                    this.lstAlumnosCalificados.Items.Add(calificado);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            

            FrmAlumno frmAlumno = new FrmAlumno();
            if (this.lstAlumnos.SelectedItem != null)
            {
                frmAlumno.txtNombre.Text = this.catedra.Alumnos[this.lstAlumnos.SelectedIndex].Nombre;
                frmAlumno.txtApellido.Text = this.catedra.Alumnos[this.lstAlumnos.SelectedIndex].Apellido;
                frmAlumno.txtLegajo.Text = this.catedra.Alumnos[this.lstAlumnos.SelectedIndex].Legajo.ToString();
                frmAlumno.txtLegajo.Enabled = false;
                frmAlumno.cmbTipoDeExamen.Text = this.catedra.Alumnos[this.lstAlumnos.SelectedIndex].Examen.ToString();
                frmAlumno.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un alumno a modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(frmAlumno.DialogResult == DialogResult.OK)
            {
                this.catedra.Alumnos[this.lstAlumnos.SelectedIndex] = frmAlumno.UnAlumno;
                this.ActualizarListadoAlumnos();
            }
            
            
             
        }
    }
}

