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

namespace RegistroAsistenciasDetalle.UI.Consultas
{
    public partial class cAsistencias : Form
    {
        public cAsistencias()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Asistencias>();
            RepositorioBase<Asistencias> Metodos = new RepositorioBase<Asistencias>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = Metodos.GetList(p => true);
                        break;
                    case 1://Id
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = Metodos.GetList(p => p.AsistenciaId == id);
                        break;
                    case 2://Asignatura
                        listado = Metodos.GetList(p => p.Asignatura.Contains(CriterioTextBox.Text));
                        break;
                }

                listado = listado.Where(c => c.Fecha.Date <= DesdeDateTimePicker.Value.Date && c.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = Metodos.GetList(p => true);
            }
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
}
