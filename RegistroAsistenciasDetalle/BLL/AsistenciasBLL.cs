using RegistroAsistenciasDetalle.DAL;
using RegistroAsistenciasDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistenciasDetalle.BLL
{
    public class AsistenciasBLL : RepositorioBase<Asistencias>
    {
        public override bool Modificar(Asistencias asistencia)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var Anterior = db.Asistencia.Find(asistencia.AsistenciaId);

                foreach (var Item in Anterior.Estudiante)
                {
                    if (!asistencia.Estudiante.Exists(d => d.EstudianteId == Item.EstudianteId))
                        db.Entry(Item).State = EntityState.Deleted;
                }

                db.Entry(asistencia).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }
    }
}
