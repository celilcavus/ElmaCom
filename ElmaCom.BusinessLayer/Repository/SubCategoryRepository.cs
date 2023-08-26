using ElmaCom.BusinessLayer.Interfaces;
using ElmaCom.DataAccessLayer.Context;
using ElmaCom.Entity.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaCom.BusinessLayer.Repository
{
    public class SubCategoryRepository : BaseRepository<SubCategory>, ISubCategoryRepository
    {
        private ElmaComApplicationContext _context;
        
        public SubCategoryRepository(ElmaComApplicationContext context) : base(context)
        {
            _context = context;
        }

        public SubCategory GetById(int id)
        {
            return _context.Set<SubCategory>().Find(id);
        }
    }
}
