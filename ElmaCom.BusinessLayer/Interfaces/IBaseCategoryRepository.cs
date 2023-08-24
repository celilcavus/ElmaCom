using ElmaCom.BusinessLayer.Repository;
using ElmaCom.Entity.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaCom.BusinessLayer.Interfaces
{
    public interface IBaseCategoryRepository : IBaseRepository<BaseCategory>
    {
        BaseCategory? GetById(int id, bool Track = false);
    }
}
