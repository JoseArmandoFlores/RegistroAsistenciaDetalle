using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistenciasDetalle.Entidades
{
    public class EstudiantesDetalle
    {
        [Key]
        public int EstudianteId { get; set; }
        public int AsistenciaId { get; set; }
        public string Nombre { get; set; }
        public bool Presente { get; set; }

        public EstudiantesDetalle()
        {
        }

        public EstudiantesDetalle(int estudianteId, int asistenciaId, string nombre, bool presente)
        {
            EstudianteId = estudianteId;
            AsistenciaId = asistenciaId;
            Nombre = nombre;
            Presente = presente;
        }
    }
}
