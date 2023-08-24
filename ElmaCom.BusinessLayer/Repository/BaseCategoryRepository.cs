using ElmaCom.BusinessLayer.Interfaces;
using ElmaCom.DataAccessLayer.Context;
using ElmaCom.Entity.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaCom.BusinessLayer.Repository
{
    public class BaseCategoryRepository : BaseRepository<BaseCategory>, IBaseCategoryRepository
    {
        private ElmaComApplicationContext _context;
        public BaseCategoryRepository(ElmaComApplicationContext context) : base(context)
        {
            _context = context;
        }

        public BaseCategory GetById(int id, bool Track = false)
        {
            int? _id = id;
            if (_id.HasValue && _id.Value > 0)
            {
                if (Track)
                {
                    return _context.Set<BaseCategory>()
                        .AsNoTracking()
                        .Where(x => x.Id.Equals(id))
                        .First();
                }
                else
                    return _context.Set<BaseCategory>()
                        .Where(x => x.Id.Equals(id))
                        .First();
            }
            else
                return default!;
           
        }
    }
}
