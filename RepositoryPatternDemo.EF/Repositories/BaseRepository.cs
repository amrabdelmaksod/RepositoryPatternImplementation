using RepositoryPatternDemo.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternDemo.EF.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        protected ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public T Find(Expression<Func<T, bool>> match)
        {
            return _context.Set<T>().SingleOrDefault(match);
        }

        public IEnumerable<T> GetAll()
        {
           return  _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return  _context.Set<T>().Find(id);
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }


    }
}
