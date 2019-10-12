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
    public partial class rAsignaturas : Form
    {
        public rAsignaturas()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            MyErrorProvider.Clear();
            IDNumericUpDown.Value = 0;
            AsignaturaTextBox.Text = string.Empty;
   
        }

        public Asignaturas LLenaClase()
        {
            Asignaturas asignatura = new Asignaturas();

            asignatura.AsignaturaId = Convert.ToInt32(IDNumericUpDown.Value);
            asignatura.Nombre = AsignaturaTextBox.Text;

            return asignatura;
        }

        public void LlenaCampo(Asignaturas asignatura)
        {
            IDNumericUpDown.Value = asignatura.AsignaturaId;
            AsignaturaTextBox.Text = asignatura.Nombre;
        }

        public bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(AsignaturaTextBox.Text))
            {
                MyErrorProvider.SetError(AsignaturaTextBox, "El campo Asignatura no puede estar vacio.");
                AsignaturaTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Asignaturas> Metodos = new RepositorioBase<Asignaturas>();

            Asignaturas asignatura = Metodos.Buscar((int)IDNumericUpDown.Value);
            return asignatura != null;
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> Metodos = new RepositorioBase<Asignaturas>();
            bool paso = false;
            Asignaturas asignatura;

            if (!Validar())
                return;

            asignatura = LLenaClase();

            if (IDNumericUpDown.Value == 0)
                paso = Metodos.Guardar(asignatura);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una asignatura que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = Metodos.Modificar(asignatura);
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
            RepositorioBase<Asignaturas> Metodos = new RepositorioBase<Asignaturas>();
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
                MessageBox.Show("No se puede eliminar una asignatura que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> Metodos = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura = new Asignaturas();
            int id;
            int.TryParse(IDNumericUpDown.Text, out id);

            Limpiar();

            asignatura = Metodos.Buscar(id);
            if (asignatura != null)
            {
                LlenaCampo(asignatura);
            }
            else
            {
                MessageBox.Show("Asignatura no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
