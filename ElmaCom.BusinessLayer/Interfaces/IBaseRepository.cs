using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaCom.BusinessLayer.Interfaces
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll(bool Track = false);
        void Add(T item);
        void Update(T item);
        void Delete(T item);

      

        void Save();
    }
}
