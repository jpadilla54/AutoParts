using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Domain.Commons
{
    public interface IRepository<T> where T : class
    {
        void Add(T entidad);
        void Delete(T entidad);
        T Get(Func<T, bool> condicion);
        IEnumerable<T> GetAll();
        void Save();
    }

}
