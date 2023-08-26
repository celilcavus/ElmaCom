using ElmaCom.Entity.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaCom.BusinessLayer.Interfaces
{
    public interface ISubCategoryRepository:IBaseRepository<SubCategory>
    {
        SubCategory GetById(int id);
    }
}
