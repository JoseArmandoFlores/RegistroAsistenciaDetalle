using RegistroAsistenciasDetalle.UI.Consultas;
using RegistroAsistenciasDetalle.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAsistenciasDetalle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAsistencias asistencia = new rAsistencias();
            asistencia.MdiParent = this;
            asistencia.Show();
        }

        private void AsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cAsignaturas asignaturas = new cAsignaturas();
            asignaturas.MdiParent = this;
            asignaturas.Show();
        }

        private void AsistenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cAsistencias asistencia = new cAsistencias();
            asistencia.MdiParent = this;
            asistencia.Show();
        }

        private void AsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cEstudiantes estudiante = new cEstudiantes();
            estudiante.MdiParent = this;
            estudiante.Show();
        }

        private void EstudiantesDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cEstudiantesDetalle estudiante = new cEstudiantesDetalle();
            estudiante.MdiParent = this;
            estudiante.Show();
        }
    }
}
