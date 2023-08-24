using ElmaCom.BusinessLayer.Interfaces;
using ElmaCom.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaCom.BusinessLayer.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        private ElmaComApplicationContext _context;

        public BaseRepository(ElmaComApplicationContext context)
        {
            _context = context;
        }

        public void Add(T item)
        {
            _context.Set<T>().Add(item);
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
        }

        public IEnumerable<T> GetAll(bool Track = false)
        {
            if (Track)
            {
                return _context.Set<T>().ToList();
            }
            else
                return _context.Set<T>().AsNoTracking().ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T item)
        {
            _context.Set<T>().Update(item);
        }
    }
}
