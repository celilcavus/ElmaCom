using ElmaCom.BusinessLayer.Interfaces;
using ElmaCom.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace ElmaCom.BusinessLayer.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ElmaComApplicationContext _repo = new();


        public void Add(T item)
        {
            _repo.Add(item);
        }

        public void Delete(T item)
        {
            _repo.Remove(item);
        }

        public IEnumerable<T> GetAll(bool isTracking)
        {
            if (isTracking == true)
            {
                return _repo.Set<T>().ToList();
            }
            else
                return _repo.Set<T>().AsNoTracking().ToList();
        }

        public T GetById(int id)
        {
            int? _id = id;
            if (_id.HasValue && _id.Value > 0)
            {
                var value = _repo.Set<T>().Find(_id.Value);
                if (value != null)
                {
                    return value;
                }
                else
                    return null!;
            }
            else
                return null!;
        }

        public int SaveChanges()
        {
            return _repo.SaveChanges();
        }

        public void Update(T item)
        {
            _repo.Update(item);
        }
    }
}
