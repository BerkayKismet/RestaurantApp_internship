using RestaurantApp.DataAccessLayer.Abstract;
using RestaurantApp.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly SignalRContext _context;
        public GenericRepository(SignalRContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}