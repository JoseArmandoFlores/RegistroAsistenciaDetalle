using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistenciasDetalle.Entidades
{
    public class Asignaturas
    {
        [Key]
        public int AsignaturaId { get; set; }
        public string Nombre { get; set; }

        public Asignaturas()
        {
        }

        public Asignaturas(int asignaturaId, string nombre)
        {
            AsignaturaId = asignaturaId;
            Nombre = nombre;
        }
    }
}
