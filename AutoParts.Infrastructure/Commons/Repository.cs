using AutoParts.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Infrastructure.Commons
{
    public class Repository<T> : IRepository<T> where T : class
    {

        public readonly DbContext _dbContext;

        public Repository(DbContext dbcontext)
        {
            _dbContext = dbcontext;

        }
        public void Add(T entidad)
        {

            _dbContext.Set<T>().Add(entidad);
        }

        public void Delete(T entidad)
        {
            _dbContext.Set<T>().Remove(entidad);
        }

        public T Get(Func<T, bool> condicion)
        {
            return _dbContext.Set<T>().FirstOrDefault(condicion);

        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}
