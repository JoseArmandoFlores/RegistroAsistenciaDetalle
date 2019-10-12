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
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            MyErrorProvider.Clear();
            IDNumericUpDown.Value = 0;
            EstudianteTextBox.Text = string.Empty;

        }

        public Estudiantes LLenaClase()
        {
            Estudiantes estudiante = new Estudiantes();

            estudiante.EstudiantesId = Convert.ToInt32(IDNumericUpDown.Value);
            estudiante.Nombres = EstudianteTextBox.Text;

            return estudiante;
        }

        public void LlenaCampo(Estudiantes estudiante)
        {
            IDNumericUpDown.Value = estudiante.EstudiantesId;
            EstudianteTextBox.Text = estudiante.Nombres;
        }

        public bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(EstudianteTextBox.Text))
            {
                MyErrorProvider.SetError(EstudianteTextBox, "El campo Estudiante no puede estar vacio.");
                EstudianteTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Estudiantes> Metodos = new RepositorioBase<Estudiantes>();

            Estudiantes estudiante = Metodos.Buscar((int)IDNumericUpDown.Value);
            return estudiante != null;
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> Metodos = new RepositorioBase<Estudiantes>();
            bool paso = false;
            Estudiantes estudiante;

            if (!Validar())
                return;

            estudiante = LLenaClase();

            if (IDNumericUpDown.Value == 0)
                paso = Metodos.Guardar(estudiante);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una estudiante que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = Metodos.Modificar(estudiante);
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
            RepositorioBase<Estudiantes> Metodos = new RepositorioBase<Estudiantes>();
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
                MessageBox.Show("No se puede eliminar un estudiante que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> Metodos = new RepositorioBase<Estudiantes>();
            Estudiantes estudiante = new Estudiantes();
            int id;
            int.TryParse(IDNumericUpDown.Text, out id);

            Limpiar();

            estudiante = Metodos.Buscar(id);
            if (estudiante != null)
            {
                LlenaCampo(estudiante);
            }
            else
            {
                MessageBox.Show("Estudiante no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
