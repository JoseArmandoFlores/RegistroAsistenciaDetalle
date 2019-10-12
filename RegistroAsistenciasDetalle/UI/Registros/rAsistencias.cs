using RegistroAsistenciasDetalle.BLL;
using RegistroAsistenciasDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAsistenciasDetalle.UI.Registros
{
    public partial class rAsistencias : Form
    {
        public List<EstudiantesDetalle> Detalle { set; get; }
        public rAsistencias()
        {
            InitializeComponent();
            this.Detalle = new List<EstudiantesDetalle>();
        }

        private void AgregarAsignaturaButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> Metodos = new RepositorioBase<Asignaturas>();

            rAsignaturas asignaturas = new rAsignaturas();
            asignaturas.ShowDialog();

            List<Asignaturas> ListaAsignaturas = new List<Asignaturas>();
            ListaAsignaturas = Metodos.GetList(p => true);

            foreach (var Item in ListaAsignaturas)
            {
                AsignaturaComboBox.Items.Add(Item.Nombre);
            }
        }

        private void AgregarEstudianteButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> Metodos = new RepositorioBase<Estudiantes>();

            rEstudiantes estudiantes = new rEstudiantes();
            estudiantes.ShowDialog();

            List<Estudiantes> ListaEstudiantes = new List<Estudiantes>();
            ListaEstudiantes = Metodos.GetList(p => true);
            
            foreach(var Item in ListaEstudiantes)
            {
                EstudianteComboBox.Items.Add(Item.Nombres);
            }
        }

        public void CargarGrid()
        {
            EstudiantesDataGridView.DataSource = null;
            EstudiantesDataGridView.DataSource = this.Detalle;
        }

        public void Limpiar()
        {
            MyErrorProvider.Clear();
            IDNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now.Date;
            EstudianteComboBox.Text = string.Empty;
            PresenteCheckBox.Checked = false;
            CantidadTextBox.Text = string.Empty;

            this.Detalle = new List<EstudiantesDetalle>();
            CargarGrid();
        }

        public Asistencias LLenaClase()
        {
            Asistencias asistencia = new Asistencias();

            asistencia.AsistenciaId = Convert.ToInt32(IDNumericUpDown.Value);
            asistencia.Fecha = FechaDateTimePicker.Value.Date;
            asistencia.Asignatura = AsignaturaComboBox.Text;
            asistencia.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
            asistencia.Estudiante = this.Detalle;

            return asistencia;
        }

        public void LlenaCampo(Asistencias asistencia)
        {
            IDNumericUpDown.Value = asistencia.AsistenciaId;
            FechaDateTimePicker.Value = asistencia.Fecha.Date;
            AsignaturaComboBox.Text = asistencia.Asignatura;
            this.Detalle = asistencia.Estudiante;
            CantidadTextBox.Text = Convert.ToString(this.Detalle.Count);

            CargarGrid();
        }

        public bool Validar()
        {
            bool paso = true;

            if (this.Detalle.Count == 0)
            {
                MyErrorProvider.SetError(AgregarEstudianteButton, "El campo Estudiante no puede estar vacio.");
                AgregarEstudianteButton.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(AsignaturaComboBox.Text))
            {
                MyErrorProvider.SetError(AgregarAsignaturaButton, "El campo Asignatura no puede estar vacio.");
                AgregarAsignaturaButton.Focus();
                paso = false;
            }

            return paso;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Asistencias> Metodos = new RepositorioBase<Asistencias>();

            Asistencias asistencia = Metodos.Buscar((int)IDNumericUpDown.Value);
            return asistencia != null;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            AsistenciasBLL Metodos = new AsistenciasBLL();
            bool paso = false;
            Asistencias asistencia;

            if (!Validar())
                return;

            asistencia = LLenaClase();

            if (IDNumericUpDown.Value == 0)
                paso = Metodos.Guardar(asistencia);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una asistencia que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = Metodos.Modificar(asistencia);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asistencias> Metodos = new RepositorioBase<Asistencias>();
            int id;
            int.TryParse(IDNumericUpDown.Text, out id);

            Limpiar();
            if (Metodos.Buscar(id) != null)
            {
                if (Metodos.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("No se puede eliminar una asistencia que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asistencias> Metodos = new RepositorioBase<Asistencias>();
            Asistencias asistencia = new Asistencias();
            int id;
            int.TryParse(IDNumericUpDown.Text, out id);

            Limpiar();

            asistencia = Metodos.Buscar(id);
            if (asistencia != null)
            {
                LlenaCampo(asistencia);
            }
            else
            {
                MessageBox.Show("Asistencia no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarAsistenciaButton_Click(object sender, EventArgs e)
        {
            if (EstudiantesDataGridView.DataSource != null)
                this.Detalle = (List<EstudiantesDetalle>)EstudiantesDataGridView.DataSource;

            this.Detalle.Add(
                new EstudiantesDetalle(
                    estudianteId: 0,
                    asistenciaId: (int)IDNumericUpDown.Value,
                    nombre: EstudianteComboBox.Text,
                    presente: PresenteCheckBox.Checked
                    )
                );

            CargarGrid();
            EstudianteComboBox.Focus();
            EstudianteComboBox.Text = string.Empty;

            CantidadTextBox.Text = EstudiantesDataGridView.Rows.Count.ToString();
        }

        private void RAsistencias_Load(object sender, EventArgs e)
        {
            var ListaEstudiantes = new List<Estudiantes>();
            var ListaAsignaturas = new List<Asignaturas>();

            RepositorioBase<Estudiantes> Metodos = new RepositorioBase<Estudiantes>();
            RepositorioBase<Asignaturas> Metodos2 = new RepositorioBase<Asignaturas>();

            ListaEstudiantes = Metodos.GetList(p => true);
            ListaAsignaturas = Metodos2.GetList(c => true);
      
            foreach (var item in ListaEstudiantes)
            {
                EstudianteComboBox.Items.Add(item.Nombres);
            }

            foreach (var item in ListaAsignaturas)
            {
                AsignaturaComboBox.Items.Add(item.Nombre);
            }
        }
    }
}
