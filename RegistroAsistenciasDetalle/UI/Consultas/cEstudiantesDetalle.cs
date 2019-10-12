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
    public partial class cEstudiantesDetalle : Form
    {
        public cEstudiantesDetalle()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<EstudiantesDetalle>();
            RepositorioBase<EstudiantesDetalle> Metodos = new RepositorioBase<EstudiantesDetalle>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = Metodos.GetList(p => true);
                        break;
                    case 1://ID
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = Metodos.GetList(p => p.AsistenciaId == id);
                        break;
                    case 2://Nombre
                        listado = Metodos.GetList(p => p.Nombre.Contains(CriterioTextBox.Text));
                        break;
                }
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
