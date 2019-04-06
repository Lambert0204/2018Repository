using MyShop.Domain;
using System;
using System.Linq;
using Unity;

namespace MyShop.Persistor
{
    public class Repository<T> : IRepository<T> where T : class , IEntity
    {
        [Dependency]
        public Context _context;

        public void Delete(T entity)
        {
            this._context.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return this._context.Set<T>();
        }

        public T GetById(int id)
        {
            return this._context.Set<T>().Single(x => x.Id == id);
        }

        public void Insert(T entity)
        {
            this._context.Set<T>().Add(entity);
        }
    }
}
