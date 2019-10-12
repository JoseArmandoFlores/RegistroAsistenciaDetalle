using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistenciasDetalle.Entidades
{
    public class Estudiantes
    {
        [Key]
        public int EstudiantesId { get; set; }
        public string Nombres { get; set; }

        public Estudiantes()
        {
        }

        public Estudiantes(int estudiantesId, string nombres)
        {
            EstudiantesId = estudiantesId;
            Nombres = nombres;
        }
    }
}
