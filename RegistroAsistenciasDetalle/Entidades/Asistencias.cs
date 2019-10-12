using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistenciasDetalle.Entidades
{
    public class Asistencias
    {
        [Key]
        public int AsistenciaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Asignatura { get; set; }
        public int Cantidad { get; set; }
        public virtual List<EstudiantesDetalle> Estudiante { get; set; }
        
        public Asistencias()
        {
        }

        public Asistencias(int asistenciaId, DateTime fecha, string asignatura, List<EstudiantesDetalle> estudiante, int cantidad)
        {
            AsistenciaId = asistenciaId;
            Fecha = fecha;
            Asignatura = asignatura;
            Estudiante = estudiante;
            Cantidad = cantidad;
        }
    }
}
