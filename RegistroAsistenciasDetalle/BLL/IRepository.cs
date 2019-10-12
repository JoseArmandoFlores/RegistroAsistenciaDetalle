using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistenciasDetalle.BLL
{
    public interface IRepository<T> where T : class
    {
        
        bool Guardar(T entidad);
        bool Modificar(T entidad);
        bool Eliminar(int id);
        T Buscar(int id);
        List<T> GetList(Expression<Func<T, bool>> expression);
    }
}
