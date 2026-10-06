using Microsoft.EntityFrameworkCore;
using ThirdGroup_1.Data;
using ThirdGroup_1.Models;

namespace ThirdGroup_1.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T: class
    {
        protected readonly AppDbContext _context;

        private readonly DbSet<T> _dbSet;

        public Repository(AppDbContext db)
        {
            _context = db;
            _dbSet = db.Set<T>();

        }

        public void Create(T obj)
        {
            _dbSet.Add(obj);
         
        }

        public void Delete(T obj)
        {
            _dbSet.Remove(obj);
      
        }

        public IEnumerable<T> GetAll()
        {
          return _dbSet.ToList();
        }

        public T GetById(int Id)
        {
          return _dbSet.Find(Id);
        }

        public void Update(T obj)
        {
          _dbSet.Update(obj);
          
        }
    }
}
